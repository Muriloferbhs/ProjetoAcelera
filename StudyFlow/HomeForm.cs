using Krypton.Toolkit;
using System;
using System.Buffers.Text;
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
    public partial class HomeForm : BaseForm
    {
        KryptonTextBox textBoxNome;
        KryptonTextBox textBoxCpf;
        KryptonTextBox textBoxTel;
        KryptonTextBox textBoxSenha;
        KryptonRichTextBox textBoxSobre;

        bool modoEdicao = false;

        public HomeForm()
        {
            InitializeComponent();
            TelaPerfil();
        }
        String editNome, editTelefone, editSobremim;


        private void TelaPerfil()
        {
            PanelConteudo.Controls.Clear();
 
            KryptonPanel perfilPanel = new KryptonPanel();
            perfilPanel.StateCommon.Color1 = Color.White;
            perfilPanel.Dock = DockStyle.Fill;
            PanelConteudo.Controls.Add(perfilPanel);

            //foto usuário
            PictureBox fotoPerfil = new PictureBox();
            fotoPerfil.Size = new Size(200, 200);
            fotoPerfil.Location = new Point(150, 110);
            fotoPerfil.BackColor = Color.White;
            fotoPerfil.BorderStyle = BorderStyle.FixedSingle;
            fotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            perfilPanel.Controls.Add(fotoPerfil);

            //posição no rank
            KryptonButton labelposicao = new KryptonButton();
            labelposicao.Text =  Usuario.UsuarioLogado.PosiçãoRanking + "º";
            labelposicao.Enabled = false;
            labelposicao.Location = new Point(165,360);
            labelposicao.Size = new Size(170, 50);
            labelposicao.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            labelposicao.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            labelposicao.StateCommon.Content.ShortText.Color1 = Color.White;
            labelposicao.StateCommon.Border.Rounding = 10;
            perfilPanel.Controls.Add(labelposicao);

            //pontos 
            KryptonButton labelPontos = new KryptonButton();
            labelPontos.Text = $"{Usuario.UsuarioLogado.Pontuacao:F2} pts";
            labelPontos.Enabled = false;
            labelPontos.Location = new Point(165, 430);
            labelPontos.Size = new Size(170, 50);
            labelPontos.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            labelPontos.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            labelPontos.StateCommon.Content.ShortText.Color1 = Color.White;
            labelPontos.StateCommon.Border.Rounding = 10;
            perfilPanel.Controls.Add(labelPontos);


            //label nome
            KryptonLabel labelNome = new KryptonLabel();
            labelNome.Text = "Nome do Usuário";
            labelNome.Location = new Point(460, 125);
            labelNome.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelNome.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(labelNome);

            //Campo nome
            textBoxNome = new KryptonTextBox();
            textBoxNome.Location = new Point(460, 150);
            textBoxNome.Size = new Size(210, 40);
            editNome = Usuario.UsuarioLogado.NomeUser;
            textBoxNome.Text = "" + editNome;
            textBoxNome.StateCommon.Content.Font = new Font("Segoe UI", 12);
            textBoxNome.StateCommon.Border.Rounding = 8;
            textBoxNome.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textBoxNome.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(textBoxNome);


            //label CPF
            KryptonLabel labelCpf = new KryptonLabel();
            labelCpf.Text = "Cpf: ";
            labelCpf.Location = new Point(460, 205);
            labelCpf.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelCpf.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(labelCpf);

            //Campo CPF
            textBoxCpf = new KryptonTextBox();
            textBoxCpf.Location = new Point(460, 230);
            textBoxCpf.Size = new Size(210, 40);
            textBoxCpf.Text = "" + Usuario.UsuarioLogado.Cpf;
            textBoxCpf.StateCommon.Content.Font = new Font("Segoe UI", 12);
            textBoxCpf.StateCommon.Border.Rounding = 8;
            textBoxCpf.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textBoxCpf.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(textBoxCpf);


            //label telefone
            KryptonLabel labelTel = new KryptonLabel();
            labelTel.Text = "Telefone: ";
            labelTel.Location = new Point(720, 125);
            labelTel.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelTel.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(labelTel);

            //Campo telefone
            textBoxTel = new KryptonTextBox();
            textBoxTel.Location = new Point(720, 150);
            textBoxTel.Size = new Size(210, 40);
            editTelefone = Usuario.UsuarioLogado.Telefone;
            textBoxTel.Text = "" + editTelefone;
            textBoxTel.StateCommon.Content.Font = new Font("Segoe UI", 12);
            textBoxTel.StateCommon.Border.Rounding = 8;
            textBoxTel.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textBoxTel.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(textBoxTel);


            //label senha
            KryptonLabel labelSenha = new KryptonLabel();
            labelSenha.Text = "Senha:";
            labelSenha.Location = new Point(720, 205);
            labelSenha.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelSenha.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(labelSenha);

            //Campo senha
            textBoxSenha = new KryptonTextBox();
            textBoxSenha.Location = new Point(720, 230);
            textBoxSenha.Size = new Size(210, 40);
            textBoxSenha.Text = "********";
            textBoxSenha.StateCommon.Content.Font = new Font("Segoe UI", 12);
            textBoxSenha.StateCommon.Border.Rounding = 8;
            textBoxSenha.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textBoxSenha.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(textBoxSenha);


            //label sobre mim
            KryptonLabel labelSobre = new KryptonLabel();
            labelSobre.Text = "Sobre mim:";
            labelSobre.Location = new Point(460, 315);
            labelSobre.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelSobre.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(labelSobre);

            //Campo Sobre mim
            textBoxSobre = new KryptonRichTextBox();
            textBoxSobre.Location = new Point(460, 340);
            textBoxSobre.Size = new Size(475, 180);
            editSobremim = Usuario.UsuarioLogado.TextoUser;
            textBoxSobre.Text = "" + editSobremim;
            textBoxSobre.StateCommon.Content.Font = new Font("Segoe UI", 12);
            textBoxSobre.StateCommon.Border.Rounding = 8;
            textBoxSobre.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textBoxSobre.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(textBoxSobre);

            // botao editar  ***provisorio*** 
            KryptonButton btnEditar = new KryptonButton();
            btnEditar.Size = new Size(70, 70);
            btnEditar.Location = new Point(950, 80);
            btnEditar.StateCommon.Back.Color1 = Color.Orange;
            btnEditar.StateCommon.Border.Rounding = 25;
            btnEditar.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            btnEditar.Text = "Editar";
            btnEditar.Click += (s, e) =>
            {
                if (modoEdicao == false) { EntrarModoEdicao(); }
                else 
                {
                    textBoxNome.Text = Usuario.UsuarioLogado.NomeUser;
                    textBoxTel.Text = Usuario.UsuarioLogado.Telefone;
                    textBoxSobre.Text = Usuario.UsuarioLogado.TextoUser;

                    BloquearCampos(); 
                }


            };
            
            
            
            
            
            
            
            perfilPanel.Controls.Add(btnEditar);


            // botao salvar
            KryptonButton buttonSalvar = new KryptonButton();
            buttonSalvar.Text = "Salvar";
            buttonSalvar.Location = new Point(620, 530);
            buttonSalvar.Size = new Size(150, 45);
            buttonSalvar.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            buttonSalvar.StateCommon.Back.Color2 = Color.FromArgb(255, 102, 0);
            buttonSalvar.OverrideDefault.Back.Color1 = Color.FromArgb(255, 102, 0);
            buttonSalvar.OverrideDefault.Back.Color2 = Color.FromArgb(255, 102, 0);
            buttonSalvar.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonSalvar.StateCommon.Border.Color2 = Color.FromArgb(255, 102, 0);
            buttonSalvar.StatePressed.Back.Color1 = Color.FromArgb(230, 92, 0);
            buttonSalvar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonSalvar.StateCommon.Content.ShortText.Color1 = Color.White;
            buttonSalvar.StateCommon.Border.Rounding = 8;
            buttonSalvar.Cursor = Cursors.Hand;
            buttonSalvar.Click += (s, e) => SalvarEdicao();
            perfilPanel.Controls.Add(buttonSalvar);

            BloquearCampos();



            TrocarConteudo(perfilPanel);
        }
        
        private void BloquearCampos()
        {

            textBoxNome.Enabled = false;
            textBoxCpf.Enabled = false;
            textBoxTel.Enabled = false;
            textBoxSenha.Enabled = false;
            textBoxSobre.Enabled = false;

            modoEdicao = false;
        }

        private void EntrarModoEdicao()
        {
            textBoxNome.Enabled = true;
            textBoxCpf.Enabled = false;
            textBoxTel.Enabled = true;
            textBoxSenha.Enabled = false;
            textBoxSobre.Enabled = true;

            modoEdicao = true;
        }

        private void SalvarEdicao()
        {


            Usuario.EditarUsuario(textBoxNome.Text, textBoxTel.Text, textBoxSobre.Text);

            if (modoEdicao)
            {
                // adicionar logica para salvar os dados editados
                 BloquearCampos();
            }
        }
    }
}
