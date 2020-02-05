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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Red = new System.Windows.Forms.TextBox();
            this.txb_Green = new System.Windows.Forms.TextBox();
            this.txb_Blue = new System.Windows.Forms.TextBox();
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
            this.comboBoxResolutionList.Location = new System.Drawing.Point(7, 69);
            this.comboBoxResolutionList.Name = "comboBoxResolutionList";
            this.comboBoxResolutionList.Size = new System.Drawing.Size(194, 20);
            this.comboBoxResolutionList.TabIndex = 10;
            this.comboBoxResolutionList.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolutionList_SelectedIndexChanged);
            // 
            // comboBoxCameraList
            // 
            this.comboBoxCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCameraList.FormattingEnabled = true;
            this.comboBoxCameraList.Location = new System.Drawing.Point(7, 24);
            this.comboBoxCameraList.Name = "comboBoxCameraList";
            this.comboBoxCameraList.Size = new System.Drawing.Size(194, 20);
            this.comboBoxCameraList.TabIndex = 8;
            this.comboBoxCameraList.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraList_SelectedIndexChanged);
            // 
            // labelCameraTitle
            // 
            this.labelCameraTitle.AutoSize = true;
            this.labelCameraTitle.Location = new System.Drawing.Point(7, 9);
            this.labelCameraTitle.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.labelCameraTitle.Name = "labelCameraTitle";
            this.labelCameraTitle.Size = new System.Drawing.Size(107, 12);
            this.labelCameraTitle.TabIndex = 9;
            this.labelCameraTitle.Text = "Camera selection:";
            // 
            // labelResolutionTitle
            // 
            this.labelResolutionTitle.AutoSize = true;
            this.labelResolutionTitle.Location = new System.Drawing.Point(7, 54);
            this.labelResolutionTitle.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.labelResolutionTitle.Name = "labelResolutionTitle";
            this.labelResolutionTitle.Size = new System.Drawing.Size(131, 12);
            this.labelResolutionTitle.TabIndex = 11;
            this.labelResolutionTitle.Text = "Resolution selection:";
            // 
            // cameraControl
            // 
            this.cameraControl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Location = new System.Drawing.Point(246, 4);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.Size = new System.Drawing.Size(376, 219);
            this.cameraControl.TabIndex = 12;
            // 
            // buttonCameraSettings
            // 
            this.buttonCameraSettings.Location = new System.Drawing.Point(7, 97);
            this.buttonCameraSettings.Name = "buttonCameraSettings";
            this.buttonCameraSettings.Size = new System.Drawing.Size(194, 26);
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
            this.pictureBoxScreenshot.Location = new System.Drawing.Point(245, 235);
            this.pictureBoxScreenshot.Name = "pictureBoxScreenshot";
            this.pictureBoxScreenshot.Size = new System.Drawing.Size(376, 219);
            this.pictureBoxScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScreenshot.TabIndex = 14;
            this.pictureBoxScreenshot.TabStop = false;
            // 
            // buttonSnapshotNextSourceFrame
            // 
            this.buttonSnapshotNextSourceFrame.Location = new System.Drawing.Point(7, 168);
            this.buttonSnapshotNextSourceFrame.Name = "buttonSnapshotNextSourceFrame";
            this.buttonSnapshotNextSourceFrame.Size = new System.Drawing.Size(194, 26);
            this.buttonSnapshotNextSourceFrame.TabIndex = 15;
            this.buttonSnapshotNextSourceFrame.Text = "Snapshot the frame to BMP";
            this.buttonSnapshotNextSourceFrame.UseVisualStyleBackColor = true;
            this.buttonSnapshotNextSourceFrame.Click += new System.EventHandler(this.buttonSnapshotNextSourceFrame_Click);
            // 
            // buttonMixerOnOff
            // 
            this.buttonMixerOnOff.Location = new System.Drawing.Point(7, 132);
            this.buttonMixerOnOff.Name = "buttonMixerOnOff";
            this.buttonMixerOnOff.Size = new System.Drawing.Size(194, 26);
            this.buttonMixerOnOff.TabIndex = 16;
            this.buttonMixerOnOff.Text = "Display camera aperture ";
            this.buttonMixerOnOff.UseVisualStyleBackColor = true;
            this.buttonMixerOnOff.Click += new System.EventHandler(this.buttonMixerOnOff_Click);
            // 
            // buttonSaveBMP
            // 
            this.buttonSaveBMP.Location = new System.Drawing.Point(7, 427);
            this.buttonSaveBMP.Name = "buttonSaveBMP";
            this.buttonSaveBMP.Size = new System.Drawing.Size(194, 26);
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
            this.groupBox1.Location = new System.Drawing.Point(7, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 102);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " RGB value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "B";
            // 
            // txb_Red
            // 
            this.txb_Red.Location = new System.Drawing.Point(62, 21);
            this.txb_Red.Name = "txb_Red";
            this.txb_Red.Size = new System.Drawing.Size(113, 21);
            this.txb_Red.TabIndex = 2;
            // 
            // txb_Green
            // 
            this.txb_Green.Location = new System.Drawing.Point(62, 46);
            this.txb_Green.Name = "txb_Green";
            this.txb_Green.Size = new System.Drawing.Size(113, 21);
            this.txb_Green.TabIndex = 3;
            // 
            // txb_Blue
            // 
            this.txb_Blue.Location = new System.Drawing.Point(62, 72);
            this.txb_Blue.Name = "txb_Blue";
            this.txb_Blue.Size = new System.Drawing.Size(113, 21);
            this.txb_Blue.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
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
            this.groupBox2.Location = new System.Drawing.Point(6, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 102);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lab value";
            // 
            // txb_b
            // 
            this.txb_b.Location = new System.Drawing.Point(62, 72);
            this.txb_b.Name = "txb_b";
            this.txb_b.Size = new System.Drawing.Size(113, 21);
            this.txb_b.TabIndex = 4;
            // 
            // txb_a
            // 
            this.txb_a.Location = new System.Drawing.Point(62, 46);
            this.txb_a.Name = "txb_a";
            this.txb_a.Size = new System.Drawing.Size(113, 21);
            this.txb_a.TabIndex = 3;
            // 
            // txb_L
            // 
            this.txb_L.Location = new System.Drawing.Point(62, 21);
            this.txb_L.Name = "txb_L";
            this.txb_L.Size = new System.Drawing.Size(113, 21);
            this.txb_L.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "L";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 456);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "浊度图像分析软件";
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

