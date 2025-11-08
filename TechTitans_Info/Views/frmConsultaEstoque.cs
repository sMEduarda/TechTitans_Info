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

        private void CarregarEstoque()
        {
            using (var db = new AppDbContext())
            {
                var dados = db.Materiais
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
            }
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
                    MessageBox.Show("Estoque atualizado!");
                    CarregarEstoque();
                }
            }
        }
    }
}