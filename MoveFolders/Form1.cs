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

namespace MoveFolders
{
    public partial class Form1 : Form
    {
        public int completed = 0;
        public int processedcnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string path = pathtext.Text;
                string foldercsv = pagenotxt.Text;
                string target = targettext.Text;
                string[] folderarr = foldercsv.Split(',');
                string incompletefiles = "";
                string completedfiles = "";
                string errormessage = "";
                status.Text = "Initiated";
                int givepagecnt = folderarr.Length;
                noofpages.Text = givepagecnt.ToString();
                this.processedcnt = 0;
                this.completed = 0;
                foreach (string folder in folderarr)
                {
                    try
                    {
                        moveFolder(path, target, completedfiles, folder, givepagecnt);
                    }
                    catch (Exception ex)
                    {
                        incompletefiles = incompletefiles + " " + folder;
                        errormessage = ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void movebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string path = pathtext.Text;
                string foldercsv = pagenotxt.Text;
                string target = targettext.Text;
                string[] folderarr = foldercsv.Split(',');
                string incompletefiles = "";
                string completedfiles = "";
                string errormessage = "";
                status.Text = "Initiated";
                int givepagecnt = folderarr.Length;
                noofpages.Text = givepagecnt.ToString();
                this.processedcnt = 0;
                this.completed = 0;
                foreach (string folder in folderarr)
                {
                    try
                    {
                        moveFiles(path, target, completedfiles, folder, givepagecnt);
                    }
                    catch (Exception ex)
                    {
                        incompletefiles = incompletefiles + " " + folder;
                        errormessage = ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void copybtn_Click(object sender, EventArgs e)
        {
            try
            {
                string path = pathtext.Text;
                string foldercsv = pagenotxt.Text;
                string target = targettext.Text;
                string[] folderarr = foldercsv.Split(',');
                string incompletefiles = "";
                string completedfiles = "";
                string errormessage = "";
                status.Text = "Initiated";
                int givepagecnt = folderarr.Length;
                noofpages.Text = givepagecnt.ToString();
                this.processedcnt = 0;
                this.completed = 0;
                foreach (string folder in folderarr)
                {
                    try
                    {
                        //System.IO.Directory.CreateDirectory(target);
                        //System.IO.Directory.Move(path + "/" + folder, target + "/" + folder);
                        //completedfiles = completedfiles + " " + folder;
                        copyFiles(path, target, completedfiles, folder, givepagecnt);
                    }
                    catch (Exception ex)
                    {
                        incompletefiles = incompletefiles + " " + folder;
                        errormessage = ex.Message;
                    }
                }
                
                //string message = "Competed: \n Completed Files: " + completedfiles + "\n";
                //if (incompletefiles != "")
                //{
                //    message = message + "Error Message" + errormessage + "\n Incomplete Files: " + incompletefiles;
                //}
                //MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private async Task moveFiles(string path, string target, string completedfiles, string folder, int total)
        {
            await Task.Run(() =>
            {
                string[] files = System.IO.Directory.GetFiles(path, folder, SearchOption.AllDirectories);
                this.processedcnt++;
                nooffiles.Invoke((MethodInvoker)(() => nooffiles.Text = this.processedcnt.ToString()));
                foreach (string f in files)
                {
                    // do something
                    System.IO.Directory.CreateDirectory(target);
                    System.IO.Directory.Move(f, target + "/" + folder);
                    completedfiles = completedfiles + " " + folder;
                    this.completed++;
                    movedfiles.Invoke((MethodInvoker)(() => movedfiles.Text = this.completed.ToString()));
                }
                if (this.processedcnt == total)
                {
                    status.Invoke((MethodInvoker)(() => status.Text = "Completed"));
                    string message = "Competed: \n Completed Files: " + completedfiles + "\n";
                    MessageBox.Show(message);
                }
            });
        }
        private async Task copyFiles(string path, string target, string completedfiles, string folder,int total)
        {
            await Task.Run(() =>
            {
                string[] files = System.IO.Directory.GetFiles(path, folder, SearchOption.AllDirectories);
                this.processedcnt++;
                nooffiles.Invoke((MethodInvoker)(() => nooffiles.Text = this.processedcnt.ToString()));
                foreach (string f in files)
            {
                // do something
                System.IO.Directory.CreateDirectory(target);
                System.IO.File.Copy(f, target + "/" + folder);
                completedfiles = completedfiles + " " + folder;
                    this.completed++;
                    movedfiles.Invoke((MethodInvoker)(() => movedfiles.Text = this.completed.ToString()));
            }
                if (this.processedcnt == total)
                {
                    status.Invoke((MethodInvoker)(() => status.Text = "Completed"));
                    string message = "Competed: \n Completed Files: " + completedfiles + "\n";
                    MessageBox.Show(message);
                }
            });
        }
        private async Task moveFolder(string path, string target, string completedfiles, string folder, int total)
        {
            await Task.Run(() =>
            {
                this.processedcnt++;
                nooffiles.Invoke((MethodInvoker)(() => nooffiles.Text = this.processedcnt.ToString()));
                System.IO.Directory.CreateDirectory(target);
                System.IO.Directory.Move(path + "/" + folder, target + "/" + folder);
                    this.completed++;
                    movedfiles.Invoke((MethodInvoker)(() => movedfiles.Text = this.completed.ToString()));
            });
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = pathtext.Text;
                string foldercsv = pagenotxt.Text;
                string target = targettext.Text;
                string[] folderarr = foldercsv.Split(',');
                string incompletefiles = "";
                string completedfiles = "";
                string errormessage = "";
                foreach (string folder in folderarr)
                {
                    try
                    {
                        //System.IO.Directory.CreateDirectory(target);
                        //System.IO.Directory.(path + "/" + folder, target + "/" + folder);
                        Copy(path + "/" + folder, target + "/" + folder);
                        completedfiles = completedfiles + " " + folder;
                    }
                    catch (Exception ex)
                    {
                        incompletefiles = incompletefiles + " " + folder;
                        errormessage = ex.Message;
                    }
                }
                string message = "Competed: \n Completed Files: " + completedfiles + "\n";
                if (incompletefiles != "")
                {
                    message = message + "Error Message" + errormessage + "\n Incomplete Files: " + incompletefiles;
                }
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
