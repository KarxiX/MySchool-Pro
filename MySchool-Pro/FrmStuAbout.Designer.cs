namespace MySchool_Pro
{
    partial class FrmStuAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStuAbout));
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.labBP = new System.Windows.Forms.Label();
            this.labCopyRight = new System.Windows.Forms.Label();
            this.labJSZC = new System.Windows.Forms.Label();
            this.llabGYYX = new System.Windows.Forms.LinkLabel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labTime = new System.Windows.Forms.Label();
            this.tData = new System.Windows.Forms.Timer(this.components);
            this.tChange = new System.Windows.Forms.Timer(this.components);
            this.imglAbout = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // picAbout
            // 
            this.picAbout.Location = new System.Drawing.Point(45, 81);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(160, 178);
            this.picAbout.TabIndex = 0;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // labBP
            // 
            this.labBP.AutoSize = true;
            this.labBP.BackColor = System.Drawing.Color.Transparent;
            this.labBP.Font = new System.Drawing.Font("微软雅黑", 9.25F, System.Drawing.FontStyle.Bold);
            this.labBP.Location = new System.Drawing.Point(233, 149);
            this.labBP.Name = "labBP";
            this.labBP.Size = new System.Drawing.Size(129, 19);
            this.labBP.TabIndex = 1;
            this.labBP.Text = "版权所有 :  北大青鸟";
            // 
            // labCopyRight
            // 
            this.labCopyRight.AutoSize = true;
            this.labCopyRight.BackColor = System.Drawing.Color.Transparent;
            this.labCopyRight.Font = new System.Drawing.Font("微软雅黑", 9.25F, System.Drawing.FontStyle.Bold);
            this.labCopyRight.Location = new System.Drawing.Point(233, 173);
            this.labCopyRight.Name = "labCopyRight";
            this.labCopyRight.Size = new System.Drawing.Size(165, 19);
            this.labCopyRight.TabIndex = 2;
            this.labCopyRight.Text = "Copyright : 2013 - 2022";
            // 
            // labJSZC
            // 
            this.labJSZC.AutoSize = true;
            this.labJSZC.BackColor = System.Drawing.Color.Transparent;
            this.labJSZC.Font = new System.Drawing.Font("微软雅黑", 9.25F, System.Drawing.FontStyle.Bold);
            this.labJSZC.Location = new System.Drawing.Point(233, 198);
            this.labJSZC.Name = "labJSZC";
            this.labJSZC.Size = new System.Drawing.Size(73, 19);
            this.labJSZC.TabIndex = 3;
            this.labJSZC.Text = "技术支持 : ";
            // 
            // llabGYYX
            // 
            this.llabGYYX.ActiveLinkColor = System.Drawing.Color.PaleTurquoise;
            this.llabGYYX.AutoSize = true;
            this.llabGYYX.BackColor = System.Drawing.Color.Transparent;
            this.llabGYYX.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llabGYYX.LinkColor = System.Drawing.Color.Black;
            this.llabGYYX.Location = new System.Drawing.Point(298, 198);
            this.llabGYYX.Name = "llabGYYX";
            this.llabGYYX.Size = new System.Drawing.Size(188, 19);
            this.llabGYYX.TabIndex = 4;
            this.llabGYYX.TabStop = true;
            this.llabGYYX.Text = "StudentMis@JadeBird.com";
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Transparent;
            this.buttonOK.Location = new System.Drawing.Point(382, 246);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(92, 28);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.BackColor = System.Drawing.Color.Transparent;
            this.labTime.Location = new System.Drawing.Point(333, 323);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(0, 19);
            this.labTime.TabIndex = 6;
            // 
            // tData
            // 
            this.tData.Enabled = true;
            this.tData.Interval = 1000;
            this.tData.Tick += new System.EventHandler(this.tData_Tick);
            // 
            // tChange
            // 
            this.tChange.Enabled = true;
            this.tChange.Interval = 1;
            this.tChange.Tick += new System.EventHandler(this.tChange_Tick);
            // 
            // imglAbout
            // 
            this.imglAbout.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglAbout.ImageStream")));
            this.imglAbout.TransparentColor = System.Drawing.Color.Transparent;
            this.imglAbout.Images.SetKeyName(0, "girl_1.gif");
            this.imglAbout.Images.SetKeyName(1, "girl_2.gif");
            this.imglAbout.Images.SetKeyName(2, "girl_3.gif");
            this.imglAbout.Images.SetKeyName(3, "girl_4.gif");
            // 
            // FrmStuAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::MySchool_Pro.Properties.Resources.aboug_bj;
            this.ClientSize = new System.Drawing.Size(560, 342);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.llabGYYX);
            this.Controls.Add(this.labJSZC);
            this.Controls.Add(this.labCopyRight);
            this.Controls.Add(this.labBP);
            this.Controls.Add(this.picAbout);
            this.Font = new System.Drawing.Font("微软雅黑", 9.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "FrmStuAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于我们";
            this.Load += new System.EventHandler(this.FrmStuAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.Label labBP;
        private System.Windows.Forms.Label labCopyRight;
        private System.Windows.Forms.Label labJSZC;
        private System.Windows.Forms.LinkLabel llabGYYX;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Timer tData;
        private System.Windows.Forms.Timer tChange;
        private System.Windows.Forms.ImageList imglAbout;
    }
}