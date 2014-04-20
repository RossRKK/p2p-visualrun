using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace visualrun
{
    public partial class Form1 : Form
    {
        private string file;
        public Form1()
        {
            string path =System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            InitializeComponent();
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = path;
        }
        private void FileAway() {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            
            if (result == DialogResult.OK) // Test result.
            {

                File.WriteAllText("file.txt", openFileDialog1.FileName);
            }
           Console.Write(result); // <-- For debugging use. 
        }
        private void Run() {
            file = File.ReadAllText("file.txt");
            Process.Start(file);
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FileAway();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Run();
        }
    }
}
