using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frm_Cadastro : Form
    {
        public frm_Cadastro()
        {
            InitializeComponent();
        }

        private void salvar(CRUD crud)
        {
            BLL bll = new BLL();
            crud.Senha = txt_senha.Text;
            crud.Nome = txt_jogos.Text;
            crud.Categoria = cb_categoria.Text;

            bll.salvarSenha(crud);
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CRUD crud = new CRUD();
                salvar(crud);

                MessageBox.Show("Adicionado com sucesso!");
            }
            catch(Exception erro)
            {
                throw erro;
            }

            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
