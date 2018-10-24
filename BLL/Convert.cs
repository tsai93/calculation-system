using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class PercentConvert
    {
        private Components objComp = new Components();
        private double temp;
        private double press;
        public PercentConvert(Components comp)
        {
            objComp = comp;
            temp = objComp.temp;
            press = objComp.press;
        }
        /// <summary>
        /// 将输入的组分转换为组分体积分数
        /// </summary>
        /// <returns></returns>
        public Components ToVolume()
        {
            
            if (objComp.compType == "volume")
            {
                return objComp;
            }
            else if (objComp.compType == "mass")
            {
                //重量分数先转换为摩尔分数
                objComp = MassToMole();
                return MoleToVolume();
            }
            else
            {
                return MoleToVolume();
            }
            
        }
        public Components MoleToVolume()
        {
            ComponentService objCompService = new ComponentService();
            Dictionary<string, double> molePercent = objComp.component;//组分摩尔分数
            Dictionary<string, double> compZip = objCompService.GetZByComp(objComp);//压缩因子
            Dictionary<string, double> middlePercent = new Dictionary<string, double>();//中间过程
            Dictionary<string, double> volumePercent = new Dictionary<string, double>();
            double sum = 0;
            //中间过程=摩尔分数*压缩因子，并算出中间过程的和sum
            foreach (KeyValuePair<string, double> kvp in molePercent)
            {
                middlePercent.Add(kvp.Key, (kvp.Value * compZip[kvp.Key]));
                sum += middlePercent[kvp.Key];
            }
            //体积分数 = 中间过程 / sum * 100
            foreach (KeyValuePair<string, double> kvp in middlePercent)
            {
                //Math.Round()的第7种重载才能实现真正的四舍五入，保留4位小数
                volumePercent[kvp.Key] = (double)Math.Round((decimal)(kvp.Value / sum * 100) , 4, MidpointRounding.AwayFromZero);
            }
            objComp.component = volumePercent;
            return objComp;
        }
        public Components MassToMole()
        {
            ComponentService objCompService = new ComponentService();
            Dictionary<string, double> massPercent = objComp.component;//组分重量分数
            Dictionary<string, double> compZip = objCompService.GetZByComp(objComp);//压缩因子
            Dictionary<string, double> compMoleMass = objCompService.GetMoleMassByComp(objComp);//各组分摩尔质量
            Dictionary<string, double> middlePercent = new Dictionary<string, double>();//中间过程
            Dictionary<string, double> molePercent = new Dictionary<string, double>();
            double sum = 0;
            //中间过程 = 重量分数 / 摩尔质量 * 压缩因子   并求和
            foreach (KeyValuePair<string, double> kvp in massPercent)
            {
                middlePercent.Add(kvp.Key, massPercent[kvp.Key] / compMoleMass[kvp.Key] * compZip[kvp.Key]);
                sum += middlePercent[kvp.Key];
            }
            //摩尔分数 = 中间过程 / sum * 100
            foreach (KeyValuePair<string, double> kvp in middlePercent)
            {
                molePercent.Add(kvp.Key, ((double)Math.Round((decimal)(kvp.Value / sum * 100), 4, MidpointRounding.AwayFromZero)));
            }
            objComp.component = molePercent;
            return objComp;
        }

        
    }
}
