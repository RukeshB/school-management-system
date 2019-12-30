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
    public partial class account_main : UserControl
    {
        public account_main()
        {
            InitializeComponent();
        }

        void hide()
        {
            bill1.Hide();
            fee_payment1.Hide();
            fee_structure1.Hide();
        }
        private void account_main_Load(object sender, EventArgs e)
        {
            hide();
        }

        private void bill_Click(object sender, EventArgs e)
        {
            hide();
            bill1.Show();
        }

        private void fee_payment_Click(object sender, EventArgs e)
        {
            hide();
            fee_payment1.Show();
        }

        private void fee_structure_Click(object sender, EventArgs e)
        {
            hide();
            fee_structure1.Show();
        }
 
    }
}
