using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zadatak_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOtvori_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li želite da nastavite?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                textBoxRezultat.Text = "Odabrali ste Yes.";
            }
            else if (result == DialogResult.No)
            {
                textBoxRezultat.Text = "Odabrali ste No.";
            }
            else
            {
                textBoxRezultat.Text = "Odabrali ste Cancel.";
            }
        }
    }
}
