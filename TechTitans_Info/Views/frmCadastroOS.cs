using System;
using System.Linq;
using System.Windows.Forms;
using TechTitans_Info.Data;
using TechTitans_Info.Models;

namespace TechTitans_Info.Views
{
    public partial class frmCadastroOS : Form
    {
        public frmCadastroOS()
        {
            InitializeComponent();
        }

        private void frmCadastroOS_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                // Carregar Tipo de Equipamento
                var tipos = db.TiposEquipamento.ToList();
                if (!tipos.Any())
                {
                    MessageBox.Show("Erro: Tipos de Equipamento não carregados.");
                    this.Close();
                    return;
                }
                cmbTipoEquipamento.DataSource = tipos;
                cmbTipoEquipamento.DisplayMember = "Nome";
                cmbTipoEquipamento.ValueMember = "Id";
                cmbTipoEquipamento.SelectedIndex = 0;

                // Carregar Prioridade
                var prioridades = db.Prioridades.ToList();
                if (!prioridades.Any())
                {
                    MessageBox.Show("Erro: Prioridades não carregadas.");
                    this.Close();
                    return;
                }
                cmbPrioridade.DataSource = prioridades;
                cmbPrioridade.DisplayMember = "Nome";
                cmbPrioridade.ValueMember = "Id";
                cmbPrioridade.SelectedIndex = 0;

                // Carregar Status
                var statusList = db.StatusOS.ToList();
                if (!statusList.Any())
                {
                    MessageBox.Show("Erro: Status não carregados.");
                    this.Close();
                    return;
                }
                cmbStatus.DataSource = statusList;
                cmbStatus.DisplayMember = "Nome";
                cmbStatus.ValueMember = "Id";
                cmbStatus.SelectedValue = 1; // Aberto por padrão

                // Data de Abertura = Hoje
                dtpDataAbertura.Value = DateTime.Today;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSolicitante.Text) ||
                string.IsNullOrWhiteSpace(txtResponsavel.Text) ||
                cmbTipoEquipamento.SelectedValue == null ||
                cmbPrioridade.SelectedValue == null ||
                cmbStatus.SelectedValue == null)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
                var os = new OrdemServico
                {
                    Solicitante = txtSolicitante.Text.Trim(),
                    Responsavel = txtResponsavel.Text.Trim(),
                    Telefone = txtTelefone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    TipoEquipamentoId = (int)cmbTipoEquipamento.SelectedValue,
                    Marca = txtMarca.Text.Trim(),
                    Serie = txtSerie.Text.Trim(),
                    DescricaoProblema = txtProblema.Text.Trim(),
                    PrioridadeId = (int)cmbPrioridade.SelectedValue,
                    StatusId = (int)cmbStatus.SelectedValue,
                    DataAbertura = dtpDataAbertura.Value
                };

                db.OrdensServico.Add(os);
                db.SaveChanges();

                MessageBox.Show($"OS #{os.Id} cadastrada com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}