using System;
using System.Linq;
using System.Windows.Forms;
using TechTitans_Info.Data;

namespace TechTitans_Info.Views
{
    public partial class frmConsultaOS : Form
    {
        public frmConsultaOS()
        {
            InitializeComponent();
        }

        private void frmConsultaOS_Load(object sender, EventArgs e)
        {
            CarregarOrdensServico();
            // opcional: filtrar enquanto digita
            this.txtFiltro.TextChanged += TxtFiltro_TextChanged;
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            CarregarOrdensServico(txtFiltro.Text);
        }

        /// <summary>
        /// Carrega ordens no grid. Se filtro vier preenchido, filtra por:
        /// Id (número), Solicitante, Responsavel, TipoEquipamento, Prioridade, Status.
        /// </summary>
        private void CarregarOrdensServico(string filtro = "")
        {
            using (var db = new AppDbContext())
            {
                // Normaliza filtro
                var filtroTrim = (filtro ?? "").Trim();
                var filtroLower = filtroTrim.ToLower();

                // Tenta detectar se o filtro é um número (Id)
                bool isId = int.TryParse(filtroTrim, out int idFiltro);

                // Projeção: traz strings prontas para exibir (tratando nav props nulas)
                var query = db.OrdensServico
                    .Select(os => new
                    {
                        os.Id,
                        Solicitante = os.Solicitante,
                        Responsavel = os.Responsavel,
                        TipoEquipamento = os.TipoEquipamento != null ? os.TipoEquipamento.Nome : (os.TipoEquipamento.Nome ?? ""),
                        // caso você tenha propriedade string direta use apenas os.TipoEquipamento (ajuste conforme seu modelo)
                        DescricaoProblema = os.DescricaoProblema,
                        Prioridade = os.Prioridade != null ? os.Prioridade.Nome : (os.Prioridade.Nome ?? ""),
                        Status = os.Status != null ? os.Status.Nome : (os.Status.Nome ?? ""),
                        os.DataAbertura
                    });

                // Aplica filtro se fornecido
                if (!string.IsNullOrEmpty(filtroTrim))
                {
                    // Atenção: usamos ToLower nas propriedades para comparação case-insensitive
                    query = query.Where(x =>
                        (isId && x.Id == idFiltro) ||
                        (x.Solicitante != null && x.Solicitante.ToLower().Contains(filtroLower)) ||
                        (x.Responsavel != null && x.Responsavel.ToLower().Contains(filtroLower)) ||
                        (x.TipoEquipamento != null && x.TipoEquipamento.ToLower().Contains(filtroLower)) ||
                        (x.Prioridade != null && x.Prioridade.ToLower().Contains(filtroLower)) ||
                        (x.Status != null && x.Status.ToLower().Contains(filtroLower))
                    );
                }

                var lista = query
                    .OrderByDescending(x => x.DataAbertura)
                    .ToList();

                dgvOS.DataSource = lista;

                // Ajustes visuais do grid
                dgvOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Coluna DescricaoProblema: quebra de linha e auto tamanho por conteúdo
                if (dgvOS.Columns.Contains("DescricaoProblema"))
                {
                    dgvOS.Columns["DescricaoProblema"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvOS.Columns["DescricaoProblema"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                // Outras colunas que queremos com tamanho por conteúdo
                string[] smallCols = { "Id", "DataAbertura", "Prioridade", "Status" };
                foreach (var c in smallCols)
                {
                    if (dgvOS.Columns.Contains(c))
                        dgvOS.Columns[c].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                // Formatar data se existir
                if (dgvOS.Columns.Contains("DataAbertura"))
                    dgvOS.Columns["DataAbertura"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CarregarOrdensServico(txtFiltro.Text);
        }

        private void btnAdicionarPeca_Click(object sender, EventArgs e)
        {
            if (dgvOS.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma ordem de serviço primeiro!");
                return;
            }

            int idOS = (int)dgvOS.CurrentRow.Cells["Id"].Value;
            // supondo que exista um formulário para adicionar peça que recebe idOS
            var frm = new frmAdicionarPecaOS(idOS);
            frm.ShowDialog();
            // caso esteja alterando itens, pode recarregar o grid
            CarregarOrdensServico(txtFiltro.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmInicial = new frmInicial();
            frmInicial.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada
            if (dgvOS.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma ordem de serviço para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pega o ID da OS selecionada
            int idOS = Convert.ToInt32(dgvOS.CurrentRow.Cells["Id"].Value);

            // Abre a tela de edição passando o ID da OS
            var frm = new frmEditarOS(idOS);
            frm.ShowDialog();

            // Após editar/excluir, recarrega a lista
            CarregarOrdensServico(txtFiltro.Text);
        }

    }
}
