using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class ScoreUtility
    {
        public static IScored BestOfTwo(IScored Assignment1, IScored Assignment2)
        {
            var score1 = Assignment1.Score / Assignment1.MaxmimumScore;
            var score2 = Assignment2.Score / Assignment2.MaxmimumScore;

            if (score1 > score2)
            {
                return Assignment1;
            } else
            {
                return Assignment2;
            }
        }
    }
}
