using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Functions
    {
        static public Dictionary<string, int> MakeLengthsDic(List<string> list)
        {
            return list
                .GroupBy(s => s)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }

}
