namespace qlnt.UI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlNavibar = new System.Windows.Forms.Panel();
            this.pnlWeather = new System.Windows.Forms.Panel();
            this.pnlToDoList = new System.Windows.Forms.Panel();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.pnlUnknownFeature = new System.Windows.Forms.Panel();
            this.fbtnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fbtnFunction2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dropManagement = new Bunifu.Framework.UI.BunifuDropdown();
            this.ibtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlSidebar.SuspendLayout();
            this.pnlNavibar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(34)))));
            this.pnlSidebar.Controls.Add(this.dropManagement);
            this.pnlSidebar.Controls.Add(this.fbtnFunction2);
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.fbtnDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(180, 720);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlNavibar
            // 
            this.pnlNavibar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(145)))), ((int)(((byte)(27)))));
            this.pnlNavibar.Controls.Add(this.ibtnClose);
            this.pnlNavibar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavibar.Location = new System.Drawing.Point(180, 0);
            this.pnlNavibar.Name = "pnlNavibar";
            this.pnlNavibar.Size = new System.Drawing.Size(1100, 60);
            this.pnlNavibar.TabIndex = 1;
            // 
            // pnlWeather
            // 
            this.pnlWeather.Location = new System.Drawing.Point(243, 81);
            this.pnlWeather.Name = "pnlWeather";
            this.pnlWeather.Size = new System.Drawing.Size(450, 280);
            this.pnlWeather.TabIndex = 2;
            // 
            // pnlToDoList
            // 
            this.pnlToDoList.Location = new System.Drawing.Point(764, 81);
            this.pnlToDoList.Name = "pnlToDoList";
            this.pnlToDoList.Size = new System.Drawing.Size(450, 280);
            this.pnlToDoList.TabIndex = 3;
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.Location = new System.Drawing.Point(243, 384);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(450, 280);
            this.pnlStatistics.TabIndex = 4;
            // 
            // pnlUnknownFeature
            // 
            this.pnlUnknownFeature.Location = new System.Drawing.Point(764, 384);
            this.pnlUnknownFeature.Name = "pnlUnknownFeature";
            this.pnlUnknownFeature.Size = new System.Drawing.Size(450, 280);
            this.pnlUnknownFeature.TabIndex = 5;
            // 
            // fbtnDashboard
            // 
            this.fbtnDashboard.Active = false;
            this.fbtnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(34)))));
            this.fbtnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnDashboard.BorderRadius = 0;
            this.fbtnDashboard.ButtonText = "Dashboard";
            this.fbtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnDashboard.Iconimage")));
            this.fbtnDashboard.Iconimage_right = null;
            this.fbtnDashboard.Iconimage_right_Selected = null;
            this.fbtnDashboard.Iconimage_Selected = null;
            this.fbtnDashboard.IconMarginLeft = 0;
            this.fbtnDashboard.IconMarginRight = 0;
            this.fbtnDashboard.IconRightVisible = true;
            this.fbtnDashboard.IconRightZoom = 0D;
            this.fbtnDashboard.IconVisible = true;
            this.fbtnDashboard.IconZoom = 90D;
            this.fbtnDashboard.IsTab = false;
            this.fbtnDashboard.Location = new System.Drawing.Point(0, 180);
            this.fbtnDashboard.Name = "fbtnDashboard";
            this.fbtnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnDashboard.selected = false;
            this.fbtnDashboard.Size = new System.Drawing.Size(180, 50);
            this.fbtnDashboard.TabIndex = 0;
            this.fbtnDashboard.Text = "Dashboard";
            this.fbtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnDashboard.Textcolor = System.Drawing.Color.White;
            this.fbtnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 180);
            this.panel1.TabIndex = 1;
            // 
            // fbtnFunction2
            // 
            this.fbtnFunction2.Active = false;
            this.fbtnFunction2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnFunction2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(34)))));
            this.fbtnFunction2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fbtnFunction2.BorderRadius = 0;
            this.fbtnFunction2.ButtonText = "Function 2";
            this.fbtnFunction2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbtnFunction2.DisabledColor = System.Drawing.Color.Gray;
            this.fbtnFunction2.Iconcolor = System.Drawing.Color.Transparent;
            this.fbtnFunction2.Iconimage = ((System.Drawing.Image)(resources.GetObject("fbtnFunction2.Iconimage")));
            this.fbtnFunction2.Iconimage_right = null;
            this.fbtnFunction2.Iconimage_right_Selected = null;
            this.fbtnFunction2.Iconimage_Selected = null;
            this.fbtnFunction2.IconMarginLeft = 0;
            this.fbtnFunction2.IconMarginRight = 0;
            this.fbtnFunction2.IconRightVisible = true;
            this.fbtnFunction2.IconRightZoom = 0D;
            this.fbtnFunction2.IconVisible = true;
            this.fbtnFunction2.IconZoom = 90D;
            this.fbtnFunction2.IsTab = false;
            this.fbtnFunction2.Location = new System.Drawing.Point(0, 236);
            this.fbtnFunction2.Name = "fbtnFunction2";
            this.fbtnFunction2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.fbtnFunction2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.fbtnFunction2.OnHoverTextColor = System.Drawing.Color.White;
            this.fbtnFunction2.selected = false;
            this.fbtnFunction2.Size = new System.Drawing.Size(180, 50);
            this.fbtnFunction2.TabIndex = 2;
            this.fbtnFunction2.Text = "Function 2";
            this.fbtnFunction2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fbtnFunction2.Textcolor = System.Drawing.Color.White;
            this.fbtnFunction2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dropManagement
            // 
            this.dropManagement.BackColor = System.Drawing.Color.Transparent;
            this.dropManagement.BorderRadius = 0;
            this.dropManagement.DisabledColor = System.Drawing.Color.Gray;
            this.dropManagement.ForeColor = System.Drawing.SystemColors.Control;
            this.dropManagement.Location = new System.Drawing.Point(0, 292);
            this.dropManagement.Name = "dropManagement";
            this.dropManagement.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(100)))), ((int)(((byte)(34)))));
            this.dropManagement.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(22)))));
            this.dropManagement.selectedIndex = -1;
            this.dropManagement.Size = new System.Drawing.Size(180, 50);
            this.dropManagement.TabIndex = 3;
            // 
            // ibtnClose
            // 
            this.ibtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ibtnClose.Image = ((System.Drawing.Image)(resources.GetObject("ibtnClose.Image")));
            this.ibtnClose.ImageActive = null;
            this.ibtnClose.Location = new System.Drawing.Point(1058, 12);
            this.ibtnClose.Name = "ibtnClose";
            this.ibtnClose.Size = new System.Drawing.Size(30, 30);
            this.ibtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnClose.TabIndex = 0;
            this.ibtnClose.TabStop = false;
            this.ibtnClose.Zoom = 10;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlUnknownFeature);
            this.Controls.Add(this.pnlStatistics);
            this.Controls.Add(this.pnlToDoList);
            this.Controls.Add(this.pnlWeather);
            this.Controls.Add(this.pnlNavibar);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Form2";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlNavibar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnDashboard;
        private System.Windows.Forms.Panel pnlNavibar;
        private System.Windows.Forms.Panel pnlWeather;
        private System.Windows.Forms.Panel pnlToDoList;
        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.Panel pnlUnknownFeature;
        private Bunifu.Framework.UI.BunifuDropdown dropManagement;
        private Bunifu.Framework.UI.BunifuFlatButton fbtnFunction2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton ibtnClose;
    }
}