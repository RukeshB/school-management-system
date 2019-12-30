using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace school_management_system.functions.student
{
    public partial class admission_form : UserControl
    {
        //static MySqlConnection conn = new MySqlConnection("server=localhost; database=school_database; userid=root;");
        //MySqlCommand cmd = new MySqlCommand("", conn);

        database db = new database();
        id student = new id();
        public static string button;
        bool valid;

        public admission_form()
        {
            InitializeComponent();
        }

        public void clear()
        {
            Class.Text = fname.Text = lname.Text = birth_place.Text = "";
            city.Text = address.Text = phone_no.Text = email.Text = transport.Text="";
            male.Checked = false;
            female.Checked = false;
        }
       
        public  void admission_form_Load(object sender, EventArgs e)
        {
            //std_id.Text = student.creatid("student_info", "student_id", "KIST", 5);
            ////if(button == "update")
            //btnSave.Text = button;
            load();
        }

        public void load()
        {
            std_id.Text = student.creatid("student_info", "student_id", "KIST", 5);
            btnSave.Text = button;

            if(btnSave.Text=="update")
            {
                std_id.Text = student_info.student_id;
                Class.Text = student_info.Class;
                fname.Text = student_info.first_name;
                lname.Text = student_info.last_name;
                DOB.Text = student_info.date_of_birth;
                admission_date.Text = student_info.admission_date;
                address.Text = student_info.address;
                birth_place.Text = student_info.birth_place;
                transport.Text = student_info.transport;
                phone_no.Text = student_info.phone;
                email.Text = student_info.Email;
                city.Text = student_info.city;
                if(student_info.gender == male.Text)
                {
                    //male.PerformClick();
                    male.Checked = true;
                    //female.Checked = false;
                }
                else if (student_info.gender == female.Text)
                {
                   // female.PerformClick();
                   // male.Checked = false;
                    female.Checked = true;
                }
            }
        }

        private void emailValidation()
        {
            var emailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            valid = Regex.IsMatch(email.Text, emailRegex);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            emailValidation();

            string gender = rediobutton();
            string name = fname.Text +" "+lname.Text;

            if (Class.Text == "" || fname.Text == "" || lname.Text == "" || phone_no.Text == "")
            {
                message.show("Full Name,Class,\nPhone No. must be fill", message.AlertType.info);
            }

            else if (phone_no.TextLength != 10)
            {
                message.show("Enter atleast 10 number\nin phone number field", message.AlertType.error);
            }

            else if (valid ==false)
            {
                MessageBox.Show("invalide email address");
            }

            else
            {
                if (btnSave.Text == "submit")
                {

                    //else
                    {
                        db.InUpDel("INSERT INTO `student_info`(`admission_date`, `student_id`, `class`, `first_name`, `last_name`, `gender`, `date_of_birth`, `birth_place`, `city`, `address`, `phone_no.`, `Email`) VALUES ('" + admission_date.Text
                        + "','" + std_id.Text + "','" + Class.Text + "','" + fname.Text + "','" + lname.Text + "','" + gender + "','" + DOB.Text + "','" + birth_place.Text + "','" + city.Text + "','" + address.Text + "','" + phone_no.Text + "','" + email.Text + "')");
                        db.InUpDel("INSERT INTO `student`(`student_id`, `class_id`, `student_name`) VALUES ('" +
                            std_id.Text + "','" + Class.Text + "','" + name + "')");
                        clear();
                        message.show("Submitted Successfull", message.AlertType.success);
                        std_id.Text = student.creatid("student_info", "student_id", "KIST", 5);
                    }
                }

                else if (btnSave.Text == "update")
                {
                    //else
                    {
                        db.InUpDel("UPDATE `student_info` SET `admission_date`='" + admission_date.Text + "',`student_id`='" + std_id.Text +
                            "',`class`='" + Class.Text + "',`first_name`='" + fname.Text + "',`last_name`='" + lname.Text + "',`gender`='" + gender + "',`date_of_birth`='" +
                        DOB.Text + "',`birth_place`='" + birth_place.Text + "',`city`='" + city.Text + "',`address`='" + address.Text + "',`transport`='" + transport.Text +
                        "',`phone_no.`='" + phone_no.Text + "',`Email`='" + email.Text + "' WHERE student_id='" + std_id.Text + "'");

                        db.InUpDel("UPDATE `student` SET `student_id`='" + std_id.Text + "',`class_id`='" + Class.Text +
                            "',`student_name`='" + name + "'  WHERE student_id='" + std_id.Text + "'");

                        //student_info;
                        message.show("Update Successfull", message.AlertType.success);
                        button = "submit";
                        btnSave.Text = button;
                        this.Hide();
                    }
                }
            }
        }


        private void cancel_Click(object sender, EventArgs e)
        {
             if (btnSave.Text == "submit")
             {
                 clear();
             }
             else  if (btnSave.Text == "update")
             {
                 this.Hide();
             }
        }

        // function to get gender from rediobutton
        string rediobutton()
       {
            string gender;

            if(male.Checked)
            {
                gender = male.Text;
            }
            else if(female.Checked)
            {
                gender= female.Text;
            }
            else
            {
               gender="";
            }

            return gender;
       }

        private void Class_Click(object sender, EventArgs e)
        {
            database db = new database();
            db.LoadComboBox(Class, "SELECT * FROM `manage_class`", "class_id");
        }

        private void textonly_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void digitonly_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
