using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace school_management_system.functions.student
{
    public partial class student_info : UserControl
    {
        public student_info()
        {
            InitializeComponent();
        }

        database db = new database();
        static MySqlConnection conn = new MySqlConnection("server=Localhost; database=school_database; userid=root;");
        MySqlCommand cmd = new MySqlCommand(" ", conn);
        public static string admission_date, student_id, Class, first_name, last_name, gender;
        public static string date_of_birth, birth_place, city, address, transport, phone, Email;

        private void student_info_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            admission_form1.Hide();
            loaddatagridview();
            edit.Enabled = false;
            delete.Enabled = false;
        }

        public  void loaddatagridview()
        {
            load_datagridview dgv = new load_datagridview();
            dgv.Loaddatagridview(dgvstudent, "student_info", "admission_date", "student_id", "class",
            "first_name","last_name","gender","date_of_birth","birth_place","city","address","transport","phone_no.","Email");
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            export ex=new export();
            ex.excel(dgvstudent,"student");
         }

        private void update_Click(object sender, EventArgs e)
        {
            admission_form.button = "update";
            admission_form1.load();
            admission_form1.Show();
            //message.show("Update Successfull", message.AlertType.success);
            loaddatagridview();
            delete.Enabled = false;
            edit.Enabled = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            db.InUpDel("DELETE FROM `student_info` WHERE `student_id`='" + student_id + "'");
            db.InUpDel("DELETE FROM `student` WHERE `student_id`='" + student_id + "'");
            message.show("Delete Successfull", message.AlertType.success);
           // clear();
            loaddatagridview();
            delete.Enabled = false;
            edit.Enabled = false;
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                admission_date = dgvstudent.CurrentRow.Cells[1].Value.ToString();
                student_id = dgvstudent.CurrentRow.Cells[2].Value.ToString();
                Class = dgvstudent.CurrentRow.Cells[3].Value.ToString();
                first_name= dgvstudent.CurrentRow.Cells[4].Value.ToString();
                last_name = dgvstudent.CurrentRow.Cells[5].Value.ToString();
                gender = dgvstudent.CurrentRow.Cells[6].Value.ToString();
                date_of_birth = dgvstudent.CurrentRow.Cells[7].Value.ToString();
                birth_place = dgvstudent.CurrentRow.Cells[8].Value.ToString();
                city= dgvstudent.CurrentRow.Cells[9].Value.ToString();
                address = dgvstudent.CurrentRow.Cells[10].Value.ToString();
                transport= dgvstudent.CurrentRow.Cells[11].Value.ToString();
                phone = dgvstudent.CurrentRow.Cells[12].Value.ToString();
                Email = dgvstudent.CurrentRow.Cells[13].Value.ToString();

                edit.Enabled = true;
                delete.Enabled = true;
            }
            catch
            {
               // clear();
            }
           
        }
    }
}
