namespace E15_LichLamViec
{
    partial class frmLichLamViec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn7 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn8 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn9 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn10 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn11 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn12 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn13 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn14 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn15 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn16 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn17 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn18 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn19 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn20 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn21 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.spgThang = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.spgTuan = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.spgNgay = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.monThang = new System.Windows.Forms.MonthCalendar();
            this.his_Panel1 = new E00_Control.his_Panel();
            this.slbLocTheoLoai = new E00_ControlNew.usc_SelectBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.his_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 519);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.spgThang);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tháng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // spgThang
            // 
            this.spgThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spgThang.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.spgThang.Location = new System.Drawing.Point(0, 0);
            this.spgThang.Name = "spgThang";
            gridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            gridColumn1.DataPropertyName = "NGAY";
            gridColumn1.HeaderText = "Ngày";
            gridColumn1.Name = "Ngày";
            gridColumn1.ShowPanelFilterExpr = DevComponents.DotNetBar.SuperGrid.Style.Tbool.True;
            gridColumn1.SortIndicator = DevComponents.DotNetBar.SuperGrid.SortIndicator.None;
            gridColumn2.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            gridColumn2.DataPropertyName = "THU";
            gridColumn2.GroupBoxEffects = DevComponents.DotNetBar.SuperGrid.GroupBoxEffects.None;
            gridColumn2.Name = "Thứ";
            gridColumn2.Visible = false;
            gridColumn3.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.None;
            gridColumn3.DataPropertyName = "HOTEN";
            gridColumn3.Name = "Họ Tên";
            gridColumn3.Width = 200;
            gridColumn4.DataPropertyName = "TU";
            gridColumn4.Name = "Từ";
            gridColumn4.Visible = false;
            gridColumn5.DataPropertyName = "DEN";
            gridColumn5.Name = "Đến";
            gridColumn5.Visible = false;
            gridColumn6.DataPropertyName = "LOAI";
            gridColumn6.HeaderText = "Loại";
            gridColumn6.Name = "Loại";
            gridColumn7.DataPropertyName = "TIEUDE";
            gridColumn7.Name = "Tiêu Đề";
            gridColumn8.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn8.DataPropertyName = "NOIDUNG";
            gridColumn8.Name = "Nội Dung";
            gridColumn8.Width = 150;
            this.spgThang.PrimaryGrid.Columns.Add(gridColumn1);
            this.spgThang.PrimaryGrid.Columns.Add(gridColumn2);
            this.spgThang.PrimaryGrid.Columns.Add(gridColumn3);
            this.spgThang.PrimaryGrid.Columns.Add(gridColumn4);
            this.spgThang.PrimaryGrid.Columns.Add(gridColumn5);
            this.spgThang.PrimaryGrid.Columns.Add(gridColumn6);
            this.spgThang.PrimaryGrid.Columns.Add(gridColumn7);
            this.spgThang.PrimaryGrid.Columns.Add(gridColumn8);
            this.spgThang.PrimaryGrid.MultiSelect = false;
            this.spgThang.Size = new System.Drawing.Size(781, 497);
            this.spgThang.TabIndex = 2;
            this.spgThang.Text = "superGridControl1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.slbLocTheoLoai);
            this.tabPage2.Controls.Add(this.spgTuan);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tuần";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // spgTuan
            // 
            this.spgTuan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spgTuan.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.spgTuan.Location = new System.Drawing.Point(0, 23);
            this.spgTuan.Name = "spgTuan";
            gridColumn9.DataPropertyName = "THU";
            gridColumn9.HeaderText = "Thứ";
            gridColumn9.Name = "Thứ";
            gridColumn9.Visible = false;
            gridColumn10.DataPropertyName = "NGAY";
            gridColumn10.Name = "Ngày";
            gridColumn10.Visible = false;
            gridColumn11.DataPropertyName = "HOTEN";
            gridColumn11.Name = "Họ Tên";
            gridColumn11.Width = 200;
            gridColumn12.DataPropertyName = "TU";
            gridColumn12.Name = "Từ";
            gridColumn13.DataPropertyName = "DEN";
            gridColumn13.Name = "Đến";
            gridColumn14.DataPropertyName = "TIEUDE";
            gridColumn14.Name = "Tiêu Đề";
            gridColumn15.DataPropertyName = "LOAI";
            gridColumn15.HeaderText = "Loại";
            gridColumn15.Name = "Loại";
            gridColumn16.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn16.DataPropertyName = "NOIDUNG";
            gridColumn16.Name = "Nội Dung";
            gridColumn16.Width = 200;
            this.spgTuan.PrimaryGrid.Columns.Add(gridColumn9);
            this.spgTuan.PrimaryGrid.Columns.Add(gridColumn10);
            this.spgTuan.PrimaryGrid.Columns.Add(gridColumn11);
            this.spgTuan.PrimaryGrid.Columns.Add(gridColumn12);
            this.spgTuan.PrimaryGrid.Columns.Add(gridColumn13);
            this.spgTuan.PrimaryGrid.Columns.Add(gridColumn14);
            this.spgTuan.PrimaryGrid.Columns.Add(gridColumn15);
            this.spgTuan.PrimaryGrid.Columns.Add(gridColumn16);
            this.spgTuan.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Triangle;
            this.spgTuan.Size = new System.Drawing.Size(777, 474);
            this.spgTuan.TabIndex = 2;
            this.spgTuan.Text = "superGridControl1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.spgNgay);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 493);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ngày";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // spgNgay
            // 
            this.spgNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spgNgay.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.spgNgay.Location = new System.Drawing.Point(-2, 0);
            this.spgNgay.Name = "spgNgay";
            gridColumn17.DataPropertyName = "GIO";
            gridColumn17.HeaderText = "Giờ";
            gridColumn17.Name = "Giờ";
            gridColumn18.DataPropertyName = "TU";
            gridColumn18.HeaderText = "Từ";
            gridColumn18.Name = "Từ";
            gridColumn19.DataPropertyName = "DEN";
            gridColumn19.HeaderText = "Đến";
            gridColumn19.Name = "Đến";
            gridColumn20.DataPropertyName = "LOAI";
            gridColumn20.HeaderText = "Loại";
            gridColumn20.Name = "Loại";
            gridColumn21.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            gridColumn21.DataPropertyName = "NOIDUNG";
            gridColumn21.HeaderText = "Nội Dung";
            gridColumn21.Name = "Nội Dung";
            this.spgNgay.PrimaryGrid.Columns.Add(gridColumn17);
            this.spgNgay.PrimaryGrid.Columns.Add(gridColumn18);
            this.spgNgay.PrimaryGrid.Columns.Add(gridColumn19);
            this.spgNgay.PrimaryGrid.Columns.Add(gridColumn20);
            this.spgNgay.PrimaryGrid.Columns.Add(gridColumn21);
            this.spgNgay.PrimaryGrid.ExpandButtonType = DevComponents.DotNetBar.SuperGrid.ExpandButtonType.Triangle;
            this.spgNgay.Size = new System.Drawing.Size(781, 495);
            this.spgNgay.TabIndex = 3;
            this.spgNgay.Text = "superGridControl1";
            // 
            // monThang
            // 
            this.monThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monThang.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monThang.Location = new System.Drawing.Point(785, 22);
            this.monThang.Name = "monThang";
            this.monThang.TabIndex = 0;
            this.monThang.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monThang_DateChanged);
            this.monThang.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monThang_DateSelected);
            // 
            // his_Panel1
            // 
            this.his_Panel1.Controls.Add(this.monThang);
            this.his_Panel1.Controls.Add(this.tabControl1);
            this.his_Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.his_Panel1.Location = new System.Drawing.Point(0, 0);
            this.his_Panel1.Name = "his_Panel1";
            this.his_Panel1.Size = new System.Drawing.Size(1012, 519);
            this.his_Panel1.TabIndex = 1;
            // 
            // slbLocTheoLoai
            // 
            this.slbLocTheoLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.slbLocTheoLoai.DataSource = null;
            this.slbLocTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slbLocTheoLoai.his_AddNew = false;
            this.slbLocTheoLoai.his_ColMa = null;
            this.slbLocTheoLoai.his_ColTen = null;
            this.slbLocTheoLoai.his_FontSize = 8.25F;
            this.slbLocTheoLoai.his_lblText = "Mã:";
            this.slbLocTheoLoai.his_lblTitle1_Bold = false;
            this.slbLocTheoLoai.his_lblTitle1_text = "labelX1";
            this.slbLocTheoLoai.his_lblTitle1_Visible = false;
            this.slbLocTheoLoai.his_lblTitle1_Width = 0;
            this.slbLocTheoLoai.his_lblVisible = false;
            this.slbLocTheoLoai.his_lblWidth = 0;
            this.slbLocTheoLoai.his_ShowCount = 10;
            this.slbLocTheoLoai.his_Showmin = 10;
            this.slbLocTheoLoai.his_TabLocation = 0;
            this.slbLocTheoLoai.his_TenReadonly = false;
            this.slbLocTheoLoai.his_TenReadOnly = false;
            this.slbLocTheoLoai.his_TenVisible = true;
            this.slbLocTheoLoai.his_TimeSearch = 200;
            this.slbLocTheoLoai.his_txtWidth = 0;
            this.slbLocTheoLoai.his_XoaMa = true;
            this.slbLocTheoLoai.Location = new System.Drawing.Point(676, 0);
            this.slbLocTheoLoai.Margin = new System.Windows.Forms.Padding(0);
            this.slbLocTheoLoai.Minlenght = 200;
            this.slbLocTheoLoai.Name = "slbLocTheoLoai";
            this.slbLocTheoLoai.Size = new System.Drawing.Size(101, 20);
            this.slbLocTheoLoai.TabIndex = 3;
            this.slbLocTheoLoai.HisSelectChange += new E00_ControlNew.EventHandler(this.slbLocTheoLoai_HisSelectChange);
            // 
            // frmLichLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 519);
            this.Controls.Add(this.his_Panel1);
            this.DoubleBuffered = true;
            this.Name = "frmLichLamViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch làm việc";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.his_Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MonthCalendar monThang;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private E00_Control.his_Panel his_Panel1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl spgThang;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl spgTuan;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl spgNgay;
        private E00_ControlNew.usc_SelectBox slbLocTheoLoai;
    }
}