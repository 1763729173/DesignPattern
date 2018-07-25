using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyWeightTest
{
    public class GymnasiumFactory
    {
        private static Dictionary<string, Gymnasium> dic = new Dictionary<string, Gymnasium>();

        public static Gymnasium GetGymnasium(String key)
        {
            if (!dic.ContainsKey(key))
            {
                Gymnasium gymnasium = new Gymnasium() { Sports = key };
                dic[key] = gymnasium;
            }
            return dic[key];
        }


    }
}
