using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, I am Message from the Menu strip", "Menu Strip", MessageBoxButtons.OK);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (checkToolStripMenuItem.Checked == true)
            {
                messageToolStripMenuItem.Enabled = true;
            }
            else if (checkToolStripMenuItem.Checked == false)
            {
                messageToolStripMenuItem.Enabled = false;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void messageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, I am Message from the ContextMenu", "Context Menu", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void checkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkToolStripMenuItem1.Checked == true)
            {
                messageToolStripMenuItem1.Enabled = false;
            } else if (checkToolStripMenuItem1.Checked == false)
            {
                messageToolStripMenuItem1.Enabled = true;
            }
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D )
            {
                tableToolStripMenuItem.Enabled = true;
                drawToolStripMenuItem.Visible = true;
                selectToolStripMenuItem.Visible = true;
                sortToolStripMenuItem.Visible = true;
            }else if(e.KeyChar == (char)Keys.E)
            {
                tableToolStripMenuItem.Enabled = false;
            }           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is just a simple Menustrip & ContextMenustrip application (Variant:12)","About Application",MessageBoxButtons.OK);
        }
    }
}
