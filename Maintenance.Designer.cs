namespace DelaCruz_ProjectAct1
{
    partial class Maintenance
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
            lblDelivery = new Label();
            lblInventoryMonitoring = new Label();
            lblPointOfSales = new Label();
            lblSalesMonitoring = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            gridViewMaintenance = new DataGridView();
            btnCategories = new Button();
            btnSuppliers = new Button();
            btnItems = new Button();
            btnMaintenance = new Button();
            btnViewCategories = new Button();
            lblBack = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMaintenance).BeginInit();
            SuspendLayout();
            // 
            // lblDashBoard
            // 
            lblDashBoard.BackColor = Color.ForestGreen;
            lblDashBoard.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashBoard.ForeColor = Color.White;
            lblDashBoard.Location = new Point(1, -2);
            lblDashBoard.Name = "lblDashBoard";
            lblDashBoard.Size = new Size(297, 747);
            lblDashBoard.TabIndex = 1;
            lblDashBoard.Text = "   DashBoard";
            // 
            // lblMaintenance
            // 
            lblMaintenance.AutoSize = true;
            lblMaintenance.BackColor = Color.ForestGreen;
            lblMaintenance.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaintenance.ForeColor = Color.White;
            lblMaintenance.Location = new Point(41, 96);
            lblMaintenance.Name = "lblMaintenance";
            lblMaintenance.Size = new Size(203, 34);
            lblMaintenance.TabIndex = 16;
            lblMaintenance.Text = "MAINTENANCE";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.BackColor = Color.ForestGreen;
            lblDelivery.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDelivery.ForeColor = SystemColors.ActiveCaptionText;
            lblDelivery.Location = new Point(72, 179);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(115, 28);
            lblDelivery.TabIndex = 12;
            lblDelivery.Text = "DELIVERY";
            // 
            // lblInventoryMonitoring
            // 
            lblInventoryMonitoring.AutoSize = true;
            lblInventoryMonitoring.BackColor = Color.ForestGreen;
            lblInventoryMonitoring.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventoryMonitoring.ForeColor = SystemColors.ActiveCaptionText;
            lblInventoryMonitoring.Location = new Point(22, 259);
            lblInventoryMonitoring.Name = "lblInventoryMonitoring";
            lblInventoryMonitoring.Size = new Size(242, 24);
            lblInventoryMonitoring.TabIndex = 13;
            lblInventoryMonitoring.Text = "INVENTORY MONITORING";
            // 
            // lblPointOfSales
            // 
            lblPointOfSales.AutoSize = true;
            lblPointOfSales.BackColor = Color.ForestGreen;
            lblPointOfSales.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPointOfSales.ForeColor = SystemColors.ActiveCaptionText;
            lblPointOfSales.Location = new Point(53, 338);
            lblPointOfSales.Name = "lblPointOfSales";
            lblPointOfSales.Size = new Size(184, 28);
            lblPointOfSales.TabIndex = 14;
            lblPointOfSales.Text = "POINT OF SALES";
            // 
            // lblSalesMonitoring
            // 
            lblSalesMonitoring.AutoSize = true;
            lblSalesMonitoring.BackColor = Color.ForestGreen;
            lblSalesMonitoring.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesMonitoring.ForeColor = SystemColors.ActiveCaptionText;
            lblSalesMonitoring.Location = new Point(41, 429);
            lblSalesMonitoring.Name = "lblSalesMonitoring";
            lblSalesMonitoring.RightToLeft = RightToLeft.No;
            lblSalesMonitoring.Size = new Size(223, 28);
            lblSalesMonitoring.TabIndex = 15;
            lblSalesMonitoring.Text = "SALES MONITORING";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(463, 53);
            label1.Name = "label1";
            label1.Size = new Size(470, 46);
            label1.TabIndex = 17;
            label1.Text = "WELCOME TO MAINTENANCE";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_tools_100;
            pictureBox1.Location = new Point(948, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // gridViewMaintenance
            // 
            gridViewMaintenance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewMaintenance.Location = new Point(304, 163);
            gridViewMaintenance.Name = "gridViewMaintenance";
            gridViewMaintenance.RowHeadersWidth = 51;
            gridViewMaintenance.Size = new Size(820, 391);
            gridViewMaintenance.TabIndex = 19;
            gridViewMaintenance.CellContentClick += gridViewMaintenance_CellContentClick;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.LimeGreen;
            btnCategories.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(329, 573);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(190, 68);
            btnCategories.TabIndex = 20;
            btnCategories.Text = "Add Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.BackColor = Color.LimeGreen;
            btnSuppliers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(721, 570);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(190, 70);
            btnSuppliers.TabIndex = 21;
            btnSuppliers.Text = "Add Suppliers";
            btnSuppliers.UseVisualStyleBackColor = false;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnItems
            // 
            btnItems.BackColor = Color.LimeGreen;
            btnItems.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnItems.ForeColor = Color.White;
            btnItems.Location = new Point(917, 571);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(190, 69);
            btnItems.TabIndex = 22;
            btnItems.Text = "Add Items";
            btnItems.UseVisualStyleBackColor = false;
            btnItems.Click += btnItems_Click;
            // 
            // btnMaintenance
            // 
            btnMaintenance.BackColor = Color.LimeGreen;
            btnMaintenance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Location = new Point(917, 654);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(191, 70);
            btnMaintenance.TabIndex = 23;
            btnMaintenance.Text = "View Maintenance";
            btnMaintenance.UseVisualStyleBackColor = false;
            btnMaintenance.Click += btnMaintenance_Click;
            // 
            // btnViewCategories
            // 
            btnViewCategories.BackColor = Color.LimeGreen;
            btnViewCategories.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewCategories.ForeColor = Color.White;
            btnViewCategories.Location = new Point(525, 573);
            btnViewCategories.Name = "btnViewCategories";
            btnViewCategories.Size = new Size(190, 68);
            btnViewCategories.TabIndex = 24;
            btnViewCategories.Text = "View Categories";
            btnViewCategories.UseVisualStyleBackColor = false;
            btnViewCategories.Click += btnViewCategories_Click;
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.BackColor = Color.Red;
            lblBack.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBack.Location = new Point(304, 9);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(55, 25);
            lblBack.TabIndex = 25;
            lblBack.Text = "BACK";
            lblBack.Click += lblBack_Click;
            // 
            // Maintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1136, 736);
            Controls.Add(lblBack);
            Controls.Add(btnViewCategories);
            Controls.Add(btnMaintenance);
            Controls.Add(btnItems);
            Controls.Add(btnSuppliers);
            Controls.Add(btnCategories);
            Controls.Add(gridViewMaintenance);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblMaintenance);
            Controls.Add(lblSalesMonitoring);
            Controls.Add(lblPointOfSales);
            Controls.Add(lblInventoryMonitoring);
            Controls.Add(lblDelivery);
            Controls.Add(lblDashBoard);
            Name = "Maintenance";
            Text = "Maintenance";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewMaintenance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashBoard;
        private Label lblMaintenance;
        private Label lblDelivery;
        private Label lblInventoryMonitoring;
        private Label lblPointOfSales;
        private Label lblSalesMonitoring;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView gridViewMaintenance;
        private Button btnCategories;
        private Button btnSuppliers;
        private Button btnItems;
        private Button btnMaintenance;
        private Button btnViewCategories;
        private Label lblBack;
    }
}