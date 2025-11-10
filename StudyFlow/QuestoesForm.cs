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
            KryptonPanel panelLista = new KryptonPanel();
            panelLista.Dock = DockStyle.Fill;
            panelLista.StateCommon.Color1 = Color.White;

            //
            // Botão Voltar
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
            buttonVoltar.Click += (s, e) => MontarTelaInicial(); // volta para a tela dos cards
            panelLista.Controls.Add(buttonVoltar);

            //
            // Título
            //
            KryptonLabel labelTitulo = new KryptonLabel();
            labelTitulo.Text = $"Questões - {areaOuTipo}";
            labelTitulo.Location = new Point(150, 25);
            labelTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            labelTitulo.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            panelLista.Controls.Add(labelTitulo);


            // Painel com scroll para a lista de questões
            Panel panelScroll = new Panel();
            panelScroll.Location = new Point(80, 90);
            panelScroll.Size = new Size(950, 500);
            panelScroll.AutoScroll = true;
            panelLista.Controls.Add(panelScroll);

            // Filtra as questões conforme a área ou tipo selecionado
            foreach (var w in questoesFiltradas)

            {

                switch (areaOuTipo)
                {
                    //adicionar o default em caso de o usuário quiser ver todas as questões
                    case "ENEM":
                        questoesFiltradas = questoes.Where(w => w.Tipo == "Enem").ToList();
                        break;
                    case "Provão Paulista":
                        questoesFiltradas = questoes.Where(w => w.Tipo == "Provão Paulista").ToList();
                        break;
                    case "Linguagens e suas Tecnologias":
                        questoesFiltradas = questoes.Where(w => w.Area == "Linguagens e suas Tecnologias").ToList();
                        break;
                    case "Ciências Humanas":
                        questoesFiltradas = questoes.Where(w => w.Area == "Ciências Humanas").ToList();
                        break;
                    case "Ciências da Natureza":
                        questoesFiltradas = questoes.Where(w => w.Area == "Ciências da Natureza").ToList();
                        break;
                    case "Matemática e suas Tecnologias":
                        questoesFiltradas = questoes.Where(w => w.Area == "Matemática e suas Tecnologias").ToList();
                        break;
                }

            }


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
                KryptonLabel labelId = new KryptonLabel();
                labelId.Text = q.ID;
                labelId.Location = new Point(20, 15);
                labelId.StateCommon.ShortText.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                labelId.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
                card.Controls.Add(labelId);

                // Tema
                KryptonLabel labelTema = new KryptonLabel();
                labelTema.Text = q.Tema;
                labelTema.Location = new Point(130, 15);
                labelTema.StateCommon.ShortText.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                labelTema.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
                card.Controls.Add(labelTema);

                // Pontos
                KryptonLabel labelPontos = new KryptonLabel();
                labelPontos.Text = $"{q.Pontuacao} pts";
                labelPontos.Location = new Point(800, 15);
                labelPontos.StateCommon.ShortText.Font = new Font("Segoe UI", 10);
                labelPontos.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
                card.Controls.Add(labelPontos);

                panelScroll.Controls.Add(card);
                y += 55;
            }

            // Troca o painel atual pelo de listagem
            TrocarConteudo(panelLista);
        }

        //Interface Questão
        private void MostrarQuestao(Pergunta questao)
        {

            string respostaDada = "";
            Usuario usuarioLogado = Usuario.UsuarioLogado;
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
            List<KryptonButton> botoesAlternativas = new List<KryptonButton>(); //lista para armazenar os botões das alternativas 

            for (int i = 0; i < alternativas.Length; i++)
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
                botoesAlternativas.Add(buttonAlternativa);

                // Evento de clique
                buttonAlternativa.Click += (s, e) =>
                {
                    panelQuestao.Focus();
                    alternativaSelecionada = buttonAlternativa;
                    respostaDada = alternativaSelecionada.Text;




                    DialogResult resultado = MessageBox.Show(
                        $"Deseja selecionar a alternativa {labelLetra.Text}?",
                        "Confirme sua resposta",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                        );

                    if (resultado == DialogResult.Yes)
                    {
                        if (!Pergunta.JaRespondeu(questao.ID))
                        {

                            if (respostaDada != questao.Resposta)
                            {
                                questao.Erros++;
                                if (questao.Erros == 1)
                                {

                                    questao.PontuacaoParcial = questao.Pontuacao * 2 / 3;

                                    buttonAlternativa.StateCommon.Border.Color1 = Color.Red;
                                    buttonAlternativa.StateCommon.Border.Color2 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Border.Color1 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.StateCommon.Border.Width = 1;
                                    buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(250, 250, 250);
                                    buttonAlternativa.StateCommon.Back.Color2 = Color.FromArgb(250, 250, 250);

                                    buttonAlternativa.Enabled = false;


                                    MessageBox.Show("Resposta incorreta!", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }

                                else if (questao.Erros == 2)
                                {
                                    questao.PontuacaoParcial = questao.Pontuacao * 1 / 3;

                                    buttonAlternativa.StateCommon.Border.Color1 = Color.Red;
                                    buttonAlternativa.StateCommon.Border.Color2 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Border.Color1 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.StateCommon.Border.Width = 1;
                                    buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(250, 250, 250);
                                    buttonAlternativa.StateCommon.Back.Color2 = Color.FromArgb(250, 250, 250);

                                    buttonAlternativa.Enabled = false;


                                    MessageBox.Show("Resposta incorreta!", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                else if (questao.Erros >= 3)
                                {
                                    questao.PontuacaoParcial = 0;

                                    buttonAlternativa.StateCommon.Border.Color1 = Color.Red;
                                    buttonAlternativa.StateCommon.Border.Color2 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Border.Color1 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.StateCommon.Border.Width = 1;
                                    buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(250, 250, 250);
                                    buttonAlternativa.StateCommon.Back.Color2 = Color.FromArgb(250, 250, 250);

                                    buttonAlternativa.Enabled = false;


                                    questao.Respondida = true;
                                    Pergunta.MarcarComoRespondida(questao.ID);
                                    MessageBox.Show("Resposta incorreta!", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    foreach (var bloqueio in botoesAlternativas)
                                    {
                                        bloqueio.Enabled = false;

                                    }
                                    questao.Erros = 0;
                                }

                            }

                            else
                            {
                                //tela pra aparecer que acertou a pergunta
                                usuarioLogado.Pontuacao += questao.PontuacaoParcial;
                                buttonAlternativa.StateCommon.Border.Color1 = Color.LightGreen;
                                buttonAlternativa.StateCommon.Border.Color2 = Color.LightGreen;
                                buttonAlternativa.OverrideDefault.Border.Color1 = Color.LightGreen;
                                buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(235, 255, 235);
                                buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(235, 255, 235);
                                buttonAlternativa.StateCommon.Border.Width = 2;
                                buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(235, 255, 235);
                                buttonAlternativa.Enabled = false;

                                questao.Respondida = true;
                                Pergunta.MarcarComoRespondida(questao.ID);
                                MessageBox.Show("Resposta Correta!", "Parabéns",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                foreach (var bloqueio in botoesAlternativas)
                                {

                                    bloqueio.Enabled = false;

                                }
                                questao.Erros = 0;
                            }
                        }

                        else if (Pergunta.JaRespondeu(questao.ID))
                        {
                            if (respostaDada != questao.Resposta)
                            {
                                questao.Erros++;
                                if (questao.Erros == 1)
                                {


                                    buttonAlternativa.StateCommon.Border.Color1 = Color.Red;
                                    buttonAlternativa.StateCommon.Border.Color2 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Border.Color1 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.StateCommon.Border.Width = 1;
                                    buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(250, 250, 250);
                                    buttonAlternativa.StateCommon.Back.Color2 = Color.FromArgb(250, 250, 250);

                                    buttonAlternativa.Enabled = false;


                                    MessageBox.Show("Resposta incorreta!", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }

                                else if (questao.Erros == 2)
                                {
                                    buttonAlternativa.StateCommon.Border.Color1 = Color.Red;
                                    buttonAlternativa.StateCommon.Border.Color2 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Border.Color1 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.StateCommon.Border.Width = 1;
                                    buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(250, 250, 250);
                                    buttonAlternativa.StateCommon.Back.Color2 = Color.FromArgb(250, 250, 250);

                                    buttonAlternativa.Enabled = false;


                                    MessageBox.Show("Resposta incorreta!", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                else if (questao.Erros >= 3)
                                {
                                    buttonAlternativa.StateCommon.Border.Color1 = Color.Red;
                                    buttonAlternativa.StateCommon.Border.Color2 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Border.Color1 = Color.Red;
                                    buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(240, 240, 240);
                                    buttonAlternativa.StateCommon.Border.Width = 1;
                                    buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(250, 250, 250);
                                    buttonAlternativa.StateCommon.Back.Color2 = Color.FromArgb(250, 250, 250);

                                    buttonAlternativa.Enabled = false;


                                    MessageBox.Show("Resposta incorreta!", "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    foreach (var bloqueio in botoesAlternativas)
                                    {
                                        bloqueio.Enabled = false;
                                    }
                                }

                            }

                            else
                            {
                                //tela pra aparecer que acertou a pergunta
                                buttonAlternativa.StateCommon.Border.Color1 = Color.LightGreen;
                                buttonAlternativa.StateCommon.Border.Color2 = Color.LightGreen;
                                buttonAlternativa.OverrideDefault.Border.Color1 = Color.LightGreen;
                                buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(235, 255, 235);
                                buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(235, 255, 235);
                                buttonAlternativa.StateCommon.Border.Width = 2;
                                buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(235, 255, 235);
                                buttonAlternativa.Enabled = false;

                                MessageBox.Show("Resposta Correta!", "Parabéns",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                foreach (var bloqueio in botoesAlternativas)
                                {

                                    bloqueio.Enabled = false;

                                }
                            }
                        }


                    }
                    else
                    {
                        buttonAlternativa.StateCommon.Back.Color1 = Color.White;
                        alternativaSelecionada = null;
                    }

                }
                    ;

                panelQuestao.Controls.Add(buttonAlternativa);
                y += 50;
            }


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