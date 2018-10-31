using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E00_Base;
using DevComponents.DotNetBar;
using E00_Common;
using E00_Model;
using AttachFile;
using TA_MessageBox;


namespace E15_LichLamViec
{
    public partial class frmKhaiBaoLichLamViecChiTiet : Office2007Form
    {
        #region Biến toàn cục
        private LibDal.AccessData _v = new LibDal.AccessData();
        private Api_Common _api = new Api_Common();
        private Acc_Oracle _acc = new Acc_Oracle();
        private DataSet _dt = new DataSet();
        private DataTable _dt1 = new DataTable();
        private List<string> _lst1 = new List<string>();
        private string _userError = "";
        private string _systemError = "";
        private string _ID = "";
        private string _lstID = "";
        private string _lstTen = "";
        private int _rowIndex = 0;
        private int _r;
        private bool _isAdd = true;
        #endregion

        #region Khởi tạo 

        public frmKhaiBaoLichLamViecChiTiet()
        {
            InitializeComponent();
            _api.KetNoi();
        }

        #endregion

        #region Phương thức

        #region Private

        private void Load_cboNhansu()
        {
            try
            {
                DataTable c = new DataTable();
                List<string> lst = new List<string>();
                lst.Add(cls_BacSi.col_Ma);
                lst.Add(cls_BacSi.col_HoTen);
                c = _api.Search(ref _userError, ref _systemError, cls_BacSi.tb_TenBang, _acc.Get_User(), -1, lst);
                cboNhansu.DataSource = c;
            }
            catch
            {
            }
        }

        private void Load_cboLoai()
        {
            DataTable a = new DataTable();
            List<string> lst = new List<string>();
            lst.Add(cls_SYS_DanhMuc.col_Ma);
            lst.Add(cls_SYS_DanhMuc.col_Ten);
            Dictionary<string, string> dicEqual = new Dictionary<string, string>();
            dicEqual.Add(cls_SYS_DanhMuc.col_Loai, "LichKham1");
            a = _api.Search(ref _userError, ref _systemError, cls_SYS_DanhMuc.tb_TenBang, _acc.Get_User(), -1, lst, dicEqual: dicEqual);
            cboLoai.DataSource = a;
        }

        private void Load_cboDouutien()
        {
            DataTable b = new DataTable();
            List<string> lst = new List<string>();
            lst.Add(cls_SYS_DanhMuc.col_Ma);
            lst.Add(cls_SYS_DanhMuc.col_Ten);
            Dictionary<string, string> dicEqual = new Dictionary<string, string>();
            dicEqual.Add(cls_SYS_DanhMuc.col_Loai, "LichKham");
            b = _api.Search(ref _userError, ref _systemError, cls_SYS_DanhMuc.tb_TenBang, _acc.Get_User(), -1, lst, dicEqual: dicEqual);
            cboDouutien.DataSource = b;
        }

        private void Load_nguyenngay()
        {
            int n;
            try
            {
                SwtNguyenngay.ImeMode = ImeMode.On;
                n = 1;
            }
            catch
            {
                SwtNguyenngay.ImeMode = ImeMode.Off;
                n = 0;
            }
            _r = n;
        }

        private void Load_dgvChiTietLichLamViec()
        {
            string sql = "SELECT B.HOTEN, A.TIEUDE, A.NOIDUNG, A.LOAI, A.DOUUTIEN, A.NSCUNGTHAMGIA, A.TU, A.DEN, A.ID"
                            + " FROM " + _acc.Get_UserMMYY() + ".NS_LICHLAMVIECCT A"
                            + " INNER JOIN " + _acc.Get_User() + ".DMBS B ON B.MA = A.MABS"
                            + " WHERE A.MABS = '" + cboNhansu.txtMa.Text + "'";
            dgvChiTietLichLamViec.DataSource = _acc.Get_Data(sql);
        }

