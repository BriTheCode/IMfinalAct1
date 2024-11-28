namespace DelaCruz_ProjectAct1
{
    partial class AddingItems
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
            btnAddItems = new Button();
            txtItemName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCategoryId = new TextBox();
            label3 = new Label();
            txtItemBasePrice = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAddItems
            // 
            btnAddItems.Location = new Point(131, 331);
            btnAddItems.Name = "btnAddItems";
            btnAddItems.Size = new Size(160, 52);
            btnAddItems.TabIndex = 7;
            btnAddItems.Text = "Add";
            btnAddItems.UseVisualStyleBackColor = true;
            btnAddItems.Click += btnAddItems_Click;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(149, 122);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(225, 27);
            txtItemName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 123);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            label2.Text = "Item Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(59, 25);
            label1.Name = "label1";
            label1.Size = new Size(262, 54);
            label1.TabIndex = 4;
            label1.Text = "Adding Items";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(149, 182);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(225, 27);
            txtCategoryId.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 183);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 8;
            label3.Text = "Category ID:";
            // 
            // txtItemBasePrice
            // 
            txtItemBasePrice.Location = new Point(149, 238);
            txtItemBasePrice.Name = "txtItemBasePrice";
            txtItemBasePrice.Size = new Size(225, 27);
            txtItemBasePrice.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(33, 238);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 10;
            label4.Text = "Base Price:";
            // 
            // AddingItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(386, 446);
            Controls.Add(txtItemBasePrice);
            Controls.Add(label4);
            Controls.Add(txtCategoryId);
            Controls.Add(label3);
            Controls.Add(btnAddItems);
            Controls.Add(txtItemName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddingItems";
            Text = "AddingItems";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddItems;
        private TextBox txtItemName;
        private Label label2;
        private Label label1;
        private TextBox txtCategoryId;
        private Label label3;
        private TextBox txtItemBasePrice;
        private Label label4;
    }
}