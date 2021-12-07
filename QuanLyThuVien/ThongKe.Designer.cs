
namespace QuanLyThuVien
{
    partial class frmThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbTuan = new System.Windows.Forms.RadioButton();
            this.rdbThang = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPFrom = new System.Windows.Forms.DateTimePicker();
            this.dtPTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLuaChon = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.ptbLine = new System.Windows.Forms.PictureBox();
            this.ptbBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            // 
            // rdbTuan
            // 
            this.rdbTuan.AutoSize = true;
            this.rdbTuan.Location = new System.Drawing.Point(152, 52);
            this.rdbTuan.Name = "rdbTuan";
            this.rdbTuan.Size = new System.Drawing.Size(62, 24);
            this.rdbTuan.TabIndex = 1;
            this.rdbTuan.TabStop = true;
            this.rdbTuan.Text = "Tuần";
            this.rdbTuan.UseVisualStyleBackColor = true;
            // 
            // rdbThang
            // 
            this.rdbThang.AutoSize = true;
            this.rdbThang.Location = new System.Drawing.Point(152, 93);
            this.rdbThang.Name = "rdbThang";
            this.rdbThang.Size = new System.Drawing.Size(71, 24);
            this.rdbThang.TabIndex = 2;
            this.rdbThang.TabStop = true;
            this.rdbThang.Text = "Tháng";
            this.rdbThang.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(331, 93);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(62, 24);
            this.rdbNam.TabIndex = 3;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Năm";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thống kê theo";
            // 
            // dtPFrom
            // 
            this.dtPFrom.Location = new System.Drawing.Point(315, 49);
            this.dtPFrom.Name = "dtPFrom";
            this.dtPFrom.Size = new System.Drawing.Size(250, 27);
            this.dtPFrom.TabIndex = 5;
            // 
            // dtPTo
            // 
            this.dtPTo.Location = new System.Drawing.Point(708, 49);
            this.dtPTo.Name = "dtPTo";
            this.dtPTo.Size = new System.Drawing.Size(250, 27);
            this.dtPTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đến ngày";
            // 
            // cbbLuaChon
            // 
            this.cbbLuaChon.FormattingEnabled = true;
            this.cbbLuaChon.Items.AddRange(new object[] {
            "Chọn nội dung thống kê",
            "Số lượng sách đã mượn",
            "Số lượng sách mượn chưa trả"});
            this.cbbLuaChon.Location = new System.Drawing.Point(514, 93);
            this.cbbLuaChon.Name = "cbbLuaChon";
            this.cbbLuaChon.Size = new System.Drawing.Size(235, 28);
            this.cbbLuaChon.TabIndex = 9;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(794, 93);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(101, 29);
            this.btnThongKe.TabIndex = 11;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // ptbLine
            // 
            this.ptbLine.Location = new System.Drawing.Point(497, 158);
            this.ptbLine.Name = "ptbLine";
            this.ptbLine.Size = new System.Drawing.Size(461, 495);
            this.ptbLine.TabIndex = 13;
            this.ptbLine.TabStop = false;
            // 
            // ptbBar
            // 
            this.ptbBar.Location = new System.Drawing.Point(12, 158);
            this.ptbBar.Name = "ptbBar";
            this.ptbBar.Size = new System.Drawing.Size(461, 495);
            this.ptbBar.TabIndex = 12;
            this.ptbBar.TabStop = false;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 661);
            this.Controls.Add(this.ptbLine);
            this.Controls.Add(this.ptbBar);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.cbbLuaChon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPTo);
            this.Controls.Add(this.dtPFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.rdbThang);
            this.Controls.Add(this.rdbTuan);
            this.Controls.Add(this.label1);
            this.Name = "frmThongKe";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.ptbLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTuan;
        private System.Windows.Forms.RadioButton rdbThang;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPFrom;
        private System.Windows.Forms.DateTimePicker dtPTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLuaChon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.PictureBox ptbLine;
        private System.Windows.Forms.PictureBox ptbBar;
    }
}