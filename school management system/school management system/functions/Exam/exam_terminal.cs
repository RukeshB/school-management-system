using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.functions.Exam
{
    public partial class exam_terminal : UserControl
    {

        public exam_terminal()
        {
            InitializeComponent();
        }

        database db = new database();
        string check_terminal_code;

        public void clear()
        {
            terminal_id.Text = terminal_name.Text = "";
        }

        private void exam_terminal_Load(object sender, EventArgs e)
        {
            //clear();
            //LoadDataGridView();
            load();
        }

        public void load()
        {
            clear();
            LoadDataGridView();
            update.Enabled = false;
            delete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (terminal_id.Text =="" ||terminal_name.Text == "")
            {
                //MessageBox.Show("one of the field is empty");
                message.show("Must fill all field", message.AlertType.info);
            }
            else
            {
                
                db.InUpDel("INSERT INTO `exam_terminals`(`terminal_id`, `terminal_name`) VALUES ('" +
                    terminal_id.Text + "','" + terminal_name.Text + "')");
                clear();
                message.show("Save Successfull", message.AlertType.success);
                LoadDataGridView();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            db.InUpDel("UPDATE `exam_terminals` SET `terminal_id`='" + terminal_id.Text + "',`terminal_name`='" +
                terminal_name.Text + "' WHERE terminal_id='" + check_terminal_code + "'");
            message.show("Update Successfull", message.AlertType.success);
            delete.Enabled = false;
            update.Enabled = false;
            LoadDataGridView();
            clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            db.InUpDel("DELETE FROM `exam_terminals` WHERE terminal_id='" + check_terminal_code + "'");
            message.show("Delete Successfull", message.AlertType.success);
            delete.Enabled = false;
            update.Enabled = false;
            LoadDataGridView();
            clear();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                terminal_id.Text= check_terminal_code = dgvterminal.CurrentRow.Cells[1].Value.ToString();
                terminal_name.Text = dgvterminal.CurrentRow.Cells[2].Value.ToString();
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
           
        public void LoadDataGridView()
        {
            load_datagridview dgv = new load_datagridview();
            dgv.Loaddatagridview(dgvterminal,"exam_terminals","terminal_id","terminal_name");
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
            ex.excel(dgvterminal, "Terminal_information");
        }

        
    }
}
