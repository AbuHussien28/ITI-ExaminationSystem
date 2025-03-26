
namespace App1
{
    partial class MakeExam
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
            this.CourseExamMake = new System.Windows.Forms.Label();
            this.ComboxExamCourse = new System.Windows.Forms.ComboBox();
            this.TFQuestionNum = new System.Windows.Forms.Label();
            this.NumTFQuestionTextBox = new System.Windows.Forms.TextBox();
            this.NumMCQQuestionTextBox = new System.Windows.Forms.TextBox();
            this.MCQQuestionNum = new System.Windows.Forms.Label();
            this.ExamIdLabel = new System.Windows.Forms.Label();
            this.iTIExaminationSYSDataSet2 = new App1.ITIExaminationSYSDataSet2();
            this.getCourseByInsdutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCourseByInsdutorTableAdapter = new App1.ITIExaminationSYSDataSet2TableAdapters.GetCourseByInsdutorTableAdapter();
            this.MakeExamBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iTIExaminationSYSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCourseByInsdutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseExamMake
            // 
            this.CourseExamMake.AutoSize = true;
            this.CourseExamMake.Location = new System.Drawing.Point(51, 223);
            this.CourseExamMake.Name = "CourseExamMake";
            this.CourseExamMake.Size = new System.Drawing.Size(40, 13);
            this.CourseExamMake.TabIndex = 0;
            this.CourseExamMake.Text = "Course";
            // 
            // ComboxExamCourse
            // 
            this.ComboxExamCourse.DataSource = this.getCourseByInsdutorBindingSource;
            this.ComboxExamCourse.DisplayMember = "CourseName";
            this.ComboxExamCourse.FormattingEnabled = true;
            this.ComboxExamCourse.Location = new System.Drawing.Point(116, 223);
            this.ComboxExamCourse.Name = "ComboxExamCourse";
            this.ComboxExamCourse.Size = new System.Drawing.Size(211, 21);
            this.ComboxExamCourse.TabIndex = 1;
            this.ComboxExamCourse.ValueMember = "CourseName";
            // 
            // TFQuestionNum
            // 
            this.TFQuestionNum.AutoSize = true;
            this.TFQuestionNum.Location = new System.Drawing.Point(51, 268);
            this.TFQuestionNum.Name = "TFQuestionNum";
            this.TFQuestionNum.Size = new System.Drawing.Size(50, 13);
            this.TFQuestionNum.TabIndex = 2;
            this.TFQuestionNum.Text = "Num T/F";
            // 
            // NumTFQuestionTextBox
            // 
            this.NumTFQuestionTextBox.Location = new System.Drawing.Point(116, 268);
            this.NumTFQuestionTextBox.Name = "NumTFQuestionTextBox";
            this.NumTFQuestionTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumTFQuestionTextBox.TabIndex = 3;
            // 
            // NumMCQQuestionTextBox
            // 
            this.NumMCQQuestionTextBox.Location = new System.Drawing.Point(116, 320);
            this.NumMCQQuestionTextBox.Name = "NumMCQQuestionTextBox";
            this.NumMCQQuestionTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumMCQQuestionTextBox.TabIndex = 5;
            // 
            // MCQQuestionNum
            // 
            this.MCQQuestionNum.AutoSize = true;
            this.MCQQuestionNum.Location = new System.Drawing.Point(51, 320);
            this.MCQQuestionNum.Name = "MCQQuestionNum";
            this.MCQQuestionNum.Size = new System.Drawing.Size(59, 13);
            this.MCQQuestionNum.TabIndex = 4;
            this.MCQQuestionNum.Text = "Num MCQ ";
            // 
            // ExamIdLabel
            // 
            this.ExamIdLabel.AutoSize = true;
            this.ExamIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamIdLabel.Location = new System.Drawing.Point(183, 380);
            this.ExamIdLabel.Name = "ExamIdLabel";
            this.ExamIdLabel.Size = new System.Drawing.Size(0, 31);
            this.ExamIdLabel.TabIndex = 6;
            // 
            // iTIExaminationSYSDataSet2
            // 
            this.iTIExaminationSYSDataSet2.DataSetName = "ITIExaminationSYSDataSet2";
            this.iTIExaminationSYSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCourseByInsdutorBindingSource
            // 
            this.getCourseByInsdutorBindingSource.DataMember = "GetCourseByInsdutor";
            this.getCourseByInsdutorBindingSource.DataSource = this.iTIExaminationSYSDataSet2;
            // 
            // getCourseByInsdutorTableAdapter
            // 
            this.getCourseByInsdutorTableAdapter.ClearBeforeFill = true;
            // 
            // MakeExamBtn
            // 
            this.MakeExamBtn.Location = new System.Drawing.Point(434, 268);
            this.MakeExamBtn.Name = "MakeExamBtn";
            this.MakeExamBtn.Size = new System.Drawing.Size(126, 61);
            this.MakeExamBtn.TabIndex = 7;
            this.MakeExamBtn.Text = "Make Exam";
            this.MakeExamBtn.UseVisualStyleBackColor = true;
            this.MakeExamBtn.Click += new System.EventHandler(this.MakeExamBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App1.Properties.Resources.ITILogoThree;
            this.pictureBox1.Location = new System.Drawing.Point(26, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 144);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MakeExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MakeExamBtn);
            this.Controls.Add(this.ExamIdLabel);
            this.Controls.Add(this.NumMCQQuestionTextBox);
            this.Controls.Add(this.MCQQuestionNum);
            this.Controls.Add(this.NumTFQuestionTextBox);
            this.Controls.Add(this.TFQuestionNum);
            this.Controls.Add(this.ComboxExamCourse);
            this.Controls.Add(this.CourseExamMake);
            this.Name = "MakeExam";
            this.Text = "MakeExam";
            this.Load += new System.EventHandler(this.MakeExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTIExaminationSYSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCourseByInsdutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CourseExamMake;
        private System.Windows.Forms.ComboBox ComboxExamCourse;
        private System.Windows.Forms.Label TFQuestionNum;
        private System.Windows.Forms.TextBox NumTFQuestionTextBox;
        private System.Windows.Forms.TextBox NumMCQQuestionTextBox;
        private System.Windows.Forms.Label MCQQuestionNum;
        private System.Windows.Forms.Label ExamIdLabel;
        private ITIExaminationSYSDataSet2 iTIExaminationSYSDataSet2;
        private System.Windows.Forms.BindingSource getCourseByInsdutorBindingSource;
        private ITIExaminationSYSDataSet2TableAdapters.GetCourseByInsdutorTableAdapter getCourseByInsdutorTableAdapter;
        private System.Windows.Forms.Button MakeExamBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}