namespace DiemDanhSV.PAL.Forms
{
    partial class FormAttendanceStudent
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            labelSubject = new Guna.UI2.WinForms.Guna2HtmlLabel();
            comboboxTerm = new Guna.UI2.WinForms.Guna2ComboBox();
            role = new Label();
            label_fullname = new Label();
            pictureBox2 = new PictureBox();
            dataGridViewSubject = new Guna.UI2.WinForms.Guna2DataGridView();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnClass = new DataGridViewTextBoxColumn();
            ColumnShift = new DataGridViewTextBoxColumn();
            ColumnTotal = new DataGridViewTextBoxColumn();
            btnAttend = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubject).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            guna2Panel1.BackColor = SystemColors.ControlLightLight;
            guna2Panel1.BorderColor = Color.LightCoral;
            guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            guna2Panel1.Controls.Add(btnLogout);
            guna2Panel1.Controls.Add(btnDashboard);
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(193, 600);
            guna2Panel1.TabIndex = 2;
            // 
            // btnLogout
            // 
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
            guna2Panel2.Anchor = AnchorStyles.Left;
            guna2Panel2.BackColor = Color.LightCoral;
            guna2Panel2.Controls.Add(labelSubject);
            guna2Panel2.Controls.Add(comboboxTerm);
            guna2Panel2.Controls.Add(role);
            guna2Panel2.Controls.Add(label_fullname);
            guna2Panel2.Controls.Add(pictureBox2);
            guna2Panel2.CustomizableEdges = customizableEdges9;
            guna2Panel2.Location = new Point(193, 0);
            guna2Panel2.Margin = new Padding(3, 4, 3, 4);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel2.Size = new Size(721, 67);
            guna2Panel2.TabIndex = 3;
            // 
            // labelSubject
            // 
            labelSubject.BackColor = Color.Transparent;
            labelSubject.Font = new Font("Sitka Subheading", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelSubject.Location = new Point(38, 16);
            labelSubject.Margin = new Padding(3, 4, 3, 4);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(85, 31);
            labelSubject.TabIndex = 8;
            labelSubject.Text = "SUBJECT";
            labelSubject.Click += labelSubject_Click;
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
            comboboxTerm.Location = new Point(424, 12);
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
            role.Location = new Point(605, 43);
            role.Name = "role";
            role.Size = new Size(37, 20);
            role.TabIndex = 2;
            role.Text = "Role";
            // 
            // label_fullname
            // 
            label_fullname.AutoSize = true;
            label_fullname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_fullname.Location = new Point(605, 12);
            label_fullname.Name = "label_fullname";
            label_fullname.Size = new Size(51, 20);
            label_fullname.TabIndex = 1;
            label_fullname.Text = "Name";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197;
            pictureBox2.Location = new Point(547, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dataGridViewSubject
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSubject.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSubject.ColumnHeadersHeight = 17;
            dataGridViewSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewSubject.Columns.AddRange(new DataGridViewColumn[] { ColumnDate, ColumnClass, ColumnShift, ColumnTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewSubject.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSubject.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewSubject.Location = new Point(216, 91);
            dataGridViewSubject.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSubject.Name = "dataGridViewSubject";
            dataGridViewSubject.RowHeadersVisible = false;
            dataGridViewSubject.RowHeadersWidth = 51;
            dataGridViewSubject.RowTemplate.Height = 25;
            dataGridViewSubject.Size = new Size(685, 448);
            dataGridViewSubject.TabIndex = 7;
            dataGridViewSubject.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewSubject.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewSubject.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewSubject.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewSubject.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewSubject.ThemeStyle.BackColor = Color.White;
            dataGridViewSubject.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewSubject.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewSubject.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewSubject.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewSubject.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewSubject.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewSubject.ThemeStyle.HeaderStyle.Height = 17;
            dataGridViewSubject.ThemeStyle.ReadOnly = false;
            dataGridViewSubject.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewSubject.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewSubject.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewSubject.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewSubject.ThemeStyle.RowsStyle.Height = 25;
            dataGridViewSubject.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewSubject.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Date";
            ColumnDate.MinimumWidth = 6;
            ColumnDate.Name = "ColumnDate";
            // 
            // ColumnClass
            // 
            ColumnClass.HeaderText = "Class Room";
            ColumnClass.MinimumWidth = 6;
            ColumnClass.Name = "ColumnClass";
            // 
            // ColumnShift
            // 
            ColumnShift.HeaderText = "Shift";
            ColumnShift.MinimumWidth = 6;
            ColumnShift.Name = "ColumnShift";
            // 
            // ColumnTotal
            // 
            ColumnTotal.HeaderText = "Total";
            ColumnTotal.MinimumWidth = 6;
            ColumnTotal.Name = "ColumnTotal";
            // 
            // btnAttend
            // 
            btnAttend.BorderRadius = 10;
            btnAttend.CustomizableEdges = customizableEdges11;
            btnAttend.DisabledState.BorderColor = Color.DarkGray;
            btnAttend.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAttend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAttend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAttend.FillColor = Color.LightCoral;
            btnAttend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAttend.ForeColor = Color.Black;
            btnAttend.Location = new Point(779, 547);
            btnAttend.Margin = new Padding(3, 4, 3, 4);
            btnAttend.Name = "btnAttend";
            btnAttend.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAttend.Size = new Size(112, 43);
            btnAttend.TabIndex = 8;
            btnAttend.Text = "Attendance";
            // 
            // FormAttendanceStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(914, 600);
            Controls.Add(btnAttend);
            Controls.Add(dataGridViewSubject);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAttendanceStudent";
            Text = "FormAttendanceStudent";
            guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxTerm;
        private Label role;
        private Label label_fullname;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewSubject;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnClass;
        private DataGridViewTextBoxColumn ColumnShift;
        private DataGridViewTextBoxColumn ColumnTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelSubject;
        private Guna.UI2.WinForms.Guna2Button btnAttend;
    }
}