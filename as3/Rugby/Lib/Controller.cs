﻿/*  
 *  class Lib.Controller 
 *  by Boxi Zhang 12238967 
 *  for Assignment III, 159.212 Application Software Development Summer 2014 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    /// <summary>
    /// class Controller, where bussiness logic is defined
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// fields
        /// </summary>
        string nationLeft, nationRight;

        /// <summary>
        /// default Ctor
        /// </summary>
        public Controller(): base(){}

        /// <summary>
        /// Ctor with two args
        /// </summary>
        /// <param name="l">left hand side nation</param>
        /// <param name="r">right hand side nation</param>
        public Controller(string l, string r)
        {
            nationLeft = l;
            nationRight = r;
        }

        /// <summary>
        /// for lambda
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        delegate bool Predicate(int i); 

        /// <summary>
        /// convert an int stored elapsed time to string
        /// </summary>
        /// <param name="elapsed">time elpased</param>
        /// <returns></returns>
        public string elapsedToString(int elapsed)
        {
            Predicate isTooSmall = i => i < 10;
            var min = (isTooSmall(elapsed / 60) ? "0" : "") + (elapsed / 60).ToString();
            var sec = (isTooSmall(elapsed % 60) ? "0" : "") + (elapsed % 60).ToString();
            return min + ":" + sec;
        }

        /// <summary>
        /// mapping from score type to points
        /// </summary>
        /// <param name="t">score type</param>
        /// <returns>score points</returns>
        public int mapPoints(int t)
        {
            return t == 0 ? 5 : t == 1 ? 2 : 3;
        }

        /// <summary>
        /// for lambda constructing
        /// </summary>
        /// <param name="scoreType"></param>
        /// <returns>score name</returns>
        delegate string mapScoreType(int scoreType);

        /// <summary>
        /// record a log for scoring
        /// </summary>
        /// <param name="isLeft"> if left hand side</param>
        /// <param name="scoreType"></param>
        /// <param name="elapsed"></param>
        /// <returns>log record</returns>
        public string makeLog(bool isLeft, int scoreType, string elapsed)
        {
            mapScoreType scoreName = t => t==0 ? "Try" : t==1 ? "Conversion" : t==2 ? "Penalty" : "Drop";
            var nation = isLeft ? nationLeft : nationRight;
            return nation + " scores a " + scoreName(scoreType) + " at " + elapsed; 
        }
    }
}
