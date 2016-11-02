namespace WellpadGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Wellpair = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_xCoord = new System.Windows.Forms.TextBox();
            this.tb_yCoord = new System.Windows.Forms.TextBox();
            this.tb_zCoord = new System.Windows.Forms.TextBox();
            this.tb_rotation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_modelPrefix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_renModels = new System.Windows.Forms.CheckBox();
            this.lb_Log = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_OutputFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 248);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 248);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Wellpair";
            // 
            // cb_Wellpair
            // 
            this.cb_Wellpair.FormattingEnabled = true;
            this.cb_Wellpair.Items.AddRange(new object[] {
            "2Wellpair",
            "3Wellpair",
            "7Wellpair"});
            this.cb_Wellpair.Location = new System.Drawing.Point(117, 27);
            this.cb_Wellpair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Wellpair.Name = "cb_Wellpair";
            this.cb_Wellpair.Size = new System.Drawing.Size(152, 21);
            this.cb_Wellpair.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Z";
            // 
            // tb_xCoord
            // 
            this.tb_xCoord.Location = new System.Drawing.Point(117, 49);
            this.tb_xCoord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_xCoord.Name = "tb_xCoord";
            this.tb_xCoord.Size = new System.Drawing.Size(152, 20);
            this.tb_xCoord.TabIndex = 7;
            // 
            // tb_yCoord
            // 
            this.tb_yCoord.Location = new System.Drawing.Point(117, 70);
            this.tb_yCoord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_yCoord.Name = "tb_yCoord";
            this.tb_yCoord.Size = new System.Drawing.Size(152, 20);
            this.tb_yCoord.TabIndex = 8;
            // 
            // tb_zCoord
            // 
            this.tb_zCoord.Location = new System.Drawing.Point(117, 90);
            this.tb_zCoord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_zCoord.Name = "tb_zCoord";
            this.tb_zCoord.Size = new System.Drawing.Size(152, 20);
            this.tb_zCoord.TabIndex = 9;
            // 
            // tb_rotation
            // 
            this.tb_rotation.Location = new System.Drawing.Point(117, 111);
            this.tb_rotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_rotation.Name = "tb_rotation";
            this.tb_rotation.Size = new System.Drawing.Size(51, 20);
            this.tb_rotation.TabIndex = 11;
            this.tb_rotation.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rotation";
            // 
            // tb_modelPrefix
            // 
            this.tb_modelPrefix.Enabled = false;
            this.tb_modelPrefix.Location = new System.Drawing.Point(117, 174);
            this.tb_modelPrefix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_modelPrefix.Name = "tb_modelPrefix";
            this.tb_modelPrefix.Size = new System.Drawing.Size(102, 20);
            this.tb_modelPrefix.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Model Prefix";
            // 
            // chk_renModels
            // 
            this.chk_renModels.AutoSize = true;
            this.chk_renModels.Location = new System.Drawing.Point(117, 155);
            this.chk_renModels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_renModels.Name = "chk_renModels";
            this.chk_renModels.Size = new System.Drawing.Size(103, 17);
            this.chk_renModels.TabIndex = 14;
            this.chk_renModels.Text = "Rename Models";
            this.chk_renModels.UseVisualStyleBackColor = true;
            this.chk_renModels.CheckedChanged += new System.EventHandler(this.chk_renModels_CheckedChanged);
            // 
            // lb_Log
            // 
            this.lb_Log.FormattingEnabled = true;
            this.lb_Log.Location = new System.Drawing.Point(288, 27);
            this.lb_Log.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_Log.Name = "lb_Log";
            this.lb_Log.Size = new System.Drawing.Size(316, 199);
            this.lb_Log.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 212);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Select Target";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Output Folder";
            // 
            // lbl_OutputFolder
            // 
            this.lbl_OutputFolder.AutoSize = true;
            this.lbl_OutputFolder.Location = new System.Drawing.Point(119, 248);
            this.lbl_OutputFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_OutputFolder.Name = "lbl_OutputFolder";
            this.lbl_OutputFolder.Size = new System.Drawing.Size(0, 13);
            this.lbl_OutputFolder.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 290);
            this.Controls.Add(this.lbl_OutputFolder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lb_Log);
            this.Controls.Add(this.chk_renModels);
            this.Controls.Add(this.tb_modelPrefix);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_rotation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_zCoord);
            this.Controls.Add(this.tb_yCoord);
            this.Controls.Add(this.tb_xCoord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Wellpair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Wellpad Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Wellpair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_xCoord;
        private System.Windows.Forms.TextBox tb_yCoord;
        private System.Windows.Forms.TextBox tb_zCoord;
        private System.Windows.Forms.TextBox tb_rotation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_modelPrefix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_renModels;
        private System.Windows.Forms.ListBox lb_Log;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_OutputFolder;
    }
}

