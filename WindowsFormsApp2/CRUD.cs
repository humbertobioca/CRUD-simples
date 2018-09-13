using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class CRUD
    {
        int id_senha;
        int id_categoria;
        string nome;
        string senha;
        string categoria;


        public int Id_senha
        {
            get { return id_senha; }
            set { id_senha = value; }
        }

        public int Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
    }
}
