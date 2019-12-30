using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.account
{
    public partial class fee_structure : UserControl
    {
        public fee_structure()
        {
            InitializeComponent();
        }

        database db = new database();

        void clear()
        {
            Class.Text = fee_id.Text = Description.Text = "";
            totalamt.Value = 0;
        }

        private void fee_structure_Load(object sender, EventArgs e)
        {
            clear();
            LoadDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Class.Text == "" || fee_id.Text == "" || Description.Text == "" || totalamt.Value == 0)
            {
                MessageBox.Show("fill-up all field");
            }
            else
            {
                db.InUpDel("INSERT INTO `account_fee_structure`(`class_id`, `fee_id`, `fee_description`, `amount`) VALUES('" +
                Class.Text + "','" + fee_id.Text + "','" + Description.Text + "','" + totalamt.Value + "')");
                clear();
                LoadDataGridView();
            }
        }

        private void Class_Click(object sender, EventArgs e)
        {
            db.LoadComboBox(Class, "SELECT * FROM manage_class", "class_id");
        }

        private void LoadDataGridView()
        {
            load_datagridview dgv = new load_datagridview();
            dgv.Loaddatagridview(dgvFee, "account_fee_structure","class_id","fee_id","fee_description","amount");
        }
    }
}
