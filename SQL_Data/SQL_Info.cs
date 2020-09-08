using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDTANK_Painel_Admin.SQL_Data
{
    class SQL_Info
    {
       public static SqlConnection myConnection;

        public static void SQL_StartConnection(string ServerName, string Username, string Password, string DatabaseName, string Trusted_Connection = "yes", string UserInstance = "true", string ConTimeOut = "30")
        {
            Console.WriteLine("Iniciando Conexão...");
            try
            {
                Console.WriteLine("Tentando...");
                SQL_Data.SQL_Info.myConnection = new SqlConnection("Server=" + ServerName + ";Database=" + DatabaseName + ";User Id=" + Username + ";Password=" + Password + ";");
                SQL_Data.SQL_Info.myConnection.Open();
                Console.WriteLine("Conectado ao Servidor!");
                MessageBox.Show(Form1.ActiveForm, "Conectado com Sucesso ao servidor " + ServerName + " Com o Banco de dados " + DatabaseName, "Conectado Ao Servidor!");
            }
            
            catch (Exception e2)
            {
                MessageBox.Show(Form1.ActiveForm, e2.ToString(), "Falha ao Conectar");
                return;
            }
}
    }
}
