namespace WinFormsApp1
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtpassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(128, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(118, 138);
            label1.Name = "label1";
            label1.Size = new Size(140, 38);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(66, 210);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(66, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(66, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaGreen;
            panel3.Location = new Point(66, 245);
            panel3.Name = "panel3";
            panel3.Size = new Size(236, 1);
            panel3.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(66, 278);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.Location = new Point(66, 316);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 1);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SeaGreen;
            panel5.Location = new Point(66, 319);
            panel5.Name = "panel5";
            panel5.Size = new Size(236, 1);
            panel5.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(66, 366);
            button1.Name = "button1";
            button1.Size = new Size(236, 33);
            button1.TabIndex = 6;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(66, 335);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 7;
            label2.Text = "Clear Fields";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(166, 416);
            label3.Name = "label3";
            label3.Size = new Size(37, 16);
            label3.TabIndex = 7;
            label3.Text = "Exit";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.SeaGreen;
            txtUserName.Location = new Point(97, 210);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(205, 24);
            txtUserName.TabIndex = 8;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.SeaGreen;
            txtpassword.Location = new Point(97, 278);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(205, 24);
            txtpassword.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(384, 461);
            Controls.Add(txtpassword);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Panel panel5;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtpassword;
    }
}