namespace qlnt.UI
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.txtboxWorker = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbbImport = new System.Windows.Forms.ComboBox();
            this.lblImport = new System.Windows.Forms.Label();
            this.dpDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.fbtnReadFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtboxTotal = new System.Windows.Forms.TextBox();
            this.fbtnConfirm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.fbtnDiscard = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTitle.Location = new System.Drawing.Point(583, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LẬP HOÁ ĐƠN";
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblWorker.Location = new System.Drawing.Point(353, 122);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(142, 25);
            this.lblWorker.TabIndex = 1;
            this.lblWorker.Text = "Tên người lập: ";
            // 
            // txtboxWorker
            // 
            this.txtboxWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxWorker.Location = new System.Drawing.Point(501, 119);
            this.txtboxWorker.Name = "txtboxWorker";
            this.txtboxWorker.Size = new System.Drawing.Size(331, 30);
            this.txtboxWorker.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDate.Location = new System.Drawing.Point(353, 177);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(171, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Ngày lập hoá đơn:";
            // 
            // cbbImport
            // 
            this.cbbImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbbImport.FormattingEnabled = true;
            this.cbbImport.Location = new System.Drawing.Point(545, 224);
            this.cbbImport.Name = "cbbImport";
            this.cbbImport.Size = new System.Drawing.Size(287, 33);
            this.cbbImport.TabIndex = 5;
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblImport.Location = new System.Drawing.Point(353, 227);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(168, 25);
            this.lblImport.TabIndex = 6;
            this.lblImport.Text = "Chọn phiếu nhập:";
            // 
            // dpDate
            // 
            this.dpDate.BackColor = System.Drawing.Color.SeaGreen;
            this.dpDate.BorderRadius = 0;
            this.dpDate.ForeColor = System.Drawing.Color.White;
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpDate.FormatCustom = null;
            this.dpDate.Location = new System.Drawing.Point(530, 166);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(303, 36);
            this.dpDate.TabIndex = 7;
            this.dpDate.Value = new System.DateTime(2019, 11, 15, 15, 4, 35, 47);
            // 
            // fbtnReadFile
            // 
            this.fbtnReadFile.Active = false;
            this.fbtnReadFile.Activecolor = System.Drawing.Color.Blue;
            this.fbtnReadFile.BackColor = System.Drawing.Color.Blue;
            this.fbtnReadFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnReadFile.BorderRadius = 0;
            this.fbtnReadFile.ButtonText = "Đọc phiếu";
            this.fbtnReadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnReadFile.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnReadFile.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnReadFile.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnReadFile.Iconimage")));
            this.fbtnReadFile.Iconimage_right = null;
            this.fbtnReadFile.Iconimage_right_Selected = null;
            this.fbtnReadFile.Iconimage_Selected = null;
            this.fbtnReadFile.IconMarginLeft = 0;
            this.fbtnReadFile.IconMarginRight = 0;
            this.fbtnReadFile.IconRightVisible = true;
            this.fbtnReadFile.IconRightZoom = 0D;
            this.fbtnReadFile.IconVisible = true;
            this.fbtnReadFile.IconZoom = 90D;
            this.fbtnReadFile.IsTab = false;
            this.fbtnReadFile.Location = new System.Drawing.Point(867, 224);
            this.fbtnReadFile.Name = "fbtnReadFile";
            this.fbtnReadFile.Normalcolor = System.Drawing.Color.Blue;
            this.fbtnReadFile.OnHovercolor = System.Drawing.Color.Blue;
            this.fbtnReadFile.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnReadFile.selected = false;
            this.fbtnReadFile.Size = new System.Drawing.Size(117, 33);
            this.fbtnReadFile.TabIndex = 8;
            this.fbtnReadFile.Text = "Đọc phiếu";
            this.fbtnReadFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnReadFile.Textcolor = System.Drawing.Color.White;
            this.fbtnReadFile.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(299, 283);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.Size = new System.Drawing.Size(733, 240);
            this.dgvProductList.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotal.Location = new System.Drawing.Point(722, 551);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(111, 25);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Thành tiền:";
            // 
            // txtboxTotal
            // 
            this.txtboxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtboxTotal.Location = new System.Drawing.Point(839, 546);
            this.txtboxTotal.Name = "txtboxTotal";
            this.txtboxTotal.Size = new System.Drawing.Size(145, 30);
            this.txtboxTotal.TabIndex = 11;
            // 
            // fbtnConfirm
            // 
            this.fbtnConfirm.Active = false;
            this.fbtnConfirm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnConfirm.BorderRadius = 0;
            this.fbtnConfirm.ButtonText = "Lưu hoá đơn";
            this.fbtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnConfirm.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnConfirm.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnConfirm.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnConfirm.Iconimage")));
            this.fbtnConfirm.Iconimage_right = null;
            this.fbtnConfirm.Iconimage_right_Selected = null;
            this.fbtnConfirm.Iconimage_Selected = null;
            this.fbtnConfirm.IconMarginLeft = 0;
            this.fbtnConfirm.IconMarginRight = 0;
            this.fbtnConfirm.IconRightVisible = true;
            this.fbtnConfirm.IconRightZoom = 0D;
            this.fbtnConfirm.IconVisible = true;
            this.fbtnConfirm.IconZoom = 90D;
            this.fbtnConfirm.IsTab = false;
            this.fbtnConfirm.Location = new System.Drawing.Point(501, 607);
            this.fbtnConfirm.Name = "fbtnConfirm";
            this.fbtnConfirm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnConfirm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnConfirm.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnConfirm.selected = false;
            this.fbtnConfirm.Size = new System.Drawing.Size(147, 48);
            this.fbtnConfirm.TabIndex = 12;
            this.fbtnConfirm.Text = "Lưu hoá đơn";
            this.fbtnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnConfirm.Textcolor = System.Drawing.Color.White;
            this.fbtnConfirm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // fbtnDiscard
            // 
            this.fbtnDiscard.Active = false;
            this.fbtnDiscard.Activecolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscard.BackColor = System.Drawing.Color.DarkRed;
            this.fbtnDiscard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnDiscard.BorderRadius = 0;
            this.fbtnDiscard.ButtonText = "Huỷ thay đổi";
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
            this.fbtnDiscard.Location = new System.Drawing.Point(727, 607);
            this.fbtnDiscard.Name = "fbtnDiscard";
            this.fbtnDiscard.Normalcolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscard.OnHovercolor = System.Drawing.Color.DarkRed;
            this.fbtnDiscard.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnDiscard.selected = false;
            this.fbtnDiscard.Size = new System.Drawing.Size(151, 48);
            this.fbtnDiscard.TabIndex = 14;
            this.fbtnDiscard.Text = "Huỷ thay đổi";
            this.fbtnDiscard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnDiscard.Textcolor = System.Drawing.Color.White;
            this.fbtnDiscard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.fbtnDiscard);
            this.Controls.Add(this.fbtnConfirm);
            this.Controls.Add(this.txtboxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.fbtnReadFile);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.lblImport);
            this.Controls.Add(this.cbbImport);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtboxWorker);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.TextBox txtboxWorker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbbImport;
        private System.Windows.Forms.Label lblImport;
        private Bunifu.Framework.UI.BunifuDatepicker dpDate;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnReadFile;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtboxTotal;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnConfirm;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnDiscard;
    }
}