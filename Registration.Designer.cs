namespace DelaCruz_ProjectAct1
{
    partial class Registration
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Inventory = new Label();
            txtPass2 = new TextBox();
            Password = new Label();
            txtEmail = new TextBox();
            UserName = new Label();
            btnRegister = new Button();
            txtUsername = new TextBox();
            label2 = new Label();
            btnLogin2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 42);
            label1.Name = "label1";
            label1.Size = new Size(326, 53);
            label1.TabIndex = 15;
            label1.Text = "REGISTRATION";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGreen;
            pictureBox1.Image = Properties.Resources.icons8_key_256;
            pictureBox1.Location = new Point(-4, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Inventory
            // 
            Inventory.BackColor = Color.DarkGreen;
            Inventory.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inventory.ForeColor = Color.White;
            Inventory.Location = new Point(-4, -2);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(231, 485);
            Inventory.TabIndex = 13;
            Inventory.Text = "\r\nWELCOME TO SALES SYSTEM\r\n";
            // 
            // txtPass2
            // 
            txtPass2.Location = new Point(410, 262);
            txtPass2.Name = "txtPass2";
            txtPass2.Size = new Size(269, 27);
            txtPass2.TabIndex = 12;
            txtPass2.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(306, 265);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 11;
            Password.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(410, 198);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 27);
            txtEmail.TabIndex = 10;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(306, 201);
            UserName.Name = "UserName";
            UserName.Size = new Size(49, 20);
            UserName.TabIndex = 9;
            UserName.Text = "Email:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SeaGreen;
            btnRegister.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(252, 329);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(231, 85);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(410, 142);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(269, 27);
            txtUsername.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 142);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 16;
            label2.Text = "Username:";
            // 
            // btnLogin2
            // 
            btnLogin2.BackColor = Color.SeaGreen;
            btnLogin2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin2.ForeColor = Color.White;
            btnLogin2.Location = new Point(499, 329);
            btnLogin2.Name = "btnLogin2";
            btnLogin2.Size = new Size(231, 85);
            btnLogin2.TabIndex = 18;
            btnLogin2.Text = "Login";
            btnLogin2.UseVisualStyleBackColor = false;
            btnLogin2.Click += btnLogin2_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(760, 477);
            Controls.Add(btnLogin2);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Inventory);
            Controls.Add(txtPass2);
            Controls.Add(Password);
            Controls.Add(txtEmail);
            Controls.Add(UserName);
            Controls.Add(btnRegister);
            Name = "Registration";
            Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label Inventory;
        private TextBox txtPass2;
        private Label Password;
        private TextBox txtEmail;
        private Label UserName;
        private Button btnRegister;
        private TextBox txtUsername;
        private Label label2;
        private Button btnLogin2;
    }
}