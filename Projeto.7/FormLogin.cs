using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto._7
{
    public partial class FormLogin : Form

    {
        public static bool Cancelar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            string nome = textBox_usuario.Text;
            string senha = textBox_senha.Text;

            if(CadastrosUsuarios.Login(nome, senha))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado!");
                textBox_usuario.Text = "";
                textBox_senha.Text = "";
                textBox_usuario.Focus();
                Close();
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
