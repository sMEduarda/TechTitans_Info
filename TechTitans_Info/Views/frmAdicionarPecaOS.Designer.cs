namespace TechTitans_Info.Views
{
    partial class frmAdicionarPecaOS
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lbl_subtitulo1 = new System.Windows.Forms.Label();
            this.lbl_titulo1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(383, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(478, 226);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(372, 33);
            this.cmbMaterial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(350, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numQuantidade.Location = new System.Drawing.Point(478, 298);
            this.numQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.numQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(372, 30);
            this.numQuantidade.TabIndex = 3;
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(438, 389);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(147, 45);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lbl_subtitulo1
            // 
            this.lbl_subtitulo1.AutoSize = true;
            this.lbl_subtitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_subtitulo1.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo1.Location = new System.Drawing.Point(324, 135);
            this.lbl_subtitulo1.Name = "lbl_subtitulo1";
            this.lbl_subtitulo1.Size = new System.Drawing.Size(559, 32);
            this.lbl_subtitulo1.TabIndex = 13;
            this.lbl_subtitulo1.Text = "Associar Material a Ordem de Serviço";
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo1.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo1.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo1.Location = new System.Drawing.Point(180, 49);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(859, 49);
            this.lbl_titulo1.TabIndex = 14;
            this.lbl_titulo1.Text = "TechTitans - Manutenção Informática";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(648, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmAdicionarPecaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechTitans_Info.Properties.Resources.fundo_azul;
            this.ClientSize = new System.Drawing.Size(1240, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_subtitulo1);
            this.Controls.Add(this.lbl_titulo1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdicionarPecaOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar Peça na OS";
            this.Load += new System.EventHandler(this.frmAdicionarPecaOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lbl_subtitulo1;
        private System.Windows.Forms.Label lbl_titulo1;
        private System.Windows.Forms.Button button1;
    }
}