namespace DemoProject
{
    partial class Menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaleSummary = new System.Windows.Forms.Button();
            this.btnSaleDetail = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.groupBox1.Controls.Add(this.btnProducts);
            this.groupBox1.Controls.Add(this.btnDeliver);
            this.groupBox1.Controls.Add(this.btnCustomer);
            this.groupBox1.Controls.Add(this.btnEmployee);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(77, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master";
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnProducts.FlatAppearance.BorderSize = 3;
            this.btnProducts.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.btnProducts.Image = global::DemoProject.Properties.Resources.product1;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducts.Location = new System.Drawing.Point(615, 30);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(141, 157);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "PRODUCTS";
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnDeliver
            // 
            this.btnDeliver.BackColor = System.Drawing.Color.Transparent;
            this.btnDeliver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeliver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeliver.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnDeliver.FlatAppearance.BorderSize = 3;
            this.btnDeliver.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.btnDeliver.Image = global::DemoProject.Properties.Resources.deliver1;
            this.btnDeliver.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeliver.Location = new System.Drawing.Point(413, 30);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(141, 157);
            this.btnDeliver.TabIndex = 3;
            this.btnDeliver.Text = "DELIVER";
            this.btnDeliver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeliver.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCustomer.FlatAppearance.BorderSize = 3;
            this.btnCustomer.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.btnCustomer.Image = global::DemoProject.Properties.Resources.customer2;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomer.Location = new System.Drawing.Point(219, 30);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(141, 157);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "CUSTOMER";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnEmployee.FlatAppearance.BorderSize = 3;
            this.btnEmployee.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.btnEmployee.Image = global::DemoProject.Properties.Resources.employee2;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(31, 30);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(141, 157);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "EMPLOYEE";
            this.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.groupBox2.Controls.Add(this.btnSales);
            this.groupBox2.Controls.Add(this.btnPrice);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(77, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRANSACTION";
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Transparent;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSales.FlatAppearance.BorderSize = 3;
            this.btnSales.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.btnSales.Image = global::DemoProject.Properties.Resources.cart;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(219, 30);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(141, 157);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "SALES";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.Transparent;
            this.btnPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrice.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnPrice.FlatAppearance.BorderSize = 3;
            this.btnPrice.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.btnPrice.Image = global::DemoProject.Properties.Resources.price2;
            this.btnPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrice.Location = new System.Drawing.Point(31, 30);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(141, 157);
            this.btnPrice.TabIndex = 2;
            this.btnPrice.Text = "PRICE";
            this.btnPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrice.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(149)))), ((int)(((byte)(227)))));
            this.groupBox3.Controls.Add(this.btnSaleSummary);
            this.groupBox3.Controls.Add(this.btnSaleDetail);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(77, 539);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(798, 194);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "REPORT";
            // 
            // btnSaleSummary
            // 
            this.btnSaleSummary.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaleSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaleSummary.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSaleSummary.FlatAppearance.BorderSize = 3;
            this.btnSaleSummary.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.btnSaleSummary.Image = global::DemoProject.Properties.Resources.pie_chart;
            this.btnSaleSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleSummary.Location = new System.Drawing.Point(219, 30);
            this.btnSaleSummary.Name = "btnSaleSummary";
            this.btnSaleSummary.Size = new System.Drawing.Size(141, 157);
            this.btnSaleSummary.TabIndex = 3;
            this.btnSaleSummary.Text = "SALES SUMMARY";
            this.btnSaleSummary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaleSummary.UseVisualStyleBackColor = false;
            // 
            // btnSaleDetail
            // 
            this.btnSaleDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnSaleDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaleDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaleDetail.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSaleDetail.FlatAppearance.BorderSize = 3;
            this.btnSaleDetail.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.btnSaleDetail.Image = global::DemoProject.Properties.Resources.sale_detail;
            this.btnSaleDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleDetail.Location = new System.Drawing.Point(31, 30);
            this.btnSaleDetail.Name = "btnSaleDetail";
            this.btnSaleDetail.Size = new System.Drawing.Size(141, 157);
            this.btnSaleDetail.TabIndex = 0;
            this.btnSaleDetail.Text = "SALES DETAIL";
            this.btnSaleDetail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSaleDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaleDetail.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(900, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 62);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "➡";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(224)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(975, 745);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaleDetail;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnSaleSummary;
        private System.Windows.Forms.Button btnExit;

    }
}