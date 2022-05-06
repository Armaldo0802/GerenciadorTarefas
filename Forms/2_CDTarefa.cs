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
using System.Data.SqlClient;



namespace Prototipo1_GT.Forms
{
    public partial class CDTarefa : Form
    {   
        SqlCommand comm = new SqlCommand();
        public CDTarefa()
        {
            InitializeComponent();

        }

        private void BT_voltar_Click(object sender, EventArgs e)
        {
            Hide();
            Form MP = new Fr_Prin();
            MP.ShowDialog();
            this.Close();

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (TxBTarefa.Text != "")
                {
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = Bd_config.Abrir();
                    comm.CommandText = "INSERT INTO Tarefas (NomeTarefa, Descrição, Data, Hora) VALUES ('" + TxBTarefa.Text + "','" + TxBDescricao.Text + "','" + Dt_Data.Text + "', '" + Dt_Hora.Text + "')";
                    comm.ExecuteReader();
                    MessageBox.Show("Tarefa salva");
                    comm.Connection.Close();
                   
                }
                else
                {
                    MessageBox.Show("Digite o nome da tarefa!");
                }
        
        }
          
           private void Dt_Hora_ValueChanged(object sender, EventArgs e)
           {
                Dt_Hora.Format = DateTimePickerFormat.Time;
                Dt_Hora.ShowUpDown = true;
                Controls.Add(Dt_Hora);
           }
    }
             
}
