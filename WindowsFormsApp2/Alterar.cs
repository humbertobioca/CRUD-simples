using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace WindowsFormsApp2
{
    public partial class frm_Alterar : Form
    {
        string conn = "Server=127.0.0.1; Port=3306; Database=db_ss; Uid=root; Pwd=; SslMode=none";
        MySqlConnection conexao = null;
        MySqlCommand comando = null;



        public frm_Alterar()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try

            {
                
                string MyConnection2 = "Server=127.0.0.1; Port=3306; Database=db_ss; Uid=root; Pwd=; SslMode=none";
                
                string Query = "update tbl_senhas set senha='" + this.txtAltSenha.Text + "',nome='" + this.txtAltNome.Text +"',categoria='" + this.cbAltCategoria.Text + "' where id_senha='" + this.txtxAltId.Text + "';";
                
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Alterado");

                while (MyReader2.Read())

                {
                    
                }

                MyConn2.Close();

            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tbl_senhas WHERE id_senha=" + txtxAltId.Text;

            conexao = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            conexao.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
            this.Close();
        }
    }
}
