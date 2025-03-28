using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tower_Dungeon.Business;

namespace Tower_Dungeon
{
    public partial class TowerDungeon: Form
    {
        public TowerDungeon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = "Testpassword19!";

            string hash1 = PassHash.Hash(pass);

            if (PassHash.Verify(pass, hash1))
            {
                MessageBox.Show("true");
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
}
