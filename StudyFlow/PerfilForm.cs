using Krypton.Toolkit;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace StudyFlow
{
    public partial class PerfilForm : BaseForm
    {
        KryptonTextBox textBoxNome;
        KryptonTextBox textBoxEmail;
        KryptonTextBox textBoxTel;
        KryptonTextBox textBoxSenha;
        KryptonRichTextBox textBoxSobre;
        KryptonButton labelposicao;

        bool modoEdicao = false;
        bool controler;

        public PerfilForm()
        {
            InitializeComponent();
            TelaPerfil();
        }
        String editNome, editTelefone, editSobremim, editEmail;

        private void linkLabelSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RecuperarSenhaForm recuperarSenha = new RecuperarSenhaForm();
            recuperarSenha.Show();
            

        }

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
            fotoPerfil.Location = new Point(130, 90);
            fotoPerfil.BackColor = Color.White;
            fotoPerfil.BorderStyle = BorderStyle.FixedSingle;
            fotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            perfilPanel.Controls.Add(fotoPerfil);

            //posição no rank
            labelposicao = new KryptonButton();
            labelposicao.Text = Usuario.UsuarioLogado.PosiçãoRanking + "º";
            labelposicao.Enabled = false;
            labelposicao.Location = new Point(145, 340);
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
            labelPontos.Location = new Point(145, 410);
            labelPontos.Size = new Size(170, 50);
            labelPontos.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            labelPontos.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            labelPontos.StateCommon.Content.ShortText.Color1 = Color.White;
            labelPontos.StateCommon.Border.Rounding = 10;
            perfilPanel.Controls.Add(labelPontos);


            //label nome
            KryptonLabel labelNome = new KryptonLabel();
            labelNome.Text = "Nome do Usuário";
            labelNome.Location = new Point(440, 105);
            labelNome.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelNome.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(labelNome);

            //Campo nome
            textBoxNome = new KryptonTextBox();
            textBoxNome.Location = new Point(440, 130);
            textBoxNome.Size = new Size(210, 40);
            editNome = Usuario.UsuarioLogado.NomeUser;
            textBoxNome.Text = "" + editNome;
            textBoxNome.StateCommon.Content.Font = new Font("Segoe UI", 12);
            textBoxNome.StateCommon.Border.Rounding = 8;
            textBoxNome.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textBoxNome.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(textBoxNome);


            //label E-mail
            KryptonLabel labelEmail = new KryptonLabel();
            labelEmail.Text = "E-mail: ";
            labelEmail.Location = new Point(440, 185);
            labelEmail.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelEmail.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(labelEmail);

            //Campo E-mail
            textBoxEmail = new KryptonTextBox();
            textBoxEmail.Location = new Point(440, 210);
            textBoxEmail.Size = new Size(210, 40);
            editEmail = Usuario.UsuarioLogado.Email;
            textBoxEmail.Text = "" + editEmail;
            textBoxEmail.StateCommon.Content.Font = new Font("Segoe UI", 12);
            textBoxEmail.StateCommon.Border.Rounding = 8;
            textBoxEmail.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textBoxEmail.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(textBoxEmail);


            // 
            // linkLabelSenha
            // 
            linkLabelSenha = new LinkLabel();
            linkLabelSenha.ActiveLinkColor = Color.Gray;
            linkLabelSenha.AutoSize = true;
            linkLabelSenha.BackColor = Color.White;
            linkLabelSenha.Cursor = Cursors.Hand;
            linkLabelSenha.Font = new Font("Segoe UI", 9F);
            linkLabelSenha.LinkColor = Color.Gray;
            linkLabelSenha.Location = new Point(745, 248);
            linkLabelSenha.Name = "linkLabelSenha";
            linkLabelSenha.Size = new Size(118, 15);
            linkLabelSenha.TabIndex = 3;
            linkLabelSenha.TabStop = true;
            linkLabelSenha.Text = "Esqueci minha senha";
            linkLabelSenha.VisitedLinkColor = Color.Gray;
            linkLabelSenha.LinkClicked += linkLabelSenha_LinkClicked;
            perfilPanel.Controls.Add(linkLabelSenha);

            //label telefone
            KryptonLabel labelTel = new KryptonLabel();
            labelTel.Text = "Telefone: ";
            labelTel.Location = new Point(700, 105);
            labelTel.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelTel.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(labelTel);

            //Campo telefone
            textBoxTel = new KryptonTextBox();
            textBoxTel.Location = new Point(700, 130);
            textBoxTel.Size = new Size(210, 40);
            editTelefone = Usuario.UsuarioLogado.Telefone;
            textBoxTel.Text = FormatarTelefone(editTelefone, controler);
            textBoxTel.StateCommon.Content.Font = new Font("Segoe UI", 12);
            textBoxTel.StateCommon.Border.Rounding = 8;
            textBoxTel.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textBoxTel.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(textBoxTel);


            //label senha
            KryptonLabel labelSenha = new KryptonLabel();
            labelSenha.Text = "Senha:";
            labelSenha.Location = new Point(690, 175);
            labelSenha.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelSenha.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(labelSenha);

            //Campo senha
            textBoxSenha = new KryptonTextBox();
            textBoxSenha.Location = new Point(700, 210);
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
            labelSobre.Location = new Point(440, 295);
            labelSobre.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            labelSobre.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(labelSobre);

            //Campo Sobre mim
            textBoxSobre = new KryptonRichTextBox();
            textBoxSobre.Location = new Point(440, 320);
            textBoxSobre.Size = new Size(475, 180);
            editSobremim = Usuario.UsuarioLogado.TextoUser;
            textBoxSobre.Text = "" + editSobremim;
            textBoxSobre.StateCommon.Content.Font = new Font("Segoe UI", 12);
            textBoxSobre.StateCommon.Border.Rounding = 8;
            textBoxSobre.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textBoxSobre.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            perfilPanel.Controls.Add(textBoxSobre);

            // botao editar 
            // 
            PictureBox iconEdit = new PictureBox();
            iconEdit.Size = new Size(40, 40);
            iconEdit.Location = new Point(930, 80);
            iconEdit.BackColor = Color.White;
            iconEdit.Image = Properties.Resources.edit;
            iconEdit.SizeMode = PictureBoxSizeMode.Zoom;
            iconEdit.Cursor = Cursors.Hand;

            iconEdit.MouseDown += (s, e) =>
            {
                iconEdit.Size = new Size(36, 36);
                iconEdit.Location = new Point(932, 82);
            };

            iconEdit.MouseUp += (s, e) =>
            {
                iconEdit.Size = new Size(40, 40);
                iconEdit.Location = new Point(930, 80);
            };

            iconEdit.Click += (s, e) =>
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

            perfilPanel.Controls.Add(iconEdit);


            // botao salvar
            KryptonButton buttonSalvar = new KryptonButton();
            buttonSalvar.Text = "Salvar";
            buttonSalvar.Location = new Point(600, 510);
            buttonSalvar.Size = new Size(130, 45);
            buttonSalvar.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            buttonSalvar.StateCommon.Back.Color2 = Color.FromArgb(255, 102, 0);
            buttonSalvar.OverrideDefault.Back.Color1 = Color.FromArgb(255, 102, 0);
            buttonSalvar.OverrideDefault.Back.Color2 = Color.FromArgb(255, 102, 0);
            buttonSalvar.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            buttonSalvar.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonSalvar.StateCommon.Border.Color2 = Color.FromArgb(255, 102, 0);
            buttonSalvar.StatePressed.Back.Color1 = Color.FromArgb(230, 92, 0);
            buttonSalvar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            buttonSalvar.StateCommon.Content.ShortText.Color1 = Color.White;
            buttonSalvar.StateCommon.Border.Rounding = 15;
            buttonSalvar.Cursor = Cursors.Hand;
            buttonSalvar.Click += (s, e) => SalvarEdicao();
            perfilPanel.Controls.Add(buttonSalvar);

            buttonSalvar.MouseDown += (s, e) =>
            {
                buttonSalvar.Size = new Size(125, 40);
                buttonSalvar.Location = new Point(603, 513);
            };

            buttonSalvar.MouseUp += (s, e) =>
            {
                buttonSalvar.Size = new Size(130, 45);
                buttonSalvar.Location = new Point(600, 510);
            };

            BloquearCampos();

            TrocarConteudo(perfilPanel);
        }

        private void BloquearCampos()
        {

            textBoxNome.Text = Usuario.UsuarioLogado.NomeUser;
            textBoxEmail.Text = Usuario.UsuarioLogado.Email;
            textBoxTel.Text = FormatarTelefone(editTelefone, controler = true);
            textBoxSobre.Text = Usuario.UsuarioLogado.TextoUser;

            textBoxNome.Enabled = false;
            textBoxEmail.Enabled = false;
            textBoxTel.Enabled = false;
            textBoxSenha.Enabled = false;
            textBoxSobre.Enabled = false;

            modoEdicao = false;
        }

        private void EntrarModoEdicao()
        {
            textBoxTel.Text = FormatarTelefone(editTelefone, controler = false);
            textBoxNome.Enabled = true;
            textBoxEmail.Enabled = true;
            textBoxTel.Enabled = true;
            textBoxSenha.Enabled = false;
            textBoxSobre.Enabled = true;

            modoEdicao = true;
        }

        private void SalvarEdicao()
        {

            if (modoEdicao)
            {
                Usuario.EditarUsuario(textBoxNome.Text, textBoxTel.Text, textBoxSobre.Text, textBoxEmail.Text);
                BloquearCampos();
            }
        }

        public static string FormatarTelefone(string editTelefone, bool controler)
        {


            if (controler == true)
            {
                return Convert.ToUInt64(editTelefone).ToString(@"\(00\) 00000\-0000");
                KryptonMessageBox.Show("oi");
            }

            else
            {
                return Regex.Replace(editTelefone, @"\D", "");

            }

        }


        private string ajudaTexto = "Nesta tela você pode visualizar e editar as informações do seu perfil.\n\n" +
            "Campos disponíveis para edição:\n" +
            "- Nome: Atualize seu nome completo.\n" +
            "- Telefone: Modifique seu número de telefone para contato.\n" +
            "- Sobre mim: Adicione ou altere uma breve descrição sobre você.\n\n" +
            "Para editar suas informações, clique no ícone de lápis no canto superior direito. Após fazer as alterações desejadas, clique no botão 'Salvar' para atualizar seu perfil.\n\n" +
            "Lembre-se de que o CPF e a senha não podem ser alterados nesta tela por questões de segurança.";

        public override string ObterMensagemAjuda()
        {
            return ajudaTexto;
        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
