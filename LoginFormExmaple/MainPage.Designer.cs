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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            buttonLogOut = new Button();
            labelDoctors = new Label();
            labelPatients = new Label();
            labelInfo = new Label();
            labelDiagnosis = new Label();
            labelCenterHospital = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(378, 336);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Window;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(514, 232);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(458, 175);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Window;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(517, 473);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(209, 95);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.Window;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(749, 473);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(223, 95);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
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
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "MainPage";
            Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
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