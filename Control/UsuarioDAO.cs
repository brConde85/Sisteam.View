using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidade;
using System.Data;

namespace Control
{
    public class UsuarioDAO
    {
        public int Inserir(usuarioEntidade objTabela)
        {
            // instanciando sql connection para abrir uma conexão
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                // abrindo conexão
                con.Open();
                cn.CommandText = "INSERT INTO usuarios ([nome],[usuario],[senha]) VALUES (@nome, @usuario,@senha)";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                
                // Abrindo uma outra conexção
                cn.Connection = con;
               
               
                return cn.ExecuteNonQuery();
            } 
        }
    }
}
