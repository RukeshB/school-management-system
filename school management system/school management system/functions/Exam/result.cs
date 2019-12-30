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
    public partial class result : UserControl
    {
        public result()
        {
            InitializeComponent();
        }
        static MySqlConnection conn = new MySqlConnection("server=localhost; database=school_database; userid=root;");
        MySqlCommand cmd = new MySqlCommand("", conn);

        database db = new database();

        public void clear()
        {
            Class.Text = student_id.Text = student_name.Text = terminal_id.Text = terminal_name.Text = "";
        }

        private void result_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            clear();
           // dgvresult.Rows.Clear();
        }

        private void Class_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(Class, "SELECT * FROM manage_class", "class_id");
        }

        private void Class_SelectedValueChanged(object sender, EventArgs e)
        {
            db.LoadComboBox(student_id, "SELECT * FROM `student` WHERE class_id ='" + Class.Text + "'", "student_id");
            //clear(); 
        }

        private void student_id_SelectedValueChanged(object sender, EventArgs e)
        {
            db.LoadTextBox(student_name, "SELECT * FROM `student` WHERE student_id ='" + student_id.Text + "'", "student_name");
        }

        private void terminal_id_SelectedValueChanged(object sender, EventArgs e)
        {
            db.LoadTextBox(terminal_name, "SELECT * FROM `exam_terminals`", "terminal_name");
        }

        private void terminal_id_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(terminal_id, "SELECT * FROM `exam_terminals`", "terminal_id");
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            id_label.Text = student_id.Text;
            terminal_label.Text = terminal_name.Text;
            class_label.Text = Class.Text;
            name_lable.Text = student_name.Text;
            id_label.Show();
            terminal_label.Show();
            class_label.Show();
            name_lable.Show();
            datagridview();
            clear();
            //load_datagridview dgv = new load_datagridview();
            //dgv.Loaddatagridview(dgvresult, "");
        }

        void datagridview()
        {
            int sn = 1;
            try
            {
                dgvresult.Rows.Clear();
                conn.Open();
                cmd = new MySqlCommand("SELECT c.subject_id,m.marks,s.subject_name,s.full_marks,s.pass_marks from manage_class_subject c, exam_marks m,manage_subject s where c.class_id='"+
                    Class.Text + "' and c.subject_id = s.subject_code AND m.subject_code=s.subject_code and m.student_id='"+student_id.Text+"'", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgvresult.Rows.Add(sn, reader.GetString("subject_id"), reader.GetString("subject_name"),
                            reader.GetString("full_marks"), reader.GetString("pass_marks"), reader.GetString("marks"));
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
    }
}
