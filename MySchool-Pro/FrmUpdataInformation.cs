using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MySchool_Pro
{
    public partial class FrmUpdataInformation : Form
    {
        public FrmUpdataInformation()
        {
            InitializeComponent();
        }

        

        /// <summary>
        /// 接收用户输入信息 并借助DBHelp工具
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butoSave_Click(object sender, EventArgs e)
        {
            string mm = tbxMM.Text;  //接收密码
            string qrmm = tbxQRMM.Text;//接收确认密码
            string name = tbxNAME.Text;//接收姓名
            int sex = rBtWOMAN.Checked ? 0 : 1;//选择 true为0 false为1(男性)
            int nianji = Convert.ToInt32(cbBNianJi.SelectedValue);//接收年级
            string phone = tBxPHONE.Text;//接收电话
            string address = tbxAddress.Text;//接收地址
            string sr = dTPBIRDAY.Value.ToString();//接收生日信息
            string Email = tbxEmail.Text;//接收电子邮件信息
            if (string.IsNullOrEmpty(mm) ||
                string.IsNullOrEmpty(qrmm) ||
                string.IsNullOrEmpty(name) ||//信息的非空判断
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(sr) ||
                string.IsNullOrEmpty(Email))

            {
                //有空值 输出错误信息
                MessageBox.Show("你输入的信息不完整!", "请检查信息是否有遗漏!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (mm.Equals(qrmm))//密码与确认密码一致 进入下一步
            {
                //编辑sql语句
                string sql = string.Format(@"INSERT INTO [Student] (LoginPwd, StudentName, Gender, GradeId, Phone, Address, Birthday, Email)
                                            VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", mm, name, sex, nianji, phone, address, sr, Email);
                bool res = DBHelper.ExecuteNonQuery(sql);//返回 true 或者 false 是否成功的判断条件
                if (res)//添加成功
                {
                    //输出信息并且清空输入的旧信息
                    MessageBox.Show("添加成功", "返回结果:" + res, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxAddress.Clear();
                    tbxEmail.Clear();
                    tbxMM.Clear();
                    tbxNAME.Clear();
                    tbxQRMM.Clear();
                    tbxXH.Clear();
                    tBxPHONE.Clear();
                    rBtWOMAN.Checked = true;
                    cbBNianJi.SelectedIndex = 0;
                    dTPBIRDAY.Value = DateTime.Now;
                }
                else//添加失败
                {
                    //输出错误信息 不清空旧输入 方便用户修改
                    MessageBox.Show("添加失败", "返回结果" + res, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// 清空按钮的验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butoClean_Click(object sender, EventArgs e)
        {
            //接收用户选择
            DialogResult res = MessageBox.Show("您确定要清空吗?", "确认您的选择", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)//用户确认清空
            {
                tbxAddress.Clear();
                tbxEmail.Clear();
                tbxMM.Clear();
                tbxNAME.Clear();//清空输入的信息
                tbxQRMM.Clear();
                tbxXH.Clear();
                tBxPHONE.Clear();
                rBtWOMAN.Checked = true;
                cbBNianJi.SelectedIndex = 0;
                dTPBIRDAY.Value = DateTime.Now;
            }

        }

        private void FrmUpdataInformation_Load(object sender, EventArgs e)
        {
            //下拉框控件的绑定(年级)
            string SQL = "select * from Grade union select 0,'请选择'";
            DataTable data= DBHelper.GetTable(SQL);
            cbBNianJi.DisplayMember = "GradeName";
            cbBNianJi.ValueMember = "GradeId";
            cbBNianJi.DataSource = data;
        }

    }
}
