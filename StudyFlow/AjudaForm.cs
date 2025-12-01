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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudyFlow
{
    public partial class AjudaForm : BaseForm

    {
        public AjudaForm()
        {
            InitializeComponent();
            TelaAjuda();

        }

        private void TelaAjuda()
        {
            PanelConteudo.Controls.Clear();

            KryptonPanel panelAjuda = new KryptonPanel();
            panelAjuda.Dock = DockStyle.Fill;
            panelAjuda.StateNormal.Color1 = Color.White;

            KryptonLabel labelTitulo = new KryptonLabel();
            labelTitulo.Text = "Ajuda - Guia Prático de Navegação";
            labelTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            labelTitulo.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            labelTitulo.Location = new Point(90, 40);
            panelAjuda.Controls.Add(labelTitulo);

            KryptonRichTextBox textAjuda = new KryptonRichTextBox();
            textAjuda.Size = new Size(950, 500);
            textAjuda.Location = new Point(90, 90);
            textAjuda.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            textAjuda.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            textAjuda.StateCommon.Border.Rounding = 8;
            textAjuda.StateCommon.Content.Font = new Font("Segoe UI", 13);

            textAjuda.Text = "O Study Flow é um projeto criado para aproximar o estudante da preparação real para \r\n" +
"os vestibulares, oferecendo uma experiência de estudo organizada, acessível e motivadora. \r\n" +
"Ele nasceu da observação das dificuldades enfrentadas por muitos jovens, principalmente \r\n" +
"da rede pública, que frequentemente não possuem acesso a materiais claros, ferramentas \r\n" +
"de acompanhamento ou um ambiente que estimule o progresso constante.\r\n" +
"\r\n" +
"Durante nossas pesquisas, conversamos com estudantes e professores para entender quais \r\n" +
"eram os maiores desafios presentes no dia a dia escolar. Percebemos que muitos alunos \r\n" +
"têm dificuldade em encontrar conteúdos confiáveis, manter uma rotina de estudos e medir \r\n" +
"seu próprio desempenho. Isso reforçou a necessidade de uma plataforma que reunisse tudo \r\n" +
"isso de forma simples e eficiente.\r\n" +
"\r\n" +
"Com essa visão, buscamos proximidade com a realidade dos estudantes da ETEC de Cachoeira \r\n" +
"Paulista, onde acompanhamos de perto a rotina dos alunos do 3º ano. Essa experiência foi \r\n" +
"fundamental para entendermos o que realmente faz diferença no processo de aprendizagem e \r\n" +
"como uma ferramenta prática poderia ajudar no preparo para provas importantes.\r\n" +
"\r\n" +
"A partir dessa vivência, estruturamos um protótipo que reúne questões de vestibulares \r\n" +
"anteriores, explicações comentadas e um sistema de pontuação e ranking. O objetivo é \r\n" +
"transformar o estudo em algo mais engajado, dinâmico e prazeroso, permitindo que cada \r\n" +
"aluno acompanhe sua evolução e identifique os pontos em que precisa melhorar.\r\n" +
"\r\n" +
"O Study Flow nasceu como uma forma de unir educação e acesso, oferecendo aos estudantes \r\n" +
"uma ferramenta que contribui para seus sonhos e metas. Nosso propósito é tornar o estudo \r\n" +
"mais leve, organizado e motivador, ajudando cada usuário a se sentir preparado e confiante \r\n" +
"em sua jornada rumo aos vestibulares.\r\n";

            textAjuda.ReadOnly = true;
            panelAjuda.Controls.Add(textAjuda);

            PanelConteudo.Controls.Add(panelAjuda);
        }

    }
}
