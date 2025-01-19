namespace LoginFormExmaple
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            pictureBoxDoctors = new PictureBox();
            pictureBoxPatients = new PictureBox();
            pictureBoxDiagnosis = new PictureBox();
            pictureBoxInfo = new PictureBox();
            buttonLogOut = new Button();
            labelDoctors = new Label();
            labelPatients = new Label();
            labelInfo = new Label();
            labelDiagnosis = new Label();
            labelCenterHospital = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDoctors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDiagnosis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDoctors
            // 
            pictureBoxDoctors.Image = (Image)resources.GetObject("pictureBoxDoctors.Image");
            pictureBoxDoctors.Location = new Point(121, 232);
            pictureBoxDoctors.Name = "pictureBoxDoctors";
            pictureBoxDoctors.Size = new Size(378, 336);
            pictureBoxDoctors.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDoctors.TabIndex = 0;
            pictureBoxDoctors.TabStop = false;
            pictureBoxDoctors.Click += pictureBoxDoctors_Click;
            // 
            // pictureBoxPatients
            // 
            pictureBoxPatients.BackColor = SystemColors.Window;
            pictureBoxPatients.Image = (Image)resources.GetObject("pictureBoxPatients.Image");
            pictureBoxPatients.Location = new Point(514, 232);
            pictureBoxPatients.Name = "pictureBoxPatients";
            pictureBoxPatients.Size = new Size(458, 175);
            pictureBoxPatients.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxPatients.TabIndex = 1;
            pictureBoxPatients.TabStop = false;
            pictureBoxPatients.Click += pictureBoxPatients_Click;
            // 
            // pictureBoxDiagnosis
            // 
            pictureBoxDiagnosis.BackColor = SystemColors.Window;
            pictureBoxDiagnosis.Image = (Image)resources.GetObject("pictureBoxDiagnosis.Image");
            pictureBoxDiagnosis.Location = new Point(517, 473);
            pictureBoxDiagnosis.Name = "pictureBoxDiagnosis";
            pictureBoxDiagnosis.Size = new Size(209, 95);
            pictureBoxDiagnosis.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDiagnosis.TabIndex = 2;
            pictureBoxDiagnosis.TabStop = false;
            // 
            // pictureBoxInfo
            // 
            pictureBoxInfo.BackColor = SystemColors.Window;
            pictureBoxInfo.Image = (Image)resources.GetObject("pictureBoxInfo.Image");
            pictureBoxInfo.Location = new Point(749, 473);
            pictureBoxInfo.Name = "pictureBoxInfo";
            pictureBoxInfo.Size = new Size(223, 95);
            pictureBoxInfo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxInfo.TabIndex = 3;
            pictureBoxInfo.TabStop = false;
            pictureBoxInfo.Click += pictureBoxInfo_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = SystemColors.Window;
            buttonLogOut.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogOut.Location = new Point(930, 645);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(173, 49);
            buttonLogOut.TabIndex = 4;
            buttonLogOut.Text = "Log out\r\n\r\n";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // labelDoctors
            // 
            labelDoctors.AutoSize = true;
            labelDoctors.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDoctors.Location = new Point(229, 181);
            labelDoctors.Name = "labelDoctors";
            labelDoctors.Size = new Size(158, 48);
            labelDoctors.TabIndex = 5;
            labelDoctors.Text = "Doctors";
            // 
            // labelPatients
            // 
            labelPatients.AutoSize = true;
            labelPatients.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPatients.Location = new Point(641, 181);
            labelPatients.Name = "labelPatients";
            labelPatients.Size = new Size(164, 48);
            labelPatients.TabIndex = 6;
            labelPatients.Text = "Patients";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.Location = new Point(812, 410);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(93, 48);
            labelInfo.TabIndex = 7;
            labelInfo.Text = "Info";
            // 
            // labelDiagnosis
            // 
            labelDiagnosis.AutoSize = true;
            labelDiagnosis.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDiagnosis.Location = new Point(530, 410);
            labelDiagnosis.Name = "labelDiagnosis";
            labelDiagnosis.Size = new Size(191, 48);
            labelDiagnosis.TabIndex = 8;
            labelDiagnosis.Text = "Diagnosis";
            // 
            // labelCenterHospital
            // 
            labelCenterHospital.Font = new Font("Times New Roman", 27.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCenterHospital.Location = new Point(173, -1);
            labelCenterHospital.Name = "labelCenterHospital";
            labelCenterHospital.Size = new Size(930, 137);
            labelCenterHospital.TabIndex = 9;
            labelCenterHospital.Text = "Center Hospital";
            labelCenterHospital.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Window;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(2, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(171, 137);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1115, 729);
            Controls.Add(pictureBox5);
            Controls.Add(labelCenterHospital);
            Controls.Add(labelDiagnosis);
            Controls.Add(labelInfo);
            Controls.Add(labelPatients);
            Controls.Add(labelDoctors);
            Controls.Add(buttonLogOut);
            Controls.Add(pictureBoxInfo);
            Controls.Add(pictureBoxDiagnosis);
            Controls.Add(pictureBoxPatients);
            Controls.Add(pictureBoxDoctors);
            MaximumSize = new Size(1139, 793);
            MinimumSize = new Size(1139, 793);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDoctors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDiagnosis).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxDoctors;
        private PictureBox pictureBoxPatients;
        private PictureBox pictureBoxDiagnosis;
        private PictureBox pictureBoxInfo;
        private Button button;
        private Button buttonLogOut;
        private Label labelDoctors;
        private Label labelPatients;
        private Label labelInfo;
        private Label labelDiagnosis;
        private Label labelCenterHospital;
        private PictureBox pictureBox5;
    }
}