namespace MySchool_Pro
{
    partial class FrmUpdataInformation
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
            this.gboYHZCXX = new System.Windows.Forms.GroupBox();
            this.tbxQRMM = new System.Windows.Forms.TextBox();
            this.tbxMM = new System.Windows.Forms.TextBox();
            this.tbxXH = new System.Windows.Forms.TextBox();
            this.labPWD = new System.Windows.Forms.Label();
            this.labQRMM = new System.Windows.Forms.Label();
            this.labXH = new System.Windows.Forms.Label();
            this.gobYHJBXX = new System.Windows.Forms.GroupBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.dTPBIRDAY = new System.Windows.Forms.DateTimePicker();
            this.labBirthday = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tBxPHONE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBNianJi = new System.Windows.Forms.ComboBox();
            this.rBtMA = new System.Windows.Forms.RadioButton();
            this.rBtWOMAN = new System.Windows.Forms.RadioButton();
            this.tbxNAME = new System.Windows.Forms.TextBox();
            this.labSEX = new System.Windows.Forms.Label();
            this.labGREAD = new System.Windows.Forms.Label();
            this.labXM = new System.Windows.Forms.Label();
            this.butoSave = new System.Windows.Forms.Button();
            this.butoClean = new System.Windows.Forms.Button();
            this.gboYHZCXX.SuspendLayout();
            this.gobYHJBXX.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboYHZCXX
            // 
            this.gboYHZCXX.Controls.Add(this.tbxQRMM);
            this.gboYHZCXX.Controls.Add(this.tbxMM);
            this.gboYHZCXX.Controls.Add(this.tbxXH);
            this.gboYHZCXX.Controls.Add(this.labPWD);
            this.gboYHZCXX.Controls.Add(this.labQRMM);
            this.gboYHZCXX.Controls.Add(this.labXH);
            this.gboYHZCXX.Location = new System.Drawing.Point(12, 30);
            this.gboYHZCXX.Name = "gboYHZCXX";
            this.gboYHZCXX.Size = new System.Drawing.Size(340, 140);
            this.gboYHZCXX.TabIndex = 0;
            this.gboYHZCXX.TabStop = false;
            this.gboYHZCXX.Text = "用户注册信息";
            // 
            // tbxQRMM
            // 
            this.tbxQRMM.Location = new System.Drawing.Point(110, 100);
            this.tbxQRMM.Name = "tbxQRMM";
            this.tbxQRMM.Size = new System.Drawing.Size(180, 21);
            this.tbxQRMM.TabIndex = 5;
            this.tbxQRMM.UseSystemPasswordChar = true;
            // 
            // tbxMM
            // 
            this.tbxMM.Location = new System.Drawing.Point(110, 64);
            this.tbxMM.Name = "tbxMM";
            this.tbxMM.Size = new System.Drawing.Size(180, 21);
            this.tbxMM.TabIndex = 4;
            this.tbxMM.UseSystemPasswordChar = true;
            // 
            // tbxXH
            // 
            this.tbxXH.Location = new System.Drawing.Point(110, 25);
            this.tbxXH.Name = "tbxXH";
            this.tbxXH.ReadOnly = true;
            this.tbxXH.Size = new System.Drawing.Size(180, 21);
            this.tbxXH.TabIndex = 3;
            this.tbxXH.Text = "学号随机生成,无需手动填写";
            // 
            // labPWD
            // 
            this.labPWD.AutoSize = true;
            this.labPWD.Location = new System.Drawing.Point(59, 64);
            this.labPWD.Name = "labPWD";
            this.labPWD.Size = new System.Drawing.Size(29, 12);
            this.labPWD.TabIndex = 2;
            this.labPWD.Text = "密码";
            // 
            // labQRMM
            // 
            this.labQRMM.AutoSize = true;
            this.labQRMM.Location = new System.Drawing.Point(35, 103);
            this.labQRMM.Name = "labQRMM";
            this.labQRMM.Size = new System.Drawing.Size(53, 12);
            this.labQRMM.TabIndex = 1;
            this.labQRMM.Text = "确认密码";
            // 
            // labXH
            // 
            this.labXH.AutoSize = true;
            this.labXH.Location = new System.Drawing.Point(59, 28);
            this.labXH.Name = "labXH";
            this.labXH.Size = new System.Drawing.Size(29, 12);
            this.labXH.TabIndex = 0;
            this.labXH.Text = "学号";
            // 
            // gobYHJBXX
            // 
            this.gobYHJBXX.Controls.Add(this.tbxEmail);
            this.gobYHJBXX.Controls.Add(this.labEmail);
            this.gobYHJBXX.Controls.Add(this.dTPBIRDAY);
            this.gobYHJBXX.Controls.Add(this.labBirthday);
            this.gobYHJBXX.Controls.Add(this.labAddress);
            this.gobYHJBXX.Controls.Add(this.tbxAddress);
            this.gobYHJBXX.Controls.Add(this.tBxPHONE);
            this.gobYHJBXX.Controls.Add(this.label1);
            this.gobYHJBXX.Controls.Add(this.cbBNianJi);
            this.gobYHJBXX.Controls.Add(this.rBtMA);
            this.gobYHJBXX.Controls.Add(this.rBtWOMAN);
            this.gobYHJBXX.Controls.Add(this.tbxNAME);
            this.gobYHJBXX.Controls.Add(this.labSEX);
            this.gobYHJBXX.Controls.Add(this.labGREAD);
            this.gobYHJBXX.Controls.Add(this.labXM);
            this.gobYHJBXX.Location = new System.Drawing.Point(12, 185);
            this.gobYHJBXX.Name = "gobYHJBXX";
            this.gobYHJBXX.Size = new System.Drawing.Size(340, 331);
            this.gobYHJBXX.TabIndex = 1;
            this.gobYHJBXX.TabStop = false;
            this.gobYHJBXX.Text = "用户基本信息";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(110, 272);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(180, 21);
            this.tbxEmail.TabIndex = 15;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(53, 275);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(35, 12);
            this.labEmail.TabIndex = 14;
            this.labEmail.Text = "Email";
            // 
            // dTPBIRDAY
            // 
            this.dTPBIRDAY.Location = new System.Drawing.Point(110, 224);
            this.dTPBIRDAY.Name = "dTPBIRDAY";
            this.dTPBIRDAY.Size = new System.Drawing.Size(180, 21);
            this.dTPBIRDAY.TabIndex = 13;
            // 
            // labBirthday
            // 
            this.labBirthday.AutoSize = true;
            this.labBirthday.Location = new System.Drawing.Point(35, 230);
            this.labBirthday.Name = "labBirthday";
            this.labBirthday.Size = new System.Drawing.Size(53, 12);
            this.labBirthday.TabIndex = 12;
            this.labBirthday.Text = "出生日期";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(59, 188);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(29, 12);
            this.labAddress.TabIndex = 11;
            this.labAddress.Text = "地址";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(110, 185);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(180, 21);
            this.tbxAddress.TabIndex = 10;
            // 
            // tBxPHONE
            // 
            this.tBxPHONE.Location = new System.Drawing.Point(110, 145);
            this.tBxPHONE.Name = "tBxPHONE";
            this.tBxPHONE.Size = new System.Drawing.Size(180, 21);
            this.tBxPHONE.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "电话";
            // 
            // cbBNianJi
            // 
            this.cbBNianJi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBNianJi.FormattingEnabled = true;
            this.cbBNianJi.Location = new System.Drawing.Point(110, 105);
            this.cbBNianJi.Name = "cbBNianJi";
            this.cbBNianJi.Size = new System.Drawing.Size(180, 20);
            this.cbBNianJi.TabIndex = 2;
            // 
            // rBtMA
            // 
            this.rBtMA.AutoSize = true;
            this.rBtMA.Checked = true;
            this.rBtMA.Location = new System.Drawing.Point(170, 68);
            this.rBtMA.Name = "rBtMA";
            this.rBtMA.Size = new System.Drawing.Size(35, 16);
            this.rBtMA.TabIndex = 7;
            this.rBtMA.TabStop = true;
            this.rBtMA.Text = "男";
            this.rBtMA.UseVisualStyleBackColor = true;
            // 
            // rBtWOMAN
            // 
            this.rBtWOMAN.AutoSize = true;
            this.rBtWOMAN.Location = new System.Drawing.Point(110, 68);
            this.rBtWOMAN.Name = "rBtWOMAN";
            this.rBtWOMAN.Size = new System.Drawing.Size(35, 16);
            this.rBtWOMAN.TabIndex = 6;
            this.rBtWOMAN.Text = "女";
            this.rBtWOMAN.UseVisualStyleBackColor = true;
            // 
            // tbxNAME
            // 
            this.tbxNAME.Location = new System.Drawing.Point(110, 34);
            this.tbxNAME.Name = "tbxNAME";
            this.tbxNAME.Size = new System.Drawing.Size(180, 21);
            this.tbxNAME.TabIndex = 3;
            // 
            // labSEX
            // 
            this.labSEX.AutoSize = true;
            this.labSEX.Location = new System.Drawing.Point(59, 68);
            this.labSEX.Name = "labSEX";
            this.labSEX.Size = new System.Drawing.Size(29, 12);
            this.labSEX.TabIndex = 2;
            this.labSEX.Text = "性别";
            // 
            // labGREAD
            // 
            this.labGREAD.AutoSize = true;
            this.labGREAD.Location = new System.Drawing.Point(59, 108);
            this.labGREAD.Name = "labGREAD";
            this.labGREAD.Size = new System.Drawing.Size(29, 12);
            this.labGREAD.TabIndex = 1;
            this.labGREAD.Text = "年级";
            // 
            // labXM
            // 
            this.labXM.AutoSize = true;
            this.labXM.Location = new System.Drawing.Point(59, 34);
            this.labXM.Name = "labXM";
            this.labXM.Size = new System.Drawing.Size(29, 12);
            this.labXM.TabIndex = 0;
            this.labXM.Text = "姓名";
            // 
            // butoSave
            // 
            this.butoSave.Location = new System.Drawing.Point(166, 522);
            this.butoSave.Name = "butoSave";
            this.butoSave.Size = new System.Drawing.Size(90, 23);
            this.butoSave.TabIndex = 2;
            this.butoSave.Text = "保存";
            this.butoSave.UseVisualStyleBackColor = true;
            this.butoSave.Click += new System.EventHandler(this.butoSave_Click);
            // 
            // butoClean
            // 
            this.butoClean.Location = new System.Drawing.Point(262, 522);
            this.butoClean.Name = "butoClean";
            this.butoClean.Size = new System.Drawing.Size(90, 23);
            this.butoClean.TabIndex = 3;
            this.butoClean.Text = "清空";
            this.butoClean.UseVisualStyleBackColor = true;
            this.butoClean.Click += new System.EventHandler(this.butoClean_Click);
            // 
            // FrmUpdataInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 593);
            this.Controls.Add(this.butoClean);
            this.Controls.Add(this.butoSave);
            this.Controls.Add(this.gobYHJBXX);
            this.Controls.Add(this.gboYHZCXX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpdataInformation";
            this.Text = "编辑学生信息";
            this.Load += new System.EventHandler(this.FrmUpdataInformation_Load);
            this.gboYHZCXX.ResumeLayout(false);
            this.gboYHZCXX.PerformLayout();
            this.gobYHJBXX.ResumeLayout(false);
            this.gobYHJBXX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboYHZCXX;
        private System.Windows.Forms.Label labXH;
        private System.Windows.Forms.Label labPWD;
        private System.Windows.Forms.Label labQRMM;
        private System.Windows.Forms.TextBox tbxQRMM;
        private System.Windows.Forms.TextBox tbxMM;
        private System.Windows.Forms.TextBox tbxXH;
        private System.Windows.Forms.GroupBox gobYHJBXX;
        private System.Windows.Forms.RadioButton rBtMA;
        private System.Windows.Forms.RadioButton rBtWOMAN;
        private System.Windows.Forms.TextBox tbxNAME;
        private System.Windows.Forms.Label labSEX;
        private System.Windows.Forms.Label labGREAD;
        private System.Windows.Forms.Label labXM;
        private System.Windows.Forms.ComboBox cbBNianJi;
        private System.Windows.Forms.TextBox tBxPHONE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label labBirthday;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.DateTimePicker dTPBIRDAY;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button butoSave;
        private System.Windows.Forms.Button butoClean;
    }
}