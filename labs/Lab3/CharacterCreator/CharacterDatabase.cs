using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace CharacterCreator
{
    public class CharacterDatabase
    {
        public Character SaveToon(Character character)
        {
            if (character == null)
                return null;
            var existing = FindByName(character.Name);
            if (existing != null)
                return null;

            var item = CloneToon(character);
            item.Id = _id++;
            _characters.Add(item);
            var writer = new XmlSerializer(typeof(List<Character>));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\characterDatabase.ccs";
            var file = File.Create(path);
            writer.Serialize(file, _characters);
            file.Close();
            return CloneToon(item);
        }

        private Character FindByName(string name)
        {
            foreach (var character in _characters)
            {
                if (String.Compare(character?.Name, name, true) == 0)
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

        private Character CloneToon(Character character)
        {
            var item = new Character();
            CopyToon(item, character, true);

            return item;
        }

        private void CopyToon(Character target, Character source, bool includeId)
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
        }
        private List<Character> _characters = new List<Character>();
        private int _id = 1;
    }
}
