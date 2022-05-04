using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo1_GT;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

 

namespace Prototipo1_GT.Classes
{

    public static class Bd_config
    {
        public static MySqlConnection Abrir() //objeto
        { //Classe de conexao 
            string cone = "server=localhost; database=gerenciadort; user = root; password= 988205211Arnaldo; port=3312"; //string de conexao 
            MySqlConnection con = new MySqlConnection(cone);
            con.Open(); //Abre a conexao
            return con;

        }

    }
        
        
        
    
}

