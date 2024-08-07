using Projeto._8.br.com.projeto.DAO;
using Projeto._8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Projeto._8.br.com.projeto.VIEW
{
    public partial class formulario_Clientes : Form
    {
        public formulario_Clientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void formulario_Clientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dataGridView_consulta.DataSource = dao.listarcliente();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Clientes obj = new Clientes();

            //1 passo - Receber os dados
            obj.nome = textBox_nome.Text;
            obj.rg = maskedTextBox_rg.Text.Replace(",", ".");
            obj.cpf = maskedTextBox_cpf.Text.Replace(",", ".");
            obj.email = textBox_email.Text;
            obj.telefone = maskedTextBox_telefone.Text;
            obj.celular = maskedTextBox_celular.Text;
            obj.cep = maskedTextBox_cep.Text;
            obj.endereço = textBox_endereço.Text;
            obj.numero = int.Parse(textBox_n.Text);
            obj.complemento = textBox_compl.Text;
            obj.bairro = textBox_bairro.Text;
            obj.cidade = textBox_cidade.Text;
            obj.estado = comboBox_uf.Text;

            //2 passo - Criar o objeto e chamar o metodo
            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarClientes(obj);

            //Recarregar o dataGrid
            dataGridView_consulta.DataSource = dao.listarcliente();



        }

        private void tabControl__SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage_consulta_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados

            textBox_codigo.Text = dataGridView_consulta.CurrentRow.Cells[0].Value.ToString();
            textBox_nome.Text = dataGridView_consulta.CurrentRow.Cells[1].Value.ToString();
            textBox_email.Text = dataGridView_consulta.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_telefone.Text = dataGridView_consulta.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox_celular.Text = dataGridView_consulta.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox_cpf.Text = dataGridView_consulta.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox_rg.Text = dataGridView_consulta.CurrentRow.Cells[6].Value.ToString();
            textBox_endereço.Text = dataGridView_consulta.CurrentRow.Cells[7].Value.ToString();
            textBox_bairro.Text = dataGridView_consulta.CurrentRow.Cells[8].Value.ToString();
            textBox_cidade.Text = dataGridView_consulta.CurrentRow.Cells[9].Value.ToString();
            textBox_n.Text = dataGridView_consulta.CurrentRow.Cells[10].Value.ToString();
            textBox_compl.Text = dataGridView_consulta.CurrentRow.Cells[11].Value.ToString();
            maskedTextBox_cep.Text = dataGridView_consulta.CurrentRow.Cells[12].Value.ToString();
            comboBox_uf.Text = dataGridView_consulta.CurrentRow.Cells[13].Value.ToString();

            //Alterar para guia Dados Pessoais
            tabela_clientes.SelectedTab = tabPage2_dadospessoais;
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            //1 passo - Receber os dados
            obj.nome = textBox_nome.Text;
            obj.rg = maskedTextBox_rg.Text.Replace(",", ".");
            obj.cpf = maskedTextBox_cpf.Text.Replace(",", ".");
            obj.email = textBox_email.Text;
            obj.telefone = maskedTextBox_telefone.Text;
            obj.celular = maskedTextBox_celular.Text;
            obj.cep = maskedTextBox_cep.Text;
            obj.endereço = textBox_endereço.Text;
            obj.numero = int.Parse(textBox_n.Text);
            obj.complemento = textBox_compl.Text;
            obj.bairro = textBox_bairro.Text;
            obj.cidade = textBox_cidade.Text;
            obj.estado = comboBox_uf.Text;

            obj.codigo = textBox_codigo.Text;

            //2 passo - Criar o objeto e chamar o metodo
            ClienteDAO dao = new ClienteDAO();

            dao.alterarCliente(obj);

            //Recarregar o dataGrid
            dataGridView_consulta.DataSource = dao.listarcliente();

        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            //1 passo - Receber os dados

            obj.codigo = textBox_codigo.Text;



            //2 passo - Criar o objeto e chamar o metodo
            ClienteDAO dao = new ClienteDAO();

            dao.excluirClientes(obj);

            //Recarregar o dataGrid
            dataGridView_consulta.DataSource = dao.listarcliente();

            tabela_clientes.SelectedTab = tabPage_consulta;
        }

        private void button_consultaPesquisar_Click(object sender, EventArgs e)
        {
            string nome = textBox_nomeconsulta.Text;
            ClienteDAO dao = new ClienteDAO();

            dataGridView_consulta.DataSource = dao.BuscarClientePorNome(nome);

            if(dataGridView_consulta.Rows.Count == 0)
            {
                dataGridView_consulta.DataSource = dao.listarcliente();
            }
        }

        private void textBox_nomeconsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_nomeconsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + textBox_nomeconsulta.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            dataGridView_consulta.DataSource = dao.BuscarClienteListando(nome);
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            try
            {


                string cep = maskedTextBox_cep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                textBox_endereço.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                textBox_bairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                textBox_cidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                textBox_compl.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                comboBox_uf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor verifique.");
                throw;
            }
        }
        }
    }
    

        

