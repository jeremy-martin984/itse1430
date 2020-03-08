/*Jeremy Martin
 * ITSE 1430
 * Lab 3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterCreator;
using System.IO;
using System.Xml.Serialization;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void OnExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox();

            about.ShowDialog(this);
        }

        //private CharacterCreator _newToon = new CharacterCreator();

        private void OnNew ( object sender, EventArgs e )
        {
            var child = new CharacterCreatorForm();

            do
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                var character = _characters.SaveToon(child.Toon);
                if (character != null)
                {
                    UpdateUI();
                    return;
                };

                MessageBox.Show("Add Failed");

            } while (true);
        }

        private void EditCharacter(object sender, EventArgs e)
        {
            var child = new CharacterCreatorForm();

            child.Toon = GetSelectedCharacter();
            if (child.Toon == null)
            {
                MessageBox.Show("No Character selected");
                return;
            }
                do
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                var character = _characters.SaveToon(child.Toon);
                if (character != null)
                {
                    UpdateUI();
                    return;
                };

                MessageBox.Show("Edit Failed");

            } while (true);

    }

        private void DeleteCharacter(object sender, EventArgs e)
        {
            string fileName;
            if (CharacterOpenForm.ShowDialog() == DialogResult.OK)
            {
                fileName = CharacterOpenForm.FileName;
            } else
            {
                return;
            }

            var result = MessageBox.Show("This will delete the character, are you sure?", "Warning!", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;
            else
            {
                File.Delete(fileName);
                MessageBox.Show("Character Has Been Deleted");
            }

            //TODO:Something more robust with existing characters
        }

        private Character GetSelectedCharacter()
        {
            return lstToons.SelectedItem as Character;
        }
        private void UpdateUI()
        {
            lstToons.Items.Clear();
            var characters = _characters.GetAll();
            foreach (var character in characters)
            {
                lstToons.Items.Add(character);
            };
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);
            UpdateUI();
        }

        public CharacterDatabase _characters = new CharacterDatabase();
    }
}
