using Krypton.Toolkit;
using StudyFlow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


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

                //Evento de clique
                card.Click += (s, e) => MostrarQuestao(q);


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

        //Interface Questão
        private void MostrarQuestao(Pergunta questao)
        {
            PanelConteudo.Controls.Clear();

            KryptonPanel panelQuestao = new KryptonPanel();
            panelQuestao.Dock = DockStyle.Fill;
            panelQuestao.StateCommon.Color1 = Color.White;

            //
            // Voltar
            //
            KryptonButton buttonVoltar = new KryptonButton();
            buttonVoltar.Text = "← Voltar";
            buttonVoltar.Size = new Size(100, 40);
            buttonVoltar.Location = new Point(20, 20);
            buttonVoltar.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            buttonVoltar.StateCommon.Back.Color2 = Color.FromArgb(255, 102, 0);
            buttonVoltar.StateCommon.Content.ShortText.Color1 = Color.White;
            buttonVoltar.StateCommon.Border.Rounding = 6;
            buttonVoltar.OverrideDefault.Back.Color1 = Color.White;
            buttonVoltar.OverrideDefault.Back.Color2 = Color.White;
            buttonVoltar.Cursor = Cursors.Hand;
            buttonVoltar.Click += (s, e) => MostrarListaQuestoes(questao.Area); // volta para a lista de questões
            panelQuestao.Controls.Add(buttonVoltar);

            // cabeçalho da questão
            int baseY = 50;

            //
            // ID questão
            //
            KryptonButton labelID = new KryptonButton();
            labelID.Text = questao.ID.ToString();
            labelID.Enabled = false;
            labelID.Location = new Point(140, baseY - 5);
            labelID.Size = new Size(60, 30);
            labelID.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            labelID.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelID.StateCommon.Content.ShortText.Color1 = Color.White;
            labelID.StateCommon.Border.Rounding = 8;
            panelQuestao.Controls.Add(labelID);

            //
            // Tipo da questão
            //
            KryptonButton labelTipo = new KryptonButton();
            labelTipo.Text = questao.Tipo.ToUpper();
            labelTipo.Enabled = false;
            labelTipo.Size = new Size(80, 30);
            labelTipo.Location = new Point(220, baseY - 5);
            labelTipo.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            labelTipo.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelTipo.StateCommon.Content.ShortText.Color1 = Color.White;
            labelTipo.StateCommon.Border.Rounding = 8;
            panelQuestao.Controls.Add(labelTipo);




            //
            // Area da questão
            //
            KryptonButton labelArea = new KryptonButton();
            labelArea.Text = questao.Area;
            labelArea.Enabled = false;
            labelArea.Location = new Point(320, baseY - 5); 
            labelArea.Size = new Size(270, 30);
            labelArea.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            labelArea.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelArea.StateCommon.Content.ShortText.Color1 = Color.White;
            labelArea.StateCommon.Border.Rounding = 8;
            panelQuestao.Controls.Add(labelArea);



            //
            // Caixa do enunciado
            //
            KryptonRichTextBox textEnunciado = new KryptonRichTextBox();
            textEnunciado.Size = new Size(850, 200);
            textEnunciado.Location = new Point(135, baseY + 30);
            textEnunciado.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            textEnunciado.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textEnunciado.StateCommon.Border.Rounding = 6;
            textEnunciado.StateCommon.Content.Font = new Font("Segoe UI", 12);
            
            textEnunciado.Text = questao.Enunciado;
            textEnunciado.ReadOnly = true;
            panelQuestao.Controls.Add(textEnunciado);

            //
            // Alternativas
            //
            int y = baseY + 250;
            string[] alternativas = new string[]
            {
                
               questao.A,
               questao.B,
               questao.C,
               questao.D,
               questao.E

            };

            KryptonButton alternativaSelecionada = null;
            
            for(int i = 0; i < alternativas.Length; i++)
            {
                KryptonButton buttonAlternativa = new KryptonButton();
                buttonAlternativa.Size = new Size(850, 40);
                buttonAlternativa.Location = new Point(135, y);
                buttonAlternativa.StateCommon.Back.Color1 = Color.White;
                buttonAlternativa.StateCommon.Back.Color2 = Color.White;
                buttonAlternativa.OverrideDefault.Back.Color1 = Color.White;
                buttonAlternativa.OverrideDefault.Back.Color2 = Color.White;
                buttonAlternativa.StatePressed.Back.Color1 = Color.FromArgb(255, 102, 0);
                buttonAlternativa.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
                buttonAlternativa.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                buttonAlternativa.StateCommon.Border.Rounding = 6;
                buttonAlternativa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10);
                buttonAlternativa.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
                buttonAlternativa.StateCommon.Content.Padding = new Padding(40, 5, 10, 5);
                buttonAlternativa.Cursor = Cursors.Hand;

                // Letras A, B, C, D, E
                KryptonLabel labelLetra = new KryptonLabel();
                labelLetra.Text = ((char)('A' + i)).ToString();
                labelLetra.StateCommon.ShortText.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                labelLetra.StateCommon.ShortText.Color1 = Color.Orange;
                labelLetra.Location = new Point(10, 5);

                buttonAlternativa.Controls.Add(labelLetra);
                buttonAlternativa.Text = alternativas[i];

                // Evento de clique
                buttonAlternativa.Click += (s, e) =>
                {
                    if (alternativaSelecionada != null)
                    {                       
                        alternativaSelecionada.StateCommon.Back.Color1 = Color.White;
                    }
                    alternativaSelecionada = buttonAlternativa;
                    buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(255, 235, 200);
                };

                panelQuestao.Controls.Add(buttonAlternativa);
                y += 50;
            }

            //
            // Botão Confirmar
            //
            KryptonButton buttonConfirmar = new KryptonButton();
            buttonConfirmar.Text = "Confirmar Resposta";
            buttonConfirmar.Size = new Size(200, 40);
            buttonConfirmar.Location = new Point(455, y + 5);
            buttonConfirmar.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            buttonConfirmar.StateCommon.Back.Color2 = Color.FromArgb(32, 0, 177);
            buttonConfirmar.OverrideDefault.Back.Color1 = Color.White;
            buttonConfirmar.OverrideDefault.Back.Color2 = Color.White;
            buttonConfirmar.StateCommon.Content.ShortText.Color1 = Color.White;
            buttonConfirmar.StateCommon.Border.Rounding = 6;
            buttonConfirmar.Cursor = Cursors.Hand;

            buttonConfirmar.Click += (s, e) =>
            {
                // logica para confirmar resposta
            };

            panelQuestao.Controls.Add(buttonConfirmar);

            TrocarConteudo(panelQuestao);
        }


        private void buttonMatematica_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonLinguagens_Click(object sender, EventArgs e)
        {

        }
    }
}