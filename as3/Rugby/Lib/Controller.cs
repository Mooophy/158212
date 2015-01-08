using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Controller
    {
        public Controller(): base(){}

        delegate bool Predicate(int i); 
        public string elapsedToString(int elapsed)
        {
            Predicate isTooSmall = i => i < 10;
            var min = (isTooSmall(elapsed / 60) ? "0" : "") + (elapsed / 60).ToString();
            var sec = (isTooSmall(elapsed % 60) ? "0" : "") + (elapsed % 60).ToString();
            return min + ":" + sec;
        }
    }
}
