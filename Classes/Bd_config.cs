
using System.Data.SqlClient;




namespace Prototipo1_GT.Classes
{

    public static class Bd_config
    {
        public static SqlConnection Abrir() //objeto
        { //Classe de conexao 
            string cone = @"Data Source=SOLID\SQLEXPRESS;Initial Catalog=Tarefa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(cone);
            con.Open(); //Abre a conexao
            return con;

        }



    }




}

