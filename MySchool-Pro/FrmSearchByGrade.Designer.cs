namespace MySchool_Pro
{
    partial class FrmSearchByGrade
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
            this.gBSearchGrade = new System.Windows.Forms.GroupBox();
            this.btoSearch = new System.Windows.Forms.Button();
            this.cBNJ = new System.Windows.Forms.ComboBox();
            this.labSSNJ = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labPs = new System.Windows.Forms.Label();
            this.dGVList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsStuList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBSearchGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVList)).BeginInit();
            this.cmsStuList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBSearchGrade
            // 
            this.gBSearchGrade.Controls.Add(this.btoSearch);
            this.gBSearchGrade.Controls.Add(this.cBNJ);
            this.gBSearchGrade.Controls.Add(this.labSSNJ);
            this.gBSearchGrade.Location = new System.Drawing.Point(12, 21);
            this.gBSearchGrade.Name = "gBSearchGrade";
            this.gBSearchGrade.Size = new System.Drawing.Size(776, 98);
            this.gBSearchGrade.TabIndex = 0;
            this.gBSearchGrade.TabStop = false;
            this.gBSearchGrade.Text = "搜索条件";
            // 
            // btoSearch
            // 
            this.btoSearch.Location = new System.Drawing.Point(312, 41);
            this.btoSearch.Name = "btoSearch";
            this.btoSearch.Size = new System.Drawing.Size(75, 23);
            this.btoSearch.TabIndex = 4;
            this.btoSearch.Text = "查  询";
            this.btoSearch.UseVisualStyleBackColor = true;
            this.btoSearch.Click += new System.EventHandler(this.btoSearch_Click);
            // 
            // cBNJ
            // 
            this.cBNJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBNJ.FormattingEnabled = true;
            this.cBNJ.Location = new System.Drawing.Point(105, 43);
            this.cBNJ.Name = "cBNJ";
            this.cBNJ.Size = new System.Drawing.Size(195, 20);
            this.cBNJ.TabIndex = 3;
            this.cBNJ.SelectedIndexChanged += new System.EventHandler(this.cBNJ_SelectedIndexChanged);
            // 
            // labSSNJ
            // 
            this.labSSNJ.AutoSize = true;
            this.labSSNJ.Location = new System.Drawing.Point(40, 46);
            this.labSSNJ.Name = "labSSNJ";
            this.labSSNJ.Size = new System.Drawing.Size(53, 12);
            this.labSSNJ.TabIndex = 2;
            this.labSSNJ.Text = "所属年级";
            // 
            // labPs
            // 
            this.labPs.AutoSize = true;
            this.labPs.Location = new System.Drawing.Point(621, 433);
            this.labPs.Name = "labPs";
            this.labPs.Size = new System.Drawing.Size(155, 12);
            this.labPs.TabIndex = 1;
            this.labPs.Text = "说明: 1代表男生 0代表女生";
            // 
            // dGVList
            // 
            this.dGVList.AllowUserToAddRows = false;
            this.dGVList.AllowUserToDeleteRows = false;
            this.dGVList.AllowUserToResizeColumns = false;
            this.dGVList.AllowUserToResizeRows = false;
            this.dGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGVList.ContextMenuStrip = this.cmsStuList;
            this.dGVList.Location = new System.Drawing.Point(12, 125);
            this.dGVList.MultiSelect = false;
            this.dGVList.Name = "dGVList";
            this.dGVList.ReadOnly = true;
            this.dGVList.RowHeadersWidth = 10;
            this.dGVList.RowTemplate.Height = 23;
            this.dGVList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVList.Size = new System.Drawing.Size(776, 301);
            this.dGVList.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentNo";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "学生学号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StudentName";
            this.Column2.HeaderText = "学生姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 210;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gender";
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 210;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Birthday";
            this.Column4.HeaderText = "出生日期";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 210;
            // 
            // cmsStuList
            // 
            this.cmsStuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除学生信息ToolStripMenuItem,
            this.修改学生信息ToolStripMenuItem,
            this.添加成绩ToolStripMenuItem});
            this.cmsStuList.Name = "cmsStuList";
            this.cmsStuList.Size = new System.Drawing.Size(181, 92);
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            this.删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            this.删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.删除学生信息ToolStripMenuItem.Text = "删除学生信息";
            this.删除学生信息ToolStripMenuItem.Click += new System.EventHandler(this.删除学生信息ToolStripMenuItem_Click);
            // 
            // 修改学生信息ToolStripMenuItem
            // 
            this.修改学生信息ToolStripMenuItem.Name = "修改学生信息ToolStripMenuItem";
            this.修改学生信息ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.修改学生信息ToolStripMenuItem.Text = "修改学生信息";
            this.修改学生信息ToolStripMenuItem.Click += new System.EventHandler(this.修改学生信息ToolStripMenuItem_Click);
            // 
            // 添加成绩ToolStripMenuItem
            // 
            this.添加成绩ToolStripMenuItem.Name = "添加成绩ToolStripMenuItem";
            this.添加成绩ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.添加成绩ToolStripMenuItem.Text = "添加成绩";
            this.添加成绩ToolStripMenuItem.Click += new System.EventHandler(this.添加成绩ToolStripMenuItem_Click);
            // 
            // FrmSearchByGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dGVList);
            this.Controls.Add(this.labPs);
            this.Controls.Add(this.gBSearchGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSearchByGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "按年级查询学员信息";
            this.Load += new System.EventHandler(this.FrmSearchByGrade_Load);
            this.gBSearchGrade.ResumeLayout(false);
            this.gBSearchGrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVList)).EndInit();
            this.cmsStuList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBSearchGrade;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labPs;
        private System.Windows.Forms.DataGridView dGVList;
        private System.Windows.Forms.Label labSSNJ;
        private System.Windows.Forms.ComboBox cBNJ;
        private System.Windows.Forms.Button btoSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ContextMenuStrip cmsStuList;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加成绩ToolStripMenuItem;
    }
}