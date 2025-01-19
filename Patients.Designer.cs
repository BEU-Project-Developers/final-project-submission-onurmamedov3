namespace LoginFormExmaple
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            pictureBox5 = new PictureBox();
            labelCenterHospital = new Label();
            textBoxDoctorContact = new TextBox();
            textBoxPatient = new TextBox();
            textBoxDoctorAge = new TextBox();
            textBoxDoctorAddress = new TextBox();
            buttonPrescription = new Button();
            buttonDSave = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBoxGender = new ComboBox();
            comboBox4 = new ComboBox();
            buttonAdd = new Button();
            textBoxOtherSimpthons = new TextBox();
            buttonBackToMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Window;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(28, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(283, 110);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 32;
            pictureBox5.TabStop = false;
            // 
            // labelCenterHospital
            // 
            labelCenterHospital.BackColor = Color.FromArgb(192, 255, 192);
            labelCenterHospital.Font = new Font("Times New Roman", 27.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCenterHospital.Location = new Point(360, 0);
            labelCenterHospital.Name = "labelCenterHospital";
            labelCenterHospital.Size = new Size(778, 110);
            labelCenterHospital.TabIndex = 31;
            labelCenterHospital.Text = "Center Hospital";
            labelCenterHospital.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxDoctorContact
            // 
            textBoxDoctorContact.BackColor = Color.FromArgb(255, 255, 192);
            textBoxDoctorContact.Location = new Point(360, 206);
            textBoxDoctorContact.Multiline = true;
            textBoxDoctorContact.Name = "textBoxDoctorContact";
            textBoxDoctorContact.PlaceholderText = "Contact";
            textBoxDoctorContact.Size = new Size(283, 50);
            textBoxDoctorContact.TabIndex = 30;
            // 
            // textBoxPatient
            // 
            textBoxPatient.BackColor = Color.FromArgb(255, 255, 192);
            textBoxPatient.Location = new Point(28, 116);
            textBoxPatient.Multiline = true;
            textBoxPatient.Name = "textBoxPatient";
            textBoxPatient.PlaceholderText = "Patient";
            textBoxPatient.Size = new Size(283, 60);
            textBoxPatient.TabIndex = 27;
            // 
            // textBoxDoctorAge
            // 
            textBoxDoctorAge.BackColor = Color.FromArgb(255, 255, 192);
            textBoxDoctorAge.Location = new Point(28, 206);
            textBoxDoctorAge.Name = "textBoxDoctorAge";
            textBoxDoctorAge.PlaceholderText = "Age";
            textBoxDoctorAge.Size = new Size(125, 35);
            textBoxDoctorAge.TabIndex = 26;
            // 
            // textBoxDoctorAddress
            // 
            textBoxDoctorAddress.BackColor = Color.FromArgb(255, 255, 192);
            textBoxDoctorAddress.Location = new Point(28, 326);
            textBoxDoctorAddress.Multiline = true;
            textBoxDoctorAddress.Name = "textBoxDoctorAddress";
            textBoxDoctorAddress.PlaceholderText = "Address";
            textBoxDoctorAddress.Size = new Size(619, 161);
            textBoxDoctorAddress.TabIndex = 24;
            // 
            // buttonPrescription
            // 
            buttonPrescription.BackColor = Color.Green;
            buttonPrescription.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrescription.ForeColor = Color.White;
            buttonPrescription.Location = new Point(28, 584);
            buttonPrescription.Name = "buttonPrescription";
            buttonPrescription.Size = new Size(619, 63);
            buttonPrescription.TabIndex = 22;
            buttonPrescription.Text = "Get the Precription";
            buttonPrescription.UseVisualStyleBackColor = false;
            // 
            // buttonDSave
            // 
            buttonDSave.BackColor = Color.Green;
            buttonDSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDSave.ForeColor = Color.White;
            buttonDSave.Location = new Point(28, 506);
            buttonDSave.Name = "buttonDSave";
            buttonDSave.Size = new Size(619, 63);
            buttonDSave.TabIndex = 21;
            buttonDSave.Text = "Save";
            buttonDSave.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(687, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(422, 393);
            dataGridView1.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 271);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 38);
            comboBox1.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(360, 271);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(282, 38);
            comboBox2.TabIndex = 34;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DisplayMember = "Gender";
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(178, 203);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(133, 38);
            comboBoxGender.TabIndex = 35;
            // 
            // comboBox4
            // 
            comboBox4.ForeColor = Color.FromArgb(255, 255, 192);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(364, 129);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(272, 38);
            comboBox4.TabIndex = 36;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Green;
            buttonAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(968, 127);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(132, 38);
            buttonAdd.TabIndex = 38;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // textBoxOtherSimpthons
            // 
            textBoxOtherSimpthons.BackColor = Color.FromArgb(255, 255, 192);
            textBoxOtherSimpthons.Location = new Point(695, 129);
            textBoxOtherSimpthons.Name = "textBoxOtherSimpthons";
            textBoxOtherSimpthons.Size = new Size(247, 35);
            textBoxOtherSimpthons.TabIndex = 39;
            textBoxOtherSimpthons.Text = "Other Simpthons";
            // 
            // buttonBackToMainMenu
            // 
            buttonBackToMainMenu.BackColor = Color.Black;
            buttonBackToMainMenu.Font = new Font("Times New Roman", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBackToMainMenu.ForeColor = Color.White;
            buttonBackToMainMenu.Location = new Point(954, 614);
            buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            buttonBackToMainMenu.Size = new Size(173, 59);
            buttonBackToMainMenu.TabIndex = 40;
            buttonBackToMainMenu.Text = "Back ";
            buttonBackToMainMenu.UseVisualStyleBackColor = false;
            buttonBackToMainMenu.Click += buttonBackToMainMenu_Click;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1150, 702);
            Controls.Add(buttonBackToMainMenu);
            Controls.Add(textBoxOtherSimpthons);
            Controls.Add(buttonAdd);
            Controls.Add(comboBox4);
            Controls.Add(comboBoxGender);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox5);
            Controls.Add(labelCenterHospital);
            Controls.Add(textBoxDoctorContact);
            Controls.Add(textBoxPatient);
            Controls.Add(textBoxDoctorAge);
            Controls.Add(textBoxDoctorAddress);
            Controls.Add(buttonPrescription);
            Controls.Add(buttonDSave);
            Controls.Add(dataGridView1);
            MaximumSize = new Size(1174, 766);
            MinimumSize = new Size(1174, 766);
            Name = "Patients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patients";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox5;
        private Label labelCenterHospital;
        private TextBox textBoxDoctorContact;
        private TextBox textBoxPatientPassword;
        private TextBox textBoxPatientUsername;
        private TextBox textBoxPatient;
        private TextBox textBoxDoctorAge;
        private TextBox textBoxDoctorYOE;
        private TextBox textBoxDoctorAddress;
        private Button buttonDDelete;
        private Button buttonPrescription;
        private Button buttonDSave;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBoxGender;
        private ComboBox comboBox4;
        private Button buttonAdd;
        private TextBox textBoxOtherSimpthons;
        private Button buttonBackToMainMenu;
    }
}