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
            _characters = new CharacterDatabase();
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

                //TODO:Better error message.
                MessageBox.Show("Add Failed");

            } while (true);
        }

        private void EditCharacter ( object sender, EventArgs e )
        {
            //Verify movie
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var child = new CharacterCreatorForm {
                Toon = character
            };

            child.Text = "Edit Character";

            do
            {
                if (child.ShowDialog(this) != DialogResult.OK)
                    return;

                // Save the movie
                var error = _characters.Update(character.Id, child.Toon);
                if (String.IsNullOrEmpty(error))
                {
                    UpdateUI();
                    return;
                };

                DisplayError(error);
            } while (true);
        }


        private bool DisplayConfirmation ( string message, string title )
        {
            //Display a confirmation dialog
            var result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //Return true if user selected OK
            return result == DialogResult.OK;
        }

        private void DeleteCharacter(object sender, EventArgs e)
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            if (!DisplayConfirmation($"Are you sure you want to delete {character.Name}?", "Delete"))
                return;

            _characters.Delete(character.Id);
            UpdateUI();
        }

        private void DisplayError ( string message )
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _characters.SaveList();
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);
            _characters.LoadToon();
            UpdateUI();
        }

        private readonly ICharacterDatabase _characters;
    }
}
