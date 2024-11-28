namespace DelaCruz_ProjectAct1
{
    partial class LoginPage
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
            btnSubmit = new Button();
            UserName = new Label();
            txtUser = new TextBox();
            Password = new Label();
            txtPass = new TextBox();
            Inventory = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnReg = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(279, 312);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(229, 80);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(301, 146);
            UserName.Name = "UserName";
            UserName.Size = new Size(78, 20);
            UserName.TabIndex = 1;
            UserName.Text = "Username:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(405, 143);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(269, 27);
            txtUser.TabIndex = 2;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(301, 210);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(405, 207);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(269, 27);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // Inventory
            // 
            Inventory.BackColor = Color.DarkGreen;
            Inventory.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Inventory.ForeColor = Color.White;
            Inventory.Location = new Point(1, -2);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(231, 485);
            Inventory.TabIndex = 5;
            Inventory.Text = "\r\nWELCOME TO SALES SYSTEM\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGreen;
            pictureBox1.Image = Properties.Resources.icons8_key_256;
            pictureBox1.Location = new Point(1, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 39);
            label1.Name = "label1";
            label1.Size = new Size(164, 53);
            label1.TabIndex = 7;
            label1.Text = "LOG IN";
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.SeaGreen;
            btnReg.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReg.ForeColor = Color.White;
            btnReg.Location = new Point(514, 312);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(229, 80);
            btnReg.TabIndex = 8;
            btnReg.Text = "Register";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(760, 477);
            Controls.Add(btnReg);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(Inventory);
            Controls.Add(txtPass);
            Controls.Add(Password);
            Controls.Add(txtUser);
            Controls.Add(UserName);
            Controls.Add(btnSubmit);
            Name = "LoginPage";
            Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label UserName;
        private TextBox txtUser;
        private Label Password;
        private TextBox txtPass;
        private Label Inventory;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnReg;
    }
}
