using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDTANK_Painel_Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variàveis de inicializacão
        SqlConnection myConnection;

        private void SQL_StartConnection(string ServerName, string Username, string Password, string DatabaseName, string Trusted_Connection = "yes", string UserInstance = "true", string ConTimeOut = "30")
        {
            myConnection = new SqlConnection("Server=" + Servername_Box.Text + ";Database=" + DatabaseName + ";User Id=" + Username + ";Password=" + Password + ";");

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Convertendo string...");
            SQL_StartConnection(Servername_Box.Text, user_Box.Text, passwd_Box.Text, Database_Box.Text);


            Console.WriteLine("Iniciando Conexão...");
            try
            {
                Console.WriteLine("Tentando Conectar...");
                myConnection.Open();
                Console.WriteLine("Conectado!");
            }
            catch (Exception e2)
            {
                Console.WriteLine("Falha ao Conectar...");
                Console.WriteLine(e2.ToString());
                return;
            }
        }
    }
}
