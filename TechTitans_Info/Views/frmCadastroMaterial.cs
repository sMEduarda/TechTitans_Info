using System;
using System.Windows.Forms;
using TechTitans_Info.Data;
using TechTitans_Info.Models;

namespace TechTitans_Info.Views
{
    public partial class frmCadastroMaterial : Form
    {
        public frmCadastroMaterial()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório!");
                return;
            }

            if (numValor.Value <= 0)
            {
                MessageBox.Show("Valor deve ser maior que zero!");
                return;
            }

            if (numQuantidade.Value <= 0)
            {
                MessageBox.Show("Quantidade deve ser maior que zero!");
                return;
            }

            using (var db = new AppDbContext())
            {
                var material = new Material
                {
                    Nome = txtNome.Text.Trim(),
                    Tipo = txtTipo.Text.Trim(),
                    Descricao = txtDescricao.Text.Trim(),
                    Valor = numValor.Value,
                    QuantidadeDisponivel = (int)numQuantidade.Value
                };

                db.Materiais.Add(material);
                db.SaveChanges();

                MessageBox.Show("Material cadastrado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // 🔹 Botão 2: voltar para tela inicial
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmInicial = new frmInicial();
            frmInicial.Show();
        }

        // 🔹 Botão 1: limpar todos os campos
        private void button1_Click(object sender, EventArgs e)
        {
            // Limpar os campos de texto
            txtNome.Clear();
            txtTipo.Clear();
            txtDescricao.Clear();


            // Mensagem de confirmação
            MessageBox.Show("Campos limpos com sucesso!", "Limpar formulário",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
