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
using System.Xml.Linq;

namespace WinForms
{
    public partial class FileIO : Form
    {
        public FileIO()
        {
            InitializeComponent();
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\ranua\Documents\DotNet\FileIO";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder is exists");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\ranua\Documents\DotNet\FileIO\Text.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("File is exists");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // BinaryWriter
                string path = @"C:\Users\ranua\Documents\DotNet\FileIO\emp.dat"; // .dat - data file
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textId.Text));
                bw.Write(textName.Text);
                bw.Write(Convert.ToDouble(textSalary.Text));
                bw.Close();
                fs.Close();// fs always open a file in buffer, once we close fs, file will be stored back to secondary storage
                MessageBox.Show("Data added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                // BinaryWriter
                string path = @"C:\Users\ranua\Documents\DotNet\FileIOemp.dat"; // .dat - data file
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Convert.ToInt32(textId.Text));
                bw.Write(textName.Text);
                bw.Write(Convert.ToDouble(textSalary.Text));
                bw.Close();
                fs.Close();// fs always open a file in buffer, once we close fs, file will be stored back to secondary storage
                MessageBox.Show("Data added to file");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SaveFileDialog saveFileDialog = new SaveFileDialog();
        //        saveFileDialog.DefaultExt = ".txt";
        //        DialogResult result = saveFileDialog.ShowDialog();
        //        StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
        //        if (result == DialogResult.OK)
        //        {
        //            sw.WriteLine(richTextBox1.Text);
        //            sw.Close();
        //        }
        //    }
        //    catch (Exception ex) { }
        //}

        //private void openToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        OpenFileDialog openFileDialog = new OpenFileDialog();
        //        openFileDialog.Filter = "Text document|*.txt|Word|*.docx|All Files|*.*";
        //        DialogResult result = openFileDialog.ShowDialog();
        //        StreamReader sr = new StreamReader(openFileDialog.FileName);
        //        richTextBox1.Text = sr.ReadToEnd();
        //        sr.Close();
        //    }
        //    catch (Exception ex) { }
        //}

    }
}
