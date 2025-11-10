using System;
using System.Linq;
using System.Windows.Forms;
using TechTitans_Info.Data;
using TechTitans_Info.Models;

namespace TechTitans_Info.Views
{
    public partial class frmAdicionarPecaOS : Form
    {
        private int _osId;

        public frmAdicionarPecaOS(int osId)
        {
            _osId = osId;
            InitializeComponent();
        }

        private void frmAdicionarPecaOS_Load(object sender, EventArgs e)
        {
            CarregarMateriais();
        }

        private void CarregarMateriais()
        {
            using (var db = new AppDbContext())
            {
                // 1. Busca apenas os IDs e dados necessários
                var materiais = db.Materiais
                    .Where(m => m.QuantidadeDisponivel > 0)
                    .Select(m => new
                    {
                        m.Id,
                        m.Nome,
                        m.Valor,
                        m.QuantidadeDisponivel
                    })
                    .ToList(); // ← FORÇA EXECUÇÃO NO C#

                // 2. Cria o Display no código (agora é permitido!)
                var listaDisplay = materiais.Select(m => new
                {
                    m.Id,
                    Display = $"{m.Nome} (R$ {m.Valor:F2}) - {m.QuantidadeDisponivel} un"
                }).ToList();

                cmbMaterial.DataSource = listaDisplay;
                cmbMaterial.DisplayMember = "Display";
                cmbMaterial.ValueMember = "Id";

                // Se não tiver materiais
                if (!listaDisplay.Any())
                {
                    MessageBox.Show("Nenhum material com estoque disponível.");
                    this.Close();
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cmbMaterial.SelectedValue == null) return;

            int materialId = (int)cmbMaterial.SelectedValue;
            int qtd = (int)numQuantidade.Value;

            using (var db = new AppDbContext())
            {
                var material = db.Materiais.Find(materialId);
                if (material == null || material.QuantidadeDisponivel < qtd)
                {
                    MessageBox.Show("Estoque insuficiente!");
                    return;
                }

                // Baixa no estoque
                material.QuantidadeDisponivel -= qtd;

                // Adiciona item na OS
                var item = new ItemOrdemServico
                {
                    OrdemServicoId = _osId,
                    MaterialId = materialId,
                    QuantidadeUsada = qtd,
                    ValorUnitario = material.Valor
                };

                db.ItensOrdemServico.Add(item);
                db.SaveChanges();

                MessageBox.Show("Peça adicionada e estoque atualizado!");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmInicial = new frmInicial();
            frmInicial.Show();
        }

    }
}