        private bool KiemTraTrung(DateTime dttu, DateTime dtden)
        {
            if (dttu.ToString("MM/dd/yyyy HH:mm").CompareTo(DateTime.Now.ToString("MM/dd/yyyy HH:mm")) > 0)
            {
                string sql1 = "select * from " + _acc.Get_UserMMYY() + ".NS_LICHLAMVIECCT "
                                        + " where(mabs = '" + cboNhansu.txtMa.Text + "')"
                                        + " and((tu between to_date('" + dpkTu.Value.ToString("MM/dd/yyyy HH:mm") + "', 'mm/dd/yyyy : HH24:MI ') and to_date('"
                                        + dpkDen.Value.ToString("MM/dd/yyyy HH:mm") + "', 'mm/dd/yyyy : HH24:MI'))"
                                        + " or(den between to_date('" + dpkTu.Value.ToString("MM/dd/yyyy HH:mm") + "', 'mm/dd/yyyy : HH24:MI ') and to_date('"
                                        + dpkDen.Value.ToString("MM/dd/yyyy HH:mm") + "', 'mm/dd/yyyy : HH24:MI')))";
                if (!_isAdd)
                {
                    sql1 += "AND ID <> '" + _ID + "'";
                }
                _dt1 = _acc.Get_Data(sql1);
                if (_dt1.Rows.Count == 0)
                {
                    return true;
                }
                else
                {
                    this._v.MsgBox("Lịch trùng");
                }
            }
            else
            {
                this._v.MsgBox("Lịch công việc không thể bé hơn ngày hiện tại");
                return false;
            }
            return false;
        }

        private void Luu()
        {
            DateTime dttu = dpkTu.Value;
            DateTime dtden = dpkDen.Value;
            {
                string s;
                try
                {
                    s = this.cboNhansu.his_GetSelectedIndex.ToString();
                }
                catch
                {
                    s = "";
                }
                if ((s.Trim() == ""))
                {
                    this._v.MsgBox("Chọn tên bác sĩ tương ứng");
                    this.cboNhansu.Focus();
                }
                else
                if (this.txtNoidung.Text.Trim() == "")
                {
                    this._v.MsgBox("Nhập nội dung");
                    this.txtNoidung.Focus();
                }
                else
                {
                    if (DateTime.Parse(dttu.ToString("MM/dd/yyyy HH:mm")) < DateTime.Parse(dtden.ToString("MM/dd/yyyy HH:mm")))
                    {
                        #region Lưu
                        try
                        {
                            //-------------------
                            Dictionary<string, string> lstData = new Dictionary<string, string>();
                            lstData.Add(cls_NS_LichLamViecCT.col_ID, _acc.Get_Ma());
                            lstData.Add(cls_NS_LichLamViecCT.col_MABS, cboNhansu.txtMa.Text.Trim());
                            lstData.Add(cls_NS_LichLamViecCT.col_TIEUDE, txtTieude.Text.Trim());
                            lstData.Add(cls_NS_LichLamViecCT.col_NOIDUNG, txtNoidung.Text.Trim());
                            lstData.Add(cls_NS_LichLamViecCT.col_DEN, dpkDen.Value.ToString("MM/dd/yyyy HH:mm"));
                            lstData.Add(cls_NS_LichLamViecCT.col_LOAI, cboLoai.txtTen.Text.Trim());
                            lstData.Add(cls_NS_LichLamViecCT.col_TU, dpkTu.Value.ToString("MM/dd/yyyy HH:mm"));
                            lstData.Add(cls_NS_LichLamViecCT.col_DOUUTIEN, cboDouutien.txtTen.Text);
                            lstData.Add(cls_NS_LichLamViecCT.col_NSCUNGTHAMGIA, txtNhansucungthamgia.Text);
                            lstData.Add(cls_NS_LichLamViecCT.col_NGUYENNGAY, _r.ToString().Trim());

                            if (KiemTraTrung(dttu, dtden))
                            {
                                if (_isAdd)
                                {
                                    List<string> lstKiemTraTrung = new List<string>();
                                    lstKiemTraTrung.Add(cls_NS_LichLamViecCT.col_ID);
                                    if (_api.Insert(ref _userError, ref _systemError, cls_NS_LichLamViecCT.tb_TenBang, lstData, lstKiemTraTrung, new List<string>(), _acc.Get_UserMMYY()))
                                    {
                                        _dt1 = _api.Search(ref _userError, ref _systemError, cls_NS_LichLamViecCT.tb_TenBang, _acc.Get_UserMMYY(), -1, orderByASC1: false, orderByName1: cls_NS_LichLamViecCT.col_ID);
                                        txtNhansucungthamgia.Text = txtNoidung.Text = txtTieude.Text = dpkTu.Text = dpkDen.Text = "";
                                        Load_dgvChiTietLichLamViec();
                                        TA_MessageBox.MessageBox.Show("Lưu thành công");
                                        btnLuu.Enabled = false;
                                    }
                                }
                                else
                                {
                                    Dictionary<string, string> lst2 = new Dictionary<string, string>();
                                    lst2.Add(cls_NS_LichLamViecCT.col_ID, dgvChiTietLichLamViec.SelectedRows[0].Cells["colID"].Value.ToString());
                                    if (_api.UpdateAll(ref _userError, ref _systemError, cls_NS_LichLamViecCT.tb_TenBang, lstData, lst2, _acc.Get_UserMMYY()))
                                    {
                                        _dt1 = _api.Search(ref _userError, ref _systemError, cls_NS_LichLamViecCT.tb_TenBang, _acc.Get_UserMMYY(), -1, orderByASC1: false, orderByName1: cls_NS_LichLamViecCT.col_ID);
                                        txtNhansucungthamgia.Text = txtNoidung.Text = txtTieude.Text = dpkTu.Text = dpkDen.Text = "";
                                        Load_dgvChiTietLichLamViec();
                                        TA_MessageBox.MessageBox.Show("Sửa thành công");
                                        btnLuu.Enabled = false;
                                    }
                                }
                            }
                            //---------------------------
                            //string sql = "INSERT INTO " + _acc.Get_UserMMYY() + ".NS_LICHLAMVIECCT(ID, MABS, TIEUDE, NOIDUNG, LOAI, TU, DEN, DOUUTIEN, NSCUNGTHAMGIA, NGUYENNGAY)"
                            //             + "VALUES('" + _acc.Get_Ma() + "','" + cboNhansu.txtMa.Text + "','"
                            //             + txtTieude.Text.Trim() + "','"
                            //             + txtNoidung.Text.Trim() + "','"
                            //             + cboLoai.txtTen.Text + "',to_date('"
                            //             + dpkTu.Value.ToString("MM/dd/yyyy HH:mm")
                            //             + "','MM/DD/YYYY HH24:mi:ss'), to_date('"
                            //             + dpkDen.Value.ToString("MM/dd/yyyy HH:mm")
                            //             + "','MM/DD/YYYY HH24:mi:ss')" + ",'"
                            //             + cboDouutien.txtTen.Text + "','"
                            //             + txtNhansucungthamgia.Text.Trim() + "','" + r + "')";
                            //_acc.Execute_Data(ref _userError, ref _systemError, sql, null);
                        }
                        catch
                        {
                            this._v.MsgBox("Lưu Thất Bại");
                        }
                        #endregion
                    }
                    else
                    {
                        this._v.MsgBox("Ngày không hợp lệ");
                    }
                }
            }
        }

