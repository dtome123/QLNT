namespace qlnt.UI
{
    partial class ImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.txtboxWorker = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtboxDateCreate = new System.Windows.Forms.TextBox();
            this.cbbProducts = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtboxAmount = new System.Windows.Forms.TextBox();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cbbSupplier = new System.Windows.Forms.ComboBox();
            this.lblTotatCost = new System.Windows.Forms.Label();
            this.txtboxTotalCost = new System.Windows.Forms.TextBox();
            this.fbtnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fbtnDiscard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fbtnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ibtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTitle.Location = new System.Drawing.Point(497, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(344, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Import Products Form";
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblWorker.Location = new System.Drawing.Point(241, 137);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(158, 25);
            this.lblWorker.TabIndex = 1;
            this.lblWorker.Text = "Worker\'s Name: ";
            // 
            // txtboxWorker
            // 
            this.txtboxWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxWorker.Location = new System.Drawing.Point(405, 132);
            this.txtboxWorker.Name = "txtboxWorker";
            this.txtboxWorker.Size = new System.Drawing.Size(401, 30);
            this.txtboxWorker.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDate.Location = new System.Drawing.Point(840, 137);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date:";
            // 
            // txtboxDateCreate
            // 
            this.txtboxDateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxDateCreate.Location = new System.Drawing.Point(905, 132);
            this.txtboxDateCreate.Name = "txtboxDateCreate";
            this.txtboxDateCreate.Size = new System.Drawing.Size(177, 30);
            this.txtboxDateCreate.TabIndex = 4;
            // 
            // cbbProducts
            // 
            this.cbbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbbProducts.FormattingEnabled = true;
            this.cbbProducts.Location = new System.Drawing.Point(405, 186);
            this.cbbProducts.Name = "cbbProducts";
            this.cbbProducts.Size = new System.Drawing.Size(401, 33);
            this.cbbProducts.TabIndex = 5;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblProductName.Location = new System.Drawing.Point(241, 192);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(142, 25);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAmount.Location = new System.Drawing.Point(841, 194);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(86, 25);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount:";
            // 
            // txtboxAmount
            // 
            this.txtboxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxAmount.Location = new System.Drawing.Point(933, 189);
            this.txtboxAmount.Name = "txtboxAmount";
            this.txtboxAmount.Size = new System.Drawing.Size(149, 30);
            this.txtboxAmount.TabIndex = 8;
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(246, 307);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.Size = new System.Drawing.Size(836, 241);
            this.dgvProductList.TabIndex = 10;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSupplier.Location = new System.Drawing.Point(241, 246);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(90, 25);
            this.lblSupplier.TabIndex = 11;
            this.lblSupplier.Text = "Supplier:";
            // 
            // cbbSupplier
            // 
            this.cbbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbbSupplier.FormattingEnabled = true;
            this.cbbSupplier.Location = new System.Drawing.Point(405, 243);
            this.cbbSupplier.Name = "cbbSupplier";
            this.cbbSupplier.Size = new System.Drawing.Size(401, 33);
            this.cbbSupplier.TabIndex = 12;
            // 
            // lblTotatCost
            // 
            this.lblTotatCost.AutoSize = true;
            this.lblTotatCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotatCost.Location = new System.Drawing.Point(782, 565);
            this.lblTotatCost.Name = "lblTotatCost";
            this.lblTotatCost.Size = new System.Drawing.Size(108, 25);
            this.lblTotatCost.TabIndex = 13;
            this.lblTotatCost.Text = "Total Cost:";
            // 
            // txtboxTotalCost
            // 
            this.txtboxTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxTotalCost.Location = new System.Drawing.Point(896, 560);
            this.txtboxTotalCost.Name = "txtboxTotalCost";
            this.txtboxTotalCost.Size = new System.Drawing.Size(186, 30);
            this.txtboxTotalCost.TabIndex = 14;
            // 
            // fbtnCreate
            // 
            this.fbtnCreate.Active = false;
            this.fbtnCreate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnCreate.BorderRadius = 0;
            this.fbtnCreate.ButtonText = "Create Import Form";
            this.fbtnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnCreate.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnCreate.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnCreate.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnCreate.Iconimage")));
            this.fbtnCreate.Iconimage_right = null;
            this.fbtnCreate.Iconimage_right_Selected = null;
            this.fbtnCreate.Iconimage_Selected = null;
            this.fbtnCreate.IconMarginLeft = 0;
            this.fbtnCreate.IconMarginRight = 0;
            this.fbtnCreate.IconRightVisible = true;
            this.fbtnCreate.IconRightZoom = 0D;
            this.fbtnCreate.IconVisible = true;
            this.fbtnCreate.IconZoom = 90D;
            this.fbtnCreate.IsTab = false;
            this.fbtnCreate.Location = new System.Drawing.Point(426, 615);
            this.fbtnCreate.Name = "fbtnCreate";
            this.fbtnCreate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnCreate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnCreate.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnCreate.selected = false;
            this.fbtnCreate.Size = new System.Drawing.Size(195, 48);
            this.fbtnCreate.TabIndex = 15;
            this.fbtnCreate.Text = "Create Import Form";
            this.fbtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnCreate.Textcolor = System.Drawing.Color.White;
            this.fbtnCreate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // fbtnDiscard
            // 
            this.fbtnDiscard.Active = false;
            this.fbtnDiscard.Activecolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscard.BackColor = System.Drawing.Color.DarkRed;
            this.fbtnDiscard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnDiscard.BorderRadius = 0;
            this.fbtnDiscard.ButtonText = "Discard Changes";
            this.fbtnDiscard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnDiscard.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnDiscard.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnDiscard.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnDiscard.Iconimage")));
            this.fbtnDiscard.Iconimage_right = null;
            this.fbtnDiscard.Iconimage_right_Selected = null;
            this.fbtnDiscard.Iconimage_Selected = null;
            this.fbtnDiscard.IconMarginLeft = 0;
            this.fbtnDiscard.IconMarginRight = 0;
            this.fbtnDiscard.IconRightVisible = true;
            this.fbtnDiscard.IconRightZoom = 0D;
            this.fbtnDiscard.IconVisible = true;
            this.fbtnDiscard.IconZoom = 90D;
            this.fbtnDiscard.IsTab = false;
            this.fbtnDiscard.Location = new System.Drawing.Point(668, 615);
            this.fbtnDiscard.Name = "fbtnDiscard";
            this.fbtnDiscard.Normalcolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscard.OnHovercolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscard.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnDiscard.selected = false;
            this.fbtnDiscard.Size = new System.Drawing.Size(195, 48);
            this.fbtnDiscard.TabIndex = 16;
            this.fbtnDiscard.Text = "Discard Changes";
            this.fbtnDiscard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnDiscard.Textcolor = System.Drawing.Color.White;
            this.fbtnDiscard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // fbtnAddProduct
            // 
            this.fbtnAddProduct.Active = false;
            this.fbtnAddProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnAddProduct.BorderRadius = 0;
            this.fbtnAddProduct.ButtonText = "Add Product";
            this.fbtnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnAddProduct.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnAddProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnAddProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnAddProduct.Iconimage")));
            this.fbtnAddProduct.Iconimage_right = null;
            this.fbtnAddProduct.Iconimage_right_Selected = null;
            this.fbtnAddProduct.Iconimage_Selected = null;
            this.fbtnAddProduct.IconMarginLeft = 0;
            this.fbtnAddProduct.IconMarginRight = 0;
            this.fbtnAddProduct.IconRightVisible = true;
            this.fbtnAddProduct.IconRightZoom = 0D;
            this.fbtnAddProduct.IconVisible = true;
            this.fbtnAddProduct.IconZoom = 90D;
            this.fbtnAddProduct.IsTab = false;
            this.fbtnAddProduct.Location = new System.Drawing.Point(876, 243);
            this.fbtnAddProduct.Name = "fbtnAddProduct";
            this.fbtnAddProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnAddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnAddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnAddProduct.selected = false;
            this.fbtnAddProduct.Size = new System.Drawing.Size(175, 33);
            this.fbtnAddProduct.TabIndex = 17;
            this.fbtnAddProduct.Text = "Add Product";
            this.fbtnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnAddProduct.Textcolor = System.Drawing.Color.White;
            this.fbtnAddProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ibtnClose
            // 
            this.ibtnClose.Image = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Image")));
            this.ibtnClose.ImageActive = null;
            this.ibtnClose.Location = new System.Drawing.Point(1227, 12);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(40, 40);
            this.ibtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnClose.TabIndex = 18;
            this.ibtnClose.TabStop = false;
            this.ibtnClose.Zoom = 10;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ibtnClose);
            this.Controls.Add(this.fbtnAddProduct);
            this.Controls.Add(this.fbtnDiscard);
            this.Controls.Add(this.fbtnCreate);
            this.Controls.Add(this.txtboxTotalCost);
            this.Controls.Add(this.lblTotatCost);
            this.Controls.Add(this.cbbSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.txtboxAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.cbbProducts);
            this.Controls.Add(this.txtboxDateCreate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtboxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.TextBox txtboxWorker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtboxDateCreate;
        private System.Windows.Forms.ComboBox cbbProducts;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtboxAmount;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cbbSupplier;
        private System.Windows.Forms.Label lblTotatCost;
        private System.Windows.Forms.TextBox txtboxTotalCost;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnCreate;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnDiscard;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnAddProduct;
        private Bunifu.Framework.UI.BunifuImageButton ibtnClose;
    }
}