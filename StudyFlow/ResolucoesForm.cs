using Krypton.Toolkit;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace StudyFlow
{
    public partial class ResolucoesForm : BaseForm
    {
        public ResolucoesForm()
        {
            InitializeComponent();
            TelaResolucoes();
        }

        private void TelaResolucoes()
        {


            //busca as questoes do arquivo json e cria uma outra lista que vai ter as questoes filtradas
            string json = File.ReadAllText("questoes.json");
            List<Pergunta> questoes = JsonSerializer.Deserialize<List<Pergunta>>(json);
            List<Pergunta> questoesFiltradas = new List<Pergunta>();

            ////apenas para teste, marcar algumas questoes como respondidas
            //Usuario.QuestoesRespondidas["0001"] = true;
            //Usuario.QuestoesRespondidas["0002"] = true;
            //Usuario.QuestoesRespondidas["0004"] = true;
            //Usuario.QuestoesRespondidas["0005"] = true;
            //Usuario.QuestoesRespondidas["0008"] = true;
            //Usuario.QuestoesRespondidas["0013"] = true;
            //Usuario.QuestoesRespondidas["0015"] = true;
            //Usuario.QuestoesRespondidas["0019"] = true;
            //Usuario.QuestoesRespondidas["0023"] = true;
            //Usuario.QuestoesRespondidas["0024"] = true;
            //Usuario.QuestoesRespondidas["0025"] = true;

            PanelConteudo.Controls.Clear();

            //
            // Panel de Conteúdo
            //
            KryptonPanel panelResolucoes = new KryptonPanel();
            panelResolucoes.Dock = DockStyle.Fill;
            panelResolucoes.StateNormal.Color1 = Color.White;

            //
            // Titulo
            //
            KryptonLabel labelTitulo = new KryptonLabel();
            labelTitulo.Text = "Resoluções de Exercícios";
            labelTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitulo.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            labelTitulo.Location = new Point(70, 35);
            panelResolucoes.Controls.Add(labelTitulo);

            // Painel com scroll para a lista de questões
            Panel panelScroll = new Panel();
            panelScroll.Location = new Point(70, 80);
            panelScroll.Size = new Size(950, 500);
            panelScroll.AutoScroll = true;
            panelScroll.BorderStyle = BorderStyle.FixedSingle;
            panelResolucoes.Controls.Add(panelScroll);

            //
            // texto busca
            //
            KryptonTextBox textBusca = new KryptonTextBox();
            textBusca.Location = new Point(880, 40);
            textBusca.Size = new Size(120, 30);
            textBusca.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textBusca.StateCommon.Border.Rounding = 8;
            textBusca.StateCommon.Content.Font = new Font("Segoe UI", 10);
            panelResolucoes.Controls.Add(textBusca);
            //adicionei dps
            textBusca.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            textBusca.Size = new Size(120, 30);
            textBusca.StateCommon.Back.Color1 = Color.FromArgb(240, 240, 240);
            textBusca.StateCommon.Border.Width = 2;
            textBusca.StateCommon.Content.Color1 = Color.Black;
            textBusca.CueHint.CueHintText = "Pesquisar ID";
            textBusca.CueHint.Color1 = Color.FromArgb(110, 110, 110);

            //
            // botao busca
            //
            //KryptonButton buttonBusca = new KryptonButton();
            //buttonBusca.Text = "Buscar";
            //buttonBusca.Location = new Point(920, 40);
            //buttonBusca.Size = new Size(60, 30);
            //buttonBusca.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            //buttonBusca.StateCommon.Back.Color2 = Color.FromArgb(255, 102, 0);
            //buttonBusca.OverrideDefault.Back.Color1 = Color.FromArgb(255, 102, 0);
            //buttonBusca.OverrideDefault.Back.Color2 = Color.FromArgb(255, 102, 0);
            //buttonBusca.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            //buttonBusca.StateCommon.Border.Color2 = Color.FromArgb(255, 102, 0);
            //buttonBusca.StatePressed.Back.Color1 = Color.FromArgb(230, 92, 0);
            //buttonBusca.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            //buttonBusca.StateCommon.Content.ShortText.Color1 = Color.White;
            //buttonBusca.StateCommon.Border.Rounding = 8;
            //buttonBusca.Cursor = Cursors.Hand;
            //panelResolucoes.Controls.Add(buttonBusca);


            //filtra as questoes que o usuario ja respondeu
            foreach (var q in questoes)
            {
                if (Usuario.JaRespondeu(q.ID))
                {
                    questoesFiltradas.Add(q);
                }
            }


            Action atualizarLista = () =>
            {
                panelScroll.Controls.Clear();
                int y = 10;

                foreach (var q in questoesFiltradas)
                {
                    KryptonPanel card = new KryptonPanel();
                    card.Size = new Size(900, 60);
                    card.Location = new Point(20, y);
                    card.StateCommon.Color1 = Color.White;
                    card.Cursor = Cursors.Hand;

                    if (Usuario.AcertouOuErrou.ContainsKey(q.ID) == true)
                    {
                        KryptonLabel labelCertoouErrado = new KryptonLabel();
                        if (Usuario.AcertouOuErrou[q.ID] == true)
                        {
                            labelCertoouErrado.Text = "Acertou";
                            labelCertoouErrado.StateCommon.ShortText.Color1 = Color.LightGreen;
                            labelCertoouErrado.Location = new Point(710, 20);
                        }

                        if (Usuario.AcertouOuErrou[q.ID] == false)
                        {
                            labelCertoouErrado.Text = "Errou";
                            labelCertoouErrado.StateCommon.ShortText.Color1 = Color.Red;
                            labelCertoouErrado.Location = new Point(718, 20);
                        }
                        labelCertoouErrado.StateCommon.ShortText.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        card.Controls.Add(labelCertoouErrado);
                    }

                    card.MouseEnter += (s, e) => card.StateCommon.Color1 = Color.FromArgb(250, 250, 255);
                    card.MouseLeave += (s, e) => card.StateCommon.Color1 = Color.White;

                    card.Click += (s, e) => MostrarResolucao(q);

                    KryptonLabel labelId = new KryptonLabel();
                    labelId.Text = q.ID;
                    labelId.Location = new Point(10, 20);
                    labelId.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    labelId.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
                    card.Controls.Add(labelId);

                    KryptonLabel labelTema = new KryptonLabel();
                    labelTema.Text = q.Tema;
                    labelTema.Location = new Point(80, 20);
                    labelTema.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    labelTema.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
                    card.Controls.Add(labelTema);

                    panelScroll.Controls.Add(card);
                    y += 70;
                }
            };

            atualizarLista();


            textBusca.TextChanged += (s, e) =>
            {

                panelScroll.Controls.Clear();

                string textoBusca = textBusca.Text.Trim();

                List<Pergunta> questoesFiltradasDenovo;

                if (string.IsNullOrEmpty(textoBusca))
                {
                    questoesFiltradasDenovo = questoesFiltradas.ToList();
                }
                else
                {
                    // Filtra por ID exatamente igual
                    questoesFiltradasDenovo = questoesFiltradas.Where(q => q.ID.StartsWith(textoBusca)).ToList();
                }

                int y = 10;
                foreach (Pergunta q in questoesFiltradasDenovo)
                {

                    KryptonPanel card = new KryptonPanel();
                    card.Size = new Size(900, 60);
                    card.Location = new Point(20, y);
                    card.StateCommon.Color1 = Color.White;
                    card.Cursor = Cursors.Hand;

                    card.MouseEnter += (s, e) => card.StateCommon.Color1 = Color.FromArgb(250, 250, 255);
                    card.MouseLeave += (s, e) => card.StateCommon.Color1 = Color.White;

                    card.Click += (s, e) => MostrarResolucao(q);

                    KryptonLabel labelId = new KryptonLabel();
                    labelId.Text = q.ID;
                    labelId.Location = new Point(10, 20);
                    labelId.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    labelId.StateCommon.ShortText.Color1 = Color.FromArgb(255, 102, 0);
                    card.Controls.Add(labelId);

                    KryptonLabel labelTema = new KryptonLabel();
                    labelTema.Text = q.Tema;
                    labelTema.Location = new Point(80, 20);
                    labelTema.StateCommon.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    labelTema.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
                    card.Controls.Add(labelTema);

                    if (Usuario.AcertouOuErrou.ContainsKey(q.ID) == true)
                    {
                        KryptonLabel labelCertoouErrado = new KryptonLabel();
                        if (Usuario.AcertouOuErrou[q.ID] == true)
                        {
                            labelCertoouErrado.Text = "Acertou";
                            labelCertoouErrado.StateCommon.ShortText.Color1 = Color.LightGreen;
                            labelCertoouErrado.Location = new Point(710, 20);
                        }

                        if (Usuario.AcertouOuErrou[q.ID] == false)
                        {
                            labelCertoouErrado.Text = "Errou";
                            labelCertoouErrado.StateCommon.ShortText.Color1 = Color.Red;
                            labelCertoouErrado.Location = new Point(718, 20);
                        }
                        labelCertoouErrado.StateCommon.ShortText.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                        card.Controls.Add(labelCertoouErrado);
                    }

                    panelScroll.Controls.Add(card);
                    y += 70;
                }



            };

            //
            // Adicionar o panel ao PanelConteudo
            //
            PanelConteudo.Controls.Add(panelResolucoes);
        }

        private void ResetarAlternativa(KryptonButton btn, KryptonRichTextBox labelExp)
        {
            btn.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            btn.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            btn.StateCommon.Border.Width = 1;
            btn.StateCommon.Back.Color1 = Color.White;
            btn.StateCommon.Back.Color2 = Color.White;

            // Opcional: limpar override
            btn.StatePressed.Back.Color1 = Color.FromArgb(255, 102, 0);
            btn.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            btn.OverrideDefault.Border.Color1 = Color.Empty;
            btn.OverrideDefault.Back.Color1 = Color.Empty;
            btn.OverrideDefault.Back.Color2 = Color.Empty;
            btn.StateCommon.Content.Padding = new Padding(40, 5, 10, 5);
            btn.Size = new Size(795, 40);

            labelExp.Visible = false;
        }
        private void ResetarAlternativaExpUnica(KryptonButton btn)
        {
            btn.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            btn.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            btn.StateCommon.Border.Width = 1;
            btn.StateCommon.Back.Color1 = Color.White;
            btn.StateCommon.Back.Color2 = Color.White;

            // Opcional: limpar override
            btn.StatePressed.Back.Color1 = Color.FromArgb(255, 102, 0);
            btn.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            btn.OverrideDefault.Border.Color1 = Color.Empty;
            btn.OverrideDefault.Back.Color1 = Color.Empty;
            btn.OverrideDefault.Back.Color2 = Color.Empty;
            btn.StateCommon.Content.Padding = new Padding(40, 5, 10, 5);
            btn.Size = new Size(500, 40);
        }
        private void MostrarResolucao(Pergunta questao)
        {
            int baseY = 60;
            string explicacao = "";
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
            buttonVoltar.Click += (s, e) => TelaResolucoes(); // volta para a lista de questões
            panelQuestao.Controls.Add(buttonVoltar);

            KryptonLabel labelTitulo = new KryptonLabel();
            labelTitulo.Text = "Resolução da questão " + questao.ID; ;
            labelTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitulo.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            labelTitulo.Location = new Point(130, 20);
            labelTitulo.AutoSize = true;

            panelQuestao.Controls.Add(labelTitulo);
            //
            // ID questão
            //
            KryptonButton labelID = new KryptonButton();
            labelID.Text = questao.ID.ToString();
            labelID.Enabled = false;
            labelID.Location = new Point(140, 20);
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
            labelTipo.Location = new Point(905, 22);
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
            labelArea.Location = new Point(605, 22);
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
            textEnunciado.Size = new Size(800, 230);
            textEnunciado.Location = new Point(125, baseY + 20);
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

            // Painel de fluxo para as alternativas, estrutura muito legal pra reorganizar os botoes quando apertados
            FlowLayoutPanel flowAlternativas = new FlowLayoutPanel();
            flowAlternativas.Location = new Point(125, 330); // ajuste como quiser
            flowAlternativas.Size = new Size(900, 300);
            flowAlternativas.FlowDirection = FlowDirection.TopDown;
            flowAlternativas.WrapContents = false;
            flowAlternativas.AutoScroll = true;
            flowAlternativas.BackColor = Color.White;

            panelQuestao.Controls.Add(flowAlternativas);

            //variavel para guardar a label da explicação anterior
            KryptonRichTextBox labelExpAnterior = null;
            for (int i = 0; i < alternativas.Length; i++)
            {
                KryptonButton buttonAlternativa = new KryptonButton();
                if (questao.expUnica == null)
                {
                    // Cria os botão da alternativa
                    buttonAlternativa.Size = new Size(795, 40);
                    buttonAlternativa.Location = new Point(40, y);
                    buttonAlternativa.StateCommon.Back.Color1 = Color.White;
                    buttonAlternativa.StateCommon.Back.Color2 = Color.White;
                    buttonAlternativa.OverrideDefault.Back.Color1 = Color.White;
                    buttonAlternativa.OverrideDefault.Back.Color2 = Color.White;
                    buttonAlternativa.StatePressed.Back.Color1 = Color.FromArgb(255, 102, 0);
                    buttonAlternativa.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
                    buttonAlternativa.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                    buttonAlternativa.StateCommon.Border.Rounding = 6;
                    buttonAlternativa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 11);
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
                    flowAlternativas.Controls.Add(buttonAlternativa);

                    KryptonRichTextBox labelExp = new KryptonRichTextBox();
                    labelExp.Size = new Size(770, 60);
                    labelExp.Location = new Point(10, 27);
                    labelExp.StateCommon.Border.Rounding = 6;
                    labelExp.StateCommon.Content.Font = new Font("Segoe UI", 9);
                    labelExp.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
                    labelExp.StateCommon.Back.Color1 = Color.FromArgb(240, 240, 240);
                }


                //pra aparecer quando a questao nao tiver mais de uma explicação
                if (questao.expUnica != null)
                {
                

                    KryptonLabel labelLetra = new KryptonLabel();
                    labelLetra.Text = ((char)('A' + i)).ToString();
                    labelLetra.StateCommon.ShortText.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    labelLetra.StateCommon.ShortText.Color1 = Color.Orange;
                    labelLetra.Location = new Point(10, 5);

                    textEnunciado.Size = new Size(500, 300);
                    textEnunciado.Location = new Point(30, baseY + 20);
                    textEnunciado.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
                    textEnunciado.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                    textEnunciado.StateCommon.Border.Rounding = 6;
                    textEnunciado.StateCommon.Content.Font = new Font("Segoe UI", 12);

                    textEnunciado.Text = questao.Enunciado;
                    textEnunciado.ReadOnly = true;
                    panelQuestao.Controls.Add(textEnunciado);

                    buttonAlternativa.Size = new Size(500, 40);
                    buttonAlternativa.StateCommon.Back.Color1 = Color.White;
                    buttonAlternativa.StateCommon.Back.Color2 = Color.White;
                    buttonAlternativa.OverrideDefault.Back.Color1 = Color.White;
                    buttonAlternativa.OverrideDefault.Back.Color2 = Color.White;
                    buttonAlternativa.StatePressed.Back.Color1 = Color.FromArgb(255, 102, 0);
                    buttonAlternativa.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
                    buttonAlternativa.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                    buttonAlternativa.StateCommon.Border.Rounding = 6;
                    buttonAlternativa.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 11);
                    buttonAlternativa.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
                    buttonAlternativa.StateCommon.Content.Padding = new Padding(40, 5, 10, 5);
                    buttonAlternativa.Cursor = Cursors.Hand;

                    flowAlternativas.Location = new Point(27, 390); // ajuste como quiser
                    flowAlternativas.Size = new Size(510, 300);

                    buttonAlternativa.Controls.Add(labelLetra);
                    buttonAlternativa.Text = alternativas[i];
                    flowAlternativas.Controls.Add(buttonAlternativa);
                }

                y += 50;
                buttonAlternativa.Click += (s, e) =>
                {
                    if (questao.expUnica == null)
                    {
                        if (labelExpAnterior != null)
                            labelExpAnterior.Visible = false;

                        KryptonRichTextBox labelExp = new KryptonRichTextBox();
                        labelExp.Size = new Size(770, 60);
                        labelExp.Location = new Point(10, 27);
                        labelExp.StateCommon.Border.Rounding = 6;
                        labelExp.StateCommon.Content.Font = new Font("Segoe UI", 9);
                        labelExp.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;
                        labelExp.StateCommon.Back.Color1 = Color.FromArgb(240, 240, 240);
                        labelExp.ReadOnly = true;
                        labelExp.Visible = false; // começa escondido



                        if (alternativaSelecionada != null)
                        {
                            // Reseta a alternativa que foi marcada antes
                            ResetarAlternativa(alternativaSelecionada, labelExp);


                        }

                        //Marca a alternativa selecionada
                        alternativaSelecionada = buttonAlternativa;
                        respostaDada = alternativaSelecionada.Text;

                        //dou valor pra explicação, que eu vou mostrar dps na richtextbox labelEXP
                        if (respostaDada == questao.A) explicacao = questao.expA;
                        else if (respostaDada == questao.B) explicacao = questao.expB;
                        else if (respostaDada == questao.C) explicacao = questao.expC;
                        else if (respostaDada == questao.D) explicacao = questao.expD;
                        else explicacao = questao.expE;
                        if (respostaDada != questao.Resposta)
                        {
                            buttonAlternativa.StateCommon.Border.Color1 = Color.Red;
                            buttonAlternativa.StateCommon.Border.Color2 = Color.Red;
                            buttonAlternativa.OverrideDefault.Border.Color1 = Color.Red;
                            buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(240, 240, 240);
                            buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(240, 240, 240);
                            buttonAlternativa.StateCommon.Border.Width = 3;
                            buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(250, 250, 250);
                            buttonAlternativa.StateCommon.Back.Color2 = Color.FromArgb(250, 250, 250);
                            buttonAlternativa.StateCommon.Content.Padding = new Padding(40, -54, 0, 0);

                            buttonAlternativa.Size = new Size(795, 90); // aumenta botão

                            // mostrar explicação
                            labelExp.Text = explicacao;
                            labelExp.Visible = false;
                            buttonAlternativa.Controls.Add(labelExp);

                            buttonAlternativa.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9);
                            buttonAlternativa.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Near;
                            buttonAlternativa.StateCommon.Content.LongText.TextV = PaletteRelativeAlign.Near;
                        }
                        else
                        {
                            buttonAlternativa.StateCommon.Border.Color1 = Color.LightGreen;
                            buttonAlternativa.StateCommon.Border.Color2 = Color.LightGreen;
                            buttonAlternativa.OverrideDefault.Border.Color1 = Color.LightGreen;
                            buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(235, 255, 235);
                            buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(235, 255, 235);
                            buttonAlternativa.StateCommon.Border.Width = 3;
                            buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(235, 255, 235);
                            buttonAlternativa.StateCommon.Content.Padding = new Padding(40, -54, 0, 0);

                            buttonAlternativa.Size = new Size(795, 90); // aumenta botão

                            // mostrar explicação
                            labelExp.Text = explicacao;
                            labelExp.Visible = true;
                            buttonAlternativa.Controls.Add(labelExp);
                            labelExp.StateCommon.Back.Color1 = Color.FromArgb(235, 255, 235);

                            buttonAlternativa.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9);
                            buttonAlternativa.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Near;

                        }
                        labelExp.Visible = true;
                        labelExpAnterior = labelExp;
                    }
                    else
                    {   //1115 1085 585 530 500 30 
                        // tamanho da tela 1115 30 500 55 500 30

                        if (alternativaSelecionada != null)
                        {
                            // Reseta a alternativa que foi marcada antes
                            ResetarAlternativaExpUnica(alternativaSelecionada);

                        }

                        alternativaSelecionada = buttonAlternativa;
                        respostaDada = alternativaSelecionada.Text;

                        if (respostaDada != questao.Resposta)
                        {
                            buttonAlternativa.StateCommon.Border.Color1 = Color.Red;
                            buttonAlternativa.StateCommon.Border.Color2 = Color.Red;
                            buttonAlternativa.OverrideDefault.Border.Color1 = Color.Red;
                            buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(240, 240, 240);
                            buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(240, 240, 240);
                            buttonAlternativa.StateCommon.Border.Width = 3;
                            buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(250, 250, 250);
                            buttonAlternativa.StateCommon.Back.Color2 = Color.FromArgb(250, 250, 250);
                        }
                        else
                        {
                            buttonAlternativa.StateCommon.Border.Color1 = Color.LightGreen;
                            buttonAlternativa.StateCommon.Border.Color2 = Color.LightGreen;
                            buttonAlternativa.OverrideDefault.Border.Color1 = Color.LightGreen;
                            buttonAlternativa.OverrideDefault.Back.Color1 = Color.FromArgb(235, 255, 235);
                            buttonAlternativa.OverrideDefault.Back.Color2 = Color.FromArgb(235, 255, 235);
                            buttonAlternativa.StateCommon.Border.Width = 3;
                            buttonAlternativa.StateCommon.Back.Color1 = Color.FromArgb(235, 255, 235);
                        }

                        KryptonRichTextBox textExplicacao = new KryptonRichTextBox();
                        textExplicacao.Size = new Size(500, 538);
                        textExplicacao.Location = new Point(585, baseY + 20);
                        textExplicacao.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
                        textExplicacao.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                        textExplicacao.StateCommon.Border.Rounding = 6;
                        textExplicacao.StateCommon.Content.Font = new Font("Segoe UI", 12);
                        textExplicacao.Visible = true;

                        textExplicacao.Text = questao.expUnica;
                        textExplicacao.ReadOnly = true;
                        panelQuestao.Controls.Add(textExplicacao);

                    }
                };
                TrocarConteudo(panelQuestao);

            }
        }
    }
}