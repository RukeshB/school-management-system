namespace school_management_system.functions.Exam
{
    partial class result
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.terminal_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.terminal_id = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.ComboBox();
            this.btnresult = new System.Windows.Forms.Button();
            this.Class = new System.Windows.Forms.ComboBox();
            this.student_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvresult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.name_lable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.class_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.terminal_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.terminal_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.terminal_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.student_id);
            this.panel1.Controls.Add(this.btnresult);
            this.panel1.Controls.Add(this.Class);
            this.panel1.Controls.Add(this.student_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 380);
            this.panel1.TabIndex = 21;
            // 
            // terminal_name
            // 
            this.terminal_name.BackColor = System.Drawing.Color.White;
            this.terminal_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminal_name.Location = new System.Drawing.Point(11, 233);
            this.terminal_name.Name = "terminal_name";
            this.terminal_name.ReadOnly = true;
            this.terminal_name.Size = new System.Drawing.Size(161, 26);
            this.terminal_name.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Terminal Name :";
            // 
            // terminal_id
            // 
            this.terminal_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminal_id.FormattingEnabled = true;
            this.terminal_id.Location = new System.Drawing.Point(11, 183);
            this.terminal_id.MaxDropDownItems = 100;
            this.terminal_id.Name = "terminal_id";
            this.terminal_id.Size = new System.Drawing.Size(161, 28);
            this.terminal_id.TabIndex = 36;
            this.terminal_id.SelectedValueChanged += new System.EventHandler(this.terminal_id_SelectedValueChanged);
            this.terminal_id.Click += new System.EventHandler(this.terminal_id_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Terminal ID :";
            // 
            // student_id
            // 
            this.student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id.FormattingEnabled = true;
            this.student_id.Location = new System.Drawing.Point(11, 85);
            this.student_id.MaxDropDownItems = 100;
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(161, 28);
            this.student_id.TabIndex = 34;
            this.student_id.SelectedValueChanged += new System.EventHandler(this.student_id_SelectedValueChanged);
            // 
            // btnresult
            // 
            this.btnresult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnresult.Location = new System.Drawing.Point(35, 315);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(120, 32);
            this.btnresult.TabIndex = 31;
            this.btnresult.Text = "Show";
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // Class
            // 
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.FormattingEnabled = true;
            this.Class.Location = new System.Drawing.Point(11, 35);
            this.Class.MaxDropDownItems = 100;
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(161, 28);
            this.Class.TabIndex = 16;
            this.Class.SelectedValueChanged += new System.EventHandler(this.Class_SelectedValueChanged);
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // student_name
            // 
            this.student_name.BackColor = System.Drawing.Color.White;
            this.student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.Location = new System.Drawing.Point(11, 135);
            this.student_name.Name = "student_name";
            this.student_name.ReadOnly = true;
            this.student_name.Size = new System.Drawing.Size(161, 26);
            this.student_name.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Student Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Class :";
            // 
            // dgvresult
            // 
            this.dgvresult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvresult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column5,
            this.Column4});
            this.dgvresult.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvresult.Location = new System.Drawing.Point(179, 114);
            this.dgvresult.Name = "dgvresult";
            this.dgvresult.ReadOnly = true;
            this.dgvresult.Size = new System.Drawing.Size(591, 266);
            this.dgvresult.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "S.N";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Subject ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 85;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Subject Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Full Marks";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Pass Marks";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Obtain Marks";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Student ID:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(450, 54);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(21, 20);
            this.id_label.TabIndex = 24;
            this.id_label.Text = "id";
            this.id_label.Visible = false;
            // 
            // name_lable
            // 
            this.name_lable.AutoSize = true;
            this.name_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lable.Location = new System.Drawing.Point(308, 85);
            this.name_lable.Name = "name_lable";
            this.name_lable.Size = new System.Drawing.Size(51, 20);
            this.name_lable.TabIndex = 26;
            this.name_lable.Text = "label7";
            this.name_lable.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(186, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Student Name:";
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_label.Location = new System.Drawing.Point(244, 54);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(45, 20);
            this.class_label.TabIndex = 28;
            this.class_label.Text = "class";
            this.class_label.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(186, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Class:";
            // 
            // terminal_label
            // 
            this.terminal_label.AutoSize = true;
            this.terminal_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminal_label.Location = new System.Drawing.Point(410, 14);
            this.terminal_label.Name = "terminal_label";
            this.terminal_label.Size = new System.Drawing.Size(65, 20);
            this.terminal_label.TabIndex = 29;
            this.terminal_label.Text = "terminal";
            this.terminal_label.Visible = false;
            // 
            // result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.terminal_label);
            this.Controls.Add(this.class_label);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.name_lable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvresult);
            this.Controls.Add(this.panel1);
            this.Name = "result";
            this.Size = new System.Drawing.Size(769, 380);
            this.Load += new System.EventHandler(this.result_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox terminal_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox terminal_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox student_id;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvresult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label name_lable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label class_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label terminal_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
