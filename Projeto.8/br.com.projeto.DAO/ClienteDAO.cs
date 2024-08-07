using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using Projeto._8.br.com.projeo.CONEXAO;
using Projeto._8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto._8.br.com.projeto.DAO
{
    internal class ClienteDAO
    {
        #region Conexão
        private MySqlConnection conexao;


        public ClienteDAO()
        {
            conexao = new Conexao().GetConnection();
        }
        #endregion
        #region Cadastrar

        public void CadastrarClientes(Clientes obj)
        {
            try
            {
                //1 passo - Definir comando SQL
                string sql = @"INSERT INTO tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) VALUES(@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                // 2 - Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", obj.nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.rg);
                executarcmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executarcmd.Parameters.AddWithValue("@email", obj.email);
                executarcmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executarcmd.Parameters.AddWithValue("@celular", obj.celular);
                executarcmd.Parameters.AddWithValue("@cep", obj.cep);
                executarcmd.Parameters.AddWithValue("@endereco", obj.endereço);
                executarcmd.Parameters.AddWithValue("@numero", obj.numero);
                executarcmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executarcmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executarcmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executarcmd.Parameters.AddWithValue("@estado", obj.estado);

                //3 passo - abrir conexao e executar comando sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastro com Sucesso");

                //4 passo - Fechar Conexão
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro" + erro);
            }
        }
        #endregion


        #region Listar
        public DataTable listarcliente()
        {
            try
            {
                //1 passo - Instanciar o DataTable
                DataTable tabelaCliente = new DataTable();

                //2 passo - Definir comando SQL
                string sql = @"SELECT * FROM tb_clientes";

                // 3 - Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);


                //4 passo - abrir conexao e executar comando sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();



                //5 passo - preenchemos os dados do DataTable

                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaCliente);

                //6 passo - Fechar Conexão
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {

                return null;
            }
        }
        #endregion
        #region Alterar
        public void alterarCliente(Clientes obj)
        {
            try
            {
                //1 passo - Definir comando SQL
                string sql = @"UPDATE  tb_clientes SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado WHERE id=@id";

                // 2 - Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", obj.nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.rg);
                executarcmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executarcmd.Parameters.AddWithValue("@email", obj.email);
                executarcmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executarcmd.Parameters.AddWithValue("@celular", obj.celular);
                executarcmd.Parameters.AddWithValue("@cep", obj.cep);
                executarcmd.Parameters.AddWithValue("@endereco", obj.endereço);
                executarcmd.Parameters.AddWithValue("@numero", obj.numero);
                executarcmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executarcmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executarcmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executarcmd.Parameters.AddWithValue("@estado", obj.estado);

                executarcmd.Parameters.AddWithValue("@id", obj.codigo);

                //3 passo - abrir conexao e executar comando sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Alterado com Sucesso");

                //4 passo - Fechar Conexão
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu o erro" + erro);
            }

        }
        #endregion



        #region Excluir

        
        public void excluirClientes(Clientes obj)
        {
            try
            {
                //1 passo - Definir comando SQL
                string sql = @"DELETE FROM tb_clientes WHERE id=@id";
                // 2 - Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@id", obj.codigo);



                //3 passo - abrir conexao e executar comando sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com Sucesso");

                //4 passo - Fechar Conexão
                conexao.Close();
            }
            catch (Exception erro)
            {

            }
        }
        #endregion

        #region Buscar Cliente - Por Nome
        public DataTable BuscarClientePorNome(string nome)
        {
            try
            {
                //1 passo - Instanciar o DataTable
                DataTable tabelaCliente = new DataTable();

                //2 passo - Definir comando SQL
                string sql = @"SELECT * FROM tb_clientes WHERE nome = @nome";


                // 3 - Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                executarcmd.Parameters.AddWithValue("@nome", nome);

                //4 passo - abrir conexao e executar comando sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();



                //5 passo - preenchemos os dados do DataTable

                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaCliente);

                //6 passo - Fechar Conexão
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {

                return null;
            }
        }
        #endregion

        #region Buscar Cliente - Listando
        public DataTable BuscarClienteListando(string nome)
        {
            try
            {
                //1 passo - Instanciar o DataTable
                DataTable tabelaCliente = new DataTable();

                //2 passo - Definir comando SQL
                string sql = @"SELECT * FROM tb_clientes WHERE nome LIKE  @nome";


                // 3 - Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);

                executarcmd.Parameters.AddWithValue("@nome", nome);

                //4 passo - abrir conexao e executar comando sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();



                //5 passo - preenchemos os dados do DataTable

                MySqlDataAdapter dg = new MySqlDataAdapter(executarcmd);
                dg.Fill(tabelaCliente);

                //6 passo - Fechar Conexão
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception erro)
            {

                return null;
            }
        }
        #endregion
    }
}

