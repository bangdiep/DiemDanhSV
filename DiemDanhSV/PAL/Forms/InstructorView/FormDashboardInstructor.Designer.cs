namespace DiemDanhSV.PAL.Forms
{
    partial class FormDashboardInstructor
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            comboboxTerm = new Guna.UI2.WinForms.Guna2ComboBox();
            role = new Label();
            username = new Label();
            Subject_list_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ColumnSubject = new DataGridViewTextBoxColumn();
            columnClassCode = new DataGridViewTextBoxColumn();
            columnType = new DataGridViewTextBoxColumn();
            columnTerm = new DataGridViewTextBoxColumn();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Subject_list_gridView).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.ControlLightLight;
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
            guna2Panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            pictureBox1.Location = new Point(37, -13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.LightCoral;
            guna2Panel2.Controls.Add(panel1);
            guna2Panel2.CustomizableEdges = customizableEdges9;
            guna2Panel2.Dock = DockStyle.Top;
            guna2Panel2.Location = new Point(193, 0);
            guna2Panel2.Margin = new Padding(3, 4, 3, 4);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel2.Size = new Size(721, 67);
            guna2Panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(comboboxTerm);
            panel1.Controls.Add(role);
            panel1.Controls.Add(username);
            panel1.Location = new Point(303, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 59);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197;
            pictureBox2.Location = new Point(143, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // comboboxTerm
            // 
            comboboxTerm.BackColor = Color.Transparent;
            comboboxTerm.CustomizableEdges = customizableEdges7;
            comboboxTerm.DrawMode = DrawMode.OwnerDrawFixed;
            comboboxTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxTerm.FillColor = Color.LightCoral;
            comboboxTerm.FocusedColor = Color.FromArgb(94, 148, 255);
            comboboxTerm.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboboxTerm.Font = new Font("Segoe UI", 10F);
            comboboxTerm.ForeColor = Color.FromArgb(68, 88, 112);
            comboboxTerm.ItemHeight = 30;
            comboboxTerm.Location = new Point(15, 7);
            comboboxTerm.Margin = new Padding(3, 4, 3, 4);
            comboboxTerm.Name = "comboboxTerm";
            comboboxTerm.ShadowDecoration.CustomizableEdges = customizableEdges8;
            comboboxTerm.Size = new Size(102, 36);
            comboboxTerm.TabIndex = 3;
            // 
            // role
            // 
            role.AutoSize = true;
            role.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            role.Location = new Point(215, 30);
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
            username.Location = new Point(214, 7);
            username.Name = "username";
            username.Size = new Size(51, 20);
            username.TabIndex = 1;
            username.Text = "Name";
            // 
            // Subject_list_gridView
            // 
            Subject_list_gridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            Subject_list_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Subject_list_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Subject_list_gridView.ColumnHeadersHeight = 17;
            Subject_list_gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Subject_list_gridView.Columns.AddRange(new DataGridViewColumn[] { ColumnSubject, columnClassCode, columnType, columnTerm });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Subject_list_gridView.DefaultCellStyle = dataGridViewCellStyle3;
            Subject_list_gridView.GridColor = Color.FromArgb(231, 229, 255);
            Subject_list_gridView.Location = new Point(200, 87);
            Subject_list_gridView.Margin = new Padding(3, 4, 3, 4);
            Subject_list_gridView.Name = "Subject_list_gridView";
            Subject_list_gridView.ReadOnly = true;
            Subject_list_gridView.RowHeadersVisible = false;
            Subject_list_gridView.RowHeadersWidth = 51;
            Subject_list_gridView.RowTemplate.Height = 25;
            Subject_list_gridView.Size = new Size(701, 497);
            Subject_list_gridView.TabIndex = 4;
            Subject_list_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Subject_list_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            Subject_list_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Subject_list_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Subject_list_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Subject_list_gridView.ThemeStyle.BackColor = Color.White;
            Subject_list_gridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            Subject_list_gridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            Subject_list_gridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Subject_list_gridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            Subject_list_gridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            Subject_list_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Subject_list_gridView.ThemeStyle.HeaderStyle.Height = 17;
            Subject_list_gridView.ThemeStyle.ReadOnly = true;
            Subject_list_gridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            Subject_list_gridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Subject_list_gridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            Subject_list_gridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Subject_list_gridView.ThemeStyle.RowsStyle.Height = 25;
            Subject_list_gridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Subject_list_gridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ColumnSubject
            // 
            ColumnSubject.HeaderText = "Subject";
            ColumnSubject.MinimumWidth = 6;
            ColumnSubject.Name = "ColumnSubject";
            ColumnSubject.ReadOnly = true;
            // 
            // columnClassCode
            // 
            columnClassCode.HeaderText = "Class";
            columnClassCode.MinimumWidth = 6;
            columnClassCode.Name = "columnClassCode";
            columnClassCode.ReadOnly = true;
            // 
            // columnType
            // 
            columnType.HeaderText = "Type Class";
            columnType.MinimumWidth = 6;
            columnType.Name = "columnType";
            columnType.ReadOnly = true;
            // 
            // columnTerm
            // 
            columnTerm.HeaderText = "Term";
            columnTerm.MinimumWidth = 6;
            columnTerm.Name = "columnTerm";
            columnTerm.ReadOnly = true;
            // 
            // FormDashboardInstructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(Subject_list_gridView);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDashboardInstructor";
            Text = "FormDashboardInstructor";
            Load += FormDashboardInstructor_Load;
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Subject_list_gridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView Subject_list_gridView;
        private DataGridViewTextBoxColumn ColumnSubject;
        private DataGridViewTextBoxColumn columnClassCode;
        private DataGridViewTextBoxColumn columnType;
        private DataGridViewTextBoxColumn columnTerm;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxTerm;
        private Label role;
        private Label username;
        private PictureBox pictureBox2;
    }
}