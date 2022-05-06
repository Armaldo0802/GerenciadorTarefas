using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Prototipo1_GT.Classes;

namespace Prototipo1_GT.Forms
{
    public partial class MinhasT : Form
    {
        public MinhasT()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btAT_Click(object sender, EventArgs e)
        {
            try {

                SqlCommand comm = new SqlCommand();
                comm.Connection = Bd_config.Abrir();
                comm.CommandText = "Select * From Tarefas";
                SqlDataAdapter A = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                A.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            catch(Exception ex)
            {
                MessageBox.Show("Erro de Conexao");
            }
           
        }
    }
}
