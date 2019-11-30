﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnt.UI
{
    public partial class ExportMngmt : Form
    {
        public ExportMngmt()
        {
            InitializeComponent();
        }
        private void hideComponents()
        {
            tbtnCreateExpf.Visible = false;
            tbtnSearchExpf.Visible = false;
        }

        private void showComponents()
        {
            tbtnCreateExpf.Visible = true;
            tbtnSearchExpf.Visible = true;
        }

        private void ibtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
