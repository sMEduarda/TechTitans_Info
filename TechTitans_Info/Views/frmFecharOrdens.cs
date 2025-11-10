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
                    .Where(os => os.StatusId != 3) // 3 = Fechado
                    .Select(os => new
                    {
                        os.Id,
                        os.Solicitante,
                        Equipamento = os.TipoEquipamento.Nome,
                        Prioridade = os.Prioridade.Nome,
                        Status = os.Status.Nome,
                        os.DataAbertura,
                        ValorPecas = os.Itens.Sum(i =>
                            (decimal?)i.QuantidadeUsada * (decimal?)i.ValorUnitario) ?? 0
                    })
                    .OrderBy(os => os.DataAbertura)
                    .ToList();

                dgvOrdens.DataSource = ordens;

                // Ajuste de cabeçalhos
                dgvOrdens.Columns["Id"].HeaderText = "OS #";
                dgvOrdens.Columns["Solicitante"].HeaderText = "Cliente";
                dgvOrdens.Columns["Equipamento"].HeaderText = "Equipamento";
                dgvOrdens.Columns["Prioridade"].HeaderText = "Prioridade";
                dgvOrdens.Columns["Status"].HeaderText = "Status";
                dgvOrdens.Columns["DataAbertura"].HeaderText = "Data de Abertura";
                dgvOrdens.Columns["ValorPecas"].HeaderText = "Valor das Peças (R$)";

                // Formatação visual
                dgvOrdens.Columns["DataAbertura"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvOrdens.Columns["ValorPecas"].DefaultCellStyle.Format = "C2";

                // Ajustar largura das colunas para caber o texto
                dgvOrdens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvOrdens.Columns["Solicitante"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            decimal valorPecas = Convert.ToDecimal(dgvOrdens.CurrentRow.Cells["ValorPecas"].Value ?? 0);

            var frm = new frmCalcularFechamento(osId, valorPecas);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CarregarOrdensAbertas();
                MessageBox.Show("Ordem de Serviço fechada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarOrdensAbertas();
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            // Voltar para o formulário inicial
            var frmInicial = new frmInicial();
            frmInicial.Show();
            this.Close();
        }
    }
}
