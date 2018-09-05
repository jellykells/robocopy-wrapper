using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RobocopyWrapper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonBrowseSource_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialogSource.ShowDialog() == DialogResult.OK)
            {
                TextBoxSource.Text = FolderBrowserDialogSource.SelectedPath;
            }
        }

        private void FolderBrowserDialogSource_HelpRequest(object sender, EventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            Process roboStartProcess = new Process();
            try
            {
                roboStartProcess.StartInfo.UseShellExecute = true;
                roboStartProcess.StartInfo.FileName = "C:\\Windows\\System32\\cmd.exe";
                roboStartProcess.StartInfo.CreateNoWindow = false;
                roboStartProcess.StartInfo.Arguments = string.Format(@"");
                roboStartProcess.Start();
                roboStartProcess.WaitForExit();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }
        }
    }
}
