﻿namespace qlnt.UI
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            this.ibtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.fbtnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fbtnDiscard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fbtnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtboxTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotatCost = new System.Windows.Forms.Label();
            this.cbbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.txtboxAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cbbProducts = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtboxWorker = new System.Windows.Forms.TextBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dpDate = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // ibtnClose
            // 
            this.ibtnClose.Image = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Image")));
            this.ibtnClose.ImageActive = null;
            this.ibtnClose.Location = new System.Drawing.Point(1221, 15);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(40, 40);
            this.ibtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnClose.TabIndex = 36;
            this.ibtnClose.TabStop = false;
            this.ibtnClose.Zoom = 10;
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
            this.fbtnAddProduct.Location = new System.Drawing.Point(870, 246);
            this.fbtnAddProduct.Name = "fbtnAddProduct";
            this.fbtnAddProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnAddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnAddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnAddProduct.selected = false;
            this.fbtnAddProduct.Size = new System.Drawing.Size(175, 33);
            this.fbtnAddProduct.TabIndex = 35;
            this.fbtnAddProduct.Text = "Add Product";
            this.fbtnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnAddProduct.Textcolor = System.Drawing.Color.White;
            this.fbtnAddProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // fbtnDiscard
            // 
            this.fbtnDiscard.Active = false;
            this.fbtnDiscard.Activecolor = System.Drawing.Color.Red;
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
            this.fbtnDiscard.Location = new System.Drawing.Point(662, 618);
            this.fbtnDiscard.Name = "fbtnDiscard";
            this.fbtnDiscard.Normalcolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscard.OnHovercolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscard.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnDiscard.selected = false;
            this.fbtnDiscard.Size = new System.Drawing.Size(195, 48);
            this.fbtnDiscard.TabIndex = 34;
            this.fbtnDiscard.Text = "Discard Changes";
            this.fbtnDiscard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnDiscard.Textcolor = System.Drawing.Color.White;
            this.fbtnDiscard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // fbtnCreate
            // 
            this.fbtnCreate.Active = false;
            this.fbtnCreate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnCreate.BackColor = System.Drawing.Color.Green;
            this.fbtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnCreate.BorderRadius = 0;
            this.fbtnCreate.ButtonText = "Create Export Form";
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
            this.fbtnCreate.Location = new System.Drawing.Point(420, 618);
            this.fbtnCreate.Name = "fbtnCreate";
            this.fbtnCreate.Normalcolor = System.Drawing.Color.Green;
            this.fbtnCreate.OnHovercolor = System.Drawing.Color.Green;
            this.fbtnCreate.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnCreate.selected = false;
            this.fbtnCreate.Size = new System.Drawing.Size(195, 48);
            this.fbtnCreate.TabIndex = 33;
            this.fbtnCreate.Text = "Create Export Form";
            this.fbtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnCreate.Textcolor = System.Drawing.Color.White;
            this.fbtnCreate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtboxTotalCost
            // 
            this.txtboxTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxTotalCost.Location = new System.Drawing.Point(890, 563);
            this.txtboxTotalCost.Name = "txtboxTotalCost";
            this.txtboxTotalCost.Size = new System.Drawing.Size(186, 30);
            this.txtboxTotalCost.TabIndex = 32;
            // 
            // lblTotatCost
            // 
            this.lblTotatCost.AutoSize = true;
            this.lblTotatCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotatCost.Location = new System.Drawing.Point(753, 566);
            this.lblTotatCost.Name = "lblTotatCost";
            this.lblTotatCost.Size = new System.Drawing.Size(131, 25);
            this.lblTotatCost.TabIndex = 31;
            this.lblTotatCost.Text = "Total Income:";
            // 
            // cbbSupplier
            // 
            this.cbbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbbSupplier.FormattingEnabled = true;
            this.cbbSupplier.Location = new System.Drawing.Point(399, 246);
            this.cbbSupplier.Name = "cbbSupplier";
            this.cbbSupplier.Size = new System.Drawing.Size(401, 33);
            this.cbbSupplier.TabIndex = 30;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSupplier.Location = new System.Drawing.Point(235, 249);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(103, 25);
            this.lblSupplier.TabIndex = 29;
            this.lblSupplier.Text = "Customer:";
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(240, 310);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.Size = new System.Drawing.Size(836, 241);
            this.dgvProductList.TabIndex = 28;
            // 
            // txtboxAmount
            // 
            this.txtboxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxAmount.Location = new System.Drawing.Point(927, 192);
            this.txtboxAmount.Name = "txtboxAmount";
            this.txtboxAmount.Size = new System.Drawing.Size(149, 30);
            this.txtboxAmount.TabIndex = 27;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAmount.Location = new System.Drawing.Point(835, 197);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(86, 25);
            this.lblAmount.TabIndex = 26;
            this.lblAmount.Text = "Amount:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblProductName.Location = new System.Drawing.Point(235, 195);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(142, 25);
            this.lblProductName.TabIndex = 25;
            this.lblProductName.Text = "Product Name:";
            // 
            // cbbProducts
            // 
            this.cbbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbbProducts.FormattingEnabled = true;
            this.cbbProducts.Location = new System.Drawing.Point(399, 189);
            this.cbbProducts.Name = "cbbProducts";
            this.cbbProducts.Size = new System.Drawing.Size(401, 33);
            this.cbbProducts.TabIndex = 24;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDate.Location = new System.Drawing.Point(834, 140);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 25);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Date:";
            // 
            // txtboxWorker
            // 
            this.txtboxWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxWorker.Location = new System.Drawing.Point(399, 135);
            this.txtboxWorker.Name = "txtboxWorker";
            this.txtboxWorker.Size = new System.Drawing.Size(401, 30);
            this.txtboxWorker.TabIndex = 21;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblWorker.Location = new System.Drawing.Point(235, 140);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(158, 25);
            this.lblWorker.TabIndex = 20;
            this.lblWorker.Text = "Worker\'s Name: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTitle.Location = new System.Drawing.Point(491, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(346, 39);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Export Products Form";
            // 
            // dpDate
            // 
            this.dpDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpDate.BorderRadius = 0;
            this.dpDate.ForeColor = System.Drawing.Color.White;
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDate.FormatCustom = null;
            this.dpDate.Location = new System.Drawing.Point(899, 129);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(177, 36);
            this.dpDate.TabIndex = 37;
            this.dpDate.Value = new System.DateTime(2019, 11, 16, 10, 36, 3, 762);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.dpDate);
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
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtboxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            ((System.ComponentModel.ISupportInitialize)(this.ibtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton ibtnClose;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnAddProduct;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnDiscard;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnCreate;
        private System.Windows.Forms.TextBox txtboxTotalCost;
        private System.Windows.Forms.Label lblTotatCost;
        private System.Windows.Forms.ComboBox cbbSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.TextBox txtboxAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cbbProducts;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtboxWorker;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuDatepicker dpDate;
    }
}