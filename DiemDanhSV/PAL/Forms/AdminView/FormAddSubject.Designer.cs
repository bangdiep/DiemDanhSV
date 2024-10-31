namespace DiemDanhSV.PAL.Forms
{
    partial class FormAddSubject
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtBoxId = new Guna.UI2.WinForms.Guna2TextBox();
            txtBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            list_subject_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            columnSjID = new DataGridViewTextBoxColumn();
            columnSjName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)list_subject_gridView).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(8, 2);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(199, 34);
            guna2HtmlLabel1.TabIndex = 3;
            guna2HtmlLabel1.Text = "Add New Subject";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.Location = new Point(12, 44);
            guna2HtmlLabel2.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(105, 30);
            guna2HtmlLabel2.TabIndex = 4;
            guna2HtmlLabel2.Text = "Subject's ID";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.Location = new Point(12, 93);
            guna2HtmlLabel3.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(150, 29);
            guna2HtmlLabel3.TabIndex = 5;
            guna2HtmlLabel3.Text = "Subject's Name";
            // 
            // txtBoxId
            // 
            txtBoxId.CustomizableEdges = customizableEdges7;
            txtBoxId.DefaultText = "";
            txtBoxId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBoxId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBoxId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBoxId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBoxId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxId.Font = new Font("Segoe UI", 9F);
            txtBoxId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxId.Location = new Point(131, 43);
            txtBoxId.Margin = new Padding(3, 5, 3, 5);
            txtBoxId.Name = "txtBoxId";
            txtBoxId.PasswordChar = '\0';
            txtBoxId.PlaceholderText = "";
            txtBoxId.SelectedText = "";
            txtBoxId.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtBoxId.Size = new Size(156, 36);
            txtBoxId.TabIndex = 6;
            // 
            // txtBoxName
            // 
            txtBoxName.CustomizableEdges = customizableEdges9;
            txtBoxName.DefaultText = "";
            txtBoxName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBoxName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBoxName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBoxName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBoxName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxName.Font = new Font("Segoe UI", 9F);
            txtBoxName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBoxName.Location = new Point(179, 93);
            txtBoxName.Margin = new Padding(3, 5, 3, 5);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.PasswordChar = '\0';
            txtBoxName.PlaceholderText = "";
            txtBoxName.SelectedText = "";
            txtBoxName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtBoxName.Size = new Size(534, 36);
            txtBoxName.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 10;
            btnAdd.CustomizableEdges = customizableEdges11;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.LightCoral;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(639, 13);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAdd.Size = new Size(74, 43);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ADD";
            btnAdd.Click += btnAdd_Click;
            // 
            // list_subject_gridView
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            list_subject_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            list_subject_gridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            list_subject_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            list_subject_gridView.ColumnHeadersHeight = 17;
            list_subject_gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            list_subject_gridView.Columns.AddRange(new DataGridViewColumn[] { columnSjID, columnSjName });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            list_subject_gridView.DefaultCellStyle = dataGridViewCellStyle6;
            list_subject_gridView.GridColor = Color.FromArgb(231, 229, 255);
            list_subject_gridView.Location = new Point(12, 149);
            list_subject_gridView.Margin = new Padding(3, 4, 3, 4);
            list_subject_gridView.Name = "list_subject_gridView";
            list_subject_gridView.RowHeadersVisible = false;
            list_subject_gridView.RowHeadersWidth = 51;
            list_subject_gridView.RowTemplate.Height = 25;
            list_subject_gridView.Size = new Size(721, 374);
            list_subject_gridView.TabIndex = 9;
            list_subject_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            list_subject_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            list_subject_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            list_subject_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            list_subject_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            list_subject_gridView.ThemeStyle.BackColor = Color.White;
            list_subject_gridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            list_subject_gridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            list_subject_gridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            list_subject_gridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            list_subject_gridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            list_subject_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            list_subject_gridView.ThemeStyle.HeaderStyle.Height = 17;
            list_subject_gridView.ThemeStyle.ReadOnly = false;
            list_subject_gridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            list_subject_gridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            list_subject_gridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            list_subject_gridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            list_subject_gridView.ThemeStyle.RowsStyle.Height = 25;
            list_subject_gridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            list_subject_gridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // columnSjID
            // 
            columnSjID.HeaderText = "Subject's ID";
            columnSjID.MinimumWidth = 6;
            columnSjID.Name = "columnSjID";
            // 
            // columnSjName
            // 
            columnSjName.HeaderText = "Subject name";
            columnSjName.MinimumWidth = 6;
            columnSjName.Name = "columnSjName";
            // 
            // FormAddSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(745, 530);
            Controls.Add(list_subject_gridView);
            Controls.Add(btnAdd);
            Controls.Add(txtBoxName);
            Controls.Add(txtBoxId);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2HtmlLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddSubject";
            Text = "FormAddSubject";
            Load += FormAddSubject_Load;
            ((System.ComponentModel.ISupportInitialize)list_subject_gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxId;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxName;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView list_subject_gridView;
        private DataGridViewTextBoxColumn columnSjID;
        private DataGridViewTextBoxColumn columnSjName;
    }
}