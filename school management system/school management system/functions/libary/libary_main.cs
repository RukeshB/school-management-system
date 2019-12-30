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
    public partial class libary_main : UserControl
    {
        public libary_main()
        {
            InitializeComponent();
        }

        public void hide()
        {
            book_menu1.Hide();
            member1.Hide();
            issue1.Hide();
            return_book1.Hide();
        }

        public void normal_color()
        {
            book_menu.BackColor = Color.Transparent;
            issue_book.BackColor = Color.Transparent;
            return_book.BackColor = Color.Transparent;
            member.BackColor = Color.Transparent;
        }

        private void libary_main_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            hide();
            book_menu1.datagridview();
            book_menu1.Show();
            book_menu1.clear();
            normal_color();
            book_menu.BackColor = Color.DodgerBlue;
        }

        private void book_menu_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            book_menu1.datagridview();
            book_menu1.Show();
           // book_menu1.clear();
           // book_menu1.datagridview();
            book_menu1.load();
            book_menu.BackColor = Color.DodgerBlue;
        }

        private void member_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            member1.Show();
           // member1.clear();
            //member1.datagrid();
            member1.load();
            member.BackColor = Color.DodgerBlue;
        }
                
        private void issue_book_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            issue1.Show();
            issue1.clear();
            issue_book.BackColor = Color.DodgerBlue;
        }

        private void return_book_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            return_book1.Show();
            issue1.clear();
            return_book.BackColor = Color.DodgerBlue;
        }

    }
}
