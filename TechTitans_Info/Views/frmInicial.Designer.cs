namespace TechTitans_Info.Views
{
    partial class frmInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrarOS = new System.Windows.Forms.Button();
            this.btnConsultarOS = new System.Windows.Forms.Button();
            this.btnCadastrarMaterial = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecharOrdens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarOS
            // 
            this.btnCadastrarOS.BackColor = System.Drawing.Color.Lavender;
            this.btnCadastrarOS.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarOS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCadastrarOS.Location = new System.Drawing.Point(119, 191);
            this.btnCadastrarOS.Name = "btnCadastrarOS";
            this.btnCadastrarOS.Size = new System.Drawing.Size(493, 60);
            this.btnCadastrarOS.TabIndex = 0;
            this.btnCadastrarOS.Text = "Cadastrar Ordem de Serviço";
            this.btnCadastrarOS.UseVisualStyleBackColor = false;
            this.btnCadastrarOS.Click += new System.EventHandler(this.btnCadastrarOS_Click);
            // 
            // btnConsultarOS
            // 
            this.btnConsultarOS.BackColor = System.Drawing.Color.Lavender;
            this.btnConsultarOS.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarOS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnConsultarOS.Location = new System.Drawing.Point(694, 187);
            this.btnConsultarOS.Name = "btnConsultarOS";
            this.btnConsultarOS.Size = new System.Drawing.Size(493, 60);
            this.btnConsultarOS.TabIndex = 1;
            this.btnConsultarOS.Text = "Consultar Ordens Criadas";
            this.btnConsultarOS.UseVisualStyleBackColor = false;
            this.btnConsultarOS.Click += new System.EventHandler(this.btnConsultarOS_Click);
            // 
            // btnCadastrarMaterial
            // 
            this.btnCadastrarMaterial.BackColor = System.Drawing.Color.Lavender;
            this.btnCadastrarMaterial.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMaterial.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCadastrarMaterial.Location = new System.Drawing.Point(119, 315);
            this.btnCadastrarMaterial.Name = "btnCadastrarMaterial";
            this.btnCadastrarMaterial.Size = new System.Drawing.Size(493, 60);
            this.btnCadastrarMaterial.TabIndex = 2;
            this.btnCadastrarMaterial.Text = "Cadastrar Material";
            this.btnCadastrarMaterial.UseVisualStyleBackColor = false;
            this.btnCadastrarMaterial.Click += new System.EventHandler(this.btnCadastrarMaterial_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.Lavender;
            this.btnEstoque.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnEstoque.Location = new System.Drawing.Point(694, 312);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(493, 60);
            this.btnEstoque.TabIndex = 3;
            this.btnEstoque.Text = "Consultar Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1195, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "TechTitans - Manutenção Informática";
            // 
            // btnFecharOrdens
            // 
            this.btnFecharOrdens.BackColor = System.Drawing.Color.Lavender;
            this.btnFecharOrdens.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharOrdens.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnFecharOrdens.Location = new System.Drawing.Point(406, 447);
            this.btnFecharOrdens.Name = "btnFecharOrdens";
            this.btnFecharOrdens.Size = new System.Drawing.Size(493, 60);
            this.btnFecharOrdens.TabIndex = 5;
            this.btnFecharOrdens.Text = "Fechar Ordem de Serviço";
            this.btnFecharOrdens.UseVisualStyleBackColor = false;
            this.btnFecharOrdens.Click += new System.EventHandler(this.btnFecharOrdens_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = global::TechTitans_Info.Properties.Resources.fundo_azul;
            this.ClientSize = new System.Drawing.Size(1412, 652);
            this.Controls.Add(this.btnFecharOrdens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnCadastrarMaterial);
            this.Controls.Add(this.btnConsultarOS);
            this.Controls.Add(this.btnCadastrarOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ordem de Serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarOS;
        private System.Windows.Forms.Button btnConsultarOS;
        private System.Windows.Forms.Button btnCadastrarMaterial;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecharOrdens;
    }
}