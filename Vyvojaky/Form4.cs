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
    public partial class formHlavniProTvorbu : Form
    {
        public formHlavniProTvorbu()
        {
            InitializeComponent();
        }


        private void int16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbTyp.Text = int16ToolStripMenuItem.ToString();
        }

        private void int32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbTyp.Text = int32ToolStripMenuItem.ToString();
        }

        private void int64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbTyp.Text = int64ToolStripMenuItem.ToString();
        }

        private void floatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbTyp.Text = floatToolStripMenuItem.ToString();
        }

        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbTyp.Text = doubleToolStripMenuItem.ToString();
        }

        private void boolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbTyp.Text = boolToolStripMenuItem.ToString();
        }

        private void stringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbTyp.Text = stringToolStripMenuItem.ToString();
        }

        private void charToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbTyp.Text = charToolStripMenuItem.ToString();
        }
    }
}
