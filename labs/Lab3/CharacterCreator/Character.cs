/*Jeremy Martin
 * ITSE 1430
 * Lab 3
 */

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
    public class Character
    {
        /// <summary>
        /// Character's name
        /// </summary>
        public string Name
        {
            get { return _name ?? "";  }
            set { _name = value?.Trim(); }
        }

        /// <summary>
        /// Characters profession/class.
        /// </summary>
        public string Class
        {
            get { return _class ?? ""; }
            set { _class = value?.Trim(); }
        }

        /// <summary>
        /// Character's race
        /// </summary>
        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value?.Trim(); }
        }

        /// <summary>
        /// Character ID, must be >= 1
        /// </summary>
        public int Id
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
        {
            get { return _description ?? ""; }
            set { _description = value?.Trim(); }
        }


        public override string ToString ()
        {

            //TODO: Remove Id, only used for debug/showing it works
            return Id + ":  " + Name;
        }
        /// <summary>
        /// takes remaining points on character string and validates all other fields for valid input
        /// </summary>
        /// <param name="pointsRemaining"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public bool ErrorCheck ( int pointsRemaining, out string error )
        {
            if (pointsRemaining != 0)
            {
                error = "You still have points to spend.";
                return false;
            }
            if (String.IsNullOrEmpty(Name))
            {
                error = "A name is required.";
                return false;
            }

            
            char[] charsToTrim = { ':', '*', '?', '<', '>', '\\', '/' };
            var temp = Name.Trim(charsToTrim);
            if (temp != Name)
            {
                error = @"The characters :, *, ?, <, >, \ and / Are not allowed.";
                return false;
            }

            if (String.IsNullOrEmpty(Class))
            {
                error = "A Class is required.";
                return false;
            }

            if (String.IsNullOrEmpty(Race))
            {
                error = "A race is required.";
                return false;

            }

            else
            {
                error = null;
                return true;
            }
        }

        private string _name;
        private string _race;
        private string _class;
        private string _description;
    }
}
