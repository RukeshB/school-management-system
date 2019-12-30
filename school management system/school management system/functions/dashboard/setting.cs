using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.functions.dashboard
{
    public partial class setting : UserControl
    {
        public setting()
        {
            InitializeComponent();
        }

        database db = new database();
        string check_pass;

        private void cancle_Click(object sender, EventArgs e)
        {    
            this.Hide();
        }

        public void clear()
        {
            user_name.Text = old_pass.Text = new_pass.Text = conform.Text = "";
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (check_pass == old_pass.Text)
            {
                if (new_pass.Text == conform.Text)
                {
                    db.InUpDel("UPDATE `login` SET `user_name`='" + user_name.Text + "',`pass`='" + new_pass.Text + "' WHERE account_type='" + account_type.Text + "'");
                    check_pass = new_pass.Text;
                    clear();
                }
                else
                {
                    message.show("password does not match", message.AlertType.error);
                }
            }
            else
            {
                message.show("old password \n does not match", message.AlertType.error);
            }
         }

        private void setting_Load(object sender, EventArgs e)
        {
            load();
        }
        
        public void load()
        {
            account_type.Text = login.account_type;
            check_pass = login.Password;
            clear();
        }
    }
}
