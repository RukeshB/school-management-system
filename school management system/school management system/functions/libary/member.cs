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
    public partial class member : UserControl
    {
        public member()
        {
            InitializeComponent();
        }

        database db = new database();
        string check_member_id;

        public void clear()
        {
            Class.Text = student_Name.Text = student_id.Text = "";
        }
        private void member_Load(object sender, EventArgs e)
        {
            //clear();
            //datagrid();
            load();
        }

        public void load()
        {
            clear();
            datagrid();
            update.Enabled = false;
            delete.Enabled = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(Class.Text=="" || student_id.Text=="")
            {
               // MessageBox.Show("fill-up all field");
                message.show("Must fill all field", message.AlertType.info);
            }
            else 
            {
                id newid = new id();
                string memberid = newid.creatid("libary_member", "member_id", "libary", 7);
                db.InUpDel("INSERT INTO `libary_member`(`member_id`, `class`, `student_id`, `student_name`, `membership_date`) VALUES ('" +
                    memberid + "','" + Class.Text + "','" + student_id.Text + "','" + student_Name.Text + "','" + membershipDate.Text + "')");
                clear();
                message.show("Add Successfull", message.AlertType.success);
                datagrid();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            db.InUpDel("UPDATE `libary_member` SET `class`='"+Class.Text+"',`student_id`='"+student_id.Text+
                "',`student_name`='" + student_Name.Text + "',membership_date='"+membershipDate.Text+"' WHERE member_id='"+check_member_id+"'");
            message.show("Update Successfull", message.AlertType.success);
            delete.Enabled = false;
            update.Enabled = false;
            datagrid();
            clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            db.InUpDel("DELETE FROM `libary_member` WHERE member_id='" + check_member_id + "'");
            message.show("Delete Successfull", message.AlertType.success);
            delete.Enabled = false;
            update.Enabled = false;
            datagrid();
            clear();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                check_member_id = dgvmember.CurrentRow.Cells[1].Value.ToString();
                Class.Text = dgvmember.CurrentRow.Cells[2].Value.ToString();
                student_id.Text = dgvmember.CurrentRow.Cells[3].Value.ToString();
                student_Name.Text = dgvmember.CurrentRow.Cells[4].Value.ToString();
                membershipDate.Text = dgvmember.CurrentRow.Cells[5].Value.ToString();
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


        private void Class_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(Class, "SELECT * FROM manage_class", "class_id");
        }

        public void datagrid()
        {
            load_datagridview dgv = new load_datagridview();
            dgv.Loaddatagridview(dgvmember, "libary_member", "member_id", "class", "student_id", "student_name", "membership_date");
        }

        private void Class_SelectedValueChanged(object sender, EventArgs e)
        {
            db.LoadComboBox(student_id, "SELECT * FROM `student` WHERE class_id ='" + Class.Text + "'", "student_id");
        }

        private void student_id_SelectedValueChanged(object sender, EventArgs e)
        {
            db.LoadTextBox(student_Name, "SELECT * FROM `student` WHERE student_id ='" + student_id.Text + "'", "student_name");
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            export ex = new export();
            ex.excel(dgvmember, "Member_Information");
        }

        
        
    }
}
