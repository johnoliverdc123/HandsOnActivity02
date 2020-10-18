namespace Inventory
{
    partial class frmAddProduct
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dtPickerMfgDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTxtDescription = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gridViewProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(724, 230);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 39;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(82, 167);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(232, 20);
            this.txtQuantity.TabIndex = 33;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(82, 80);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(232, 21);
            this.cbCategory.TabIndex = 32;
            // 
            // dtPickerMfgDate
            // 
            this.dtPickerMfgDate.Location = new System.Drawing.Point(82, 109);
            this.dtPickerMfgDate.Name = "dtPickerMfgDate";
            this.dtPickerMfgDate.Size = new System.Drawing.Size(232, 20);
            this.dtPickerMfgDate.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mfg. Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Qty.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add Product";
            // 
            // dtPickerExpDate
            // 
            this.dtPickerExpDate.Location = new System.Drawing.Point(82, 139);
            this.dtPickerExpDate.Name = "dtPickerExpDate";
            this.dtPickerExpDate.Size = new System.Drawing.Size(232, 20);
            this.dtPickerExpDate.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Exp. Date";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(82, 196);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(232, 20);
            this.txtSellPrice.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Sell Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(82, 52);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(232, 20);
            this.txtProductName.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Product";
            // 
            // richTxtDescription
            // 
            this.richTxtDescription.Location = new System.Drawing.Point(344, 80);
            this.richTxtDescription.Name = "richTxtDescription";
            this.richTxtDescription.Size = new System.Drawing.Size(455, 144);
            this.richTxtDescription.TabIndex = 46;
            this.richTxtDescription.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Description";
            // 
            // gridViewProductList
            // 
            this.gridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProductList.Location = new System.Drawing.Point(12, 260);
            this.gridViewProductList.Name = "gridViewProductList";
            this.gridViewProductList.Size = new System.Drawing.Size(787, 178);
            this.gridViewProductList.TabIndex = 48;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.gridViewProductList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTxtDescription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPickerExpDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.dtPickerMfgDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddProduct";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DateTimePicker dtPickerMfgDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPickerExpDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridViewProductList;
    }
}

