namespace App1
{
    partial class Student
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
            this.StdNameLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExamIDSlovedLb = new System.Windows.Forms.Label();
            this.examSlovedCB = new System.Windows.Forms.ComboBox();
            this.ScoreLb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.sloveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.examNotSlovedCB = new System.Windows.Forms.ComboBox();
            this.dateNotSlovedLb = new System.Windows.Forms.Label();
            this.ExamIDNotSlovedLb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StdNameLb
            // 
            this.StdNameLb.AutoSize = true;
            this.StdNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdNameLb.Location = new System.Drawing.Point(332, 37);
            this.StdNameLb.Name = "StdNameLb";
            this.StdNameLb.Size = new System.Drawing.Size(0, 31);
            this.StdNameLb.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExamIDSlovedLb);
            this.panel1.Controls.Add(this.examSlovedCB);
            this.panel1.Controls.Add(this.ScoreLb);
            this.panel1.Controls.Add(this.dateLb);
            this.panel1.Location = new System.Drawing.Point(12, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 64);
            this.panel1.TabIndex = 1;
            // 
            // ExamIDSlovedLb
            // 
            this.ExamIDSlovedLb.AutoSize = true;
            this.ExamIDSlovedLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamIDSlovedLb.Location = new System.Drawing.Point(212, 28);
            this.ExamIDSlovedLb.Name = "ExamIDSlovedLb";
            this.ExamIDSlovedLb.Size = new System.Drawing.Size(0, 24);
            this.ExamIDSlovedLb.TabIndex = 10;
            // 
            // examSlovedCB
            // 
            this.examSlovedCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examSlovedCB.FormattingEnabled = true;
            this.examSlovedCB.Location = new System.Drawing.Point(3, 28);
            this.examSlovedCB.Name = "examSlovedCB";
            this.examSlovedCB.Size = new System.Drawing.Size(190, 24);
            this.examSlovedCB.TabIndex = 8;
            this.examSlovedCB.SelectedIndexChanged += new System.EventHandler(this.examSlovedCB_SelectedIndexChanged);
            // 
            // ScoreLb
            // 
            this.ScoreLb.AutoSize = true;
            this.ScoreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLb.Location = new System.Drawing.Point(605, 28);
            this.ScoreLb.Name = "ScoreLb";
            this.ScoreLb.Size = new System.Drawing.Size(0, 24);
            this.ScoreLb.TabIndex = 5;
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLb.Location = new System.Drawing.Point(342, 28);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(0, 24);
            this.dateLb.TabIndex = 4;
            // 
            // sloveBtn
            // 
            this.sloveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloveBtn.Location = new System.Drawing.Point(609, 14);
            this.sloveBtn.Name = "sloveBtn";
            this.sloveBtn.Size = new System.Drawing.Size(133, 39);
            this.sloveBtn.TabIndex = 6;
            this.sloveBtn.Text = "SloveExam";
            this.sloveBtn.UseVisualStyleBackColor = true;
            this.sloveBtn.Click += new System.EventHandler(this.sloveBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.examNotSlovedCB);
            this.panel2.Controls.Add(this.dateNotSlovedLb);
            this.panel2.Controls.Add(this.sloveBtn);
            this.panel2.Controls.Add(this.ExamIDNotSlovedLb);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 64);
            this.panel2.TabIndex = 7;
            // 
            // examNotSlovedCB
            // 
            this.examNotSlovedCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examNotSlovedCB.FormattingEnabled = true;
            this.examNotSlovedCB.Location = new System.Drawing.Point(3, 22);
            this.examNotSlovedCB.Name = "examNotSlovedCB";
            this.examNotSlovedCB.Size = new System.Drawing.Size(190, 24);
            this.examNotSlovedCB.TabIndex = 9;
            this.examNotSlovedCB.SelectedIndexChanged += new System.EventHandler(this.examNotSlovedCB_SelectedIndexChanged);
            // 
            // dateNotSlovedLb
            // 
            this.dateNotSlovedLb.AutoSize = true;
            this.dateNotSlovedLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNotSlovedLb.Location = new System.Drawing.Point(342, 22);
            this.dateNotSlovedLb.Name = "dateNotSlovedLb";
            this.dateNotSlovedLb.Size = new System.Drawing.Size(0, 24);
            this.dateNotSlovedLb.TabIndex = 5;
            // 
            // ExamIDNotSlovedLb
            // 
            this.ExamIDNotSlovedLb.AutoSize = true;
            this.ExamIDNotSlovedLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamIDNotSlovedLb.Location = new System.Drawing.Point(212, 22);
            this.ExamIDNotSlovedLb.Name = "ExamIDNotSlovedLb";
            this.ExamIDNotSlovedLb.Size = new System.Drawing.Size(0, 24);
            this.ExamIDNotSlovedLb.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App1.Properties.Resources.ITILogoThree;
            this.pictureBox1.Location = new System.Drawing.Point(15, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StdNameLb);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StdNameLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ScoreLb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.Button sloveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dateNotSlovedLb;
        private System.Windows.Forms.Label ExamIDNotSlovedLb;
        private System.Windows.Forms.ComboBox examSlovedCB;
        private System.Windows.Forms.Label ExamIDSlovedLb;
        private System.Windows.Forms.ComboBox examNotSlovedCB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}