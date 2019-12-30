using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.functions
{
    public partial class Teacher : UserControl
    {
        id staff = new id();
        database db = new database();
        string check_id;

        public Teacher()
        {
            InitializeComponent();
        }

        public void clear()
        {
            name.Text = designation.Text = qualification.Text = address.Text = phone_no.Text = "";
            male.Checked = false;
            female.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(name.Text ==""|| designation.Text ==""|| qualification.Text ==""|| address.Text =="")
            {
                //MessageBox.Show("fill-up all data");
                message.show("Must fill all field", message.AlertType.info);
            }

            else if (phone_no.TextLength != 10)
            {
                message.show("Enter atleast 10 number\nin phone number field", message.AlertType.error);
            }

            else
            {
                    string staff_id = staff.creatid("staff_info", "staff_id", "Staff", 6);
                    db.InUpDel("INSERT INTO `staff_info`(`staff_id`, `designation`, `name`, `gender`, `address`, `phone`, `qualification`) VALUES ('" +
                    staff_id + "','" + designation.Text + "','" + name.Text + "','" + rediobutton() + "','" + address.Text + "','" + phone_no.Text + "','" + qualification.Text + "')");
                    message.show("Save Successfull", message.AlertType.success);
                clear();
                LoadDataGridView();
               
            }
            //MessageBox.Show(myid);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || designation.Text == "" || qualification.Text == "" || address.Text == "")
            {
                //MessageBox.Show("fill-up all data");
                message.show("Must fill all field", message.AlertType.info);
            }

            else if (phone_no.TextLength != 10)
            {
                message.show("Enter atleast 10 number\nin phone number field", message.AlertType.error);
            }

            else
            {
                db.InUpDel("UPDATE `staff_info` SET `designation`='" + designation.Text + "',`name`='" + name.Text + "',`address`='" + address.Text +
                    "',`phone`='" + phone_no.Text + "',`qualification`='" + qualification.Text + "' where staff_id='" + check_id + "'");
                message.show("Update Successfull", message.AlertType.success);
                update.Enabled = false;
                delete.Enabled = false;
                // btnSave.Enabled = true;
                LoadDataGridView();
                clear();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            db.InUpDel("DELETE FROM `staff_info` WHERE staff_id='" + check_id + "'");
            update.Enabled = false;
            delete.Enabled = false;
            LoadDataGridView();
            clear();
        }

        public void LoadDataGridView()
        {
            load_datagridview dgv = new load_datagridview();
            dgv.Loaddatagridview(dgvteacher, "staff_info", "staff_id", "designation",
                "name", "gender", "address", "phone", "qualification");
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string gender;

            try
            {
                check_id = dgvteacher.CurrentRow.Cells[1].Value.ToString();
                designation.Text = dgvteacher.CurrentRow.Cells[2].Value.ToString();
                name.Text = dgvteacher.CurrentRow.Cells[3].Value.ToString();
                gender = dgvteacher.CurrentRow.Cells[4].Value.ToString();
                address.Text = dgvteacher.CurrentRow.Cells[5].Value.ToString();
                qualification.Text = dgvteacher.CurrentRow.Cells[7].Value.ToString();
                phone_no.Text = dgvteacher.CurrentRow.Cells[6].Value.ToString();
                //btnSave.Text = "Update";
                if (gender == male.Text)
                {
                    male.Checked = true;
                }
                else if (gender == female.Text)
                {
                    female.Checked = true;
                }
                update.Enabled = true;
                delete.Enabled = true;
               // btnSave.Enabled = false;
            }
            catch
            {
                clear();
            }
        }

        // function to get gender from rediobutton
        string rediobutton()
        {
            string gender;

            if (male.Checked)
            {
                gender = male.Text;
            }
            else if (female.Checked)
            {
                gender = female.Text;
            }
            else
            {
                gender = "";
            }

            return gender;
        }


        private void Teacher_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            LoadDataGridView();
            delete.Enabled = false;
            update.Enabled = false;
            clear();
        }

        private void textonly_keypress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
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
            ex.excel(dgvteacher, "teacher_information");
        }

    }
}
