namespace DelaCruz_ProjectAct1
{
    partial class Add_Inventory
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
            btnAddInventory = new Button();
            txtInventoryQuantity = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtInventoryID = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAddInventory
            // 
            btnAddInventory.Location = new Point(126, 298);
            btnAddInventory.Name = "btnAddInventory";
            btnAddInventory.Size = new Size(160, 52);
            btnAddInventory.TabIndex = 7;
            btnAddInventory.Text = "Add";
            btnAddInventory.UseVisualStyleBackColor = true;
            btnAddInventory.Click += btnAddInventory_Click;
            // 
            // txtInventoryQuantity
            // 
            txtInventoryQuantity.Location = new Point(149, 226);
            txtInventoryQuantity.Name = "txtInventoryQuantity";
            txtInventoryQuantity.Size = new Size(225, 27);
            txtInventoryQuantity.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 230);
            label2.Name = "label2";
            label2.Size = new Size(137, 18);
            label2.TabIndex = 5;
            label2.Text = "Inventory Quantity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(30, 52);
            label1.Name = "label1";
            label1.Size = new Size(332, 54);
            label1.TabIndex = 4;
            label1.Text = "Adding Inventory";
            // 
            // txtInventoryID
            // 
            txtInventoryID.Location = new Point(149, 170);
            txtInventoryID.Name = "txtInventoryID";
            txtInventoryID.Size = new Size(225, 27);
            txtInventoryID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 174);
            label3.Name = "label3";
            label3.Size = new Size(66, 18);
            label3.TabIndex = 8;
            label3.Text = "Item ID:";
            // 
            // Add_Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(386, 446);
            Controls.Add(txtInventoryID);
            Controls.Add(label3);
            Controls.Add(btnAddInventory);
            Controls.Add(txtInventoryQuantity);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Add_Inventory";
            Text = "Add_Inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddInventory;
        private TextBox txtInventoryQuantity;
        private Label label2;
        private Label label1;
        private TextBox txtInventoryID;
        private Label label3;
    }
}