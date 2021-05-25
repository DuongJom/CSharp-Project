
namespace QuanLyThuVien
{
    partial class frmNhapSach
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSoLuong = new System.Windows.Forms.TextBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tác giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thể loại:";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(199, 98);
            this.txtTenSach.Multiline = true;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(416, 37);
            this.txtTenSach.TabIndex = 4;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(199, 141);
            this.txtTacGia.Multiline = true;
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(416, 33);
            this.txtTacGia.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAdd.Location = new System.Drawing.Point(305, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.Location = new System.Drawing.Point(621, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBackMain
            // 
            this.btnBackMain.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackMain.Location = new System.Drawing.Point(43, 435);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(91, 31);
            this.btnBackMain.TabIndex = 9;
            this.btnBackMain.Text = "Trang chủ";
            this.btnBackMain.UseVisualStyleBackColor = false;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số lượng";
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Location = new System.Drawing.Point(490, 181);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(125, 27);
            this.txbSoLuong.TabIndex = 11;
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.tenSach,
            this.tacGia,
            this.theLoai,
            this.soLuong});
            this.dgvSach.Location = new System.Drawing.Point(43, 215);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 29;
            this.dgvSach.Size = new System.Drawing.Size(651, 209);
            this.dgvSach.TabIndex = 12;
            // 
            // maSach
            // 
            this.maSach.DataPropertyName = "maSach";
            this.maSach.HeaderText = "Mã Sách";
            this.maSach.MinimumWidth = 6;
            this.maSach.Name = "maSach";
            // 
            // tenSach
            // 
            this.tenSach.DataPropertyName = "tenSach";
            this.tenSach.HeaderText = "Tên Sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            // 
            // tacGia
            // 
            this.tacGia.DataPropertyName = "tacGia";
            this.tacGia.HeaderText = "Tác Giả";
            this.tacGia.MinimumWidth = 6;
            this.tacGia.Name = "tacGia";
            // 
            // theLoai
            // 
            this.theLoai.DataPropertyName = "theLoai";
            this.theLoai.HeaderText = "Thể Loại";
            this.theLoai.MinimumWidth = 6;
            this.theLoai.Name = "theLoai";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.SpringGreen;
            this.btnLuu.Location = new System.Drawing.Point(542, 435);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 31);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SpringGreen;
            this.btnXoa.Location = new System.Drawing.Point(463, 435);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 31);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSua.Location = new System.Drawing.Point(384, 435);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 31);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mã sách";
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(199, 56);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(151, 27);
            this.txtMasach.TabIndex = 18;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(199, 180);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(179, 27);
            this.txtTheLoai.TabIndex = 19;
            // 
            // frmNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVien.Properties.Resources.nhapSach;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 478);
            this.Controls.Add(this.txtTheLoai);
            this.Controls.Add(this.txtMasach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.txbSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBackMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmNhapSach";
            this.Text = "Quản Lý Nhập Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhapSach_FormClosing);
            this.Load += new System.EventHandler(this.frmNhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSoLuong;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.TextBox txtTheLoai;
    }
}