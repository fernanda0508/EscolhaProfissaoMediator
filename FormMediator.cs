using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolhaProfissao
{
    //FormMediator atua como um intermediário
    //que gerencia e coordena a interação entre os diferentes componentes do formulário,
    //como o TextBox e o ComboBox
    class FormMediator
    {
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private TextBox txtNomeCompleto;
        private ComboBox cboxCurso;
        private ComboBox cboxProfDesejada;
        private Button btnSubmit;

        public FormMediator(TextBox txtNome, TextBox txtSobrenome, TextBox txtNomeCompleto, ComboBox cboxCurso, ComboBox cboxProfDesejada, Button btnSubmit)
        {
            this.txtNome = txtNome;
            this.txtSobrenome = txtSobrenome;
            this.txtNomeCompleto = txtNomeCompleto;
            this.cboxCurso = cboxCurso;
            this.cboxProfDesejada = cboxProfDesejada;
            this.btnSubmit = btnSubmit;
            
            //O formulário começa somente com o controle do nome habilitado
            DisableAll();
        }

        //verifica se o controle que disparou o evento é uma das caixas de texto de nome ou sobrenome,
        //e em seguida preenche a caixa de texto de nome completo e habilita a caixa de seleção de curso.
        public void Notify(Control sender)
        {
            if (sender == txtNome || sender == txtSobrenome)
            {
                FillNomeCompleto();
                EnableCurso();
            }
            //. Se o controle que disparou o evento é a caixa de seleção de curso, a caixa de seleção de profissão
            //é habilitada
            else if (sender == cboxCurso)
            {
                EnableProfDesejada();
            }
        }

        //é responsável por verificar se todos os campos do formulário foram preenchidos
        public bool ValidateAll()
        {
            if (txtNome.Text == "" || txtSobrenome.Text == "" || cboxCurso.SelectedIndex == -1 || cboxProfDesejada.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de enviar o formulário.");
                return false;
            }

            return true;
        }

        // concatena o nome e o sobrenome
        private void FillNomeCompleto()
        {
            txtNomeCompleto.Text = txtNome.Text + " " + txtSobrenome.Text;
        }

        //Os métodos EnableCurso(), EnableProfDesejada() e EnableSubmit()
        //são responsáveis por habilitar os controles correspondentes
        private void EnableCurso()
        {
            cboxCurso.Enabled = true;
        }

        private void EnableProfDesejada()
        {
            cboxProfDesejada.Enabled = true;
            EnableSubmit();
        }

        private void EnableSubmit()
        {
            btnSubmit.Enabled = true;
        }

        //desabilitar todos os controles da interface gráfica
        private void DisableAll()
        {
            cboxCurso.Enabled = false;
            cboxProfDesejada.Enabled = false;
            btnSubmit.Enabled = false;
        }
    }
}
