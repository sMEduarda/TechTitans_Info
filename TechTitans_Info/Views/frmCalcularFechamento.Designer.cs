namespace TechTitans_Info.Views
{
    partial class frmCalcularFechamento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMaoDeObra = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPecas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbl_subtitulo1 = new System.Windows.Forms.Label();
            this.lbl_titulo1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMaoDeObra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(373, 218);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(194, 29);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Abertura: --/--/----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor da Mão de Obra (R$):";
            // 
            // numMaoDeObra
            // 
            this.numMaoDeObra.DecimalPlaces = 2;
            this.numMaoDeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numMaoDeObra.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaoDeObra.Location = new System.Drawing.Point(697, 274);
            this.numMaoDeObra.Name = "numMaoDeObra";
            this.numMaoDeObra.Size = new System.Drawing.Size(95, 30);
            this.numMaoDeObra.TabIndex = 5;
            this.numMaoDeObra.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numMaoDeObra.ValueChanged += new System.EventHandler(this.numMaoDeObra_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(373, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Total das Peças:";
            // 
            // lblPecas
            // 
            this.lblPecas.AutoSize = true;
            this.lblPecas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecas.Location = new System.Drawing.Point(698, 334);
            this.lblPecas.Name = "lblPecas";
            this.lblPecas.Size = new System.Drawing.Size(94, 29);
            this.lblPecas.TabIndex = 3;
            this.lblPecas.Text = "R$ 0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(398, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL DA CONTA:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Snow;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(661, 435);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 32);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(404, 525);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(158, 45);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar OS";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lbl_subtitulo1
            // 
            this.lbl_subtitulo1.AutoSize = true;
            this.lbl_subtitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_subtitulo1.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo1.Location = new System.Drawing.Point(408, 121);
            this.lbl_subtitulo1.Name = "lbl_subtitulo1";
            this.lbl_subtitulo1.Size = new System.Drawing.Size(380, 32);
            this.lbl_subtitulo1.TabIndex = 13;
            this.lbl_subtitulo1.Text = "Fechar Ordem de Serviço";
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo1.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo1.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo1.Location = new System.Drawing.Point(176, 41);
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
            this.button1.Location = new System.Drawing.Point(630, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmCalcularFechamento
            // 
            this.BackgroundImage = global::TechTitans_Info.Properties.Resources.fundo_azul;
            this.ClientSize = new System.Drawing.Size(1221, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_subtitulo1);
            this.Controls.Add(this.lbl_titulo1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPecas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numMaoDeObra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalcularFechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fechar OS - Cálculo Final";
            this.Load += new System.EventHandler(this.frmCalcularFechamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMaoDeObra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMaoDeObra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPecas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbl_subtitulo1;
        private System.Windows.Forms.Label lbl_titulo1;
        private System.Windows.Forms.Button button1;
    }
}