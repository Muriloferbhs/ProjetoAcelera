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
            textBusca.Location = new Point(700, 40);
            textBusca.Size = new Size(200, 30);
            textBusca.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            textBusca.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textBusca.StateCommon.Border.Rounding = 8;
            textBusca.StateCommon.Content.Font = new Font("Segoe UI", 10);
            panelResolucoes.Controls.Add(textBusca);

            //
            // botao busca
            //
            KryptonButton buttonBusca = new KryptonButton();
            buttonBusca.Text = "Buscar";
            buttonBusca.Location = new Point(920, 40);
            buttonBusca.Size = new Size(60, 30);
            buttonBusca.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            buttonBusca.StateCommon.Back.Color2 = Color.FromArgb(255, 102, 0);
            buttonBusca.OverrideDefault.Back.Color1 = Color.FromArgb(255, 102, 0);
            buttonBusca.OverrideDefault.Back.Color2 = Color.FromArgb(255, 102, 0);
            buttonBusca.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonBusca.StateCommon.Border.Color2 = Color.FromArgb(255, 102, 0);
            buttonBusca.StatePressed.Back.Color1 = Color.FromArgb(230, 92, 0);
            buttonBusca.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            buttonBusca.StateCommon.Content.ShortText.Color1 = Color.White;
            buttonBusca.StateCommon.Border.Rounding = 8;
            buttonBusca.Cursor = Cursors.Hand;
            panelResolucoes.Controls.Add(buttonBusca);



            string json = File.ReadAllText("questoes.json");
            List<Pergunta> questoes = JsonSerializer.Deserialize<List<Pergunta>>(json);
            List<Pergunta> questoesFiltradas = JsonSerializer.Deserialize<List<Pergunta>>(json);

            Action atualizarLista = () =>
            {
                panelScroll.Controls.Clear();
                int y = 10;

                foreach (var q in questoesFiltradas)
                {
                    KryptonPanel card = new KryptonPanel();
                    card.Size = new Size (900, 60);
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

                    panelScroll.Controls.Add(card);
                    y += 70;
                }
            };

            atualizarLista();

            buttonBusca.Click += (s, e) =>
            {
                //logica de busca
            };

            //
            // Adicionar o panel ao PanelConteudo
            //
            PanelConteudo.Controls.Add(panelResolucoes);
        }

        private void MostrarResolucao(Pergunta pergunta)
        {
            
        }
    }
}
