using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1_GT.Forms
{
    public partial class MinhasT : Form
    {
        public MinhasT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form MP = new Fr_Prin();
            MP.ShowDialog();
            this.Close();

        }

        private void MinhasT_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tarefaTabela.Tarefas'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefasTableAdapter.Fill(this.tarefaTabela.Tarefas);

        }
    
    }
}
