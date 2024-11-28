namespace DelaCruz_ProjectAct1
{
    partial class AddCategories
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
            label2 = new Label();
            txtCategory = new TextBox();
            btnAdding = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(354, 54);
            label1.TabIndex = 0;
            label1.Text = "Adding Categories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 222);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 1;
            label2.Text = "Category Name:";
            label2.Click += label2_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(142, 221);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(225, 27);
            txtCategory.TabIndex = 2;
            txtCategory.TextChanged += txtCategory_TextChanged;
            // 
            // btnAdding
            // 
            btnAdding.Location = new Point(154, 292);
            btnAdding.Name = "btnAdding";
            btnAdding.Size = new Size(160, 52);
            btnAdding.TabIndex = 3;
            btnAdding.Text = "Add";
            btnAdding.UseVisualStyleBackColor = true;
            btnAdding.Click += btnAdding_Click;
            // 
            // AddCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(386, 446);
            Controls.Add(btnAdding);
            Controls.Add(txtCategory);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCategories";
            Text = "AddCategories";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCategory;
        private Button btnAdding;
    }
}