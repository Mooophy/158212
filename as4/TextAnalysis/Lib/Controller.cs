using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    using Seq = List<string>;
    using Tpl = Tuple<int, List<string>>;
    using DicOcc = Dictionary<string, int>;
    using DicLen = Dictionary<int, SortedSet<string>>;

    public class Controller
    {
        private Seq Data;
        private DicOcc Occu;
        private DicLen Leng;

        public DicOcc BuildOccu(Seq li)
        {
            var occu = new DicOcc();
            foreach (var key in li)
                occu[key] = occu.ContainsKey(key) ? occu[key] + 1 : 1;
            return occu;
        }

        public DicLen BuildLeng(Seq li)
        {
            var leng = new DicLen();
            foreach (string w in li)
                if (leng.ContainsKey(w.Length)) 
                    leng[w.Length].Add(w);
                else 
                    leng[w.Length] = new SortedSet<string> { w };
            return leng;
        }


        public Controller() : base(){}

        public Controller(Seq data) 
        {
            Data = new Seq(data);
            Occu = BuildOccu(data);
            Leng = BuildLeng(data);
        }

        public override string ToString()
        {
            string contents = "";
            foreach (var str in Data)   
                contents += str + " ";
            return contents;
        }

        public int HowOften(string key)
        {
            return Occu.ContainsKey(key) ? Occu[key] : 0;
        }

        public Tpl MostCommon()
        {
            var max = Occu.Values.Max();
            var lst = new Seq();
            foreach(var entry in Occu)
                if (entry.Value == max) lst.Add(entry.Key);
            return new Tpl(max, lst);
        }

        public Tuple<int, SortedSet<string>> Longest()
        {
            var max = Leng.Keys.Max();
            return new Tuple<int, SortedSet<string>>(max, Leng[max]);
        }

        public Tuple<int, SortedSet<string>> Shortest()
        {
            var min = Leng.Keys.Min();
            return new Tuple<int, SortedSet<string>>(min, Leng[min]);
        }

        public int Average()
        {
            return Convert.ToInt32(Leng.Keys.Average());
        }

        public SortedSet<string> LookupByLength(int len)
        {
            return Leng.ContainsKey(len) ? Leng[len] : new SortedSet<string>();
        }
    }
}
