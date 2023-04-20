using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolhaProfissao
{
    
    public partial class Form1 : Form
    {
        //Criando um objeto mediator
        private FormMediator mediator;
       
        public Form1()
        {
            InitializeComponent();
            // passando as caixas de texto, as caixas de seleção e o botão de envio como parâmetros
            // para o construtor do objeto mediator
            mediator = new FormMediator(txtNome, txtSobrenome, txtNomeCompleto, cboxCurso, cboxProfDesejada, btnSubmit);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            mediator.Notify(txtNome);

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {
            mediator.Notify(txtSobrenome);
        }

        private void cboxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediator.Notify(cboxCurso);

        }

        private void cboxProfDesejada_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediator.Notify(cboxProfDesejada);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (mediator.ValidateAll())
            {
                MessageBox.Show("Formulário Enviado");
            }
        }
    }
}
