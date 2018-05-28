namespace Monitor
{
    partial class frmSee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSee));
            this.lblCPUID = new System.Windows.Forms.Label();
            this.lbl_CPUID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_CountyName = new System.Windows.Forms.Label();
            this.lbl_CityName = new System.Windows.Forms.Label();
            this.lbl_SchoolName = new System.Windows.Forms.Label();
            this.lblCountyName = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_Num = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblOrderProcess = new System.Windows.Forms.Label();
            this.dgvProcess = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.show = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCPUID
            // 
            this.lblCPUID.AutoSize = true;
            this.lblCPUID.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCPUID.Location = new System.Drawing.Point(29, 107);
            this.lblCPUID.Name = "lblCPUID";
            this.lblCPUID.Size = new System.Drawing.Size(96, 16);
            this.lblCPUID.TabIndex = 8;
            this.lblCPUID.Text = "CPU序列号：";
            // 
            // lbl_CPUID
            // 
            this.lbl_CPUID.AutoSize = true;
            this.lbl_CPUID.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CPUID.Location = new System.Drawing.Point(30, 133);
            this.lbl_CPUID.Name = "lbl_CPUID";
            this.lbl_CPUID.Size = new System.Drawing.Size(64, 16);
            this.lbl_CPUID.TabIndex = 7;
            this.lbl_CPUID.Text = "label10";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_CountyName);
            this.groupBox1.Controls.Add(this.lblCPUID);
            this.groupBox1.Controls.Add(this.lbl_CPUID);
            this.groupBox1.Controls.Add(this.lbl_CityName);
            this.groupBox1.Controls.Add(this.lbl_SchoolName);
            this.groupBox1.Controls.Add(this.lblCountyName);
            this.groupBox1.Controls.Add(this.lblCityName);
            this.groupBox1.Controls.Add(this.lblSchoolName);
            this.groupBox1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(67, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 243);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "本机注册信息";
            // 
            // lbl_CountyName
            // 
            this.lbl_CountyName.AutoSize = true;
            this.lbl_CountyName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CountyName.Location = new System.Drawing.Point(111, 55);
            this.lbl_CountyName.Name = "lbl_CountyName";
            this.lbl_CountyName.Size = new System.Drawing.Size(56, 16);
            this.lbl_CountyName.TabIndex = 10;
            this.lbl_CountyName.Text = "label3";
            // 
            // lbl_CityName
            // 
            this.lbl_CityName.AutoSize = true;
            this.lbl_CityName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CityName.Location = new System.Drawing.Point(105, 28);
            this.lbl_CityName.Name = "lbl_CityName";
            this.lbl_CityName.Size = new System.Drawing.Size(56, 16);
            this.lbl_CityName.TabIndex = 9;
            this.lbl_CityName.Text = "label2";
            // 
            // lbl_SchoolName
            // 
            this.lbl_SchoolName.AutoSize = true;
            this.lbl_SchoolName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SchoolName.Location = new System.Drawing.Point(103, 82);
            this.lbl_SchoolName.Name = "lbl_SchoolName";
            this.lbl_SchoolName.Size = new System.Drawing.Size(56, 16);
            this.lbl_SchoolName.TabIndex = 11;
            this.lbl_SchoolName.Text = "label5";
            // 
            // lblCountyName
            // 
            this.lblCountyName.AutoSize = true;
            this.lblCountyName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCountyName.Location = new System.Drawing.Point(29, 55);
            this.lblCountyName.Name = "lblCountyName";
            this.lblCountyName.Size = new System.Drawing.Size(88, 16);
            this.lblCountyName.TabIndex = 2;
            this.lblCountyName.Text = "区/县 名：";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCityName.Location = new System.Drawing.Point(30, 28);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(88, 16);
            this.lblCityName.TabIndex = 1;
            this.lblCityName.Text = "城 市 名：";
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSchoolName.Location = new System.Drawing.Point(28, 82);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(88, 16);
            this.lblSchoolName.TabIndex = 2;
            this.lblSchoolName.Text = "学校名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbl_Num);
            this.groupBox2.Controls.Add(this.lblnum);
            this.groupBox2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(351, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 53);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "正在运行的电脑的进程信息";
            // 
            // lbl_Num
            // 
            this.lbl_Num.AutoSize = true;
            this.lbl_Num.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Num.Location = new System.Drawing.Point(230, 27);
            this.lbl_Num.Name = "lbl_Num";
            this.lbl_Num.Size = new System.Drawing.Size(56, 16);
            this.lbl_Num.TabIndex = 9;
            this.lbl_Num.Text = "label2";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblnum.Location = new System.Drawing.Point(36, 27);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(200, 16);
            this.lblnum.TabIndex = 1;
            this.lblnum.Text = "当前本校运行的电脑数量：";
            // 
            // lblOrderProcess
            // 
            this.lblOrderProcess.AutoSize = true;
            this.lblOrderProcess.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderProcess.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOrderProcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrderProcess.Location = new System.Drawing.Point(349, 111);
            this.lblOrderProcess.Name = "lblOrderProcess";
            this.lblOrderProcess.Size = new System.Drawing.Size(77, 14);
            this.lblOrderProcess.TabIndex = 11;
            this.lblOrderProcess.Text = "当前软件：";
            // 
            // dgvProcess
            // 
            this.dgvProcess.AllowUserToAddRows = false;
            this.dgvProcess.AllowUserToDeleteRows = false;
            this.dgvProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcess.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcess.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProcess.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvProcess.Location = new System.Drawing.Point(351, 130);
            this.dgvProcess.MultiSelect = false;
            this.dgvProcess.Name = "dgvProcess";
            this.dgvProcess.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcess.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProcess.RowHeadersWidth = 50;
            this.dgvProcess.RowTemplate.Height = 23;
            this.dgvProcess.RowTemplate.ReadOnly = true;
            this.dgvProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcess.Size = new System.Drawing.Size(286, 161);
            this.dgvProcess.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRefresh.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Location = new System.Drawing.Point(562, 310);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "江苏省教育电脑检测平台";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // show
            // 
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(100, 22);
            this.show.Text = "显示";
            // 
            // frmSee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Monitor.Properties.Resources.showpage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 361);
            this.Controls.Add(this.lblOrderProcess);
            this.Controls.Add(this.dgvProcess);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信息一览";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSee_FormClosing);
            this.Load += new System.EventHandler(this.frmSee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcess)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCountyName;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lbl_CPUID;
        private System.Windows.Forms.Label lbl_CountyName;
        private System.Windows.Forms.Label lbl_CityName;
        private System.Windows.Forms.Label lblCPUID;
        private System.Windows.Forms.Label lbl_SchoolName;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_Num;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.DataGridView dgvProcess;
        private System.Windows.Forms.Label lblOrderProcess;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem show;
    }
}