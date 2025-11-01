using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyFlow;


namespace StudyFlow
{ 
public partial class QuestoesForm : BaseForm
    {
        public QuestoesForm()
        {
            InitializeComponent();

            buttonMatematica.Click += (s, e) => MostrarListaQuestoes("Matemática e suas Tecnologias");
            buttonLinguagens.Click += (s, e) => MostrarListaQuestoes("Linguagens e suas Tecnologias");
            buttonCienciasH.Click += (s, e) => MostrarListaQuestoes("Ciências Humanas");
            buttonCienciasN.Click += (s, e) => MostrarListaQuestoes("Ciências da Natureza");
            buttonEnem.Click += (s, e) => MostrarListaQuestoes("ENEM");
            buttonProvaoP.Click += (s, e) => MostrarListaQuestoes("Provão Paulista");
        }

        private void MontarTelaInicial()
        {
            PanelConteudo.Controls.Clear();
            PanelConteudo.Controls.Add(panelCards);
        }

        private void MostrarListaQuestoes(string areaOuTipo)
        {
            string json = File.ReadAllText("questoes.json");
            List<Pergunta> questoes = JsonSerializer.Deserialize<List<Pergunta>>(json);
            List<Pergunta> questoesFiltradas = JsonSerializer.Deserialize<List<Pergunta>>(json);

            PanelConteudo.Controls.Clear();

            // Cria o painel principal que mostrará a lista
            KryptonPanel painelLista = new KryptonPanel();
            painelLista.Dock = DockStyle.Fill;
            painelLista.StateCommon.Color1 = Color.White;

            //
            // Botão Voltar
            //
            KryptonButton btnVoltar = new KryptonButton();
            btnVoltar.Text = "← Voltar";
            btnVoltar.Size = new Size(100, 40);
            btnVoltar.Location = new Point(20, 20);
            btnVoltar.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            btnVoltar.StateCommon.Back.Color2 = Color.FromArgb(255, 102, 0);
            btnVoltar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnVoltar.StateCommon.Border.Rounding = 6;
            btnVoltar.OverrideDefault.Back.Color1 = Color.White;
            btnVoltar.OverrideDefault.Back.Color2 = Color.White;
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.Click += (s, e) => MontarTelaInicial(); // volta para a tela dos cards
            painelLista.Controls.Add(btnVoltar);

            //
            // Título
            //
            KryptonLabel lblTitulo = new KryptonLabel();
            lblTitulo.Text = $"Questões - {areaOuTipo}";
            lblTitulo.Location = new Point(150, 25);
            lblTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitulo.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            painelLista.Controls.Add(lblTitulo);


            // Painel com scroll para a lista de questões
            Panel painelScroll = new Panel();
            painelScroll.Location = new Point(80, 90);
            painelScroll.Size = new Size(950, 500);
            painelScroll.AutoScroll = true;
            painelLista.Controls.Add(painelScroll);

            // Filtra as questões conforme a área ou tipo selecionado
            foreach (var w in questoesFiltradas)

            {

                switch (areaOuTipo)
                {
                    //adicionar o default em caso de o usuário quiser ver todas as questões
                    case "ENEM": questoesFiltradas = questoes.Where(w => w.Tipo == "Enem").ToList();
                        break;
                    case "Provão Paulista": questoesFiltradas = questoes.Where(w => w.Tipo == "Provão Paulista").ToList();
                        break;
                    case "Linguagens e suas Tecnologias": questoesFiltradas = questoes.Where(w => w.Area == "Linguagens e suas Tecnologias").ToList();
                        break;
                    case "Ciências Humanas": questoesFiltradas = questoes.Where(w => w.Area == "Ciências Humanas").ToList();
                        break;
                    case "Ciências da Natureza": questoesFiltradas = questoes.Where(w => w.Area == "Ciências da Natureza").ToList();
                        break;
                    case "Matemática e suas Tecnologias": questoesFiltradas = questoes.Where(w => w.Area == "Matemática e suas Tecnologias").ToList();
                        break;
                }

            }

            //importante não apagar esse for, porque ele cria os cards de cada questã. OBS.: mas pode ser mudado conforme a logica de carregar as questões
            int y = 0;
            foreach (var q in questoesFiltradas)

            {
                // Painel de cada questão
                KryptonPanel card = new KryptonPanel();
                card.Size = new Size(900, 50);
                card.Location = new Point(12, y + 12);
                card.StateCommon.Color1 = Color.White;
                card.Cursor = Cursors.Hand;

                // Efeito de hover
                card.MouseEnter += (s, e) => card.StateCommon.Color1 = Color.FromArgb(250, 250, 255);
                card.MouseLeave += (s, e) => card.StateCommon.Color1 = Color.White;

                //Evento de clique  (SEM NADA AINDA)
                card.Click += (s, e) =>
                {
                    /* 
                    *
                    *
                    * ADICIONAR A LOGICA DE ABRIR A QUESTAO AQUI
                    *
                    *
                    */


                    // Por enquanto só um efeito visual temporário
                    card.StateCommon.Color1 = Color.FromArgb(240, 240, 255);
                };

                // ID
                KryptonLabel lblId = new KryptonLabel();
                lblId.Text = q.ID;
                lblId.Location = new Point(20, 15);
                lblId.StateCommon.ShortText.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblId.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
                card.Controls.Add(lblId);

                // Tema
                KryptonLabel lblTema = new KryptonLabel();
                lblTema.Text = q.Tema;
                lblTema.Location = new Point(130, 15);
                lblTema.StateCommon.ShortText.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblTema.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
                card.Controls.Add(lblTema);

                // Pontos
                KryptonLabel lblPontos = new KryptonLabel();
                lblPontos.Text = $"{q.Pontuacao} pts";
                lblPontos.Location = new Point(800, 15);
                lblPontos.StateCommon.ShortText.Font = new Font("Segoe UI", 10);
                lblPontos.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
                card.Controls.Add(lblPontos);

                painelScroll.Controls.Add(card);
                y += 55;
            }

            // Troca o painel atual pelo de listagem
            TrocarConteudo(painelLista);
        }


        private void buttonMatematica_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonLinguagens_Click(object sender, EventArgs e)
        {

        }
    }
}