using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace school_management_system
{
    class load_datagridview
    {
        static MySqlConnection conn = new MySqlConnection("server=localhost; database=school_database; userid=root;");
        MySqlCommand cmd = new MySqlCommand("", conn);

        /// <summary>
        /// Load datagridview with 2 display member
        /// </summary>
        /// <param name="dgv">datagridview name</param>
        /// <param name="tableName">table name</param>
        /// <param name="displayMember1">fieldName you want to display</param>
        /// <param name="displayMember2">fieldName you want to display</param>
        public void Loaddatagridview(DataGridView dgv, string tableName, string displayMember1,
            string displayMember2)
        {
            int sn = 1;
            try
            {
                dgv.Rows.Clear();
                conn.Open();
                cmd = new MySqlCommand("SELECT * from " + tableName, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgv.Rows.Add(sn, reader.GetString(displayMember1), reader.GetString(displayMember2));
                        sn++;
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
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        /// <summary>
        /// load datagridview with 3 display member
        /// </summary>
        /// <param name="dgv">datagridview name</param>
        /// <param name="tableName">table name</param>
        /// <param name="displayMember1">fieldName you want to display</param>
        /// <param name="displayMember2">fieldName you want to display</param>
        /// <param name="displayMember3">fieldName you want to display</param>
        public void Loaddatagridview(DataGridView dgv, string tableName, string displayMember1,
           string displayMember2, string displayMember3)
        {
            int sn = 1;
            try
            {
                dgv.Rows.Clear();
                conn.Open();
                cmd = new MySqlCommand("SELECT * from " + tableName, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgv.Rows.Add(sn, reader.GetString(displayMember1), reader.GetString(displayMember2),
                            reader.GetString(displayMember3));
                        sn++;
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
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }


        /// <summary>
        /// Load datagridview with 4 display member
        /// </summary>
        /// <param name="dgv">datagridview name</param>
        /// <param name="tableName">table name</param>
        /// <param name="displayMember1">fieldName you want to display</param>
        /// <param name="displayMember2">fieldName you want to display</param>
        /// <param name="displayMember3">fieldName you want to display</param>
        /// <param name="displayMember4">fieldName you want to display</param>
        public void Loaddatagridview(DataGridView dgv, string tableName, string displayMember1,
            string displayMember2, string displayMember3, string displayMember4)
        {
            int sn = 1;
            try
            {
                dgv.Rows.Clear();
                conn.Open();
                cmd = new MySqlCommand("SELECT * from " + tableName, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgv.Rows.Add(sn, reader.GetString(displayMember1), reader.GetString(displayMember2),
                            reader.GetString(displayMember3), reader.GetString(displayMember4));
                        sn++;
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
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        //load datagridview with 5 display menber
        public void Loaddatagridview(DataGridView dgv, string tableName, string displayMember1,
            string displayMember2, string displayMember3, string displayMember4, string displayMember5)
        {
            int sn = 1;
            try
            {
                dgv.Rows.Clear();
                conn.Open();
                cmd = new MySqlCommand("SELECT * from " + tableName, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgv.Rows.Add(sn, reader.GetString(displayMember1), reader.GetString(displayMember2),
                            reader.GetString(displayMember3), reader.GetString(displayMember4), reader.GetString(displayMember5));
                        sn++;
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
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }


        // load datagrid view with 7 displaymember
        public void Loaddatagridview(DataGridView dgv, string tableName, string displayMember1,string displayMember2, 
            string displayMember3,string displayMember4,string displaymember5,string displaymember6,string displaymember7)
        {
            int sn = 1;
            try
            {
                dgv.Rows.Clear();
                conn.Open();
                cmd = new MySqlCommand("SELECT * from " + tableName, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgv.Rows.Add(sn, reader.GetString(displayMember1), reader.GetString(displayMember2),
                            reader.GetString(displayMember3), reader.GetString(displayMember4),
                            reader.GetString(displaymember5), reader.GetString(displaymember6), reader.GetString(displaymember7));
                        sn++;
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
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        // load datagrid view with 13 displaymember
        public void Loaddatagridview(DataGridView dgv, string tableName, string displayMember1, string displayMember2,
            string displayMember3, string displayMember4, string displaymember5, string displaymember6, string displaymember7,
            string displaymember8, string displaymember9, string displaymember10, string displaymember11, string displaymember12, 
            string displaymember13)
        {
            int sn = 1;
            try
            {
                dgv.Rows.Clear();
                conn.Open();
                cmd = new MySqlCommand("SELECT * from " + tableName, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dgv.Rows.Add(sn, reader.GetString(displayMember1), reader.GetString(displayMember2),
                            reader.GetString(displayMember3), reader.GetString(displayMember4),
                            reader.GetString(displaymember5), reader.GetString(displaymember6), reader.GetString(displaymember7)
                            , reader.GetString(displaymember8), reader.GetString(displaymember9), reader.GetString(displaymember10)
                            , reader.GetString(displaymember11), reader.GetString(displaymember12), reader.GetString(displaymember13));
                        sn++;
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
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}
