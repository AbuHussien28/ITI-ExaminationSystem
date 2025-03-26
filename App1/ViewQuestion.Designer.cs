
namespace App1
{
    partial class ViewQuestion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iTIExaminationSYSDataSet1 = new App1.ITIExaminationSYSDataSet1();
            this.questionSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionSelectTableAdapter = new App1.ITIExaminationSYSDataSet1TableAdapters.QuestionSelectTableAdapter();
            this.qIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qdegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTIExaminationSYSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qIDDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.qAnswerDataGridViewTextBoxColumn,
            this.qdegreeDataGridViewTextBoxColumn,
            this.examIDDataGridViewTextBoxColumn,
            this.questionTypeDataGridViewTextBoxColumn,
            this.courseIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.questionSelectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 461);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iTIExaminationSYSDataSet1
            // 
            this.iTIExaminationSYSDataSet1.DataSetName = "ITIExaminationSYSDataSet1";
            this.iTIExaminationSYSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionSelectBindingSource
            // 
            this.questionSelectBindingSource.DataMember = "QuestionSelect";
            this.questionSelectBindingSource.DataSource = this.iTIExaminationSYSDataSet1;
            // 
            // questionSelectTableAdapter
            // 
            this.questionSelectTableAdapter.ClearBeforeFill = true;
            // 
            // qIDDataGridViewTextBoxColumn
            // 
            this.qIDDataGridViewTextBoxColumn.DataPropertyName = "Q_ID";
            this.qIDDataGridViewTextBoxColumn.HeaderText = "Q_ID";
            this.qIDDataGridViewTextBoxColumn.Name = "qIDDataGridViewTextBoxColumn";
            this.qIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            // 
            // qAnswerDataGridViewTextBoxColumn
            // 
            this.qAnswerDataGridViewTextBoxColumn.DataPropertyName = "QAnswer";
            this.qAnswerDataGridViewTextBoxColumn.HeaderText = "QAnswer";
            this.qAnswerDataGridViewTextBoxColumn.Name = "qAnswerDataGridViewTextBoxColumn";
            // 
            // qdegreeDataGridViewTextBoxColumn
            // 
            this.qdegreeDataGridViewTextBoxColumn.DataPropertyName = "Qdegree";
            this.qdegreeDataGridViewTextBoxColumn.HeaderText = "Qdegree";
            this.qdegreeDataGridViewTextBoxColumn.Name = "qdegreeDataGridViewTextBoxColumn";
            // 
            // examIDDataGridViewTextBoxColumn
            // 
            this.examIDDataGridViewTextBoxColumn.DataPropertyName = "Exam_ID";
            this.examIDDataGridViewTextBoxColumn.HeaderText = "Exam_ID";
            this.examIDDataGridViewTextBoxColumn.Name = "examIDDataGridViewTextBoxColumn";
            // 
            // questionTypeDataGridViewTextBoxColumn
            // 
            this.questionTypeDataGridViewTextBoxColumn.DataPropertyName = "Question_Type";
            this.questionTypeDataGridViewTextBoxColumn.HeaderText = "Question_Type";
            this.questionTypeDataGridViewTextBoxColumn.Name = "questionTypeDataGridViewTextBoxColumn";
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::App1.Properties.Resources.ITILogoThree;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1505, 166);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 650);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewQuestion";
            this.Text = "ViewQuestion";
            this.Load += new System.EventHandler(this.ViewQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTIExaminationSYSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ITIExaminationSYSDataSet1 iTIExaminationSYSDataSet1;
        private System.Windows.Forms.BindingSource questionSelectBindingSource;
        private ITIExaminationSYSDataSet1TableAdapters.QuestionSelectTableAdapter questionSelectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn qIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qdegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
    }
}