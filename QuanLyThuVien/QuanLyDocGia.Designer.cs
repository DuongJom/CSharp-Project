
namespace QuanLyThuVien
{
    partial class frmQuanLyDocGia
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
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.maDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSoDK = new System.Windows.Forms.TextBox();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDG,
            this.tenDG,
            this.ngaySinh,
            this.soDangKy,
            this.soCMND});
            this.dgvDocGia.Location = new System.Drawing.Point(12, 176);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowHeadersWidth = 51;
            this.dgvDocGia.RowTemplate.Height = 29;
            this.dgvDocGia.Size = new System.Drawing.Size(708, 231);
            this.dgvDocGia.TabIndex = 0;
            // 
            // maDG
            // 
            this.maDG.DataPropertyName = "maDG";
            this.maDG.HeaderText = "Mã độc giả";
            this.maDG.MinimumWidth = 6;
            this.maDG.Name = "maDG";
            // 
            // tenDG
            // 
            this.tenDG.DataPropertyName = "tenDG";
            this.tenDG.HeaderText = "Tên độc giả";
            this.tenDG.MinimumWidth = 6;
            this.tenDG.Name = "tenDG";
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            // 
            // soDangKy
            // 
            this.soDangKy.DataPropertyName = "soDangKy";
            this.soDangKy.HeaderText = "Số đăng ký";
            this.soDangKy.MinimumWidth = 6;
            this.soDangKy.Name = "soDangKy";
            // 
            // soCMND
            // 
            this.soCMND.DataPropertyName = "soCMND";
            this.soCMND.HeaderText = "Số CMND";
            this.soCMND.MinimumWidth = 6;
            this.soCMND.Name = "soCMND";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ ĐỘC GIẢ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.txtMaDG);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtSoDK);
            this.groupBox1.Controls.Add(this.txtTenDG);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(267, 69);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(220, 27);
            this.txtNgaySinh.TabIndex = 11;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(19, 58);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(136, 27);
            this.txtMaDG.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã độc giả";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(577, 69);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(117, 27);
            this.txtCMND.TabIndex = 6;
            // 
            // txtSoDK
            // 
            this.txtSoDK.Location = new System.Drawing.Point(577, 25);
            this.txtSoDK.Name = "txtSoDK";
            this.txtSoDK.Size = new System.Drawing.Size(117, 27);
            this.txtSoDK.TabIndex = 5;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(267, 28);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(220, 27);
            this.txtTenDG.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số đăng ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên độc giả";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Location = new System.Drawing.Point(556, 413);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.Location = new System.Drawing.Point(471, 413);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 27);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Location = new System.Drawing.Point(386, 413);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 27);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Location = new System.Drawing.Point(301, 413);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 27);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(216, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 27);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button6_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(16, 420);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<< Trang chủ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 452);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDocGia);
            this.Name = "frmQuanLyDocGia";
            this.Text = "QuanLyDocGia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyDocGia_FormClosing);
            this.Load += new System.EventHandler(this.QuanLyDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSoDK;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn soCMND;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgaySinh;
    }
}