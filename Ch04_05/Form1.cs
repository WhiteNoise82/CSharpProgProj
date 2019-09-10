using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ch04_05
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher Watcher;
        private string FolderPath = String.Empty;
        private bool let = false;
        private delegate void DelegateCreateListBoxItem(string EventName, string DateTime, string FilePath);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbbMonitor.Text = "ON";
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            if (fbdFolder.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbdFolder.SelectedPath;
                FolderPath = fbdFolder.SelectedPath;
            }
        }

        private void BtnMonitor_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "") return;

            if (btnMonitor.Text == "모니터 ON")
            {
                btnMonitor.Text = "모니터 OFF";
                btnSave.Enabled = false;

                Watcher = new FileSystemWatcher();
                Watcher.Filter = "*." + txtExtension.Text.ToLower();
                Watcher.Path = Environment.ExpandEnvironmentVariables(FolderPath);

                if (cbbMonitor.Text == "ON")
                {
                    Watcher.IncludeSubdirectories = true;
                }
                else
                {
                    Watcher.IncludeSubdirectories = false;
                }

                Watcher.NotifyFilter =
                    NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                    NotifyFilters.FileName | NotifyFilters.DirectoryName;
                Watcher.Changed += new FileSystemEventHandler(OnChanded);
                Watcher.Created += new FileSystemEventHandler(OnCreate);
                Watcher.Deleted += new FileSystemEventHandler(OnDeleted);
                Watcher.Renamed += new FileSystemEventHandler(OnRenamed);

                Watcher.EnableRaisingEvents = true;
            }
            else
            {
                if (Watcher != null)
                {
                    Watcher.Changed -= new FileSystemEventHandler(OnChanded);
                    Watcher.Created -= new FileSystemEventHandler(OnCreate);
                    Watcher.Deleted -= new FileSystemEventHandler(OnDeleted);
                    Watcher.Renamed -= new FileSystemEventHandler(OnRenamed);

                    Watcher.EnableRaisingEvents = false;
                }
                btnMonitor.Text = "모니터 ON";
                btnSave.Enabled = true;
            }
        }
    }
}
