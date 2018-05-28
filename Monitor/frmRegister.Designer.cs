namespace Monitor
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCityName = new System.Windows.Forms.TextBox();
            this.cmbCityID = new System.Windows.Forms.ComboBox();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.lblCountyName = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblCityID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSchoolID = new System.Windows.Forms.TextBox();
            this.cmbSchoolQuality = new System.Windows.Forms.ComboBox();
            this.cmbSchoolKind = new System.Windows.Forms.ComboBox();
            this.cmbSchoolName = new System.Windows.Forms.ComboBox();
            this.lblSchoolQuality = new System.Windows.Forms.Label();
            this.lblSchoolKind = new System.Windows.Forms.Label();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblSchoolID = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbClassFun = new System.Windows.Forms.ComboBox();
            this.lblClassAddress = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.ntIShow = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbCityName);
            this.groupBox1.Controls.Add(this.cmbCityID);
            this.groupBox1.Controls.Add(this.cmbCounty);
            this.groupBox1.Controls.Add(this.lblCountyName);
            this.groupBox1.Controls.Add(this.lblCityName);
            this.groupBox1.Controls.Add(this.lblCityID);
            this.groupBox1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(68, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "地区信息";
            // 
            // cmbCityName
            // 
            this.cmbCityName.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCityName.Location = new System.Drawing.Point(379, 22);
            this.cmbCityName.Name = "cmbCityName";
            this.cmbCityName.Size = new System.Drawing.Size(118, 23);
            this.cmbCityName.TabIndex = 8;
            // 
            // cmbCityID
            // 
            this.cmbCityID.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCityID.FormattingEnabled = true;
            this.cmbCityID.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "J",
            "K",
            "L",
            "M",
            "N"});
            this.cmbCityID.Location = new System.Drawing.Point(102, 22);
            this.cmbCityID.Name = "cmbCityID";
            this.cmbCityID.Size = new System.Drawing.Size(118, 22);
            this.cmbCityID.TabIndex = 6;
            this.cmbCityID.SelectedIndexChanged += new System.EventHandler(this.cmbCityID_SelectedIndexChanged);
            // 
            // cmbCounty
            // 
            this.cmbCounty.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Items.AddRange(new object[] {
            "栖霞区",
            "鼓楼区",
            "江宁区",
            "雨花台区",
            "秦淮区",
            "浦口区",
            "玄武区",
            "六合区",
            "建邺区"});
            this.cmbCounty.Location = new System.Drawing.Point(102, 49);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(118, 22);
            this.cmbCounty.TabIndex = 5;
            this.cmbCounty.SelectedValueChanged += new System.EventHandler(this.cmbCounty_SelectedValueChanged);
            // 
            // lblCountyName
            // 
            this.lblCountyName.AutoSize = true;
            this.lblCountyName.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCountyName.Location = new System.Drawing.Point(35, 52);
            this.lblCountyName.Name = "lblCountyName";
            this.lblCountyName.Size = new System.Drawing.Size(77, 14);
            this.lblCountyName.TabIndex = 2;
            this.lblCountyName.Text = "区/县 名：";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCityName.Location = new System.Drawing.Point(311, 25);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(77, 14);
            this.lblCityName.TabIndex = 1;
            this.lblCityName.Text = "城 市 名：";
            // 
            // lblCityID
            // 
            this.lblCityID.AutoSize = true;
            this.lblCityID.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCityID.Location = new System.Drawing.Point(36, 25);
            this.lblCityID.Name = "lblCityID";
            this.lblCityID.Size = new System.Drawing.Size(77, 14);
            this.lblCityID.TabIndex = 0;
            this.lblCityID.Text = "城市编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbSchoolID);
            this.groupBox2.Controls.Add(this.cmbSchoolQuality);
            this.groupBox2.Controls.Add(this.cmbSchoolKind);
            this.groupBox2.Controls.Add(this.cmbSchoolName);
            this.groupBox2.Controls.Add(this.lblSchoolQuality);
            this.groupBox2.Controls.Add(this.lblSchoolKind);
            this.groupBox2.Controls.Add(this.lblSchoolName);
            this.groupBox2.Controls.Add(this.lblSchoolID);
            this.groupBox2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(68, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学校信息";
            // 
            // cmbSchoolID
            // 
            this.cmbSchoolID.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSchoolID.Location = new System.Drawing.Point(379, 21);
            this.cmbSchoolID.Name = "cmbSchoolID";
            this.cmbSchoolID.Size = new System.Drawing.Size(118, 23);
            this.cmbSchoolID.TabIndex = 12;
            // 
            // cmbSchoolQuality
            // 
            this.cmbSchoolQuality.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSchoolQuality.FormattingEnabled = true;
            this.cmbSchoolQuality.Items.AddRange(new object[] {
            "公办",
            "民办"});
            this.cmbSchoolQuality.Location = new System.Drawing.Point(379, 47);
            this.cmbSchoolQuality.Name = "cmbSchoolQuality";
            this.cmbSchoolQuality.Size = new System.Drawing.Size(118, 22);
            this.cmbSchoolQuality.TabIndex = 11;
            // 
            // cmbSchoolKind
            // 
            this.cmbSchoolKind.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSchoolKind.FormattingEnabled = true;
            this.cmbSchoolKind.Items.AddRange(new object[] {
            "小学",
            "初中",
            "高中"});
            this.cmbSchoolKind.Location = new System.Drawing.Point(102, 47);
            this.cmbSchoolKind.Name = "cmbSchoolKind";
            this.cmbSchoolKind.Size = new System.Drawing.Size(118, 22);
            this.cmbSchoolKind.TabIndex = 10;
            // 
            // cmbSchoolName
            // 
            this.cmbSchoolName.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbSchoolName.FormattingEnabled = true;
            this.cmbSchoolName.Location = new System.Drawing.Point(102, 22);
            this.cmbSchoolName.Name = "cmbSchoolName";
            this.cmbSchoolName.Size = new System.Drawing.Size(118, 22);
            this.cmbSchoolName.TabIndex = 7;
            // 
            // lblSchoolQuality
            // 
            this.lblSchoolQuality.AutoSize = true;
            this.lblSchoolQuality.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSchoolQuality.Location = new System.Drawing.Point(311, 50);
            this.lblSchoolQuality.Name = "lblSchoolQuality";
            this.lblSchoolQuality.Size = new System.Drawing.Size(77, 14);
            this.lblSchoolQuality.TabIndex = 4;
            this.lblSchoolQuality.Text = "学校性质：";
            // 
            // lblSchoolKind
            // 
            this.lblSchoolKind.AutoSize = true;
            this.lblSchoolKind.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSchoolKind.Location = new System.Drawing.Point(36, 50);
            this.lblSchoolKind.Name = "lblSchoolKind";
            this.lblSchoolKind.Size = new System.Drawing.Size(77, 14);
            this.lblSchoolKind.TabIndex = 3;
            this.lblSchoolKind.Text = "学校类别：";
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSchoolName.Location = new System.Drawing.Point(34, 25);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(77, 14);
            this.lblSchoolName.TabIndex = 2;
            this.lblSchoolName.Text = "学校名称：";
            // 
            // lblSchoolID
            // 
            this.lblSchoolID.AutoSize = true;
            this.lblSchoolID.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSchoolID.Location = new System.Drawing.Point(311, 25);
            this.lblSchoolID.Name = "lblSchoolID";
            this.lblSchoolID.Size = new System.Drawing.Size(77, 14);
            this.lblSchoolID.TabIndex = 1;
            this.lblSchoolID.Text = "学校编号：";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cmbClassFun);
            this.groupBox3.Controls.Add(this.lblClassAddress);
            this.groupBox3.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(68, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 49);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "教室信息";
            // 
            // cmbClassFun
            // 
            this.cmbClassFun.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbClassFun.FormattingEnabled = true;
            this.cmbClassFun.Items.AddRange(new object[] {
            "行政办公室",
            "教师办公室",
            "学生用机房",
            "多媒体教室",
            ""});
            this.cmbClassFun.Location = new System.Drawing.Point(102, 18);
            this.cmbClassFun.Name = "cmbClassFun";
            this.cmbClassFun.Size = new System.Drawing.Size(118, 22);
            this.cmbClassFun.TabIndex = 12;
            // 
            // lblClassAddress
            // 
            this.lblClassAddress.AutoSize = true;
            this.lblClassAddress.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClassAddress.Location = new System.Drawing.Point(32, 23);
            this.lblClassAddress.Name = "lblClassAddress";
            this.lblClassAddress.Size = new System.Drawing.Size(77, 14);
            this.lblClassAddress.TabIndex = 2;
            this.lblClassAddress.Text = "教室功能：";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(539, 314);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "提交信息";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ntIShow
            // 
            this.ntIShow.ContextMenuStrip = this.contextMenuStrip1;
            this.ntIShow.Icon = ((System.Drawing.Icon)(resources.GetObject("ntIShow.Icon")));
            this.ntIShow.Text = "江苏省教育技术装备监测平台";
            this.ntIShow.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem1.Text = "显示";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Monitor.Properties.Resources.showpage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 361);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电脑信息录入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegister_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCountyName;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Label lblCityID;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.ComboBox cmbSchoolName;
        private System.Windows.Forms.Label lblSchoolQuality;
        private System.Windows.Forms.Label lblSchoolKind;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label lblSchoolID;
        private System.Windows.Forms.Label lblClassAddress;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbCityID;
        private System.Windows.Forms.ComboBox cmbSchoolQuality;
        private System.Windows.Forms.ComboBox cmbSchoolKind;
        private System.Windows.Forms.ComboBox cmbClassFun;
        private System.Windows.Forms.NotifyIcon ntIShow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox cmbCityName;
        private System.Windows.Forms.TextBox cmbSchoolID;
    }
}