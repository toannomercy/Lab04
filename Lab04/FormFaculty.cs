using Lab04.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class FormFaculty : Form
    {
        private StudentContextDB context;
        public FormFaculty()
        {
            InitializeComponent();
        }

        private void FormFaculty_Load(object sender, EventArgs e)
        {
            context = new StudentContextDB();
            List<FACULTY> listFaculty = context.FACULTies.ToList();
            BindGrid(listFaculty);
        }
        private void BindGrid(List<FACULTY> listFaculty)
        {
            dgv_faculty.Rows.Clear();
            foreach (var item in listFaculty)
            {
                int index = dgv_faculty.Rows.Add();
                dgv_faculty.Rows[index].Cells[0].Value = item.FacultyID;
                dgv_faculty.Rows[index].Cells[1].Value = item.FacultyName;
                dgv_faculty.Rows[index].Cells[2].Value = item.TotolProfessor;
            }
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
            FormStudent formStudent = new FormStudent();    
            formStudent.Show();
        }
        private bool IsNonNegativeInteger(string input)
        {
            if (int.TryParse(input, out int result) && result >= 0)
                return true;
            else
                return false;
        }
        private void ResetData()
        {
            tb_makhoa.Clear();
            tb_tenkhoa.Clear();
            tb_tonggs.Clear();
            var danhSachKhoa = context.FACULTies.ToList();
            BindGrid(danhSachKhoa);
        }
        private FACULTY checkIfIdExists(int id)
        {
            FACULTY s = context.FACULTies.FirstOrDefault(p => p.FacultyID == id);
            if (s == null) return null;
            return s;
        }

        private STUDENT checkIfStudentExists(int id)
        {
            STUDENT s = context.STUDENTs.FirstOrDefault(p => p.FacultyID == id);
            if (s == null) return null;
            return s;
        }
        private bool IsDataValid()
        {
            string id = tb_makhoa.Text;
            string tenKhoa = tb_tenkhoa.Text;
            string tongGS = tb_tonggs.Text;
            if(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(tenKhoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(!IsNonNegativeInteger(id))
            {
                MessageBox.Show("Mã khoa phải là số nguyên không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(!string.IsNullOrEmpty(tongGS) && !IsNonNegativeInteger(tongGS))
            {
                MessageBox.Show("Tổng số giáo phải là số nguyên không âm, hoặc Null", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btn_themsua_Click(object sender, EventArgs e)
        {
            if (!IsDataValid()) return;
            int id = int.Parse(tb_makhoa.Text);
            bool existsId = context.FACULTies.Any(s => s.FacultyID == id);
            if(existsId)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa khoa này?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int? tong;
                    if (string.IsNullOrEmpty(tb_tonggs.Text))
                        tong = null;
                    else
                        tong = int.Parse (tb_tonggs.Text);
                    FACULTY s = new FACULTY()
                    {
                        FacultyID = int.Parse(tb_makhoa.Text),
                        FacultyName = tb_tenkhoa.Text,
                        TotolProfessor = tong,
                    };
                    context.Entry(checkIfIdExists(id)).CurrentValues.SetValues(s);
                    context.SaveChanges();
                    ResetData();
                    MessageBox.Show("Sửa Khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                int? tong;
                if (string.IsNullOrEmpty(tb_tonggs.Text))
                    tong = null;
                else
                    tong = int.Parse(tb_tonggs.Text);
                FACULTY s = new FACULTY()
                {
                    FacultyID = int.Parse(tb_makhoa.Text),
                    FacultyName = tb_tenkhoa.Text,
                    TotolProfessor = tong,
                };
                context.FACULTies.Add(s);
                context.SaveChanges();
                ResetData();
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int ID;
            if (tb_makhoa.Text == "")
            {
                if (dgv_faculty.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ID = int.Parse(dgv_faculty.SelectedRows[0].Cells["Column1"].Value.ToString());
            }
            else
            {
                ID = int.Parse(tb_makhoa.Text);
                if (checkIfIdExists(ID) == null)
                {
                    MessageBox.Show("Không tìm thấy mã khoa cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoa này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes && checkIfStudentExists(ID) == null)
            {
                context.FACULTies.Remove(checkIfIdExists(ID));
                context.SaveChanges();
                ResetData();
                MessageBox.Show("Xóa khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Không thể khoa đang có sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
        }

    }
}
