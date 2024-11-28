namespace DelaCruz_ProjectAct1
{
    partial class Add_PointOfSales
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
            btnAddingPos = new Button();
            txtPosSalesQuantity = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtPosID = new TextBox();
            label3 = new Label();
            txtPosTotalAmount = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAddingPos
            // 
            btnAddingPos.BackColor = Color.LimeGreen;
            btnAddingPos.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddingPos.ForeColor = Color.White;
            btnAddingPos.Location = new Point(122, 334);
            btnAddingPos.Name = "btnAddingPos";
            btnAddingPos.Size = new Size(160, 52);
            btnAddingPos.TabIndex = 7;
            btnAddingPos.Text = "Add";
            btnAddingPos.UseVisualStyleBackColor = false;
            btnAddingPos.Click += btnAddingPos_Click;
            // 
            // txtPosSalesQuantity
            // 
            txtPosSalesQuantity.Location = new Point(149, 208);
            txtPosSalesQuantity.Name = "txtPosSalesQuantity";
            txtPosSalesQuantity.Size = new Size(225, 27);
            txtPosSalesQuantity.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 212);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 5;
            label2.Text = "Sales Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(29, 53);
            label1.Name = "label1";
            label1.Size = new Size(345, 46);
            label1.TabIndex = 4;
            label1.Text = "Adding Point Of Sales";
            // 
            // txtPosID
            // 
            txtPosID.Location = new Point(146, 161);
            txtPosID.Name = "txtPosID";
            txtPosID.Size = new Size(225, 27);
            txtPosID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 162);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 8;
            label3.Text = "Item ID: ";
            // 
            // txtPosTotalAmount
            // 
            txtPosTotalAmount.Location = new Point(149, 257);
            txtPosTotalAmount.Name = "txtPosTotalAmount";
            txtPosTotalAmount.Size = new Size(225, 27);
            txtPosTotalAmount.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 257);
            label5.Name = "label5";
            label5.Size = new Size(122, 23);
            label5.TabIndex = 14;
            label5.Text = "Total Amount: ";
            // 
            // Add_PointOfSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(386, 446);
            Controls.Add(txtPosTotalAmount);
            Controls.Add(label5);
            Controls.Add(txtPosID);
            Controls.Add(label3);
            Controls.Add(btnAddingPos);
            Controls.Add(txtPosSalesQuantity);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Add_PointOfSales";
            Text = "Add_PointOfSales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddingPos;
        private TextBox txtPosSalesQuantity;
        private Label label2;
        private Label label1;
        private TextBox txtPosID;
        private Label label3;
        private TextBox txtPosTotalAmount;
        private Label label5;
    }
}