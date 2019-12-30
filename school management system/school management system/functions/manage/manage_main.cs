using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.functions.manage
{
    public partial class manage_main : UserControl
    {
        public manage_main()
        {
            InitializeComponent();
        }

        public void hide()
        {
            add_subject1.Hide();
            manage_class1.Hide();
            manage_teacher1.Hide();
        }

        public void normal_color()
        {
            add_subject.BackColor = Color.Transparent;
            manage_teacher.BackColor = Color.Transparent;
            manage_class.BackColor = Color.Transparent;
        }
        private void manage_main_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            hide();
            manage_teacher1.Show();
            manage_teacher1.clear();
            manage_teacher1.Loaddatagrideview();
            normal_color();
            manage_teacher.BackColor = Color.DodgerBlue;
        }

        private void add_subject_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            add_subject1.Show();
            add_subject1.clear();
           // add_subject1.LoadDataGridView();
            add_subject1.load();
            add_subject.BackColor = Color.DodgerBlue;
        }

        private void manage_class_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            manage_class1.Show();
            manage_class1.clear();
            //manage_class1.LoadDataGridView();
            manage_class1.load();
            manage_class.BackColor = Color.DodgerBlue;
        }

        private void manage_teacher_click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            manage_teacher1.Show();
            manage_teacher1.clear();
            //manage_teacher1.Loaddatagrideview();
            manage_teacher1.load();
            manage_teacher.BackColor = Color.DodgerBlue;
        }
                        
    }
}
