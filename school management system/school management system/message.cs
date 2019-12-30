using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_management_system
{
    public partial class message : Form
    {
        public message(string messages, AlertType type)
        {
            InitializeComponent();
            label_message.Text = messages;
            switch(type)
            {
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    icon.Image = imageList1.Images[0];
                    break;
                case AlertType.info:
                    this.BackColor = Color.Gray;
                    icon.Image = imageList1.Images[1];
                    break;
                case AlertType.warning:
                    this.BackColor = Color.Crimson;
                    icon.Image = imageList1.Images[2];
                    break;
                case AlertType.error:
                    this.BackColor = Color.FromArgb(255,128,0);
                    icon.Image = imageList1.Images[3];
                    break;
            }
        }

        public  static void show(string messages, AlertType type)
        {
            new school_management_system.message(messages, type).Show();
           //message meg= new Custom_message_notification.message
        }

        public enum AlertType
        {
            success, info, warning,error
        }

        private void message_Load(object sender, EventArgs e)
        {
            this.Top = 20;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity>0)
            {
                this.Opacity-=0.01;
            }
            else
            {
                this.Close();
            }
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
