using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RenameFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSourceFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = false;
            if (!Directory.Exists(txtSourceFolder.Text.Trim()))
            {
                MessageBox.Show("Folder " + txtSourceFolder.Text.Trim() + " does not exist");
                return;
            }

            SearchOption option;
            if (chkSubFolderSearch.Checked)
                option = SearchOption.AllDirectories;
            else
                option = SearchOption.TopDirectoryOnly;


            string sSearchPattern = "*." + txtFromExt.Text.Trim();
            foreach (string fname in Directory.GetFiles(txtSourceFolder.Text.Trim(),sSearchPattern,option))
            {
                string sOutputDir = String.Concat(Path.GetDirectoryName(fname), Path.DirectorySeparatorChar, "output");
                if (!Directory.Exists(sOutputDir))
                {
                    Directory.CreateDirectory(sOutputDir);
                }
                string sNewName = String.Concat(sOutputDir, Path.DirectorySeparatorChar, Path.GetFileNameWithoutExtension(fname),".", txtToExt.Text.Trim());
                Console.WriteLine("Renaming to : " + sNewName);
                try
                {
                    if (File.Exists(sNewName))
                        File.Delete(sNewName);

                    File.Move(fname, sNewName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to rename file : " + fname + " exception = " + ex.Message);
                }
            }

            MessageBox.Show("Done");
            startBtn.Enabled = true;
        }
    }
}