namespace TechTitans_Info.Views
{
    partial class frmFecharOrdens
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvOrdens = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lbl_subtitulo1 = new System.Windows.Forms.Label();
            this.lbl_titulo1 = new System.Windows.Forms.Label();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrdens
            // 
            this.dgvOrdens.AllowUserToAddRows = false;
            this.dgvOrdens.AllowUserToDeleteRows = false;
            this.dgvOrdens.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgvOrdens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdens.Location = new System.Drawing.Point(81, 170);
            this.dgvOrdens.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrdens.Name = "dgvOrdens";
            this.dgvOrdens.ReadOnly = true;
            this.dgvOrdens.RowHeadersWidth = 51;
            this.dgvOrdens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdens.Size = new System.Drawing.Size(1116, 480);
            this.dgvOrdens.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(355, 681);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(162, 49);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar OS";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Gold;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(580, 680);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(160, 49);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar Lista";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lbl_subtitulo1
            // 
            this.lbl_subtitulo1.AutoSize = true;
            this.lbl_subtitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_subtitulo1.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo1.Location = new System.Drawing.Point(477, 112);
            this.lbl_subtitulo1.Name = "lbl_subtitulo1";
            this.lbl_subtitulo1.Size = new System.Drawing.Size(380, 32);
            this.lbl_subtitulo1.TabIndex = 11;
            this.lbl_subtitulo1.Text = "Fechar Ordem de Serviço";
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo1.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo1.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo1.Location = new System.Drawing.Point(237, 36);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(859, 49);
            this.lbl_titulo1.TabIndex = 12;
            this.lbl_titulo1.Text = "TechTitans - Manutenção Informática";
            // 
            // 
            // btnCancelar2
            this.btnCancelar2.BackColor = System.Drawing.Color.Red;
            this.btnCancelar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar2.ForeColor = System.Drawing.Color.White;
            this.btnCancelar2.Location = new System.Drawing.Point(799, 679);
            this.btnCancelar2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(162, 49);
            this.btnCancelar2.TabIndex = 13;
            this.btnCancelar2.Text = "Cancelar";
            this.btnCancelar2.UseVisualStyleBackColor = false;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
            // 
            // frmFecharOrdens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechTitans_Info.Properties.Resources.fundo_azul;
            this.ClientSize = new System.Drawing.Size(1288, 779);
            this.Controls.Add(this.btnCancelar2);
            this.Controls.Add(this.lbl_subtitulo1);
            this.Controls.Add(this.lbl_titulo1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvOrdens);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFecharOrdens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechar Ordens - TechTitans OS";
            this.Load += new System.EventHandler(this.frmFecharOrdens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvOrdens;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lbl_subtitulo1;
        private System.Windows.Forms.Label lbl_titulo1;
        private System.Windows.Forms.Button btnCancelar2;
    }
}