namespace qlnt.UI
{
    partial class ProductSellingManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSellingManagement));
            this.tbtnImportForm = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnExportForm = new Bunifu.Framework.UI.BunifuTileButton();
            this.tbtnBillForm = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // tbtnImportForm
            // 
            this.tbtnImportForm.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnImportForm.color = System.Drawing.Color.SeaGreen;
            this.tbtnImportForm.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnImportForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnImportForm.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnImportForm.ForeColor = System.Drawing.Color.White;
            this.tbtnImportForm.Image = ((System.Drawing.Image)(resources.GetObject("tbtnImportForm.Image")));
            this.tbtnImportForm.ImagePosition = 19;
            this.tbtnImportForm.ImageZoom = 50;
            this.tbtnImportForm.LabelPosition = 39;
            this.tbtnImportForm.LabelText = "Tạo phiếu nhập";
            this.tbtnImportForm.Location = new System.Drawing.Point(122, 191);
            this.tbtnImportForm.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnImportForm.Name = "tbtnImportForm";
            this.tbtnImportForm.Size = new System.Drawing.Size(205, 211);
            this.tbtnImportForm.TabIndex = 0;
            this.tbtnImportForm.Click += new System.EventHandler(this.tbtnImportForm_Click);
            // 
            // tbtnExportForm
            // 
            this.tbtnExportForm.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnExportForm.color = System.Drawing.Color.SeaGreen;
            this.tbtnExportForm.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnExportForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnExportForm.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnExportForm.ForeColor = System.Drawing.Color.White;
            this.tbtnExportForm.Image = ((System.Drawing.Image)(resources.GetObject("tbtnExportForm.Image")));
            this.tbtnExportForm.ImagePosition = 19;
            this.tbtnExportForm.ImageZoom = 50;
            this.tbtnExportForm.LabelPosition = 39;
            this.tbtnExportForm.LabelText = "Tạo phiếu xuất";
            this.tbtnExportForm.Location = new System.Drawing.Point(460, 191);
            this.tbtnExportForm.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnExportForm.Name = "tbtnExportForm";
            this.tbtnExportForm.Size = new System.Drawing.Size(205, 211);
            this.tbtnExportForm.TabIndex = 1;
            this.tbtnExportForm.Click += new System.EventHandler(this.tbtnExportForm_Click);
            // 
            // tbtnBillForm
            // 
            this.tbtnBillForm.BackColor = System.Drawing.Color.SeaGreen;
            this.tbtnBillForm.color = System.Drawing.Color.SeaGreen;
            this.tbtnBillForm.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.tbtnBillForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbtnBillForm.Font = new System.Drawing.Font("Arial", 15F);
            this.tbtnBillForm.ForeColor = System.Drawing.Color.White;
            this.tbtnBillForm.Image = ((System.Drawing.Image)(resources.GetObject("tbtnBillForm.Image")));
            this.tbtnBillForm.ImagePosition = 19;
            this.tbtnBillForm.ImageZoom = 50;
            this.tbtnBillForm.LabelPosition = 39;
            this.tbtnBillForm.LabelText = "Xuất hoá đơn";
            this.tbtnBillForm.Location = new System.Drawing.Point(793, 191);
            this.tbtnBillForm.Margin = new System.Windows.Forms.Padding(6);
            this.tbtnBillForm.Name = "tbtnBillForm";
            this.tbtnBillForm.Size = new System.Drawing.Size(205, 211);
            this.tbtnBillForm.TabIndex = 2;
            // 
            // ProductSellingManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 622);
            this.Controls.Add(this.tbtnBillForm);
            this.Controls.Add(this.tbtnExportForm);
            this.Controls.Add(this.tbtnImportForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductSellingManagement";
            this.Text = "ProductSellingManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton tbtnImportForm;
        private Bunifu.Framework.UI.BunifuTileButton tbtnExportForm;
        private Bunifu.Framework.UI.BunifuTileButton tbtnBillForm;
    }
}