using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace DAL
{
    public class ComponentService
    {
        public Dictionary<string, double> GetZByAb(string ab, double temp)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            string sql = string.Format("select component_z from components_{0} where component_ab = '{1}'", temp, ab);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            double z = -9.9;
            if (objReader.Read())
            {
                z = Convert.ToDouble(objReader["component_z"]);
            }
            objReader.Close();
            dict.Add(ab, z);

            return dict;
        }
        
        public Dictionary<string, double> GetZByComp(Components comp)
        {
            Dictionary<string, double> compDict = comp.component;
            Dictionary<string, double> zDict = new Dictionary<string, double>();
            foreach (KeyValuePair<string, double> kvp in compDict)
            {
                zDict.Add(kvp.Key, 9999);
            }
            double temp = comp.temp;
            string sql = string.Format("select component_ab,component_z from components_{0}", temp);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            while (objReader.Read())
            {
                if (zDict.ContainsKey(objReader["component_ab"].ToString().Trim()))
                {
                    zDict[objReader["component_ab"].ToString().Trim()] = Convert.ToDouble(objReader["component_z"]);
                }
            }
            return zDict;
        }

        public Dictionary<string, double> GetMoleMassByComp(Components comp)
        {
            Dictionary<string, double> compDict = comp.component;
            Dictionary<string, double> mDict = new Dictionary<string, double>();
            foreach (KeyValuePair<string, double> kvp in compDict)
            {
                mDict.Add(kvp.Key, 9999);
            }
            double temp = comp.temp;
            string sql = string.Format("select component_ab,component_mole_mass from components_{0}", temp);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            while (objReader.Read())
            {
                if (mDict.ContainsKey(objReader["component_ab"].ToString().Trim()))
                {
                    mDict[objReader["component_ab"].ToString().Trim()] = Convert.ToDouble(objReader["component_mole_mass"]);
                }
            }
            return mDict;
        }
    }
}
