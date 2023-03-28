using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISESPORT
{
    public partial class ApplicationForm : Form
    {
        private FormAllPlayer fop;
        private FormTeamInfo fti;
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void allPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.MdiParent = this;
            formAllPlayer.Show();*/

            this.Hide();
            FormAllPlayer fop = new FormAllPlayer();
            fop.ShowDialog();
            fop = null;
            this.Show();
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTeamInfo fti = new FormTeamInfo();
            fti.ShowDialog();
            fti = null;
            this.Show();
        }
    }
}
