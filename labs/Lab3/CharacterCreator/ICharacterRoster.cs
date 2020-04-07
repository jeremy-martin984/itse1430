/*Jeremy Martin
 * ITSE 1430
 * Lab 3
 * 4/6/2020
 */


namespace CharacterCreator
{
    /// <summary>
    /// Provides an interface for accessing Character data
    /// </summary>
    public interface ICharacterRoster
    {
        /// <summary>
        /// Deletes a character
        /// </summary>
        /// <param name="id"></param>
        void Delete ( int id );

        /// <summary>
        /// Returns all characters on roster
        /// </summary>
        Character[] GetAll ();

        /// <summary>
        /// Loads a character from the roster
        /// </summary>
        void LoadToon ();

        /// <summary>
        /// Saves the character list in xml format
        /// </summary>
        void SaveList ();

        /// <summary>
        /// Saves the character to the roster
        /// </summary>
        /// <param name="character"></param>
        Character SaveToon ( Character character );

        /// <summary>
        /// Updates a character
        /// </summary>
        /// <param name="id"></param>
        /// <param name="character"></param>
        /// Error: Invalid character name
        /// Error: Character already exists
        /// Error: Character name is empty
        string Update ( int id, Character character );
    }
}