using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class school_bus : UserControl
    {
        public school_bus()
        {
            InitializeComponent();
        }

        database db = new database();
        string check_bus_no;

        public void clear()
        {
            route.Text = bus_no.Text = fee.Text = "";
        }

        private void school_bus_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            clear();
            loaddatagridview();
            delete.Enabled = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if( route.Text == "" || bus_no.Text =="" || fee.Text == "")
            {
                //MessageBox.Show("fill-up all field");
                message.show("Must fill all field", message.AlertType.info);
            }
            else
            {
                    db.InUpDel("INSERT INTO `bus_info`(`route`, `bus_number`, `route_fee`) VALUES ('" +
                        route.Text + "','" + bus_no.Text + "','" + fee.Text + "')");
                    message.show("Save Successfull", message.AlertType.success);
                clear();
                loaddatagridview();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            db.InUpDel("UPDATE `bus_info` SET `route`='" + route.Text + "',`bus_number`='" +
                        bus_no.Text + "',`route_fee`='" + fee.Text + "' WHERE bus_number='" + check_bus_no + "'");
            message.show("Update Successfull", message.AlertType.success);
            clear();
            loaddatagridview();
            delete.Enabled = false;
            update.Enabled = false;
        }

         private void delete_Click(object sender, EventArgs e)
        {
            db.InUpDel("DELETE FROM `bus_info` WHERE bus_number='" + check_bus_no + "'");
            message.show("Delete Successfull", message.AlertType.success);
            clear();
            loaddatagridview();
            delete.Enabled = false;
            update.Enabled = false;
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                bus_no.Text=check_bus_no = dgvbus.CurrentRow.Cells[2].Value.ToString();
                route.Text = dgvbus.CurrentRow.Cells[1].Value.ToString();
                fee.Text = dgvbus.CurrentRow.Cells[3].Value.ToString();
                update.Enabled = true;
                delete.Enabled = true;
                // btnSave.Enabled = false;
            }
            catch
            {
                clear();
            }
        }


        public void loaddatagridview()
        {
            load_datagridview dgv = new load_datagridview();
            dgv.Loaddatagridview(dgvbus, "bus_info", "route", "bus_number", "route_fee");
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
            ex.excel(dgvbus, "bus_information");
        }

      
    }
}
