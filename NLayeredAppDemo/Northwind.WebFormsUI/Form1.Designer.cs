namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxSelect = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxAddCategoryId = new System.Windows.Forms.ComboBox();
            this.lblAddQuantityPerUnit = new System.Windows.Forms.Label();
            this.tbxAddQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblAddStockAmount = new System.Windows.Forms.Label();
            this.tbxAddStockAmount = new System.Windows.Forms.TextBox();
            this.lblAddUnitPrice = new System.Windows.Forms.Label();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.lblAddCategoryId = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxUpdateCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.lblUpdateCategoryId = new System.Windows.Forms.Label();
            this.lblUpdateStockAmount = new System.Windows.Forms.Label();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxSelect.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(50, 140);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1080, 361);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxSelect
            // 
            this.gbxSelect.Controls.Add(this.lblSearch);
            this.gbxSelect.Controls.Add(this.lblCategory);
            this.gbxSelect.Controls.Add(this.cbxCategory);
            this.gbxSelect.Controls.Add(this.tbxSearch);
            this.gbxSelect.Location = new System.Drawing.Point(50, 27);
            this.gbxSelect.Name = "gbxSelect";
            this.gbxSelect.Size = new System.Drawing.Size(1080, 107);
            this.gbxSelect.TabIndex = 1;
            this.gbxSelect.TabStop = false;
            this.gbxSelect.Text = "Select";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(350, 48);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 16);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(62, 45);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(154, 45);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(428, 48);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 22);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.cbxAddCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxAddQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblAddStockAmount);
            this.gbxProductAdd.Controls.Add(this.tbxAddStockAmount);
            this.gbxProductAdd.Controls.Add(this.lblAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxAddUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblAddCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblAddProductName);
            this.gbxProductAdd.Controls.Add(this.tbxAddProductName);
            this.gbxProductAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxProductAdd.Location = new System.Drawing.Point(50, 551);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(388, 193);
            this.gbxProductAdd.TabIndex = 2;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxAddCategoryId
            // 
            this.cbxAddCategoryId.FormattingEnabled = true;
            this.cbxAddCategoryId.Location = new System.Drawing.Point(125, 47);
            this.cbxAddCategoryId.Name = "cbxAddCategoryId";
            this.cbxAddCategoryId.Size = new System.Drawing.Size(173, 24);
            this.cbxAddCategoryId.TabIndex = 10;
            // 
            // lblAddQuantityPerUnit
            // 
            this.lblAddQuantityPerUnit.AutoSize = true;
            this.lblAddQuantityPerUnit.Location = new System.Drawing.Point(13, 133);
            this.lblAddQuantityPerUnit.Name = "lblAddQuantityPerUnit";
            this.lblAddQuantityPerUnit.Size = new System.Drawing.Size(105, 16);
            this.lblAddQuantityPerUnit.TabIndex = 9;
            this.lblAddQuantityPerUnit.Text = "Quantity Per Unit";
            // 
            // tbxAddQuantityPerUnit
            // 
            this.tbxAddQuantityPerUnit.Location = new System.Drawing.Point(124, 133);
            this.tbxAddQuantityPerUnit.Name = "tbxAddQuantityPerUnit";
            this.tbxAddQuantityPerUnit.Size = new System.Drawing.Size(174, 22);
            this.tbxAddQuantityPerUnit.TabIndex = 8;
            // 
            // lblAddStockAmount
            // 
            this.lblAddStockAmount.AutoSize = true;
            this.lblAddStockAmount.Location = new System.Drawing.Point(29, 105);
            this.lblAddStockAmount.Name = "lblAddStockAmount";
            this.lblAddStockAmount.Size = new System.Drawing.Size(89, 16);
            this.lblAddStockAmount.TabIndex = 7;
            this.lblAddStockAmount.Text = "Stock Amount";
            // 
            // tbxAddStockAmount
            // 
            this.tbxAddStockAmount.Location = new System.Drawing.Point(124, 105);
            this.tbxAddStockAmount.Name = "tbxAddStockAmount";
            this.tbxAddStockAmount.Size = new System.Drawing.Size(174, 22);
            this.tbxAddStockAmount.TabIndex = 6;
            // 
            // lblAddUnitPrice
            // 
            this.lblAddUnitPrice.AutoSize = true;
            this.lblAddUnitPrice.Location = new System.Drawing.Point(54, 77);
            this.lblAddUnitPrice.Name = "lblAddUnitPrice";
            this.lblAddUnitPrice.Size = new System.Drawing.Size(64, 16);
            this.lblAddUnitPrice.TabIndex = 5;
            this.lblAddUnitPrice.Text = "Unit Price";
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(124, 77);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(174, 22);
            this.tbxAddUnitPrice.TabIndex = 4;
            // 
            // lblAddCategoryId
            // 
            this.lblAddCategoryId.AutoSize = true;
            this.lblAddCategoryId.Location = new System.Drawing.Point(56, 49);
            this.lblAddCategoryId.Name = "lblAddCategoryId";
            this.lblAddCategoryId.Size = new System.Drawing.Size(62, 16);
            this.lblAddCategoryId.TabIndex = 3;
            this.lblAddCategoryId.Text = "Category";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(25, 21);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(93, 16);
            this.lblAddProductName.TabIndex = 1;
            this.lblAddProductName.Text = "Product Name";
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(124, 21);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(174, 22);
            this.tbxAddProductName.TabIndex = 0;
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Controls.Add(this.btnUpdate);
            this.gbxProductUpdate.Controls.Add(this.cbxUpdateCategoryId);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateProductName);
            this.gbxProductUpdate.Controls.Add(this.lblUpdateQuantityPerUnit);
            this.gbxProductUpdate.Controls.Add(this.lblUpdateProductName);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxProductUpdate.Controls.Add(this.lblUpdateCategoryId);
            this.gbxProductUpdate.Controls.Add(this.lblUpdateStockAmount);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateStockAmount);
            this.gbxProductUpdate.Controls.Add(this.lblUpdateUnitPrice);
            this.gbxProductUpdate.Location = new System.Drawing.Point(742, 551);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Size = new System.Drawing.Size(388, 193);
            this.gbxProductUpdate.TabIndex = 3;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(237, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxUpdateCategoryId
            // 
            this.cbxUpdateCategoryId.FormattingEnabled = true;
            this.cbxUpdateCategoryId.Location = new System.Drawing.Point(139, 47);
            this.cbxUpdateCategoryId.Name = "cbxUpdateCategoryId";
            this.cbxUpdateCategoryId.Size = new System.Drawing.Size(173, 24);
            this.cbxUpdateCategoryId.TabIndex = 20;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(138, 21);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(174, 22);
            this.tbxUpdateProductName.TabIndex = 11;
            // 
            // lblUpdateQuantityPerUnit
            // 
            this.lblUpdateQuantityPerUnit.AutoSize = true;
            this.lblUpdateQuantityPerUnit.Location = new System.Drawing.Point(27, 133);
            this.lblUpdateQuantityPerUnit.Name = "lblUpdateQuantityPerUnit";
            this.lblUpdateQuantityPerUnit.Size = new System.Drawing.Size(105, 16);
            this.lblUpdateQuantityPerUnit.TabIndex = 19;
            this.lblUpdateQuantityPerUnit.Text = "Quantity Per Unit";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(39, 21);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(93, 16);
            this.lblUpdateProductName.TabIndex = 12;
            this.lblUpdateProductName.Text = "Product Name";
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(138, 133);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(174, 22);
            this.tbxUpdateQuantityPerUnit.TabIndex = 18;
            // 
            // lblUpdateCategoryId
            // 
            this.lblUpdateCategoryId.AutoSize = true;
            this.lblUpdateCategoryId.Location = new System.Drawing.Point(70, 49);
            this.lblUpdateCategoryId.Name = "lblUpdateCategoryId";
            this.lblUpdateCategoryId.Size = new System.Drawing.Size(62, 16);
            this.lblUpdateCategoryId.TabIndex = 13;
            this.lblUpdateCategoryId.Text = "Category";
            // 
            // lblUpdateStockAmount
            // 
            this.lblUpdateStockAmount.AutoSize = true;
            this.lblUpdateStockAmount.Location = new System.Drawing.Point(43, 105);
            this.lblUpdateStockAmount.Name = "lblUpdateStockAmount";
            this.lblUpdateStockAmount.Size = new System.Drawing.Size(89, 16);
            this.lblUpdateStockAmount.TabIndex = 17;
            this.lblUpdateStockAmount.Text = "Stock Amount";
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(138, 77);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(174, 22);
            this.tbxUpdateUnitPrice.TabIndex = 14;
            // 
            // tbxUpdateStockAmount
            // 
            this.tbxUpdateStockAmount.Location = new System.Drawing.Point(138, 105);
            this.tbxUpdateStockAmount.Name = "tbxUpdateStockAmount";
            this.tbxUpdateStockAmount.Size = new System.Drawing.Size(174, 22);
            this.tbxUpdateStockAmount.TabIndex = 16;
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(68, 77);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(64, 16);
            this.lblUpdateUnitPrice.TabIndex = 15;
            this.lblUpdateUnitPrice.Text = "Unit Price";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1011, 507);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 26);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 750);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxSelect);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxSelect.ResumeLayout(false);
            this.gbxSelect.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxSelect;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblAddQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxAddQuantityPerUnit;
        private System.Windows.Forms.Label lblAddStockAmount;
        private System.Windows.Forms.TextBox tbxAddStockAmount;
        private System.Windows.Forms.Label lblAddUnitPrice;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.Label lblAddCategoryId;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.GroupBox gbxProductUpdate;
        private System.Windows.Forms.ComboBox cbxAddCategoryId;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryId;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateQuantityPerUnit;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.Label lblUpdateCategoryId;
        private System.Windows.Forms.Label lblUpdateStockAmount;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.TextBox tbxUpdateStockAmount;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

