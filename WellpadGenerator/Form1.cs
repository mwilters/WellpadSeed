using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using Autodesk.AutoCAD.ApplicationServices;
//using Autodesk.AutoCAD.DatabaseServices;
//using Autodesk.AutoCAD.Runtime;

using AutoCAD;

namespace WellpadGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            //Process the files
            //MessageBox.Show("Processing Template", "Message");
            //Copy files from corresponding folder
            CopyModels(cb_Wellpair.Text, @lbl_OutputFolder.Text);

            //Open each model and move to the correct coordinates
            string x = tb_xCoord.Text;
            string y = tb_yCoord.Text;
            string z = tb_zCoord.Text;

            string rotation = tb_rotation.Text;
           
            ProcessModel(@lbl_OutputFolder.Text, x, y, z, rotation);

            //Process Complete
            AddToLog("Template Preparation, complete");
            MessageBox.Show("Template Preparation, complete", "Message");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                //MessageBox.Show("Folder selected: " + folderBrowserDialog1.SelectedPath, "Message");
                lbl_OutputFolder.Text = folderBrowserDialog1.SelectedPath;    
            }
        }

        public void CopyModels(string wellPair, string targetPath)
        {
            AddToLog("Copying models");

            string srcPath = @"C:\Working\Bigrock\WellpadTemplate\" + wellPair;
            targetPath = @"C:\Working\Bigrock\WellpadTemplate\";
            string[] files = System.IO.Directory.GetFiles(srcPath);

            foreach (string s in files)
            {
                if (System.IO.Path.GetExtension(s).Equals(".dwg"))
                {
                    string fName = s.Substring(srcPath.Length + 1);
                    File.Copy(Path.Combine(srcPath, fName), Path.Combine(targetPath, fName), true);
                }
            }

            AddToLog(files.Count() + " models copied to " + targetPath);
        }

        public void ProcessModel(string folder, string x, string y, string z, string rotation)
        {
            AddToLog("Preparing to move models");

            string[] files = System.IO.Directory.GetFiles(folder);
            foreach (string f in files)
            {
                string strFileName = f;

                if (File.Exists(strFileName))
                {
                    AutoCAD.AcadApplication app;
                    app = new AcadApplication();
                    app.Visible = true;

                    //Open file
                    app.Documents.Open(strFileName);

                    //Do some clean up if require
                    app.ZoomExtents();
                    app.ActiveDocument.SendCommand("_PLAN   ");

                    //Move the model to the specified coordinates
                    app.ActiveDocument.SendCommand("_MOVE _All  0,0,0 " + x + ',' + y + ',' + z + " ");

                    //Rotate model to the specified rotation.  Rotation is based on template datum of x,x,x
                    app.ActiveDocument.SendCommand("_ROTATE _All  0,0,0 " + rotation + " ");

                    AddToLog(strFileName + " moved " + "X: " + x + "Y: " + y + "Z: " + z);

                    //Save and Close
                    app.ActiveDocument.Save();
                    app.ActiveDocument.Close();

                    AddToLog(strFileName + " saved.");

                }
                else
                {
                    MessageBox.Show("File " + strFileName + " does not exist.", "Message");
                }
            }
            
        }

        public void AddToLog(String message)
        {
            int LOG_MAX_LINES = 100;

            // add this line at the top of the log
            lb_Log.Items.Insert(0, message);

            // keep only a few lines in the log
            while (lb_Log.Items.Count > LOG_MAX_LINES)
            {
                lb_Log.Items.RemoveAt(lb_Log.Items.Count - 1);
            }
            }

        private void chk_renModels_CheckedChanged(object sender, EventArgs e)
        {
            //If check box is checked, enable text box for input
            CheckState state = chk_renModels.CheckState;

            //Test for CheckState
            switch(state){
                case CheckState.Checked:
                    tb_modelPrefix.Enabled = true;
                    break;
                case CheckState.Unchecked:
                    tb_modelPrefix.Enabled = false;
                    break;
            }
        }

        }
    }
