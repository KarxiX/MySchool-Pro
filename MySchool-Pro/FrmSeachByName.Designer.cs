namespace MySchool_Pro
{
    partial class FrmSeachByName
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
            this.gBoSeachAreas = new System.Windows.Forms.GroupBox();
            this.btoChaXun = new System.Windows.Forms.Button();
            this.lblMohu = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.LvStudentList = new System.Windows.Forms.ListView();
            this.cHStudentNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHStudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHStudentSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHGread = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMSStudentList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoSeachAreas.SuspendLayout();
            this.cMSStudentList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoSeachAreas
            // 
            this.gBoSeachAreas.Controls.Add(this.btoChaXun);
            this.gBoSeachAreas.Controls.Add(this.lblMohu);
            this.gBoSeachAreas.Controls.Add(this.tbName);
            this.gBoSeachAreas.Controls.Add(this.lblStudentName);
            this.gBoSeachAreas.Location = new System.Drawing.Point(22, 25);
            this.gBoSeachAreas.Name = "gBoSeachAreas";
            this.gBoSeachAreas.Size = new System.Drawing.Size(577, 101);
            this.gBoSeachAreas.TabIndex = 0;
            this.gBoSeachAreas.TabStop = false;
            this.gBoSeachAreas.Text = "搜索条件";
            // 
            // btoChaXun
            // 
            this.btoChaXun.Location = new System.Drawing.Point(299, 30);
            this.btoChaXun.Name = "btoChaXun";
            this.btoChaXun.Size = new System.Drawing.Size(102, 23);
            this.btoChaXun.TabIndex = 3;
            this.btoChaXun.Text = "查  询";
            this.btoChaXun.UseVisualStyleBackColor = true;
            this.btoChaXun.Click += new System.EventHandler(this.btoChaXun_Click);
            // 
            // lblMohu
            // 
            this.lblMohu.AutoSize = true;
            this.lblMohu.Location = new System.Drawing.Point(407, 35);
            this.lblMohu.Name = "lblMohu";
            this.lblMohu.Size = new System.Drawing.Size(89, 12);
            this.lblMohu.TabIndex = 2;
            this.lblMohu.Text = "(支持模糊查询)";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(92, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(201, 21);
            this.tbName.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(33, 35);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(53, 12);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "学员姓名";
            // 
            // LvStudentList
            // 
            this.LvStudentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHStudentNo,
            this.cHStudentName,
            this.cHStudentSex,
            this.cHGread,
            this.cHEmail,
            this.cHPhone});
            this.LvStudentList.ContextMenuStrip = this.cMSStudentList;
            this.LvStudentList.FullRowSelect = true;
            this.LvStudentList.GridLines = true;
            this.LvStudentList.HideSelection = false;
            this.LvStudentList.Location = new System.Drawing.Point(22, 150);
            this.LvStudentList.Name = "LvStudentList";
            this.LvStudentList.Size = new System.Drawing.Size(577, 247);
            this.LvStudentList.TabIndex = 4;
            this.LvStudentList.UseCompatibleStateImageBehavior = false;
            this.LvStudentList.View = System.Windows.Forms.View.Details;
            // 
            // cHStudentNo
            // 
            this.cHStudentNo.Text = "学号(StudentNo)";
            this.cHStudentNo.Width = 100;
            // 
            // cHStudentName
            // 
            this.cHStudentName.Text = "学员姓名(StudentName)";
            this.cHStudentName.Width = 151;
            // 
            // cHStudentSex
            // 
            this.cHStudentSex.Text = "性别(StudentSex)";
            this.cHStudentSex.Width = 57;
            // 
            // cHGread
            // 
            this.cHGread.Text = "年级(Gread)";
            this.cHGread.Width = 86;
            // 
            // cHEmail
            // 
            this.cHEmail.Text = "邮箱(Email)";
            this.cHEmail.Width = 77;
            // 
            // cHPhone
            // 
            this.cHPhone.Text = "电话(Phone)";
            this.cHPhone.Width = 269;
            // 
            // cMSStudentList
            // 
            this.cMSStudentList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
            this.cMSStudentList.Name = "cMSStudentList";
            this.cMSStudentList.Size = new System.Drawing.Size(149, 26);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmiDelete.Text = "删除学员信息";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // FrmSeachByName
            // 
            this.AcceptButton = this.btoChaXun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 409);
            this.Controls.Add(this.LvStudentList);
            this.Controls.Add(this.gBoSeachAreas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmSeachByName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "按名称查询学员信息";
            this.Load += new System.EventHandler(this.FrmSeachByName_Load);
            this.gBoSeachAreas.ResumeLayout(false);
            this.gBoSeachAreas.PerformLayout();
            this.cMSStudentList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoSeachAreas;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btoChaXun;
        private System.Windows.Forms.Label lblMohu;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListView LvStudentList;
        private System.Windows.Forms.ColumnHeader cHStudentNo;
        private System.Windows.Forms.ColumnHeader cHStudentName;
        private System.Windows.Forms.ColumnHeader cHStudentSex;
        private System.Windows.Forms.ColumnHeader cHGread;
        private System.Windows.Forms.ColumnHeader cHEmail;
        private System.Windows.Forms.ColumnHeader cHPhone;
        private System.Windows.Forms.ContextMenuStrip cMSStudentList;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}