using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    using DicLen = Dictionary<int, SortedSet<string>>;

    public class Controller
    {
        private List<string> _data;
        private Dictionary<string, int> _occurrences;
        private DicLen _lengths;

        public Dictionary<string, int> BuildOccu(List<string> list)
        {
            var occu = new Dictionary<string, int>();
            foreach (var key in list)
                occu[key] = occu.ContainsKey(key) ? occu[key] + 1 : 1;
            return occu;
        }

        public DicLen BuildLeng(List<string> list)
        {
            var leng = new DicLen();
            foreach (string w in list)
                if (leng.ContainsKey(w.Length)) 
                    leng[w.Length].Add(w);
                else 
                    leng[w.Length] = new SortedSet<string> { w };
            return leng;
        }

        public Controller() : base(){}

        public Controller(List<string> data) 
        {
            _data = new List<string>(data);
            _occurrences = BuildOccu(data);
            _lengths = BuildLeng(data);
        }

        public override string ToString()
        {
            string contents = "";
            foreach (var str in _data)   
                contents += str + " ";
            return contents;
        }

        public int HowOften(string key)
        {
            return _occurrences.ContainsKey(key) ? _occurrences[key] : 0;
        }

        public Tuple<int, List<string>> MostCommon()
        {
            var max = _occurrences.Values.Max();
            var lst = new List<string>();
            foreach(var entry in _occurrences)
                if (entry.Value == max) lst.Add(entry.Key);
            return new Tuple<int, List<string>>(max, lst);
        }

        public Tuple<int, SortedSet<string>> Longest()
        {
            var max = _lengths.Keys.Max();
            return new Tuple<int, SortedSet<string>>(max, _lengths[max]);
        }

        public Tuple<int, SortedSet<string>> Shortest()
        {
            var min = _lengths.Keys.Min();
            return new Tuple<int, SortedSet<string>>(min, _lengths[min]);
        }

        public int Average()
        {
            return Convert.ToInt32(_lengths.Keys.Average());
        }

        public SortedSet<string> LookupByLength(int len)
        {
            return _lengths.ContainsKey(len) ? _lengths[len] : new SortedSet<string>();
        }
    }
}
