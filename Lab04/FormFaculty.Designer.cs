namespace Lab04
{
    partial class FormFaculty
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
            this.gb_thongtinkhoa = new System.Windows.Forms.GroupBox();
            this.tb_tonggs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tenkhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_makhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_faculty = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_themsua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.gb_thongtinkhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_faculty)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_thongtinkhoa
            // 
            this.gb_thongtinkhoa.Controls.Add(this.tb_tonggs);
            this.gb_thongtinkhoa.Controls.Add(this.label3);
            this.gb_thongtinkhoa.Controls.Add(this.tb_tenkhoa);
            this.gb_thongtinkhoa.Controls.Add(this.label2);
            this.gb_thongtinkhoa.Controls.Add(this.tb_makhoa);
            this.gb_thongtinkhoa.Controls.Add(this.label1);
            this.gb_thongtinkhoa.ForeColor = System.Drawing.Color.Blue;
            this.gb_thongtinkhoa.Location = new System.Drawing.Point(16, 15);
            this.gb_thongtinkhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_thongtinkhoa.Name = "gb_thongtinkhoa";
            this.gb_thongtinkhoa.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_thongtinkhoa.Size = new System.Drawing.Size(377, 287);
            this.gb_thongtinkhoa.TabIndex = 0;
            this.gb_thongtinkhoa.TabStop = false;
            this.gb_thongtinkhoa.Text = "THÔNG TIN KHOA";
            // 
            // tb_tonggs
            // 
            this.tb_tonggs.Location = new System.Drawing.Point(117, 199);
            this.tb_tonggs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_tonggs.Name = "tb_tonggs";
            this.tb_tonggs.Size = new System.Drawing.Size(132, 22);
            this.tb_tonggs.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng số GS";
            // 
            // tb_tenkhoa
            // 
            this.tb_tenkhoa.Location = new System.Drawing.Point(117, 119);
            this.tb_tenkhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_tenkhoa.Name = "tb_tenkhoa";
            this.tb_tenkhoa.Size = new System.Drawing.Size(232, 22);
            this.tb_tenkhoa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khoa";
            // 
            // tb_makhoa
            // 
            this.tb_makhoa.Location = new System.Drawing.Point(117, 50);
            this.tb_makhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_makhoa.Name = "tb_makhoa";
            this.tb_makhoa.Size = new System.Drawing.Size(132, 22);
            this.tb_makhoa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // dgv_faculty
            // 
            this.dgv_faculty.AllowUserToAddRows = false;
            this.dgv_faculty.AllowUserToDeleteRows = false;
            this.dgv_faculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_faculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_faculty.Location = new System.Drawing.Point(401, 15);
            this.dgv_faculty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_faculty.Name = "dgv_faculty";
            this.dgv_faculty.ReadOnly = true;
            this.dgv_faculty.RowHeadersWidth = 51;
            this.dgv_faculty.Size = new System.Drawing.Size(618, 379);
            this.dgv_faculty.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Khoa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Khoa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tổng số GS";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // btn_themsua
            // 
            this.btn_themsua.Location = new System.Drawing.Point(167, 366);
            this.btn_themsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_themsua.Name = "btn_themsua";
            this.btn_themsua.Size = new System.Drawing.Size(100, 28);
            this.btn_themsua.TabIndex = 2;
            this.btn_themsua.Text = "Thêm/Sửa";
            this.btn_themsua.UseVisualStyleBackColor = true;
            this.btn_themsua.Click += new System.EventHandler(this.btn_themsua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(293, 366);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(951, 401);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(100, 28);
            this.btn_dong.TabIndex = 2;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // FormFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 441);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_themsua);
            this.Controls.Add(this.dgv_faculty);
            this.Controls.Add(this.gb_thongtinkhoa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFaculty";
            this.Text = "FormFaculty";
            this.Load += new System.EventHandler(this.FormFaculty_Load);
            this.gb_thongtinkhoa.ResumeLayout(false);
            this.gb_thongtinkhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_faculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_thongtinkhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_faculty;
        private System.Windows.Forms.TextBox tb_tonggs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tenkhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_themsua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_dong;
    }
}