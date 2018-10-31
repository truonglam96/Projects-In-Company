using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using E00_Base;
using E00_Common;
using E00_Model;
using E00_System;

namespace Báo_Cáo_Sử_Dụng
{
    public partial class frmBaoCaoSuDung : frm_BaoCao
    {
        private Api_Common _api = new Api_Common();
        Acc_Oracle _acc = new Acc_Oracle();
        DataSet dt = new DataSet();
        //private LibDal.AccessData v;
        DataTable _getFill1 = null;
        DataTable _getFill2 = null;

        public frmBaoCaoSuDung()
        {
            InitializeComponent();
            _api.KetNoi();
        }

        
        private void load_dgv()
        {
            string sql1 = ("select DISTINCT makpsudung, tenkpsudung from " + _acc.Get_User() + ".TAISAN_SUDUNGCT" );
            string sql2 = ("select DISTINCT maphongcongnang, tenphongcongnang from " + _acc.Get_User() + "." + cls_TaiSan_SuDungCT.tb_TenBang);
            _getFill1 = _acc.Get_Data(sql1);
            dgvDonviSD.DataSource = _getFill1;
            _getFill2 = _acc.Get_Data(sql2);
            dgvPhongcongnang.DataSource = _getFill2;


        }
         
     
        private void frmBaoCaoSuDung_Load(object sender, EventArgs e)
        {
            load_dgv();
           
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
