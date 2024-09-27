using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace listaTelefonica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection
                ("server=127.0.0.1;userid=root;password=root;database=telefonia");

                conn.Open();

                string dataCadastro = DateTime.Now.ToString("yyyy-MM-dd");

                string query = "INSERT INTO `contatos` (nome, telefone, identificacao, dataCadastro) VALUES (@nome, @telefone, @identificacao, @data);";

                using (MySqlCommand comando = new MySqlCommand(query, conn))
                {   
                    comando.Parameters.AddWithValue("@nome", txbNome.Text);
                    comando.Parameters.AddWithValue("@telefone", txbTelefone.Text);
                    comando.Parameters.AddWithValue("@identificacao", cbxIdentificacao.Text);
                    comando.Parameters.AddWithValue("@data", dataCadastro);  // Adicionando o parâmetro de data corretamente

                    comando.ExecuteNonQuery();
                }
                MessageBox.Show("Contato salvo", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                lblErro.Text = ex.Message;
            }
            finally
            {
                txbNome.Text = "";
                txbTelefone.Text = "";
                lblErro.Text = "";
                cbxIdentificacao.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
            lblTelefoneEncontrado.Text = "";
        }


        private void cbxEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbxEscolha.SelectedIndex)
            {
                case 0:
                    lblTelefoneEncontrado.Text = "";
                    lstLista.Items.Clear();
                    lblBuscar.Location = new Point(88, 70);
                    cbxEscolha.Location = new Point(160, 67);
                    btnListar.Location = new Point(253, 67);
                    cbxTelefones.Visible = false;
                    cbxIdentifica.Visible = false;
                    txbNomeLista.Visible = false;
                    break; 
                
                case 1:
                    lblTelefoneEncontrado.Text = "";
                    lstLista.Items.Clear();
                    lblBuscar.Location = new Point(40, 70);
                    cbxEscolha.Location = new Point(110, 67);
                    txbNomeLista.Location = new Point(200, 67);
                    btnListar.Location = new Point(290, 67);
                    cbxTelefones.Visible = false;
                    cbxIdentifica.Visible = false;
                    txbNomeLista.Visible = true;
                    break;

                case 2:
                    lblTelefoneEncontrado.Text = "";
                    lstLista.Items.Clear();
                    lblBuscar.Location = new Point(40, 70);
                    cbxEscolha.Location = new Point(110, 67);
                    cbxTelefones.Location = new Point(200, 67);
                    btnListar.Location = new Point(290, 67);
                    cbxTelefones.Visible = true;
                    cbxIdentifica.Visible = false;
                    txbNomeLista.Visible = false;
                    break;

                case 3:
                    lblTelefoneEncontrado.Text = "";
                    lstLista.Items.Clear();
                    lblBuscar.Location = new Point(40, 70);
                    cbxEscolha.Location = new Point(110, 67);
                    cbxIdentifica.Location = new Point(200, 67);
                    btnListar.Location = new Point(290, 67);
                    cbxTelefones.Visible = false;
                    cbxIdentifica.Visible = true;
                    txbNomeLista.Visible = false;

                    break;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=telefonia");
                conn.Open();
                string Nome = txbNomeLista.Text;
                string Telefone = cbxTelefones.Text;
                string Identifica = cbxIdentifica.Text;         

                int desc = cbxEscolha.SelectedIndex;
                MySqlCommand cmd;
                MySqlDataReader reader;

                switch (desc)
                {
                    case 0:
                        try
                        {
                            // Cria o comando SQL para selecionar todos os registros
                            cmd = new MySqlCommand("SELECT * FROM `contatos`", conn);
                            reader = cmd.ExecuteReader();

                            lstLista.Items.Clear();

                            // Verifica se há registros retornados
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    lstLista.Items.Add("Id contato: " + reader.GetInt32(0));
                                    lstLista.Items.Add("Nome: " + reader.GetString(1));
                                    lstLista.Items.Add("Telefone: " + reader.GetString(2));
                                    lstLista.Items.Add("Quem é essa pessoa: " + reader.GetString(3));
                                    lstLista.Items.Add("-----------------------------------" + "\n");
                                }
                            }
                            else
                            {
                                lstLista.Items.Add("Nenhuma moeda encontrada.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex.Message);
                        }
                        finally
                        {
                            cmd = null;
                        }
                        break ; 
                    
                    case 1:
                        if (string.IsNullOrEmpty(Nome))
                        {
                            MessageBox.Show("Digite alguma coisa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                lstLista.Items.Clear();

                                // Certifica se a conexão está aberta
                                if (conn.State != ConnectionState.Open)
                                {
                                    conn.Open();
                                }

                                cmd = new MySqlCommand("SELECT `nome`,`telefone`,`identificacao` FROM `contatos` WHERE `nome` = @nome", conn);
                                cmd.Parameters.AddWithValue("@nome", Nome);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    // Use o índice correto: 0 para a primeira coluna
                                    lstLista.Items.Add("Nome encontrado: " + reader.GetString(0));
                                    lstLista.Items.Add("Telefone associado: " + reader.GetString(1));
                                    lstLista.Items.Add("Quem é essa pessoa? " + reader.GetString(2));
                                    lstLista.Items.Add("-----------------------------------");
                                }
                                reader.Close();
                            }
                            catch (Exception ex)
                            {
                                lblErro1.Text = "Erro: " + ex.Message;
                            }
                            finally
                            {
                                cmd = null; // Libera o comando
                            }
                        }
                        break;

                    case 2:
                        if (string.IsNullOrEmpty(Telefone))
                        {
                            MessageBox.Show("Escolha alguma opção", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                lstLista.Items.Clear();

                                // Certifica se a conexão está aberta
                                if (conn.State != ConnectionState.Open)
                                {
                                    conn.Open();
                                }

                                cmd = new MySqlCommand("SELECT `nome`,`telefone`, `identificacao` FROM `contatos` WHERE `telefone` = @telefone", conn);
                                cmd.Parameters.AddWithValue("@telefone", Telefone);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    lblTelefoneEncontrado.Text = "Telefone encontrado: " + reader.GetString(1);
                                    // Use o índice correto: 0 para a primeira coluna
                                    lstLista.Items.Add("\n" + "\n");
                                    lstLista.Items.Add("Nome associado: " + reader.GetString(0));
                                    lstLista.Items.Add("Quem é essa pessoa? " + reader.GetString(2));
                                    lstLista.Items.Add("\n" + "-----------------------------------" + "\n");
                                }
                                reader.Close();
                            }
                            catch (Exception ex)
                            {
                                lblErro1.Text = "Erro: " + ex.Message;
                            }
                            finally
                            {
                                cmd = null; // Libera o comando
                            }
                        }
                        break; 

                    case 3:
                        if (string.IsNullOrEmpty(Identifica))
                        {
                            MessageBox.Show("Escolha alguma opção", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                lstLista.Items.Clear();

                                // Certifica se a conexão está aberta
                                if (conn.State != ConnectionState.Open)
                                {
                                    conn.Open();
                                }

                                cmd = new MySqlCommand("SELECT `nome`,`telefone`,`identificacao` FROM `contatos` WHERE `identificacao` = @identifica", conn);
                                cmd.Parameters.AddWithValue("@Identifica", Identifica);
                                reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    lblTelefoneEncontrado.Text = "Identificação de contato: " + reader.GetString(2);
                                    // Use o índice correto: 0 para a primeira coluna
                                    lstLista.Items.Add("\n" + "\n");
                                    lstLista.Items.Add("Nome associado: " + reader.GetString(0));
                                    lstLista.Items.Add("Telefone " + reader.GetString(1));
                                    lstLista.Items.Add("\n" + "-----------------------------------" + "\n");
                                }
                                reader.Close();
                            }
                            catch (Exception ex)
                            {
                                lblErro1.Text = "Erro: " + ex.Message;
                            }
                            finally
                            {
                                cmd = null; // Libera o comando
                            }
                        }
                        break; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBuscar.Location = new Point(88, 70);
            cbxEscolha.Location = new Point(160, 67);
            btnListar.Location = new Point(253, 67);
            cbxTelefones.Visible = false;
            cbxIdentifica.Visible = false;
            txbNomeLista.Visible = false;
            lblTelefoneEncontrado.Text = "";
            lblErro1.Text = "";
            lblErro.Text = "";

            try
            {
                MySqlConnection conn = new MySqlConnection("server=127.0.0.1;userid=root;password=root;database=telefonia");
                conn.Open();
                MySqlCommand inserir = new MySqlCommand("SELECT `telefone` FROM `contatos`;", conn);
                MySqlDataReader ler = inserir.ExecuteReader();
                while (ler.Read())
                {
                    cbxTelefones.Items.Add(ler[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxTelefones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
