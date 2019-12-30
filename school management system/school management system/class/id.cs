using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace school_management_system
{
    class id
    {
        static MySqlConnection conn = new MySqlConnection("server=localhost; database=school_database; userid=root;");
        MySqlCommand cmd = new MySqlCommand("", conn);

        /// <summary>
        /// generate unique id
        /// </summary>
        /// <param name="tablename">table name</param>
        /// <param name="colum">field name</param>
        /// <param name="character">character of id you want to include</param>
        ///  /// <param name="number">length of string + 1</param>
        /// <returns>unique id</returns>
        public string creatid(string tablename,string colum,string character,int number)
        {
            //string character = "kist";
            string myid = string.Empty;
            string newid = string.Empty;
            try
            {
                conn.Open();
                cmd = new MySqlCommand("select ifnull(max(cast(substring("+colum+"," +number+", length("+colum+")) as int)),0)+1 as newId from "+tablename, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        myid = reader.GetString("newid");
                    }
                }
                switch (myid.Length)
                {
                    case 1:
                        {
                            newid = character + "000" + myid;
                            break;
                        }
                    case 2:
                        {
                            newid = character + "00" + myid;
                            break;
                        }
                    case 3:
                        {
                            newid = character + "0" + myid;
                            break;
                        }
                    case 4:
                        {
                            newid = character + myid;
                            break;
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
            return newid;
        }
    }
}
