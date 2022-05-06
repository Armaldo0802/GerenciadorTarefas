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
using MySql.Data.MySqlClient;



namespace Prototipo1_GT.Forms
{
    public partial class CDTarefa : Form
    {
       

        public CDTarefa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BT_voltar_Click(object sender, EventArgs e)
        {
            Hide();
            Form MP = new Fr_Prin();
            MP.ShowDialog();
            this.Close();

        }

       static private void TxBTarefa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxBTarefa.Text != "")
            {
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = Bd_config.Abrir();
                comm.CommandText = "INSERT INTO Tarefas (NomeTarefa, Descrição, Data, Hora) VALUES ('" + TxBTarefa.Text + "','" + TxBDescricao.Text + "','" + Dt_Data.Text + "', '" + Dt_Hora.Text + "')";
                comm.ExecuteReader();

                comm.Connection.Close();
                MessageBox.Show("Tarefa salva");
            }
            else
            {
                MessageBox.Show("Digite o nome da tarefa!");
            }

        }

        private void Dt_Data_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void CDTarefa_Load(object sender, EventArgs e)
        {

        }
    }
             
}
