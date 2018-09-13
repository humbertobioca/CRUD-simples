using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp2
{
    public partial class frm_Categoria : Form
    {
        private DataSet DSet;
        private MySqlConnection conexao;
        private MySqlDataAdapter Adapter;
        public frm_Categoria()
        {
            InitializeComponent();
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            DSet = new DataSet();
            conexao = new MySqlConnection(" Persist Security Info = False; server = localhost; database = mydb; uid = root; pwd =matheus80");
            //MySqlConnection conexao = new MySqlConnection("Server=localhost; Database=mydb; User id=root; Password=matheus80");
            
            try
            {
                conexao.Open();
                MessageBox.Show("Conectou mizera!");
            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao banco!");
            }
        }
    }
}
