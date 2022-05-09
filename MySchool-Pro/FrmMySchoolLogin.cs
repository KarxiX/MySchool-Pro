using MySchool_Pro.AdminFrom;
using System;
using System.Windows.Forms;

namespace MySchool_Pro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("您确定要退出登录吗?", "确认您的选择", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        public void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (this.textName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("错误!请输入用户名", "错误!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textName.Focus();
                return;
            }
            else if (this.texPWD.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("错误!请输入密码", "错误!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.texPWD.Focus();
                return;
            }
            else if (this.comBoxLeixing.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("错误!请选择登录类型", "错误!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comBoxLeixing.Focus();
                return;
            }
            string sql = string.Format("SELECT COUNT(0) FROM Admin WHERE LoginId='{0}' AND LoginPwd='{1}'", this.textName.Text.Trim(), this.texPWD.Text.Trim());
            int count = Convert.ToInt32(DBHelper.ExecuteScalar(sql));
            if (count == 0)
            {
                textName.Clear();
                texPWD.Clear();
                MessageBox.Show("请输入正确的账号密码", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            //if (this.comBoxLeixing.Text.Equals("管理员登录"))
            //{
            FrmAdmin frmadmin = new FrmAdmin();
            frmadmin.Show();
            //隐藏窗体
            this.Hide();
            //} 
        }
    }
}
