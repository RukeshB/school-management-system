using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system.functions
{
    public partial class dashboard_main : UserControl
    {
        public dashboard_main()
        {
            InitializeComponent();
        }

       // static public bool slide;
        void hide()
        {
           // dashboard1.Hide();
            setting1.Hide();
        }

        public void normal_color()
        {
            setting.BackColor = Color.Transparent;
            about.BackColor = Color.Transparent;
        }

        private void dashboard_main_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            hide();
            dashboard1.Show();
           // slide = true;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
            setting1.Show();
            setting1.load();
           // slide = false;
           // setting.BackColor = Color.DodgerBlue;
        }

        private void about_Click(object sender, EventArgs e)
        {
            hide();
            normal_color();
           // about.BackColor = Color.DodgerBlue;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
