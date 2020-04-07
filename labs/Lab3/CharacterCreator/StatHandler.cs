/*Jeremy Martin
 * ITSE 1430
 * Lab 3
 * 4/6/2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    /// <summary>
    /// Takes two strings from text field, parses as ints, and returns new values (as strings) when appropriate.
    /// </summary>
    public static class StatHandler
    {
        public static void PlusStat ( string pointsRemaining, string statIncrease, out string newPointsRemaining, out string newStatTotal )
        {
            var temp = Int32.Parse(pointsRemaining);
            if (temp == 0)
            {
                newPointsRemaining = null;
                newStatTotal = null;
                return;
            } else
            {
                temp -= 1;
                newPointsRemaining = temp.ToString();
                temp = Int32.Parse(statIncrease);
                temp += 1;
                newStatTotal = temp.ToString();
                return;
            }
        }

        public static void MinusStat ( string pointsRemaining, string statIncrease, out string newPointsRemaining, out string newStatTotal )
        {
            var temp = Int32.Parse(statIncrease);
            if (temp == 50)
            {
                newPointsRemaining = null;
                newStatTotal = null;
                return;
            } else
            {
                temp -= 1;
                newStatTotal = temp.ToString();
                temp = Int32.Parse(pointsRemaining);
                temp += 1;
                newPointsRemaining = temp.ToString();
                return;
            }
        }
    }
}
