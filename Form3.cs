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

namespace StarLanchesC
{
    public partial class Form3 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        String sql_query;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-PVS0UJ2\SQLEXPRESS;Database=slc#;trusted_connection=yes");
                sql_query = "select * from usuarios order by nome asc";
                SqlDataAdapter data = new SqlDataAdapter(sql_query, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_dados.DataSource = tabela.Tables[0];
                dgv_dados.Refresh();
            }
            catch
            {
                MessageBox.Show("falha na conexao", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                sql_query = "select * from usuarios where cpf = '" + txt_cpf.Text + "'";
                SqlDataAdapter data = new SqlDataAdapter(sql_query, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                txt_usuario.Text = tabela.Tables[0].Rows[0]["usuario"].ToString();
                txt_senha.Text = tabela.Tables[0].Rows[0]["senha"].ToString();
                txt_email.Text = tabela.Tables[0].Rows[0]["email"].ToString();
                txt_nome.Text = tabela.Tables[0].Rows[0]["nome"].ToString();
                txt_cpf.Text = tabela.Tables[0].Rows[0]["cpf"].ToString();
                txt_data.Text = tabela.Tables[0].Rows[0]["data_nasc"].ToString();
            }
            catch
            {
                MessageBox.Show("CPF não localizado!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sql_query = "select * from usuarios where nome like '" + txt_buscar.Text + "%'";
                SqlDataAdapter data = new SqlDataAdapter(sql_query, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_dados.DataSource = tabela.Tables[0];
                dgv_dados.Refresh();
            }
            finally
            {
                conexao.Close();
            }

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                sql_query = "update usuarios set usuario=@usuario, senha=@senha, email=@email, nome=@nome, data_nasc=@data_nasc where cpf=@cpf";
                comando = new SqlCommand(sql_query, conexao);
                comando.Parameters.AddWithValue("@usuario", txt_usuario.Text);
                comando.Parameters.AddWithValue("@senha", txt_senha.Text);
                comando.Parameters.AddWithValue("@email", txt_email.Text);
                comando.Parameters.AddWithValue("@nome", txt_nome.Text);
                comando.Parameters.AddWithValue("@cpf", txt_cpf.Text);
                comando.Parameters.AddWithValue("@data_nasc", txt_data.Text);
                comando.ExecuteNonQuery();
                comando.CommandType = CommandType.Text;
                MessageBox.Show("Dados alterados com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sql_query = "select * from usuarios order by nome asc";
                SqlDataAdapter data = new SqlDataAdapter(sql_query, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_dados.DataSource = tabela.Tables[0];
                dgv_dados.Refresh();
                txt_usuario.Clear();
                txt_senha.Clear();
                txt_email.Clear();
                txt_nome.Clear();
                txt_cpf.Clear();
                txt_data.Clear();
                txt_cpf.Focus();

            }
            catch
            {
                MessageBox.Show("Erro ao alterar dados!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexao.Close();
            }
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                sql_query = "delete from usuarios where cpf=@cpf";
                comando = new SqlCommand(sql_query, conexao);
                comando.Parameters.AddWithValue("@CPF", txt_cpf.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Dados excluído com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sql_query = "select * from usuarios order by nome asc";
                SqlDataAdapter data = new SqlDataAdapter(sql_query, conexao);
                DataSet tabela = new DataSet();
                data.Fill(tabela);
                dgv_dados.DataSource = tabela.Tables[0];
                dgv_dados.Refresh();
                txt_usuario.Clear();
                txt_senha.Clear();
                txt_email.Clear();
                txt_nome.Clear();
                txt_cpf.Clear();
                txt_data.Clear();
                txt_cpf.Focus();

            }

            catch
            {
                MessageBox.Show("Erro ao excluir!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            Form1 chama = new Form1();
            chama.ShowDialog();
            this.Close();
        }

        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form2 chama = new Form2();
            chama.ShowDialog();
            this.Close();
        }
        
    }
}