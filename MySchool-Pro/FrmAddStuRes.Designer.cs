namespace MySchool_Pro
{
    partial class FrmAddStuRes
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
            this.gBoTJCJ = new System.Windows.Forms.GroupBox();
            this.dTPExamDate = new System.Windows.Forms.DateTimePicker();
            this.tBoRes = new System.Windows.Forms.TextBox();
            this.cBoSubject = new System.Windows.Forms.ComboBox();
            this.labTime = new System.Windows.Forms.Label();
            this.labRes = new System.Windows.Forms.Label();
            this.labSubject = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dGVStuRes = new System.Windows.Forms.DataGridView();
            this.butoFH = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butShowAllRes = new System.Windows.Forms.Button();
            this.butSaveRes = new System.Windows.Forms.Button();
            this.gBoTJCJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStuRes)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoTJCJ
            // 
            this.gBoTJCJ.Controls.Add(this.butShowAllRes);
            this.gBoTJCJ.Controls.Add(this.dTPExamDate);
            this.gBoTJCJ.Controls.Add(this.tBoRes);
            this.gBoTJCJ.Controls.Add(this.cBoSubject);
            this.gBoTJCJ.Controls.Add(this.labTime);
            this.gBoTJCJ.Controls.Add(this.labRes);
            this.gBoTJCJ.Controls.Add(this.labSubject);
            this.gBoTJCJ.Location = new System.Drawing.Point(12, 23);
            this.gBoTJCJ.Name = "gBoTJCJ";
            this.gBoTJCJ.Size = new System.Drawing.Size(565, 124);
            this.gBoTJCJ.TabIndex = 0;
            this.gBoTJCJ.TabStop = false;
            this.gBoTJCJ.Text = "输 入 成 绩 ";
            // 
            // dTPExamDate
            // 
            this.dTPExamDate.Location = new System.Drawing.Point(101, 84);
            this.dTPExamDate.Name = "dTPExamDate";
            this.dTPExamDate.Size = new System.Drawing.Size(289, 21);
            this.dTPExamDate.TabIndex = 5;
            // 
            // tBoRes
            // 
            this.tBoRes.Location = new System.Drawing.Point(101, 51);
            this.tBoRes.Name = "tBoRes";
            this.tBoRes.Size = new System.Drawing.Size(289, 21);
            this.tBoRes.TabIndex = 4;
            // 
            // cBoSubject
            // 
            this.cBoSubject.FormattingEnabled = true;
            this.cBoSubject.Location = new System.Drawing.Point(101, 21);
            this.cBoSubject.Name = "cBoSubject";
            this.cBoSubject.Size = new System.Drawing.Size(289, 20);
            this.cBoSubject.TabIndex = 1;
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(31, 87);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(53, 12);
            this.labTime.TabIndex = 3;
            this.labTime.Text = "考试时间";
            // 
            // labRes
            // 
            this.labRes.AutoSize = true;
            this.labRes.Location = new System.Drawing.Point(49, 55);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(35, 12);
            this.labRes.TabIndex = 2;
            this.labRes.Text = "成 绩";
            // 
            // labSubject
            // 
            this.labSubject.AutoSize = true;
            this.labSubject.Location = new System.Drawing.Point(49, 25);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(35, 12);
            this.labSubject.TabIndex = 1;
            this.labSubject.Text = "科 目";
            // 
            // dGVStuRes
            // 
            this.dGVStuRes.AllowUserToAddRows = false;
            this.dGVStuRes.AllowUserToDeleteRows = false;
            this.dGVStuRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStuRes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGVStuRes.Location = new System.Drawing.Point(12, 161);
            this.dGVStuRes.Name = "dGVStuRes";
            this.dGVStuRes.ReadOnly = true;
            this.dGVStuRes.RowHeadersWidth = 10;
            this.dGVStuRes.RowTemplate.Height = 23;
            this.dGVStuRes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVStuRes.Size = new System.Drawing.Size(565, 273);
            this.dGVStuRes.TabIndex = 6;
            // 
            // butoFH
            // 
            this.butoFH.Location = new System.Drawing.Point(502, 440);
            this.butoFH.Name = "butoFH";
            this.butoFH.Size = new System.Drawing.Size(75, 23);
            this.butoFH.TabIndex = 7;
            this.butoFH.Text = "返  回";
            this.butoFH.UseVisualStyleBackColor = true;
            this.butoFH.Click += new System.EventHandler(this.butoFH_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentName";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "学生姓名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SubjectName";
            this.Column2.HeaderText = "科目名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "StudentResult";
            this.Column3.HeaderText = "成绩";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ExamDate";
            this.Column4.HeaderText = "考试时间";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // butShowAllRes
            // 
            this.butShowAllRes.Location = new System.Drawing.Point(431, 50);
            this.butShowAllRes.Name = "butShowAllRes";
            this.butShowAllRes.Size = new System.Drawing.Size(97, 23);
            this.butShowAllRes.TabIndex = 6;
            this.butShowAllRes.Text = "所有学生成绩";
            this.butShowAllRes.UseVisualStyleBackColor = true;
            this.butShowAllRes.Click += new System.EventHandler(this.butShowAllRes_Click);
            // 
            // butSaveRes
            // 
            this.butSaveRes.Location = new System.Drawing.Point(409, 440);
            this.butSaveRes.Name = "butSaveRes";
            this.butSaveRes.Size = new System.Drawing.Size(75, 23);
            this.butSaveRes.TabIndex = 7;
            this.butSaveRes.Text = "保  存";
            this.butSaveRes.UseVisualStyleBackColor = true;
            this.butSaveRes.Click += new System.EventHandler(this.butSaveRes_Click);
            // 
            // FrmAddStuRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 468);
            this.Controls.Add(this.butSaveRes);
            this.Controls.Add(this.butoFH);
            this.Controls.Add(this.dGVStuRes);
            this.Controls.Add(this.gBoTJCJ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddStuRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加学生成绩";
            this.Load += new System.EventHandler(this.FrmAddStuRes_Load);
            this.gBoTJCJ.ResumeLayout(false);
            this.gBoTJCJ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStuRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoTJCJ;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labSubject;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.ComboBox cBoSubject;
        private System.Windows.Forms.DateTimePicker dTPExamDate;
        private System.Windows.Forms.TextBox tBoRes;
        private System.Windows.Forms.DataGridView dGVStuRes;
        private System.Windows.Forms.Button butoFH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button butShowAllRes;
        private System.Windows.Forms.Button butSaveRes;
    }
}