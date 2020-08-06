namespace P4_Projekt.UserControls
{
    partial class SimpleProductUserControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pBoxProductImage = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnAddToChart = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.numUpDownUnits = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.558307F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.83792F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.001449F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.31154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.01665F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.71582F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.558306F));
            this.tableLayoutPanel1.Controls.Add(this.pBoxProductImage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitter1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAddToChart, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblManufacturer, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUnitPrice, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUnits, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.numUpDownUnits, 5, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pBoxProductImage
            // 
            this.pBoxProductImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxProductImage.BackColor = System.Drawing.Color.White;
            this.pBoxProductImage.Location = new System.Drawing.Point(25, 10);
            this.pBoxProductImage.MaximumSize = new System.Drawing.Size(128, 128);
            this.pBoxProductImage.Name = "pBoxProductImage";
            this.tableLayoutPanel1.SetRowSpan(this.pBoxProductImage, 2);
            this.pBoxProductImage.Size = new System.Drawing.Size(128, 128);
            this.pBoxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxProductImage.TabIndex = 0;
            this.pBoxProductImage.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.splitter1, 5);
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(25, 144);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(824, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // btnAddToChart
            // 
            this.btnAddToChart.BackColor = System.Drawing.Color.Orange;
            this.btnAddToChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddToChart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddToChart.FlatAppearance.BorderSize = 3;
            this.btnAddToChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToChart.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddToChart.ForeColor = System.Drawing.Color.White;
            this.btnAddToChart.Location = new System.Drawing.Point(709, 10);
            this.btnAddToChart.Name = "btnAddToChart";
            this.btnAddToChart.Size = new System.Drawing.Size(140, 61);
            this.btnAddToChart.TabIndex = 2;
            this.btnAddToChart.Text = "Add";
            this.btnAddToChart.UseVisualStyleBackColor = false;
            this.btnAddToChart.Click += new System.EventHandler(this.btnAddToChart_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(207, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(251, 67);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblManufacturer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblManufacturer.Location = new System.Drawing.Point(207, 74);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(132, 67);
            this.lblManufacturer.TabIndex = 4;
            this.lblManufacturer.Text = "manufacturer";
            this.lblManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnitPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUnitPrice.Location = new System.Drawing.Point(464, 7);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(239, 67);
            this.lblUnitPrice.TabIndex = 5;
            this.lblUnitPrice.Text = "price";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnits.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUnits.Location = new System.Drawing.Point(464, 74);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(239, 67);
            this.lblUnits.TabIndex = 6;
            this.lblUnits.Text = "units";
            this.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUpDownUnits
            // 
            this.numUpDownUnits.BackColor = System.Drawing.Color.White;
            this.numUpDownUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numUpDownUnits.Dock = System.Windows.Forms.DockStyle.Top;
            this.numUpDownUnits.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.numUpDownUnits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numUpDownUnits.Location = new System.Drawing.Point(709, 77);
            this.numUpDownUnits.Name = "numUpDownUnits";
            this.numUpDownUnits.Size = new System.Drawing.Size(140, 22);
            this.numUpDownUnits.TabIndex = 7;
            this.numUpDownUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUpDownUnits.ThousandsSeparator = true;
            // 
            // SimpleProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(600, 150);
            this.Name = "SimpleProductUserControl";
            this.Size = new System.Drawing.Size(878, 150);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pBoxProductImage;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnAddToChart;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.NumericUpDown numUpDownUnits;
    }
}
