using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;



namespace CalculationSystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
            //将输入表格填入默认值
            InitComponents();

            //初始化默认勾选摩尔分数和标压0°C工况
            this.rdoMole.Checked = true;
            this.rdoTemp0.Checked = true;
            this.txtOtherPress.Text = "101.325";
            this.txtOtherTemp.Text = "273.15";
        }
        /// <summary>
        /// 表格的默认参数初始化
        /// </summary>
        private void InitComponents()
        {
            this.dgvInputPercent.RowCount = 17;
            this.dgvInputPercent.Rows[0].Cells[0].Value = "N2";
            this.dgvInputPercent.Rows[1].Cells[0].Value = "O2";
            this.dgvInputPercent.Rows[2].Cells[0].Value = "CH4";
            this.dgvInputPercent.Rows[3].Cells[0].Value = "C2";
            this.dgvInputPercent.Rows[4].Cells[0].Value = "CO2";
            this.dgvInputPercent.Rows[5].Cells[0].Value = "C3";
            this.dgvInputPercent.Rows[6].Cells[0].Value = "i_C4";
            this.dgvInputPercent.Rows[7].Cells[0].Value = "n_C4";
            this.dgvInputPercent.Rows[8].Cells[0].Value = "i_C5";
            this.dgvInputPercent.Rows[9].Cells[0].Value = "n_C5";
            this.dgvInputPercent.Rows[10].Cells[0].Value = "i_C6";
            this.dgvInputPercent.Rows[11].Cells[0].Value = "n_C6";
            this.dgvInputPercent.Rows[12].Cells[0].Value = "C7";
            this.dgvInputPercent.Rows[13].Cells[0].Value = "C8";
            this.dgvInputPercent.Rows[14].Cells[0].Value = "H2";
            this.dgvInputPercent.Rows[15].Cells[0].Value = "H2S";
            this.dgvInputPercent.Rows[16].Cells[0].Value = "CO";

            this.dgvInputPercent.Rows[0].Cells[1].Value = 56.2000;
            this.dgvInputPercent.Rows[1].Cells[1].Value = 3.1200;
            this.dgvInputPercent.Rows[2].Cells[1].Value = 1.5700;
            this.dgvInputPercent.Rows[3].Cells[1].Value = 0.2000;
            this.dgvInputPercent.Rows[4].Cells[1].Value = 13.7000;
            this.dgvInputPercent.Rows[5].Cells[1].Value = 0.3000;
            this.dgvInputPercent.Rows[6].Cells[1].Value = 0.0620;
            this.dgvInputPercent.Rows[7].Cells[1].Value = 0.0750;
            this.dgvInputPercent.Rows[8].Cells[1].Value = 0.0200;
            this.dgvInputPercent.Rows[9].Cells[1].Value = 0.0160;
            this.dgvInputPercent.Rows[10].Cells[1].Value = 0.0510;
            this.dgvInputPercent.Rows[11].Cells[1].Value = 0.000;
            this.dgvInputPercent.Rows[12].Cells[1].Value = 15.2700;
            this.dgvInputPercent.Rows[13].Cells[1].Value = 0.4000;
            this.dgvInputPercent.Rows[14].Cells[1].Value = 0.0100;
            this.dgvInputPercent.Rows[15].Cells[1].Value = 0.1900;
            this.dgvInputPercent.Rows[16].Cells[1].Value = 8.7000;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "表格文件|*.xls|表格文件|*.xlsx|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtExcelPath.Text = openFileDialog.FileName;
            }
        }

        private void rdoTempOther_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdoTempOther.Checked == true)
            {
                this.txtOtherPress.Enabled = true;
                this.txtOtherTemp.Enabled = true;
            }
            else
            {
                this.txtOtherPress.Enabled = false;
                this.txtOtherTemp.Enabled = false;
            }
        }

        private void btnGasCalculate_Click(object sender, EventArgs e)
        {
            //封装组成成分对象
            Components objComponents = new Components()
            {
                component = GetComp(this.dgvInputPercent),
                temp = GetTemp(),
                press = GetPress(),
                compType = GetCompType()
            };

            //将质量分数或摩尔分数转换为组分体积分数用于接下来的计算
            PercentConvert convert = new PercentConvert(objComponents);
            objComponents = convert.ToVolume();

            //将转换后的体积分数填入到计算结果的体积分数表中
            FillDgvByComp(objComponents, this.dgvVolumePercent);
            
            //计算
            //ComponentService objCompService = new ComponentService();
            //Dictionary<string, double> dict = new Dictionary<string, double>();
            //dict = objCompService.GetZByAb("H2", 20);
            //Dictionary<string, double> dict1 = new Dictionary<string, double>();
            //dict1 = objCompService.GetZByComp(objComponents);
            
        }
        /// <summary>
        /// 获取成分组成及比例
        /// </summary>
        /// <param name="objDgv">数据来源的DataGridView</param>
        /// <returns>输出字典类型的成分和比例</returns>
        private Dictionary<string, double> GetComp(DataGridView objDgv)
        {
            Dictionary<string, double> component = new Dictionary<string, double>();

            for (int i = 0; i < objDgv.RowCount; i++)
            {
                try
                {
                    component.Add(objDgv.Rows[i].Cells[0].Value.ToString(), System.Convert.ToDouble(objDgv.Rows[i].Cells[1].Value));
                }
                catch (NullReferenceException)
                {
                    ;
                }
            }
            return component;
        }

        /// <summary>
        /// 获取初始的成分类型mole or mass or volume
        /// </summary>
        /// <returns></returns>
        private string GetCompType()
        {
            string compType = "";
            if (this.rdoMass.Checked)
            {
                compType = "mass";
            }
            else if (this.rdoMole.Checked)
            {
                compType = "mole";
            }
            else
            {
                compType = "volume";
            }
            return compType;
        }

        /// <summary>
        /// 获取工况温度
        /// </summary>
        /// <returns></returns>
        private double GetTemp()
        {
            double temp = 0;
            if (this.rdoTemp0.Checked)
            {
                temp = 0;
            }
            else if (this.rdoTemp15.Checked)
            {
                temp = 15;
            }
            else if (this.rdoTemp20.Checked)
            {
                temp = 20;
            }
            else
            {
                temp = double.Parse(txtOtherTemp.Text);
            }
            return temp;
        }

        /// <summary>
        /// 获取工况压力
        /// </summary>
        /// <returns></returns>
        private double GetPress()
        {
            double press = 0;
            if (this.rdoTemp0.Checked)
            {
                press = 1;
            }
            else if (this.rdoTemp15.Checked)
            {
                press = 1;
            }
            else if (this.rdoTemp20.Checked)
            {
                press = 1;
            }
            else
            {
                press = double.Parse(txtOtherPress.Text);
            }
            return press;
        }

        /// <summary>
        /// 使用component实例填充相应DataGridView
        /// </summary>
        /// <param name="comp">成分组成实例</param>
        /// <param name="objDgv">需要填充的DataGridView</param>
        private void FillDgvByComp(Components comp, DataGridView objDgv)
        {
            Dictionary<string, double> compDict = new Dictionary<string, double>();
            compDict = comp.component;
            objDgv.RowCount = compDict.Count;
            int i = 0;
            foreach (KeyValuePair<string,double> kvp in compDict)
            {
                objDgv.Rows[i].Cells[0].Value = kvp.Key;
                objDgv.Rows[i].Cells[1].Value = kvp.Value;
                i++;
            }

        }
    }
}
