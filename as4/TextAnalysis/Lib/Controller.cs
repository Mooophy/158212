using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Controller
    {
        private List<string> Data;
        private Dictionary<string, int> Occu;

        public Controller(List<string> data) 
        {
            Data = new List<string>(data);
            Occu = new Dictionary<string, int>();
            foreach (var key in Data)
                Occu[key] = Occu.ContainsKey(key) ? Occu[key] + 1 : 1;
        }

        public override string ToString()
        {
            string contents = "";
            foreach (var str in Data)   
                contents += str + " ";
            return contents;
        }

        public int howOften(string key)
        {
            return Occu.ContainsKey(key) ? Occu[key] : 0;
        }
    }
}
