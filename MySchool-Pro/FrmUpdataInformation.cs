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
using System.Data.SqlClient;

namespace MySchool_Pro
{
    public partial class FrmUpdataInformation : Form
    {
        private string stuNo;

        public FrmUpdataInformation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取学员编号 下一步传递
        /// </summary>
        public string StuNo { get => stuNo; set => stuNo = value; }



        /// <summary>
        /// 接收用户输入信息 并借助DBHelp工具实现修改与新增操作
        /// 保存按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butoSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StuNo))
            {
                //新增
                NewAddStudent();
            }
            else  //执行修改
            {
                UpdateStuHANSHU();
            }
            string UpdataStuZIUDAN()
            {
                string Dlmm = tbxMM.Text;  //接收密码
                string StuNa = tbxNAME.Text;//接收姓名
                int Sex = rBtWOMAN.Checked ? 0 : 1;//选择 true为0 false为1(男性)
                int Grade = Convert.ToInt32(cbBNianJi.SelectedValue);//接收年级
                string Phone = tBxPHONE.Text;//接收电话
                string Address = tbxAddress.Text;//接收地址
                string Birthday = dTPBIRDAY.Value.ToString();//接收生日信息
                string Email = tbxEmail.Text;//接收电子邮件信息
                string sqlxg = $"UPDATE [Student] SET LoginPwd='{Dlmm}', StudentName='{StuNa}', Gender='{Sex}', GradeId ='{Grade}',Phone='{Phone}', Address ='{Address}',Birthday='{Birthday}', Email= '{Email}' WHERE StudentNo = '{StuNo}'";//修改的SQL语句 
                return sqlxg;
            }
            void UpdateStuHANSHU()
            {
                //创建修改SQL语句
                string sqlxg = UpdataStuZIUDAN();

                //执行修改操作
                bool res = DBHelper.ExecuteNonQuery(sqlxg);

                //判断修改是否成功!
                if (res)
                {
                    MessageBox.Show("修改成功!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmSeachByName.frmSeachByName.ShowStudentByName();
                }
                if (!res)
                {
                    MessageBox.Show("修改失败", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //关闭窗体,刷新数据
                if (FrmSeachByName.frmSeachByName != null)
                {
                    FrmSeachByName.frmSeachByName.ShowStudentByName();
                }
                Close();
            }
        }


        /// <summary>
        /// 新增学生方法
        /// </summary>
        private void NewAddStudent()
        {
            string mm, qrmm, name, phone, address, sr, Email;
            int sex, nianji;
            UserSHURUZIDUAN();
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
                    ClearAllData();
                }
                else//添加失败
                {
                    //输出错误信息 不清空旧输入 方便用户修改
                    MessageBox.Show("添加失败", "返回结果" + res, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //接收用户输入的字段
            void UserSHURUZIDUAN()
            {
                mm = tbxMM.Text;
                qrmm = tbxQRMM.Text;
                name = tbxNAME.Text;
                sex = rBtWOMAN.Checked ? 0 : 1;
                nianji = Convert.ToInt32(cbBNianJi.SelectedValue);
                phone = tBxPHONE.Text;
                address = tbxAddress.Text;
                sr = dTPBIRDAY.Value.ToString();
                Email = tbxEmail.Text;
                //接收电子邮件信息
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
                ClearAllData();
            }

        }

        /// <summary>
        /// 清理数据方法
        /// </summary>
        private void ClearAllData()
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

        /// <summary>
        /// 通过学号获取学员信息 并显示到页面上
        /// </summary>
        private void FrmUpdataInformation_Load(object sender, EventArgs e)
        {
            //下拉框控件的绑定(年级)
            LoadGrad();
            //如果StuNo为空 退出操作
            if (string.IsNullOrEmpty(StuNo))
            {
                return;
            }
            tbxXH.Text = StuNo;
            LoadStuInfoByStuNo();
        }



        //展示信息方法
        private void LoadStuInfoByStuNo()
        {
            string sql = $"SELECT * FROM [Student] WHERE [StudentNo] = '{StuNo}'";
            SqlDataReader reader = DBHelper.ExecuteReader(sql);
            if (reader != null && reader.HasRows && reader.Read())
            {
                tbxMM.Text = reader["LoginPwd"].ToString();
                tbxQRMM.Text = reader["LoginPwd"].ToString();
                tbxNAME.Text = reader["StudentName"].ToString();
                int sex = Convert.ToInt32(reader["Gender"]);
                rBtMA.Checked = true;
                if (sex == 0)
                {
                    rBtWOMAN.Checked = true;
                }
                tBxPHONE.Text = reader["Phone"].ToString();
                tbxAddress.Text = reader["Address"].ToString();
                tbxEmail.Text = reader["Email"].ToString();
                cbBNianJi.SelectedValue = reader["GradeId"].ToString();
                dTPBIRDAY.Value = Convert.ToDateTime(reader["Birthday"]);
                reader.Close();
            }
        }

        /// <summary>
        /// 加载年级的方法
        /// </summary>
        private void LoadGrad()
        {
            //下拉框控件的绑定(年级)
            string SQL = "select * from Grade union select 0,'请选择'";
            DataTable data = DBHelper.GetTable(SQL);
            cbBNianJi.DisplayMember = "GradeName";
            cbBNianJi.ValueMember = "GradeId";
            cbBNianJi.DataSource = data;
        }
    }
}
