namespace school_management_system.functions.student
{
    partial class promot_student
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
            this.label1 = new System.Windows.Forms.Label();
            this.std_id = new System.Windows.Forms.ComboBox();
            this.from = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.std_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.promot = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID :";
            // 
            // std_id
            // 
            this.std_id.BackColor = System.Drawing.Color.White;
            this.std_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_id.FormattingEnabled = true;
            this.std_id.Location = new System.Drawing.Point(405, 132);
            this.std_id.Name = "std_id";
            this.std_id.Size = new System.Drawing.Size(137, 28);
            this.std_id.TabIndex = 1;
            this.std_id.SelectedValueChanged += new System.EventHandler(this.std_id_SelectedValueChanged);
            // 
            // from
            // 
            this.from.BackColor = System.Drawing.Color.White;
            this.from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.FormattingEnabled = true;
            this.from.Location = new System.Drawing.Point(405, 98);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(137, 28);
            this.from.TabIndex = 3;
            this.from.SelectedValueChanged += new System.EventHandler(this.from_SelectedValueChanged);
            this.from.Click += new System.EventHandler(this.from_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(226, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Promotion From Class :";
            // 
            // std_name
            // 
            this.std_name.BackColor = System.Drawing.Color.White;
            this.std_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_name.Location = new System.Drawing.Point(405, 166);
            this.std_name.Name = "std_name";
            this.std_name.ReadOnly = true;
            this.std_name.Size = new System.Drawing.Size(137, 26);
            this.std_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(226, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(226, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Promotion To Class :";
            // 
            // promot
            // 
            this.promot.BackColor = System.Drawing.Color.Transparent;
            this.promot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.promot.Location = new System.Drawing.Point(346, 250);
            this.promot.Name = "promot";
            this.promot.Size = new System.Drawing.Size(120, 32);
            this.promot.TabIndex = 43;
            this.promot.Text = "Promot";
            this.promot.UseVisualStyleBackColor = false;
            this.promot.Click += new System.EventHandler(this.promot_Click);
            // 
            // to
            // 
            this.to.BackColor = System.Drawing.Color.White;
            this.to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.FormattingEnabled = true;
            this.to.Location = new System.Drawing.Point(405, 198);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(137, 28);
            this.to.TabIndex = 44;
            // 
            // promot_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.to);
            this.Controls.Add(this.promot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.std_name);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.std_id);
            this.Controls.Add(this.label1);
            this.Name = "promot_student";
            this.Size = new System.Drawing.Size(769, 381);
            this.Load += new System.EventHandler(this.promot_student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox std_id;
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox std_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button promot;
        private System.Windows.Forms.ComboBox to;
    }
}
