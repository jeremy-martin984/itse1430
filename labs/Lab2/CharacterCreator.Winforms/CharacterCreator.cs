using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterCreator : Form
    {
        public CharacterCreator ()
        {
            InitializeComponent();
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            Close();
            
        }

        private void OnSave ( object sender, EventArgs e )
        {
            saveCharacter.FileName = txtName.Text;
            saveCharacter.ShowDialog();
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

        private void CharacterCreator_Load ( object sender, EventArgs e )
        {

        }
    }
}
