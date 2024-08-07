namespace Projeto._8.br.com.projeto.VIEW
{
    partial class formulario_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabela_clientes = new System.Windows.Forms.TabControl();
            this.tabPage2_dadospessoais = new System.Windows.Forms.TabPage();
            this.comboBox_uf = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_cep = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_rg = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_celular = new System.Windows.Forms.MaskedTextBox();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.textBox_bairro = new System.Windows.Forms.TextBox();
            this.textBox_compl = new System.Windows.Forms.TextBox();
            this.textBox_cidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_endereço = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_consulta = new System.Windows.Forms.TabPage();
            this.dataGridView_consulta = new System.Windows.Forms.DataGridView();
            this.button_consultaPesquisar = new System.Windows.Forms.Button();
            this.textBox_nomeconsulta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_salva = new System.Windows.Forms.Button();
            this.button_novo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabela_clientes.SuspendLayout();
            this.tabPage2_dadospessoais.SuspendLayout();
            this.tabPage_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 107);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("NewsGoth BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabela_clientes
            // 
            this.tabela_clientes.Controls.Add(this.tabPage2_dadospessoais);
            this.tabela_clientes.Controls.Add(this.tabPage_consulta);
            this.tabela_clientes.Location = new System.Drawing.Point(41, 124);
            this.tabela_clientes.Name = "tabela_clientes";
            this.tabela_clientes.SelectedIndex = 0;
            this.tabela_clientes.Size = new System.Drawing.Size(645, 358);
            this.tabela_clientes.TabIndex = 1;
            this.tabela_clientes.SelectedIndexChanged += new System.EventHandler(this.tabControl__SelectedIndexChanged);
            // 
            // tabPage2_dadospessoais
            // 
            this.tabPage2_dadospessoais.Controls.Add(this.comboBox_uf);
            this.tabPage2_dadospessoais.Controls.Add(this.maskedTextBox_cep);
            this.tabPage2_dadospessoais.Controls.Add(this.maskedTextBox_rg);
            this.tabPage2_dadospessoais.Controls.Add(this.maskedTextBox_cpf);
            this.tabPage2_dadospessoais.Controls.Add(this.maskedTextBox_telefone);
            this.tabPage2_dadospessoais.Controls.Add(this.maskedTextBox_celular);
            this.tabPage2_dadospessoais.Controls.Add(this.button_pesquisar);
            this.tabPage2_dadospessoais.Controls.Add(this.textBox_bairro);
            this.tabPage2_dadospessoais.Controls.Add(this.textBox_compl);
            this.tabPage2_dadospessoais.Controls.Add(this.textBox_cidade);
            this.tabPage2_dadospessoais.Controls.Add(this.label12);
            this.tabPage2_dadospessoais.Controls.Add(this.label15);
            this.tabPage2_dadospessoais.Controls.Add(this.label13);
            this.tabPage2_dadospessoais.Controls.Add(this.label10);
            this.tabPage2_dadospessoais.Controls.Add(this.label14);
            this.tabPage2_dadospessoais.Controls.Add(this.label11);
            this.tabPage2_dadospessoais.Controls.Add(this.label8);
            this.tabPage2_dadospessoais.Controls.Add(this.label7);
            this.tabPage2_dadospessoais.Controls.Add(this.textBox_n);
            this.tabPage2_dadospessoais.Controls.Add(this.label9);
            this.tabPage2_dadospessoais.Controls.Add(this.label6);
            this.tabPage2_dadospessoais.Controls.Add(this.textBox_endereço);
            this.tabPage2_dadospessoais.Controls.Add(this.label5);
            this.tabPage2_dadospessoais.Controls.Add(this.textBox_email);
            this.tabPage2_dadospessoais.Controls.Add(this.label4);
            this.tabPage2_dadospessoais.Controls.Add(this.textBox_nome);
            this.tabPage2_dadospessoais.Controls.Add(this.label3);
            this.tabPage2_dadospessoais.Controls.Add(this.textBox_codigo);
            this.tabPage2_dadospessoais.Controls.Add(this.label2);
            this.tabPage2_dadospessoais.Location = new System.Drawing.Point(4, 22);
            this.tabPage2_dadospessoais.Name = "tabPage2_dadospessoais";
            this.tabPage2_dadospessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2_dadospessoais.Size = new System.Drawing.Size(637, 332);
            this.tabPage2_dadospessoais.TabIndex = 1;
            this.tabPage2_dadospessoais.Text = "Dados Pessoais";
            this.tabPage2_dadospessoais.UseVisualStyleBackColor = true;
            this.tabPage2_dadospessoais.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // comboBox_uf
            // 
            this.comboBox_uf.FormattingEnabled = true;
            this.comboBox_uf.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.comboBox_uf.Location = new System.Drawing.Point(121, 289);
            this.comboBox_uf.Name = "comboBox_uf";
            this.comboBox_uf.Size = new System.Drawing.Size(121, 21);
            this.comboBox_uf.TabIndex = 12;
            // 
            // maskedTextBox_cep
            // 
            this.maskedTextBox_cep.Location = new System.Drawing.Point(482, 261);
            this.maskedTextBox_cep.Mask = "99999-999";
            this.maskedTextBox_cep.Name = "maskedTextBox_cep";
            this.maskedTextBox_cep.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_cep.TabIndex = 11;
            // 
            // maskedTextBox_rg
            // 
            this.maskedTextBox_rg.Location = new System.Drawing.Point(482, 154);
            this.maskedTextBox_rg.Mask = "99,999,999-9";
            this.maskedTextBox_rg.Name = "maskedTextBox_rg";
            this.maskedTextBox_rg.Size = new System.Drawing.Size(131, 20);
            this.maskedTextBox_rg.TabIndex = 10;
            // 
            // maskedTextBox_cpf
            // 
            this.maskedTextBox_cpf.Location = new System.Drawing.Point(121, 152);
            this.maskedTextBox_cpf.Mask = "999,999,999-99";
            this.maskedTextBox_cpf.Name = "maskedTextBox_cpf";
            this.maskedTextBox_cpf.Size = new System.Drawing.Size(127, 20);
            this.maskedTextBox_cpf.TabIndex = 9;
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(121, 115);
            this.maskedTextBox_telefone.Mask = "(99) 9 9999-9999";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(152, 20);
            this.maskedTextBox_telefone.TabIndex = 8;
            // 
            // maskedTextBox_celular
            // 
            this.maskedTextBox_celular.Location = new System.Drawing.Point(482, 117);
            this.maskedTextBox_celular.Mask = "(99) 9 9999-9999";
            this.maskedTextBox_celular.Name = "maskedTextBox_celular";
            this.maskedTextBox_celular.Size = new System.Drawing.Size(151, 20);
            this.maskedTextBox_celular.TabIndex = 7;
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_pesquisar.Location = new System.Drawing.Point(482, 299);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.button_pesquisar.TabIndex = 6;
            this.button_pesquisar.Text = "Pesquisar:";
            this.button_pesquisar.UseVisualStyleBackColor = false;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // textBox_bairro
            // 
            this.textBox_bairro.Location = new System.Drawing.Point(482, 190);
            this.textBox_bairro.Name = "textBox_bairro";
            this.textBox_bairro.Size = new System.Drawing.Size(117, 20);
            this.textBox_bairro.TabIndex = 5;
            this.textBox_bairro.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox_compl
            // 
            this.textBox_compl.Location = new System.Drawing.Point(121, 250);
            this.textBox_compl.Name = "textBox_compl";
            this.textBox_compl.Size = new System.Drawing.Size(117, 20);
            this.textBox_compl.TabIndex = 5;
            this.textBox_compl.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox_cidade
            // 
            this.textBox_cidade.Location = new System.Drawing.Point(121, 220);
            this.textBox_cidade.Name = "textBox_cidade";
            this.textBox_cidade.Size = new System.Drawing.Size(117, 20);
            this.textBox_cidade.TabIndex = 5;
            this.textBox_cidade.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(378, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Bairro:";
            this.label12.Click += new System.EventHandler(this.label3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 287);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "UF:";
            this.label15.Click += new System.EventHandler(this.label3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Compl:";
            this.label13.Click += new System.EventHandler(this.label3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cidade:";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(378, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "CEP:";
            this.label14.Click += new System.EventHandler(this.label3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(378, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nº:";
            this.label11.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(378, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Celular:";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Telefone:";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(482, 222);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(54, 20);
            this.textBox_n.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Endereço:";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "CPF:";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_endereço
            // 
            this.textBox_endereço.Location = new System.Drawing.Point(121, 188);
            this.textBox_endereço.Name = "textBox_endereço";
            this.textBox_endereço.Size = new System.Drawing.Size(186, 20);
            this.textBox_endereço.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "RG:";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(121, 83);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(364, 20);
            this.textBox_email.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(121, 48);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(364, 20);
            this.textBox_nome.TabIndex = 5;
            this.textBox_nome.TextChanged += new System.EventHandler(this.textBox_nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(121, 17);
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(100, 20);
            this.textBox_codigo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // tabPage_consulta
            // 
            this.tabPage_consulta.Controls.Add(this.dataGridView_consulta);
            this.tabPage_consulta.Controls.Add(this.button_consultaPesquisar);
            this.tabPage_consulta.Controls.Add(this.textBox_nomeconsulta);
            this.tabPage_consulta.Controls.Add(this.label16);
            this.tabPage_consulta.Location = new System.Drawing.Point(4, 22);
            this.tabPage_consulta.Name = "tabPage_consulta";
            this.tabPage_consulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_consulta.Size = new System.Drawing.Size(637, 332);
            this.tabPage_consulta.TabIndex = 0;
            this.tabPage_consulta.Text = "Consulta";
            this.tabPage_consulta.UseVisualStyleBackColor = true;
            this.tabPage_consulta.Click += new System.EventHandler(this.tabPage_consulta_Click);
            // 
            // dataGridView_consulta
            // 
            this.dataGridView_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_consulta.Location = new System.Drawing.Point(22, 50);
            this.dataGridView_consulta.Name = "dataGridView_consulta";
            this.dataGridView_consulta.Size = new System.Drawing.Size(569, 258);
            this.dataGridView_consulta.TabIndex = 8;
            this.dataGridView_consulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_consulta_CellClick);
            this.dataGridView_consulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_consulta_CellContentClick);
            // 
            // button_consultaPesquisar
            // 
            this.button_consultaPesquisar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_consultaPesquisar.Location = new System.Drawing.Point(500, 24);
            this.button_consultaPesquisar.Name = "button_consultaPesquisar";
            this.button_consultaPesquisar.Size = new System.Drawing.Size(91, 23);
            this.button_consultaPesquisar.TabIndex = 7;
            this.button_consultaPesquisar.Text = "Pesquisar:";
            this.button_consultaPesquisar.UseVisualStyleBackColor = false;
            this.button_consultaPesquisar.Click += new System.EventHandler(this.button_consultaPesquisar_Click);
            // 
            // textBox_nomeconsulta
            // 
            this.textBox_nomeconsulta.Location = new System.Drawing.Point(110, 24);
            this.textBox_nomeconsulta.Name = "textBox_nomeconsulta";
            this.textBox_nomeconsulta.Size = new System.Drawing.Size(369, 20);
            this.textBox_nomeconsulta.TabIndex = 1;
            this.textBox_nomeconsulta.TextChanged += new System.EventHandler(this.textBox_nomeconsulta_TextChanged);
            this.textBox_nomeconsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nomeconsulta_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Nome:";
            // 
            // button_editar
            // 
            this.button_editar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_editar.Location = new System.Drawing.Point(45, 515);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(115, 48);
            this.button_editar.TabIndex = 2;
            this.button_editar.Text = "Editar";
            this.button_editar.UseVisualStyleBackColor = false;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_excluir.Location = new System.Drawing.Point(569, 515);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(117, 48);
            this.button_excluir.TabIndex = 2;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_salva
            // 
            this.button_salva.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_salva.Location = new System.Drawing.Point(224, 515);
            this.button_salva.Name = "button_salva";
            this.button_salva.Size = new System.Drawing.Size(120, 48);
            this.button_salva.TabIndex = 2;
            this.button_salva.Text = "Salvar";
            this.button_salva.UseVisualStyleBackColor = false;
            this.button_salva.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_novo
            // 
            this.button_novo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_novo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_novo.Location = new System.Drawing.Point(398, 515);
            this.button_novo.Name = "button_novo";
            this.button_novo.Size = new System.Drawing.Size(117, 48);
            this.button_novo.TabIndex = 2;
            this.button_novo.Text = "Novo";
            this.button_novo.UseVisualStyleBackColor = false;
            // 
            // formulario_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 634);
            this.Controls.Add(this.button_novo);
            this.Controls.Add(this.button_salva);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_editar);
            this.Controls.Add(this.tabela_clientes);
            this.Controls.Add(this.panel1);
            this.Name = "formulario_Clientes";
            this.Text = "formulario_Clientes";
            this.Load += new System.EventHandler(this.formulario_Clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabela_clientes.ResumeLayout(false);
            this.tabPage2_dadospessoais.ResumeLayout(false);
            this.tabPage2_dadospessoais.PerformLayout();
            this.tabPage_consulta.ResumeLayout(false);
            this.tabPage_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabela_clientes;
        private System.Windows.Forms.TabPage tabPage_consulta;
        private System.Windows.Forms.TabPage tabPage2_dadospessoais;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_endereço;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_bairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.TextBox textBox_compl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_salva;
        private System.Windows.Forms.Button button_novo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cep;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_rg;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_celular;
        private System.Windows.Forms.ComboBox comboBox_uf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView_consulta;
        private System.Windows.Forms.Button button_consultaPesquisar;
        private System.Windows.Forms.TextBox textBox_nomeconsulta;
        private System.Windows.Forms.Label label16;
    }
}