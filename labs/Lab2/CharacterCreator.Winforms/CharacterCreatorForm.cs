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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace CharacterCreator.Winforms
{
    public partial class CharacterCreatorForm : Form
    {
        public CharacterCreatorForm ()
        {
            InitializeComponent();
        }

        private int GetAsInt32 ( string txtBox )
        {
            int temp = Int32.Parse(txtBox);
            return temp;
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
            
        }

        private void OnSave ( object sender, EventArgs e )
        {
            var newToon = new Character {
                Agility = GetAsInt32(txtAgi.Text),
                Charisma = GetAsInt32(txtCha.Text),
                Constitution = GetAsInt32(txtCon.Text),
                Strength = GetAsInt32(txtStr.Text),
                Intelligence = GetAsInt32(txtInt.Text),
                Name = txtName.Text,
                Race = comboBoxRace.Text,
                Class = comboBoxClass.Text,
                Description = richTextBio.Text
            };
            int pointsRemaining = GetAsInt32(txtPointsRemaining.Text);

            if(!newToon.ErrorCheck(pointsRemaining, out string error))
            {
                MessageBox.Show(error, "Missing Data!", MessageBoxButtons.OK);
                return;
            }
            System.Xml.Serialization.XmlSerializer writer = 
                new System.Xml.Serialization.XmlSerializer(typeof(Character));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + txtName.Text + ".xml";// "//SerializationOverview.xml"; 
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, newToon);
            file.Close();
            Close();
        }

        private void PlusStr ( object sender, EventArgs e )
        {
            var plus = new StatHandler();
            plus.PlusStat(txtPointsRemaining.Text, txtStr.Text, out string temp, out string temp2);
            if (temp2 == null)
                return;
            else
            {
                txtStr.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void MinusStr ( object sender, EventArgs e )
        {
            var minus = new StatHandler();
            minus.MinusStat(txtPointsRemaining.Text, txtStr.Text, out string temp, out string temp2);
            if (temp2 == null)
                return;
            else
            {
                txtStr.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void PlusInt ( object sender, EventArgs e )
        {
            var plus = new StatHandler();
            plus.PlusStat(txtPointsRemaining.Text, txtInt.Text, out string temp, out string temp2);
            if (temp2 == null)
                return;
            else
            {
                txtInt.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void PlusAgi ( object sender, EventArgs e )
        {
            var plus = new StatHandler();
            plus.PlusStat(txtPointsRemaining.Text, txtAgi.Text, out string temp, out string temp2);
            if (temp2 == null)
                return;
            else
            {
                txtAgi.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void PlusCon ( object sender, EventArgs e )
        {
            var plus = new StatHandler();
            plus.PlusStat(txtPointsRemaining.Text, txtCon.Text, out string temp, out string temp2);
            if (temp2 == null)
                return;
            else
            {
                txtCon.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void PlusCha ( object sender, EventArgs e )
        {
            var plus = new StatHandler();
            plus.PlusStat(txtPointsRemaining.Text, txtCha.Text, out string temp, out string temp2);
            if (temp2 == null)
                return;
            else
            {
                txtCha.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void MinusInt ( object sender, EventArgs e )
        {
            var minus = new StatHandler();
            minus.MinusStat(txtPointsRemaining.Text, txtInt.Text, out string temp, out string temp2);
            if (temp2 == null)
                return;
            else
            {
                txtInt.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void MinusAgi ( object sender, EventArgs e )
        {
            var minus = new StatHandler();
            minus.MinusStat(txtPointsRemaining.Text, txtAgi.Text, out string temp, out string temp2);
            if (temp2 == null)
                return;
            else
            {
                txtAgi.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void MinusCon ( object sender, EventArgs e )
        {
            var minus = new StatHandler();
            minus.MinusStat(txtPointsRemaining.Text, txtCon.Text, out string temp, out string temp2);
            if (temp2 == null)
                return;
            else
            {
                txtCon.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        private void MinusCha ( object sender, EventArgs e )
        {
            var minus = new StatHandler();
            minus.MinusStat(txtPointsRemaining.Text, txtCha.Text, out string temp, out string temp2);
            if (temp2 == null)
                return;
            else
            {
                txtCha.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }


        private void OnSaveOk ( object sender, CancelEventArgs e )
        {
            //TODO:Actually save the character.

        }
    }
}