        private void Sua()
        {
            Show_Chi_Tiet();
        }

        private void Xoa()
        {
            if (_lstID.Length > 0)
            {
                _lstID = _lstID.Substring(0, _lstID.Length - 1);
                _lstTen = _lstTen.Substring(0, _lstTen.Length - 1);
            }
            else
            {
                _lstID = dgvChiTietLichLamViec.SelectedRows[0].Cells["colID"].Value.ToString();
                _lstTen = dgvChiTietLichLamViec.SelectedRows[0].Cells["colNOIDUNG"].Value.ToString();
            }
            DialogResult rsl = TA_MessageBox.MessageBox.Show("Bạn có chắc chắn muốn xóa: \n" + _lstTen
                 , TA_MessageBox.MessageIcon.Question);

            if (rsl == DialogResult.Yes)
            {
                _dt1 = _api.Search(ref _userError, ref _systemError, cls_NS_LichLamViecCT.tb_TenBang, _acc.Get_UserMMYY(), -1, orderByASC1: false, orderByName1: cls_NS_LichLamViecCT.col_ID);
                txtNhansucungthamgia.Text = txtNoidung.Text = txtTieude.Text = dpkTu.Text = dpkDen.Text = "";

                _api.DeleteAll(ref _userError, ref _systemError, cls_NS_LichLamViecCT.tb_TenBang, _lstID, _acc.Get_UserMMYY());
                _lstID = _lstTen = "";
                if (_rowIndex <= (dgvChiTietLichLamViec.Rows.Count - 1))
                {
                    dgvChiTietLichLamViec.Rows[_rowIndex].Selected = true;
                }
                else if (dgvChiTietLichLamViec.Rows.Count > 0)
                {
                    dgvChiTietLichLamViec.Rows[dgvChiTietLichLamViec.Rows.Count - 1].Selected = true;
                }
                Load_dgvChiTietLichLamViec();
            }
        }

