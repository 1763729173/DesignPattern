using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyWeightTest
{
    /// <summary>
    /// 体育馆
    /// </summary>
    public class Gymnasium
    {
        public string Name { get; set; }

        public string Sports { get; set; }

        public override string ToString()
        {
            return string.Format("Name:{0},Sports:{1}",Name,Sports);
        }
    }
}
