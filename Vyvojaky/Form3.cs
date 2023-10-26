using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyvojaky
{
    public partial class formExistujiciSoubory : Form
    {
        public formExistujiciSoubory()
        {
            InitializeComponent();
        }

        private void btExistujici_Click(object sender, EventArgs e)
        {
            Form tvorba = new formHlavniProTvorbu();
            tvorba.Show();
        }
    }
}
