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
    public partial class manage_teacher : UserControl
    {
        public manage_teacher()
        {
            InitializeComponent();
        }

        database db=new database();
        string check_subj_teacher_id;

        public void clear()
        {
            subject_teacher_id.Text = subject_id.Text = teacher_id.Text = "";
        }

        private void manage_teacher_Load(object sender, EventArgs e)
        {
            load();
            //clear();
           // Loaddatagrideview();
        }

        public void load()
        {
            clear();
            Loaddatagrideview();
            update.Enabled = false;
            delete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (subject_teacher_id.Text == "" || subject_id.Text == "" || teacher_id.Text == "")
            {
                //MessageBox.Show("all field must be filled-up");
                message.show("Must fill all field", message.AlertType.info);
            }
            else
            {
                db.InUpDel("INSERT INTO `manage_subject_teacher`(`sub_teacher_id`, `subject_id`, `teacher_id`) VALUES ('" +
                    subject_teacher_id.Text + "','" + subject_id.Text + "','" + teacher_id.Text + "')");
                clear();
                message.show("Save Successfull", message.AlertType.success);
                Loaddatagrideview();
            }
         }

        private void update_Click(object sender, EventArgs e)
        {
            db.InUpDel("UPDATE `manage_subject_teacher` SET `sub_teacher_id`='" + subject_teacher_id.Text + "',`subject_id`='" +
                subject_id.Text + "',`teacher_id`='" + teacher_id.Text + "' WHERE sub_teacher_id='"+check_subj_teacher_id+"'");
            message.show("Update Successfull", message.AlertType.success);
            delete.Enabled = false;
            update.Enabled = false;
            Loaddatagrideview();
            clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            db.InUpDel("DELETE FROM `manage_subject_teacher` WHERE sub_teacher_id='" + check_subj_teacher_id + "'");
            message.show("Delete Successfull", message.AlertType.success);
            delete.Enabled = false;
            update.Enabled = false;
            Loaddatagrideview();
            clear();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                subject_teacher_id.Text= check_subj_teacher_id = dgvsubject_teacher.CurrentRow.Cells[1].Value.ToString();
                subject_id.Text = dgvsubject_teacher.CurrentRow.Cells[2].Value.ToString();
                teacher_id.Text = dgvsubject_teacher.CurrentRow.Cells[3].Value.ToString();
               // btnSave.Text = "Update";
                update.Enabled = true;
                delete.Enabled = true;
                // btnSave.Enabled = false;
            }
            catch
            {
                clear();
            }
        }


        private void teacher_id_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(teacher_id, "SELECT * FROM `staff_info` where designation='Teacher'", "staff_id");
        }

        private void subject_id_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(subject_id, "SELECT * FROM `manage_subject`", "subject_code");
        }
 
        public void Loaddatagrideview()
        {
            load_datagridview dgv = new load_datagridview();
            dgv.Loaddatagridview(dgvsubject_teacher, "manage_subject_teacher", "sub_teacher_id", "subject_id", "teacher_id");
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            export ex = new export();
            ex.excel(dgvsubject_teacher, "Subject_Teacher");
        }

    }
}
