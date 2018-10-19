using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculationSystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            List<string> l = new List<string>();
            string[] name = { "a", "b" };
            dgvInputPercent.Rows[0].Cells[0].Value = "H2";
            this.rdoMole.Checked = true;
            this.rdoTemp0.Checked = true;
            this.txtOtherPress.Text = "101.325";
            this.txtOtherTemp.Text = "273.15";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "e:\\";//注意这里写路径时要用c:\\而不是c:\
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
            this.txtMiDu.Text = this.grpTempAndPress.Tag.ToString();
        }

    }
}
