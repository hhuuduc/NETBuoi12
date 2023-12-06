using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongHoiNghi
{
    public partial class frmPhongHoiNghi : Form
    {

        HoiNghi_DAO hn = new HoiNghi_DAO();

        LoaiPhong_DAO lp = new LoaiPhong_DAO();

        public frmPhongHoiNghi()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txt_MaHoiNghi.Text = "";
            txt_TenHoiNghi.Text = "";
            txtSoNguoiThamGia.Text = "";
            cb_LoaiPhong.Text = "";
        }

        private void frmPhongHoiNghi_Load(object sender, EventArgs e)
        {
            List<HoiNghi> dshn = hn.LoadDSHN();
            dtgv_PhongHoiNghi.DataSource = null;
            dtgv_PhongHoiNghi.DataSource = dshn;
            dtgv_PhongHoiNghi.Columns[0].HeaderText = "Mã Hội Nghị";
            dtgv_PhongHoiNghi.Columns[1].HeaderText = "Tên Hội Nghị";
            dtgv_PhongHoiNghi.Columns[2].HeaderText = "Mã Loại Phòng";
            dtgv_PhongHoiNghi.Columns[3].HeaderText = "Số lượng";
            List<LoaiPhong> dsp = lp.LoadDSP();
            cb_LoaiPhong.Items.Clear();
            cb_LoaiPhong.Items.Add("");
            for (int i = 0; i < dsp.Count(); i++)
            {
                cb_LoaiPhong.Items.Add(dsp[i].tenLoaiPhong);
            }
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                HoiNghi hnnew = new HoiNghi();
                hnnew.maHoiNghi = txt_MaHoiNghi.Text.ToString();
                hnnew.tenHoiNghi = txt_TenHoiNghi.Text.ToString();
                hnnew.soNguoi = Convert.ToInt32(txtSoNguoiThamGia.Text);
                List<LoaiPhong> dsp = lp.LoadDSP();
                for (int i = 0; i < dsp.Count(); i++)
                {
                    if (String.Compare(cb_LoaiPhong.Text, dsp[i].tenLoaiPhong, false) == 0)
                        hnnew.maLoaiPhong = dsp[i].maLoaiPhong;
                }
                hn.ThemHoiNghi(hnnew);
                MessageBox.Show("Lưu thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                frmPhongHoiNghi_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = dtgv_PhongHoiNghi.Rows[dtgv_PhongHoiNghi.CurrentRow.Index].Cells[0].Value.ToString();
                hn.XoaHoiNghi(ma);
                MessageBox.Show("Xóa hội nghị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                frmPhongHoiNghi_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgv_PhongHoiNghi_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dtgv_PhongHoiNghi.CurrentRow != null)
            {
                txt_MaHoiNghi.Text = dtgv_PhongHoiNghi.Rows[dtgv_PhongHoiNghi.CurrentRow.Index].Cells[0].Value.ToString();
                txt_TenHoiNghi.Text = dtgv_PhongHoiNghi.Rows[dtgv_PhongHoiNghi.CurrentRow.Index].Cells[1].Value.ToString();
                txtSoNguoiThamGia.Text = dtgv_PhongHoiNghi.Rows[dtgv_PhongHoiNghi.CurrentRow.Index].Cells[3].Value.ToString();
                List<LoaiPhong> dsp = lp.LoadDSP();
                for (int i = 0; i < dsp.Count(); i++)
                {
                    if (String.Compare(dtgv_PhongHoiNghi.Rows[dtgv_PhongHoiNghi.CurrentRow.Index].Cells[2].Value.ToString(), dsp[i].maLoaiPhong, false) == 0)
                        cb_LoaiPhong.Text = dsp[i].tenLoaiPhong;
                }
            }
        }

        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_LocDanhSach_Click(object sender, EventArgs e)
        {
            if (String.Compare(cb_LoaiPhong.Text, "", true) == 0)
            {
                frmPhongHoiNghi_Load(sender, e);
            }
            else
            {
                List<LoaiPhong> dsp = lp.LoadDSP();
                string ma = "";
                for (int i = 0; i < dsp.Count(); i++)
                {
                    if (String.Compare(cb_LoaiPhong.Text, dsp[i].tenLoaiPhong, false) == 0)
                        ma = dsp[i].maLoaiPhong;
                }

                List<HoiNghi> dshncdk = hn.LoadDSHNcoDK(ma);
                dtgv_PhongHoiNghi.DataSource = null;
                dtgv_PhongHoiNghi.DataSource = dshncdk;
                dtgv_PhongHoiNghi.Columns[0].HeaderText = "Mã Hội Nghị";
                dtgv_PhongHoiNghi.Columns[1].HeaderText = "Tên Hội Nghị";
                dtgv_PhongHoiNghi.Columns[2].HeaderText = "Mã Loại Phòng";
                dtgv_PhongHoiNghi.Columns[3].HeaderText = "Số lượng";
            }
        }

        private void txtSoNguoiThamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void frmPhongHoiNghi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
