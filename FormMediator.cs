using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolhaProfissao
{
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

            DisableAll();
        }

        public void Notify(Control sender)
        {
            if (sender == txtNome || sender == txtSobrenome)
            {
                FillNomeCompleto();
                EnableCurso();
            }
            else if (sender == cboxCurso)
            {
                EnableProfDesejada();
            }
        }

        public bool ValidateAll()
        {
            if (txtNome.Text == "" || txtSobrenome.Text == "" || cboxCurso.SelectedIndex == -1 || cboxProfDesejada.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de enviar o formulário.");
                return false;
            }

            return true;
        }

        private void FillNomeCompleto()
        {
            txtNomeCompleto.Text = txtNome.Text + " " + txtSobrenome.Text;
        }

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

        private void DisableAll()
        {
            cboxCurso.Enabled = false;
            cboxProfDesejada.Enabled = false;
            btnSubmit.Enabled = false;
        }
    }
}
