﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlnt.DB;
using System.Text.RegularExpressions;
using qlnt.BUS;

namespace qlnt.DialogForm
{
    public interface hover
    {

    }
    public partial class Diablog_PB : Form
    {
        PhanBonBUS bus = new PhanBonBUS();
        PhanBon o;
        int id;

        public Diablog_PB()
        {
            InitializeComponent();
        }
        public Diablog_PB(string id)
        {
            InitializeComponent();
            PhanBonDB db = new PhanBonDB();
            // load noi dung de sua thong tin
            #region gắn giá trị
            this.id = Convert.ToInt32(id);
            o = db.getPhanBon(id);
            textTenPB.Text = o.TenPB ;
            comboBoxLoai.Text = o.Loai;
            textDonGia.Text = o.DonGia.ToString();
            textKhoiLuong.Text = o.KhoiLuong.ToString();
            textSoLuong.Text = o.SoLuong.ToString();
            DatepickerSX.Value = o.NgaySX;
            DatepickerSX.Value.ToString("dd/MM/yyyy");
            DatepickerHSD.Value = o.HanSD;
            DatepickerHSD.Value.ToString("dd/MM/yyyy");
            #endregion
            // An button add
            button_add.Enabled = false;
            button_add.Visible = false;
            //Hien button luu
            button_luu.Visible = true;
            //button_luu.Enabled = false;
        }
        public bool check()
        {
            checkString c = new checkString();
            if (c.isNUll(textTenPB.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                textTenPB.Focus();
                return false;
            }
            if (c.isNUll(comboBoxLoai.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                comboBoxLoai.Focus();
                return false;
            }
            if (c.isNUll(textSoLuong.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                textSoLuong.Focus();
                return false;
            }
            if (c.isNUll(textKhoiLuong.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                textKhoiLuong.Focus();
                return false;
            }
            if (c.isNUll(textDonGia.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                textDonGia.Focus();
                return false;
            }
            if (!c.isNumber(textSoLuong.Text))
            {
                MessageBox.Show("Dữ liệu số lượng phải là số");
                textSoLuong.Focus();
                return false;
            }
            if (!c.isNumber(textKhoiLuong.Text))
            {
                MessageBox.Show("Dữ liệu khối lượng phải là số");
                textKhoiLuong.Focus();
                return false;
            }
            return true;
        }
        private void Dialog_close()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void button_add_Click(object sender, EventArgs e)
        {

            if(check())
            {
                o = new PhanBon() { TenPB = textTenPB.Text, Loai = comboBoxLoai.Text, SoLuong = Convert.ToInt32(textSoLuong.Text), DonGia = Convert.ToDouble(textDonGia.Text), KhoiLuong = Convert.ToInt32(textKhoiLuong.Text), NgaySX = DatepickerSX.Value.Date, HanSD = DatepickerHSD.Value.Date };
                bus.Add(o);
                Dialog_close();
            }            
            #region kt
            //string t="Tên phân bón : {0} \n Loại: {1} \n Ngày sx: {2} \n hạn sử dụng: {3}";
            //string msg = string.Format(t,o.TenPB,o.Loai,o.NgaySX.ToString("dd//MM/yyyy"), o.HanSD.ToString("dd//MM/yyyy"));
            //MessageBox.Show(msg);

            //DatepickerSX.Value.ToString("dd/MM/yyyy")
            //MessageBox.Show(textTenPB.Text+" " + comboBoxLoai.Text );

            //MessageBox.Show("thành công");
            #endregion

        }

        private void add_PB_Load(object sender, EventArgs e)
        {
            List<string> l=new List<string>() {"Vô cơ", "Hữu cơ"} ;
            comboBoxLoai.DataSource = l;
            //DatepickerSX.Format = DateTimePickerFormat.Custom;
            //DatepickerSX.FormatCustom = "dd/MM/yyyy";

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            if (check())
            {
                o = new PhanBon() { MaPB = this.id, TenPB = textTenPB.Text, Loai = comboBoxLoai.Text, SoLuong = Convert.ToInt32(textSoLuong.Text), DonGia = Convert.ToDouble(textDonGia.Text), KhoiLuong = Convert.ToInt32(textKhoiLuong.Text), NgaySX = DatepickerSX.Value.Date, HanSD = DatepickerHSD.Value.Date };
                bus.Edit(o);
                MessageBox.Show("Sửa thành công");
                Dialog_close();
            }
        }
    }
}