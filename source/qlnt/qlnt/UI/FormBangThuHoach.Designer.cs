namespace qlnt
{
    partial class FormBangThuHoach
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBangThuHoach));
            this.dataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThuHoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanLuongThuHoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SanLuongThietHai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaBang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxThang = new System.Windows.Forms.ComboBox();
            this.bunifuImageButtonSearch = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNV,
            this.NgayThuHoach,
            this.SanLuongThuHoach,
            this.SanLuongThietHai,
            this.Xem,
            this.MaBang});
            this.dataGrid.DoubleBuffered = true;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.Silver;
            this.dataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGrid.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataGrid.Location = new System.Drawing.Point(40, 190);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid.Size = new System.Drawing.Size(623, 154);
            this.dataGrid.TabIndex = 9;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            this.dataGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellMouseLeave);
            this.dataGrid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_CellMouseMove);
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NgayThuHoach
            // 
            this.NgayThuHoach.DataPropertyName = "NgayThuHoach";
            this.NgayThuHoach.HeaderText = "Ngày thu hoạch";
            this.NgayThuHoach.Name = "NgayThuHoach";
            this.NgayThuHoach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NgayThuHoach.Width = 120;
            // 
            // SanLuongThuHoach
            // 
            this.SanLuongThuHoach.DataPropertyName = "SanLuongThuHoach";
            this.SanLuongThuHoach.HeaderText = "Tổng sản lượng thu hoạch";
            this.SanLuongThuHoach.Name = "SanLuongThuHoach";
            this.SanLuongThuHoach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SanLuongThuHoach.Width = 130;
            // 
            // SanLuongThietHai
            // 
            this.SanLuongThietHai.DataPropertyName = "SanLuongThietHai";
            this.SanLuongThietHai.HeaderText = "Tổng sản lượng thiệt hại";
            this.SanLuongThietHai.Name = "SanLuongThietHai";
            this.SanLuongThietHai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SanLuongThietHai.Width = 130;
            // 
            // Xem
            // 
            this.Xem.HeaderText = "Xem";
            this.Xem.Name = "Xem";
            this.Xem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xem.Text = "Xem";
            this.Xem.UseColumnTextForButtonValue = true;
            this.Xem.Width = 50;
            // 
            // MaBang
            // 
            this.MaBang.DataPropertyName = "MaBang";
            this.MaBang.HeaderText = "Column1";
            this.MaBang.Name = "MaBang";
            this.MaBang.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(112, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 42);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bảng thu hoạch nông sản";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(517, 132);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(44, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 30;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(567, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Thêm ";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(638, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 32;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Location = new System.Drawing.Point(331, 144);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(68, 21);
            this.comboBoxNam.TabIndex = 33;
            this.comboBoxNam.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tìm kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Năm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBoxThang
            // 
            this.comboBoxThang.FormattingEnabled = true;
            this.comboBoxThang.Location = new System.Drawing.Point(186, 144);
            this.comboBoxThang.Name = "comboBoxThang";
            this.comboBoxThang.Size = new System.Drawing.Size(64, 21);
            this.comboBoxThang.TabIndex = 34;
            // 
            // bunifuImageButtonSearch
            // 
            this.bunifuImageButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonSearch.Image")));
            this.bunifuImageButtonSearch.ImageActive = null;
            this.bunifuImageButtonSearch.Location = new System.Drawing.Point(424, 142);
            this.bunifuImageButtonSearch.Name = "bunifuImageButtonSearch";
            this.bunifuImageButtonSearch.Size = new System.Drawing.Size(40, 25);
            this.bunifuImageButtonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonSearch.TabIndex = 38;
            this.bunifuImageButtonSearch.TabStop = false;
            this.bunifuImageButtonSearch.Zoom = 10;
            this.bunifuImageButtonSearch.Click += new System.EventHandler(this.bunifuImageButtonSearch_Click);
            // 
            // FormBangThuHoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(675, 452);
            this.Controls.Add(this.bunifuImageButtonSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxThang);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBangThuHoach";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGrid;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxThang;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThuHoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanLuongThuHoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SanLuongThietHai;
        private System.Windows.Forms.DataGridViewButtonColumn Xem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBang;
    }
}