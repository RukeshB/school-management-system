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

namespace school_management_system.functions.Exam
{
    public partial class add_subject : UserControl
    {
        static MySqlConnection conn = new MySqlConnection("server=localhost; database=school_database; userid=root;");
        MySqlCommand cmd = new MySqlCommand("", conn);

        database db = new database();
        string check_code,check_class;

        public add_subject()
        {
            InitializeComponent();
        }

        public void clear()
        {
            subject_code.Text = subject_name.Text = full_marks.Text = pass_marks.Text = Class.Text ="";
        }

        private void add_subject_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            LoadDataGridView();
            clear();
            update.Enabled = false;
            delete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if( subject_code.Text ==""|| subject_name.Text ==""|| full_marks.Text ==""|| pass_marks.Text == "" || Class.Text=="")
            {
                //MessageBox.Show("fill-up all field");
                message.show("Must fill all field", message.AlertType.info);
            }
            else
            {
                    db.InUpDel("INSERT INTO `manage_subject`(`subject_code`, `subject_name`, `full_marks`, `pass_marks`) VALUES ('" + subject_code.Text 
                        + "','" + subject_name.Text + "','" + full_marks.Text + "','" + pass_marks.Text + "')");
                    db.InUpDel("INSERT INTO `manage_class_subject`(`class_id`, `subject_id`) VALUES ('" + Class.Text + "','" + subject_code.Text + "')");
                    message.show("Add Successfull", message.AlertType.success);
                clear();
                LoadDataGridView();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            db.InUpDel("UPDATE `manage_subject` SET `subject_code`='" + subject_code.Text + "',`subject_name`='" + subject_name.Text +
                        "',`full_marks`='" + full_marks.Text + "',`pass_marks`='" + pass_marks.Text + "' WHERE subject_code='" + check_code + "'");
            db.InUpDel("UPDATE `manage_class_subject` SET `class_id`='" + Class.Text +"' , subject_id='" + subject_code.Text +
                "' where subject_id='" + check_code + "' and class_id='"+ check_class+"'");
            message.show("Update Successfull", message.AlertType.success);
            clear();
            LoadDataGridView();
            delete.Enabled = false;
            update.Enabled = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            db.InUpDel("DELETE FROM `manage_subject` WHERE subject_code='" + check_code + "'");
            db.InUpDel("DELETE FROM `manage_class_subject` WHERE subject_id='" + check_code + "' and class_id='"+check_class+"'");
            message.show("Delete Successfull", message.AlertType.success);
            clear();
            LoadDataGridView();
            delete.Enabled = false;
            update.Enabled = false;
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * from manage_class_subject where subject_id='" + 
                    dgvsubject.CurrentRow.Cells[1].Value.ToString()+"'", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       check_class=Class.Text = reader.GetString("class_id");
                    }
                }
                subject_code.Text = check_code = dgvsubject.CurrentRow.Cells[1].Value.ToString();
                subject_name.Text = dgvsubject.CurrentRow.Cells[2].Value.ToString();
                full_marks.Text = dgvsubject.CurrentRow.Cells[3].Value.ToString();
                pass_marks.Text = dgvsubject.CurrentRow.Cells[4].Value.ToString();
               // btnSave.Text = "Update";
                update.Enabled = true;
                delete.Enabled = true;
                // btnSave.Enabled = false;
            }
            catch
            {
                clear();
            }
            finally
            {
                conn.Close();
            }
        }


        private void Class_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(Class, "SELECT * FROM manage_class", "class_id");
        }

        public void LoadDataGridView()
        {
            load_datagridview dgv = new load_datagridview();
            dgv.Loaddatagridview(dgvsubject, "manage_subject", "subject_code", "subject_name", "full_marks", "pass_marks");
        }

        private void textonly_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void digitonly_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            export ex = new export();
            ex.excel(dgvsubject, "subject_information");
        }
       
    }
}
