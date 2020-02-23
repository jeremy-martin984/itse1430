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
            //foo(str textbox, str textbox, out var, out var, bool)
            var temp = Int32.Parse(txtPointsRemaining.Text);
            if (temp == 0)
                return;
            else
            {
                temp -= 1;
                txtPointsRemaining.Text = temp.ToString();
                temp = Int32.Parse(txtStr.Text);
                temp += 1;
                txtStr.Text = temp.ToString();
            }
        }
    }
}
