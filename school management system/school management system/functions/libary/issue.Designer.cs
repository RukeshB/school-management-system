namespace school_management_system.functions.libary
{
    partial class issue
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
            this.dateleable = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.std_id = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.issue_book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.bookCode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateleable
            // 
            this.dateleable.AutoSize = true;
            this.dateleable.BackColor = System.Drawing.Color.Transparent;
            this.dateleable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateleable.ForeColor = System.Drawing.Color.White;
            this.dateleable.Location = new System.Drawing.Point(247, 234);
            this.dateleable.Name = "dateleable";
            this.dateleable.Size = new System.Drawing.Size(52, 20);
            this.dateleable.TabIndex = 59;
            this.dateleable.Text = "Date :";
            // 
            // date
            // 
            this.date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(363, 229);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(158, 26);
            this.date.TabIndex = 58;
            // 
            // std_id
            // 
            this.std_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.std_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.std_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_id.FormattingEnabled = true;
            this.std_id.Location = new System.Drawing.Point(364, 99);
            this.std_id.Name = "std_id";
            this.std_id.Size = new System.Drawing.Size(157, 28);
            this.std_id.TabIndex = 57;
            this.std_id.SelectedValueChanged += new System.EventHandler(this.std_id_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(247, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Student ID :";
            // 
            // issue_book
            // 
            this.issue_book.BackColor = System.Drawing.Color.Transparent;
            this.issue_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_book.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.issue_book.Location = new System.Drawing.Point(333, 306);
            this.issue_book.Name = "issue_book";
            this.issue_book.Size = new System.Drawing.Size(120, 32);
            this.issue_book.TabIndex = 53;
            this.issue_book.Text = "Issue";
            this.issue_book.UseVisualStyleBackColor = false;
            this.issue_book.Click += new System.EventHandler(this.issue_book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Book Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Title :";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(364, 198);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(157, 26);
            this.title.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(247, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Student Name :";
            // 
            // student_name
            // 
            this.student_name.BackColor = System.Drawing.Color.White;
            this.student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.Location = new System.Drawing.Point(364, 133);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(157, 26);
            this.student_name.TabIndex = 61;
            // 
            // Class
            // 
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.FormattingEnabled = true;
            this.Class.Location = new System.Drawing.Point(363, 65);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(158, 28);
            this.Class.TabIndex = 62;
            this.Class.SelectedValueChanged += new System.EventHandler(this.Class_SelectedValueChanged);
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // bookCode
            // 
            this.bookCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCode.FormattingEnabled = true;
            this.bookCode.Location = new System.Drawing.Point(364, 165);
            this.bookCode.Name = "bookCode";
            this.bookCode.Size = new System.Drawing.Size(158, 28);
            this.bookCode.TabIndex = 63;
            this.bookCode.SelectedValueChanged += new System.EventHandler(this.bookCode_SelectedValueChanged);
            this.bookCode.Click += new System.EventHandler(this.bookCode_Click);
            // 
            // issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.bookCode);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateleable);
            this.Controls.Add(this.date);
            this.Controls.Add(this.std_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.issue_book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Name = "issue";
            this.Size = new System.Drawing.Size(769, 380);
            this.Load += new System.EventHandler(this.issue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateleable;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox std_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button issue_book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.ComboBox bookCode;
    }
}
