namespace DiemDanhSV.PAL.Forms
{
    partial class FormMainStudent
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            role = new Label();
            username = new Label();
            std_panel = new Panel();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.Control;
            guna2Panel1.Controls.Add(btnLogout);
            guna2Panel1.Controls.Add(btnDashboard);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Left;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(193, 600);
            guna2Panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom;
            btnLogout.CustomImages.Image = Properties.Resources.out_log_icon_218015;
            btnLogout.CustomImages.ImageAlign = HorizontalAlignment.Left;
            btnLogout.CustomizableEdges = customizableEdges1;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.Transparent;
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.ForeColor = Color.Black;
            btnLogout.HoverState.FillColor = Color.FromArgb(255, 128, 128);
            btnLogout.HoverState.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(14, 541);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogout.Size = new Size(153, 43);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log out";
            btnLogout.TextOffset = new Point(1, 0);
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.CustomImages.Image = Properties.Resources._1904661_building_dashboard_default_home_house_page_start_122511__1_;
            btnDashboard.CustomImages.ImageAlign = HorizontalAlignment.Left;
            btnDashboard.CustomizableEdges = customizableEdges3;
            btnDashboard.DisabledState.BorderColor = Color.DarkGray;
            btnDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashboard.FillColor = Color.Transparent;
            btnDashboard.Font = new Font("Segoe UI", 9F);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.HoverState.FillColor = Color.FromArgb(255, 128, 128);
            btnDashboard.HoverState.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(14, 152);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDashboard.Size = new Size(176, 43);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextOffset = new Point(1, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_dai_hoc_ton_duc_thang_dongphucvina_vn_;
            pictureBox1.Location = new Point(37, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.LightCoral;
            guna2Panel2.Controls.Add(pictureBox2);
            guna2Panel2.Controls.Add(panel1);
            guna2Panel2.CustomizableEdges = customizableEdges7;
            guna2Panel2.Dock = DockStyle.Top;
            guna2Panel2.Location = new Point(193, 0);
            guna2Panel2.Margin = new Padding(3, 4, 3, 4);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel2.Size = new Size(753, 67);
            guna2Panel2.TabIndex = 2;
            guna2Panel2.Paint += guna2Panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197;
            pictureBox2.Location = new Point(489, 9);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(role);
            panel1.Controls.Add(username);
            panel1.Location = new Point(339, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 59);
            panel1.TabIndex = 4;
            // 
            // role
            // 
            role.AutoSize = true;
            role.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            role.Location = new Point(203, 31);
            role.Name = "role";
            role.Size = new Size(37, 20);
            role.TabIndex = 2;
            role.Text = "Role";
            // 
            // username
            // 
            username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.Location = new Point(203, 7);
            username.Name = "username";
            username.Size = new Size(51, 20);
            username.TabIndex = 1;
            username.Text = "Name";
            // 
            // std_panel
            // 
            std_panel.Location = new Point(194, 72);
            std_panel.Name = "std_panel";
            std_panel.Size = new Size(752, 528);
            std_panel.TabIndex = 3;
            // 
            // FormMainStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(946, 600);
            Controls.Add(std_panel);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMainStudent";
            Text = "FormDashboardStudent";
            Load += FormDashboardStudent_Load;
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label role;
        private Label username;
        private Panel std_panel;
    }
}