namespace school_management_system.functions.libary
{
    partial class return_book
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
            this.Return = new System.Windows.Forms.Button();
            this.student_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateleable = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.std_id = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.ComboBox();
            this.bookCode = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.BackColor = System.Drawing.Color.Transparent;
            this.Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Return.Location = new System.Drawing.Point(333, 306);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(120, 32);
            this.Return.TabIndex = 71;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = false;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // student_name
            // 
            this.student_name.BackColor = System.Drawing.Color.White;
            this.student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.Location = new System.Drawing.Point(364, 135);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(157, 26);
            this.student_name.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(247, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 82;
            this.label5.Text = "Student Name :";
            // 
            // dateleable
            // 
            this.dateleable.AutoSize = true;
            this.dateleable.BackColor = System.Drawing.Color.Transparent;
            this.dateleable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateleable.ForeColor = System.Drawing.Color.White;
            this.dateleable.Location = new System.Drawing.Point(247, 236);
            this.dateleable.Name = "dateleable";
            this.dateleable.Size = new System.Drawing.Size(52, 20);
            this.dateleable.TabIndex = 81;
            this.dateleable.Text = "Date :";
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(363, 231);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(158, 26);
            this.date.TabIndex = 80;
            // 
            // std_id
            // 
            this.std_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.std_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.std_id.BackColor = System.Drawing.Color.White;
            this.std_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_id.FormattingEnabled = true;
            this.std_id.Location = new System.Drawing.Point(364, 101);
            this.std_id.Name = "std_id";
            this.std_id.Size = new System.Drawing.Size(157, 28);
            this.std_id.TabIndex = 79;
            this.std_id.SelectedValueChanged += new System.EventHandler(this.std_id_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(247, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Student ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Book Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Title :";
            // 
            // Class
            // 
            this.Class.BackColor = System.Drawing.Color.White;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.FormattingEnabled = true;
            this.Class.Location = new System.Drawing.Point(364, 67);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(158, 28);
            this.Class.TabIndex = 84;
            this.Class.SelectedValueChanged += new System.EventHandler(this.Class_SelectedValueChanged);
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // bookCode
            // 
            this.bookCode.BackColor = System.Drawing.Color.White;
            this.bookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCode.FormattingEnabled = true;
            this.bookCode.Location = new System.Drawing.Point(363, 167);
            this.bookCode.Name = "bookCode";
            this.bookCode.Size = new System.Drawing.Size(158, 28);
            this.bookCode.TabIndex = 85;
            this.bookCode.SelectedValueChanged += new System.EventHandler(this.bookCode_SelectedValueChanged);
            this.bookCode.Click += new System.EventHandler(this.bookCode_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(363, 201);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(157, 26);
            this.title.TabIndex = 86;
            // 
            // return_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.title);
            this.Controls.Add(this.bookCode);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateleable);
            this.Controls.Add(this.date);
            this.Controls.Add(this.std_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Return);
            this.Name = "return_book";
            this.Size = new System.Drawing.Size(769, 380);
            this.Load += new System.EventHandler(this.return_book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dateleable;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox std_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.ComboBox bookCode;
        private System.Windows.Forms.TextBox title;
    }
}
