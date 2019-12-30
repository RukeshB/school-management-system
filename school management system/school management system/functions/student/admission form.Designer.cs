namespace school_management_system.functions.student
{
    partial class admission_form
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.transport = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.admission_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.std_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.birth_place = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.phone_no = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.transport);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Class);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.admission_date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.std_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(62, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admission Details";
            // 
            // transport
            // 
            this.transport.BackColor = System.Drawing.Color.White;
            this.transport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transport.FormattingEnabled = true;
            this.transport.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.transport.Location = new System.Drawing.Point(488, 42);
            this.transport.Name = "transport";
            this.transport.Size = new System.Drawing.Size(146, 28);
            this.transport.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(363, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Transportaion :";
            // 
            // Class
            // 
            this.Class.BackColor = System.Drawing.Color.White;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.FormattingEnabled = true;
            this.Class.Location = new System.Drawing.Point(207, 42);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(150, 28);
            this.Class.TabIndex = 7;
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Class :";
            // 
            // admission_date
            // 
            this.admission_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admission_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.admission_date.Location = new System.Drawing.Point(488, 13);
            this.admission_date.Name = "admission_date";
            this.admission_date.Size = new System.Drawing.Size(146, 26);
            this.admission_date.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admission Date :";
            // 
            // std_id
            // 
            this.std_id.BackColor = System.Drawing.Color.White;
            this.std_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_id.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.std_id.Location = new System.Drawing.Point(207, 13);
            this.std_id.MaxLength = 10;
            this.std_id.Name = "std_id";
            this.std_id.ReadOnly = true;
            this.std_id.Size = new System.Drawing.Size(150, 26);
            this.std_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admission no.(Student ID) :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.female);
            this.groupBox2.Controls.Add(this.male);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.birth_place);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DOB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.fname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(62, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 108);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Details";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(277, 77);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(80, 24);
            this.female.TabIndex = 11;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(210, 77);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(61, 24);
            this.male.TabIndex = 10;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gender :";
            // 
            // birth_place
            // 
            this.birth_place.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.birth_place.BackColor = System.Drawing.Color.White;
            this.birth_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_place.Location = new System.Drawing.Point(488, 45);
            this.birth_place.MaxLength = 30;
            this.birth_place.Name = "birth_place";
            this.birth_place.Size = new System.Drawing.Size(146, 26);
            this.birth_place.TabIndex = 8;
            this.birth_place.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textonly_keypress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Birth Place :";
            // 
            // lname
            // 
            this.lname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.lname.BackColor = System.Drawing.Color.White;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(488, 13);
            this.lname.MaxLength = 20;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(146, 26);
            this.lname.TabIndex = 6;
            this.lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textonly_keypress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name :";
            // 
            // DOB
            // 
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(207, 45);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(150, 26);
            this.DOB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth :";
            // 
            // fname
            // 
            this.fname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.fname.BackColor = System.Drawing.Color.White;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(207, 13);
            this.fname.MaxLength = 20;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(150, 26);
            this.fname.TabIndex = 1;
            this.fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textonly_keypress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.phone_no);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.email);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.address);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.city);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(62, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(644, 87);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // phone_no
            // 
            this.phone_no.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.phone_no.BackColor = System.Drawing.Color.White;
            this.phone_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_no.Location = new System.Drawing.Point(207, 51);
            this.phone_no.MaxLength = 10;
            this.phone_no.Name = "phone_no";
            this.phone_no.Size = new System.Drawing.Size(150, 26);
            this.phone_no.TabIndex = 13;
            this.phone_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitonly_keypress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Phone No. :";
            // 
            // email
            // 
            this.email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.email.BackColor = System.Drawing.Color.White;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(488, 51);
            this.email.MaxLength = 25;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(146, 26);
            this.email.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(361, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = " E-Mail Address:";
            // 
            // address
            // 
            this.address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.address.BackColor = System.Drawing.Color.White;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(488, 13);
            this.address.MaxLength = 30;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(146, 26);
            this.address.TabIndex = 6;
            this.address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textonly_keypress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(361, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Adderss :";
            // 
            // city
            // 
            this.city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.city.BackColor = System.Drawing.Color.White;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(207, 13);
            this.city.MaxLength = 25;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(150, 26);
            this.city.TabIndex = 1;
            this.city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textonly_keypress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "City :";
            // 
            // cancel
            // 
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel.Location = new System.Drawing.Point(396, 325);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(120, 32);
            this.cancel.TabIndex = 33;
            this.cancel.Text = "Cancel ";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(258, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 32);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "submit";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // admission_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "admission_form";
            this.Size = new System.Drawing.Size(769, 380);
            this.Load += new System.EventHandler(this.admission_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker admission_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox std_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox birth_place;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox phone_no;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox transport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button btnSave;
    }
}
