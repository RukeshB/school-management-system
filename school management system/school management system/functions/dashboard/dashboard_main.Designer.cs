namespace school_management_system.functions
{
    partial class dashboard_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_main));
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.setting = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.dashboard1 = new school_management_system.functions.Dashboard();
            this.setting1 = new school_management_system.functions.dashboard.setting();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.setting);
            this.panel2.Controls.Add(this.about);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 86);
            this.panel2.TabIndex = 4;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.CausesValidation = false;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout.Location = new System.Drawing.Point(623, -1);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(131, 84);
            this.logout.TabIndex = 26;
            this.logout.Text = "Log Out";
            this.logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(40, 55);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(138, 20);
            this.bunifuCustomLabel2.TabIndex = 25;
            this.bunifuCustomLabel2.Text = "Secondary School";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(45, 10);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(134, 55);
            this.bunifuCustomLabel1.TabIndex = 24;
            this.bunifuCustomLabel1.Text = "KIST";
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.Transparent;
            this.setting.CausesValidation = false;
            this.setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting.ForeColor = System.Drawing.Color.White;
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.setting.Location = new System.Drawing.Point(341, 0);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(131, 84);
            this.setting.TabIndex = 6;
            this.setting.Text = "User Setting";
            this.setting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.setting.UseVisualStyleBackColor = false;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.CausesValidation = false;
            this.about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.ForeColor = System.Drawing.Color.White;
            this.about.Image = ((System.Drawing.Image)(resources.GetObject("about.Image")));
            this.about.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.about.Location = new System.Drawing.Point(482, 0);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(131, 84);
            this.about.TabIndex = 4;
            this.about.Text = "About Us";
            this.about.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.dashboard1.Location = new System.Drawing.Point(0, 92);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(769, 380);
            this.dashboard1.TabIndex = 5;
            // 
            // setting1
            // 
            this.setting1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.setting1.Location = new System.Drawing.Point(0, 92);
            this.setting1.Name = "setting1";
            this.setting1.Size = new System.Drawing.Size(769, 380);
            this.setting1.TabIndex = 8;
            // 
            // dashboard_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.setting1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.panel2);
            this.Name = "dashboard_main";
            this.Size = new System.Drawing.Size(769, 472);
            this.Load += new System.EventHandler(this.dashboard_main_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Button about;
        private Dashboard dashboard1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private dashboard.setting setting1;
        private System.Windows.Forms.Button logout;
    }
}
