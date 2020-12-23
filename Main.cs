using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test4education
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }




        private void ToBinarySystem_Click(object sender, EventArgs e)
        {
            switch (FromNumSys.SelectedIndex)
            {
                case 0: OutputTextBox.Text = TurnToBinSys.FromDecimal(int.Parse(Input.Text)).ToString();
                break;
            }
        }


    }
}
