namespace TechTitans_Info.Views
{
    partial class frmConsultaEstoque
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numNovaQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lbl_subtitulo1 = new System.Windows.Forms.Label();
            this.lbl_titulo1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lblFiltroId = new System.Windows.Forms.Label();
            this.txtFiltroId = new System.Windows.Forms.TextBox();
            this.lblFiltroNome = new System.Windows.Forms.Label();
            this.txtFiltroNome = new System.Windows.Forms.TextBox();
            this.lblFiltroTipo = new System.Windows.Forms.Label();
            this.txtFiltroTipo = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNovaQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(121, 219);
            this.dgvEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.RowHeadersWidth = 51;
            this.dgvEstoque.Size = new System.Drawing.Size(1101, 407);
            this.dgvEstoque.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(504, 694);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nova Quantidade:";
            // 
            // numNovaQuantidade
            // 
            this.numNovaQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.numNovaQuantidade.Location = new System.Drawing.Point(727, 691);
            this.numNovaQuantidade.Name = "numNovaQuantidade";
            this.numNovaQuantidade.Size = new System.Drawing.Size(107, 30);
            this.numNovaQuantidade.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(510, 735);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(128, 46);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lbl_subtitulo1
            // 
            this.lbl_subtitulo1.AutoSize = true;
            this.lbl_subtitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_subtitulo1.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo1.Location = new System.Drawing.Point(475, 91);
            this.lbl_subtitulo1.Name = "lbl_subtitulo1";
            this.lbl_subtitulo1.Size = new System.Drawing.Size(432, 32);
            this.lbl_subtitulo1.TabIndex = 15;
            this.lbl_subtitulo1.Text = "Ajustar Estoque de Materiais";
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo1.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo1.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo1.Location = new System.Drawing.Point(258, 34);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(859, 49);
            this.lbl_titulo1.TabIndex = 16;
            this.lbl_titulo1.Text = "TechTitans - Manutenção Informática";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(502, 644);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Atualizar Quantidades";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(709, 735);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(128, 46);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lblFiltroId
            // 
            this.lblFiltroId.AutoSize = true;
            this.lblFiltroId.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFiltroId.ForeColor = System.Drawing.Color.White;
            this.lblFiltroId.Location = new System.Drawing.Point(202, 165);
            this.lblFiltroId.Name = "lblFiltroId";
            this.lblFiltroId.Size = new System.Drawing.Size(40, 25);
            this.lblFiltroId.TabIndex = 30;
            this.lblFiltroId.Text = "ID:";
            // 
            // txtFiltroId
            // 
            this.txtFiltroId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtFiltroId.Location = new System.Drawing.Point(252, 163);
            this.txtFiltroId.Name = "txtFiltroId";
            this.txtFiltroId.Size = new System.Drawing.Size(80, 30);
            this.txtFiltroId.TabIndex = 31;
            // 
            // lblFiltroNome
            // 
            this.lblFiltroNome.AutoSize = true;
            this.lblFiltroNome.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFiltroNome.ForeColor = System.Drawing.Color.White;
            this.lblFiltroNome.Location = new System.Drawing.Point(388, 166);
            this.lblFiltroNome.Name = "lblFiltroNome";
            this.lblFiltroNome.Size = new System.Drawing.Size(60, 25);
            this.lblFiltroNome.TabIndex = 32;
            this.lblFiltroNome.Text = "Item:";
            // 
            // txtFiltroNome
            // 
            this.txtFiltroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtFiltroNome.Location = new System.Drawing.Point(458, 163);
            this.txtFiltroNome.Name = "txtFiltroNome";
            this.txtFiltroNome.Size = new System.Drawing.Size(200, 30);
            this.txtFiltroNome.TabIndex = 33;
            // 
            // lblFiltroTipo
            // 
            this.lblFiltroTipo.AutoSize = true;
            this.lblFiltroTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltroTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFiltroTipo.ForeColor = System.Drawing.Color.White;
            this.lblFiltroTipo.Location = new System.Drawing.Point(701, 166);
            this.lblFiltroTipo.Name = "lblFiltroTipo";
            this.lblFiltroTipo.Size = new System.Drawing.Size(62, 25);
            this.lblFiltroTipo.TabIndex = 34;
            this.lblFiltroTipo.Text = "Tipo:";
            // 
            // txtFiltroTipo
            // 
            this.txtFiltroTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtFiltroTipo.Location = new System.Drawing.Point(774, 163);
            this.txtFiltroTipo.Name = "txtFiltroTipo";
            this.txtFiltroTipo.Size = new System.Drawing.Size(150, 30);
            this.txtFiltroTipo.TabIndex = 35;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(962, 158);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 35);
            this.btnFiltrar.TabIndex = 36;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Orange;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(1091, 158);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpar.TabIndex = 37;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechTitans_Info.Properties.Resources.fundo_azul;
            this.ClientSize = new System.Drawing.Size(1395, 830);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.numNovaQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_subtitulo1);
            this.Controls.Add(this.lbl_titulo1);
            this.Controls.Add(this.dgvEstoque);
            this.Controls.Add(this.lblFiltroId);
            this.Controls.Add(this.txtFiltroId);
            this.Controls.Add(this.lblFiltroNome);
            this.Controls.Add(this.txtFiltroNome);
            this.Controls.Add(this.lblFiltroTipo);
            this.Controls.Add(this.txtFiltroTipo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnLimpar);
            this.Name = "frmConsultaEstoque";
            this.Text = "Consulta de Estoque";
            this.Load += new System.EventHandler(this.frmConsultaEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNovaQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNovaQuantidade;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lbl_subtitulo1;
        private System.Windows.Forms.Label lbl_titulo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel;

        // 🔎 Novos componentes de filtro
        private System.Windows.Forms.Label lblFiltroId;
        private System.Windows.Forms.TextBox txtFiltroId;
        private System.Windows.Forms.Label lblFiltroNome;
        private System.Windows.Forms.TextBox txtFiltroNome;
        private System.Windows.Forms.Label lblFiltroTipo;
        private System.Windows.Forms.TextBox txtFiltroTipo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpar;
    }
}
