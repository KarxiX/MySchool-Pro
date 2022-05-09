using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool_Pro
{
    public partial class FrmSeachByName : Form
    {
        public FrmSeachByName()
        {
            InitializeComponent();
        }

        private void FrmSeachByName_Load(object sender, EventArgs e)
        {
            ShowStudentByName();
        }
        /// <summary>
        /// 根据学员姓名展示信息
        /// </summary>
        private void ShowStudentByName()
        {
            //清除列表项
            LvStudentList.Items.Clear();
            //获取学员姓名
            string name = tbName.Text;
            //定义SQL语句
            string sql = $"SELECT S.StudentNo,S.StudentName,S.Gender,G.GradeName,S.Email,s.Phone FROM Student S INNER JOIN Grade G ON S.GradeId = G.GradeId WHERE S.StudentName LIKE '%{name}%'";
            //执行>配合读取一行的形式
            SqlDataReader r = DBHelper.ExecuteReader(sql);
            //开始循环读取
            while(r!=null && r.HasRows && r.Read())
            {
                //创建列表项
                ListViewItem lvi = new ListViewItem();
                lvi.Text = r["StudentNo"].ToString();
                //绑定子集
                lvi.SubItems.Add(r["StudentName"].ToString());
                string sex = Convert.ToInt32(r["Gender"]) == 0 ? "女生" : "男生";
                lvi.SubItems.Add(sex);
                lvi.SubItems.Add(r["GradeName"].ToString());
                lvi.SubItems.Add(r["Email"].ToString());
                lvi.SubItems.Add(r["Phone"].ToString());
                //将创建的列表项添加到ListView控件中
                LvStudentList.Items.Add(lvi);
            }
            if (r != null)
            {
                r.Close();
            }

        }

        private void btoChaXun_Click(object sender, EventArgs e)
        {
            ShowStudentByName();
        }
        /// <summary>
        /// 删除学员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private void DeleteStudent()
        {
            //判断lv控件是否有选择的项
            if (LvStudentList.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要删除的学员数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }   
                //获取学号信息
                string No = LvStudentList.SelectedItems[0].SubItems[0].Text;
                DialogResult r = MessageBox.Show($"您确定要删除学号;{No}的学员信息吗","WORRING",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
               
            if (r != DialogResult.OK)
            {
                return;
            }

            //编写SQL语句
            string sqls = $"Delete from Student where [StudentNo] ={No}";
            //使用DBHelper工具完成删除操作
            bool res= DBHelper.ExecuteNonQuery(sqls);
            //判断是否成功 返回结果 True:成功 False:失败
            if (res)
            {
                MessageBox.Show("该学员已删除!","提示!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("出现了一点小问题....","ERROR",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            //刷新页面
            ShowStudentByName();

        }
    }
}
