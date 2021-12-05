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

namespace RenameWinForms
{
    public partial class Form1 : Form
    {
        List<string> foundFiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void renameBtn_Click(object sender, EventArgs e)
        {
            this.renameBtn.Enabled = false;
            this.oldNameTB.Enabled = false;
            this.newNameTB.Enabled = false;
            Search();
        }
        private List<string> getFilesInDir(string dirPath)
        {
            List<string> retVal = new List<string>();
            try
            {
                retVal = Directory.GetFiles(dirPath, "*.*", SearchOption.TopDirectoryOnly).ToList();
                foreach (DirectoryInfo d in new DirectoryInfo(dirPath).GetDirectories("*", SearchOption.TopDirectoryOnly))
                {
                    retVal.AddRange(getFilesInDir(d.FullName));
                }
            }
            catch (Exception ex) { }
            return retVal;
        }
        private void FoundFiles()
        {
            if(foundFiles.Count > 0)
            {
                MessageBox.Show(foundFiles[0]);
            }
            else
                MessageBox.Show("Not found!");
        }
        private void Search()
        {
            List<string> files = new List<string>();
            Task.Factory.StartNew(() =>
            {
                if (this.oldNameTB.Text != string.Empty && this.newNameTB.Text != string.Empty)
                {
                    foreach (var item in Environment.GetLogicalDrives())
                    {
                        this.searchLabel.Invoke((MethodInvoker)(() => this.searchLabel.Text = $"Searching in {item}"));
                        files = getFilesInDir(item);
                        this.progressBar1.Invoke((MethodInvoker)(() => this.progressBar1.Value = 0));
                        this.progressBar1.Invoke((MethodInvoker)(() => this.progressBar1.Maximum = files.Count() + 1));
                        this.allFilesLabel.Invoke((MethodInvoker)(() => this.allFilesLabel.Text = $"{this.progressBar1.Maximum} files"));
                        foreach (var elem in files)
                        {
                            this.progressBar1.Invoke((MethodInvoker)(() => this.progressBar1.Value += this.progressBar1.Step));
                            this.currentLabel.Invoke((MethodInvoker)(() => this.currentLabel.Text = $"{this.progressBar1.Value} files"));
                            if (Path.GetFileName(elem) == this.oldNameTB.Text)
                            {
                                foundFiles.Add(elem);
                            }
                            else if (Path.GetFileNameWithoutExtension(elem) == this.oldNameTB.Text)
                            {
                                foundFiles.Add(elem);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fill in all the fields!");
                }
                this.searchLabel.Invoke((MethodInvoker)(() => this.searchLabel.Text = string.Empty));
                this.renameBtn.Invoke((MethodInvoker)(() => this.renameBtn.Enabled = true));
                this.oldNameTB.Invoke((MethodInvoker)(() => this.oldNameTB.Enabled = true));
                this.newNameTB.Invoke((MethodInvoker)(() => this.newNameTB.Enabled = true));
                FoundFiles();
            });
        }
    }
}
