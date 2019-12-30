using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace school_management_system
{
    class database
    {
        static MySqlConnection conn = new MySqlConnection("server=localhost; database=school_database; userid=root;");
        MySqlCommand cmd = new MySqlCommand("", conn);

        /// <summary>
        /// Executes an Insert, Update and Delete Query
        /// </summary>
        /// <param name="myQuery">Write the Insert, Update or Delete query</param>
        public void InUpDel(string myQuery)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(myQuery, conn);
                cmd.ExecuteNonQuery();
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



        /// <summary>
        /// Load ComboBox
        /// </summary>
        /// <param name="c">ComboBox Name</param>
        /// <param name="Query">Select query</param>
        /// <param name="displayMember">fieldName you want to display</param>
        public void LoadComboBox(ComboBox c, string Query, string displayMember)
        {
            c.Items.Clear();
            try
            {
                conn.Open();
                cmd = new MySqlCommand(Query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        c.Items.Add(reader.GetString(displayMember));
                    }
                }
            }
            catch (MySqlException ex)
            {
               // MessageBox.Show(ex.Message);
                message.show(ex.Message, message.AlertType.error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }


        /// <summary>
        /// Load TextBox
        /// </summary>
        /// <param name="t">TextBox Name</param>
        /// <param name="Query">Select query</param>
        /// <param name="displayMember">fieldName you want to display</param>
        public void LoadTextBox(TextBox t, string Query, string displayMember)
        {
            t.Clear();
            try
            {
                conn.Open();
                cmd = new MySqlCommand(Query, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        t.Text = (reader.GetString(displayMember));
                    }
                }
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
                message.show(ex.Message, message.AlertType.error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open) 
                    conn.Close();
            }
        }
    }
}
