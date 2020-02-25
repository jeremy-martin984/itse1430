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
            var newCharacter = new CharacterCreatorForm();
            newCharacter.ShowDialog(this);
        }

        private void EditCharacter(object sender, EventArgs e)
        {
            var fileName = "";
            if (CharacterOpenForm.ShowDialog() == DialogResult.OK)
            {
                fileName = CharacterOpenForm.FileName;
            }
            else
            {
                return;
            }

            var editCharacter = new CharacterCreatorForm {
                Text = "Edit Character"
            };
            var reader = new XmlSerializer(typeof(Character));
            var file = new StreamReader(fileName);
            var editToon = (Character)reader.Deserialize(file);
            file.Close();
            editCharacter.Toon = editToon;
            //todo:load in character
            editCharacter.ShowDialog(this);

        }

        private void DeleteCharacter(object sender, EventArgs e)
        {
            var fileName = "";
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

    }
}
