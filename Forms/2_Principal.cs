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

        private void Fr_Prin_Load(object sender, EventArgs e)
        {
            
        }

        private void cadastrarTarefaToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
