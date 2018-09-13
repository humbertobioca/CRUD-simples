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
    public partial class SistemaSenhas : Form
    {
        public SistemaSenhas()
        {
            InitializeComponent();
        }


        private void Menu_cadastrar_senhas_Click(object sender, EventArgs e)
        {
            frm_Cadastro frm = new frm_Cadastro();
            frm.Show();
        }

        private void Menu_consutar_senhas_Click(object sender, EventArgs e)
        {
            frm_Consultar frm = new frm_Consultar();
            frm.Show();
        }



        private void Menu_deletar_senhas_Click(object sender, EventArgs e)
        {
            frm_Deletar frm = new frm_Deletar();
            frm.Show();
        }

        private void senhasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_Alterar frm = new frm_Alterar();
            frm.Show();
        }

        private void senhasToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            frm_Alterar frm = new frm_Alterar();
            frm.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Categoria frm = new frm_Categoria();
            frm.Show();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            try
            {
                dg_senha.DataSource = bll.ExibirSenhaDao();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao exibir os dados" + erro);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
