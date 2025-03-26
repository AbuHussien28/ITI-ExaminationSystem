
namespace App1
{
    partial class HomeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestionContentAdd = new System.Windows.Forms.Label();
            this.ContentQuestionAddTextBox = new System.Windows.Forms.TextBox();
            this.ChooiceAddTextBox = new System.Windows.Forms.TextBox();
            this.QuestionChoiceAdd = new System.Windows.Forms.Label();
            this.QuestionType = new System.Windows.Forms.Label();
            this.MCQType = new System.Windows.Forms.RadioButton();
            this.TrueFalseType = new System.Windows.Forms.RadioButton();
            this.CourseQuestionAdd = new System.Windows.Forms.Label();
            this.CourseComboxAdd = new System.Windows.Forms.ComboBox();
            this.iTIExaminationSYSDataSet = new App1.ITIExaminationSYSDataSet();
            this.getCourseByInsdutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getCourseByInsdutorTableAdapter = new App1.ITIExaminationSYSDataSetTableAdapters.GetCourseByInsdutorTableAdapter();
            this.AddQuestion = new System.Windows.Forms.Button();
            this.CorrectQuestionAddTextBox = new System.Windows.Forms.TextBox();
            this.CorrectQuestionAdd = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTIExaminationSYSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCourseByInsdutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questionToolStripMenuItem,
            this.examToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // questionToolStripMenuItem
            // 
            this.questionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewQuestionsToolStripMenuItem});
            this.questionToolStripMenuItem.Name = "questionToolStripMenuItem";
            this.questionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.questionToolStripMenuItem.Text = "Question";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // viewQuestionsToolStripMenuItem
            // 
            this.viewQuestionsToolStripMenuItem.Name = "viewQuestionsToolStripMenuItem";
            this.viewQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewQuestionsToolStripMenuItem.Text = "View Questions";
            this.viewQuestionsToolStripMenuItem.Click += new System.EventHandler(this.viewQuestionsToolStripMenuItem_Click);
            // 
            // examToolStripMenuItem
            // 
            this.examToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeToolStripMenuItem,
            this.assignToolStripMenuItem});
            this.examToolStripMenuItem.Name = "examToolStripMenuItem";
            this.examToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.examToolStripMenuItem.Text = "Exam";
            // 
            // makeToolStripMenuItem
            // 
            this.makeToolStripMenuItem.Name = "makeToolStripMenuItem";
            this.makeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeToolStripMenuItem.Text = "Make";
            this.makeToolStripMenuItem.Click += new System.EventHandler(this.makeToolStripMenuItem_Click);
            // 
            // assignToolStripMenuItem
            // 
            this.assignToolStripMenuItem.Name = "assignToolStripMenuItem";
            this.assignToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.assignToolStripMenuItem.Text = "Assign";
            this.assignToolStripMenuItem.Click += new System.EventHandler(this.assignToolStripMenuItem_Click);
            // 
            // QuestionContentAdd
            // 
            this.QuestionContentAdd.AutoSize = true;
            this.QuestionContentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionContentAdd.Location = new System.Drawing.Point(32, 227);
            this.QuestionContentAdd.Name = "QuestionContentAdd";
            this.QuestionContentAdd.Size = new System.Drawing.Size(165, 25);
            this.QuestionContentAdd.TabIndex = 1;
            this.QuestionContentAdd.Text = "Question Content";
            // 
            // ContentQuestionAddTextBox
            // 
            this.ContentQuestionAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentQuestionAddTextBox.Location = new System.Drawing.Point(219, 227);
            this.ContentQuestionAddTextBox.Multiline = true;
            this.ContentQuestionAddTextBox.Name = "ContentQuestionAddTextBox";
            this.ContentQuestionAddTextBox.Size = new System.Drawing.Size(418, 33);
            this.ContentQuestionAddTextBox.TabIndex = 2;
            // 
            // ChooiceAddTextBox
            // 
            this.ChooiceAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooiceAddTextBox.Location = new System.Drawing.Point(219, 500);
            this.ChooiceAddTextBox.Multiline = true;
            this.ChooiceAddTextBox.Name = "ChooiceAddTextBox";
            this.ChooiceAddTextBox.Size = new System.Drawing.Size(418, 33);
            this.ChooiceAddTextBox.TabIndex = 4;
            // 
            // QuestionChoiceAdd
            // 
            this.QuestionChoiceAdd.AutoSize = true;
            this.QuestionChoiceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionChoiceAdd.Location = new System.Drawing.Point(32, 508);
            this.QuestionChoiceAdd.Name = "QuestionChoiceAdd";
            this.QuestionChoiceAdd.Size = new System.Drawing.Size(91, 25);
            this.QuestionChoiceAdd.TabIndex = 3;
            this.QuestionChoiceAdd.Text = "Chooses";
            // 
            // QuestionType
            // 
            this.QuestionType.AutoSize = true;
            this.QuestionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionType.Location = new System.Drawing.Point(32, 298);
            this.QuestionType.Name = "QuestionType";
            this.QuestionType.Size = new System.Drawing.Size(57, 25);
            this.QuestionType.TabIndex = 5;
            this.QuestionType.Text = "Type";
            // 
            // MCQType
            // 
            this.MCQType.AutoSize = true;
            this.MCQType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCQType.Location = new System.Drawing.Point(219, 296);
            this.MCQType.Name = "MCQType";
            this.MCQType.Size = new System.Drawing.Size(78, 29);
            this.MCQType.TabIndex = 6;
            this.MCQType.TabStop = true;
            this.MCQType.Text = "MCQ";
            this.MCQType.UseVisualStyleBackColor = true;
            // 
            // TrueFalseType
            // 
            this.TrueFalseType.AutoSize = true;
            this.TrueFalseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrueFalseType.Location = new System.Drawing.Point(512, 298);
            this.TrueFalseType.Name = "TrueFalseType";
            this.TrueFalseType.Size = new System.Drawing.Size(125, 29);
            this.TrueFalseType.TabIndex = 7;
            this.TrueFalseType.TabStop = true;
            this.TrueFalseType.Text = "True/False";
            this.TrueFalseType.UseVisualStyleBackColor = true;
            // 
            // CourseQuestionAdd
            // 
            this.CourseQuestionAdd.AutoSize = true;
            this.CourseQuestionAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseQuestionAdd.Location = new System.Drawing.Point(32, 363);
            this.CourseQuestionAdd.Name = "CourseQuestionAdd";
            this.CourseQuestionAdd.Size = new System.Drawing.Size(76, 25);
            this.CourseQuestionAdd.TabIndex = 8;
            this.CourseQuestionAdd.Text = "Course";
            // 
            // CourseComboxAdd
            // 
            this.CourseComboxAdd.FormattingEnabled = true;
            this.CourseComboxAdd.Location = new System.Drawing.Point(219, 354);
            this.CourseComboxAdd.Name = "CourseComboxAdd";
            this.CourseComboxAdd.Size = new System.Drawing.Size(418, 21);
            this.CourseComboxAdd.TabIndex = 9;
            // 
            // iTIExaminationSYSDataSet
            // 
            this.iTIExaminationSYSDataSet.DataSetName = "ITIExaminationSYSDataSet";
            this.iTIExaminationSYSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getCourseByInsdutorBindingSource
            // 
            this.getCourseByInsdutorBindingSource.DataMember = "GetCourseByInsdutor";
            this.getCourseByInsdutorBindingSource.DataSource = this.iTIExaminationSYSDataSet;
            // 
            // getCourseByInsdutorTableAdapter
            // 
            this.getCourseByInsdutorTableAdapter.ClearBeforeFill = true;
            // 
            // AddQuestion
            // 
            this.AddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuestion.Location = new System.Drawing.Point(671, 245);
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(151, 98);
            this.AddQuestion.TabIndex = 16;
            this.AddQuestion.Text = "ADD";
            this.AddQuestion.UseVisualStyleBackColor = true;
            this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // CorrectQuestionAddTextBox
            // 
            this.CorrectQuestionAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectQuestionAddTextBox.Location = new System.Drawing.Point(219, 436);
            this.CorrectQuestionAddTextBox.Multiline = true;
            this.CorrectQuestionAddTextBox.Name = "CorrectQuestionAddTextBox";
            this.CorrectQuestionAddTextBox.Size = new System.Drawing.Size(418, 33);
            this.CorrectQuestionAddTextBox.TabIndex = 18;
            this.CorrectQuestionAddTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CorrectQuestionAdd
            // 
            this.CorrectQuestionAdd.AutoSize = true;
            this.CorrectQuestionAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectQuestionAdd.Location = new System.Drawing.Point(32, 444);
            this.CorrectQuestionAdd.Name = "CorrectQuestionAdd";
            this.CorrectQuestionAdd.Size = new System.Drawing.Size(147, 25);
            this.CorrectQuestionAdd.TabIndex = 17;
            this.CorrectQuestionAdd.Text = "Correct Answer";
            this.CorrectQuestionAdd.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(671, 410);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(151, 98);
            this.ClearBtn.TabIndex = 19;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App1.Properties.Resources.ITILogoThree;
            this.pictureBox1.Location = new System.Drawing.Point(37, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(868, 167);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CorrectQuestionAddTextBox);
            this.Controls.Add(this.CorrectQuestionAdd);
            this.Controls.Add(this.AddQuestion);
            this.Controls.Add(this.CourseComboxAdd);
            this.Controls.Add(this.CourseQuestionAdd);
            this.Controls.Add(this.TrueFalseType);
            this.Controls.Add(this.MCQType);
            this.Controls.Add(this.QuestionType);
            this.Controls.Add(this.ChooiceAddTextBox);
            this.Controls.Add(this.QuestionChoiceAdd);
            this.Controls.Add(this.ContentQuestionAddTextBox);
            this.Controls.Add(this.QuestionContentAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "Home Question";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTIExaminationSYSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCourseByInsdutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem questionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignToolStripMenuItem;
        private System.Windows.Forms.Label QuestionContentAdd;
        private System.Windows.Forms.TextBox ContentQuestionAddTextBox;
        private System.Windows.Forms.TextBox ChooiceAddTextBox;
        private System.Windows.Forms.Label QuestionChoiceAdd;
        private System.Windows.Forms.Label QuestionType;
        private System.Windows.Forms.RadioButton MCQType;
        private System.Windows.Forms.RadioButton TrueFalseType;
        private System.Windows.Forms.Label CourseQuestionAdd;
        private System.Windows.Forms.ComboBox CourseComboxAdd;
        private ITIExaminationSYSDataSet iTIExaminationSYSDataSet;
        private System.Windows.Forms.BindingSource getCourseByInsdutorBindingSource;
        private ITIExaminationSYSDataSetTableAdapters.GetCourseByInsdutorTableAdapter getCourseByInsdutorTableAdapter;
        private System.Windows.Forms.Button AddQuestion;
        private System.Windows.Forms.TextBox CorrectQuestionAddTextBox;
        private System.Windows.Forms.Label CorrectQuestionAdd;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ToolStripMenuItem viewQuestionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}