using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
namespace WindowsFormsApp2
{
    class DAO
    {
        string conn = "Server=127.0.0.1; Port=3306; Database=db_ss; Uid=root; Pwd=; SslMode=none";
        protected MySqlConnection conexao = null;
        MySqlCommand comando = null;

        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conn);
                conexao.Open();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }
        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conn);
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            
        }


        public DataTable ExibirSenha()
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("SELECT * FROM tbl_senhas", conexao);

                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = comando;

                DataTable Dt = new DataTable();

                Da.Fill(Dt);

                return Dt;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void salvar(CRUD crud)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("INSERT INTO tbl_senhas(id_senha, senha, nome, categoria) VALUES (null, @senha, @nome, @categoria)", conexao);
                comando.Parameters.AddWithValue("@senha", crud.Senha);
                comando.Parameters.AddWithValue("@nome", crud.Nome);
                comando.Parameters.AddWithValue("@categoria", crud.Categoria);

                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
