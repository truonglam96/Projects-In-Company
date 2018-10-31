namespace Calendar
{
    partial class Form1
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
            this.his_Panel3 = new E00_Control.his_Panel();
            this.btnToday = new System.Windows.Forms.Button();
            this.dpkDate = new System.Windows.Forms.DateTimePicker();
            this.his_Panel2 = new E00_Control.his_Panel();
            this.pnlMaTrix = new E00_Control.his_Panel();
            this.his_Panel4 = new E00_Control.his_Panel();
            this.btnThangsau = new System.Windows.Forms.Button();
            this.bntChunhat = new System.Windows.Forms.Button();
            this.bntThu7 = new System.Windows.Forms.Button();
            this.bntThu6 = new System.Windows.Forms.Button();
            this.bntThu5 = new System.Windows.Forms.Button();
            this.btnThu4 = new System.Windows.Forms.Button();
            this.btnthu3 = new System.Windows.Forms.Button();
            this.btnThangtruoc = new System.Windows.Forms.Button();
            this.btnthu2 = new System.Windows.Forms.Button();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.his_Panel1.SuspendLayout();
            this.his_Panel3.SuspendLayout();
            this.his_Panel2.SuspendLayout();
            this.his_Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // his_Panel1
            // 
            this.his_Panel1.Controls.Add(this.his_Panel3);
            this.his_Panel1.Controls.Add(this.his_Panel2);
            this.his_Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.his_Panel1.Location = new System.Drawing.Point(0, 0);
            this.his_Panel1.Name = "his_Panel1";
            this.his_Panel1.Size = new System.Drawing.Size(899, 669);
            this.his_Panel1.TabIndex = 0;
            // 
            // his_Panel3
            // 
            this.his_Panel3.Controls.Add(this.btnToday);
            this.his_Panel3.Controls.Add(this.dpkDate);
            this.his_Panel3.Location = new System.Drawing.Point(0, 3);
            this.his_Panel3.Name = "his_Panel3";
            this.his_Panel3.Size = new System.Drawing.Size(898, 26);
            this.his_Panel3.TabIndex = 1;
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(500, 1);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 20);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // dpkDate
            // 
            this.dpkDate.Location = new System.Drawing.Point(294, 1);
            this.dpkDate.Name = "dpkDate";
            this.dpkDate.Size = new System.Drawing.Size(200, 20);
            this.dpkDate.TabIndex = 0;
            this.dpkDate.ValueChanged += new System.EventHandler(this.dpkDate_ValueChanged);
            // 
            // his_Panel2
            // 
            this.his_Panel2.Controls.Add(this.pnlJob);
            this.his_Panel2.Controls.Add(this.pnlMaTrix);
            this.his_Panel2.Controls.Add(this.his_Panel4);
            this.his_Panel2.Location = new System.Drawing.Point(0, 35);
            this.his_Panel2.Name = "his_Panel2";
            this.his_Panel2.Size = new System.Drawing.Size(898, 419);
            this.his_Panel2.TabIndex = 0;
            // 
            // pnlMaTrix
            // 
            this.pnlMaTrix.Location = new System.Drawing.Point(176, 54);
            this.pnlMaTrix.Name = "pnlMaTrix";
            this.pnlMaTrix.Size = new System.Drawing.Size(561, 365);
            this.pnlMaTrix.TabIndex = 1;
            // 
            // his_Panel4
            // 
            this.his_Panel4.Controls.Add(this.btnThangsau);
            this.his_Panel4.Controls.Add(this.bntChunhat);
            this.his_Panel4.Controls.Add(this.bntThu7);
            this.his_Panel4.Controls.Add(this.bntThu6);
            this.his_Panel4.Controls.Add(this.bntThu5);
            this.his_Panel4.Controls.Add(this.btnThu4);
            this.his_Panel4.Controls.Add(this.btnthu3);
            this.his_Panel4.Controls.Add(this.btnThangtruoc);
            this.his_Panel4.Controls.Add(this.btnthu2);
            this.his_Panel4.Location = new System.Drawing.Point(0, 0);
            this.his_Panel4.Name = "his_Panel4";
            this.his_Panel4.Size = new System.Drawing.Size(967, 48);
            this.his_Panel4.TabIndex = 0;
            // 
            // btnThangsau
            // 
            this.btnThangsau.Location = new System.Drawing.Point(741, 3);
            this.btnThangsau.Name = "btnThangsau";
            this.btnThangsau.Size = new System.Drawing.Size(75, 42);
            this.btnThangsau.TabIndex = 0;
            this.btnThangsau.Text = "Tháng sau";
            this.btnThangsau.UseVisualStyleBackColor = true;
            this.btnThangsau.Click += new System.EventHandler(this.btnThangsau_Click);
            // 
            // bntChunhat
            // 
            this.bntChunhat.Location = new System.Drawing.Point(662, 3);
            this.bntChunhat.Name = "bntChunhat";
            this.bntChunhat.Size = new System.Drawing.Size(75, 42);
            this.bntChunhat.TabIndex = 0;
            this.bntChunhat.Text = "Chủ nhật";
            this.bntChunhat.UseVisualStyleBackColor = true;
            // 
            // bntThu7
            // 
            this.bntThu7.Location = new System.Drawing.Point(581, 3);
            this.bntThu7.Name = "bntThu7";
            this.bntThu7.Size = new System.Drawing.Size(75, 42);
            this.bntThu7.TabIndex = 0;
            this.bntThu7.Text = "Thứ 7";
            this.bntThu7.UseVisualStyleBackColor = true;
            // 
            // bntThu6
            // 
            this.bntThu6.Location = new System.Drawing.Point(500, 3);
            this.bntThu6.Name = "bntThu6";
            this.bntThu6.Size = new System.Drawing.Size(75, 42);
            this.bntThu6.TabIndex = 0;
            this.bntThu6.Text = "Thứ 6";
            this.bntThu6.UseVisualStyleBackColor = true;
            // 
            // bntThu5
            // 
            this.bntThu5.Location = new System.Drawing.Point(419, 3);
            this.bntThu5.Name = "bntThu5";
            this.bntThu5.Size = new System.Drawing.Size(75, 42);
            this.bntThu5.TabIndex = 0;
            this.bntThu5.Text = "Thứ 5";
            this.bntThu5.UseVisualStyleBackColor = true;
            // 
            // btnThu4
            // 
            this.btnThu4.Location = new System.Drawing.Point(338, 3);
            this.btnThu4.Name = "btnThu4";
            this.btnThu4.Size = new System.Drawing.Size(75, 42);
            this.btnThu4.TabIndex = 0;
            this.btnThu4.Text = "Thứ 4";
            this.btnThu4.UseVisualStyleBackColor = true;
            // 
            // btnthu3
            // 
            this.btnthu3.Location = new System.Drawing.Point(257, 3);
            this.btnthu3.Name = "btnthu3";
            this.btnthu3.Size = new System.Drawing.Size(75, 42);
            this.btnthu3.TabIndex = 0;
            this.btnthu3.Text = "Thứ 3";
            this.btnthu3.UseVisualStyleBackColor = true;
            // 
            // btnThangtruoc
            // 
            this.btnThangtruoc.Location = new System.Drawing.Point(95, 3);
            this.btnThangtruoc.Name = "btnThangtruoc";
            this.btnThangtruoc.Size = new System.Drawing.Size(75, 42);
            this.btnThangtruoc.TabIndex = 0;
            this.btnThangtruoc.Text = "Tháng trước";
            this.btnThangtruoc.UseVisualStyleBackColor = true;
            this.btnThangtruoc.Click += new System.EventHandler(this.btnThangtruoc_Click);
            // 
            // btnthu2
            // 
            this.btnthu2.Location = new System.Drawing.Point(176, 3);
            this.btnthu2.Name = "btnthu2";
            this.btnthu2.Size = new System.Drawing.Size(75, 42);
            this.btnthu2.TabIndex = 0;
            this.btnthu2.Text = "Thứ 2";
            this.btnthu2.UseVisualStyleBackColor = true;
            // 
            // pnlJob
            // 
            this.pnlJob.Location = new System.Drawing.Point(0, 425);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(896, 209);
            this.pnlJob.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 669);
            this.Controls.Add(this.his_Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.his_Panel1.ResumeLayout(false);
            this.his_Panel3.ResumeLayout(false);
            this.his_Panel2.ResumeLayout(false);
            this.his_Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private E00_Control.his_Panel his_Panel1;
        private E00_Control.his_Panel his_Panel3;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DateTimePicker dpkDate;
        private E00_Control.his_Panel his_Panel2;
        private E00_Control.his_Panel pnlMaTrix;
        private E00_Control.his_Panel his_Panel4;
        private System.Windows.Forms.Button btnThangsau;
        private System.Windows.Forms.Button bntChunhat;
        private System.Windows.Forms.Button bntThu7;
        private System.Windows.Forms.Button bntThu6;
        private System.Windows.Forms.Button bntThu5;
        private System.Windows.Forms.Button btnThu4;
        private System.Windows.Forms.Button btnthu3;
        private System.Windows.Forms.Button btnThangtruoc;
        private System.Windows.Forms.Button btnthu2;
        private System.Windows.Forms.Panel pnlJob;
    }
}

