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

    public partial class marks_obtain : UserControl
    {
        public marks_obtain()
        {
            InitializeComponent();
        }

        static MySqlConnection conn = new MySqlConnection("server=localhost; database=school_database; userid=root;");
        MySqlCommand cmd = new MySqlCommand("", conn);

        database db = new database();

        public void clear()
        {
            Class.Text = subject_code.Text = subject_name.Text = terminal_id.Text = terminal_name.Text= "";
            //dgvmarks.Rows.Clear();
        }
        private void marks_obtain_Load(object sender, EventArgs e)
        {
            //clear();
            //datagridview();
            load();
        }

        public void load()
        {
            clear();
            datagridclear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Class.Text == "" || subject_code.Text == "" || subject_name.Text == "" || terminal_id.Text == "" || terminal_name.Text == "")
            {
                message.show("Must fill all field", message.AlertType.info);
            }
            else
            {
                int i;
                for (i = 0; i < dgvmarks.Rows.Count - 1; i++)
                {
                    db.InUpDel("INSERT INTO `exam_marks`(`class_id`, `subject_code`, `terminal_id`, `student_id`, `student_name`, `marks`) VALUES ('" +
                    Class.Text + "','" + subject_code.Text + "','" + terminal_id.Text + "','" + dgvmarks.Rows[i].Cells[1].FormattedValue.ToString() +
                    "','" + dgvmarks.Rows[i].Cells[2].FormattedValue.ToString() + "','" + dgvmarks.Rows[i].Cells[3].FormattedValue.ToString() + "')");
                }
                clear();
                datagridclear();
                message.show("Save Successfull", message.AlertType.success);
                //db.InUpDel("INSERT INTO `exam_marks`(`class_id`, `subject_code`, `terminal_id`, `student_id`, `student_name`, `marks`) VALUES ('"+
                //Class.Text+"','"+subject_code.Text+"','"+terminal.Text+"','"+)")
            }
        }

        private void Class_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(Class, "SELECT * FROM manage_class", "class_id");
        }

        private void Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.LoadComboBox(subject_code, "SELECT * FROM `manage_class_subject` WHERE class_id ='"+Class.Text+"'", "subject_id");
            //dgvmarks.Rows.Clear();
            datagridview();
            clear();
        }

        private void subject_code_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.LoadTextBox(subject_name, "SELECT * FROM `manage_subject` WHERE subject_code='" + subject_code.Text + "'", "subject_name");
        }

        private void terminal_id_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(terminal_id, "SELECT * FROM `exam_terminals`", "terminal_id");
        }

        private void terminal_id_SelectedValueChanged(object sender, EventArgs e)
        {
            db.LoadTextBox(terminal_name, "SELECT * FROM `exam_terminals`", "terminal_name");
        }

       public void datagridview()
        {
            int sn = 1;
            try
            {
                dgvmarks.Rows.Clear();
                conn.Open();
                cmd = new MySqlCommand("SELECT * from student where class_id='"+Class.Text+"'", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvmarks.Rows.Add(sn, reader.GetString("student_id"), reader.GetString("student_name"));
                        sn++;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
        public void datagridclear()
        {
            dgvmarks.Rows.Clear();
        }
        private void dgvmarks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
