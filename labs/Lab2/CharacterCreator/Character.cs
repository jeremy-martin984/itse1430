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
