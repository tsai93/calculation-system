namespace CalculationSystem
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGas = new System.Windows.Forms.TabPage();
            this.btnOutput = new System.Windows.Forms.Button();
            this.grpGasResult = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDi2 = new System.Windows.Forms.TextBox();
            this.txtGao2 = new System.Windows.Forms.TextBox();
            this.txtFenZiLiang = new System.Windows.Forms.TextBox();
            this.txtZhenShiMiDu = new System.Windows.Forms.TextBox();
            this.txtMiDu = new System.Windows.Forms.TextBox();
            this.txtDi1 = new System.Windows.Forms.TextBox();
            this.txtGao1 = new System.Windows.Forms.TextBox();
            this.txtYaSuoYinZi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvVolumePercent = new System.Windows.Forms.DataGridView();
            this.ComponentVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGasCalculate = new System.Windows.Forms.Button();
            this.grpTempAndPress = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtOtherTemp = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOtherPress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rdoTempOther = new System.Windows.Forms.RadioButton();
            this.rdoTemp15 = new System.Windows.Forms.RadioButton();
            this.rdoTemp20 = new System.Windows.Forms.RadioButton();
            this.rdoTemp0 = new System.Windows.Forms.RadioButton();
            this.grpComponent = new System.Windows.Forms.GroupBox();
            this.rdoVolume = new System.Windows.Forms.RadioButton();
            this.rdoMass = new System.Windows.Forms.RadioButton();
            this.rdoMole = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInputPercent = new System.Windows.Forms.DataGridView();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabZ = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabGas.SuspendLayout();
            this.grpGasResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolumePercent)).BeginInit();
            this.grpTempAndPress.SuspendLayout();
            this.grpComponent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabGas);
            this.tabControl1.Controls.Add(this.tabZ);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 643);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGas
            // 
            this.tabGas.Controls.Add(this.btnOutput);
            this.tabGas.Controls.Add(this.grpGasResult);
            this.tabGas.Controls.Add(this.btnGasCalculate);
            this.tabGas.Controls.Add(this.grpTempAndPress);
            this.tabGas.Controls.Add(this.grpComponent);
            this.tabGas.Controls.Add(this.btnLoad);
            this.tabGas.Controls.Add(this.btnBrowse);
            this.tabGas.Controls.Add(this.txtExcelPath);
            this.tabGas.Controls.Add(this.label1);
            this.tabGas.Controls.Add(this.dgvInputPercent);
            this.tabGas.Location = new System.Drawing.Point(4, 25);
            this.tabGas.Name = "tabGas";
            this.tabGas.Padding = new System.Windows.Forms.Padding(3);
            this.tabGas.Size = new System.Drawing.Size(1051, 614);
            this.tabGas.TabIndex = 0;
            this.tabGas.Text = "天然气系统计算";
            this.tabGas.UseVisualStyleBackColor = true;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(471, 530);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(87, 38);
            this.btnOutput.TabIndex = 10;
            this.btnOutput.Text = "导出";
            this.btnOutput.UseVisualStyleBackColor = true;
            // 
            // grpGasResult
            // 
            this.grpGasResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGasResult.Controls.Add(this.label14);
            this.grpGasResult.Controls.Add(this.label13);
            this.grpGasResult.Controls.Add(this.label12);
            this.grpGasResult.Controls.Add(this.label11);
            this.grpGasResult.Controls.Add(this.label10);
            this.grpGasResult.Controls.Add(this.txtDi2);
            this.grpGasResult.Controls.Add(this.txtGao2);
            this.grpGasResult.Controls.Add(this.txtFenZiLiang);
            this.grpGasResult.Controls.Add(this.txtZhenShiMiDu);
            this.grpGasResult.Controls.Add(this.txtMiDu);
            this.grpGasResult.Controls.Add(this.txtDi1);
            this.grpGasResult.Controls.Add(this.txtGao1);
            this.grpGasResult.Controls.Add(this.txtYaSuoYinZi);
            this.grpGasResult.Controls.Add(this.label9);
            this.grpGasResult.Controls.Add(this.label8);
            this.grpGasResult.Controls.Add(this.label7);
            this.grpGasResult.Controls.Add(this.label6);
            this.grpGasResult.Controls.Add(this.label5);
            this.grpGasResult.Controls.Add(this.label4);
            this.grpGasResult.Controls.Add(this.label3);
            this.grpGasResult.Controls.Add(this.dgvVolumePercent);
            this.grpGasResult.Controls.Add(this.label2);
            this.grpGasResult.Location = new System.Drawing.Point(664, 14);
            this.grpGasResult.Name = "grpGasResult";
            this.grpGasResult.Size = new System.Drawing.Size(381, 594);
            this.grpGasResult.TabIndex = 9;
            this.grpGasResult.TabStop = false;
            this.grpGasResult.Text = "计算结果";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(202, 492);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 15);
            this.label14.TabIndex = 21;
            this.label14.Text = "kg/m3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 460);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "kJ/kg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(325, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "kJ/kg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 460);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "kJ/m3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "kJ/m3";
            // 
            // txtDi2
            // 
            this.txtDi2.Location = new System.Drawing.Point(251, 457);
            this.txtDi2.Name = "txtDi2";
            this.txtDi2.Size = new System.Drawing.Size(68, 25);
            this.txtDi2.TabIndex = 16;
            // 
            // txtGao2
            // 
            this.txtGao2.Location = new System.Drawing.Point(251, 425);
            this.txtGao2.Name = "txtGao2";
            this.txtGao2.Size = new System.Drawing.Size(68, 25);
            this.txtGao2.TabIndex = 15;
            // 
            // txtFenZiLiang
            // 
            this.txtFenZiLiang.Location = new System.Drawing.Point(128, 553);
            this.txtFenZiLiang.Name = "txtFenZiLiang";
            this.txtFenZiLiang.Size = new System.Drawing.Size(68, 25);
            this.txtFenZiLiang.TabIndex = 14;
            // 
            // txtZhenShiMiDu
            // 
            this.txtZhenShiMiDu.Location = new System.Drawing.Point(128, 521);
            this.txtZhenShiMiDu.Name = "txtZhenShiMiDu";
            this.txtZhenShiMiDu.Size = new System.Drawing.Size(68, 25);
            this.txtZhenShiMiDu.TabIndex = 13;
            // 
            // txtMiDu
            // 
            this.txtMiDu.Location = new System.Drawing.Point(128, 489);
            this.txtMiDu.Name = "txtMiDu";
            this.txtMiDu.Size = new System.Drawing.Size(68, 25);
            this.txtMiDu.TabIndex = 12;
            // 
            // txtDi1
            // 
            this.txtDi1.Location = new System.Drawing.Point(128, 457);
            this.txtDi1.Name = "txtDi1";
            this.txtDi1.Size = new System.Drawing.Size(68, 25);
            this.txtDi1.TabIndex = 11;
            // 
            // txtGao1
            // 
            this.txtGao1.Location = new System.Drawing.Point(128, 425);
            this.txtGao1.Name = "txtGao1";
            this.txtGao1.Size = new System.Drawing.Size(68, 25);
            this.txtGao1.TabIndex = 10;
            // 
            // txtYaSuoYinZi
            // 
            this.txtYaSuoYinZi.Location = new System.Drawing.Point(128, 393);
            this.txtYaSuoYinZi.Name = "txtYaSuoYinZi";
            this.txtYaSuoYinZi.Size = new System.Drawing.Size(68, 25);
            this.txtYaSuoYinZi.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "平均分子量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "真实相对密度：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "真实密度：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "真实低位发热量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "真实高位发热量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "压缩因子：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "燃气基本计算参数：";
            // 
            // dgvVolumePercent
            // 
            this.dgvVolumePercent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVolumePercent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponentVolume,
            this.PercentVolume});
            this.dgvVolumePercent.Location = new System.Drawing.Point(14, 52);
            this.dgvVolumePercent.Name = "dgvVolumePercent";
            this.dgvVolumePercent.RowTemplate.Height = 27;
            this.dgvVolumePercent.Size = new System.Drawing.Size(330, 291);
            this.dgvVolumePercent.TabIndex = 1;
            // 
            // ComponentVolume
            // 
            this.ComponentVolume.HeaderText = "成分";
            this.ComponentVolume.Name = "ComponentVolume";
            // 
            // PercentVolume
            // 
            this.PercentVolume.HeaderText = "体积百分含量";
            this.PercentVolume.Name = "PercentVolume";
            this.PercentVolume.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "燃气组分体积分数：";
            // 
            // btnGasCalculate
            // 
            this.btnGasCalculate.Location = new System.Drawing.Point(471, 470);
            this.btnGasCalculate.Name = "btnGasCalculate";
            this.btnGasCalculate.Size = new System.Drawing.Size(87, 38);
            this.btnGasCalculate.TabIndex = 8;
            this.btnGasCalculate.Text = "计算";
            this.btnGasCalculate.UseVisualStyleBackColor = true;
            this.btnGasCalculate.Click += new System.EventHandler(this.btnGasCalculate_Click);
            // 
            // grpTempAndPress
            // 
            this.grpTempAndPress.Controls.Add(this.label18);
            this.grpTempAndPress.Controls.Add(this.txtOtherTemp);
            this.grpTempAndPress.Controls.Add(this.label17);
            this.grpTempAndPress.Controls.Add(this.txtOtherPress);
            this.grpTempAndPress.Controls.Add(this.label16);
            this.grpTempAndPress.Controls.Add(this.label15);
            this.grpTempAndPress.Controls.Add(this.rdoTempOther);
            this.grpTempAndPress.Controls.Add(this.rdoTemp15);
            this.grpTempAndPress.Controls.Add(this.rdoTemp20);
            this.grpTempAndPress.Controls.Add(this.rdoTemp0);
            this.grpTempAndPress.Location = new System.Drawing.Point(386, 248);
            this.grpTempAndPress.Name = "grpTempAndPress";
            this.grpTempAndPress.Size = new System.Drawing.Size(254, 199);
            this.grpTempAndPress.TabIndex = 7;
            this.grpTempAndPress.TabStop = false;
            this.grpTempAndPress.Text = "温度压力工况";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(207, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 15);
            this.label18.TabIndex = 9;
            this.label18.Text = "K";
            // 
            // txtOtherTemp
            // 
            this.txtOtherTemp.Enabled = false;
            this.txtOtherTemp.Location = new System.Drawing.Point(132, 162);
            this.txtOtherTemp.Name = "txtOtherTemp";
            this.txtOtherTemp.Size = new System.Drawing.Size(69, 25);
            this.txtOtherTemp.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(207, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 15);
            this.label17.TabIndex = 7;
            this.label17.Text = "kPa";
            // 
            // txtOtherPress
            // 
            this.txtOtherPress.Enabled = false;
            this.txtOtherPress.Location = new System.Drawing.Point(132, 131);
            this.txtOtherPress.Name = "txtOtherPress";
            this.txtOtherPress.Size = new System.Drawing.Size(69, 25);
            this.txtOtherPress.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(82, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 5;
            this.label16.Text = "温度：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(82, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "压力：";
            // 
            // rdoTempOther
            // 
            this.rdoTempOther.AutoSize = true;
            this.rdoTempOther.Location = new System.Drawing.Point(19, 137);
            this.rdoTempOther.Name = "rdoTempOther";
            this.rdoTempOther.Size = new System.Drawing.Size(73, 19);
            this.rdoTempOther.TabIndex = 3;
            this.rdoTempOther.TabStop = true;
            this.rdoTempOther.Text = "其他：";
            this.rdoTempOther.UseVisualStyleBackColor = true;
            this.rdoTempOther.CheckedChanged += new System.EventHandler(this.rdoTempOther_CheckedChanged);
            // 
            // rdoTemp15
            // 
            this.rdoTemp15.AutoSize = true;
            this.rdoTemp15.Location = new System.Drawing.Point(19, 102);
            this.rdoTemp15.Name = "rdoTemp15";
            this.rdoTemp15.Size = new System.Drawing.Size(227, 19);
            this.rdoTemp15.TabIndex = 2;
            this.rdoTemp15.TabStop = true;
            this.rdoTemp15.Text = "101.325kPa,288.15K(15°C)";
            this.rdoTemp15.UseVisualStyleBackColor = true;
            // 
            // rdoTemp20
            // 
            this.rdoTemp20.AutoSize = true;
            this.rdoTemp20.Location = new System.Drawing.Point(19, 67);
            this.rdoTemp20.Name = "rdoTemp20";
            this.rdoTemp20.Size = new System.Drawing.Size(227, 19);
            this.rdoTemp20.TabIndex = 1;
            this.rdoTemp20.TabStop = true;
            this.rdoTemp20.Text = "101.325kPa,293.15K(20°C)";
            this.rdoTemp20.UseVisualStyleBackColor = true;
            // 
            // rdoTemp0
            // 
            this.rdoTemp0.AutoSize = true;
            this.rdoTemp0.Location = new System.Drawing.Point(19, 33);
            this.rdoTemp0.Name = "rdoTemp0";
            this.rdoTemp0.Size = new System.Drawing.Size(219, 19);
            this.rdoTemp0.TabIndex = 0;
            this.rdoTemp0.TabStop = true;
            this.rdoTemp0.Text = "101.325kPa,273.15K(0°C)";
            this.rdoTemp0.UseVisualStyleBackColor = true;
            // 
            // grpComponent
            // 
            this.grpComponent.Controls.Add(this.rdoVolume);
            this.grpComponent.Controls.Add(this.rdoMass);
            this.grpComponent.Controls.Add(this.rdoMole);
            this.grpComponent.Location = new System.Drawing.Point(386, 76);
            this.grpComponent.Name = "grpComponent";
            this.grpComponent.Size = new System.Drawing.Size(254, 143);
            this.grpComponent.TabIndex = 6;
            this.grpComponent.TabStop = false;
            this.grpComponent.Text = "输入百分含量";
            // 
            // rdoVolume
            // 
            this.rdoVolume.AutoSize = true;
            this.rdoVolume.Location = new System.Drawing.Point(19, 101);
            this.rdoVolume.Name = "rdoVolume";
            this.rdoVolume.Size = new System.Drawing.Size(88, 19);
            this.rdoVolume.TabIndex = 2;
            this.rdoVolume.TabStop = true;
            this.rdoVolume.Text = "体积分数";
            this.rdoVolume.UseVisualStyleBackColor = true;
            // 
            // rdoMass
            // 
            this.rdoMass.AutoSize = true;
            this.rdoMass.Location = new System.Drawing.Point(19, 67);
            this.rdoMass.Name = "rdoMass";
            this.rdoMass.Size = new System.Drawing.Size(88, 19);
            this.rdoMass.TabIndex = 1;
            this.rdoMass.TabStop = true;
            this.rdoMass.Text = "质量分数";
            this.rdoMass.UseVisualStyleBackColor = true;
            // 
            // rdoMole
            // 
            this.rdoMole.AutoSize = true;
            this.rdoMole.Location = new System.Drawing.Point(19, 33);
            this.rdoMole.Name = "rdoMole";
            this.rdoMole.Size = new System.Drawing.Size(88, 19);
            this.rdoMole.TabIndex = 0;
            this.rdoMole.TabStop = true;
            this.rdoMole.Text = "摩尔分数";
            this.rdoMole.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(285, 42);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(72, 28);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(207, 42);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(72, 28);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "浏览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Location = new System.Drawing.Point(9, 42);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(192, 25);
            this.txtExcelPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "导入成分excel表：";
            // 
            // dgvInputPercent
            // 
            this.dgvInputPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvInputPercent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputPercent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Component,
            this.Percent});
            this.dgvInputPercent.Location = new System.Drawing.Point(6, 76);
            this.dgvInputPercent.Name = "dgvInputPercent";
            this.dgvInputPercent.RowTemplate.Height = 27;
            this.dgvInputPercent.Size = new System.Drawing.Size(351, 532);
            this.dgvInputPercent.TabIndex = 0;
            // 
            // Component
            // 
            this.Component.HeaderText = "成分";
            this.Component.Name = "Component";
            this.Component.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "百分含量";
            this.Percent.Name = "Percent";
            // 
            // tabZ
            // 
            this.tabZ.Location = new System.Drawing.Point(4, 25);
            this.tabZ.Name = "tabZ";
            this.tabZ.Padding = new System.Windows.Forms.Padding(3);
            this.tabZ.Size = new System.Drawing.Size(1051, 614);
            this.tabZ.TabIndex = 1;
            this.tabZ.Text = "压缩因子计算";
            this.tabZ.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 694);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMain";
            this.Text = "GH Calculation System V0.1";
            this.tabControl1.ResumeLayout(false);
            this.tabGas.ResumeLayout(false);
            this.tabGas.PerformLayout();
            this.grpGasResult.ResumeLayout(false);
            this.grpGasResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolumePercent)).EndInit();
            this.grpTempAndPress.ResumeLayout(false);
            this.grpTempAndPress.PerformLayout();
            this.grpComponent.ResumeLayout(false);
            this.grpComponent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputPercent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGas;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInputPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.Button btnGasCalculate;
        private System.Windows.Forms.GroupBox grpTempAndPress;
        private System.Windows.Forms.RadioButton rdoTemp15;
        private System.Windows.Forms.RadioButton rdoTemp20;
        private System.Windows.Forms.RadioButton rdoTemp0;
        private System.Windows.Forms.GroupBox grpComponent;
        private System.Windows.Forms.RadioButton rdoVolume;
        private System.Windows.Forms.RadioButton rdoMass;
        private System.Windows.Forms.RadioButton rdoMole;
        private System.Windows.Forms.GroupBox grpGasResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVolumePercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentVolume;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDi2;
        private System.Windows.Forms.TextBox txtGao2;
        private System.Windows.Forms.TextBox txtFenZiLiang;
        private System.Windows.Forms.TextBox txtZhenShiMiDu;
        private System.Windows.Forms.TextBox txtMiDu;
        private System.Windows.Forms.TextBox txtDi1;
        private System.Windows.Forms.TextBox txtGao1;
        private System.Windows.Forms.TextBox txtYaSuoYinZi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtOtherTemp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtOtherPress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rdoTempOther;
        private System.Windows.Forms.TabPage tabZ;
    }
}

