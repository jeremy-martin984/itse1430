using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    /// <summary>
    /// Represents all info for a character
    /// </summary>

        public class StatHandler
    {
        /// <summary>
        /// Controls adding or subtracting stat points from the character screen
        /// </summary>
        /// <param name="pointsRemaining"></param>
        /// <param name="statIncrease"></param>
        /// <param name="newPointsRemaining"></param>
        /// <param name="newStatTotal"></param>
        public void PlusStat ( string pointsRemaining, string statIncrease, out string newPointsRemaining, out string newStatTotal )
        {
            var temp = Int32.Parse(pointsRemaining);
            if (temp == 0)
            {
                newPointsRemaining = null;
                newStatTotal = null;
                return;
            } 

            else
            {
                temp -= 1;
                newPointsRemaining = temp.ToString();
                temp = Int32.Parse(statIncrease);
                temp += 1;
                newStatTotal = temp.ToString();
                return;
            }
        }

        public void MinusStat (string pointsRemaining, string statIncrease, out string newPointsRemaining, out string newStatTotal )
        {
            var temp = Int32.Parse(statIncrease);
            if (temp == 50)
            {
                newPointsRemaining = null;
                newStatTotal = null;
                return;
            }

            else
            {
                temp -= 1;
                newStatTotal = temp.ToString();
                temp = Int32.Parse(pointsRemaining);
                temp += 1;
                newPointsRemaining = temp.ToString();
                return;
            }
        }

    public class Character
    {
        /// <summary>
        /// Character's name
        /// </summary>
        public string Name
        { get; set; }

        /// <summary>
        /// Characters profession/class.
        /// </summary>
        public string Class
        { get; set; }

        /// <summary>
        /// Character's race
        /// </summary>
        public string Race
        { get; set; }

        /// <summary>
        /// Character strength, value 1 - 100
        /// </summary>
        public int Strength
        { get; set; }

        /// <summary>
        /// Character intelligence, value 1 - 100
        /// </summary>
        public int Intelligence
        { get; set; }

        /// <summary>
        /// Character Agility, value 1 - 100
        /// </summary>
        public int Agility
        { get; set; }

        /// <summary>
        /// Character Constitution, value 1 - 100
        /// </summary>
        public int Constitution
        { get; set; }

        /// <summary>
        /// Character Charisma, value 1 - 100
        /// </summary>
        public int Charisma
        { get; set; }

        /// <summary>
        /// Character description, make a good life story. Avoid as much walking as Tolkien
        /// </summary>
        public string Description
        { get; set; }


        }
    }
}
