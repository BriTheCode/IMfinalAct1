namespace DelaCruz_ProjectAct1
{
    partial class Dashboard
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblDelivery = new Label();
            lblInventoryMonitoring = new Label();
            lblPointOfSales = new Label();
            lblSalesMonitoring = new Label();
            gridViewAccounts = new DataGridView();
            btnViewAccounts = new Button();
            lblMaintenance = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewAccounts).BeginInit();
            SuspendLayout();
            // 
            // lblDashBoard
            // 
            lblDashBoard.BackColor = Color.ForestGreen;
            lblDashBoard.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashBoard.ForeColor = Color.White;
            lblDashBoard.Location = new Point(-3, -4);
            lblDashBoard.Name = "lblDashBoard";
            lblDashBoard.Size = new Size(297, 747);
            lblDashBoard.TabIndex = 0;
            lblDashBoard.Text = "   DashBoard";
            lblDashBoard.Click += lblDashBoard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(443, 45);
            label1.Name = "label1";
            label1.Size = new Size(470, 46);
            label1.TabIndex = 1;
            label1.Text = "WELCOME, BRIAN DELA CRUZ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Robinweatherall_Library_Book_64;
            pictureBox1.Location = new Point(910, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.BackColor = Color.ForestGreen;
            lblDelivery.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDelivery.ForeColor = SystemColors.ActiveCaptionText;
            lblDelivery.Location = new Point(76, 170);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(115, 28);
            lblDelivery.TabIndex = 4;
            lblDelivery.Text = "DELIVERY";
            lblDelivery.Click += lblDelivery_Click;
            // 
            // lblInventoryMonitoring
            // 
            lblInventoryMonitoring.AutoSize = true;
            lblInventoryMonitoring.BackColor = Color.ForestGreen;
            lblInventoryMonitoring.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventoryMonitoring.ForeColor = SystemColors.ActiveCaptionText;
            lblInventoryMonitoring.Location = new Point(26, 250);
            lblInventoryMonitoring.Name = "lblInventoryMonitoring";
            lblInventoryMonitoring.Size = new Size(242, 24);
            lblInventoryMonitoring.TabIndex = 5;
            lblInventoryMonitoring.Text = "INVENTORY MONITORING";
            lblInventoryMonitoring.Click += lblInventoryMonitoring_Click;
            // 
            // lblPointOfSales
            // 
            lblPointOfSales.AutoSize = true;
            lblPointOfSales.BackColor = Color.ForestGreen;
            lblPointOfSales.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPointOfSales.ForeColor = SystemColors.ActiveCaptionText;
            lblPointOfSales.Location = new Point(57, 329);
            lblPointOfSales.Name = "lblPointOfSales";
            lblPointOfSales.Size = new Size(184, 28);
            lblPointOfSales.TabIndex = 6;
            lblPointOfSales.Text = "POINT OF SALES";
            lblPointOfSales.Click += lblPointOfSales_Click;
            // 
            // lblSalesMonitoring
            // 
            lblSalesMonitoring.AutoSize = true;
            lblSalesMonitoring.BackColor = Color.ForestGreen;
            lblSalesMonitoring.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesMonitoring.ForeColor = SystemColors.ActiveCaptionText;
            lblSalesMonitoring.Location = new Point(45, 420);
            lblSalesMonitoring.Name = "lblSalesMonitoring";
            lblSalesMonitoring.RightToLeft = RightToLeft.No;
            lblSalesMonitoring.Size = new Size(223, 28);
            lblSalesMonitoring.TabIndex = 7;
            lblSalesMonitoring.Text = "SALES MONITORING";
            lblSalesMonitoring.Click += lblSalesMonitoring_Click;
            // 
            // gridViewAccounts
            // 
            gridViewAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewAccounts.Location = new Point(328, 145);
            gridViewAccounts.Name = "gridViewAccounts";
            gridViewAccounts.RowHeadersWidth = 51;
            gridViewAccounts.Size = new Size(774, 388);
            gridViewAccounts.TabIndex = 8;
            gridViewAccounts.CellContentClick += gridViewAccounts_CellContentClick;
            // 
            // btnViewAccounts
            // 
            btnViewAccounts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViewAccounts.BackColor = Color.LimeGreen;
            btnViewAccounts.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewAccounts.ForeColor = Color.White;
            btnViewAccounts.Location = new Point(598, 566);
            btnViewAccounts.Name = "btnViewAccounts";
            btnViewAccounts.Size = new Size(247, 79);
            btnViewAccounts.TabIndex = 9;
            btnViewAccounts.Text = "View Account";
            btnViewAccounts.UseVisualStyleBackColor = false;
            btnViewAccounts.Click += btnViewAccounts_Click;
            // 
            // lblMaintenance
            // 
            lblMaintenance.AutoSize = true;
            lblMaintenance.BackColor = Color.ForestGreen;
            lblMaintenance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaintenance.ForeColor = SystemColors.ActiveCaptionText;
            lblMaintenance.Location = new Point(57, 102);
            lblMaintenance.Name = "lblMaintenance";
            lblMaintenance.Size = new Size(165, 28);
            lblMaintenance.TabIndex = 10;
            lblMaintenance.Text = "MAINTENANCE";
            lblMaintenance.Click += lblMaintenance_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1136, 736);
            Controls.Add(lblMaintenance);
            Controls.Add(btnViewAccounts);
            Controls.Add(gridViewAccounts);
            Controls.Add(lblSalesMonitoring);
            Controls.Add(lblPointOfSales);
            Controls.Add(lblInventoryMonitoring);
            Controls.Add(lblDelivery);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblDashBoard);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewAccounts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashBoard;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblDelivery;
        private Label lblInventoryMonitoring;
        private Label lblPointOfSales;
        private Label lblSalesMonitoring;
        private DataGridView gridViewAccounts;
        private Button btnViewAccounts;
        private Label lblMaintenance;
    }
}