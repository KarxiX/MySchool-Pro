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
    public partial class FrmStuAbout : Form
    {
        public FrmStuAbout()
        {
            InitializeComponent();
        }
        int index = 0;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 每隔一秒执行一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tData_Tick(object sender, EventArgs e)
        {
            string data = DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss");
            labTime.Text = $"当前日期:{data}";
        }

        /// <summary>
        /// 自动切换图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tChange_Tick(object sender, EventArgs e)
        {
            index++;
            if(index >= imglAbout.Images.Count)
            {
                index = 0;
            }
            picAbout.Image = imglAbout.Images[index];

        }

        private void FrmStuAbout_Load(object sender, EventArgs e)
        {
            picAbout.Image = imglAbout.Images[0];
        }

        private void picAbout_Click(object sender, EventArgs e)
        {
            tChange.Stop();//停止定时器  等价 tChange.Enabled = false;


            tChange.Start();//打开定时器 等价 tChange.Enabled = true;

        }
    }
}
