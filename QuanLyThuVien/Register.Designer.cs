
namespace QuanLyThuVien
{
    partial class frmRegister
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRepeatPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbLinces = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThuVien.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(375, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG KÝ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xác thực mật khẩu";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(397, 92);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(214, 27);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Text = "\r\n";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(397, 125);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(214, 27);
            this.txtPass.TabIndex = 6;
            // 
            // txtRepeatPass
            // 
            this.txtRepeatPass.Location = new System.Drawing.Point(397, 157);
            this.txtRepeatPass.Name = "txtRepeatPass";
            this.txtRepeatPass.PasswordChar = '*';
            this.txtRepeatPass.Size = new System.Drawing.Size(214, 27);
            this.txtRepeatPass.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(534, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckbLinces
            // 
            this.ckbLinces.AutoSize = true;
            this.ckbLinces.Location = new System.Drawing.Point(260, 194);
            this.ckbLinces.Name = "ckbLinces";
            this.ckbLinces.Size = new System.Drawing.Size(232, 24);
            this.ckbLinces.TabIndex = 9;
            this.ckbLinces.Text = "Tôi đồng ý với mọi điều khoản";
            this.ckbLinces.UseVisualStyleBackColor = true;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 255);
            this.Controls.Add(this.ckbLinces);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRepeatPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmRegister";
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRepeatPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckbLinces;
    }
}