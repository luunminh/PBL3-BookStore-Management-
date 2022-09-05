using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Book_Store_Manager.GUI_Form
{
    public partial class ThemCaLam : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        public ThemCaLam()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool Check()
        {
            if (txtTenCaLam.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tên ca làm");
                txtTenCaLam.Focus();
                return false;
            }
            if (txtPhuCapCa.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tiền phụ cấp ca");
                txtTenCaLam.Focus();
                return false;
            }
            else
            {
                int kq;
                bool formatSL = int.TryParse(txtPhuCapCa.Text.Trim(), out kq);
                if (!formatSL)
                {
                    MessageBox.Show("Tiền phụ cấp ca không đúng định dạng!");
                    txtPhuCapCa.Clear();
                    txtPhuCapCa.Focus();
                    return false;
                }
            }
            if (txtGioBatDau.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập giờ bắt đầu");
                txtGioBatDau.Focus();
                return false;
            }
            else
            {
                if (CheckTime(txtGioBatDau.Text) == false)
                {
                    MessageBox.Show("Giờ bắt đầu không đúng định dạng! (HH:mm:ss)");
                    txtGioBatDau.Focus();
                    return false;
                }
            }
            if (txtGioKetThuc.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập giờ kết thúc");
                txtGioKetThuc.Focus();
                return false;
            }
            else
            {
                if (CheckTime(txtGioKetThuc.Text) == false)
                {
                    MessageBox.Show("Giờ kết thúc không đúng định dạng! (HH:mm:ss).");
                    txtGioKetThuc.Focus();
                    return false;
                }
            }
            int result = DateTime.Compare(Convert.ToDateTime(txtGioBatDau.Text), Convert.ToDateTime(txtGioKetThuc.Text));
            if (result >= 0)
            {
                MessageBox.Show("Giờ bắt đầu đã lớn hơn hoặc bằng giờ kết thúc. Vui lòng nhập lại.");
                return false;
            }
            if(txtGioBatDau.Text.Trim() == txtGioKetThuc.Text.Trim())
            {
                MessageBox.Show("Giờ bắt đầu bằng giờ kết thúc. Vui lòng nhập lại");
                return false;
            }
            return true;

        }
        public bool CheckTime(string time)
        {

            string[] tg = time.Split(':');
            if (tg.Length != 3)
            {
                return false;
            }
            int tgcheck;
            for (int i = 0; i < tg.Length; i++)
            {
                if ((Int32.TryParse(tg[i], out tgcheck) == true))
                {
                    if (i == 0)
                    {
                        if ((Convert.ToInt32(tg[i]) >= 0 && Convert.ToInt32(tg[i]) <= 23))
                            continue;
                        else return false;
                    }
                    else
                    {
                        if ((Convert.ToInt32(tg[i]) >= 0 && Convert.ToInt32(tg[i]) <= 59))
                            continue;
                        else return false;
                    }
                }
                else
                {
                    return false;
                }

            }

            return true;

        }
        private void btOK_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận thêm mới ca làm không ?", "Xác nhận thêm", MessageBoxButtons.YesNo);
            if(results == DialogResult.Yes)
            {
                if (Check())
                {
                    CaLam ud = new CaLam
                    {
                        MaCaLam = "",
                        TenCaLam = txtTenCaLam.Text,
                        TrangThai = "Hoạt động",
                        GioBatDau = TimeSpan.Parse(txtGioBatDau.Text),
                        GioKetThuc = TimeSpan.Parse(txtGioKetThuc.Text),
                        PhuCapCaLam = Convert.ToInt32(txtPhuCapCa.Text)
                    };
                    BLL_CaLam.Instance.ThemCaLam(ud);
                    MessageBox.Show("Thêm ca làm thành công");
                    d();
                    this.Dispose();
                }
            }
           
        }
    }
}
