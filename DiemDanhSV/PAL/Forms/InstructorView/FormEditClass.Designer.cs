namespace DiemDanhSV.PAL.Forms.InstructorView
{
    partial class FormEditClass
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
            lb_subjectName = new Label();
            text_subjectName = new TextBox();
            text_classCode = new TextBox();
            lb_classCode = new Label();
            text_term = new TextBox();
            label2 = new Label();
            text_linkGGForm = new TextBox();
            lb_linkGGForm = new Label();
            btn_save = new Button();
            btn_showQR = new Button();
            panel1 = new Panel();
            btn_cancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_subjectName
            // 
            lb_subjectName.Anchor = AnchorStyles.None;
            lb_subjectName.AutoSize = true;
            lb_subjectName.BackColor = Color.White;
            lb_subjectName.Font = new Font("Poppins", 10F);
            lb_subjectName.Location = new Point(91, 147);
            lb_subjectName.Name = "lb_subjectName";
            lb_subjectName.Size = new Size(137, 30);
            lb_subjectName.TabIndex = 0;
            lb_subjectName.Text = "Subject Name:";
            // 
            // text_subjectName
            // 
            text_subjectName.Anchor = AnchorStyles.None;
            text_subjectName.BackColor = Color.White;
            text_subjectName.BorderStyle = BorderStyle.FixedSingle;
            text_subjectName.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_subjectName.ForeColor = SystemColors.WindowFrame;
            text_subjectName.Location = new Point(246, 147);
            text_subjectName.Name = "text_subjectName";
            text_subjectName.ReadOnly = true;
            text_subjectName.Size = new Size(460, 30);
            text_subjectName.TabIndex = 1;
            // 
            // text_classCode
            // 
            text_classCode.Anchor = AnchorStyles.None;
            text_classCode.BackColor = Color.White;
            text_classCode.BorderStyle = BorderStyle.FixedSingle;
            text_classCode.Font = new Font("Poppins", 9F);
            text_classCode.ForeColor = SystemColors.ScrollBar;
            text_classCode.Location = new Point(246, 186);
            text_classCode.Name = "text_classCode";
            text_classCode.ReadOnly = true;
            text_classCode.Size = new Size(176, 30);
            text_classCode.TabIndex = 3;
            // 
            // lb_classCode
            // 
            lb_classCode.Anchor = AnchorStyles.None;
            lb_classCode.AutoSize = true;
            lb_classCode.BackColor = Color.White;
            lb_classCode.Font = new Font("Poppins", 10F);
            lb_classCode.Location = new Point(144, 186);
            lb_classCode.Name = "lb_classCode";
            lb_classCode.Size = new Size(84, 30);
            lb_classCode.TabIndex = 2;
            lb_classCode.Text = "Class ID:";
            // 
            // text_term
            // 
            text_term.Anchor = AnchorStyles.None;
            text_term.BackColor = Color.White;
            text_term.BorderStyle = BorderStyle.FixedSingle;
            text_term.Font = new Font("Poppins", 9F);
            text_term.ForeColor = SystemColors.WindowFrame;
            text_term.Location = new Point(495, 186);
            text_term.Name = "text_term";
            text_term.ReadOnly = true;
            text_term.Size = new Size(211, 30);
            text_term.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Poppins", 10F);
            label2.Location = new Point(428, 185);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 4;
            label2.Text = "Term:";
            // 
            // text_linkGGForm
            // 
            text_linkGGForm.Anchor = AnchorStyles.None;
            text_linkGGForm.BackColor = Color.White;
            text_linkGGForm.BorderStyle = BorderStyle.FixedSingle;
            text_linkGGForm.Font = new Font("Poppins", 9F);
            text_linkGGForm.Location = new Point(246, 226);
            text_linkGGForm.Name = "text_linkGGForm";
            text_linkGGForm.Size = new Size(460, 30);
            text_linkGGForm.TabIndex = 7;
            text_linkGGForm.TextChanged += text_linkGGForm_DataContextChanged;
            text_linkGGForm.MouseLeave += text_linkGGForm_MouseLeave;
            // 
            // lb_linkGGForm
            // 
            lb_linkGGForm.Anchor = AnchorStyles.None;
            lb_linkGGForm.AutoSize = true;
            lb_linkGGForm.BackColor = Color.White;
            lb_linkGGForm.Font = new Font("Poppins", 10F);
            lb_linkGGForm.Location = new Point(100, 226);
            lb_linkGGForm.Name = "lb_linkGGForm";
            lb_linkGGForm.Size = new Size(128, 30);
            lb_linkGGForm.TabIndex = 6;
            lb_linkGGForm.Text = "Link GG Form:";
            // 
            // btn_save
            // 
            btn_save.Anchor = AnchorStyles.None;
            btn_save.BackColor = SystemColors.Control;
            btn_save.Font = new Font("Poppins", 9F);
            btn_save.Location = new Point(612, 292);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Visible = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_showQR
            // 
            btn_showQR.Anchor = AnchorStyles.None;
            btn_showQR.Font = new Font("Poppins", 9F);
            btn_showQR.Location = new Point(612, 292);
            btn_showQR.Name = "btn_showQR";
            btn_showQR.Size = new Size(94, 29);
            btn_showQR.TabIndex = 9;
            btn_showQR.Text = "Show QR";
            btn_showQR.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_cancel);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_showQR);
            panel1.Controls.Add(lb_classCode);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 10;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.None;
            btn_cancel.BackColor = SystemColors.Control;
            btn_cancel.Font = new Font("Poppins", 9F);
            btn_cancel.Location = new Point(495, 292);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(94, 29);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Visible = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // FormEditClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(text_linkGGForm);
            Controls.Add(lb_linkGGForm);
            Controls.Add(text_term);
            Controls.Add(label2);
            Controls.Add(text_classCode);
            Controls.Add(text_subjectName);
            Controls.Add(lb_subjectName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditClass";
            Text = "FormEditClass";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_subjectName;
        private TextBox text_subjectName;
        private TextBox text_classCode;
        private Label lb_classCode;
        private TextBox text_term;
        private Label label2;
        private TextBox text_linkGGForm;
        private Label lb_linkGGForm;
        private Button btn_save;
        private Button btn_showQR;
        private Panel panel1;
        private Button btn_cancel;
    }
}