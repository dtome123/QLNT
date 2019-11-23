namespace qlnt.UI
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
            this.fbtnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fbtnCreate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtboxTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotatCost = new System.Windows.Forms.Label();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
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
            this.cbbExportProductType = new System.Windows.Forms.ComboBox();
            this.lblExportProductType = new System.Windows.Forms.Label();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.fbtnDiscardChanges = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.pnlActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // fbtnAddProduct
            // 
            this.fbtnAddProduct.Active = false;
            this.fbtnAddProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnAddProduct.BorderRadius = 0;
            this.fbtnAddProduct.ButtonText = "Thêm mặt hàng";
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
            this.fbtnAddProduct.Location = new System.Drawing.Point(794, 222);
            this.fbtnAddProduct.Name = "fbtnAddProduct";
            this.fbtnAddProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnAddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnAddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnAddProduct.selected = false;
            this.fbtnAddProduct.Size = new System.Drawing.Size(175, 33);
            this.fbtnAddProduct.TabIndex = 35;
            this.fbtnAddProduct.Text = "Thêm mặt hàng";
            this.fbtnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnAddProduct.Textcolor = System.Drawing.Color.White;
            this.fbtnAddProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // fbtnCreate
            // 
            this.fbtnCreate.Active = false;
            this.fbtnCreate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnCreate.BackColor = System.Drawing.Color.Green;
            this.fbtnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnCreate.BorderRadius = 0;
            this.fbtnCreate.ButtonText = "Tạo phiếu xuất";
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
            this.fbtnCreate.Location = new System.Drawing.Point(323, 594);
            this.fbtnCreate.Name = "fbtnCreate";
            this.fbtnCreate.Normalcolor = System.Drawing.Color.Green;
            this.fbtnCreate.OnHovercolor = System.Drawing.Color.Green;
            this.fbtnCreate.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnCreate.selected = false;
            this.fbtnCreate.Size = new System.Drawing.Size(195, 48);
            this.fbtnCreate.TabIndex = 33;
            this.fbtnCreate.Text = "Tạo phiếu xuất";
            this.fbtnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnCreate.Textcolor = System.Drawing.Color.White;
            this.fbtnCreate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtboxTotalCost
            // 
            this.txtboxTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxTotalCost.Location = new System.Drawing.Point(794, 545);
            this.txtboxTotalCost.Name = "txtboxTotalCost";
            this.txtboxTotalCost.Size = new System.Drawing.Size(186, 30);
            this.txtboxTotalCost.TabIndex = 32;
            // 
            // lblTotatCost
            // 
            this.lblTotatCost.AutoSize = true;
            this.lblTotatCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotatCost.Location = new System.Drawing.Point(694, 548);
            this.lblTotatCost.Name = "lblTotatCost";
            this.lblTotatCost.Size = new System.Drawing.Size(94, 25);
            this.lblTotatCost.TabIndex = 31;
            this.lblTotatCost.Text = "Tổng tiền";
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(262, 222);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(441, 33);
            this.cbbCustomer.TabIndex = 30;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSupplier.Location = new System.Drawing.Point(138, 225);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(118, 25);
            this.lblSupplier.TabIndex = 29;
            this.lblSupplier.Text = "Khách hàng";
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(104, 272);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.Size = new System.Drawing.Size(903, 261);
            this.dgvProductList.TabIndex = 28;
            // 
            // txtboxAmount
            // 
            this.txtboxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxAmount.Location = new System.Drawing.Point(831, 111);
            this.txtboxAmount.Name = "txtboxAmount";
            this.txtboxAmount.Size = new System.Drawing.Size(176, 30);
            this.txtboxAmount.TabIndex = 27;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAmount.Location = new System.Drawing.Point(735, 116);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(90, 25);
            this.lblAmount.TabIndex = 26;
            this.lblAmount.Text = "Số lượng";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblProductName.Location = new System.Drawing.Point(138, 171);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(212, 25);
            this.lblProductName.TabIndex = 25;
            this.lblProductName.Text = "Tên mặt hàng cần xuất";
            // 
            // cbbProducts
            // 
            this.cbbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbbProducts.FormattingEnabled = true;
            this.cbbProducts.Location = new System.Drawing.Point(356, 165);
            this.cbbProducts.MaxDropDownItems = 10;
            this.cbbProducts.Name = "cbbProducts";
            this.cbbProducts.Size = new System.Drawing.Size(347, 33);
            this.cbbProducts.TabIndex = 24;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDate.Location = new System.Drawing.Point(735, 61);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 25);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Ngày lập";
            // 
            // txtboxWorker
            // 
            this.txtboxWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxWorker.Location = new System.Drawing.Point(280, 61);
            this.txtboxWorker.Name = "txtboxWorker";
            this.txtboxWorker.Size = new System.Drawing.Size(423, 30);
            this.txtboxWorker.TabIndex = 21;
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblWorker.Location = new System.Drawing.Point(138, 61);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(137, 25);
            this.lblWorker.TabIndex = 20;
            this.lblWorker.Text = "Tên nhân viên";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitle.Location = new System.Drawing.Point(450, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 31);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "XUẤT HÀNG HOÁ";
            // 
            // dpDate
            // 
            this.dpDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpDate.BorderRadius = 0;
            this.dpDate.ForeColor = System.Drawing.Color.White;
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDate.FormatCustom = null;
            this.dpDate.Location = new System.Drawing.Point(830, 61);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(177, 30);
            this.dpDate.TabIndex = 37;
            this.dpDate.Value = new System.DateTime(2019, 11, 16, 10, 36, 3, 762);
            // 
            // cbbExportProductType
            // 
            this.cbbExportProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbbExportProductType.FormattingEnabled = true;
            this.cbbExportProductType.Location = new System.Drawing.Point(288, 108);
            this.cbbExportProductType.Name = "cbbExportProductType";
            this.cbbExportProductType.Size = new System.Drawing.Size(415, 33);
            this.cbbExportProductType.TabIndex = 38;
            // 
            // lblExportProductType
            // 
            this.lblExportProductType.AutoSize = true;
            this.lblExportProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblExportProductType.Location = new System.Drawing.Point(138, 116);
            this.lblExportProductType.Name = "lblExportProductType";
            this.lblExportProductType.Size = new System.Drawing.Size(144, 25);
            this.lblExportProductType.TabIndex = 39;
            this.lblExportProductType.Text = "Loại phiếu xuất";
            // 
            // pnlActive
            // 
            this.pnlActive.Controls.Add(this.fbtnDiscardChanges);
            this.pnlActive.Location = new System.Drawing.Point(0, 0);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(1100, 661);
            this.pnlActive.TabIndex = 40;
            // 
            // fbtnDiscardChanges
            // 
            this.fbtnDiscardChanges.Active = false;
            this.fbtnDiscardChanges.Activecolor = System.Drawing.Color.Red;
            this.fbtnDiscardChanges.BackColor = System.Drawing.Color.DarkRed;
            this.fbtnDiscardChanges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnDiscardChanges.BorderRadius = 0;
            this.fbtnDiscardChanges.ButtonText = "Huỷ thay đổi";
            this.fbtnDiscardChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnDiscardChanges.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnDiscardChanges.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnDiscardChanges.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnDiscardChanges.Iconimage")));
            this.fbtnDiscardChanges.Iconimage_right = null;
            this.fbtnDiscardChanges.Iconimage_right_Selected = null;
            this.fbtnDiscardChanges.Iconimage_Selected = null;
            this.fbtnDiscardChanges.IconMarginLeft = 0;
            this.fbtnDiscardChanges.IconMarginRight = 0;
            this.fbtnDiscardChanges.IconRightVisible = true;
            this.fbtnDiscardChanges.IconRightZoom = 0D;
            this.fbtnDiscardChanges.IconVisible = true;
            this.fbtnDiscardChanges.IconZoom = 90D;
            this.fbtnDiscardChanges.IsTab = false;
            this.fbtnDiscardChanges.Location = new System.Drawing.Point(574, 594);
            this.fbtnDiscardChanges.Name = "fbtnDiscardChanges";
            this.fbtnDiscardChanges.Normalcolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscardChanges.OnHovercolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscardChanges.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnDiscardChanges.selected = false;
            this.fbtnDiscardChanges.Size = new System.Drawing.Size(195, 48);
            this.fbtnDiscardChanges.TabIndex = 41;
            this.fbtnDiscardChanges.Text = "Huỷ thay đổi";
            this.fbtnDiscardChanges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnDiscardChanges.Textcolor = System.Drawing.Color.White;
            this.fbtnDiscardChanges.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.lblExportProductType);
            this.Controls.Add(this.cbbExportProductType);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.fbtnAddProduct);
            this.Controls.Add(this.fbtnCreate);
            this.Controls.Add(this.txtboxTotalCost);
            this.Controls.Add(this.lblTotatCost);
            this.Controls.Add(this.cbbCustomer);
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
            this.Controls.Add(this.pnlActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.pnlActive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton fbtnAddProduct;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnCreate;
        private System.Windows.Forms.TextBox txtboxTotalCost;
        private System.Windows.Forms.Label lblTotatCost;
        private System.Windows.Forms.ComboBox cbbCustomer;
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
        private System.Windows.Forms.ComboBox cbbExportProductType;
        private System.Windows.Forms.Label lblExportProductType;
        private System.Windows.Forms.Panel pnlActive;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnDiscardChanges;
    }
}