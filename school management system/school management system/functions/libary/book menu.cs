using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.functions.libary
{
    public partial class book_menu : UserControl
    {
        public book_menu()
        {
            InitializeComponent();
        }

        id book = new id();
        database db = new database();
        string check_book_code;

        public void clear()
        {
            title.Text = author.Text = "";
            TotalBooks.Value = 0;
        }

        private void book_menu_Load(object sender, EventArgs e)
        {
           // clear();
           // datagridview();
            //code.Text=book.creatid("libary_book_menu", "book_code", "BOOK", 5);
            load();
        }

        public void load()
        {
            clear();
            datagridview();
            code.Text = book.creatid("libary_book_menu", "book_code", "BOOK", 5);
            update.Enabled = false;
            delete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (code.Text == "" || title.Text == "" || author.Text == "" || TotalBooks.Value == 0)
            {
                //MessageBox.Show("fill up all field");
                message.show("Must fill all field", message.AlertType.info);
            }
            else
            {
                
                db.InUpDel("INSERT INTO `libary_book_menu`(`book_code`, `title`, `author`, `number_of_book`) VALUES ('" +
                    code.Text + "','" + title.Text + "','" + author.Text + "','" + TotalBooks.Value + "')");
                clear();
                message.show("Add Successfull", message.AlertType.success);
                datagridview();
                code.Text = book.creatid("libary_book_menu", "book_code", "BOOK", 5);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            db.InUpDel("UPDATE `libary_book_menu` SET `book_code`='" + code.Text + "',`title`='" +title.Text +
                "', `author`='"+author.Text+ "',`number_of_book`='" + TotalBooks.Text + "' WHERE book_code='" + check_book_code + "'");
            code.Text = book.creatid("libary_book_menu", "book_code", "BOOK", 5);
            message.show("Update Successfull", message.AlertType.success);
            delete.Enabled = false;
            update.Enabled = false;
            datagridview();
            clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            db.InUpDel("DELETE FROM `libary_book_menu` WHERE book_code='" + check_book_code + "'");
            code.Text = book.creatid("libary_book_menu", "book_code", "BOOK", 5);
            message.show("Delete Successfull", message.AlertType.success);
            delete.Enabled = false;
            update.Enabled = false;
            datagridview();
            clear();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                code.Text = check_book_code = dgvbook.CurrentRow.Cells[1].Value.ToString();
                title.Text = dgvbook.CurrentRow.Cells[2].Value.ToString();
                author.Text = dgvbook.CurrentRow.Cells[3].Value.ToString();
                TotalBooks.Text = dgvbook.CurrentRow.Cells[4].Value.ToString();
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
             
        public void datagridview()
        {
            load_datagridview dgv = new load_datagridview();
            dgv.Loaddatagridview(dgvbook, "libary_book_menu", "book_code", "title", "author", "number_of_book");
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
            ex.excel(dgvbook, "Book_information");
        }

       
    }
}