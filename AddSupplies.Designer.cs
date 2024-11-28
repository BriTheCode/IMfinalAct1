namespace DelaCruz_ProjectAct1
{
    partial class AddSupplies
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
            btnAddSupplies = new Button();
            txtSupplyName = new TextBox();
            label2 = new Label();
            txtSupplyAddress = new TextBox();
            label3 = new Label();
            txtSupplyContact = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(31, 54);
            label1.Name = "label1";
            label1.Size = new Size(315, 54);
            label1.TabIndex = 1;
            label1.Text = "Adding Supplies";
            // 
            // btnAddSupplies
            // 
            btnAddSupplies.ForeColor = Color.Black;
            btnAddSupplies.Location = new Point(127, 328);
            btnAddSupplies.Name = "btnAddSupplies";
            btnAddSupplies.Size = new Size(160, 52);
            btnAddSupplies.TabIndex = 6;
            btnAddSupplies.Text = "Add";
            btnAddSupplies.UseVisualStyleBackColor = true;
            btnAddSupplies.Click += btnAddSupplies_Click;
            // 
            // txtSupplyName
            // 
            txtSupplyName.Location = new Point(151, 162);
            txtSupplyName.Name = "txtSupplyName";
            txtSupplyName.Size = new Size(225, 27);
            txtSupplyName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 163);
            label2.Name = "label2";
            label2.Size = new Size(127, 23);
            label2.TabIndex = 4;
            label2.Text = "Supplier Name:";
            // 
            // txtSupplyAddress
            // 
            txtSupplyAddress.Location = new Point(151, 210);
            txtSupplyAddress.Name = "txtSupplyAddress";
            txtSupplyAddress.Size = new Size(225, 27);
            txtSupplyAddress.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 210);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 7;
            label3.Text = "Address:";
            // 
            // txtSupplyContact
            // 
            txtSupplyContact.Location = new Point(151, 255);
            txtSupplyContact.Name = "txtSupplyContact";
            txtSupplyContact.Size = new Size(225, 27);
            txtSupplyContact.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(11, 256);
            label4.Name = "label4";
            label4.Size = new Size(137, 23);
            label4.TabIndex = 9;
            label4.Text = "ContactNumber:";
            // 
            // AddSupplies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(386, 446);
            Controls.Add(txtSupplyContact);
            Controls.Add(label4);
            Controls.Add(txtSupplyAddress);
            Controls.Add(label3);
            Controls.Add(btnAddSupplies);
            Controls.Add(txtSupplyName);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "AddSupplies";
            Text = "AddSupplies";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddSupplies;
        private TextBox txtSupplyName;
        private Label label2;
        private TextBox txtSupplyAddress;
        private Label label3;
        private TextBox txtSupplyContact;
        private Label label4;
    }
}