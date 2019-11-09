using System;
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
    public partial class Diablog_PB : Form
    {
        public Diablog_PB()
        {
            InitializeComponent();
        }
        PhanBon o;
        public Diablog_PB(string id)
        {
            InitializeComponent();
            PhanBonDB db = new PhanBonDB();
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

            button_add.Enabled = false;
            button_add.Visible = false;
            button_luu.Visible = true;
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            o = new PhanBon() { TenPB = textTenPB.Text, Loai = comboBoxLoai.Text, SoLuong = Convert.ToInt32(textSoLuong.Text), DonGia = Convert.ToDouble(textDonGia.Text), KhoiLuong = Convert.ToInt32(textKhoiLuong.Text), NgaySX = DatepickerSX.Value.Date, HanSD = DatepickerHSD.Value.Date };
            PhanBonBUS bus = new PhanBonBUS();
            bus.them(o);
            #region kt
            //string t="Tên phân bón : {0} \n Loại: {1} \n Ngày sx: {2} \n hạn sử dụng: {3}";
            //string msg = string.Format(t,o.TenPB,o.Loai,o.NgaySX.ToString("dd//MM/yyyy"), o.HanSD.ToString("dd//MM/yyyy"));
            //MessageBox.Show(msg);

            //DatepickerSX.Value.ToString("dd/MM/yyyy")
            //MessageBox.Show(textTenPB.Text+" " + comboBoxLoai.Text );

            //MessageBox.Show("thành công");
            #endregion
            this.DialogResult = DialogResult.OK;
            this.Close();

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
            MessageBox.Show("lưu");
        }
    }
}
