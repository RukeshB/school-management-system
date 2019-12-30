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
    public partial class manage_class : UserControl
    {
        public manage_class()
        {
            InitializeComponent();
        }

        database db = new database();
        string check_class;

        public void clear()
        {
            class_id.Clear();
            class_name.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(class_id.Text=="" || class_name.Text=="")
            {
               // MessageBox.Show("one of the field is empty");
                message.show("Must fill all field", message.AlertType.info);
            }
            else
            {
                database db = new database();
                db.InUpDel("INSERT INTO `manage_class`(`class_id`, `class_name`) VALUES ('" + class_id.Text + "','" + class_name.Text + "')");
                clear();
                message.show("Save Successfull", message.AlertType.success);
                LoadDataGridView();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            db.InUpDel("UPDATE `manage_class` SET `class_id`='" + class_id.Text + "',`class_name`='" + class_name.Text +
                "' WHERE class_id='" + check_class + "'");
            clear();
            message.show("Update Successfull", message.AlertType.success);
            LoadDataGridView();
            update.Enabled = false;
            delete.Enabled = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            db.InUpDel("DELETE FROM `manage_class` WHERE class_id='" + check_class + "'");
            clear();
            message.show("Delete Successfull", message.AlertType.success);
            LoadDataGridView();
            update.Enabled = false;
            delete.Enabled = false;
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                class_id.Text=check_class = dgvclass.CurrentRow.Cells[1].Value.ToString();
                class_name.Text = dgvclass.CurrentRow.Cells[2].Value.ToString();
                //btnSave.Text = "Update";
                update.Enabled = true;
                delete.Enabled = true;
                // btnSave.Enabled = false;
            }
            catch
            {
                clear();
            }
        }

        private void manage_class_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            clear();
            LoadDataGridView();
            update.Enabled = false;
            delete.Enabled = false;
        }

        public void LoadDataGridView()
        {
            load_datagridview dgv = new load_datagridview();
            dgv.Loaddatagridview(dgvclass, "manage_class", "class_id", "class_name");
        }

        private void textonly_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            export ex = new export();
            ex.excel(dgvclass, "Class_information");
        }

       
    }
}
