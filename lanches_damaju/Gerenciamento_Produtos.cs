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
    public partial class Gerenciamento_Produtos : Form
    {
        public Gerenciamento_Produtos()
        {
            InitializeComponent();
        }

        private void buttonFecharClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPesquisarClientesClick_Click(object sender, EventArgs e)
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
                    string listagem = "SELECT id_produto, Nome, Valor, Descricao, Categoria FROM tb_produtos";

                    //Cria o comando MySql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtém os resultados.
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        //Atribui a tabela de dados ao dataGridView
                        dgvProdutos.DataSource = dadosClientes;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes: " + ex.Message);
            }

        }

        private void buttonRemoverProdutosClick_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int produtoID = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells["id_produto"].Value);

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
                            string listagem = "DELETE FROM tb_produtos WHERE id_produto = @id_produto";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id_produto", produtoID);

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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
