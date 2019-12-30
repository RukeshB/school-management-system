using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        void disable_button()
        {
            Student.Enabled = false; student_icon.Enabled = false;
            Staff.Enabled = false; staff_icon.Enabled = false;
            libary.Enabled = false; libary_icon.Enabled = false;
            bus.Enabled = false; bus_icon.Enabled = false;
            result.Enabled = false; result_icon.Enabled = false;
            account.Enabled = false; account_icon.Enabled = false;
            manage.Enabled = false; manage_icon.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (login.account_type == "teacher")
            {
                disable_button();
                staff_icon.Enabled = true; Staff.Enabled = true;
                student_icon.Enabled = true; student_icon.Enabled = true;
            }

            else if (login.account_type == "libary_department")
            {
                disable_button();
                libary.Enabled = true; libary_icon.Enabled = true;
            }
            else if (login.account_type == "exam_department")
            {
                disable_button();
                result.Enabled = true; result_icon.Enabled = true;
            }
            hide_usercontrol();
            close_panal.Hide();
            dashboard_main1.Show();
            //toolTip1.SetToolTip(student_icon, "Student Records");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide_panal();
        }

        private void show_Click(object sender, EventArgs e)
        {
            shown_panal.Hide();
            animation.ShowSync(close_panal);
        }

        private void home_click(object sender, EventArgs e)
        {
            hide_panal();
            //home_icon.BackColor = Color.DodgerBlue;
            //home.BackColor = Color.DodgerBlue;
            hide_usercontrol();
            dashboard_main1.Show();
            dashboard_main1.load();
        }

        private void student_click(object sender, EventArgs e)
        {
            hide_panal();
            hide_usercontrol();
            student_main1.Show();
            //Student.BackColor = Color.DodgerBlue;
            //student_icon.BackColor = Color.DodgerBlue;
        }

        private void Staff_click(object sender, EventArgs e)
        {
            hide_panal();
            hide_usercontrol();
            teacher1.Show();
            teacher1.clear();
            teacher1.LoadDataGridView();
        }

        private void manage_click(object sender, EventArgs e)
        {
            hide_panal();
            hide_usercontrol();
            manage_main1.Show();
        }

        private void libary_click(object sender, EventArgs e)
        {
            hide_panal();
            hide_usercontrol();
            libary_main1.Show();
        }

        private void bus_click(object sender, EventArgs e)
        {
            hide_panal();
            hide_usercontrol();
            school_bus1.Show();
            school_bus1.clear();
            school_bus1.loaddatagridview();
        }

        private void result_click(object sender, EventArgs e)
        {
            hide_panal();
            hide_usercontrol();
            exam_main1.Show();
        }

        private void account_click(object sender, EventArgs e)
        {
            hide_panal();
            hide_usercontrol();
            account_main1.Show();

        }

        void hide_panal()
        {
            animation.HideSync(close_panal);
            shown_panal.Show();
        }

        void hide_usercontrol()
        {
            account_main1.Hide();
            school_bus1.Hide();
            teacher1.Hide();
            libary_main1.Hide();
            student_main1.Hide();
            exam_main1.Hide();
            manage_main1.Hide();
            dashboard_main1.Hide();
        }

    }
}
