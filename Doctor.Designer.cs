namespace LoginFormExmaple
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            dataGridView1 = new DataGridView();
            buttonDSave = new Button();
            buttonDEdit = new Button();
            buttonDDelete = new Button();
            textBoxDoctorAddress = new TextBox();
            textBoxDoctorYOE = new TextBox();
            textBoxDoctorAge = new TextBox();
            textBoxDoctor = new TextBox();
            textBoxDoctorUsername = new TextBox();
            textBoxDoctorPassword = new TextBox();
            textBoxDoctorContact = new TextBox();
            pictureBox5 = new PictureBox();
            labelCenterHospital = new Label();
            buttonBackToMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(749, 395);
            dataGridView1.TabIndex = 7;
            // 
            // buttonDSave
            // 
            buttonDSave.BackColor = Color.Green;
            buttonDSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDSave.ForeColor = Color.White;
            buttonDSave.Location = new Point(18, 511);
            buttonDSave.Name = "buttonDSave";
            buttonDSave.Size = new Size(141, 63);
            buttonDSave.TabIndex = 8;
            buttonDSave.Text = "Save";
            buttonDSave.UseVisualStyleBackColor = false;
            // 
            // buttonDEdit
            // 
            buttonDEdit.BackColor = Color.Green;
            buttonDEdit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDEdit.ForeColor = Color.White;
            buttonDEdit.Location = new Point(165, 511);
            buttonDEdit.Name = "buttonDEdit";
            buttonDEdit.Size = new Size(136, 63);
            buttonDEdit.TabIndex = 9;
            buttonDEdit.Text = "Edit";
            buttonDEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDDelete
            // 
            buttonDDelete.BackColor = Color.Red;
            buttonDDelete.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDDelete.ForeColor = Color.White;
            buttonDDelete.Location = new Point(18, 580);
            buttonDDelete.Name = "buttonDDelete";
            buttonDDelete.Size = new Size(283, 64);
            buttonDDelete.TabIndex = 10;
            buttonDDelete.Text = "Delete";
            buttonDDelete.UseVisualStyleBackColor = false;
            // 
            // textBoxDoctorAddress
            // 
            textBoxDoctorAddress.BackColor = Color.FromArgb(255, 255, 192);
            textBoxDoctorAddress.Location = new Point(18, 331);
            textBoxDoctorAddress.Multiline = true;
            textBoxDoctorAddress.Name = "textBoxDoctorAddress";
            textBoxDoctorAddress.PlaceholderText = "Address";
            textBoxDoctorAddress.Size = new Size(283, 161);
            textBoxDoctorAddress.TabIndex = 11;
            // 
            // textBoxDoctorYOE
            // 
            textBoxDoctorYOE.BackColor = Color.FromArgb(255, 255, 192);
            textBoxDoctorYOE.Location = new Point(18, 272);
            textBoxDoctorYOE.Name = "textBoxDoctorYOE";
            textBoxDoctorYOE.PlaceholderText = "YOE";
            textBoxDoctorYOE.Size = new Size(123, 35);
            textBoxDoctorYOE.TabIndex = 12;
            // 
            // textBoxDoctorAge
            // 
            textBoxDoctorAge.BackColor = Color.FromArgb(255, 255, 192);
            textBoxDoctorAge.Location = new Point(176, 272);
            textBoxDoctorAge.Name = "textBoxDoctorAge";
            textBoxDoctorAge.PlaceholderText = "Age";
            textBoxDoctorAge.Size = new Size(125, 35);
            textBoxDoctorAge.TabIndex = 13;
            // 
            // textBoxDoctor
            // 
            textBoxDoctor.BackColor = Color.FromArgb(255, 255, 192);
            textBoxDoctor.Location = new Point(18, 121);
            textBoxDoctor.Multiline = true;
            textBoxDoctor.Name = "textBoxDoctor";
            textBoxDoctor.PlaceholderText = "Doctors";
            textBoxDoctor.Size = new Size(283, 60);
            textBoxDoctor.TabIndex = 14;
            // 
            // textBoxDoctorUsername
            // 
            textBoxDoctorUsername.BackColor = Color.FromArgb(255, 255, 192);
            textBoxDoctorUsername.Location = new Point(350, 121);
            textBoxDoctorUsername.Name = "textBoxDoctorUsername";
            textBoxDoctorUsername.PlaceholderText = "Username";
            textBoxDoctorUsername.Size = new Size(358, 35);
            textBoxDoctorUsername.TabIndex = 15;
            // 
            // textBoxDoctorPassword
            // 
            textBoxDoctorPassword.BackColor = Color.FromArgb(255, 255, 192);
            textBoxDoctorPassword.Location = new Point(731, 121);
            textBoxDoctorPassword.Name = "textBoxDoctorPassword";
            textBoxDoctorPassword.PlaceholderText = "Password";
            textBoxDoctorPassword.Size = new Size(368, 35);
            textBoxDoctorPassword.TabIndex = 16;
            // 
            // textBoxDoctorContact
            // 
            textBoxDoctorContact.BackColor = Color.FromArgb(255, 255, 192);
            textBoxDoctorContact.Location = new Point(18, 199);
            textBoxDoctorContact.Multiline = true;
            textBoxDoctorContact.Name = "textBoxDoctorContact";
            textBoxDoctorContact.PlaceholderText = "Contact";
            textBoxDoctorContact.Size = new Size(283, 50);
            textBoxDoctorContact.TabIndex = 17;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Window;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(283, 110);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // labelCenterHospital
            // 
            labelCenterHospital.BackColor = Color.FromArgb(192, 255, 192);
            labelCenterHospital.Font = new Font("Times New Roman", 27.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCenterHospital.Location = new Point(350, 5);
            labelCenterHospital.Name = "labelCenterHospital";
            labelCenterHospital.Size = new Size(778, 110);
            labelCenterHospital.TabIndex = 18;
            labelCenterHospital.Text = "Center Hospital";
            labelCenterHospital.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBackToMainMenu
            // 
            buttonBackToMainMenu.BackColor = Color.Black;
            buttonBackToMainMenu.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBackToMainMenu.ForeColor = Color.White;
            buttonBackToMainMenu.Location = new Point(926, 595);
            buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            buttonBackToMainMenu.Size = new Size(173, 59);
            buttonBackToMainMenu.TabIndex = 20;
            buttonBackToMainMenu.Text = "Back ";
            buttonBackToMainMenu.UseVisualStyleBackColor = false;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1130, 692);
            Controls.Add(buttonBackToMainMenu);
            Controls.Add(pictureBox5);
            Controls.Add(labelCenterHospital);
            Controls.Add(textBoxDoctorContact);
            Controls.Add(textBoxDoctorPassword);
            Controls.Add(textBoxDoctorUsername);
            Controls.Add(textBoxDoctor);
            Controls.Add(textBoxDoctorAge);
            Controls.Add(textBoxDoctorYOE);
            Controls.Add(textBoxDoctorAddress);
            Controls.Add(buttonDDelete);
            Controls.Add(buttonDEdit);
            Controls.Add(buttonDSave);
            Controls.Add(dataGridView1);
            Name = "Doctor";
            Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label textDPassword;
        private Label textDUsername;
        private DataGridView dataGridView1;
        private Button buttonDEdit;
        private Button buttonDSave;
        private Button buttonDDelete;
        private TextBox textBoxDoctorAddress;
        private TextBox textBoxDoctorYOE;
        private TextBox textBoxDoctorAge;
        private TextBox textBoxDoctor;
        private TextBox textBoxDoctorUsername;
        private TextBox textBoxDoctorPassword;
        private TextBox textBoxDoctorContact;
        private PictureBox pictureBox5;
        private Label labelCenterHospital;
        private Button buttonBackToMainMenu;
    }
}