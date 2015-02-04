using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackEnd
{
    /// <summary>
    /// tools that can be used for this assignment
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// transform a text file to IEnumerable
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static IEnumerable<string> ReadFrom(string file)
        {
            using (var reader = File.OpenText(file))
                for (string line; (line = reader.ReadLine()) != null;/* */)
                    yield return line;
        }
    }
}
