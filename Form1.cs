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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 chama = new Form4();
            chama.ShowDialog();
            this.Close();
        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 chama = new Form2();
            chama.ShowDialog();
            this.Close();
        }

        private void EditarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 chama = new Form3();
            chama.ShowDialog();
            this.Close();
        }
    }
}