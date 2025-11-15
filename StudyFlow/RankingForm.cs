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
    public partial class RankingForm : BaseForm
    {
        public RankingForm()
        {
            InitializeComponent();
            TelaRanking();
        }
        private void TelaRanking()
        {
            PanelConteudo.Controls.Clear();

            //
            // Panel de Conteúdo
            //
            KryptonPanel panelRanking = new KryptonPanel();
            panelRanking.Dock = DockStyle.Fill;
            panelRanking.StateNormal.Color1 = Color.White;

            //
            // Titulo
            //
            KryptonLabel labelTitulo = new KryptonLabel();
            labelTitulo.Text = "Ranking de Usuários";
            labelTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitulo.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            labelTitulo.Location = new Point(70, 20);
            panelRanking.Controls.Add(labelTitulo);

            //
            // panel lista
            //
            Panel panelScroll = new Panel();
            panelScroll.Location = new Point(60, 120);
            panelScroll.Size = new Size(950, 500);
            panelScroll.AutoScroll = true;
            panelScroll.BackColor = Color.White;
            panelRanking.Controls.Add(panelScroll);

            //
            // Cabeçalho da lista
            //
            // posicao
            KryptonButton labelCabecalhoPosicao = new KryptonButton();
            labelCabecalhoPosicao.Text = "Posição";
            labelCabecalhoPosicao.Enabled = false;
            labelCabecalhoPosicao.Location = new Point(85, 80);
            labelCabecalhoPosicao.Size = new Size(90, 30);
            labelCabecalhoPosicao.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            labelCabecalhoPosicao.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelCabecalhoPosicao.StateCommon.Content.ShortText.Color1 = Color.White;
            labelCabecalhoPosicao.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            labelCabecalhoPosicao.StateCommon.Border.Color1 = Color.White;
            labelCabecalhoPosicao.StateCommon.Border.Rounding = 8;
            panelRanking.Controls.Add(labelCabecalhoPosicao);

            // usuario 
            KryptonButton labelCabecalhoUsuario = new KryptonButton();
            labelCabecalhoUsuario.Text = "Usuário";
            labelCabecalhoUsuario.Enabled = false;
            labelCabecalhoUsuario.Location = new Point(220, 80);
            labelCabecalhoUsuario.Size = new Size(90, 30);
            labelCabecalhoUsuario.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            labelCabecalhoUsuario.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelCabecalhoUsuario.StateCommon.Content.ShortText.Color1 = Color.White;
            labelCabecalhoUsuario.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            labelCabecalhoUsuario.StateCommon.Border.Color1 = Color.White;
            labelCabecalhoUsuario.StateCommon.Border.Rounding = 8;
            panelRanking.Controls.Add(labelCabecalhoUsuario);


            //Questoes respodidas
            //KryptonButton labelCabecalhoTentativas = new KryptonButton();
            //labelCabecalhoTentativas.Text = "Respondidas";
            //labelCabecalhoTentativas.Enabled = false;
            //labelCabecalhoTentativas.Location = new Point(355, 80);
            //labelCabecalhoTentativas.Size = new Size(120, 30);
            //labelCabecalhoTentativas.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            //labelCabecalhoTentativas.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            //labelCabecalhoTentativas.StateCommon.Content.ShortText.Color1 = Color.White;
            //labelCabecalhoTentativas.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            //labelCabecalhoTentativas.StateCommon.Border.Color1 = Color.White;
            //labelCabecalhoTentativas.StateCommon.Border.Rounding = 8;
            //panelRanking.Controls.Add(labelCabecalhoTentativas);

            // pontuaçao

            KryptonButton labelCabecalhoPontuacao = new KryptonButton();
            labelCabecalhoPontuacao.Text = "Pontos";
            labelCabecalhoPontuacao.Enabled = false;
            labelCabecalhoPontuacao.Location = new Point(870, 80);
            labelCabecalhoPontuacao.Size = new Size(90, 30);
            labelCabecalhoPontuacao.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            labelCabecalhoPontuacao.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelCabecalhoPontuacao.StateCommon.Content.ShortText.Color1 = Color.White;
            labelCabecalhoPontuacao.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            labelCabecalhoPontuacao.StateCommon.Border.Color1 = Color.White;
            labelCabecalhoPontuacao.StateCommon.Border.Rounding = 8;
            panelRanking.Controls.Add(labelCabecalhoPontuacao);


            
            Ranking.CalcularRanking();
            Ranking.RankingGeral.Sort((a, b) => b.PontuacaoPrioridade.CompareTo(a.PontuacaoPrioridade));

            int y = 10;
            int posicao = 1;

            foreach (var user in Ranking.RankingGeral)
            {
                KryptonButton linha = new KryptonButton();
                linha.Size = new Size(900, 45);
                linha.Text = "";
                linha.Location = new Point(20, y);
                linha.StateCommon.Back.Color1 = Color.White;
                linha.StateCommon.Border.Color1 = Color.FromArgb(230, 230, 230);
                linha.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                linha.StateCommon.Border.Rounding = 10;
                linha.StateCommon.Border.Width = 1;
                linha.Enabled = false;


                if (Usuario.UsuarioLogado.NomeUser == user.NomeUserRanking)
                {
                    Usuario.UsuarioLogado.PosiçãoRanking = posicao;
                    //KryptonMessageBox.Show("posição do usuario logado: " + Usuario.UsuarioLogado.PosiçãoRanking);


                    //linha.StateCommon.Border.Color1 = Color.FromArgb(10, 35, 80);
                    linha.StateCommon.Back.Color1 = Color.FromArgb(215, 215, 215); ;


                }





                if (posicao == 1)
                {
                    linha.StateCommon.Border.Color1 = Color.FromArgb(255, 180, 40);
                }
                else if (posicao == 2)
                {
                    linha.StateCommon.Border.Color1 = Color.FromArgb(180, 180, 180);
                }
                else if (posicao == 3)
                {
                    linha.StateCommon.Border.Color1 = Color.FromArgb(220, 120, 60);
                }

                // Posição
                KryptonLabel labelPos = new KryptonLabel();
                labelPos.Text = $"{posicao}º";
                labelPos.Location = new Point(30, 10);
                labelPos.StateCommon.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                labelPos.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
                linha.Controls.Add(labelPos);

                // Usuário
                KryptonLabel labelNome = new KryptonLabel();
                labelNome.Text = user.NomeUserRanking;
                labelNome.Location = new Point(150, 10);
                labelNome.StateCommon.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                labelNome.StateCommon.ShortText.Color1 = Color.FromArgb(83, 79, 79);
                labelNome.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
                labelNome.StateCommon.ShortText.TextV = PaletteRelativeAlign.Center;
                linha.Controls.Add(labelNome);

                // Pontos
                KryptonLabel labelPontos = new KryptonLabel();
                labelPontos.Text = $"{user.PontuacaoPrioridade:F2} pts";
                labelPontos.Location = new Point(800, 10);
                labelPontos.StateCommon.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                labelPontos.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
                linha.Controls.Add(labelPontos);

                panelScroll.Controls.Add(linha);
                y += 50;
                posicao++;
            }
            
            TrocarConteudo(panelRanking);
        }
    }
}
