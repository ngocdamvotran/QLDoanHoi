namespace QLDoanhoi
{
    partial class frmChuongTrinh
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
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbThoiGian = new System.Windows.Forms.TextBox();
            this.tbCapDo = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.lbCapDo = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.dgvChuongtrinh = new System.Windows.Forms.DataGridView();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongtrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnAdd);
            this.grbThongTin.Controls.Add(this.btnUpdate);
            this.grbThongTin.Controls.Add(this.btnDel);
            this.grbThongTin.Controls.Add(this.tbMa);
            this.grbThongTin.Controls.Add(this.tbThoiGian);
            this.grbThongTin.Controls.Add(this.tbCapDo);
            this.grbThongTin.Controls.Add(this.lbTen);
            this.grbThongTin.Controls.Add(this.tbTen);
            this.grbThongTin.Controls.Add(this.lbThoiGian);
            this.grbThongTin.Controls.Add(this.lbCapDo);
            this.grbThongTin.Controls.Add(this.lbMa);
            this.grbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin.Location = new System.Drawing.Point(24, 12);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(546, 282);
            this.grbThongTin.TabIndex = 0;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin chương trình";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(56, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(211, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 38);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(364, 228);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(111, 38);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(240, 25);
            this.tbMa.Multiline = true;
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(235, 32);
            this.tbMa.TabIndex = 3;
            // 
            // tbThoiGian
            // 
            this.tbThoiGian.Location = new System.Drawing.Point(240, 156);
            this.tbThoiGian.Multiline = true;
            this.tbThoiGian.Name = "tbThoiGian";
            this.tbThoiGian.Size = new System.Drawing.Size(235, 36);
            this.tbThoiGian.TabIndex = 3;
            // 
            // tbCapDo
            // 
            this.tbCapDo.Location = new System.Drawing.Point(240, 110);
            this.tbCapDo.Multiline = true;
            this.tbCapDo.Name = "tbCapDo";
            this.tbCapDo.Size = new System.Drawing.Size(235, 36);
            this.tbCapDo.TabIndex = 3;
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(53, 76);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(77, 24);
            this.lbTen.TabIndex = 1;
            this.lbTen.Text = "Tên CT";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(240, 66);
            this.tbTen.Multiline = true;
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(235, 34);
            this.tbTen.TabIndex = 3;
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.Location = new System.Drawing.Point(53, 168);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(129, 24);
            this.lbThoiGian.TabIndex = 2;
            this.lbThoiGian.Text = "Thời gian BD";
            // 
            // lbCapDo
            // 
            this.lbCapDo.AutoSize = true;
            this.lbCapDo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapDo.Location = new System.Drawing.Point(52, 122);
            this.lbCapDo.Name = "lbCapDo";
            this.lbCapDo.Size = new System.Drawing.Size(108, 24);
            this.lbCapDo.TabIndex = 2;
            this.lbCapDo.Text = "Cấp độ CT";
            // 
            // lbMa
            // 
            this.lbMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMa.Location = new System.Drawing.Point(53, 31);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(95, 45);
            this.lbMa.TabIndex = 0;
            this.lbMa.Text = "Mã CT";
            // 
            // dgvChuongtrinh
            // 
            this.dgvChuongtrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuongtrinh.Location = new System.Drawing.Point(24, 300);
            this.dgvChuongtrinh.Name = "dgvChuongtrinh";
            this.dgvChuongtrinh.Size = new System.Drawing.Size(546, 237);
            this.dgvChuongtrinh.TabIndex = 1;
            // 
            // frmChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 549);
            this.Controls.Add(this.dgvChuongtrinh);
            this.Controls.Add(this.grbThongTin);
            this.Name = "frmChuongTrinh";
            this.Text = "ChuongTrinh";
            this.Load += new System.EventHandler(this.frmQlDH_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuongtrinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbCapDo;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbCapDo;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbThoiGian;
        private System.Windows.Forms.Label lbThoiGian;
        private System.Windows.Forms.DataGridView dgvChuongtrinh;
    }
}

