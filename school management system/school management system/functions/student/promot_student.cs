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
    public partial class promot_student : UserControl
    {
        public promot_student()
        {
            InitializeComponent();
        }

        database db = new database();

        public void clear()
        {
            from.Text = to.Text = std_id.Text = std_name.Text = "";
        }

        private void promot_student_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void from_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(from, "SELECT * FROM `manage_class`", "class_id");
        }

        private void from_SelectedValueChanged(object sender, EventArgs e)
        {
            db.LoadComboBox(std_id, "SELECT * FROM `student_info` where class='" + from.Text + "'", "student_id");
            db.LoadComboBox(to, "SELECT * FROM `manage_class`", "class_id");
            clear();
        }

        private void std_id_SelectedValueChanged(object sender, EventArgs e)
        {
            db.LoadTextBox(std_name, "SELECT * FROM `student_info` where student_id='" + std_id.Text + "'", "first_name");
        }

        private void promot_Click(object sender, EventArgs e)
        {
            if (from.Text ==""|| to.Text ==""|| std_id.Text ==""|| std_name.Text == "")
            {
                message.show("Must fill all field", message.AlertType.info);
            }
            else
            {
                db.InUpDel("UPDATE `student_info` SET `class`='" + to.Text + "' WHERE student_id='" + std_id.Text + "'");
                clear();
                message.show("Save Successfull", message.AlertType.success);
            }
        }

        private void to_Click(object sender, EventArgs e)
        {
            //database db1 = new database();
            //db1.LoadComboBox(to, "SELECT * FROM `manage_class`", "class_id");
        }
                
    }
}
