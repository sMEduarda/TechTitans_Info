using System;
using System.Windows.Forms;

namespace TechTitans_Info.Views
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void btnCadastrarOS_Click(object sender, EventArgs e)
        {
            new frmCadastroOS().ShowDialog();
        }

        private void btnConsultarOS_Click(object sender, EventArgs e)
        {
            new frmConsultaOS().ShowDialog();
        }

        private void btnCadastrarMaterial_Click(object sender, EventArgs e)
        {
            new frmCadastroMaterial().ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            new frmConsultaEstoque().ShowDialog();
        }

        private void btnFecharOrdens_Click(object sender, EventArgs e)
        {
            new frmFecharOrdens().ShowDialog();
        }
    }
}