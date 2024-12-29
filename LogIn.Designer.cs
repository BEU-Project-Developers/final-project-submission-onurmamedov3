namespace LoginFormExmaple
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            pictureBoxHospital = new PictureBox();
            pictureBoxUser = new PictureBox();
            labelLogIn = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBoxLock = new PictureBox();
            button1 = new Button();
            textUsername = new TextBox();
            textPassword = new TextBox();
            newUserLabelLink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHospital).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLock).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxHospital
            // 
            pictureBoxHospital.Image = (Image)resources.GetObject("pictureBoxHospital.Image");
            pictureBoxHospital.Location = new Point(216, 12);
            pictureBoxHospital.Name = "pictureBoxHospital";
            pictureBoxHospital.Size = new Size(171, 137);
            pictureBoxHospital.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHospital.TabIndex = 0;
            pictureBoxHospital.TabStop = false;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
            pictureBoxUser.Location = new Point(66, 263);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(40, 40);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUser.TabIndex = 1;
            pictureBoxUser.TabStop = false;
            // 
            // labelLogIn
            // 
            labelLogIn.AutoSize = true;
            labelLogIn.Font = new Font("Times New Roman", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogIn.Location = new Point(225, 162);
            labelLogIn.Name = "labelLogIn";
            labelLogIn.Size = new Size(150, 42);
            labelLogIn.TabIndex = 2;
            labelLogIn.Text = "LOG IN";
            labelLogIn.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Location = new Point(89, 309);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 8);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(89, 387);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 8);
            panel2.TabIndex = 5;
            // 
            // pictureBoxLock
            // 
            pictureBoxLock.Image = (Image)resources.GetObject("pictureBoxLock.Image");
            pictureBoxLock.Location = new Point(66, 341);
            pictureBoxLock.Name = "pictureBoxLock";
            pictureBoxLock.Size = new Size(40, 40);
            pictureBoxLock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLock.TabIndex = 4;
            pictureBoxLock.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(66, 446);
            button1.Name = "button1";
            button1.Size = new Size(477, 65);
            button1.TabIndex = 6;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(255, 255, 192);
            textUsername.Location = new Point(121, 263);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.PlaceholderText = "Username";
            textUsername.Size = new Size(422, 35);
            textUsername.TabIndex = 7;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(255, 255, 192);
            textPassword.Location = new Point(121, 346);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(422, 35);
            textPassword.TabIndex = 8;
            // 
            // newUserLabelLink
            // 
            newUserLabelLink.AutoSize = true;
            newUserLabelLink.Location = new Point(182, 551);
            newUserLabelLink.Name = "newUserLabelLink";
            newUserLabelLink.Size = new Size(265, 30);
            newUserLabelLink.TabIndex = 9;
            newUserLabelLink.TabStop = true;
            newUserLabelLink.Text = "New User? Click to sign up!";
            newUserLabelLink.LinkClicked += newUserLabelLink_LinkClicked;
            // 
            // LogIn
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(608, 654);
            Controls.Add(newUserLabelLink);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(pictureBoxLock);
            Controls.Add(panel1);
            Controls.Add(labelLogIn);
            Controls.Add(pictureBoxUser);
            Controls.Add(pictureBoxHospital);
            MaximumSize = new Size(632, 718);
            MinimumSize = new Size(632, 718);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Center Hospital - Log in";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHospital).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxHospital;
        private PictureBox pictureBoxUser;
        private Label labelLogIn;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBoxLock;
        private Button button1;
        private TextBox textUsername;
        private TextBox textPassword;
        private LinkLabel newUserLabelLink;
    }
}
