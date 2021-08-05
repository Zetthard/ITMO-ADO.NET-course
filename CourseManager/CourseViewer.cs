using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManager
{
    public partial class CourseViewer : Form
    {
        private SchoolEntities schoolContext;
        public CourseViewer()
        {
            InitializeComponent();
        }

        private void CourseViewer_Load(object sender, EventArgs e)
        {
            schoolContext = new SchoolEntities();
            var departmentQuery = from d in schoolContext.Departments.Include("Courses")
                                  orderby d.Name
                                  select d;
            try
            {
                comboBoxDepartmentList.DisplayMember = "Name";
                comboBoxDepartmentList.DataSource = departmentQuery.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxDepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Department department = (Department)comboBoxDepartmentList.SelectedItem;

                dataGridViewCourse.DataSource = department.Courses.ToList();

                dataGridViewCourse.Columns["Department"].Visible = false;
                dataGridViewCourse.Columns["StudentGrades"].Visible = false;
                dataGridViewCourse.Columns["OnlineCourse"].Visible = false;
                dataGridViewCourse.Columns["OnsiteCourse"].Visible = false;
                dataGridViewCourse.Columns["People"].Visible = false;
                dataGridViewCourse.Columns["DepartmentId"].Visible = false;

                dataGridViewCourse.AllowUserToDeleteRows = false;
                dataGridViewCourse.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                schoolContext.SaveChanges();
                MessageBox.Show("Данные в базе успешно обновлены");
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            Close();
            schoolContext.Dispose();
        }
    }
}
