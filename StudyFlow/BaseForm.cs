using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyFlow
{
    public partial class BaseForm : KryptonForm {
        public BaseForm() {
            InitializeComponent();
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        
        private void TrocarTela(Form novaTela) //metodo para trocar de tela
        {
            novaTela.StartPosition = FormStartPosition.Manual;
            novaTela.Location = this.Location;
            novaTela.Site = this.Site;
            novaTela.Show();
            this.Hide(); //esconde a tela anterior 


        }

        private void ButtonHome_Click(object sender, EventArgs e) {
            if (this is HomeForm) return;
            TrocarTela(new HomeForm());  // Troca de tel

        }

        private void ButtonRanking_Click(object sender, EventArgs e) {
            if (this is RankingForm) return;
            
            TrocarTela(new RankingForm());  // Troca de tel
        }

        private void ButtonNivelamento_Click(object sender, EventArgs e) {
            if (this is QuestoesForm) return;
           
            TrocarTela(new QuestoesForm());  // Troca de tel
        }

        private void ButtonQuestoes_Click(object sender, EventArgs e) {
            if (this is ResolucoesForm) return;
          
            TrocarTela(new ResolucoesForm());  // Troca de tel
        }

        private void ButtonAjuda_Click(object sender, EventArgs e) {
            
            MostrarAjuda("Ajuda", ObterMensagemAjuda());
        }

        public void TrocarConteudo(Control novoConteudo) {
            PanelConteudo.Controls.Clear();
            novoConteudo.Dock = DockStyle.Fill;
            PanelConteudo.Controls.Add(novoConteudo);
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show(
                    "Deseja realmente sair?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.No)
                {
                    e.Cancel = true; // Cancela o fechamento
                }
                else
                {
                    Application.Exit(); // Fecha toda a aplicação
                }
            }
        }

        public virtual string ObterMensagemAjuda()
        {
            return "Esta é a mensagem de ajuda padrão. Substitua este método nas subclasses para fornecer mensagens específicas.";
        }

        public void MostrarAjuda(string titulo, string mensagem)
        {
            PopupForm popup = new PopupForm(titulo, mensagem);
            popup.ShowDialog();
        }

        private void PanelEsquerda_Paint(object sender, PaintEventArgs e) {

        }
    }
}
