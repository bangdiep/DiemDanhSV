namespace DiemDanhSV.PAL.Forms.AdminView
{
    partial class FormAddList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            list_data_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            btnSelect = new Guna.UI2.WinForms.Guna2Button();
            columnSubject = new DataGridViewTextBoxColumn();
            columnClsID = new DataGridViewTextBoxColumn();
            columnRoom = new DataGridViewTextBoxColumn();
            columnTerm = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)list_data_gridView).BeginInit();
            SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(7, 2);
            guna2HtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(255, 30);
            guna2HtmlLabel1.TabIndex = 15;
            guna2HtmlLabel1.Text = "ADD CLASS-STUDENT LIST";
            // 
            // list_data_gridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            list_data_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            list_data_gridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            list_data_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            list_data_gridView.ColumnHeadersHeight = 17;
            list_data_gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            list_data_gridView.Columns.AddRange(new DataGridViewColumn[] { columnSubject, columnClsID, columnRoom, columnTerm, Column1 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            list_data_gridView.DefaultCellStyle = dataGridViewCellStyle3;
            list_data_gridView.GridColor = Color.FromArgb(231, 229, 255);
            list_data_gridView.Location = new Point(7, 66);
            list_data_gridView.Margin = new Padding(3, 4, 3, 4);
            list_data_gridView.Name = "list_data_gridView";
            list_data_gridView.RowHeadersVisible = false;
            list_data_gridView.RowHeadersWidth = 51;
            list_data_gridView.RowTemplate.Height = 25;
            list_data_gridView.Size = new Size(731, 463);
            list_data_gridView.TabIndex = 14;
            list_data_gridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            list_data_gridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            list_data_gridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            list_data_gridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            list_data_gridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            list_data_gridView.ThemeStyle.BackColor = Color.White;
            list_data_gridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            list_data_gridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            list_data_gridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            list_data_gridView.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            list_data_gridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            list_data_gridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            list_data_gridView.ThemeStyle.HeaderStyle.Height = 17;
            list_data_gridView.ThemeStyle.ReadOnly = false;
            list_data_gridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            list_data_gridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            list_data_gridView.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            list_data_gridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            list_data_gridView.ThemeStyle.RowsStyle.Height = 25;
            list_data_gridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            list_data_gridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelect.BorderRadius = 10;
            btnSelect.CustomizableEdges = customizableEdges1;
            btnSelect.DisabledState.BorderColor = Color.DarkGray;
            btnSelect.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSelect.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSelect.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSelect.FillColor = Color.LightCoral;
            btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSelect.ForeColor = Color.Black;
            btnSelect.Location = new Point(599, 3);
            btnSelect.Margin = new Padding(3, 4, 3, 4);
            btnSelect.Name = "btnSelect";
            btnSelect.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSelect.Size = new Size(139, 40);
            btnSelect.TabIndex = 13;
            btnSelect.Text = "Select file Excel";
            btnSelect.Click += btnSelect_Click;
            // 
            // columnSubject
            // 
            columnSubject.HeaderText = "Subject";
            columnSubject.MinimumWidth = 6;
            columnSubject.Name = "columnSubject";
            // 
            // columnClsID
            // 
            columnClsID.HeaderText = "Class ID";
            columnClsID.MinimumWidth = 6;
            columnClsID.Name = "columnClsID";
            // 
            // columnRoom
            // 
            columnRoom.HeaderText = "Room";
            columnRoom.MinimumWidth = 6;
            columnRoom.Name = "columnRoom";
            // 
            // columnTerm
            // 
            columnTerm.HeaderText = "Term";
            columnTerm.MinimumWidth = 6;
            columnTerm.Name = "columnTerm";
            // 
            // Column1
            // 
            Column1.HeaderText = "Total Student";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // FormAddList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 530);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(list_data_gridView);
            Controls.Add(btnSelect);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddList";
            Text = "FormAddList";
            ((System.ComponentModel.ISupportInitialize)list_data_gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView list_data_gridView;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private DataGridViewTextBoxColumn columnSubject;
        private DataGridViewTextBoxColumn columnClsID;
        private DataGridViewTextBoxColumn columnRoom;
        private DataGridViewTextBoxColumn columnTerm;
        private DataGridViewTextBoxColumn Column1;
    }
}