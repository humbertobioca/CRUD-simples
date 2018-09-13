using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WindowsFormsApp2
{
    class BLL 
    {
        


        public DataTable ExibirSenhaDao()
        {
            DAO dao = null;
            try
            {
                DataTable DataT = new DataTable();
                dao = new DAO();

                DataT = dao.ExibirSenha();
                return DataT;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void salvarSenha(CRUD crud)
        {
            DAO dao = new DAO();
            try
            {
                dao.salvar(crud);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