        private void Show_Chi_Tiet()
        {
            try
            {
                dpkTu.Text = dgvChiTietLichLamViec.SelectedRows[0].Cells["colTU"].Value.ToString();
                dpkDen.Text = dgvChiTietLichLamViec.SelectedRows[0].Cells["colDEN"].Value.ToString();
                cboDouutien.txtTen.Text = dgvChiTietLichLamViec.SelectedRows[0].Cells["colDOUUTIEN"].Value.ToString();
                txtNhansucungthamgia.Text = dgvChiTietLichLamViec.SelectedRows[0].Cells["colNSCUNGTHAMGIA"].Value.ToString();
                txtNoidung.Text = dgvChiTietLichLamViec.SelectedRows[0].Cells["colNOIDUNG"].Value.ToString();
                txtTieude.Text = dgvChiTietLichLamViec.SelectedRows[0].Cells["colTIEUDE"].Value.ToString();
                cboLoai.txtTen.Text = dgvChiTietLichLamViec.SelectedRows[0].Cells["colLOAI"].Value.ToString();
                cboNhansu.txtTen.Text = dgvChiTietLichLamViec.SelectedRows[0].Cells["colNHANSU"].Value.ToString();
            }
            catch
            {
            }
        }
        #endregion

        #region Event

        private void frmLichLamViecChiTiet_Load(object sender, EventArgs e)
        {
            Load_cboNhansu();
            Load_cboLoai();
            Load_cboDouutien();

        }

        private void his_LabelX1_Click(object sender, EventArgs e)
        {
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Luu();
            cboLoai.clear();
            cboDouutien.clear();
            txtNhansucungthamgia.Text = txtNoidung.Text = txtTieude.Text = "";
        }

        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            Load_nguyenngay();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void cboDouutien_Load(object sender, EventArgs e)
        {
        }

        private void lbDouutien_Click(object sender, EventArgs e)
        {
            frm_DanhMucChung f = new frm_DanhMucChung("LichKham", "Lịch khám", "Khám Bệnh", "", "", "");
            f.ShowDialog();
        }

        private void btnKetthuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void his_ButtonX21_Click(object sender, EventArgs e)
        {
            frm_DinhKem f = new frm_DinhKem();
            f.ShowDialog();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            cboNhansu.clear();
            cboLoai.clear();
            cboDouutien.clear();
            txtNhansucungthamgia.Text = txtNoidung.Text = txtTieude.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _isAdd = true;
            btnLuu.Enabled = true;
        }

        private void his_LabelX5_Click(object sender, EventArgs e)
        {
            frm_DanhMucChung f = new frm_DanhMucChung("Lichkham1", "Lịch khám", "Khám", "", "", "");
            f.ShowDialog();
        }

        private void txtTieude_Enter(object sender, EventArgs e)
        {
        }

        private void txtTieude_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtTieude_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void pnlXemLich_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cboNhansu_Click(object sender, EventArgs e)
        {
        }

        private void cboNhansu_HisSelectChange(object sender, EventArgs e)
        {
            Load_dgvChiTietLichLamViec();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            _isAdd = false;
            btnLuu.Enabled = true;
            Sua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }

        private void dgvChiTietLichLamViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _ID = dgvChiTietLichLamViec.CurrentRow.Cells["colID"].Value.ToString();
            }
            catch
            {
            }
        }

        private void cboLoai_Click(object sender, EventArgs e)
        {
            Load_cboLoai();
        }

        private void cboDouutien_Click(object sender, EventArgs e)
        {
            Load_cboDouutien();
        }
        #endregion
        #endregion
    }
}
