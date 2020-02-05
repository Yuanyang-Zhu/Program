namespace cameraD
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxResolutionList = new System.Windows.Forms.ComboBox();
            this.comboBoxCameraList = new System.Windows.Forms.ComboBox();
            this.labelCameraTitle = new System.Windows.Forms.Label();
            this.labelResolutionTitle = new System.Windows.Forms.Label();
            this.cameraControl = new Camera_NET.CameraControl();
            this.buttonCameraSettings = new System.Windows.Forms.Button();
            this.pictureBoxScreenshot = new System.Windows.Forms.PictureBox();
            this.buttonSnapshotNextSourceFrame = new System.Windows.Forms.Button();
            this.buttonMixerOnOff = new System.Windows.Forms.Button();
            this.buttonSaveBMP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_Blue = new System.Windows.Forms.TextBox();
            this.txb_Green = new System.Windows.Forms.TextBox();
            this.txb_Red = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb_b = new System.Windows.Forms.TextBox();
            this.txb_a = new System.Windows.Forms.TextBox();
            this.txb_L = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxResolutionList
            // 
            this.comboBoxResolutionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResolutionList.FormattingEnabled = true;
            this.comboBoxResolutionList.Location = new System.Drawing.Point(9, 86);
            this.comboBoxResolutionList.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxResolutionList.Name = "comboBoxResolutionList";
            this.comboBoxResolutionList.Size = new System.Drawing.Size(257, 23);
            this.comboBoxResolutionList.TabIndex = 10;
            this.comboBoxResolutionList.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolutionList_SelectedIndexChanged);
            // 
            // comboBoxCameraList
            // 
            this.comboBoxCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCameraList.FormattingEnabled = true;
            this.comboBoxCameraList.Location = new System.Drawing.Point(9, 30);
            this.comboBoxCameraList.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCameraList.Name = "comboBoxCameraList";
            this.comboBoxCameraList.Size = new System.Drawing.Size(257, 23);
            this.comboBoxCameraList.TabIndex = 8;
            this.comboBoxCameraList.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraList_SelectedIndexChanged);
            // 
            // labelCameraTitle
            // 
            this.labelCameraTitle.AutoSize = true;
            this.labelCameraTitle.Location = new System.Drawing.Point(9, 11);
            this.labelCameraTitle.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.labelCameraTitle.Name = "labelCameraTitle";
            this.labelCameraTitle.Size = new System.Drawing.Size(143, 15);
            this.labelCameraTitle.TabIndex = 9;
            this.labelCameraTitle.Text = "Camera selection:";
            // 
            // labelResolutionTitle
            // 
            this.labelResolutionTitle.AutoSize = true;
            this.labelResolutionTitle.Location = new System.Drawing.Point(9, 68);
            this.labelResolutionTitle.Margin = new System.Windows.Forms.Padding(4, 9, 4, 0);
            this.labelResolutionTitle.Name = "labelResolutionTitle";
            this.labelResolutionTitle.Size = new System.Drawing.Size(175, 15);
            this.labelResolutionTitle.TabIndex = 11;
            this.labelResolutionTitle.Text = "Resolution selection:";
            // 
            // cameraControl
            // 
            this.cameraControl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Location = new System.Drawing.Point(328, 5);
            this.cameraControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.Size = new System.Drawing.Size(501, 274);
            this.cameraControl.TabIndex = 12;
            // 
            // buttonCameraSettings
            // 
            this.buttonCameraSettings.Location = new System.Drawing.Point(9, 121);
            this.buttonCameraSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCameraSettings.Name = "buttonCameraSettings";
            this.buttonCameraSettings.Size = new System.Drawing.Size(259, 32);
            this.buttonCameraSettings.TabIndex = 13;
            this.buttonCameraSettings.Text = "Camera settings";
            this.buttonCameraSettings.UseVisualStyleBackColor = true;
            this.buttonCameraSettings.Click += new System.EventHandler(this.buttonCameraSettings_Click);
            // 
            // pictureBoxScreenshot
            // 
            this.pictureBoxScreenshot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxScreenshot.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBoxScreenshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxScreenshot.Location = new System.Drawing.Point(327, 294);
            this.pictureBoxScreenshot.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxScreenshot.Name = "pictureBoxScreenshot";
            this.pictureBoxScreenshot.Size = new System.Drawing.Size(501, 273);
            this.pictureBoxScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScreenshot.TabIndex = 14;
            this.pictureBoxScreenshot.TabStop = false;
            // 
            // buttonSnapshotNextSourceFrame
            // 
            this.buttonSnapshotNextSourceFrame.Location = new System.Drawing.Point(9, 210);
            this.buttonSnapshotNextSourceFrame.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSnapshotNextSourceFrame.Name = "buttonSnapshotNextSourceFrame";
            this.buttonSnapshotNextSourceFrame.Size = new System.Drawing.Size(259, 32);
            this.buttonSnapshotNextSourceFrame.TabIndex = 15;
            this.buttonSnapshotNextSourceFrame.Text = "Snapshot the frame to BMP";
            this.buttonSnapshotNextSourceFrame.UseVisualStyleBackColor = true;
            this.buttonSnapshotNextSourceFrame.Click += new System.EventHandler(this.buttonSnapshotNextSourceFrame_Click);
            // 
            // buttonMixerOnOff
            // 
            this.buttonMixerOnOff.Location = new System.Drawing.Point(9, 165);
            this.buttonMixerOnOff.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMixerOnOff.Name = "buttonMixerOnOff";
            this.buttonMixerOnOff.Size = new System.Drawing.Size(259, 32);
            this.buttonMixerOnOff.TabIndex = 16;
            this.buttonMixerOnOff.Text = "Display camera aperture ";
            this.buttonMixerOnOff.UseVisualStyleBackColor = true;
            this.buttonMixerOnOff.Click += new System.EventHandler(this.buttonMixerOnOff_Click);
            // 
            // buttonSaveBMP
            // 
            this.buttonSaveBMP.Location = new System.Drawing.Point(9, 534);
            this.buttonSaveBMP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveBMP.Name = "buttonSaveBMP";
            this.buttonSaveBMP.Size = new System.Drawing.Size(259, 32);
            this.buttonSaveBMP.TabIndex = 17;
            this.buttonSaveBMP.Text = "Save as BMP file";
            this.buttonSaveBMP.UseVisualStyleBackColor = true;
            this.buttonSaveBMP.Click += new System.EventHandler(this.buttonSaveBMP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_Blue);
            this.groupBox1.Controls.Add(this.txb_Green);
            this.groupBox1.Controls.Add(this.txb_Red);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 252);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(261, 128);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " RGB value";
            // 
            // txb_Blue
            // 
            this.txb_Blue.Location = new System.Drawing.Point(83, 90);
            this.txb_Blue.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Blue.Name = "txb_Blue";
            this.txb_Blue.Size = new System.Drawing.Size(149, 25);
            this.txb_Blue.TabIndex = 4;
            // 
            // txb_Green
            // 
            this.txb_Green.Location = new System.Drawing.Point(83, 58);
            this.txb_Green.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Green.Name = "txb_Green";
            this.txb_Green.Size = new System.Drawing.Size(149, 25);
            this.txb_Green.TabIndex = 3;
            // 
            // txb_Red
            // 
            this.txb_Red.Location = new System.Drawing.Point(83, 26);
            this.txb_Red.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Red.Name = "txb_Red";
            this.txb_Red.Size = new System.Drawing.Size(149, 25);
            this.txb_Red.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 482);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "b";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb_b);
            this.groupBox2.Controls.Add(this.txb_a);
            this.groupBox2.Controls.Add(this.txb_L);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(8, 391);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(261, 128);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lab value";
            // 
            // txb_b
            // 
            this.txb_b.Location = new System.Drawing.Point(83, 90);
            this.txb_b.Margin = new System.Windows.Forms.Padding(4);
            this.txb_b.Name = "txb_b";
            this.txb_b.Size = new System.Drawing.Size(149, 25);
            this.txb_b.TabIndex = 4;
            // 
            // txb_a
            // 
            this.txb_a.Location = new System.Drawing.Point(83, 58);
            this.txb_a.Margin = new System.Windows.Forms.Padding(4);
            this.txb_a.Name = "txb_a";
            this.txb_a.Size = new System.Drawing.Size(149, 25);
            this.txb_a.TabIndex = 3;
            // 
            // txb_L
            // 
            this.txb_L.Location = new System.Drawing.Point(83, 26);
            this.txb_L.Margin = new System.Windows.Forms.Padding(4);
            this.txb_L.Name = "txb_L";
            this.txb_L.Size = new System.Drawing.Size(149, 25);
            this.txb_L.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "L";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 570);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSaveBMP);
            this.Controls.Add(this.buttonMixerOnOff);
            this.Controls.Add(this.buttonSnapshotNextSourceFrame);
            this.Controls.Add(this.pictureBoxScreenshot);
            this.Controls.Add(this.buttonCameraSettings);
            this.Controls.Add(this.cameraControl);
            this.Controls.Add(this.comboBoxResolutionList);
            this.Controls.Add(this.comboBoxCameraList);
            this.Controls.Add(this.labelCameraTitle);
            this.Controls.Add(this.labelResolutionTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nephelometric Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxResolutionList;
        private System.Windows.Forms.ComboBox comboBoxCameraList;
        private System.Windows.Forms.Label labelCameraTitle;
        private System.Windows.Forms.Label labelResolutionTitle;
        private Camera_NET.CameraControl cameraControl;
        private System.Windows.Forms.Button buttonCameraSettings;
        private System.Windows.Forms.PictureBox pictureBoxScreenshot;
        private System.Windows.Forms.Button buttonSnapshotNextSourceFrame;
        private System.Windows.Forms.Button buttonMixerOnOff;
        private System.Windows.Forms.Button buttonSaveBMP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_Blue;
        private System.Windows.Forms.TextBox txb_Green;
        private System.Windows.Forms.TextBox txb_Red;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb_b;
        private System.Windows.Forms.TextBox txb_a;
        private System.Windows.Forms.TextBox txb_L;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

