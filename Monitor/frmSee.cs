using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Monitor.frmRegister;

namespace Monitor
{
    
    /// <summary>
    /// 信息一览
    /// </summary>
    public partial class frmSee : Form
    {

      
        Database mDB = new Database("other");
        Process[] myProcess = Process.GetProcesses();
        int rowsDeleted = 9999;

        public frmSee()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 加载时从全局变量中读取已写入的信息，以及从数据库中统计出来的整体信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSee_Load(object sender, EventArgs e)
        {
            RegistryKey rsg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft", true);
            //城市信息
            lbl_CityName.Text = rsg.GetValue("城市名").ToString();                      //城市名
            lbl_CountyName.Text = rsg.GetValue("区/县名").ToString();                    //区县名

            //学校信息
            lbl_SchoolName.Text = rsg.GetValue("学校名称").ToString();                   //学校名称

            //教室信息
            lbl_CPUID.Text = rsg.GetValue("CPU序列号").ToString();                               //CPU序列号

          

            //访问数据库，显示用户机器数量           
          
            String sqlString = "select count(distinct cpuID) from tAppInformation where DateDiff(dd,logTime,getdate())=0";    //查询当天的记录
            lbl_Num.Text = mDB.ExecuteSQL(sqlString).ToString();

            DataSet ds = mDB.GetDataSet("SELECT appName as 进程名称, count(*) as 次数  FROM tAppInformation group by appname order by 次数 DESC ");
            dgvProcess.DataSource = ds.Tables[0];
            for(int i = 1; i <= dgvProcess.Rows.Count; i++) { 
               dgvProcess.Rows[i-1].HeaderCell.Value = i.ToString();
            }
        }



        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            String sqlString = "select count(distinct cpuID) from tAppInformation where DateDiff(dd,logTime,getdate())=0";    //查询当天的记录
            lbl_Num.Text = mDB.ExecuteSQL(sqlString).ToString();

            DataSet ds = mDB.GetDataSet("SELECT appName as 进程名称, count(*) as 次数  FROM tAppInformation group by appname order by 次数 DESC  ");
            dgvProcess.DataSource = ds.Tables[0];
            for (int i = 1; i <= dgvProcess.Rows.Count; i++)
            {
                dgvProcess.Rows[i - 1].HeaderCell.Value = i.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RegistryKey rsg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft", true);
            //读取本机进程信息并写入数据库中
            foreach (Process p in myProcess)
            {
                //存储过程
                string phicM = string.Format("{0:###,##0.00}MB", p.WorkingSet64 / 1024.0f / 1024.0f);
                String sqlString = "insert into tAppInformation(cpuID,processID,appName,storage,startTime,fileName) values('" + rsg.GetValue("CPU序列号").ToString() + "','" + p.Id + "','" + p.ProcessName + "','" + phicM;

                //有些进程无法获取启动时间和文件名信息，所以要用try/catch
                try
                {
                    // sqlString += ","+p.StartTime+","+p.MainModule.FileName;
                    sqlString += "','" + p.StartTime + "','" + p.MainModule.FileName + "')";
                }
                catch
                {
                    // sqlString += ",0,0";
                    sqlString += "','  ','  '";
                }
                rowsDeleted = mDB.ExecuteSQL(sqlString);
            }
            MessageBox.Show("已写入！");
        }

        private void frmSee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)                //当用户点击窗体右上角X按钮或(Alt + F4)时 发生
            {
                e.Cancel = true;
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
