using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto._7
{
    static class CadastrosUsuarios
    {
        private static Usuario[] usuarios =
        {

            //Criando Usuarios que poderão acessar

            new Usuario(){Nome = "Aline", Senha = "1234"},
            new Usuario(){Nome = "Diego", Senha = "abc123"},
            new Usuario(){Nome = "Cassio", Senha = "abcd"}
        };

        //Verificar o usuario que esta logado

        private static Usuario _userLogado = null;

        //Defini o valor e ativa o array acima

        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }

            set { _userLogado = value; }
        }

        // Controle de Login

        public static bool Login(string nome, string senha)
        {
            foreach(Usuario usuario in usuarios)
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
        