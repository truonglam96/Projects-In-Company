using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using E00_Common;
using E00_Model;
using System.Globalization;
using DevComponents.DotNetBar.SuperGrid;

namespace E15_LichLamViec
{
    public partial class frmLichLamViecTatCaBS : Office2007Form
    {
        #region Biến toàn cục
        private Acc_Oracle _acc = new Acc_Oracle();
        private Api_Common _api = new Api_Common();
        private DataRow _drN;
        private DataTable _dt = new DataTable();
        private DataTable _Gettb = new DataTable();
        #endregion

        #region Khởi tạo

        public frmLichLamViecTatCaBS()
        {
            InitializeComponent();
            _api.KetNoi();
        }
        #endregion

        #region Phương thức

        #region Private

        private void LoadData()
        {
            try
            {
                string sql = "select b.HOTEN, to_char(a.tu,'hh24:mi') as TU, to_char(a.den,'hh24:mi') as DEN, a.TIEUDE, a.NOIDUNG, a.LOAI, to_char(a.tu,'dd/mm/yyyy') as NGAY"
                           + " from " + _acc.Get_UserMMYY() + ".ns_lichlamviecct a "
                           + " inner join " + _acc.Get_User() + ".dmbs b on a.mabs = b.ma ";
                _Gettb = _acc.Get_Data(sql);
            }
            catch
            {
                TA_MessageBox.MessageBox.Show("Không có kết nối DataBase");
            }

        }

