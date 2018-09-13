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
    public partial class frm_Consultar : Form
    {
        string conn = "Server=127.0.0.1; Port=3306; Database=db_ss; Uid=root; Pwd=; SslMode=none";
        MySqlConnection conexao = null;
        bool novo;
        public frm_Consultar()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbl_senhas WHERE id_senha=" + txtconsId.Text;

            conexao = new MySqlConnection(conn);
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader;
            conexao.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtConsNome.Enabled = true;
                    txtConsSenha.Enabled = true;
                    txtConsCategoria.Enabled = true;
                    txtConsSenha.Focus();
                    txtconsId.Text = reader[0].ToString();
                    txtConsSenha.Text = reader[1].ToString();
                    txtConsNome.Text = reader[2].ToString();
                    txtConsCategoria.Text = reader[3].ToString();
                    novo = false;
                }
                else
                    MessageBox.Show("Nenhum registro encontrado com o Id informado!");
       

     }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conexao.Close();
            }

            txtconsId.Text = "";

        }

        private void btnSairCons_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

