using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenWFA
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Form1 home = new Form1();

            if (e.ClickedItem == aboutToolStripMenuItem)
            {
                
            }
            else
            {
                this.Close();
            }
        }
    }
}
