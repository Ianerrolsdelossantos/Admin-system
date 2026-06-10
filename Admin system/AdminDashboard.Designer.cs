namespace Admin_system
{
    partial class AdminDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            panel1 = new Panel();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            dashboardtab = new TabPage();
            Stafflogstab = new TabPage();
            Reporttab = new TabPage();
            Tenanttab = new TabPage();
            roomunittab = new TabPage();
            inboxtab = new TabPage();
            Settingtab = new TabPage();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            button9 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 49, 128);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 461);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 49, 128);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 100);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(dashboardtab);
            tabControl1.Controls.Add(Stafflogstab);
            tabControl1.Controls.Add(Reporttab);
            tabControl1.Controls.Add(Tenanttab);
            tabControl1.Controls.Add(roomunittab);
            tabControl1.Controls.Add(inboxtab);
            tabControl1.Controls.Add(Settingtab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(218, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(966, 461);
            tabControl1.TabIndex = 2;
            // 
            // dashboardtab
            // 
            dashboardtab.Location = new Point(4, 24);
            dashboardtab.Name = "dashboardtab";
            dashboardtab.Padding = new Padding(3);
            dashboardtab.Size = new Size(958, 433);
            dashboardtab.TabIndex = 0;
            dashboardtab.Text = "Dashboard";
            dashboardtab.UseVisualStyleBackColor = true;
            dashboardtab.Click += dashboardtab_Click;
            // 
            // Stafflogstab
            // 
            Stafflogstab.Location = new Point(4, 24);
            Stafflogstab.Name = "Stafflogstab";
            Stafflogstab.Padding = new Padding(3);
            Stafflogstab.Size = new Size(958, 433);
            Stafflogstab.TabIndex = 1;
            Stafflogstab.Text = "Staff logs";
            Stafflogstab.UseVisualStyleBackColor = true;
            // 
            // Reporttab
            // 
            Reporttab.Location = new Point(4, 24);
            Reporttab.Name = "Reporttab";
            Reporttab.Padding = new Padding(3);
            Reporttab.Size = new Size(958, 433);
            Reporttab.TabIndex = 2;
            Reporttab.Text = "Reports";
            Reporttab.UseVisualStyleBackColor = true;
            // 
            // Tenanttab
            // 
            Tenanttab.Location = new Point(4, 24);
            Tenanttab.Name = "Tenanttab";
            Tenanttab.Padding = new Padding(3);
            Tenanttab.Size = new Size(958, 433);
            Tenanttab.TabIndex = 3;
            Tenanttab.Text = "Tenant";
            Tenanttab.UseVisualStyleBackColor = true;
            // 
            // roomunittab
            // 
            roomunittab.Location = new Point(4, 24);
            roomunittab.Name = "roomunittab";
            roomunittab.Padding = new Padding(3);
            roomunittab.Size = new Size(958, 433);
            roomunittab.TabIndex = 4;
            roomunittab.Text = "Room/units";
            roomunittab.UseVisualStyleBackColor = true;
            // 
            // inboxtab
            // 
            inboxtab.Location = new Point(4, 24);
            inboxtab.Name = "inboxtab";
            inboxtab.Padding = new Padding(3);
            inboxtab.Size = new Size(958, 433);
            inboxtab.TabIndex = 5;
            inboxtab.Text = "Inbox";
            inboxtab.UseVisualStyleBackColor = true;
            // 
            // Settingtab
            // 
            Settingtab.Location = new Point(4, 24);
            Settingtab.Name = "Settingtab";
            Settingtab.Padding = new Padding(3);
            Settingtab.Size = new Size(958, 433);
            Settingtab.TabIndex = 6;
            Settingtab.Text = "Setting";
            Settingtab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Image = Properties.Resources.layout;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(218, 37);
            button1.TabIndex = 0;
            button1.Text = "DASHBOARD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(224, 224, 224);
            button2.Image = Properties.Resources.staff;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 37);
            button2.Name = "button2";
            button2.Size = new Size(218, 37);
            button2.TabIndex = 1;
            button2.Text = "Staff logs";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(224, 224, 224);
            button3.Image = Properties.Resources.transaction_history;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 74);
            button3.Name = "button3";
            button3.Size = new Size(218, 37);
            button3.TabIndex = 2;
            button3.Text = "Transaction log";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(224, 224, 224);
            button4.Image = Properties.Resources.risk_analysis;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 111);
            button4.Name = "button4";
            button4.Size = new Size(218, 37);
            button4.TabIndex = 3;
            button4.Text = "Reports";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(224, 224, 224);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 148);
            button5.Name = "button5";
            button5.Size = new Size(218, 37);
            button5.TabIndex = 4;
            button5.Text = "Tenant";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(224, 224, 224);
            button6.Image = Properties.Resources.bed__1_;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 185);
            button6.Name = "button6";
            button6.Size = new Size(218, 37);
            button6.TabIndex = 5;
            button6.Text = "Room/units";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Top;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.FromArgb(224, 224, 224);
            button7.Image = Properties.Resources.email;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 222);
            button7.Name = "button7";
            button7.Size = new Size(218, 37);
            button7.TabIndex = 6;
            button7.Text = "Inbox";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Bottom;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(224, 224, 224);
            button8.Image = Properties.Resources.exit;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 424);
            button8.Name = "button8";
            button8.Size = new Size(218, 37);
            button8.TabIndex = 7;
            button8.Text = "Log out";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._678582529_927105203621440_1824702887409386771_n;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Top;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.FromArgb(224, 224, 224);
            button9.Image = Properties.Resources.settings;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(0, 259);
            button9.Name = "button9";
            button9.Size = new Size(218, 37);
            button9.TabIndex = 8;
            button9.Text = "Settings";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 561);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage dashboardtab;
        private TabPage Stafflogstab;
        private TabPage Reporttab;
        private TabPage Tenanttab;
        private TabPage roomunittab;
        private TabPage inboxtab;
        private TabPage Settingtab;
        private Button button1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button9;
    }
}