using PBL3_Book_Store_Manager.BLL;
using PBL3_Book_Store_Manager.GUI.GUI_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Book_Store_Manager.GUI.GUI__AD.UC_Control
{
    public partial class UC_DeXuat : UserControl
    {
        string MaChucVu { get; set; }
        public UC_DeXuat(string maChucVu)
        {
            InitializeComponent();
            MaChucVu = maChucVu;
            setGUI();
        }
        public void setGUI()
        {
            dgvDeXuat.DataSource = BLL_DeXuat.Instance.GetAllListDeXuatView_BLL();
           // dgvDeXuat.Columns["TenNguoiDaiDienPhapLy"].Visible = false;
            //dgvDeXuat.Columns["TenNguoiDaiDienKinhDoanh"].Visible = false;
           // dgvDeXuat.Columns["TrangThai"].Visible = false;
            dgvDeXuat.Columns[0].HeaderText = "Mã đề xuất";
            dgvDeXuat.Columns[1].HeaderText = "Tên nhân viên";
            dgvDeXuat.Columns[2].HeaderText = "Tình trạng";
            dgvDeXuat.Columns[3].HeaderText = "Loại đề xuất";
            dgvDeXuat.Columns[4].HeaderText = "Thời gian";
            dgvDeXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbbSortDeXuat.SelectedIndex = 0;
        }

        private void btSearchDeXuat_Click(object sender, EventArgs e)
        {
            if (cbbSortDeXuat.SelectedIndex == 0)
            {
                if (txtSearchDeXuat.Text.Trim() == null)
                {
                    dgvDeXuat.DataSource = BLL_DeXuat.Instance.GetAllListDeXuatView_BLL();
                }
                else dgvDeXuat.DataSource = BLL_DeXuat.Instance.SearchListDeXuatByMaDX(txtSearchDeXuat.Text);
            }
            else if (cbbSortDeXuat.SelectedIndex == 1)
            {
                if (txtSearchDeXuat.Text.Trim() == null)
                {
                    dgvDeXuat.DataSource = BLL_DeXuat.Instance.GetAllListDeXuatView_BLL();
                }
                else dgvDeXuat.DataSource = BLL_DeXuat.Instance.SearchListDeXuatByTenNV(txtSearchDeXuat.Text);
            }
            else if (cbbSortDeXuat.SelectedIndex == 2)
            {
                if (txtSearchDeXuat.Text.Trim() == null)
                {
                    dgvDeXuat.DataSource = BLL_DeXuat.Instance.GetAllListDeXuatView_BLL();
                }
                else dgvDeXuat.DataSource = BLL_DeXuat.Instance.SearchListDeXuatByLoaiDX(txtSearchDeXuat.Text);
            }
            else if (cbbSortDeXuat.SelectedIndex == 3)
            {
                if (txtSearchDeXuat.Text.Trim() == null)
                {
                    dgvDeXuat.DataSource = BLL_DeXuat.Instance.GetAllListDeXuatView_BLL();
                }
                else dgvDeXuat.DataSource = BLL_DeXuat.Instance.SearchListDeXuatByTinhTrang(txtSearchDeXuat.Text);
            }
        }

        private void btChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDeXuat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đối tượng đề xuất cần xem chi tiết");
            }
            else if (dgvDeXuat.SelectedRows.Count == 1)
            {
                if(BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(dgvDeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString()).LoaiDeXuat.Contains("cung ứng"))
                {
                    if(MaChucVu =="CV000")
                    {
                        ChiTietDeXuatNCU_AD dxncu = new ChiTietDeXuatNCU_AD(dgvDeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString());
                        dxncu.d += new ChiTietDeXuatNCU_AD.MyDel(setGUI);
                        dxncu.ShowDialog();
                        setGUI();

                    }
                    else
                    {
                        ChiTietDeXuatNCU_NV dxncu = new ChiTietDeXuatNCU_NV(dgvDeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString());
                        dxncu.ShowDialog();
                        setGUI();
                    }
                }  else if ((BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(dgvDeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString()).LoaiDeXuat == "Đề xuất nhập hàng hóa vào kho") )
                {
                    if (MaChucVu == "CV000")
                    {
                        ChiTietDeXuatHoaDonNhapKho_AD CTDXHDNhap = new ChiTietDeXuatHoaDonNhapKho_AD(dgvDeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString());
                        CTDXHDNhap.ShowDialog();
                        setGUI();

                    }
                    else
                    {
                        ChiTietDeXuatHoaDonNhapKho_NV CTDXHDNhap = new ChiTietDeXuatHoaDonNhapKho_NV(dgvDeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString());
                        CTDXHDNhap.ShowDialog();
                        setGUI();
                    }
                } else if((BLL_DeXuat.Instance.GetDeXuatByMaDeXuat(dgvDeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString()).LoaiDeXuat == "Đề xuất xuất hàng hóa lên kệ"))
                {
                    if(MaChucVu == "CV000")
                    {
                        ChiTietDeXuatHoaDonXuatKho_AD cddxhdxk = new ChiTietDeXuatHoaDonXuatKho_AD(dgvDeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString());
                        cddxhdxk.ShowDialog();
                        setGUI();
                    }
                    else
                    {
                        ChiTietDeXuatHoaDonXuatKho_NV cddxhdxk = new ChiTietDeXuatHoaDonXuatKho_NV(dgvDeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString());
                        cddxhdxk.ShowDialog();
                    }
                }else
                {
                    if (MaChucVu == "CV000")
                    {
                        ChiTietDeXuatHH_Ad ctdxhh = new ChiTietDeXuatHH_Ad(dgvDeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString());
                        ctdxhh.ShowDialog();
                        setGUI();
                    }
                    else
                    {
                        ChiTietDeXuatHangHoa_NV ctdxhh = new ChiTietDeXuatHangHoa_NV(dgvDeXuat.SelectedRows[0].Cells["MaDeXuat"].Value.ToString());
                        ctdxhh.ShowDialog();
                        setGUI();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ được chọn 1 đối tượng đề xuất để xem chi tiết");
            }
        }
    }
}
