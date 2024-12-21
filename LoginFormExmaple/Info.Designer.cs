namespace LoginFormExmaple
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            textBoxHospitalInfo = new TextBox();
            labelAbout = new Label();
            SuspendLayout();
            // 
            // textBoxHospitalInfo
            // 
            textBoxHospitalInfo.BackColor = Color.FromArgb(255, 255, 192);
            textBoxHospitalInfo.Font = new Font("Times New Roman", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxHospitalInfo.Location = new Point(32, 114);
            textBoxHospitalInfo.Multiline = true;
            textBoxHospitalInfo.Name = "textBoxHospitalInfo";
            textBoxHospitalInfo.ReadOnly = true;
            textBoxHospitalInfo.Size = new Size(1040, 475);
            textBoxHospitalInfo.TabIndex = 0;
            textBoxHospitalInfo.Text = resources.GetString("textBoxHospitalInfo.Text");
            // 
            // labelAbout
            // 
            labelAbout.Font = new Font("Times New Roman", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAbout.Location = new Point(285, 41);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(546, 49);
            labelAbout.TabIndex = 1;
            labelAbout.Text = "About  Center Hospital: ";
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1111, 615);
            Controls.Add(labelAbout);
            Controls.Add(textBoxHospitalInfo);
            Name = "Info";
            Text = "Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHospitalInfo;
        private Label labelAbout;
    }
}