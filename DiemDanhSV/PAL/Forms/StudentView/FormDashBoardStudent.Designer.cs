namespace DiemDanhSV.PAL.Forms.StudentView
{
    partial class FormDashBoardStudent
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
            Subject_list_gridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ColumnSubject = new DataGridViewTextBoxColumn();
            ColumnClassID = new DataGridViewTextBoxColumn();
            ColumnShift = new DataGridViewTextBoxColumn();
            ColumnTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Subject_list_gridView).BeginInit();
            SuspendLayout();
            // 
            // Subject_list_gridView
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            Subject_list_gridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Subject_list_gridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            Subject_list_gridView.Columns.AddRange(new DataGridViewColumn[] { ColumnSubject, ColumnClassID, ColumnShift, ColumnTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Subject_list_gridView.DefaultCellStyle = dataGridViewCellStyle3;
            Subject_list_gridView.GridColor = Color.FromArgb(231, 229, 255);
            Subject_list_gridView.Location = new Point(1, 1);
            Subject_list_gridView.Margin = new Padding(3, 4, 3, 4);
            Subject_list_gridView.Name = "Subject_list_gridView";
            Subject_list_gridView.RowHeadersVisible = false;
            Subject_list_gridView.RowHeadersWidth = 51;
            Subject_list_gridView.RowTemplate.Height = 25;
            Subject_list_gridView.Size = new Size(749, 525);
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
            Subject_list_gridView.ThemeStyle.ReadOnly = false;
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
            ColumnSubject.HeaderText = "Class";
            ColumnSubject.MinimumWidth = 6;
            ColumnSubject.Name = "ColumnSubject";
            // 
            // ColumnClassID
            // 
            ColumnClassID.HeaderText = "Class Code";
            ColumnClassID.MinimumWidth = 6;
            ColumnClassID.Name = "ColumnClassID";
            // 
            // ColumnShift
            // 
            ColumnShift.HeaderText = "Shift";
            ColumnShift.MinimumWidth = 6;
            ColumnShift.Name = "ColumnShift";
            // 
            // ColumnTotal
            // 
            ColumnTotal.HeaderText = "Total Absent";
            ColumnTotal.MinimumWidth = 6;
            ColumnTotal.Name = "ColumnTotal";
            // 
            // DashBoardStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 528);
            Controls.Add(Subject_list_gridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoardStudent";
            Text = "DashBoardStudent";
            ((System.ComponentModel.ISupportInitialize)Subject_list_gridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Subject_list_gridView;
        private DataGridViewTextBoxColumn ColumnSubject;
        private DataGridViewTextBoxColumn ColumnClassID;
        private DataGridViewTextBoxColumn ColumnShift;
        private DataGridViewTextBoxColumn ColumnTotal;
    }
}