using System;
using System.Linq;
using System.Windows.Forms;
using TechTitans_Info.Data;
using TechTitans_Info.Models;

namespace TechTitans_Info.Views
{
    public partial class frmEditarOS : Form
    {
        private int _osId; // ID da OS sendo editada

        public frmEditarOS(int osId)
        {
            InitializeComponent();
            _osId = osId;
        }

        private void frmEditarOS_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                // Carrega a OS com o ID recebido
                var os = db.OrdensServico
                    .FirstOrDefault(o => o.Id == _osId);

                if (os == null)
                {
                    MessageBox.Show("Ordem de Serviço não encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // 🔹 Carrega os ComboBoxes
                cmbTipoEquipamento.DataSource = db.TiposEquipamento.ToList();
                cmbTipoEquipamento.DisplayMember = "Nome";
                cmbTipoEquipamento.ValueMember = "Id";

                cmbPrioridade.DataSource = db.Prioridades.ToList();
                cmbPrioridade.DisplayMember = "Nome";
                cmbPrioridade.ValueMember = "Id";

                cmbStatus.DataSource = db.StatusOS.ToList();
                cmbStatus.DisplayMember = "Nome";
                cmbStatus.ValueMember = "Id";

                // 🔹 Preenche os campos do formulário com os dados da OS
                lblId.Text = $"ID: {os.Id}";
                txtSolicitante.Text = os.Solicitante;
                txtResponsavel.Text = os.Responsavel;
                txtTelefone.Text = os.Telefone;
                txtEmail.Text = os.Email;
                txtMarca.Text = os.Marca;
                txtSerie.Text = os.Serie;
                txtProblema.Text = os.DescricaoProblema;
                dtpDataAbertura.Value = os.DataAbertura;

                // Define os valores selecionados nos ComboBoxes
                if (os.TipoEquipamentoId != 0)
                    cmbTipoEquipamento.SelectedValue = os.TipoEquipamentoId;

                if (os.PrioridadeId != 0)
                    cmbPrioridade.SelectedValue = os.PrioridadeId;

                if (os.StatusId != 0)
                    cmbStatus.SelectedValue = os.StatusId;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var os = db.OrdensServico.FirstOrDefault(o => o.Id == _osId);
                if (os == null)
                {
                    MessageBox.Show("Ordem de Serviço não encontrada!");
                    return;
                }

                // Atualiza os campos
                os.Solicitante = txtSolicitante.Text.Trim();
                os.Responsavel = txtResponsavel.Text.Trim();
                os.Telefone = txtTelefone.Text.Trim();
                os.Email = txtEmail.Text.Trim();
                os.Marca = txtMarca.Text.Trim();
                os.Serie = txtSerie.Text.Trim();
                os.DescricaoProblema = txtProblema.Text.Trim();
                os.DataAbertura = dtpDataAbertura.Value;

                os.TipoEquipamentoId = (int)cmbTipoEquipamento.SelectedValue;
                os.PrioridadeId = (int)cmbPrioridade.SelectedValue;
                os.StatusId = (int)cmbStatus.SelectedValue;

                db.SaveChanges();
                MessageBox.Show("Ordem de Serviço atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Tem certeza que deseja excluir esta Ordem de Serviço?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (var db = new AppDbContext())
                {
                    var os = db.OrdensServico.FirstOrDefault(o => o.Id == _osId);
                    if (os != null)
                    {
                        db.OrdensServico.Remove(os);
                        db.SaveChanges();
                        MessageBox.Show("Ordem de Serviço excluída com sucesso!");
                    }
                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
