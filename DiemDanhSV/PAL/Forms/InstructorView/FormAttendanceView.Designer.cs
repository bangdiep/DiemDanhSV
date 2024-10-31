namespace DiemDanhSV.PAL.Forms.InstructorView
{
    partial class FormAttendanceView
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
            dataGridViewSubject = new Guna.UI2.WinForms.Guna2DataGridView();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnClass = new DataGridViewTextBoxColumn();
            ColumnShift = new DataGridViewTextBoxColumn();
            ColumnTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubject).BeginInit();
            SuspendLayout();
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
            dataGridViewSubject.Location = new Point(0, 1);
            dataGridViewSubject.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSubject.Name = "dataGridViewSubject";
            dataGridViewSubject.RowHeadersVisible = false;
            dataGridViewSubject.RowHeadersWidth = 51;
            dataGridViewSubject.RowTemplate.Height = 25;
            dataGridViewSubject.Size = new Size(799, 562);
            dataGridViewSubject.TabIndex = 8;
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
            // FormAttendanceView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(dataGridViewSubject);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAttendanceView";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewSubject;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnClass;
        private DataGridViewTextBoxColumn ColumnShift;
        private DataGridViewTextBoxColumn ColumnTotal;
    }
}