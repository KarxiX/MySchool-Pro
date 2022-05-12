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
    public partial class FrmSearchByGrade : Form
    {

        public static FrmSearchByGrade frmSearchByGrade;
        
        public FrmSearchByGrade()
        {
            InitializeComponent();
            frmSearchByGrade = this;
        }

        private void FrmSearchByGrade_Load(object sender, EventArgs e)
        {
            LoadGread();
            //根据年级查询学生数据
            LoadStuForGrade();
        }

        //根据年级查询学生数据的方法
        private void LoadStuForGrade()
        {
            //查询全部学员的SQL语句
            string sql = "SELECT StudentNo, StudentName, Gender, Birthday FROM [Student] WHERE 1 = 1  ";
            int gid = Convert.ToInt32(cBNJ.SelectedValue);
            //判断是否为查询全部
            if (gid != 0)
            {
                sql += $"  AND GradeId = {gid}";
            }
            //执行SQL语句
            DataTable data = DBHelper.GetTable(sql);

            //禁止DGV控件自动创建新行列
            dGVList.AutoGenerateColumns = false;

            //将查询数据显示在dgv控件中
            dGVList.DataSource = data;
        }

        /// <summary>
        /// 加载年级信息
        /// </summary>
        public void LoadGread()
        {
            string sql = "SELECT * FROM Grade UNION SELECT 0 ,'所有年级'";
            DataTable data= DBHelper.GetTable(sql);
            cBNJ.DisplayMember ="GradeName";
            cBNJ.ValueMember = "GradeID";
            cBNJ.DataSource = data;
        }

        private void btoSearch_Click(object sender, EventArgs e)
        {
            LoadStuForGrade();
        }

        /// <summary>
        /// 下拉框项更改时触发的事件 调用年级查询学生数据的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBNJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStuForGrade();
        }
        /// <summary>
        /// 删除学生信息的方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //判断控件是否有选择的项
            if (dGVList.SelectedRows.Count== 0)
            {
                MessageBox.Show("请选择要删除的学员数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            GreadDeleteStu();

            //重新加载页面
            LoadGread();
        }


        /// <summary>
        ///年级查询内删除学生的方法 
        /// </summary>
        private void GreadDeleteStu()
        {
            //获取学号
            string No = dGVList.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult r = MessageBox.Show($"您确定要删除学号;{No}的学员信息吗", "WORRING", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //取消删除操作
            if (r != DialogResult.OK)
            {
                return;
            }

            //编写SQL语句
            string sqls = $"Delete from Student where [StudentNo] ={No}";
            //使用DBHelper工具完成删除操作
            bool res = DBHelper.ExecuteNonQuery(sqls);
            //判断是否成功 返回结果 True:成功 False:失败
            if (res)
            {
                MessageBox.Show("该学员已删除!", "提示!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("出现了一点小问题....", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 修改学生信息方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取学号
            string no = dGVList.SelectedRows[0].Cells[0].Value.ToString();

            //打开信息编辑窗体
            FrmUpdataInformation frm = new FrmUpdataInformation();
            frm.StuNo = no;
            frm.ShowDialog();
            
        }

        private void 添加成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStuRes frmAdd = new FrmAddStuRes();
            string NO = dGVList.SelectedRows[0].Cells[0].Value.ToString();
            frmAdd.StuNos = NO; 
            frmAdd.Show();
        }
    }
}
