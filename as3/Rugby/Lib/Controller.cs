using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Controller
    {
        private string leftNation = "Chile";
        private string rightNation = "Germany";

        public Controller(): base(){}

        public Controller(string lhs, string rhs)
        {
            leftNation = lhs;
            rightNation = rhs;
        }

        public string LeftNation
        {
            get
            {
                return leftNation;
            }
            set
            {
                leftNation = value;
            }
        }
        public string RightNation
        {
            get 
            {
                return rightNation;
            }
            set
            {
                rightNation = value;
            }
        }
    }
}