        private void Thang(DateTime date)
        {
            _dt.Clear();
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                _drN = _dt.NewRow();
                string time = (date.Month + "/" + i + "/" + date.Year).ToString();
                DateTime d = DateTime.Parse(time);
                _drN[1] = d.ToString("dd/MM/yyyy");
                DataRow[] dr = _Gettb.Select("NGAY ='" + d.ToString("dd/MM/yyyy") + "'");
                if (dr.Length > 0)
                {
                    for (int j = 0; j < dr.Length; j++)
                    {
                        try
                        {
                            _drN = _dt.NewRow();
                            _drN["HOTEN"] = dr[j]["HOTEN"].ToString();
                            _drN["NGAY"] = dr[j]["NGAY"].ToString();
                            _drN["TU"] = dr[j]["TU"].ToString();
                            _drN["DEN"] = dr[j]["DEN"].ToString();
                            _drN["TIEUDE"] = dr[j]["TIEUDE"].ToString();
                            _drN["NOIDUNG"] = dr[j]["NOIDUNG"].ToString();
                            _drN["LOAI"] = dr[j]["LOAI"].ToString();
                           // _drN["THU"] = DoiNgayVietNam(dsd.DayOfWeek.ToString()) + ": " + _drN["NGAY"];
                            _dt.Rows.Add(_drN);
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {
                    try
                    {
                        _drN = _dt.NewRow();
                        _drN["HOTEN"] = "";
                        _drN["NGAY"] = d.ToString("dd/MM/yyyy");
                        //_drN["THU"] = DoiNgayVietNam(dsd.DayOfWeek.ToString()) + ": " + _drN["NGAY"];
                        _dt.Rows.Add(_drN);
                    }
                    catch
                    {
                    }
                }
                //{
                //    try
                //    {
                //        _drN["HOTEN"] = dr[0]["HOTEN"].ToString();
                //        _drN["TU"] = dr[0]["TU"].ToString();
                //        _drN["DEN"] = dr[0]["DEN"].ToString();
                //        _drN["TIEUDE"] = dr[0]["TIEUDE"].ToString();
                //        _drN["NOIDUNG"] = dr[0]["NOIDUNG"].ToString();
                //    }
                //    catch
                //    {
                //    }
                //}
                //_drN[2] = DoiNgayVietNam(d.DayOfWeek.ToString());
                //_dt.Rows.Add(_drN);
            }
            _dt.Rows.Add();
            spgThang.PrimaryGrid.DataSource = _dt;

            GridPanel panel = spgThang.PrimaryGrid;
            panel.SetGroup(new GridColumn[] { panel.Columns["Ngày"], panel.Columns["Họ Tên"] });
        }

        private void Tuan(string fill)
        {
            DateTime d = monThang1.SelectionRange.Start;
            DateTime dd = GetFirstDayOfWeek(d);
            dd = dd.AddDays(1);
            DateTime ld = dd.AddDays(6);
            string filter = "NGAY >='" + dd.ToString("dd/MM/yyyy") + "' and NGAY <'" + ld.ToString("dd/MM/yyyy") + "'";
            if (ld.Month > dd.Month)
                filter = "NGAY >='" + dd.ToString("dd/MM/yyyy") + "' and NGAY <'" + DayOfMonth(dd) + "/" + dd.Month + "/" + dd.Year + "'";
            DataRow[] f = _dt.Select(filter);
            foreach (DataRow dr in _dt.Rows)
            {
                dr["THU"] = dr["THU"] + " " + dr["NGAY"] + "";
            }
            DataTable dtTuan = _dt.Clone();
            for (int i = dd.Day; i <= dd.Day + 6; i++)
            {
                string s = i - DayOfMonth(dd) < 10 ? "0" + (i - DayOfMonth(dd)) : (i - DayOfMonth(dd)).ToString();
                string time = i > DayOfMonth(dd) ? (ld.Month + "/" + s + "/" + ld.Year): (dd.Month + "/" + i + "/" + dd.Year);
                DateTime dsd = DateTime.Parse(time);
                DataRow[] dr = fill == null ? _Gettb.Select("NGAY ='" + dsd.ToString("dd/MM/yyyy") + "'") : _Gettb.Select("NGAY ='" + dsd.ToString("dd/MM/yyyy") + "'" + fill);
                if (dr.Length > 0)
                {
                    for (int j = 0; j < dr.Length; j++)
                    {
                        try
                        {
                            _drN = dtTuan.NewRow();
                            _drN["HOTEN"] = dr[j]["HOTEN"].ToString();
                            _drN["NGAY"] = dr[j]["NGAY"].ToString();
                            _drN["TU"] = dr[j]["TU"].ToString();
                            _drN["DEN"] = dr[j]["DEN"].ToString();
                            _drN["TIEUDE"] = dr[j]["TIEUDE"].ToString();
                            _drN["NOIDUNG"] = dr[j]["NOIDUNG"].ToString();
                            _drN["LOAI"] = dr[j]["LOAI"].ToString();
                            _drN["THU"] = DoiNgayVietNam(dsd.DayOfWeek.ToString()) + ": " + _drN["NGAY"];
                            dtTuan.Rows.Add(_drN);
                        }
                        catch
                        {
                        }
                    }
                }
                else
                {
                    try
                    {
                        _drN = dtTuan.NewRow();
                        _drN["HOTEN"] = "";
                        _drN["NGAY"] = dsd.ToString("dd/MM/yyyy");
                        _drN["THU"] = DoiNgayVietNam(dsd.DayOfWeek.ToString()) + ": " + _drN["NGAY"];
                        dtTuan.Rows.Add(_drN);
                    }
                    catch
                    {
                    }
                }
            }
            //if (f.Length > 0)
            //{
                spgTuan.PrimaryGrid.DataSource = dtTuan;
            //}
            //else
            //{
            //    spgTuan.PrimaryGrid.DataSource = null;
            //}
            GridPanel panel = spgTuan.PrimaryGrid;
            panel.SetGroup(new GridColumn[] { panel.Columns["Thứ"], panel.Columns["Họ Tên"] });
        }

        private void Ngay()
        {
            DataTable dtNgay = new DataTable();
            string d = monThang1.SelectionRange.Start.ToString("dd/MM/yyyy"), t = "";
            DataRow[] f = _Gettb.Select("NGAY = '" + d + "'", "TU");
            dtNgay.Columns.Add("GIO");
            dtNgay.Columns.Add("TU");
            dtNgay.Columns.Add("DEN");
            dtNgay.Columns.Add("HOTEN");
            dtNgay.Columns.Add("TIEUDE");
            dtNgay.Columns.Add("NOIDUNG");
            for (int i = 0; i < 24; i++)
            {
                t = i < 10 ? "0" + i + ":00" : i + ":00";
                DataRow ff = dtNgay.NewRow();
                ff[0] = t;
                dtNgay.Rows.Add(ff);
                //if (f.Length > 0)
                //{
                foreach (DataRow dr in f)
                {
                    if (dr[1].ToString().Substring(0, 2).CompareTo(t.Substring(0, 2)) == 0)
                    {
                        _drN = dtNgay.NewRow();
                        _drN[1] = dr[1].ToString();
                        _drN[2] = dr[2].ToString();
                        _drN[3] = dr[0].ToString();
                        _drN[4] = dr[3].ToString();
                        _drN[5] = dr[4].ToString();
                        dtNgay.Rows.Add(_drN);
                        if (int.Parse(dr[2].ToString().Substring(0, 2)) - int.Parse(dr[1].ToString().Substring(0, 2)) >= 1)
                            i = int.Parse(dr[2].ToString().Substring(0, 2)) - 1;
                    }
                }
                //}
                //else
                //{
                //}
            }
            if (f.Length > 0)
            {
                spgNgay.PrimaryGrid.DataSource = dtNgay;
            }
            else
            {
                spgNgay.PrimaryGrid.DataSource = null;
            }
            spgNgay.PrimaryGrid.DataSource = dtNgay;
            spgNgay.PrimaryGrid.AutoGenerateColumns = false;
        }

        public static string DoiNgayVietNam(string name)
        {
            string Nametemp = "";
            switch (name)
            {
                case "Monday":
                    Nametemp = "Thứ 2";
                    break;
                case "Tuesday":
                    Nametemp = "Thứ 3";
                    break;
                case "Wednesday":
                    Nametemp = "Thứ 4";
                    break;
                case "Thursday":
                    Nametemp = "Thứ 5";
                    break;
                case "Friday":
                    Nametemp = "Thứ 6";
                    break;
                case "Saturday":
                    Nametemp = "Thứ bảy";
                    break;
                case "Sunday":
                    Nametemp = "Chủ nhật";
                    break;
            }
            return Nametemp;
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }
        #endregion

        #region Event

        private void frmLichLamViecTatCaBS_Load(object sender, EventArgs e)
        {
            spgNgay.PrimaryGrid.AutoGenerateColumns = false;
            _dt.Columns.Add("HOTEN");
            _dt.Columns.Add("NGAY");
            _dt.Columns.Add("THU");
            _dt.Columns.Add("NOIDUNG");
            _dt.Columns.Add("TU");
            _dt.Columns.Add("DEN");
            _dt.Columns.Add("TIEUDE");
            _dt.Columns.Add("LOAI");
            LoadData();
            Thang(DateTime.Now);
            Tuan(null);
            Ngay();
        }

        private void monThang_DateChanged(object sender, DateRangeEventArgs e)
        {
            Thang(monThang1.SelectionRange.Start);
            Tuan(null);
            Ngay();
        }

        private void monThang_DateSelected(object sender, DateRangeEventArgs e)
        {
        }

        public static DateTime GetFirstDayOfWeek(DateTime dayInWeek)
        {
            CultureInfo defaultCultureInfo = CultureInfo.CurrentCulture;
            return GetFirstDayOfWeek(dayInWeek, defaultCultureInfo);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            monThang1.SetDate(monThang1.SelectionRange.Start.Date);
        }

        private static DateTime GetFirstDayOfWeek(DateTime dayInWeek, CultureInfo cultureInfo)
        {
            DayOfWeek firstDay = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            DateTime firstDayInWeek = dayInWeek.Date;
            while (firstDayInWeek.DayOfWeek != firstDay)
            {
                firstDayInWeek = firstDayInWeek.AddDays(-1);
            }
            return firstDayInWeek;
        }
        #endregion 
        #endregion
    }
}
