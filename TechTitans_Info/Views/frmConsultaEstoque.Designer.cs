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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNovaQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(86, 183);
            this.dgvEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.RowHeadersWidth = 51;
            this.dgvEstoque.Size = new System.Drawing.Size(1113, 407);
            this.dgvEstoque.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 660);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nova Quantidade:";
            // 
            // numNovaQuantidade
            // 
            this.numNovaQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNovaQuantidade.Location = new System.Drawing.Point(690, 658);
            this.numNovaQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.numNovaQuantidade.Name = "numNovaQuantidade";
            this.numNovaQuantidade.Size = new System.Drawing.Size(107, 30);
            this.numNovaQuantidade.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(492, 710);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
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
            this.lbl_subtitulo1.Location = new System.Drawing.Point(455, 123);
            this.lbl_subtitulo1.Name = "lbl_subtitulo1";
            this.lbl_subtitulo1.Size = new System.Drawing.Size(380, 32);
            this.lbl_subtitulo1.TabIndex = 15;
            this.lbl_subtitulo1.Text = "Fechar Ordem de Serviço";
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo1.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo1.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo1.Location = new System.Drawing.Point(223, 43);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(859, 49);
            this.lbl_titulo1.TabIndex = 16;
            this.lbl_titulo1.Text = "TechTitans - Manutenção Informática";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(484, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Atualizar Quantidades";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(669, 710);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechTitans_Info.Properties.Resources.fundo_azul;
            this.ClientSize = new System.Drawing.Size(1291, 779);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_subtitulo1);
            this.Controls.Add(this.lbl_titulo1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.numNovaQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEstoque);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button1;
    }
}