/*Jeremy Martin
 * ITSE 1430
 * Lab 3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CharacterCreator
{
    /// <summary>
    /// Represents all info for a character
    /// </summary>
    public class Character : IValidatableObject
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
        public int PointsRemaining
        { get; set; }


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
        public IEnumerable<ValidationResult> Validate ( ValidationContext validationContext )
        {
            if (PointsRemaining != 0)
            {
                yield return new ValidationResult("You still have points to spend", new[] { nameof(PointsRemaining) });
            };
            if (String.IsNullOrEmpty(Name))
            {
                yield return new ValidationResult("Name cannot be empty", new[] { nameof(Name) });
            };

            
            char[] charsToTrim = { ':', '*', '?', '<', '>', '\\', '/' };
            var temp = Name.Trim(charsToTrim);
            if (temp != Name)
            {
                yield return new ValidationResult(@"The characters :, *, ?, <, >, \ and / Are not allowed.", new[] { nameof(Name) });
            };

            if (String.IsNullOrEmpty(Class))
            {
                yield return new ValidationResult("You must pick a class", new[] { nameof(Class) });
            };

            if (String.IsNullOrEmpty(Race))
            {
                yield return new ValidationResult("You must pick a race", new[] { nameof(Race) });
            };
        }

        private string _name;
        private string _race;
        private string _class;
        private string _description;
    }
}
