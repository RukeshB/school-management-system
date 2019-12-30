using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.functions.Exam
{
    public partial class exam_main : UserControl
    {
        public exam_main()
        {
            InitializeComponent();
        }

        void hide()
        {
            exam_terminal1.Hide();
            marks_obtain1.Hide();
            result1.Hide();
        }

        public void normal_color()
        {
            terminal.BackColor = Color.Transparent;
            obtain_marks.BackColor = Color.Transparent;
            result.BackColor = Color.Transparent; 
        }
        private void exam_main_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            hide();
            marks_obtain1.Show();
            marks_obtain1.load();
            normal_color();
            obtain_marks.BackColor = Color.DodgerBlue;
        }

        private void terminal_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            exam_terminal1.Show();
           // exam_terminal1.clear();
            //exam_terminal1.LoadDataGridView();
            exam_terminal1.load();
            terminal.BackColor = Color.DodgerBlue;
        }

        private void obtain_marks_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            marks_obtain1.Show();
            //marks_obtain1.clear();
            //marks_obtain1.datagridclear();
            marks_obtain1.load();
            obtain_marks.BackColor = Color.DodgerBlue;
        }

        private void result_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            result1.Show();
            result1.load();
            result.BackColor = Color.DodgerBlue;
        }
 
    }
}
