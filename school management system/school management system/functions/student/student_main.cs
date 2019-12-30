using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.functions.student
{
    public partial class student_main : UserControl
    {
        public student_main()
        {
            InitializeComponent();
        }

        public void hide()
        {
            admission_form1.Hide();
            student_info1.Hide();
            promot_student1.Hide();
        }

        public void normal_color()
        {
            admission.BackColor = Color.Transparent;
            student_info.BackColor = Color.Transparent;
            promot_student.BackColor = Color.Transparent;
        }

        private void student_main_Load(object sender, EventArgs e)
        {
            hide();
            student_info1.loaddatagridview();
            student_info1.Show();
            student_info.BackColor = Color.DodgerBlue;
        }

        private void admission_Click(object sender, EventArgs e)
        {
            hide();
            admission_form.button = "submit";
            normal_color();
            admission_form1.Show();
            admission_form1.clear();
            admission.BackColor = Color.DodgerBlue;
            admission_form1.load();
        }

        private void student_info_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            student_info1.loaddatagridview();
            student_info1.load();
            student_info1.Show();
            student_info.BackColor = Color.DodgerBlue;

        }

        private void promot_student_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            promot_student1.Show();
            promot_student1.clear();
            promot_student.BackColor = Color.DodgerBlue;
        }
               
    }
}
