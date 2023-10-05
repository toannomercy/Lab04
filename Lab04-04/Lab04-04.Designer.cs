namespace Lab04_04
{
    partial class FormProduct
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
            this.gb_thongtin = new System.Windows.Forms.GroupBox();
            this.dtp_deliverydate = new System.Windows.Forms.DateTimePicker();
            this.dtp_orderdate = new System.Windows.Forms.DateTimePicker();
            this.cb_showall = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_orderinfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.gb_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_thongtin
            // 
            this.gb_thongtin.Controls.Add(this.dtp_deliverydate);
            this.gb_thongtin.Controls.Add(this.dtp_orderdate);
            this.gb_thongtin.Controls.Add(this.cb_showall);
            this.gb_thongtin.Controls.Add(this.label2);
            this.gb_thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_thongtin.ForeColor = System.Drawing.Color.Blue;
            this.gb_thongtin.Location = new System.Drawing.Point(17, 16);
            this.gb_thongtin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_thongtin.Name = "gb_thongtin";
            this.gb_thongtin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_thongtin.Size = new System.Drawing.Size(1029, 178);
            this.gb_thongtin.TabIndex = 0;
            this.gb_thongtin.TabStop = false;
            this.gb_thongtin.Text = "Thông tin đơn hàng";
            // 
            // dtp_deliverydate
            // 
            this.dtp_deliverydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_deliverydate.Location = new System.Drawing.Point(643, 103);
            this.dtp_deliverydate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_deliverydate.Name = "dtp_deliverydate";
            this.dtp_deliverydate.Size = new System.Drawing.Size(319, 24);
            this.dtp_deliverydate.TabIndex = 3;
            this.dtp_deliverydate.Value = new System.DateTime(2019, 10, 5, 0, 0, 0, 0);
            this.dtp_deliverydate.ValueChanged += new System.EventHandler(this.dtp_orderdate_ValueChanged);
            // 
            // dtp_orderdate
            // 
            this.dtp_orderdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_orderdate.Location = new System.Drawing.Point(263, 103);
            this.dtp_orderdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_orderdate.Name = "dtp_orderdate";
            this.dtp_orderdate.Size = new System.Drawing.Size(321, 24);
            this.dtp_orderdate.TabIndex = 3;
            this.dtp_orderdate.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            this.dtp_orderdate.ValueChanged += new System.EventHandler(this.dtp_orderdate_ValueChanged);
            // 
            // cb_showall
            // 
            this.cb_showall.AutoSize = true;
            this.cb_showall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showall.ForeColor = System.Drawing.Color.Black;
            this.cb_showall.Location = new System.Drawing.Point(53, 58);
            this.cb_showall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_showall.Name = "cb_showall";
            this.cb_showall.Size = new System.Drawing.Size(179, 22);
            this.cb_showall.TabIndex = 0;
            this.cb_showall.Text = "Xem tất cả trong tháng";
            this.cb_showall.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(85, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian giao hàng";
            // 
            // dgv_orderinfo
            // 
            this.dgv_orderinfo.AllowUserToAddRows = false;
            this.dgv_orderinfo.AllowUserToDeleteRows = false;
            this.dgv_orderinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_orderinfo.Location = new System.Drawing.Point(17, 203);
            this.dgv_orderinfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_orderinfo.Name = "dgv_orderinfo";
            this.dgv_orderinfo.ReadOnly = true;
            this.dgv_orderinfo.RowHeadersWidth = 51;
            this.dgv_orderinfo.Size = new System.Drawing.Size(1029, 464);
            this.dgv_orderinfo.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số HĐ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Đặt Hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Giao Hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành Tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 689);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng cộng";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(804, 686);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_amount.Size = new System.Drawing.Size(241, 22);
            this.txt_amount.TabIndex = 3;
            this.txt_amount.Text = "0";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 725);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_orderinfo);
            this.Controls.Add(this.gb_thongtin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.gb_thongtin.ResumeLayout(false);
            this.gb_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_thongtin;
        private System.Windows.Forms.DateTimePicker dtp_deliverydate;
        private System.Windows.Forms.DateTimePicker dtp_orderdate;
        private System.Windows.Forms.CheckBox cb_showall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_orderinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

