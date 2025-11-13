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

            textAjuda.Text = "PRIMEIROS PASSOS E ACESSO\r\n" +
                "É necessário realizar um cadastro inicial, e após efetuar o acesso com login e senha, é importante que o email fornecido seja um email válido, para recuperação de senha caso necessário.\r\n" +
                " \r\nTela Inicial\r\n" +
                "Ao efetuar login, você será direcionado pala a tela Home, o “hub” de informações, ali você encontrará um Feed de Notícias e Atualidades de Vestibulares para complementar seu conhecimento, estudos e preparação. \r\n" +
                "Além disso, poderá visualizar o guia de opções localizado na lateral esquerda.\r\n" +
                "  \r\nGuia de Opções\r\n" +
                "O menu se encontra na lateral esquerda e é o principal sistema de navegação para todas as ferramentas disponíveis no sistema, você encontrará as opções na seguinte ordem: Home, Perfil, Questões, Resolução, Ajuda.\r\n" +
                "Home: Tela Inicial, apresentada anteriormente\r\n" +
                "Perfil: Onde estarão todas as suas informações cadastrais, disponíveis para serem editadas caso seja necessário\r\n" +
                "Questões: Local onde todas as questões são disponibilizadas\r\nResolução: Local onde todas as resoluções de questões que o usuário já tenha resolvido\r\n" +
                " \r\n \r\nMÓDULO DE ESTUDO\r\n" +
                "Como acessar e responder as questões?\r\n" +
                "1. Clique na aba “Questões” no menu lateral\r\n" +
                "2. A tela apresentará os quadros de cada área (Linguagens e suas Tecnologias, Matemática e suas Tecnologias, Ciências Humanas, Ciências da Natureza, Enem e Provão Paulista)\r\n" +
                "3. Clique no quadro desejado para ver a lista de questões daquela área\r\n" +
                "4. Ao clicar em uma questão da lista, ela será aberta, o usuário deve selecionar a alternativa que julgar correta, clicando sobre o corpo da alternativa\r\n\r\n" +
                "Atribuição de Pontos\r\n" +
                "Cada questão possui uma pontuação de acordo com o nível de dificuldade, ao errar uma vez essa pontuação é multiplicada por 0.66, ao errar uma segunda vez a pontuação é multiplicada por 0.33. Além disso, a pessoa tem três tentativas de responder a questão, após a questão é “bloqueada”\r\n" +
                " \r\nComo visualizar as resoluções comentadas?\r\n" +
                "\r\n\r\n\r\nACOMPANHAMENTO DE DESEMPENHO\r\n" +
                "Visualizando o Ranking\r\n" +
                "Clique na aba “Ranking”, aqui você visualiza a sua posição atual em relação a todos os usuários da plataforma, baseada no seu desempenho e quantidade de questões respondidas. O Ranking mostra a posição, seguido do nome e da pontuação geral de cada usuário.\r\n" +
                "\r\n\r\n\r\nGERENCIAMENTO E SUPORTE\r\n" +
                "Meu Perfil\r\n" +
                "Clique na aba “Perfil” para atualizar ou editar suas informações de cadastro (nome, e-mail, etc.).\r\n" +
                "\r\nRecuperação de senha\r\n" +
                "\r\nSuporte e Contato\r\n" +
                "Caso encontre algum erro, tenha sugestões ou precise de suporte, entre em contato conosco pelo e-mail: nunesdopradosarah@gmail.com\r\n";

            textAjuda.ReadOnly = true;
            panelAjuda.Controls.Add(textAjuda);

            PanelConteudo.Controls.Add(panelAjuda);
        }

    }
}
