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
    public partial class FormFind : Form
    {
        private StudentContextDB context;
        public FormFind()
        {
            InitializeComponent();
        }

        private void FormFind_Load(object sender, EventArgs e)
        {
            context = new StudentContextDB();
            List<FACULTY> listFaculty = context.FACULTies.ToList();
            List<STUDENT> listStudent = context.STUDENTs.ToList();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (var item in listStudent)
                auto.Add(item.FullName);
            txt_hoten.AutoCompleteCustomSource = auto;
            txt_hoten.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_hoten.AutoCompleteSource = AutoCompleteSource.CustomSource;
            FillFalcultyCombobox(listFaculty);
        }

        private void FillFalcultyCombobox(List<FACULTY> listFalcultys)
        {
            this.cmb_khoa.DataSource = listFalcultys;
            this.cmb_khoa.DisplayMember = "FacultyName";
            this.cmb_khoa.ValueMember = "FacultyID";
            cmb_khoa.SelectedIndex = -1;
        }
         
        
        private void btn_trve_Click(object sender, EventArgs e)
        {
            this.Close();
            FormStudent formStudent = new FormStudent();
            formStudent.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_hoten.Clear();
            txt_maso.Clear();
            txt_kq.Text = "0";
            dgv_find.Rows.Clear();
            cmb_khoa.SelectedIndex = -1;
        }

        private bool IsDataValid()
        {
            string mssv = txt_maso.Text;
            string hoTen = txt_hoten.Text;
            if (string.IsNullOrEmpty(mssv) && string.IsNullOrEmpty(hoTen) && cmb_khoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void BindGrid(List<STUDENT> listStudent)
        {
            dgv_find.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgv_find.Rows.Add();
                dgv_find.Rows[index].Cells[0].Value = item.StudentID;
                dgv_find.Rows[index].Cells[1].Value = item.FullName;
                dgv_find.Rows[index].Cells[2].Value = item.FACULTY.FacultyName;
                dgv_find.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (!IsDataValid())
                return;

            string tenSinhVien = txt_hoten.Text;
            string maso = txt_maso.Text;
            

            var query = context.STUDENTs.AsQueryable();

            if (!string.IsNullOrWhiteSpace(tenSinhVien))
            {
                query = query.Where(sv => sv.FullName.Contains(tenSinhVien));
            }

            if (!string.IsNullOrWhiteSpace(maso))
            {
                query = query.Where(sv => sv.StudentID.Contains(maso));
            }

            int khoaID;
            if (cmb_khoa.SelectedValue != null)
            {
                khoaID = int.Parse(cmb_khoa.SelectedValue.ToString());
                query = query.Where(sv => sv.FacultyID == khoaID);
            }

            List<STUDENT> listStudentFind = query.ToList();
            BindGrid(listStudentFind);

            if(listStudentFind.Count == 0)
                MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt_kq.Text = listStudentFind.Count.ToString();
        }
    }
}
