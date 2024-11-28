namespace DelaCruz_ProjectAct1
{
    partial class Delivery
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
            lblDashBoard = new Label();
            lblMaintenance = new Label();
            lblSalesMonitoring = new Label();
            lblPointOfSales = new Label();
            lblInventoryMonitoring = new Label();
            lblDelivery = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            gridViewDelivery = new DataGridView();
            btnAddDelivery = new Button();
            btnAddInventory = new Button();
            btnViewDelivery = new Button();
            btnViewInventory = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewDelivery).BeginInit();
            SuspendLayout();
            // 
            // lblDashBoard
            // 
            lblDashBoard.BackColor = Color.ForestGreen;
            lblDashBoard.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashBoard.ForeColor = Color.White;
            lblDashBoard.Location = new Point(-1, -1);
            lblDashBoard.Name = "lblDashBoard";
            lblDashBoard.Size = new Size(297, 747);
            lblDashBoard.TabIndex = 2;
            lblDashBoard.Text = "   DashBoard";
            // 
            // lblMaintenance
            // 
            lblMaintenance.AutoSize = true;
            lblMaintenance.BackColor = Color.ForestGreen;
            lblMaintenance.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaintenance.ForeColor = Color.Black;
            lblMaintenance.Location = new Point(51, 96);
            lblMaintenance.Name = "lblMaintenance";
            lblMaintenance.Size = new Size(203, 34);
            lblMaintenance.TabIndex = 21;
            lblMaintenance.Text = "MAINTENANCE";
            // 
            // lblSalesMonitoring
            // 
            lblSalesMonitoring.AutoSize = true;
            lblSalesMonitoring.BackColor = Color.ForestGreen;
            lblSalesMonitoring.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesMonitoring.ForeColor = SystemColors.ActiveCaptionText;
            lblSalesMonitoring.Location = new Point(51, 429);
            lblSalesMonitoring.Name = "lblSalesMonitoring";
            lblSalesMonitoring.RightToLeft = RightToLeft.No;
            lblSalesMonitoring.Size = new Size(223, 28);
            lblSalesMonitoring.TabIndex = 20;
            lblSalesMonitoring.Text = "SALES MONITORING";
            // 
            // lblPointOfSales
            // 
            lblPointOfSales.AutoSize = true;
            lblPointOfSales.BackColor = Color.ForestGreen;
            lblPointOfSales.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPointOfSales.ForeColor = SystemColors.ActiveCaptionText;
            lblPointOfSales.Location = new Point(63, 338);
            lblPointOfSales.Name = "lblPointOfSales";
            lblPointOfSales.Size = new Size(184, 28);
            lblPointOfSales.TabIndex = 19;
            lblPointOfSales.Text = "POINT OF SALES";
            // 
            // lblInventoryMonitoring
            // 
            lblInventoryMonitoring.AutoSize = true;
            lblInventoryMonitoring.BackColor = Color.ForestGreen;
            lblInventoryMonitoring.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventoryMonitoring.ForeColor = SystemColors.ActiveCaptionText;
            lblInventoryMonitoring.Location = new Point(32, 259);
            lblInventoryMonitoring.Name = "lblInventoryMonitoring";
            lblInventoryMonitoring.Size = new Size(242, 24);
            lblInventoryMonitoring.TabIndex = 18;
            lblInventoryMonitoring.Text = "INVENTORY MONITORING";
            lblInventoryMonitoring.Click += lblInventoryMonitoring_Click;
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.BackColor = Color.ForestGreen;
            lblDelivery.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDelivery.ForeColor = Color.White;
            lblDelivery.Location = new Point(73, 168);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(140, 34);
            lblDelivery.TabIndex = 17;
            lblDelivery.Text = "DELIVERY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(504, 48);
            label1.Name = "label1";
            label1.Size = new Size(380, 46);
            label1.TabIndex = 22;
            label1.Text = "WELCOME TO DELIVERY";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_delivery_100;
            pictureBox1.Location = new Point(890, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // gridViewDelivery
            // 
            gridViewDelivery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewDelivery.Location = new Point(327, 184);
            gridViewDelivery.Name = "gridViewDelivery";
            gridViewDelivery.RowHeadersWidth = 51;
            gridViewDelivery.Size = new Size(782, 394);
            gridViewDelivery.TabIndex = 24;
            // 
            // btnAddDelivery
            // 
            btnAddDelivery.BackColor = Color.LimeGreen;
            btnAddDelivery.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddDelivery.Location = new Point(327, 599);
            btnAddDelivery.Name = "btnAddDelivery";
            btnAddDelivery.Size = new Size(186, 74);
            btnAddDelivery.TabIndex = 25;
            btnAddDelivery.Text = "Add Delivery";
            btnAddDelivery.UseVisualStyleBackColor = false;
            btnAddDelivery.Click += btnAddDelivery_Click;
            // 
            // btnAddInventory
            // 
            btnAddInventory.BackColor = Color.LimeGreen;
            btnAddInventory.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddInventory.Location = new Point(735, 599);
            btnAddInventory.Name = "btnAddInventory";
            btnAddInventory.Size = new Size(184, 74);
            btnAddInventory.TabIndex = 27;
            btnAddInventory.Text = "Add Inventory";
            btnAddInventory.UseVisualStyleBackColor = false;
            btnAddInventory.Click += btnAddInventory_Click;
            // 
            // btnViewDelivery
            // 
            btnViewDelivery.BackColor = Color.LimeGreen;
            btnViewDelivery.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDelivery.Location = new Point(519, 599);
            btnViewDelivery.Name = "btnViewDelivery";
            btnViewDelivery.Size = new Size(184, 74);
            btnViewDelivery.TabIndex = 28;
            btnViewDelivery.Text = "View Delivery";
            btnViewDelivery.UseVisualStyleBackColor = false;
            btnViewDelivery.Click += btnViewDelivery_Click;
            // 
            // btnViewInventory
            // 
            btnViewInventory.BackColor = Color.LimeGreen;
            btnViewInventory.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewInventory.Location = new Point(925, 599);
            btnViewInventory.Name = "btnViewInventory";
            btnViewInventory.Size = new Size(184, 74);
            btnViewInventory.TabIndex = 29;
            btnViewInventory.Text = "View Inventory";
            btnViewInventory.UseVisualStyleBackColor = false;
            btnViewInventory.Click += btnViewInventory_Click;
            // 
            // Delivery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1136, 736);
            Controls.Add(btnViewInventory);
            Controls.Add(btnViewDelivery);
            Controls.Add(btnAddInventory);
            Controls.Add(btnAddDelivery);
            Controls.Add(gridViewDelivery);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblMaintenance);
            Controls.Add(lblSalesMonitoring);
            Controls.Add(lblPointOfSales);
            Controls.Add(lblInventoryMonitoring);
            Controls.Add(lblDelivery);
            Controls.Add(lblDashBoard);
            Name = "Delivery";
            Text = "Delivery";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewDelivery).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashBoard;
        private Label lblMaintenance;
        private Label lblSalesMonitoring;
        private Label lblPointOfSales;
        private Label lblInventoryMonitoring;
        private Label lblDelivery;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView gridViewDelivery;
        private Button btnAddDelivery;
        private Button btnAddInventory;
        private Button btnViewDelivery;
        private Button btnViewInventory;
    }
}