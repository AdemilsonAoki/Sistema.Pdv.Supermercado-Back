using MySql.Data.MySqlClient;
using System.Data;


namespace SistemaPDVBack.Model
{
    class Conexao
    {

        MySqlConnection con = new MySqlConnection();

        private readonly string conexao = "Server=localhost;Database=bancopim2semestre2020;Uid=root;Pwd=Brasileiro55@;";

        public Conexao()
        {
            con.ConnectionString = conexao;
        }
        public MySqlConnection AbrirBanco()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        public void FecharBanco()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }



        }
    }
}
