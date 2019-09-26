using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Entidade;
using Model;

namespace Sistema.view
{
    public partial class frmCadUsuario : Form
    {
         usuarioEntidade objTabela = new usuarioEntidade();
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void BtbNovo_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            iniciarOpc();
        }
        private string opc = "";
        private void iniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    {
                        HabilitarCampos();
                        LimparCampos();
                        break;
                    }
                case "Salvar":
                    {
                        try
                        {
                            objTabela.Nome = txtNome.Text;
                            objTabela.Usuario = txtUsuario.Text;
                            objTabela.Senha = txtSenha.Text;

                            //int x = UsuarioModel.Inserir(objTabela);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro!");
                            throw;
                        }
                        break;
                    }
                case "Excluir":
                    {
                        break;
                    }
                case "Editar":
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }
        private void HabilitarCampos()
        {
            // para habilitar os campos que estavam desabilitados 
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            iniciarOpc();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            opc = "Excluir";
            iniciarOpc();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            opc = "Editar";
            iniciarOpc();
        }
    }
}
