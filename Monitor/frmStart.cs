using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Permissions;
using static Monitor.frmRegister;
using System.Diagnostics;

namespace Monitor
{
    public partial class frmStart : Form
    {

        // 定义必要的数据操作对象
        Process[] myProcess = Process.GetProcesses();
        int rowsDeleted = 9999;
        Database mDB = new Database("other");


        public frmStart()
        {
            InitializeComponent();
        }




        private void frmStart_Load(object sender, EventArgs e)
        {
          /*  String sqlString = "insert  into  tClass(schoolID,classFun) values('ABCD','学生用机房')";
            rowsDeleted = mDB.ExecuteSQL(sqlString);
            mDB.Close();
            MessageBox.Show("学校编号：ABCD,教室功能：学生用机房");*/
            
            RegistryKey rsg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft", true);        //true表可以修改  //这里跟网上千篇一律的代码不同，把LocalMachine修改成了CurrentUser
            if (rsg.GetValue("城市编号") != null)
            {   //说明已注册过，则实现写入进程信息的功能

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
                // 操作完毕关闭数据库通道
                mDB.Close();


                //关闭注册表
                rsg.Close();

                //进入信息显示页面
                timer2.Enabled = true;
            }
            else timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister FrmMain = new frmRegister();
            FrmMain.Show();
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
            frmSee frmsee = new frmSee();
            frmsee.Show();
            timer2.Enabled = false;
        }
    }
}
