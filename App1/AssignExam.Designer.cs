
namespace App1
{
    partial class AssignExam
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
            this.components = new System.ComponentModel.Container();
            this.CourseIdAssignExam = new System.Windows.Forms.Label();
            this.CourseIDAssignCombox = new System.Windows.Forms.ComboBox();
            this.StudIdLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StdCombox = new System.Windows.Forms.ComboBox();
            this.AssignExamBtn = new System.Windows.Forms.Button();
            this.ExamAssignIdLabel = new System.Windows.Forms.Label();
            this.ExamIDTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseIdAssignExam
            // 
            this.CourseIdAssignExam.AutoSize = true;
            this.CourseIdAssignExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseIdAssignExam.Location = new System.Drawing.Point(75, 235);
            this.CourseIdAssignExam.Name = "CourseIdAssignExam";
            this.CourseIdAssignExam.Size = new System.Drawing.Size(76, 25);
            this.CourseIdAssignExam.TabIndex = 0;
            this.CourseIdAssignExam.Text = "Course";
            this.CourseIdAssignExam.Click += new System.EventHandler(this.label1_Click);
            // 
            // CourseIDAssignCombox
            // 
            this.CourseIDAssignCombox.FormattingEnabled = true;
            this.CourseIDAssignCombox.Location = new System.Drawing.Point(216, 239);
            this.CourseIDAssignCombox.Name = "CourseIDAssignCombox";
            this.CourseIDAssignCombox.Size = new System.Drawing.Size(294, 21);
            this.CourseIDAssignCombox.TabIndex = 1;
            // 
            // StudIdLabel
            // 
            this.StudIdLabel.AutoSize = true;
            this.StudIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudIdLabel.Location = new System.Drawing.Point(75, 279);
            this.StudIdLabel.Name = "StudIdLabel";
            this.StudIdLabel.Size = new System.Drawing.Size(137, 25);
            this.StudIdLabel.TabIndex = 2;
            this.StudIdLabel.Text = "Student Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // StdCombox
            // 
            this.StdCombox.FormattingEnabled = true;
            this.StdCombox.Location = new System.Drawing.Point(216, 279);
            this.StdCombox.Name = "StdCombox";
            this.StdCombox.Size = new System.Drawing.Size(294, 21);
            this.StdCombox.TabIndex = 4;
            // 
            // AssignExamBtn
            // 
            this.AssignExamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignExamBtn.Location = new System.Drawing.Point(606, 251);
            this.AssignExamBtn.Name = "AssignExamBtn";
            this.AssignExamBtn.Size = new System.Drawing.Size(145, 69);
            this.AssignExamBtn.TabIndex = 5;
            this.AssignExamBtn.Text = "Assign Exam";
            this.AssignExamBtn.UseVisualStyleBackColor = true;
            this.AssignExamBtn.Click += new System.EventHandler(this.AssignExamBtn_Click);
            // 
            // ExamAssignIdLabel
            // 
            this.ExamAssignIdLabel.AutoSize = true;
            this.ExamAssignIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamAssignIdLabel.Location = new System.Drawing.Point(75, 334);
            this.ExamAssignIdLabel.Name = "ExamAssignIdLabel";
            this.ExamAssignIdLabel.Size = new System.Drawing.Size(86, 25);
            this.ExamAssignIdLabel.TabIndex = 6;
            this.ExamAssignIdLabel.Text = "Exam ID";
            // 
            // ExamIDTextBox
            // 
            this.ExamIDTextBox.Location = new System.Drawing.Point(216, 334);
            this.ExamIDTextBox.Name = "ExamIDTextBox";
            this.ExamIDTextBox.Size = new System.Drawing.Size(294, 20);
            this.ExamIDTextBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App1.Properties.Resources.ITILogoThree;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 179);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AssignExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExamIDTextBox);
            this.Controls.Add(this.ExamAssignIdLabel);
            this.Controls.Add(this.AssignExamBtn);
            this.Controls.Add(this.StdCombox);
            this.Controls.Add(this.StudIdLabel);
            this.Controls.Add(this.CourseIDAssignCombox);
            this.Controls.Add(this.CourseIdAssignExam);
            this.Name = "AssignExam";
            this.Text = "AssignExam";
            this.Load += new System.EventHandler(this.AssignExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseIdAssignExam;
        private System.Windows.Forms.ComboBox CourseIDAssignCombox;
        private System.Windows.Forms.Label StudIdLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox StdCombox;
        private System.Windows.Forms.Button AssignExamBtn;
        private System.Windows.Forms.Label ExamAssignIdLabel;
        private System.Windows.Forms.TextBox ExamIDTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}