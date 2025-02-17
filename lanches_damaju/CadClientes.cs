using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace lanches_damaju
{
    public partial class CadClientes : Form
    {
        public CadClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {





            string conexaoString = "Server=localhost; Port=3306; Database=db_lanches_damaju; Uid=root; Pwd=;";

            string query = "INSERT INTO tb_Clientes (Nome, Email, Senha, CEP, CPF, Numero, Telefone) VALUES (@Nome, @Email, @Senha, @CEP, @CPF, @Numero, @Telefone)";


            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    //Abre a conexão
                    conexao.Open();
                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        //Adicionar os parâmentros com os valores dos TextBox
                        comando.Parameters.AddWithValue("@Nome", textBoxNome.Text);
                        comando.Parameters.AddWithValue("@Email", maskedTextBoxEmail.Text);
                        comando.Parameters.AddWithValue("@Senha", textBoxSenha.Text);
                        comando.Parameters.AddWithValue("@Cep", maskedTextBoxCEP.Text);
                        comando.Parameters.AddWithValue("@CPF", maskedTextBoxCPF.Text);
                        comando.Parameters.AddWithValue("@Numero", maskedTextBoxNumero.Text);
                        comando.Parameters.AddWithValue("@Telefone", maskedTextBoxTelefone.Text);

                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                        textBoxNome.Text = "";
                        maskedTextBoxEmail.Text = "";
                        textBoxSenha.Text = "";
                        maskedTextBoxCEP.Text = "";
                        maskedTextBoxCPF.Text = "";
                        maskedTextBoxNumero.Text = "";
                        
                        textBoxNome.Focus();
                    }
                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba menssagem do erro
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            maskedTextBoxEmail.Text = "";
            textBoxSenha.Text = "";
            maskedTextBoxCEP.Text = "";
            maskedTextBoxCPF.Text = "";
            maskedTextBoxNumero.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxNome.Focus();
        }
    }
}
