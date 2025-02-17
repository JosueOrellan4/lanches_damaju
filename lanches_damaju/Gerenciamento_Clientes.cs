using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanches_damaju
{
    public partial class Gerenciamento_Clientes : Form
    {
        public Gerenciamento_Clientes()
        {
            InitializeComponent();
        }

        private void buttonFecharClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=3306; Database=db_lanches_damaju; Uid=root; Pwd=;";


            try
            {
                //Cria uma conexão com o banco de dados MySql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //Abre conexão
                    consulta.Open();
                    //Consulta SQL para selecionar Clientes
                    string listagem = "SELECT id, Nome, Email, Senha, CEP, CPF, Numero, Telefone FROM tb_clientes";

                    //Cria o comando MySql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtém os resultados.
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        //Atribui a tabela de dados ao dataGridView
                        dgvClientes.DataSource = dadosClientes;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes: " + ex.Message);
            }

        }

        private void buttonRemoverClientesClick_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int clienteID = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //Defina sua string de conexão com o banco
                    string connectionString = "Server=localhost; Port=3306; Database=db_lanches_damaju; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados MySql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //Abre conexão
                            consulta.Open();
                            //Consulta SQL para selecionar Clientes
                            string listagem = "DELETE FROM tb_clientes WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id", clienteID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o cliente");
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }





                }
                else
                {
                    MessageBox.Show("Por favor, Selecione um cliente para excluir");
                }
            }
        }
    }
}
