using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E15_LichLamViec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLichLamViec f = new frmLichLamViec("0001");
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmKhaiBaoLichLamViecChiTiet f = new frmKhaiBaoLichLamViecChiTiet();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLichLamViecTatCaBS f = new frmLichLamViecTatCaBS();
            f.Show();
        }
    }
}
