namespace DelaCruz_ProjectAct1
{
    partial class PointOfSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointOfSales));
            lblDashBoard = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            gridViewPointOfSales = new DataGridView();
            btnAddSales = new Button();
            btnViewSales = new Button();
            lblMaintenance = new Label();
            lblSalesMonitoring = new Label();
            lblPointOfSales = new Label();
            lblInventoryMonitoring = new Label();
            lblDelivery = new Label();
            btnUpdateSales = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewPointOfSales).BeginInit();
            SuspendLayout();
            // 
            // lblDashBoard
            // 
            lblDashBoard.BackColor = Color.ForestGreen;
            lblDashBoard.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashBoard.ForeColor = Color.White;
            lblDashBoard.Location = new Point(1, -4);
            lblDashBoard.Name = "lblDashBoard";
            lblDashBoard.Size = new Size(297, 747);
            lblDashBoard.TabIndex = 2;
            lblDashBoard.Text = "   DashBoard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(933, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(440, 43);
            label1.Name = "label1";
            label1.Size = new Size(487, 46);
            label1.TabIndex = 18;
            label1.Text = "WELCOME TO POINT OF SALES";
            // 
            // gridViewPointOfSales
            // 
            gridViewPointOfSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewPointOfSales.Location = new Point(330, 151);
            gridViewPointOfSales.Name = "gridViewPointOfSales";
            gridViewPointOfSales.RowHeadersWidth = 51;
            gridViewPointOfSales.Size = new Size(794, 403);
            gridViewPointOfSales.TabIndex = 20;
            // 
            // btnAddSales
            // 
            btnAddSales.BackColor = Color.LimeGreen;
            btnAddSales.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSales.ForeColor = Color.White;
            btnAddSales.Location = new Point(348, 591);
            btnAddSales.Name = "btnAddSales";
            btnAddSales.Size = new Size(205, 77);
            btnAddSales.TabIndex = 21;
            btnAddSales.Text = "Add Sales";
            btnAddSales.UseVisualStyleBackColor = false;
            btnAddSales.Click += btnAddSales_Click;
            // 
            // btnViewSales
            // 
            btnViewSales.BackColor = Color.LimeGreen;
            btnViewSales.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewSales.ForeColor = Color.White;
            btnViewSales.Location = new Point(872, 591);
            btnViewSales.Name = "btnViewSales";
            btnViewSales.Size = new Size(205, 77);
            btnViewSales.TabIndex = 22;
            btnViewSales.Text = "View Sales";
            btnViewSales.UseVisualStyleBackColor = false;
            btnViewSales.Click += btnViewSales_Click;
            // 
            // lblMaintenance
            // 
            lblMaintenance.AutoSize = true;
            lblMaintenance.BackColor = Color.ForestGreen;
            lblMaintenance.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaintenance.ForeColor = SystemColors.ActiveCaptionText;
            lblMaintenance.Location = new Point(61, 113);
            lblMaintenance.Name = "lblMaintenance";
            lblMaintenance.Size = new Size(165, 28);
            lblMaintenance.TabIndex = 27;
            lblMaintenance.Text = "MAINTENANCE";
            // 
            // lblSalesMonitoring
            // 
            lblSalesMonitoring.AutoSize = true;
            lblSalesMonitoring.BackColor = Color.ForestGreen;
            lblSalesMonitoring.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesMonitoring.ForeColor = SystemColors.ActiveCaptionText;
            lblSalesMonitoring.Location = new Point(49, 431);
            lblSalesMonitoring.Name = "lblSalesMonitoring";
            lblSalesMonitoring.RightToLeft = RightToLeft.No;
            lblSalesMonitoring.Size = new Size(223, 28);
            lblSalesMonitoring.TabIndex = 26;
            lblSalesMonitoring.Text = "SALES MONITORING";
            // 
            // lblPointOfSales
            // 
            lblPointOfSales.AutoSize = true;
            lblPointOfSales.BackColor = Color.ForestGreen;
            lblPointOfSales.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPointOfSales.ForeColor = Color.White;
            lblPointOfSales.Location = new Point(61, 340);
            lblPointOfSales.Name = "lblPointOfSales";
            lblPointOfSales.Size = new Size(184, 28);
            lblPointOfSales.TabIndex = 25;
            lblPointOfSales.Text = "POINT OF SALES";
            // 
            // lblInventoryMonitoring
            // 
            lblInventoryMonitoring.AutoSize = true;
            lblInventoryMonitoring.BackColor = Color.ForestGreen;
            lblInventoryMonitoring.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInventoryMonitoring.ForeColor = SystemColors.ActiveCaptionText;
            lblInventoryMonitoring.Location = new Point(30, 261);
            lblInventoryMonitoring.Name = "lblInventoryMonitoring";
            lblInventoryMonitoring.Size = new Size(242, 24);
            lblInventoryMonitoring.TabIndex = 24;
            lblInventoryMonitoring.Text = "INVENTORY MONITORING";
            // 
            // lblDelivery
            // 
            lblDelivery.AutoSize = true;
            lblDelivery.BackColor = Color.ForestGreen;
            lblDelivery.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDelivery.ForeColor = SystemColors.ActiveCaptionText;
            lblDelivery.Location = new Point(80, 181);
            lblDelivery.Name = "lblDelivery";
            lblDelivery.Size = new Size(115, 28);
            lblDelivery.TabIndex = 23;
            lblDelivery.Text = "DELIVERY";
            // 
            // btnUpdateSales
            // 
            btnUpdateSales.BackColor = Color.LimeGreen;
            btnUpdateSales.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateSales.ForeColor = Color.White;
            btnUpdateSales.Location = new Point(573, 591);
            btnUpdateSales.Name = "btnUpdateSales";
            btnUpdateSales.Size = new Size(205, 77);
            btnUpdateSales.TabIndex = 28;
            btnUpdateSales.Text = "Deduct Sales";
            btnUpdateSales.UseVisualStyleBackColor = false;
            btnUpdateSales.Click += btnUpdateSales_Click;
            // 
            // PointOfSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1136, 736);
            Controls.Add(btnUpdateSales);
            Controls.Add(lblMaintenance);
            Controls.Add(lblSalesMonitoring);
            Controls.Add(lblPointOfSales);
            Controls.Add(lblInventoryMonitoring);
            Controls.Add(lblDelivery);
            Controls.Add(btnViewSales);
            Controls.Add(btnAddSales);
            Controls.Add(gridViewPointOfSales);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblDashBoard);
            Name = "PointOfSales";
            Text = "PointOfSales";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewPointOfSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashBoard;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView gridViewPointOfSales;
        private Button btnAddSales;
        private Button btnViewSales;
        private Label lblMaintenance;
        private Label lblSalesMonitoring;
        private Label lblPointOfSales;
        private Label lblInventoryMonitoring;
        private Label lblDelivery;
        private Button btnUpdateSales;
    }
}