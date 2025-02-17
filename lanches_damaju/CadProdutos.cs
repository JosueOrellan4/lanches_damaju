using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanches_damaju
{
    public partial class CadProdutos : Form
    {
        public CadProdutos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=localhost; Port=3306; Database=db_lanches_damaju; Uid=root; Pwd=;";

            string query = "INSERT INTO tb_produtos (Nome, Valor, Descricao, Categoria, Imagem) VALUES (@Nome, @Valor, @Descricao, @Categoria, @Imagem)";

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
                        comando.Parameters.AddWithValue("@Valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@Descricao ", richTextBoxDescricao.Text);
                        comando.Parameters.AddWithValue("@Categoria", textBoxCategoria.Text);

                        if (pictureBox1.Image != null)
                        {
                            // Converte a imagem para um array de bytes
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                                byte[] imagemBytes = ms.ToArray();

                                // Adiciona o parâmetro de imagem
                                comando.Parameters.AddWithValue("@Imagem", imagemBytes);
                            }
                        }
                        else
                        {
                            // Se não houver imagem, você pode definir um valor padrão ou deixá-lo nulo
                            comando.Parameters.AddWithValue("@Imagem", DBNull.Value);
                        }

                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                        textBoxNome.Text = "";
                        maskedTextBoxValor.Text = "";
                        richTextBoxDescricao.Text = "";
                        textBoxCategoria.Text = "";
                        pictureBox1.Image = null;


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

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            maskedTextBoxValor.Text = "";
            richTextBoxDescricao.Text = "";
            textBoxCategoria.Text = "";
            textBoxNome.Focus();
        }
      

        private void button4_Click(object sender, EventArgs e)
        {
            
        
            // Criar o objeto OpenFileDialog para selecionar o arquivo de imagem
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Definir o filtro para permitir apenas imagens (JPEG, PNG, etc.)
            openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            // Mostrar a caixa de diálogo para o usuário escolher a imagem
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obter o caminho completo da imagem selecionada
                string filePath = openFileDialog.FileName;

                // Carregar a imagem no PictureBox
                pictureBox1.Image = Image.FromFile(filePath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

