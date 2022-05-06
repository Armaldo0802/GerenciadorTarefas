using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototipo1_GT.Classes;


namespace Prototipo1_GT.Forms
{
    public partial class Fr_Prin : Form
    {

        public Fr_Prin()
        {
            InitializeComponent();
           
        }

        private void cadastrarTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form CD = new CDTarefa();
            CD.ShowDialog();
            this.Close();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minhasTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form MT = new MinhasT();
            MT.ShowDialog();
            this.Close();
        }
    }
}
