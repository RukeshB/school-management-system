namespace school_management_system.functions.libary
{
    partial class libary_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(libary_main));
            this.panel2 = new System.Windows.Forms.Panel();
            this.return_book = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.issue_book = new System.Windows.Forms.Button();
            this.book_menu = new System.Windows.Forms.Button();
            this.member = new System.Windows.Forms.Button();
            this.issue1 = new school_management_system.functions.libary.issue();
            this.return_book1 = new school_management_system.functions.libary.return_book();
            this.member1 = new school_management_system.functions.libary.member();
            this.book_menu1 = new school_management_system.functions.libary.book_menu();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.return_book);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.issue_book);
            this.panel2.Controls.Add(this.book_menu);
            this.panel2.Controls.Add(this.member);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 86);
            this.panel2.TabIndex = 4;
            // 
            // return_book
            // 
            this.return_book.BackColor = System.Drawing.Color.Transparent;
            this.return_book.CausesValidation = false;
            this.return_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.return_book.FlatAppearance.BorderSize = 0;
            this.return_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.return_book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.return_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_book.ForeColor = System.Drawing.Color.White;
            this.return_book.Image = ((System.Drawing.Image)(resources.GetObject("return_book.Image")));
            this.return_book.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.return_book.Location = new System.Drawing.Point(608, 0);
            this.return_book.Name = "return_book";
            this.return_book.Size = new System.Drawing.Size(131, 84);
            this.return_book.TabIndex = 8;
            this.return_book.Text = "Return book";
            this.return_book.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.return_book.UseVisualStyleBackColor = false;
            this.return_book.Click += new System.EventHandler(this.return_book_Click);
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
            // issue_book
            // 
            this.issue_book.BackColor = System.Drawing.Color.Transparent;
            this.issue_book.CausesValidation = false;
            this.issue_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issue_book.FlatAppearance.BorderSize = 0;
            this.issue_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.issue_book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.issue_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_book.ForeColor = System.Drawing.Color.White;
            this.issue_book.Image = ((System.Drawing.Image)(resources.GetObject("issue_book.Image")));
            this.issue_book.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.issue_book.Location = new System.Drawing.Point(471, 0);
            this.issue_book.Name = "issue_book";
            this.issue_book.Size = new System.Drawing.Size(131, 84);
            this.issue_book.TabIndex = 6;
            this.issue_book.Text = "Issue book";
            this.issue_book.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.issue_book.UseVisualStyleBackColor = false;
            this.issue_book.Click += new System.EventHandler(this.issue_book_Click);
            // 
            // book_menu
            // 
            this.book_menu.BackColor = System.Drawing.Color.Transparent;
            this.book_menu.CausesValidation = false;
            this.book_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book_menu.FlatAppearance.BorderSize = 0;
            this.book_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.book_menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.book_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_menu.ForeColor = System.Drawing.Color.White;
            this.book_menu.Image = ((System.Drawing.Image)(resources.GetObject("book_menu.Image")));
            this.book_menu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.book_menu.Location = new System.Drawing.Point(334, 0);
            this.book_menu.Name = "book_menu";
            this.book_menu.Size = new System.Drawing.Size(131, 84);
            this.book_menu.TabIndex = 5;
            this.book_menu.Text = "Book Menu";
            this.book_menu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.book_menu.UseVisualStyleBackColor = false;
            this.book_menu.Click += new System.EventHandler(this.book_menu_Click);
            // 
            // member
            // 
            this.member.BackColor = System.Drawing.Color.Transparent;
            this.member.CausesValidation = false;
            this.member.Cursor = System.Windows.Forms.Cursors.Hand;
            this.member.FlatAppearance.BorderSize = 0;
            this.member.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.member.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.member.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member.ForeColor = System.Drawing.Color.White;
            this.member.Image = ((System.Drawing.Image)(resources.GetObject("member.Image")));
            this.member.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.member.Location = new System.Drawing.Point(197, 0);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(131, 84);
            this.member.TabIndex = 3;
            this.member.Text = "Member";
            this.member.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.member.UseVisualStyleBackColor = false;
            this.member.Click += new System.EventHandler(this.member_Click);
            // 
            // issue1
            // 
            this.issue1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.issue1.Location = new System.Drawing.Point(0, 91);
            this.issue1.Name = "issue1";
            this.issue1.Size = new System.Drawing.Size(769, 380);
            this.issue1.TabIndex = 8;
            // 
            // return_book1
            // 
            this.return_book1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.return_book1.Location = new System.Drawing.Point(0, 91);
            this.return_book1.Name = "return_book1";
            this.return_book1.Size = new System.Drawing.Size(769, 380);
            this.return_book1.TabIndex = 7;
            // 
            // member1
            // 
            this.member1.Location = new System.Drawing.Point(0, 84);
            this.member1.Name = "member1";
            this.member1.Size = new System.Drawing.Size(769, 388);
            this.member1.TabIndex = 6;
            // 
            // book_menu1
            // 
            this.book_menu1.Location = new System.Drawing.Point(0, 85);
            this.book_menu1.Name = "book_menu1";
            this.book_menu1.Size = new System.Drawing.Size(769, 388);
            this.book_menu1.TabIndex = 5;
            // 
            // libary_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.issue1);
            this.Controls.Add(this.return_book1);
            this.Controls.Add(this.member1);
            this.Controls.Add(this.book_menu1);
            this.Controls.Add(this.panel2);
            this.Name = "libary_main";
            this.Size = new System.Drawing.Size(769, 472);
            this.Load += new System.EventHandler(this.libary_main_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button issue_book;
        private System.Windows.Forms.Button book_menu;
        private System.Windows.Forms.Button member;
        private book_menu book_menu1;
        private member member1;
        private System.Windows.Forms.Button return_book;
        private return_book return_book1;
        private issue issue1;
    }
}
