using Lab04.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        private StudentContextDB context;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            context = new StudentContextDB();
            List<FACULTY> listFaculty = context.FACULTies.ToList();
            List<STUDENT> listStudent = context.STUDENTs.ToList();
            FillFalcultyCombobox(listFaculty);
            BindGrid(listStudent);
        }
        private void FillFalcultyCombobox(List<FACULTY> listFalcultys)
        {
            this.cb_khoa.DataSource = listFalcultys;
            this.cb_khoa.DisplayMember = "FacultyName";
            this.cb_khoa.ValueMember = "FacultyID";
        }
        private void BindGrid(List<STUDENT> listStudent)
        {
            dgv_sinhvien.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgv_sinhvien.Rows.Add();
                dgv_sinhvien.Rows[index].Cells[0].Value = item.StudentID;
                dgv_sinhvien.Rows[index].Cells[1].Value = item.FullName;
                dgv_sinhvien.Rows[index].Cells[2].Value = item.FACULTY.FacultyName;
                dgv_sinhvien.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        private bool IsDataValid()
        {
            string mssv = tb_maso.Text;
            string hoTen = tb_maso.Text;
            String diemTB = tb_dtb.Text.ToString();
            if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diemTB))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(tb_dtb.Text, out double averageScore) || Double.Parse(tb_dtb.Text) < 0)
            {
                MessageBox.Show("Điểm trung bình phải là kiểu số thực và không âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (mssv.Length != 10)
            {
                MessageBox.Show("Mã số sinh viên phải có 10 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ResetData()
        {
            tb_maso.Clear();
            tb_hoten.Clear();
            tb_dtb.Clear();
            cb_khoa.SelectedValue = 1;
            var danhSachSinhVien = context.STUDENTs.ToList();
            BindGrid(danhSachSinhVien);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!IsDataValid())
            {
                return;
            }
            STUDENT newStudent = new STUDENT()
            {
                StudentID = tb_maso.Text,
                FullName = tb_hoten.Text,
                FacultyID = (int)cb_khoa.SelectedValue,
                AverageScore = double.Parse(tb_dtb.Text),
            };
            context.STUDENTs.Add(newStudent);
            context.SaveChanges();
            ResetData();
            MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private STUDENT CheckIfMaSinhVienExists(string ID)
        {
            STUDENT s = context.STUDENTs.FirstOrDefault(p => p.StudentID == ID);
            if (s == null) return null;
            return s;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maSinhVienToDelete;
            if (tb_maso.Text == "")
            {
                if (dgv_sinhvien.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                maSinhVienToDelete = dgv_sinhvien.SelectedRows[0].Cells["Column1"].Value.ToString();
            }
            else
            {
                maSinhVienToDelete = tb_maso.Text;
                if (CheckIfMaSinhVienExists(maSinhVienToDelete) == null)
                {
                    MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                context.STUDENTs.Remove(CheckIfMaSinhVienExists(maSinhVienToDelete));
                context.SaveChanges();
                ResetData();
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maSinhVienToChange;
            if (tb_maso.Text == "")
            {
                if (dgv_sinhvien.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                maSinhVienToChange = dgv_sinhvien.SelectedRows[0].Cells["Column1"].Value.ToString();
            }
            else
            {
                maSinhVienToChange = tb_maso.Text;
                if (CheckIfMaSinhVienExists(maSinhVienToChange) == null)
                {
                    MessageBox.Show("Không tìm thấy MSSV cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa sinh viên này?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (!IsDataValid()) return;
                STUDENT s = new STUDENT()
                {
                    StudentID = tb_maso.Text,
                    FullName = tb_hoten.Text,
                    FacultyID = (int)cb_khoa.SelectedValue,
                    AverageScore = double.Parse(tb_dtb.Text),
                };
                context.Entry(CheckIfMaSinhVienExists(maSinhVienToChange)).CurrentValues.SetValues(s);
                context.SaveChanges();
                ResetData();
                MessageBox.Show("Sửa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_sinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string massv = dgv_sinhvien.Rows[e.RowIndex].Cells["Column1"].Value.ToString();
                string hoten = dgv_sinhvien.Rows[e.RowIndex].Cells["Column2"].Value.ToString();
                string diem = dgv_sinhvien.Rows[e.RowIndex].Cells["Column4"].Value.ToString();
                string khoa = dgv_sinhvien.Rows[e.RowIndex].Cells["Column3"].Value.ToString();
                tb_maso.Text = massv;
                tb_hoten.Text = hoten;
                tb_dtb.Text = diem;
                FACULTY s = context.FACULTies.FirstOrDefault(p => p.FacultyName == khoa);
                cb_khoa.SelectedValue = s.FacultyID;
            }
        }
    }
}
