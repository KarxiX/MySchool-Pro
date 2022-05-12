using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool_Pro.AdminFrom
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void Admin_MouseClick(object sender, MouseEventArgs e)
        {
           
                if (this.BackColor == Color.Black)
                {
                    this.BackColor = Color.Yellow;
                }
                else if (this.BackColor == Color.Yellow)
                {
                    this.BackColor = Color.Green;
                }
                else if (this.BackColor == Color.Green)
                {
                    this.BackColor = Color.Red;
                }
                else if (this.BackColor == Color.Red)
                {
                    this.BackColor = Color.Black;
                }

           
        }
        /// <summary>
        /// 单击事件 打开新增学生信息的窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtXJXS_Click_1(object sender, EventArgs e)
        {
            FrmUpdataInformation ft = new FrmUpdataInformation();
            ft.MdiParent = this;
            ft.Show();
        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//退出窗体时关闭应用程序
        }
        /// <summary>
        /// 点击时事件 打开查询新窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtXMCX_Click(object sender, EventArgs e)
        {
            FrmSeachByName frmSeachByName = new FrmSeachByName();
            frmSeachByName.MdiParent = this;//结业考试重点 指定Mdi父容器
            frmSeachByName.Show();
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStuAbout frmStuAbout = new FrmStuAbout();
            frmStuAbout.MdiParent = this;   
            frmStuAbout.Show();
        }
        /// <summary>
        /// 按年级查询信息方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtNJCX_Click(object sender, EventArgs e)
        {
            FrmSearchByGrade frmSearchByGrade = new FrmSearchByGrade();
            frmSearchByGrade.MdiParent = this; 
            frmSearchByGrade.Show();
        }
    }
}
