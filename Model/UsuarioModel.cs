using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidade;
using Control;


namespace Model
{
    public class UsuarioModel
    {
        public static int Inserir(usuarioEntidade objTabela)
        {
            // para retornar um valor quando algo for inserido
            return new UsuarioDAO().Inserir(objTabela);
        }
    }
}
