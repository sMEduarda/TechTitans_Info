namespace TechTitans_Info.Views
{
    partial class frmCadastroMaterial
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbl_subtitulo1 = new System.Windows.Forms.Label();
            this.lbl_titulo1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(411, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(495, 221);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(436, 30);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(424, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTipo.Location = new System.Drawing.Point(495, 288);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(436, 30);
            this.txtTipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(376, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(495, 356);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(436, 106);
            this.txtDescricao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(417, 493);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor:";
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValor.Location = new System.Drawing.Point(495, 488);
            this.numValor.Margin = new System.Windows.Forms.Padding(4);
            this.numValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(133, 30);
            this.numValor.TabIndex = 7;
            this.numValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(664, 493);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidade.Location = new System.Drawing.Point(798, 488);
            this.numQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.numQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(133, 30);
            this.numQuantidade.TabIndex = 9;
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(416, 571);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(133, 46);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lbl_subtitulo1
            // 
            this.lbl_subtitulo1.AutoSize = true;
            this.lbl_subtitulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_subtitulo1.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo1.Location = new System.Drawing.Point(514, 117);
            this.lbl_subtitulo1.Name = "lbl_subtitulo1";
            this.lbl_subtitulo1.Size = new System.Drawing.Size(403, 32);
            this.lbl_subtitulo1.TabIndex = 11;
            this.lbl_subtitulo1.Text = "Cadastrar Itens de Estoque";
            // 
            // lbl_titulo1
            // 
            this.lbl_titulo1.AutoSize = true;
            this.lbl_titulo1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo1.Font = new System.Drawing.Font("Georgia", 25.8F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo1.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo1.Location = new System.Drawing.Point(307, 35);
            this.lbl_titulo1.Name = "lbl_titulo1";
            this.lbl_titulo1.Size = new System.Drawing.Size(859, 49);
            this.lbl_titulo1.TabIndex = 12;
            this.lbl_titulo1.Text = "TechTitans - Manutenção Informática";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(622, 571);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(823, 570);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 46);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmCadastroMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechTitans_Info.Properties.Resources.fundo_azul;
            this.ClientSize = new System.Drawing.Size(1319, 777);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_subtitulo1);
            this.Controls.Add(this.lbl_titulo1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Material";
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lbl_subtitulo1;
        private System.Windows.Forms.Label lbl_titulo1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}