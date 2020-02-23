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
    }
}
