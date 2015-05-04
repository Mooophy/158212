using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LengthsDictionary : Dictionary<string, int>
    {
        static Dictionary<string, int> InitDic(List<string> list)
        {
            return list
                .GroupBy(s => s)
                .ToDictionary(g => g.Key, g => g.Count());
        }

        public LengthsDictionary(List<string> list)
            : base(InitDic(list))
        { }
    }

}
