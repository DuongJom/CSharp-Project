
namespace QuanLyThuVien
{
    partial class frmTimKiem
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
            this.rdbTenSach = new System.Windows.Forms.RadioButton();
            this.rdbTacGia = new System.Windows.Forms.RadioButton();
            this.txtSearchTenSach = new System.Windows.Forms.TextBox();
            this.txtSearchTacGia = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvTimSach = new System.Windows.Forms.DataGridView();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm theo";
            // 
            // rdbTenSach
            // 
            this.rdbTenSach.AutoSize = true;
            this.rdbTenSach.Location = new System.Drawing.Point(114, 46);
            this.rdbTenSach.Name = "rdbTenSach";
            this.rdbTenSach.Size = new System.Drawing.Size(86, 24);
            this.rdbTenSach.TabIndex = 2;
            this.rdbTenSach.Text = "Tên sách";
            this.rdbTenSach.UseVisualStyleBackColor = true;
            // 
            // rdbTacGia
            // 
            this.rdbTacGia.AutoSize = true;
            this.rdbTacGia.Location = new System.Drawing.Point(113, 80);
            this.rdbTacGia.Name = "rdbTacGia";
            this.rdbTacGia.Size = new System.Drawing.Size(76, 24);
            this.rdbTacGia.TabIndex = 3;
            this.rdbTacGia.Text = "Tác giả";
            this.rdbTacGia.UseVisualStyleBackColor = true;
            this.rdbTacGia.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtSearchTenSach
            // 
            this.txtSearchTenSach.Location = new System.Drawing.Point(206, 46);
            this.txtSearchTenSach.Name = "txtSearchTenSach";
            this.txtSearchTenSach.Size = new System.Drawing.Size(244, 27);
            this.txtSearchTenSach.TabIndex = 4;
            // 
            // txtSearchTacGia
            // 
            this.txtSearchTacGia.Location = new System.Drawing.Point(206, 79);
            this.txtSearchTacGia.Name = "txtSearchTacGia";
            this.txtSearchTacGia.Size = new System.Drawing.Size(244, 27);
            this.txtSearchTacGia.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(492, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 33);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvTimSach
            // 
            this.dgvTimSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSach,
            this.tenSach,
            this.tacGia,
            this.theLoai,
            this.soLuong});
            this.dgvTimSach.Location = new System.Drawing.Point(12, 121);
            this.dgvTimSach.Name = "dgvTimSach";
            this.dgvTimSach.RowHeadersWidth = 51;
            this.dgvTimSach.RowTemplate.Height = 29;
            this.dgvTimSach.Size = new System.Drawing.Size(584, 202);
            this.dgvTimSach.TabIndex = 7;
            // 
            // maSach
            // 
            this.maSach.DataPropertyName = "maSach";
            this.maSach.HeaderText = "Mã sách";
            this.maSach.MinimumWidth = 6;
            this.maSach.Name = "maSach";
            // 
            // tenSach
            // 
            this.tenSach.DataPropertyName = "tenSach";
            this.tenSach.HeaderText = "Tên sách";
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
            this.theLoai.HeaderText = "Thể loại";
            this.theLoai.MinimumWidth = 6;
            this.theLoai.Name = "theLoai";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(492, 86);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 20);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<<Trang chủ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 335);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dgvTimSach);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchTacGia);
            this.Controls.Add(this.txtSearchTenSach);
            this.Controls.Add(this.rdbTacGia);
            this.Controls.Add(this.rdbTenSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTimKiem";
            this.Text = "Tìm Kiếm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiem_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbTenSach;
        private System.Windows.Forms.RadioButton rdbTacGia;
        private System.Windows.Forms.TextBox txtSearchTenSach;
        private System.Windows.Forms.TextBox txtSearchTacGia;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTimSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}