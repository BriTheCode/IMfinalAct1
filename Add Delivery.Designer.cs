namespace DelaCruz_ProjectAct1
{
    partial class Add_Delivery
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
            btnDeliveryAdd = new Button();
            txtDeliveryItemId = new TextBox();
            lblItemId = new Label();
            label1 = new Label();
            txtDeliveryQuantity = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnDeliveryAdd
            // 
            btnDeliveryAdd.Location = new Point(177, 305);
            btnDeliveryAdd.Name = "btnDeliveryAdd";
            btnDeliveryAdd.Size = new Size(160, 52);
            btnDeliveryAdd.TabIndex = 11;
            btnDeliveryAdd.Text = "Add";
            btnDeliveryAdd.UseVisualStyleBackColor = true;
            btnDeliveryAdd.Click += btnDeliveryAdd_Click;
            // 
            // txtDeliveryItemId
            // 
            txtDeliveryItemId.Location = new Point(177, 166);
            txtDeliveryItemId.Name = "txtDeliveryItemId";
            txtDeliveryItemId.Size = new Size(225, 27);
            txtDeliveryItemId.TabIndex = 10;
            txtDeliveryItemId.TextChanged += txtDeliveryItemId_TextChanged;
            // 
            // lblItemId
            // 
            lblItemId.AutoSize = true;
            lblItemId.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemId.ForeColor = Color.White;
            lblItemId.Location = new Point(48, 167);
            lblItemId.Name = "lblItemId";
            lblItemId.Size = new Size(76, 23);
            lblItemId.TabIndex = 9;
            lblItemId.Text = "Item ID: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(71, 70);
            label1.Name = "label1";
            label1.Size = new Size(307, 54);
            label1.TabIndex = 8;
            label1.Text = "Adding Delivery";
            // 
            // txtDeliveryQuantity
            // 
            txtDeliveryQuantity.Location = new Point(177, 229);
            txtDeliveryQuantity.Name = "txtDeliveryQuantity";
            txtDeliveryQuantity.Size = new Size(225, 27);
            txtDeliveryQuantity.TabIndex = 13;
            txtDeliveryQuantity.TextChanged += txtDeliveryQuantity_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 230);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 12;
            label3.Text = "Quantity:";
            // 
            // Add_Delivery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(438, 450);
            Controls.Add(txtDeliveryQuantity);
            Controls.Add(label3);
            Controls.Add(btnDeliveryAdd);
            Controls.Add(txtDeliveryItemId);
            Controls.Add(lblItemId);
            Controls.Add(label1);
            Name = "Add_Delivery";
            Text = "Add_Delivery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeliveryAdd;
        private TextBox txtDeliveryItemId;
        private Label lblItemId;
        private Label label1;
        private TextBox txtDeliveryQuantity;
        private Label label3;
    }
}