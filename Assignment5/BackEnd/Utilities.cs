using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackEnd
{
    public class Utilities
    {
        static IEnumerable<string> ReadFrom(string file)
        {
            using (var reader = File.OpenText(file))
                for (string line; (line = reader.ReadLine()) != null;/* */)
                    yield return line;
        }
    }
}
