namespace P4_Projekt.UserControls
{
    partial class ShoppingUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.chkBoxDiscontinued = new System.Windows.Forms.CheckBox();
            this.lblSplit = new System.Windows.Forms.Label();
            this.tBoxManufacturer = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tBoxPriceMax = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.cBoxCategory = new System.Windows.Forms.ComboBox();
            this.tBoxPriceMin = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.pnlCreateOrder = new System.Windows.Forms.Panel();
            this.pnlTotalPrice = new System.Windows.Forms.Panel();
            this.lblTP = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pnlChartListBox = new System.Windows.Forms.Panel();
            this.btnRealize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.pnlFilter.SuspendLayout();
            this.pnlCreateOrder.SuspendLayout();
            this.pnlTotalPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.DimGray;
            this.pnlFilter.Controls.Add(this.chkBoxDiscontinued);
            this.pnlFilter.Controls.Add(this.lblSplit);
            this.pnlFilter.Controls.Add(this.tBoxManufacturer);
            this.pnlFilter.Controls.Add(this.lblManufacturer);
            this.pnlFilter.Controls.Add(this.lblName);
            this.pnlFilter.Controls.Add(this.tBoxPriceMax);
            this.pnlFilter.Controls.Add(this.lblPrice);
            this.pnlFilter.Controls.Add(this.lblCategory);
            this.pnlFilter.Controls.Add(this.tBoxName);
            this.pnlFilter.Controls.Add(this.cBoxCategory);
            this.pnlFilter.Controls.Add(this.tBoxPriceMin);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(150, 512);
            this.pnlFilter.TabIndex = 0;
            // 
            // chkBoxDiscontinued
            // 
            this.chkBoxDiscontinued.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBoxDiscontinued.AutoSize = true;
            this.chkBoxDiscontinued.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.chkBoxDiscontinued.ForeColor = System.Drawing.Color.White;
            this.chkBoxDiscontinued.Location = new System.Drawing.Point(6, 412);
            this.chkBoxDiscontinued.Name = "chkBoxDiscontinued";
            this.chkBoxDiscontinued.Size = new System.Drawing.Size(141, 18);
            this.chkBoxDiscontinued.TabIndex = 6;
            this.chkBoxDiscontinued.Text = "Include discontinued";
            this.chkBoxDiscontinued.UseVisualStyleBackColor = true;
            // 
            // lblSplit
            // 
            this.lblSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSplit.AutoSize = true;
            this.lblSplit.BackColor = System.Drawing.Color.Transparent;
            this.lblSplit.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblSplit.ForeColor = System.Drawing.Color.Black;
            this.lblSplit.Location = new System.Drawing.Point(63, 157);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(17, 24);
            this.lblSplit.TabIndex = 14;
            this.lblSplit.Text = "-";
            // 
            // tBoxManufacturer
            // 
            this.tBoxManufacturer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.tBoxManufacturer.Location = new System.Drawing.Point(7, 369);
            this.tBoxManufacturer.MaximumSize = new System.Drawing.Size(130, 4);
            this.tBoxManufacturer.MinimumSize = new System.Drawing.Size(130, 4);
            this.tBoxManufacturer.Name = "tBoxManufacturer";
            this.tBoxManufacturer.Size = new System.Drawing.Size(130, 20);
            this.tBoxManufacturer.TabIndex = 5;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblManufacturer.ForeColor = System.Drawing.Color.White;
            this.lblManufacturer.Location = new System.Drawing.Point(3, 304);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblManufacturer.Size = new System.Drawing.Size(120, 39);
            this.lblManufacturer.TabIndex = 12;
            this.lblManufacturer.Text = "Manufacturer: ";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(3, 203);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblName.Size = new System.Drawing.Size(63, 39);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name: ";
            // 
            // tBoxPriceMax
            // 
            this.tBoxPriceMax.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.tBoxPriceMax.Location = new System.Drawing.Point(87, 162);
            this.tBoxPriceMax.Name = "tBoxPriceMax";
            this.tBoxPriceMax.Size = new System.Drawing.Size(50, 20);
            this.tBoxPriceMax.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(3, 102);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblPrice.Size = new System.Drawing.Size(58, 39);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price: ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(3, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lblCategory.Size = new System.Drawing.Size(89, 39);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category: ";
            // 
            // tBoxName
            // 
            this.tBoxName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.tBoxName.Location = new System.Drawing.Point(7, 263);
            this.tBoxName.MaximumSize = new System.Drawing.Size(130, 4);
            this.tBoxName.MinimumSize = new System.Drawing.Size(130, 4);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(130, 20);
            this.tBoxName.TabIndex = 4;
            // 
            // cBoxCategory
            // 
            this.cBoxCategory.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.cBoxCategory.FormattingEnabled = true;
            this.cBoxCategory.Location = new System.Drawing.Point(7, 59);
            this.cBoxCategory.MaximumSize = new System.Drawing.Size(130, 0);
            this.cBoxCategory.MinimumSize = new System.Drawing.Size(130, 0);
            this.cBoxCategory.Name = "cBoxCategory";
            this.cBoxCategory.Size = new System.Drawing.Size(130, 22);
            this.cBoxCategory.TabIndex = 1;
            // 
            // tBoxPriceMin
            // 
            this.tBoxPriceMin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.tBoxPriceMin.Location = new System.Drawing.Point(7, 162);
            this.tBoxPriceMin.Name = "tBoxPriceMin";
            this.tBoxPriceMin.Size = new System.Drawing.Size(50, 20);
            this.tBoxPriceMin.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Orange;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFilter.FlatAppearance.BorderSize = 3;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(0, 452);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 60);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // pnlCreateOrder
            // 
            this.pnlCreateOrder.BackColor = System.Drawing.Color.White;
            this.pnlCreateOrder.Controls.Add(this.pnlTotalPrice);
            this.pnlCreateOrder.Controls.Add(this.pnlChartListBox);
            this.pnlCreateOrder.Controls.Add(this.btnRealize);
            this.pnlCreateOrder.Controls.Add(this.btnCancel);
            this.pnlCreateOrder.Controls.Add(this.btnCreateOrder);
            this.pnlCreateOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCreateOrder.Location = new System.Drawing.Point(150, 0);
            this.pnlCreateOrder.MaximumSize = new System.Drawing.Size(125, 0);
            this.pnlCreateOrder.Name = "pnlCreateOrder";
            this.pnlCreateOrder.Size = new System.Drawing.Size(125, 512);
            this.pnlCreateOrder.TabIndex = 1;
            // 
            // pnlTotalPrice
            // 
            this.pnlTotalPrice.Controls.Add(this.lblTP);
            this.pnlTotalPrice.Controls.Add(this.lblTotalPrice);
            this.pnlTotalPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotalPrice.Location = new System.Drawing.Point(0, 339);
            this.pnlTotalPrice.Name = "pnlTotalPrice";
            this.pnlTotalPrice.Size = new System.Drawing.Size(125, 53);
            this.pnlTotalPrice.TabIndex = 13;
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTP.Location = new System.Drawing.Point(0, 15);
            this.lblTP.Name = "lblTP";
            this.lblTP.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTP.Size = new System.Drawing.Size(100, 19);
            this.lblTP.TabIndex = 14;
            this.lblTP.Text = "Total Price:";
            this.lblTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.Location = new System.Drawing.Point(0, 34);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTotalPrice.Size = new System.Drawing.Size(58, 19);
            this.lblTotalPrice.TabIndex = 13;
            this.lblTotalPrice.Text = "0.00zł";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChartListBox
            // 
            this.pnlChartListBox.AutoScroll = true;
            this.pnlChartListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartListBox.Location = new System.Drawing.Point(0, 60);
            this.pnlChartListBox.Name = "pnlChartListBox";
            this.pnlChartListBox.Size = new System.Drawing.Size(125, 332);
            this.pnlChartListBox.TabIndex = 11;
            // 
            // btnRealize
            // 
            this.btnRealize.BackColor = System.Drawing.Color.Orange;
            this.btnRealize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRealize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRealize.FlatAppearance.BorderSize = 3;
            this.btnRealize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealize.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRealize.ForeColor = System.Drawing.Color.White;
            this.btnRealize.Location = new System.Drawing.Point(0, 392);
            this.btnRealize.Name = "btnRealize";
            this.btnRealize.Size = new System.Drawing.Size(125, 60);
            this.btnRealize.TabIndex = 8;
            this.btnRealize.Text = "Realize";
            this.btnRealize.UseVisualStyleBackColor = false;
            this.btnRealize.Click += new System.EventHandler(this.btnRealize_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(0, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 60);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.Orange;
            this.btnCreateOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateOrder.FlatAppearance.BorderSize = 3;
            this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateOrder.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrder.Location = new System.Drawing.Point(0, 0);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(125, 60);
            this.btnCreateOrder.TabIndex = 7;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // pnlProducts
            // 
            this.pnlProducts.AutoScroll = true;
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducts.Location = new System.Drawing.Point(275, 0);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(604, 512);
            this.pnlProducts.TabIndex = 2;
            // 
            // ShoppingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.pnlCreateOrder);
            this.Controls.Add(this.pnlFilter);
            this.MinimumSize = new System.Drawing.Size(879, 512);
            this.Name = "ShoppingUserControl";
            this.Size = new System.Drawing.Size(879, 512);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlCreateOrder.ResumeLayout(false);
            this.pnlTotalPrice.ResumeLayout(false);
            this.pnlTotalPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox tBoxPriceMin;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cBoxCategory;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.TextBox tBoxManufacturer;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tBoxPriceMax;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.CheckBox chkBoxDiscontinued;
        private System.Windows.Forms.Panel pnlCreateOrder;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnRealize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Panel pnlChartListBox;
        private System.Windows.Forms.Panel pnlTotalPrice;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}
