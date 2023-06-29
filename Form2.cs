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
    public partial class Form2 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        String sql_query;
        public Form2()
        {
            InitializeComponent();

        }

        private void lbl_cadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 chama = new Form1();
            chama.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=DESKTOP-PVS0UJ2\SQLEXPRESS;Database=slc#;trusted_connection=yes");
            }
            catch
            {
                MessageBox.Show("falha na conexao", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                sql_query = "insert into usuarios (usuario, senha, email, nome, cpf, data_nasc) values (@usuario, @senha, @email, @nome, @cpf, @data_nasc)";
                comando = new SqlCommand(sql_query, conexao);
                comando.Parameters.AddWithValue("@usuario", txt_usuario.Text);
                comando.Parameters.AddWithValue("@senha", txt_senha.Text);
                comando.Parameters.AddWithValue("@email", txt_email.Text);
                comando.Parameters.AddWithValue("@nome", txt_nome.Text);
                comando.Parameters.AddWithValue("@cpf", txt_cpf.Text);
                comando.Parameters.AddWithValue("@data_nasc", txt_data.Value);
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();

            }
            catch
            {
                MessageBox.Show("Erro ao Gravar!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
