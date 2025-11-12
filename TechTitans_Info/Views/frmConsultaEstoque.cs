using System;
using System.Linq;
using System.Windows.Forms;
using TechTitans_Info.Data;
using TechTitans_Info.Models;

namespace TechTitans_Info.Views
{
    public partial class frmConsultaEstoque : Form
    {
        public frmConsultaEstoque()
        {
            InitializeComponent();
        }

        private void frmConsultaEstoque_Load(object sender, EventArgs e)
        {
            CarregarEstoque();
        }

        private void CarregarEstoque(string idFiltro = "", string nomeFiltro = "", string tipoFiltro = "")
        {
            using (var db = new AppDbContext())
            {
                var query = db.Materiais.AsQueryable();

                // 🔎 Aplica os filtros
                if (!string.IsNullOrWhiteSpace(idFiltro) && int.TryParse(idFiltro, out int id))
                    query = query.Where(m => m.Id == id);

                if (!string.IsNullOrWhiteSpace(nomeFiltro))
                    query = query.Where(m => m.Nome.Contains(nomeFiltro));

                if (!string.IsNullOrWhiteSpace(tipoFiltro))
                    query = query.Where(m => m.Tipo.Contains(tipoFiltro));

                var dados = query
                    .Select(m => new
                    {
                        m.Id,
                        m.Nome,
                        m.Tipo,
                        m.Valor,
                        m.QuantidadeDisponivel
                    })
                    .ToList();

                dgvEstoque.DataSource = dados;

                // ✅ Ajuste automático das colunas
                dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEstoque.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvEstoque.Columns["Nome"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarEstoque(txtFiltroId.Text, txtFiltroNome.Text, txtFiltroTipo.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtFiltroId.Clear();
            txtFiltroNome.Clear();
            txtFiltroTipo.Clear();
            CarregarEstoque();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.CurrentRow == null) return;

            int id = (int)dgvEstoque.CurrentRow.Cells["Id"].Value;
            int novaQtd = (int)numNovaQuantidade.Value;

            if (novaQtd < 0)
            {
                MessageBox.Show("Quantidade não pode ser negativa!");
                return;
            }

            using (var db = new AppDbContext())
            {
                var material = db.Materiais.Find(id);
                if (material != null)
                {
                    material.QuantidadeDisponivel = novaQtd;
                    db.SaveChanges();
                    MessageBox.Show("Estoque atualizado com sucesso!");
                    CarregarEstoque();
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmInicial = new frmInicial();
            frmInicial.Show();
        }
    }
}
