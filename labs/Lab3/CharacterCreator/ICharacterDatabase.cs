/*Jeremy Martin
 * ITSE 1430
 * Lab 3
 */


namespace CharacterCreator
{
    public interface ICharacterDatabase
    {
        void Delete ( int id );
        Character[] GetAll ();
        void LoadToon ();
        void SaveList ();
        Character SaveToon ( Character character );
        string Update ( int id, Character character );
    }
}