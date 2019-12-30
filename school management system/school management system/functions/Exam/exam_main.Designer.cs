namespace school_management_system.functions.Exam
{
    partial class exam_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exam_main));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.Button();
            this.obtain_marks = new System.Windows.Forms.Button();
            this.terminal = new System.Windows.Forms.Button();
            this.exam_terminal1 = new school_management_system.functions.Exam.exam_terminal();
            this.marks_obtain1 = new school_management_system.functions.Exam.marks_obtain();
            this.result1 = new school_management_system.functions.Exam.result();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.result);
            this.panel2.Controls.Add(this.obtain_marks);
            this.panel2.Controls.Add(this.terminal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 86);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.CausesValidation = false;
            this.result.Cursor = System.Windows.Forms.Cursors.Hand;
            this.result.FlatAppearance.BorderSize = 0;
            this.result.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.result.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.White;
            this.result.Image = ((System.Drawing.Image)(resources.GetObject("result.Image")));
            this.result.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.result.Location = new System.Drawing.Point(534, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(131, 84);
            this.result.TabIndex = 6;
            this.result.Text = "Result";
            this.result.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // obtain_marks
            // 
            this.obtain_marks.BackColor = System.Drawing.Color.Transparent;
            this.obtain_marks.CausesValidation = false;
            this.obtain_marks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obtain_marks.FlatAppearance.BorderSize = 0;
            this.obtain_marks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.obtain_marks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.obtain_marks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obtain_marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obtain_marks.ForeColor = System.Drawing.Color.White;
            this.obtain_marks.Image = ((System.Drawing.Image)(resources.GetObject("obtain_marks.Image")));
            this.obtain_marks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.obtain_marks.Location = new System.Drawing.Point(397, 0);
            this.obtain_marks.Name = "obtain_marks";
            this.obtain_marks.Size = new System.Drawing.Size(131, 84);
            this.obtain_marks.TabIndex = 5;
            this.obtain_marks.Text = "Obtain Marks";
            this.obtain_marks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.obtain_marks.UseVisualStyleBackColor = false;
            this.obtain_marks.Click += new System.EventHandler(this.obtain_marks_Click);
            // 
            // terminal
            // 
            this.terminal.BackColor = System.Drawing.Color.Transparent;
            this.terminal.CausesValidation = false;
            this.terminal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.terminal.FlatAppearance.BorderSize = 0;
            this.terminal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.terminal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.terminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminal.ForeColor = System.Drawing.Color.White;
            this.terminal.Image = ((System.Drawing.Image)(resources.GetObject("terminal.Image")));
            this.terminal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.terminal.Location = new System.Drawing.Point(260, 0);
            this.terminal.Name = "terminal";
            this.terminal.Size = new System.Drawing.Size(131, 84);
            this.terminal.TabIndex = 3;
            this.terminal.Text = "Add  exam terminals";
            this.terminal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.terminal.UseVisualStyleBackColor = false;
            this.terminal.Click += new System.EventHandler(this.terminal_Click);
            // 
            // exam_terminal1
            // 
            this.exam_terminal1.Location = new System.Drawing.Point(0, 92);
            this.exam_terminal1.Name = "exam_terminal1";
            this.exam_terminal1.Size = new System.Drawing.Size(769, 380);
            this.exam_terminal1.TabIndex = 7;
            // 
            // marks_obtain1
            // 
            this.marks_obtain1.BackColor = System.Drawing.Color.Silver;
            this.marks_obtain1.Location = new System.Drawing.Point(0, 92);
            this.marks_obtain1.Name = "marks_obtain1";
            this.marks_obtain1.Size = new System.Drawing.Size(769, 380);
            this.marks_obtain1.TabIndex = 6;
            // 
            // result1
            // 
            this.result1.BackColor = System.Drawing.Color.Silver;
            this.result1.Location = new System.Drawing.Point(0, 92);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(769, 380);
            this.result1.TabIndex = 8;
            // 
            // exam_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.result1);
            this.Controls.Add(this.exam_terminal1);
            this.Controls.Add(this.marks_obtain1);
            this.Controls.Add(this.panel2);
            this.Name = "exam_main";
            this.Size = new System.Drawing.Size(769, 472);
            this.Load += new System.EventHandler(this.exam_main_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button obtain_marks;
        private System.Windows.Forms.Button terminal;
        private marks_obtain marks_obtain1;
        private exam_terminal exam_terminal1;
        private result result1;
    }
}
