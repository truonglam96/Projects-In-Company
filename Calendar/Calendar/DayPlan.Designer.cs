namespace Calendar
{
    partial class DayPlan
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
            this.his_Panel1 = new E00_Control.his_Panel();
            this.his_Panel2 = new E00_Control.his_Panel();
            this.his_Panel3 = new E00_Control.his_Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnustrThemviec = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustrHomnay = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHomqua = new System.Windows.Forms.Button();
            this.btnNgaymai = new System.Windows.Forms.Button();
            this.his_Panel1.SuspendLayout();
            this.his_Panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // his_Panel1
            // 
            this.his_Panel1.Controls.Add(this.his_Panel3);
            this.his_Panel1.Controls.Add(this.his_Panel2);
            this.his_Panel1.Controls.Add(this.menuStrip1);
            this.his_Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.his_Panel1.Location = new System.Drawing.Point(0, 0);
            this.his_Panel1.Name = "his_Panel1";
            this.his_Panel1.Size = new System.Drawing.Size(523, 668);
            this.his_Panel1.TabIndex = 0;
            // 
            // his_Panel2
            // 
            this.his_Panel2.Location = new System.Drawing.Point(0, 66);
            this.his_Panel2.Name = "his_Panel2";
            this.his_Panel2.Size = new System.Drawing.Size(523, 602);
            this.his_Panel2.TabIndex = 0;
            // 
            // his_Panel3
            // 
            this.his_Panel3.Controls.Add(this.btnNgaymai);
            this.his_Panel3.Controls.Add(this.btnHomqua);
            this.his_Panel3.Controls.Add(this.dateTimePicker1);
            this.his_Panel3.Location = new System.Drawing.Point(0, 27);
            this.his_Panel3.Name = "his_Panel3";
            this.his_Panel3.Size = new System.Drawing.Size(520, 33);
            this.his_Panel3.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnustrThemviec,
            this.mnustrHomnay});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnustrThemviec
            // 
            this.mnustrThemviec.Name = "mnustrThemviec";
            this.mnustrThemviec.Size = new System.Drawing.Size(74, 20);
            this.mnustrThemviec.Text = "Thêm việc";
            // 
            // mnustrHomnay
            // 
            this.mnustrHomnay.Name = "mnustrHomnay";
            this.mnustrHomnay.Size = new System.Drawing.Size(68, 20);
            this.mnustrHomnay.Text = "Hôm nay";
            // 
            // btnHomqua
            // 
            this.btnHomqua.Location = new System.Drawing.Point(0, -1);
            this.btnHomqua.Name = "btnHomqua";
            this.btnHomqua.Size = new System.Drawing.Size(75, 23);
            this.btnHomqua.TabIndex = 1;
            this.btnHomqua.Text = "Hôm qua";
            this.btnHomqua.UseVisualStyleBackColor = true;
            // 
            // btnNgaymai
            // 
            this.btnNgaymai.Location = new System.Drawing.Point(445, 0);
            this.btnNgaymai.Name = "btnNgaymai";
            this.btnNgaymai.Size = new System.Drawing.Size(75, 23);
            this.btnNgaymai.TabIndex = 2;
            this.btnNgaymai.Text = "Ngày mai";
            this.btnNgaymai.UseVisualStyleBackColor = true;
            // 
            // DayPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 668);
            this.Controls.Add(this.his_Panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DayPlan";
            this.Text = "DayPlan";
            this.his_Panel1.ResumeLayout(false);
            this.his_Panel1.PerformLayout();
            this.his_Panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private E00_Control.his_Panel his_Panel1;
        private E00_Control.his_Panel his_Panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private E00_Control.his_Panel his_Panel2;
        private System.Windows.Forms.Button btnNgaymai;
        private System.Windows.Forms.Button btnHomqua;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnustrThemviec;
        private System.Windows.Forms.ToolStripMenuItem mnustrHomnay;
    }
}