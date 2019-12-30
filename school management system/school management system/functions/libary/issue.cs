using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.functions.libary
{
    public partial class issue : UserControl
    {
        public issue()
        {
            InitializeComponent();
        }

        database db = new database();

        public void clear()
        {
            Class.Text = std_id.Text = student_name.Text = bookCode.Text = title.Text = "";
        }

        private void issue_book_Click(object sender, EventArgs e)
        {
            if (Class.Text == "" || std_id.Text == "" || student_name.Text == "" || bookCode.Text == "" || title.Text == "")
            {
               // MessageBox.Show("Fill up all field");
                message.show("Must fill all field", message.AlertType.info);
            }
            else
            {
                db.InUpDel("INSERT INTO `libary_issue_book`(`student_id`, `book_code`, `date_of_issue`) VALUES ('" +
                    std_id.Text + "','" + bookCode.Text + "','" + date.Text + "')");
                db.InUpDel("UPDATE `libary_book_menu` SET `number_of_book`=`number_of_book`-1 WHERE book_code='" + bookCode.Text + "'");
                message.show("Issue Successfull", message.AlertType.success);
                clear();
            }
        }

        private void Class_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(Class, "SELECT * FROM manage_class", "class_id");
        }

        private void Class_SelectedValueChanged(object sender, EventArgs e)
        {
            db.LoadComboBox(std_id, "SELECT * FROM `student` WHERE class_id ='" + Class.Text + "'", "student_id");
            clear(); 
        }

        private void std_id_SelectedValueChanged(object sender, EventArgs e)
        {
            db.LoadTextBox(student_name, "SELECT * FROM `student` WHERE student_id ='" + std_id.Text + "'", "student_name");
            bookCode.Text = title.Text = "";
        }

        private void bookCode_SelectedValueChanged(object sender, EventArgs e)
        {
            db.LoadTextBox(title, "SELECT * FROM `libary_book_menu` where book_code='" + bookCode.Text + "'", "title");
        }

        private void bookCode_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(bookCode, "SELECT * FROM `libary_book_menu` where `number_of_book` != 0", "book_code");
        }

        private void issue_Load(object sender, EventArgs e)
        {
            clear();
        }

    }
}
