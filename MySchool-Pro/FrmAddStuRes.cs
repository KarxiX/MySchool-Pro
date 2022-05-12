using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool_Pro
{
    public partial class FrmAddStuRes : Form
    {
        public FrmAddStuRes()
        {
            InitializeComponent();
        }
        //创建公有属性
        public string StuNos { get; set; }
        /// <summary>
        /// 窗体加载时 加载两个方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddStuRes_Load(object sender, EventArgs e)
        {
            //查询所有科目方法
            LoadSubject();
            //查询选中学生的考试信息
            LoadStuResByStuNo();
        }

        private void LoadStuResByStuNo()
        {
            //创建三表联查语句
            string sql = string.Format($"SELECT U.StudentName,S.SubjectName,R.StudentResult,R.ExamDate FROM [Result] R INNER JOIN [Subject] AS S ON R.SubjectId  =  S.SubjectId INNER JOIN [Student] AS U ON U.StudentNo  =  R.StudentNo WHERE R.StudentNo  = {StuNos}");
            DataTable data = DBHelper.GetTable(sql);
            //不许控件创建新的行列
            dGVStuRes.AutoGenerateColumns = false;
            //绑定数据源到dGVStuRes控件
            dGVStuRes.DataSource = data;
        }

        /// <summary>
        /// 查询并显示所有学生考试信息到dGVStuRes控件中
        /// </summary>
        private void LoadStuRes()
        {
            //创建三表联查语句
            string sql = string.Format($"SELECT U.StudentName,S.SubjectName,R.StudentResult,R.ExamDate FROM [Result] R INNER JOIN[Subject] AS S ON R.SubjectId = S.SubjectId INNER JOIN[Student] AS U ON U.StudentNo =  R.StudentNo");
            DataTable data = DBHelper.GetTable(sql);
            //不许控件创建新的行列
            dGVStuRes.AutoGenerateColumns = false;
            //绑定数据源到dGVStuRes控件
            dGVStuRes.DataSource = data;
        }

        /// <summary>
        /// 查询所有科目方法
        /// </summary>
        private void LoadSubject()
        {
            //创建sql语句
            string sql = "SELECT SubjectId,SubjectName FROM [Subject] UNION SELECT 0 ,'所有科目'";
            DataTable table = DBHelper.GetTable(sql);
            cBoSubject.DisplayMember = "SubjectName";
            cBoSubject.ValueMember = "SubjectId";
            //绑定数据源
            cBoSubject.DataSource = table;
        }

        private void butoFH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butShowAllRes_Click(object sender, EventArgs e)
        {
            // 查询并显示所有学生考试信息到dGVStuRes控件中
            LoadStuRes();
        }

        private void butSaveRes_Click(object sender, EventArgs e)
        {
            //定义 sr:生日 Stuno:学号 的string数据
            string ksrq,StuNoss;
            //定义 nianji:年级 Res:考试成绩 的int数据
            int nianji, Res;
            StuNoss = StuNos.ToString();//通过传递的值获取学号
            Res = Convert.ToInt32(tBoRes.Text);//tBoRes 文本框控件获取考试成绩数据
            nianji = Convert.ToInt32(cBoSubject.SelectedValue);//cBoSubject下拉框控件获取年级数据
            ksrq = dTPExamDate.Value.ToString();//通过dTPExamDate DateTimePicker控件获取生日数据

            //数据获取完毕 开始插入数据操作 -创建SQL语句
            string sql = $"INSERT INTO [Result](StudentNo, SubjectId, StudentResult, ExamDate) VALUES ('{StuNoss}','{nianji}','{Res}','{ksrq}')";
            bool ress = DBHelper.ExecuteNonQuery(sql);
            //判断操作是否成功
            if (ress)
            {
                MessageBox.Show("新增信息成功!", "Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadStuResByStuNo();
            }
            else
            { 
                MessageBox.Show("新增信息失败!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
