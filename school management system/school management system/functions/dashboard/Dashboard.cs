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
    public partial class Dashboard : UserControl
    {
        int noofpicture;
        public Dashboard()
        {
            InitializeComponent();
        }

        void hide()
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            hide();
            pictureBox2.Show();
            noofpicture = 3;
        }

        private void next_Click(object sender, EventArgs e)
        {
            nextpicture();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            
            if (noofpicture == 1)
            {
                hide();
                bunifuTransition2.ShowSync(pictureBox2);
                noofpicture = 3;
            }

            else if (noofpicture == 2)
            {
                hide();
                bunifuTransition2.ShowSync(pictureBox1);
                noofpicture = 1;
            }
            else if (noofpicture == 3)
            {
                hide();
                bunifuTransition2.ShowSync(pictureBox3);
                noofpicture = 2;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //nextpicture();
        }

        void nextpicture()
        {
            if (noofpicture == 1)
            {
                hide();
                bunifuTransition2.ShowSync(pictureBox1);
                noofpicture = 2;
            }

            else if (noofpicture == 2)
            {
                hide();
                bunifuTransition2.ShowSync(pictureBox2);
                noofpicture = 3;
            }
            else if (noofpicture == 3)
            {
                hide();
                bunifuTransition2.ShowSync(pictureBox3);
                noofpicture = 1;
            }
        }
    }
}
