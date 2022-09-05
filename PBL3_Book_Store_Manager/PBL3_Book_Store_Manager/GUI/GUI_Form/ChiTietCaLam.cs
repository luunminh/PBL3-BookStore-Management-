using _3Layers.DTO;
using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.DAL;
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
    public partial class ChiTietCaLam : Form
    {
        public delegate void MyDel();
        public MyDel d { get; set; }
        string MaCaLam { get; set; }
        List<ChiTietCaLamView> ctclView = new List<ChiTietCaLamView>();
        // List<CTCaLam> ccCa = new List<CTCaLam>();
        public ChiTietCaLam(string maCaLam)
        {
            InitializeComponent();
            MaCaLam = maCaLam;
            ctclView = BLL_CaLam.Instance.GetListCTCaLamViewByMaCaLam(MaCaLam);
            // ccCa = BLL_CaLam.Instance.GetListCTCaLamByMaCaKhongTrangThai(MaCaLam);
            setGUI(MaCaLam);
        }
        public void setGUI(string maCaLam)
        {
            CaLam s = new CaLam();
            s = BLL_CaLam.Instance.GetCaLamByMaCaLam(maCaLam);
            txtTenCaLam.Text = s.TenCaLam.ToString();
            txtPhuCapCa.Text = s.PhuCapCaLam.ToString();
            //dtpBatDau.Value = s.GioBatDau;
            txtGioBatDau.Text = s.GioBatDau.ToString();
            txtGioKetThuc.Text = s.GioKetThuc.ToString();
            dgvNVTrongCa.DataSource = ctclView;
            dgvNVTrongCa.Columns["MaNhanVien"].Visible = false;
            dgvNVTrongCa.Columns[0].HeaderText = "Mã ca làm";
            dgvNVTrongCa.Columns[1].HeaderText = "Tên nhân viên";
            dgvNVTrongCa.Columns[2].HeaderText = "Trạng thái";
            dgvNVTrongCa.Columns[3].HeaderText = "Trạng thái";
            dgvNVTrongCa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbNV.Items.AddRange(BLL_NV.Instance.GetCBB().ToArray());

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool CheckNVCoTrongCa()
        {
            foreach(ChiTietCaLamView i in ctclView)
            {
                if(i.MaNhanVien == ((CBBItems)(cbbNV.SelectedItem)).Value)
                {
                    return true;
                }    
            }
            return false;
        }
        private void btThem_Click(object sender, EventArgs e)
        {

            if (cbbNV.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần thêm vào.");
            }
            else if (cbbNV.SelectedIndex >= 0 )
            {
              //  List<ChiTietCaLamView> ctclviews2 = ctclView;
                
               
                    if (CheckNVCoTrongCa())
                    {
                        MessageBox.Show("Nhân viên đã có trong ca làm này.");
                        //break;
                    }
                    else
                    {
                        ChiTietCaLamView ctcll = new ChiTietCaLamView
                        {
                            MaCaLam = MaCaLam,
                            TenNhanVien = ((CBBItems)(cbbNV.SelectedItem)).Text,
                            TrangThai = "Đang làm việc",
                            MaNhanVien = ((CBBItems)(cbbNV.SelectedItem)).Value
                        };

                        // ccCa.Add(cccl);
                        ctclView.Add(ctcll);
                        dgvNVTrongCa.DataSource = null;
                        dgvNVTrongCa.DataSource = ctclView;
                        dgvNVTrongCa.Columns["MaNhanVien"].Visible = false;
                        dgvNVTrongCa.Columns[0].HeaderText = "Mã ca làm";
                        dgvNVTrongCa.Columns[1].HeaderText = "Tên nhân viên";
                        dgvNVTrongCa.Columns[2].HeaderText = "Trạng thái";
                        dgvNVTrongCa.Columns[3].HeaderText = "Trạng thái";
                    //break;
                    

                }

                   
                }    
            }

        
        public bool Check()
        {
            if (txtTenCaLam.Text.Replace(" ","" ).Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên ca làm");
                txtTenCaLam.Focus();
                return false;
            }
            if (txtPhuCapCa.Text.Replace(" ", "").Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tiền phụ cấp ca");
                txtPhuCapCa.Focus();
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
            if (txtGioBatDau.Text.Trim() == txtGioKetThuc.Text.Trim())
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
                    if(i ==0)
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
        

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult results = MessageBox.Show("Bạn có muốn xác nhận cập nhật ca làm không ?", "Xác nhận cập nhật", MessageBoxButtons.YesNo);
            if (results == DialogResult.Yes)
            {
                     CaLam ud = new CaLam
            {
                MaCaLam = MaCaLam,
                TenCaLam = txtTenCaLam.Text,
                TrangThai = "Hoạt động",
                GioBatDau = TimeSpan.Parse(txtGioBatDau.Text),
                GioKetThuc = TimeSpan.Parse(txtGioKetThuc.Text),
                PhuCapCaLam = Convert.ToInt32(txtPhuCapCa.Text)
            };
                if (Check())
                {
                    if (BLL_CaLam.Instance.CheckUpDateCa(ud) == true)
                    {
                        this.Dispose();
                    }
                    else
                    {

                        if(Check())
                        {
                            BLL_CaLam.Instance.CheckCTCL(ctclView, MaCaLam);
                            MessageBox.Show("Cập nhật ca làm thành công");
                            d();
                            this.Dispose();
                        }    
                      


                    }
                }
            }    
           

           
            
           
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvNVTrongCa.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên cần tạm ngưng.");
            }
           
                else
                {
                    foreach(ChiTietCaLamView i in ctclView)
                    {
                        if(i.MaCaLam == dgvNVTrongCa.SelectedRows[0].Cells["MaCaLam"].Value.ToString() && i.MaNhanVien == dgvNVTrongCa.SelectedRows[0].Cells["MaNhanVien"].Value.ToString())
                        {
                             i.TrangThai = "Tạm ngưng";
                        }    
                    }    

                    // ccCa.Add(cccl);
                    
                    dgvNVTrongCa.DataSource = null;
                    dgvNVTrongCa.DataSource = ctclView;
                    dgvNVTrongCa.Columns["MaNhanVien"].Visible = false;
                    dgvNVTrongCa.Columns[0].HeaderText = "Mã ca làm";
                    dgvNVTrongCa.Columns[1].HeaderText = "Tên nhân viên";
                    dgvNVTrongCa.Columns[2].HeaderText = "Trạng thái";
                    dgvNVTrongCa.Columns[3].HeaderText = "Trạng thái";
                    //break;


                }


            
        }
    }
}
