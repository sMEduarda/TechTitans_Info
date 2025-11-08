using System;
using System.Linq;
using System.Windows.Forms;
using TechTitans_Info.Data;
using TechTitans_Info.Models;

namespace TechTitans_Info.Views
{
    public partial class frmFecharOrdens : Form
    {
        public frmFecharOrdens()
        {
            InitializeComponent();
        }

        private void frmFecharOrdens_Load(object sender, EventArgs e)
        {
            CarregarOrdensAbertas();
        }

        private void CarregarOrdensAbertas()
        {
            using (var db = new AppDbContext())
            {
                var ordens = db.OrdensServico
                    .Where(os => os.StatusId != 3) // != Fechado
                    .Select(os => new
                    {
                        os.Id,
                        os.Solicitante,
                        Equipamento = os.TipoEquipamento.Nome,
                        os.DataAbertura,
                        ValorPecas = os.Itens.Sum(i => i.QuantidadeUsada * i.ValorUnitario),
                        Status = os.Status.Nome
                    })
                    .OrderBy(os => os.DataAbertura)
                    .ToList();

                dgvOrdens.DataSource = ordens;
                dgvOrdens.Columns["Id"].HeaderText = "OS #";
                dgvOrdens.Columns["Solicitante"].HeaderText = "Cliente";
                dgvOrdens.Columns["Equipamento"].HeaderText = "Tipo";
                dgvOrdens.Columns["DataAbertura"].HeaderText = "Abertura";
                dgvOrdens.Columns["ValorPecas"].HeaderText = "Peças (R$)";
                dgvOrdens.Columns["Status"].HeaderText = "Status";

                // Formatar colunas
                dgvOrdens.Columns["DataAbertura"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvOrdens.Columns["ValorPecas"].DefaultCellStyle.Format = "C2";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (dgvOrdens.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma OS para fechar.");
                return;
            }

            int osId = (int)dgvOrdens.CurrentRow.Cells["Id"].Value;
            decimal valorPecas = (decimal)dgvOrdens.CurrentRow.Cells["ValorPecas"].Value;

            var frm = new frmCalcularFechamento(osId, valorPecas);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CarregarOrdensAbertas(); // Atualiza lista
                MessageBox.Show("Ordem de Serviço fechada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarOrdensAbertas();
        }
    }
}