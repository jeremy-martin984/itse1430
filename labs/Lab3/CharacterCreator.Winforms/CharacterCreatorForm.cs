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
    public partial class CharacterCreatorForm : Form
    {

        public CharacterCreatorForm ()
        {
            InitializeComponent();
        }

        public Character Toon
        { get; set; }
        private int GetAsInt32 ( string txtBox )
        {
            var temp = Int32.Parse(txtBox);
            return temp;
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            Close();

        }

        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;
            Toon = new Character {
                Agility = GetAsInt32(txtAgi.Text),
                Charisma = GetAsInt32(txtCha.Text),
                Constitution = GetAsInt32(txtCon.Text),
                Strength = GetAsInt32(txtStr.Text),
                Intelligence = GetAsInt32(txtInt.Text),
                Name = txtName.Text,
                Race = comboBoxRace.Text,
                Class = comboBoxClass.Text,
                Description = richTextBio.Text,
                PointsRemaining = GetAsInt32(txtPointsRemaining.Text)
            };

            IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> errors = ObjectValidator.Validate(Toon);
            if (errors.Any())
            {
                MessageBox.Show("Error");
                return;
            }
            //TODO: Better input validation

            DialogResult = DialogResult.OK;
            
            Close();
        }


        private void PlusStr ( object sender, EventArgs e )
        {
            StatHandler.PlusStat(txtPointsRemaining.Text, txtStr.Text, out var temp, out var temp2);
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
            StatHandler.MinusStat(txtPointsRemaining.Text, txtStr.Text, out var temp, out var temp2);
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
            StatHandler.PlusStat(txtPointsRemaining.Text, txtInt.Text, out var temp, out var temp2);
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
            StatHandler.PlusStat(txtPointsRemaining.Text, txtAgi.Text, out var temp, out var temp2);
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
            StatHandler.PlusStat(txtPointsRemaining.Text, txtCon.Text, out var temp, out var temp2);
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
            StatHandler.PlusStat(txtPointsRemaining.Text, txtCha.Text, out var temp, out var temp2);
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
            StatHandler.MinusStat(txtPointsRemaining.Text, txtInt.Text, out var temp, out var temp2);
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
            StatHandler.MinusStat(txtPointsRemaining.Text, txtAgi.Text, out var temp, out var temp2);
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
            StatHandler.MinusStat(txtPointsRemaining.Text, txtCon.Text, out var temp, out var temp2);
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
            StatHandler.MinusStat(txtPointsRemaining.Text, txtCha.Text, out var temp, out var temp2);
            if (temp2 == null)
                return;
            else
            {
                txtCha.Text = temp2;
                txtPointsRemaining.Text = temp;
            }
        }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad(e);
            if (Toon != null)
            {

                txtName.Text = Toon.Name.ToString();
                txtAgi.Text = Toon.Agility.ToString();
                txtCha.Text = Toon.Charisma.ToString();
                txtCon.Text = Toon.Constitution.ToString();
                txtInt.Text = Toon.Intelligence.ToString();
                txtPointsRemaining.Text = "0";
                txtStr.Text = Toon.Strength.ToString();
                comboBoxClass.Text = Toon.Class.ToString();
                comboBoxRace.Text = Toon.Race.ToString();
                richTextBio.Text = Toon.Description.ToString();
            }
        }

        private void CharacterCreatorForm_Load(object sender, EventArgs e)
        {

        }

        private void OnValidateName(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "A Name is required");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }

        private void OnValidateClass(object sender, CancelEventArgs e)
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "A class is required");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }

        private void OnValidateRace(object sender, CancelEventArgs e)
        {
            var control = sender as ComboBox;

            if (String.IsNullOrEmpty(control.Text))
            {
                _errors.SetError(control, "A Race is required");
                e.Cancel = true;
            }
            else
                _errors.SetError(control, "");
        }
    }
}
