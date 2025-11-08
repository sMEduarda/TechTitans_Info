using System;
using System.Linq;
using System.Windows.Forms;
using TechTitans_Info.Data;
using TechTitans_Info.Models;

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
            CarregarOS();
        }

        private void CarregarOS()
        {
            using (var db = new AppDbContext())
            {
                var dados = db.OrdensServico
                    .Select(os => new
                    {
                        os.Id,
                        os.Solicitante,
                        Status = os.Status.Nome,
                        Prioridade = os.Prioridade.Nome,
                        os.DataAbertura
                    })
                    .ToList();

                dgvOS.DataSource = dados;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var filtro = txtFiltro.Text.Trim();
                var dados = db.OrdensServico
                    .Where(os => os.Solicitante.Contains(filtro))
                    .Select(os => new
                    {
                        os.Id,
                        os.Solicitante,
                        Status = os.Status.Nome,
                        Prioridade = os.Prioridade.Nome,
                        os.DataAbertura
                    })
                    .ToList();

                dgvOS.DataSource = dados;
            }
        }

        private void btnAdicionarPeca_Click(object sender, EventArgs e)
        {
            if (dgvOS.CurrentRow != null)
            {
                int osId = (int)dgvOS.CurrentRow.Cells["Id"].Value;
                new frmAdicionarPecaOS(osId).ShowDialog();
            }
        }
    }
}