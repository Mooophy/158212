using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalysis
{
    public class Controller
    {
        /// <summary>
        /// field for raw data
        /// </summary>
        private List<string> _data;
        /// <summary>
        /// a dictionary to store number of occurrences
        /// </summary>
        private Dictionary<string, int> _occurrences;
        /// <summary>
        /// a dictionary to store words that have same length.
        /// </summary>
        private Dictionary<int, SortedSet<string>> _lengths;
        /// <summary>
        /// build a occurrences dictionay and return it
        /// </summary>
        /// <param name="list">raw data</param>
        /// <returns>dictionary</returns>
        public Dictionary<string, int> BuildOccu(List<string> list)
        {
            var occu = new Dictionary<string, int>();
            foreach (var key in list.Where(word => word != ""))
                occu[key] = occu.ContainsKey(key) ? occu[key] + 1 : 1;
            return occu;
        }
        /// <summary>
        /// build a lengths dictionary and return it
        /// </summary>
        /// <param name="list">raw data</param>
        /// <returns>dictionary</returns>
        public Dictionary<int, SortedSet<string>> BuildLeng(List<string> list)
        {
            var leng = new Dictionary<int, SortedSet<string>>();
            foreach (string w in list.Where(word => word != ""))
                if (leng.ContainsKey(w.Length))
                    leng[w.Length].Add(w);
                else
                    leng[w.Length] = new SortedSet<string> { w };
            return leng;
        }
        /// <summary>
        /// default constructor
        /// </summary>
        public Controller() : base(){}
        /// <summary>
        /// constructor with raw data
        /// </summary>
        /// <param name="data"></param>
        public Controller(List<string> data) 
        {
            _data = new List<string>(data);
            _occurrences = BuildOccu(data);
            _lengths = BuildLeng(data);
        }
        /// <summary>
        /// overloaded 
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string contents = "";
            foreach (var str in _data)   
                contents += str + " ";
            return contents;
        }
        /// <summary>
        /// lookup by frequency
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>frequency</returns>
        public int HowOften(string key)
        {
            return _occurrences.ContainsKey(key) ? _occurrences[key] : 0;
        }
        /// <summary>
        /// search for the most common words
        /// </summary>
        /// <returns>tuple</returns>
        public Tuple<int, List<string>> MostCommon()
        {
            var max = _occurrences.Values.Max();
            var lst = new List<string>();
            foreach (var entry in _occurrences.Where(entry => entry.Value == max))
                lst.Add(entry.Key);
            return new Tuple<int, List<string>>(max, lst);
        }
        /// <summary>
        /// search for the longest words
        /// </summary>
        /// <returns>tuple</returns>
        public Tuple<int, SortedSet<string>> Longest()
        {
            var max = _lengths.Keys.Max();
            return new Tuple<int, SortedSet<string>>(max, _lengths[max]);
        }
        /// <summary>
        /// search for the shortest words
        /// </summary>
        /// <returns>tuple</returns>
        public Tuple<int, SortedSet<string>> Shortest()
        {
            var min = _lengths.Keys.Min();
            return new Tuple<int, SortedSet<string>>(min, _lengths[min]);
        }
        /// <summary>
        /// calcualte the average length
        /// </summary>
        /// <returns>int</returns>
        public int Average()
        {
            return Convert.ToInt32(_lengths.Keys.Average());
        }
        /// <summary>
        ///  lookup by length
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public SortedSet<string> LookupByLength(int len)
        {
            return _lengths.ContainsKey(len) ? _lengths[len] : new SortedSet<string>();
        }
    }

    public class AllControls
    {
        /// <summary>
        /// Refer to a post on SO :
        /// http://stackoverflow.com/questions/3419159/how-to-get-all-child-controls-of-a-windows-forms-form-of-a-specific-type-button
        /// </summary>
        /// <param name="control"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<Control> Get(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => Get(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }
    }
}
