namespace LoginFormExmaple
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pictureBox1 = new PictureBox();
            labelSignUp = new Label();
            textPassword = new TextBox();
            textUsername = new TextBox();
            buttonSignUp = new Button();
            panel2 = new Panel();
            pictureBoxLock = new PictureBox();
            panel1 = new Panel();
            pictureBoxUser = new PictureBox();
            textConfirmPassword = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(217, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.Font = new Font("Times New Roman", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSignUp.Location = new Point(217, 152);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(167, 42);
            labelSignUp.TabIndex = 3;
            labelSignUp.Text = "SIGN UP";
            labelSignUp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(255, 255, 192);
            textPassword.Location = new Point(109, 348);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(422, 35);
            textPassword.TabIndex = 15;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(255, 255, 192);
            textUsername.Location = new Point(109, 263);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.PlaceholderText = "Username";
            textUsername.Size = new Size(422, 35);
            textUsername.TabIndex = 14;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = SystemColors.ActiveCaptionText;
            buttonSignUp.Cursor = Cursors.Hand;
            buttonSignUp.FlatAppearance.BorderSize = 0;
            buttonSignUp.FlatStyle = FlatStyle.Flat;
            buttonSignUp.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignUp.ForeColor = Color.White;
            buttonSignUp.Location = new Point(66, 548);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(477, 65);
            buttonSignUp.TabIndex = 13;
            buttonSignUp.Text = "SIGN UP";
            buttonSignUp.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(77, 389);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 8);
            panel2.TabIndex = 12;
            // 
            // pictureBoxLock
            // 
            pictureBoxLock.Image = (Image)resources.GetObject("pictureBoxLock.Image");
            pictureBoxLock.Location = new Point(66, 343);
            pictureBoxLock.Name = "pictureBoxLock";
            pictureBoxLock.Size = new Size(40, 40);
            pictureBoxLock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLock.TabIndex = 11;
            pictureBoxLock.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(77, 309);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 8);
            panel1.TabIndex = 10;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
            pictureBoxUser.Location = new Point(66, 263);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(40, 40);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxUser.TabIndex = 9;
            pictureBoxUser.TabStop = false;
            // 
            // textConfirmPassword
            // 
            textConfirmPassword.BackColor = Color.FromArgb(255, 255, 192);
            textConfirmPassword.Location = new Point(109, 433);
            textConfirmPassword.Multiline = true;
            textConfirmPassword.Name = "textConfirmPassword";
            textConfirmPassword.PlaceholderText = "Confirm Password";
            textConfirmPassword.Size = new Size(422, 35);
            textConfirmPassword.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.Location = new Point(77, 474);
            panel3.Name = "panel3";
            panel3.Size = new Size(454, 8);
            panel3.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 428);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(608, 691);
            Controls.Add(textConfirmPassword);
            Controls.Add(panel3);
            Controls.Add(pictureBox2);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(buttonSignUp);
            Controls.Add(panel2);
            Controls.Add(pictureBoxLock);
            Controls.Add(panel1);
            Controls.Add(pictureBoxUser);
            Controls.Add(labelSignUp);
            Controls.Add(pictureBox1);
            Name = "SignUp";
            Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelSignUp;
        private TextBox textPassword;
        private TextBox textUsername;
        private Button buttonSignUp;
        private Panel panel2;
        private PictureBox pictureBoxLock;
        private Panel panel1;
        private PictureBox pictureBoxUser;
        private TextBox textConfirmPassword;
        private Panel panel3;
        private PictureBox pictureBox2;
    }
}