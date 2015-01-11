using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    using Seq = List<string>;
    using Dic = Dictionary<string, int>;
    public class Controller
    {
        private Seq Data;
        private Dic Occu, Leng;

        public Dic BuildOccu(Seq li)
        {
            var occu = new Dic();
            foreach (var key in li)
                occu[key] = occu.ContainsKey(key) ? occu[key] + 1 : 1;
            return occu;
        }

        public Controller() : base(){}

        public Controller(Seq data) 
        {
            Data = new Seq(data);
            Occu = BuildOccu(data);
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

        public Tuple<int, Seq> MostCommon()
        {
            var max = Occu.Values.Max();
            var lst = new Seq();
            foreach(var entry in Occu)
                if (entry.Value == max) lst.Add(entry.Key);
            return new Tuple<int, Seq>(max, lst);
        }
    }
}
