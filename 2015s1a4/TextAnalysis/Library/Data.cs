using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LenDic : Dictionary<int, SortedSet<string>>
    {
        private static Dictionary<int, SortedSet<string>> makeDicFromList(List<string> list)
        {
            return 
                list
                .GroupBy(s => s.Length)
                .ToDictionary(g => g.Key, g => new SortedSet<string>(g));
        }

        public LenDic(List<string> list)
            : base(makeDicFromList(list))
        { }
    }

    public class FrqDic : Dictionary<string, int>
    {
        public FrqDic(List<string> list)
            : base(list.GroupBy(s => s).ToDictionary(g => g.ElementAt(0), g => g.Count()))
        {}
    }
}
