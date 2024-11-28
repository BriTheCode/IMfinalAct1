namespace DelaCruz_ProjectAct1
{
    partial class DeductSales
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
            txtPosItemID = new TextBox();
            label3 = new Label();
            btnAddPos = new Button();
            txtDeductSalesQuantity = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPosItemID
            // 
            txtPosItemID.Location = new Point(151, 182);
            txtPosItemID.Name = "txtPosItemID";
            txtPosItemID.Size = new Size(225, 27);
            txtPosItemID.TabIndex = 15;
            txtPosItemID.TextChanged += txtPosItemID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 186);
            label3.Name = "label3";
            label3.Size = new Size(66, 18);
            label3.TabIndex = 14;
            label3.Text = "Item ID:";
            // 
            // btnAddPos
            // 
            btnAddPos.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPos.Location = new Point(139, 309);
            btnAddPos.Name = "btnAddPos";
            btnAddPos.Size = new Size(160, 52);
            btnAddPos.TabIndex = 13;
            btnAddPos.Text = "Deduct";
            btnAddPos.UseVisualStyleBackColor = true;
            btnAddPos.Click += btnAddPos_Click;
            // 
            // txtDeductSalesQuantity
            // 
            txtDeductSalesQuantity.Location = new Point(151, 238);
            txtDeductSalesQuantity.Name = "txtDeductSalesQuantity";
            txtDeductSalesQuantity.Size = new Size(225, 27);
            txtDeductSalesQuantity.TabIndex = 12;
            txtDeductSalesQuantity.TextChanged += txtDeductSalesQuantity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 244);
            label2.Name = "label2";
            label2.Size = new Size(137, 16);
            label2.TabIndex = 11;
            label2.Text = "Deduct Sales Quantity:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(82, 68);
            label1.Name = "label1";
            label1.Size = new Size(251, 54);
            label1.TabIndex = 10;
            label1.Text = "Deduct Sales";
            // 
            // DeductSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(386, 446);
            Controls.Add(txtPosItemID);
            Controls.Add(label3);
            Controls.Add(btnAddPos);
            Controls.Add(txtDeductSalesQuantity);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeductSales";
            Text = "DeductSales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPosItemID;
        private Label label3;
        private Button btnAddPos;
        private TextBox txtDeductSalesQuantity;
        private Label label2;
        private Label label1;
    }
}