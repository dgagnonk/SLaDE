﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace SLaDE
{

    // Ideas: snippet repository
    // Documentation
    // Colour picker: https://stackoverflow.com/questions/1483928/how-to-read-the-color-of-a-screen-pixel

    public partial class frmMain : Form
    {
        public const string CurrentVersion = "alpha";


        // We run into access issues if the GlobalHwnd is IntPtr,
        // and since we only ever use it as a string it will be 
        // stored as such.
        public string GlobalHwnd = "N/A";

        private string SytheLibExecutable;
        private string DataDirectory;
        private string SyntaxFile;
        private string TessdataDirectory;
        private string BackupDir;

        private string currentScriptFile;

        // The SytheLibProt.exe instance
        private Process proc;
        // The SytheLib thread
        private Task ScriptTask;

        private bool isDirty = false;
        private bool isRunning = false;

        // Used to silence the process listener events when running script
        // based tools
        private bool SilentPipe = false;

        private enum Selector
        {
            SLBitmap, SLColour, BluBitmap, BluColour
        }

        #region Variable Init and Data Checks (Startup)

        private void InitVariables()
        {
            DataDirectory = Environment.CurrentDirectory + "\\data\\";
            SytheLibExecutable = "SytheLibProt.exe";
            currentScriptFile = "";
            SyntaxFile = DataDirectory + "syntax.xml";
            TessdataDirectory = Environment.CurrentDirectory + "\\tessdata\\";
            BackupDir = Environment.CurrentDirectory + "\\backups\\";
        }

        private void CheckFilesAndFolders()
        {
            Startup.CheckDataDir(DataDirectory);
            Startup.CheckSyntaxFile(SyntaxFile);
            Startup.CheckBackupDir(BackupDir);

            // both of the following conditions have to be true for the run button to be enabled
            bool canRun = Startup.CheckSLExecutable(SytheLibExecutable) && Startup.CheckTessdataDir(TessdataDirectory);
            btnRun.Enabled = canRun;
        }

        #endregion

        #region Constructor

        public frmMain()
        {
            InitializeComponent();

            this.FormClosing += FrmMain_FormClosing;

            txtInput.KeyDown += TxtInput_KeyDown;
            txtEditor.TextChanged += TxtEditor_TextChanged;

            InitVariables();
            CheckFilesAndFolders();

            ClearConsole();
            ChangeStatus("Idle.", Color.Blue);

            txtOutput.DeselectAll();

            ApplySettings();

        }





        #endregion

        #region Tool Selectors

        private void RunToolScript(Selector selector)
        {

            if (GlobalHwnd == "N/A")
            {
                var result = MessageBox.Show("You cannot use a colour or bitmap selector without first setting a global window handle. Would you like to set a global window handle now?", "Handle", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes) windowHandleSelectorToolStripMenuItem.PerformClick();
                return;
            }

            switch(selector)
            {
                case Selector.SLColour:
                    File.Delete(Environment.CurrentDirectory + "\\data\\SLColour.dat");
                    File.WriteAllText(
                        Environment.CurrentDirectory + "\\data\\SLColour.dat",
                        "global GUI_PASSED_HWND = " + GlobalHwnd + ";\n" +
                        "SetWindowByHWND(GUI_PASSED_HWND);\n" +
                        "Scrape();\n" +
                        "print(ShowColorPicker());\n" +
                        "//<SCRIPT END>"
                    );
                    currentScriptFile = Environment.CurrentDirectory + "\\data\\SLColour.dat";
                    break;

                case Selector.SLBitmap:
                    File.Delete(Environment.CurrentDirectory + "\\data\\SLBitmap.dat");
                    File.WriteAllText(
                        Environment.CurrentDirectory + "\\data\\SLBitmap.dat",
                        "global GUI_PASSED_HWND = " + GlobalHwnd + ";\n" +
                        "SetWindowByHWND(GUI_PASSED_HWND);\n" +
                        "Scrape();\n" +
                        "print(ShowBitmapPicker());\n" +
                        "//<SCRIPT END>"
                    );
                    currentScriptFile = Environment.CurrentDirectory + "\\data\\SLBitmap.dat";
                    break;

                default:
                    break;
            }

            SilentPipe = true;
            (new Task(() => { StartSytheLibInstance(true); })).Start();
        }



        #endregion

        #region Main toolbar

        private void lblHwnd_Click(object sender, EventArgs e)
        {
            if (GlobalHwnd == "N/A")
            {
                var result = MessageBox.Show("You haven't selected a global window handle to use with the current script. Would you like to set one now?", "Window Handle", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) return;

                // if yes...
                windowHandleSelectorToolStripMenuItem.PerformClick();
                return;
            }
            else
            {
                var result = MessageBox.Show("Would you like to reset the global window handle?", "Window Handle", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result != DialogResult.Yes) GlobalHwnd = "N/A";
            }
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            if (ScriptTask != null && ScriptTask.Status == TaskStatus.Running) { KillSytheLib(); return; }

            currentScriptFile = DataDirectory + Guid.NewGuid().ToString() + ".txt";
            string fullscript = txtEditor.Text + "\n//<SCRIPT END>\n";

            if (GlobalHwnd != "N/A") fullscript = "global GUI_PASSED_HWND = " + GlobalHwnd + ";\n" + fullscript;

            File.WriteAllText(currentScriptFile, fullscript);

            txtInput.Focus();

            btnRun.Image = Properties.Resources.Stop_16px;

            SilentPipe = false;

            ScriptTask = new Task(() => { StartSytheLibInstance(false); });
            ScriptTask.Start();

            ChangeStatus("Running.", Color.Blue);
            isRunning = true;

            await ScriptTask;

            ScriptThreadStatus();
            KillSytheLib();
        }

        private void btnClips_Click(object sender, EventArgs e)
        {
            frmClips frm = new frmClips();
            frm.ShowDialog();
        }

        private void SaveScript()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.Cancel) return;

            File.WriteAllText(sfd.FileName, txtEditor.Text);

            isDirty = false;
        }

        private void OpenScript()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.Cancel) return;

            txtEditor.Text = File.ReadAllText(ofd.FileName);

            isDirty = false;
        }

        private void NewScript()
        {
            isDirty = false;
            txtEditor.Text = "";
        }

        // Return false if user chooses to cancel (do not proceed with action and do not save)
        // Return true if user chooses to continue/save in some capacity, or if document isn't even dirty
        private bool SaveIfDirty()
        {
            if (isDirty)
            {
                var result = MessageBox.Show("This script has been changed. Would you like to save it before continuing?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) SaveScript();
                else if (result == DialogResult.Cancel) return false;
                return true;
            }
            else
                return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveScript();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (SaveIfDirty()) OpenScript();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (SaveIfDirty()) NewScript();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsFormDialog();
        }

        private void ApplySettings()
        {
            tmrBackup.Enabled = Properties.Settings.Default.Backups;
            tmrBackup.Interval = Properties.Settings.Default.BackupMins * 60000;
            tmrMouse.Enabled = Properties.Settings.Default.MouseCoordinates;
        }

        private void SettingsFormDialog()
        {
            frmSettings frm = new frmSettings();
            var result = frm.ShowDialog();

            if (result == DialogResult.OK) ApplySettings();
        }

        #endregion

        #region Form and Editor Events

        private void frmMain_Load(object sender, EventArgs e)
        {
            CheckForUpdates();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (string file in Directory.GetFiles(DataDirectory))
                if (file.EndsWith(".txt")) File.Delete(file);
            

            if (isDirty)
            {
                var result = MessageBox.Show("Would you like to save before closing?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                else if (result == DialogResult.Yes) btnSave.PerformClick();
            }
        }

        private void TxtEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (txtEditor.Text == "") isDirty = false;
            else isDirty = true;
        }

        #endregion

        #region Console

        private void ClearConsole()
        {
            ChangeStatus("Clearing console...", Color.Blue);
            txtOutput.Text = "SYSTEM: Welcome to SLaDE." + Environment.NewLine;
            ChangeStatus("Idle.", Color.Blue);
        }

        private void lnkClearConsole_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearConsole();
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnInput.PerformClick();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            try
            {
                proc.StandardInput.WriteLine(txtInput.Text);
                log("INPUT: " + txtInput.Text);
                txtInput.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChangeStatus("Error sending input.", Color.Red);
            }


        }

        private void ConsoleAutoScroll()
        {
            if (txtOutput.InvokeRequired)
            {
                txtOutput.Invoke(new MethodInvoker(() => 
                {
                    txtOutput.SelectionStart = txtOutput.Text.Length - 1;
                    txtOutput.ScrollToCaret();
                }));
            }
            else
            {
                txtOutput.SelectionStart = txtOutput.Text.Length - 1;
                txtOutput.ScrollToCaret();
            }
        }

        #endregion

        #region Process Events

        private void ManageData(string data)
        {
            if (string.IsNullOrEmpty(data)) return;
            if (string.IsNullOrWhiteSpace(data)) return;
            //if (!data.StartsWith("Load") || !data.StartsWith("\"")) log("SCRIPT: " + data);
            log(data);
            ConsoleAutoScroll();
        }

        private void Proc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (SilentPipe) return;
            ManageData(e.Data);
        }

        private  void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            ManageData(e.Data);
        }

        private void Proc_Exited(object sender, EventArgs e)
        {
            KillSytheLib();
        }

        #endregion

        #region Status and Logging

        private void ScriptThreadStatus()
        {
            if (ScriptTask == null) log("SYSTEM: Script thread has yet to be initialised.");
            else log("SYSTEM: Current script thread status is \"" + ScriptTask.Status.ToString() + "\".");
        }

        private void ChangeStatus(string text, Color color)
        {
            if (tsControls.InvokeRequired)
            {
                tsControls.Invoke(new MethodInvoker(() =>
                {
                    lblStatus.ForeColor = color;
                    lblStatus.Text = "Status: " + text;
                }));
            }
            else
            {
                lblStatus.ForeColor = color;
                lblStatus.Text = "Status: " + text;
            }


        }

        private void log(string text)
        {
            if (txtOutput.InvokeRequired)
                txtOutput.Invoke(new MethodInvoker(() =>
                {
                    txtOutput.Text += (text + Environment.NewLine);
                }));
            else
                txtOutput.Text += (text + Environment.NewLine);

            ConsoleAutoScroll();
        }

        #endregion

        #region Process Interactions

        // Starts an instance of SytheLibProt.exe and maps events and StartInfo properly
        private void StartSytheLibInstance(bool silent)
        {
            if (!silent) ChangeStatus("Spawning SytheLib process...", Color.Blue);

            proc = new Process();
            proc.StartInfo.FileName = SytheLibExecutable;
            proc.StartInfo.Arguments = "\"" + currentScriptFile + "\"";

            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;

            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;

            proc.OutputDataReceived += Proc_OutputDataReceived;
            proc.ErrorDataReceived += Proc_ErrorDataReceived;
            proc.Exited += Proc_Exited;

            try
            {
                bool start = proc.Start();
                isRunning = start;

                if (start)
                {
                    if (!silent) ChangeStatus("Running...", Color.Blue);
                    proc.BeginErrorReadLine();
                    proc.BeginOutputReadLine();
                    proc.WaitForExit();
                }
                else
                {
                    if (!silent) ChangeStatus("Error starting SytheLib. Check console.", Color.Red);
                    if (!silent) log("SYSTEM: Error starting SytheLib.");
                }
            }
            catch (Exception ex)
            {
                log("SYSTEM: " + ex.Message);
            }

        }

        private void KillSytheLib()
        {
            if (!(proc == null || proc.HasExited)) proc.Kill();

            if (!string.IsNullOrEmpty(currentScriptFile) && File.Exists(currentScriptFile)) File.Delete(currentScriptFile);

            btnRun.Image = Properties.Resources.Play_16px;

            ChangeStatus("Idle.", Color.Blue);

            isRunning = false;
        }

        #endregion

        #region Menu

        private void colourSelectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunToolScript(Selector.SLColour);
        }

        private void bitmapSelectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunToolScript(Selector.SLBitmap);
        }

        private void windowHandleSelectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHandleSelector handleSelector = new frmHandleSelector(GlobalHwnd);
            handleSelector.ShowDialog();

            if (handleSelector.DialogResult != DialogResult.OK) return;
            GlobalHwnd = handleSelector.GlobalHwnd;

            lblHwnd.Text = "Global Window Handle: " + handleSelector.GlobalHwnd;
        }

        private void checkScriptTaskStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScriptThreadStatus();
        }

        private void freeIconsByIcons8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Clicking this link will open a web browser. Continue?", "Opening Link", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result != DialogResult.Yes) return;

            Process.Start("http://www.icons8.com/");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsFormDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNew.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpen.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion

        #region Status strip

        private void tmrMouseCoords_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MouseCoordinates) lblCoordinates.Text = Cursor.Position.ToString();
        }

        #endregion

        #region Backups

        private void tmrBackup_Tick(object sender, EventArgs e)
        {
            Startup.CheckBackupDir(BackupDir);

            if (Properties.Settings.Default.Backups)
            {
                string orig_filename = DateTime.Now.ToString();
                string filename = orig_filename;
                int counter = 2;
                while (File.Exists(BackupDir + filename + ".txt"))
                {
                    filename = orig_filename + "_" + counter.ToString();
                    counter++;
                }

                File.WriteAllText(BackupDir + filename.Replace(":", ";") + ".txt", txtEditor.Text);
            }
        }


        #endregion

        #region Updates

        public void CheckForUpdates()
        {

            string updatefile = (new System.Net.WebClient()).DownloadString("http://www.dangk.net/files/updateserver/slade.txt");
            if (updatefile != CurrentVersion)
            {
                MessageBox.Show("There is a new version of SLaDE available for download. The update server isn't ready yet, so please check the Sythe thread for details.");
            }
        }

        #endregion


    }
}
