using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace school_management_system
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        static MySqlConnection conn= new MySqlConnection("server=localhost; database=school_database; userid=root;");
        MySqlCommand cmd = new MySqlCommand("", conn);

        public static string account_type,user_name,Password;

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM `login` WHERE user_name = @username AND pass = @password and account_type = @type", conn);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", pass.Text);
                cmd.Parameters.AddWithValue("@type", type.Text);
                 using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        account_type = type.Text;
                        user_name = username.Text;
                        Password = pass.Text;
                        main_form main = new main_form();
                        this.Hide();
                        main.ShowDialog();
                    }
                    else
                        message.show("Wrong Username\n or Password", message.AlertType.error);
                }
            }

            catch (MySqlException ex)
            {
                 MessageBox.Show(ex.Message);
                //message.show(ex.Message, message.AlertType.error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
           
        }

        private void exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideshow_OnChange(object sender, EventArgs e)
        {
            if (hideshow.Checked)
            {
               // label1.Text = "Hide";
                pass.isPassword = false;
            }

            else
            {
                pass.isPassword = true;
               // label1.Text = "Show";
            }
        }
    }
}
