/*Jeremy Martin
 * ITSE 1430
 * Lab 3
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace CharacterCreator
{
    public class CharacterDatabase : ICharacterRoster
    {
        public Character SaveToon ( Character character )
        {
            if (character == null)
                return null;
            var existing = FindByName(character.Name);
            if (existing != null)
                return null;

            var item = CloneToon(character);
            item.Id = _id++;
            _characters.Add(item);
            return CloneToon(item);
        }


        public void SaveList ()
        {
            //Saves the character list to mydocuments, primarily for troubleshooting
            var writer = new XmlSerializer(typeof(List<Character>));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\characterDatabase.ccs";
            var file = File.Create(path);
            writer.Serialize(file, _characters);
            file.Close();
        }
        public string Update ( int id, Character character )
        {
            if (character == null)
                return "No Character found";
            var errors = ObjectValidator.Validate(character);
            if (errors.Any())
                return null;
            if (id < 0)
                return "Id is invalid";

            var existing = FindById(id);
            if (existing == null)
                return "Character not found";

            var sameName = FindByName(character.Name);
            if (sameName != null && sameName.Id != id)
                return "Duplicate names not allowed";

            CopyToon(existing, character, false);

            return null;
        }
        public void LoadToon ()
        {
            //Loads character data from xml file, mainly for troubleshooting

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\characterDatabase.ccs";
            if (!File.Exists(path))
                return;
            var reader = new XmlSerializer(typeof(List<Character>));
            var file = new StreamReader(path);
            _characters = (List<Character>)reader.Deserialize(file);
            _id = _characters.Count() + 1;
            file.Close();
        }

        private Character FindByName ( string name )
        {
            foreach (var character in _characters)
            {
                if (String.Compare(character?.Name, name, true) == 0)
                    return character;
            };

            return null;
        }

        private Character FindById ( int id )
        {
            foreach (var character in _characters)
            {
                if (character.Id == id)
                    return character;
            };

            return null;
        }
        public Character[] GetAll ()
        {
            //Clone objects
            var items = new Character[_characters.Count];
            var index = 0;
            foreach (var character in _characters)
            {
                items[index++] = CloneToon(character);
            };

            return items;
        }

        public void Delete ( int id )
        {
            if (id <= 0)
                return;

            var character = FindById(id);
            if (character != null)
                _characters.Remove(character);
        }
        private Character CloneToon ( Character character )
        {
            var item = new Character();
            CopyToon(item, character, true);

            return item;
        }

        private void CopyToon ( Character target, Character source, bool includeId )
        {
            if (includeId)
                target.Id = source.Id;
            target.Name = source.Name;
            target.Class = source.Class;
            target.Race = source.Race;
            target.Intelligence = source.Intelligence;
            target.Strength = source.Strength;
            target.Description = source.Description;
            target.Constitution = source.Constitution;
            target.Agility = source.Agility;
            target.Charisma = source.Charisma;
            target.PointsRemaining = source.PointsRemaining;
        }
        private List<Character> _characters = new List<Character>();
        private int _id = 1;
    }
}
