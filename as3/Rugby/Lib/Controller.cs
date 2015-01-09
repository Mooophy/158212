using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Controller
    {
        string nationLeft, nationRight;
        public Controller(): base(){}
        public Controller(string l, string r)
        {
            nationLeft = l;
            nationRight = r;
        }

        delegate bool Predicate(int i); 
        public string elapsedToString(int elapsed)
        {
            Predicate isTooSmall = i => i < 10;
            var min = (isTooSmall(elapsed / 60) ? "0" : "") + (elapsed / 60).ToString();
            var sec = (isTooSmall(elapsed % 60) ? "0" : "") + (elapsed % 60).ToString();
            return min + ":" + sec;
        }

        public int mapPoints(int t)
        {
            return t == 0 ? 5 : t == 1 ? 2 : 3;
        }

        delegate string mapScoreType(int scoreType);
        public string makeLog(bool isLeft, int scoreType, string elapsed)
        {
            mapScoreType scoreName = t => t==0 ? "Try" : t==1 ? "Conversion" : t==2 ? "Penalty" : "Drop";
            var nation = isLeft ? nationLeft : nationRight;
            return nation + " scores a " + scoreName(scoreType) + " at " + elapsed; 
        }
    }
}
