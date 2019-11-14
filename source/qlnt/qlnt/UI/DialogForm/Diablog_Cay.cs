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
  
    public partial class Diablog_Cay : Form
    {
        CayBUS bus = new CayBUS();
        Cay o;
        int id;

        public Diablog_Cay()
        {
            InitializeComponent();
        }
        public Diablog_Cay(string id)
        {
            InitializeComponent();
            CayDB db = new CayDB();
            // load noi dung de sua thong tin
            #region gắn giá trị
            this.id = Convert.ToInt32(id);
            o = db.GetCay(id);
            textTenCay.Text = o.TenCay ;
            comboBoxMuaThuHoach.Text = o.MuaThuHoach;
            textSoLuong.Text = o.SoLuong.ToString();
            DatepickerNamGieoDau.Value = o.NamGieoDau ;
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
            if (c.isNUll(textTenCay.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                textTenCay.Focus();
                return false;
            }
            if (c.isNUll(comboBoxMuaThuHoach.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                comboBoxMuaThuHoach.Focus();
                return false;
            }
            if (c.isNUll(textSoLuong.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                textSoLuong.Focus();
                return false;
            }
            if (!c.isNumber(textSoLuong.Text))
            {
                MessageBox.Show("Dữ liệu số lượng phải là số");
                textSoLuong.Focus();
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
                o = new Cay() {TenCay = o.TenCay, SoLuong = o.SoLuong, MuaThuHoach = o.MuaThuHoach, NamGieoDau = o.NamGieoDau,MaLoaiCay=o.MaLoaiCay };
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
            List<string> l=new List<string>() {"Xuân", "Hạ", "Thu", "Đông" } ;
            comboBoxMuaThuHoach.DataSource = l;
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
                o = new Cay() { MaLoaiCay = this.id, TenCay = textTenCay.Text, MuaThuHoach = comboBoxMuaThuHoach.Text, SoLuong = Convert.ToInt32(textSoLuong.Text),NamGieoDau=DatepickerNamGieoDau.Value.Date, };
                bus.Edit(o);
                MessageBox.Show("Sửa thành công");
                Dialog_close();
            }
        }

        private void labelTen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
