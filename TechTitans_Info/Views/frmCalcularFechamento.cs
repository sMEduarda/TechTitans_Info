using System;
using System.Windows.Forms;
using TechTitans_Info.Data;
using TechTitans_Info.Models;

namespace TechTitans_Info.Views
{
    public partial class frmCalcularFechamento : Form
    {
        private int _osId;
        private decimal _valorPecas;

        public frmCalcularFechamento(int osId, decimal valorPecas)
        {
            _osId = osId;
            _valorPecas = valorPecas;
            InitializeComponent();
        }

        private void frmCalcularFechamento_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var os = db.OrdensServico.Find(_osId);
                lblData.Text = $"Abertura: {os.DataAbertura:dd/MM/yyyy}";
            }

            lblPecas.Text = _valorPecas.ToString("C");
            AtualizarTotal();
        }

        private void numMaoDeObra_ValueChanged(object sender, EventArgs e)
        {
            AtualizarTotal();
        }

        private void AtualizarTotal()
        {
            decimal total = numMaoDeObra.Value + _valorPecas;
            lblTotal.Text = total.ToString("C");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var os = db.OrdensServico.Find(_osId);
                os.ValorMaoDeObra = numMaoDeObra.Value;
                os.ValorTotalPecas = _valorPecas;
                os.ValorTotal = numMaoDeObra.Value + _valorPecas;
                os.DataFechamento = DateTime.Now;
                os.StatusId = 3;

                db.SaveChanges();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}