using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Components
    {
        public Dictionary<string, double> component { get; set; }
        /// <summary>
        /// temp = 0 or 20 or 15
        /// </summary>
        public double temp { get; set; }
        /// <summary>
        /// press = 1 (101.325 kPa)
        /// </summary>
        public double press { get; set; }
        /// <summary>
        /// initType = mole or mass or volume
        /// </summary>
        public string compType { get; set; }

    }
}
