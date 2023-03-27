
namespace EscolhaProfissao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.cboxProfDesejada = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxCurso = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profissão Dev";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(52, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(110, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(235, 94);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(122, 20);
            this.txtSobrenome.TabIndex = 4;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.txtSobrenome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome Completo:";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Enabled = false;
            this.txtNomeCompleto.Location = new System.Drawing.Point(99, 138);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(258, 20);
            this.txtNomeCompleto.TabIndex = 6;
            // 
            // cboxProfDesejada
            // 
            this.cboxProfDesejada.FormattingEnabled = true;
            this.cboxProfDesejada.Items.AddRange(new object[] {
            "Desenvolvedor ou desenvolvedora de software.",
            "Desenvolvedor ou desenvolvedora Web.",
            "Analista de Business Intelligence.",
            "Especialista em segurança da informação.",
            "Cientista de dados.",
            "Administrador ou administradora de banco de dados.",
            "Analista de sistemas de computador."});
            this.cboxProfDesejada.Location = new System.Drawing.Point(119, 227);
            this.cboxProfDesejada.Name = "cboxProfDesejada";
            this.cboxProfDesejada.Size = new System.Drawing.Size(238, 21);
            this.cboxProfDesejada.TabIndex = 7;
            this.cboxProfDesejada.SelectedIndexChanged += new System.EventHandler(this.cboxProfDesejada_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Profissão Desejada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Curso:";
            // 
            // cboxCurso
            // 
            this.cboxCurso.FormattingEnabled = true;
            this.cboxCurso.Items.AddRange(new object[] {
            "1. Análise e Desenvolvimento de Sistemas",
            "2. Ciência da Computação",
            "3. Jogos Digitais",
            "4. Gestão da Tecnologia da Informação",
            "5. Sistemas de Informação",
            "6. Engenharia de Software",
            "7. Engenharia da Computação",
            "8. Engenharia de Controle e Automação",
            "9. Rede de Computadores",
            "10. Sistemas para Internet"});
            this.cboxCurso.Location = new System.Drawing.Point(55, 184);
            this.cboxCurso.Name = "cboxCurso";
            this.cboxCurso.Size = new System.Drawing.Size(302, 21);
            this.cboxCurso.TabIndex = 10;
            this.cboxCurso.SelectedIndexChanged += new System.EventHandler(this.cboxCurso_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(273, 292);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(83, 24);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Enviar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 339);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboxCurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxProfDesejada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Escolha de Profissão - Formulário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.ComboBox cboxProfDesejada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxCurso;
        private System.Windows.Forms.Button btnSubmit;
    }
}

