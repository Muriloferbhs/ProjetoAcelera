using Krypton.Toolkit;

namespace StudyFlow
{
    partial class QuestoesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCards = new KryptonPanel();
            buttonProvaoP = new KryptonButton();
            buttonLinguagens = new KryptonButton();
            buttonCienciasH = new KryptonButton();
            buttonEnem = new KryptonButton();
            buttonCienciasN = new KryptonButton();
            buttonMatematica = new KryptonButton();
            panelBusca = new KryptonPanel();
            btnCard = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)PanelConteudo).BeginInit();
            PanelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCards).BeginInit();
            panelCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelBusca).BeginInit();
            SuspendLayout();
            // 
            // PanelConteudo
            // 
            PanelConteudo.Controls.Add(panelCards);
            PanelConteudo.Controls.Add(panelBusca);
            PanelConteudo.Size = new Size(1121, 616);
            PanelConteudo.StateNormal.Color1 = Color.White;
            // 
            // panelCards
            // 
            panelCards.Controls.Add(buttonProvaoP);
            panelCards.Controls.Add(buttonLinguagens);
            panelCards.Controls.Add(buttonCienciasH);
            panelCards.Controls.Add(buttonEnem);
            panelCards.Controls.Add(buttonCienciasN);
            panelCards.Controls.Add(buttonMatematica);
            panelCards.Dock = DockStyle.Left;
            panelCards.Location = new Point(0, 0);
            panelCards.Name = "panelCards";
            panelCards.Size = new Size(800, 616);
            panelCards.StateCommon.Color1 = Color.White;
            panelCards.StateDisabled.Color1 = Color.Transparent;
            panelCards.StateDisabled.Color2 = Color.Transparent;
            panelCards.StateNormal.Color1 = Color.Transparent;
            panelCards.StateNormal.Color2 = Color.Transparent;
            panelCards.TabIndex = 0;
            // 
            // buttonProvaoP
            // 
            buttonProvaoP.Cursor = Cursors.Hand;
            buttonProvaoP.Location = new Point(415, 390);
            buttonProvaoP.Name = "buttonProvaoP";
            buttonProvaoP.OverrideDefault.Back.Color1 = Color.White;
            buttonProvaoP.OverrideDefault.Back.Color2 = Color.White;
            buttonProvaoP.OverrideDefault.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonProvaoP.OverrideDefault.Border.Color2 = Color.FromArgb(255, 102, 0);
            buttonProvaoP.Size = new Size(350, 120);
            buttonProvaoP.StateCommon.Back.Color1 = Color.White;
            buttonProvaoP.StateCommon.Back.Color2 = Color.White;
            buttonProvaoP.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonProvaoP.StateCommon.Border.Rounding = 10F;
            buttonProvaoP.StateCommon.Border.Width = 1;
            buttonProvaoP.StateCommon.Content.LongText.Color1 = Color.FromArgb(255, 102, 0);
            buttonProvaoP.StateCommon.Content.LongText.Font = new Font("Segoe UI", 10F);
            buttonProvaoP.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Center;
            buttonProvaoP.StateCommon.Content.LongText.TextV = PaletteRelativeAlign.Far;
            buttonProvaoP.StateCommon.Content.Padding = new Padding(-1, -1, -1, 15);
            buttonProvaoP.StateCommon.Content.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            buttonProvaoP.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonProvaoP.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            buttonProvaoP.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            buttonProvaoP.StateNormal.Back.Color1 = Color.White;
            buttonProvaoP.StateNormal.Back.Color2 = Color.White;
            buttonProvaoP.StatePressed.Back.Color1 = SystemColors.ButtonFace;
            buttonProvaoP.StatePressed.Back.Color2 = Color.White;
            buttonProvaoP.StateTracking.Back.Color1 = Color.White;
            buttonProvaoP.StateTracking.Back.Color2 = Color.White;
            buttonProvaoP.TabIndex = 5;
            buttonProvaoP.Values.DropDownArrowColor = Color.Empty;
            buttonProvaoP.Values.ExtraText = "Questões de edições anteriores do Provão Paulista, \r\nenvolvendo as matérias da matriz do Ensino Médio";
            buttonProvaoP.Values.Text = "PROVÃO PAULISTA";
            // 
            // buttonLinguagens
            // 
            buttonLinguagens.Cursor = Cursors.Hand;
            buttonLinguagens.Location = new Point(415, 70);
            buttonLinguagens.Name = "buttonLinguagens";
            buttonLinguagens.OverrideDefault.Back.Color1 = Color.White;
            buttonLinguagens.OverrideDefault.Back.Color2 = Color.White;
            buttonLinguagens.OverrideDefault.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonLinguagens.OverrideDefault.Border.Color2 = Color.FromArgb(255, 102, 0);
            buttonLinguagens.Size = new Size(350, 120);
            buttonLinguagens.StateCommon.Back.Color1 = Color.White;
            buttonLinguagens.StateCommon.Back.Color2 = Color.White;
            buttonLinguagens.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonLinguagens.StateCommon.Border.Rounding = 10F;
            buttonLinguagens.StateCommon.Border.Width = 1;
            buttonLinguagens.StateCommon.Content.LongText.Color1 = Color.FromArgb(255, 102, 0);
            buttonLinguagens.StateCommon.Content.LongText.Font = new Font("Segoe UI", 10F);
            buttonLinguagens.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Center;
            buttonLinguagens.StateCommon.Content.LongText.TextV = PaletteRelativeAlign.Far;
            buttonLinguagens.StateCommon.Content.Padding = new Padding(-1, -1, -1, 15);
            buttonLinguagens.StateCommon.Content.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            buttonLinguagens.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonLinguagens.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            buttonLinguagens.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            buttonLinguagens.StatePressed.Back.Color1 = SystemColors.ButtonFace;
            buttonLinguagens.TabIndex = 4;
            buttonLinguagens.Values.DropDownArrowColor = Color.Empty;
            buttonLinguagens.Values.ExtraText = "Questões envolvendo os conhecimentos\r\nde língua portuguesa, interpretação de texto,\r\n literatura, artes, inglês, espanhol e atualidades";
            buttonLinguagens.Values.Text = "LINGUAGENS E SUAS TECNOLOGIAS";
            buttonLinguagens.Click += buttonLinguagens_Click;
            // 
            // buttonCienciasH
            // 
            buttonCienciasH.Cursor = Cursors.Hand;
            buttonCienciasH.Location = new Point(37, 234);
            buttonCienciasH.Name = "buttonCienciasH";
            buttonCienciasH.OverrideDefault.Back.Color1 = Color.White;
            buttonCienciasH.OverrideDefault.Back.Color2 = Color.White;
            buttonCienciasH.OverrideDefault.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonCienciasH.OverrideDefault.Border.Color2 = Color.FromArgb(255, 102, 0);
            buttonCienciasH.Size = new Size(350, 120);
            buttonCienciasH.StateCommon.Back.Color1 = Color.White;
            buttonCienciasH.StateCommon.Back.Color2 = Color.White;
            buttonCienciasH.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonCienciasH.StateCommon.Border.Rounding = 10F;
            buttonCienciasH.StateCommon.Border.Width = 1;
            buttonCienciasH.StateCommon.Content.LongText.Color1 = Color.FromArgb(255, 102, 0);
            buttonCienciasH.StateCommon.Content.LongText.Font = new Font("Segoe UI", 10F);
            buttonCienciasH.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Center;
            buttonCienciasH.StateCommon.Content.LongText.TextV = PaletteRelativeAlign.Far;
            buttonCienciasH.StateCommon.Content.Padding = new Padding(-1, -1, -1, 15);
            buttonCienciasH.StateCommon.Content.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            buttonCienciasH.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonCienciasH.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            buttonCienciasH.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            buttonCienciasH.StateNormal.Back.Color1 = Color.White;
            buttonCienciasH.StateNormal.Back.Color2 = Color.White;
            buttonCienciasH.StatePressed.Back.Color1 = SystemColors.ButtonFace;
            buttonCienciasH.StatePressed.Back.Color2 = Color.White;
            buttonCienciasH.StateTracking.Back.Color1 = Color.White;
            buttonCienciasH.StateTracking.Back.Color2 = Color.White;
            buttonCienciasH.TabIndex = 3;
            buttonCienciasH.Values.DropDownArrowColor = Color.Empty;
            buttonCienciasH.Values.ExtraText = "Questões envolvendo os conhecimentos sobre história,\r\n geografia, filosofia, sociologia, economia e política";
            buttonCienciasH.Values.Text = "CIÊNCIAS HUMANAS";
            // 
            // buttonEnem
            // 
            buttonEnem.Cursor = Cursors.Hand;
            buttonEnem.Location = new Point(37, 390);
            buttonEnem.Name = "buttonEnem";
            buttonEnem.OverrideDefault.Back.Color1 = Color.White;
            buttonEnem.OverrideDefault.Back.Color2 = Color.White;
            buttonEnem.OverrideDefault.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonEnem.OverrideDefault.Border.Color2 = Color.FromArgb(255, 102, 0);
            buttonEnem.Size = new Size(350, 120);
            buttonEnem.StateCommon.Back.Color1 = Color.White;
            buttonEnem.StateCommon.Back.Color2 = Color.White;
            buttonEnem.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonEnem.StateCommon.Border.Rounding = 10F;
            buttonEnem.StateCommon.Border.Width = 1;
            buttonEnem.StateCommon.Content.LongText.Color1 = Color.FromArgb(255, 102, 0);
            buttonEnem.StateCommon.Content.LongText.Font = new Font("Segoe UI", 10F);
            buttonEnem.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Center;
            buttonEnem.StateCommon.Content.LongText.TextV = PaletteRelativeAlign.Far;
            buttonEnem.StateCommon.Content.Padding = new Padding(-1, -1, -1, 15);
            buttonEnem.StateCommon.Content.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            buttonEnem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonEnem.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            buttonEnem.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            buttonEnem.StateNormal.Back.Color1 = Color.White;
            buttonEnem.StateNormal.Back.Color2 = Color.White;
            buttonEnem.StatePressed.Back.Color1 = SystemColors.ButtonFace;
            buttonEnem.StatePressed.Back.Color2 = Color.White;
            buttonEnem.StateTracking.Back.Color1 = Color.White;
            buttonEnem.StateTracking.Back.Color2 = Color.White;
            buttonEnem.TabIndex = 2;
            buttonEnem.Values.DropDownArrowColor = Color.Empty;
            buttonEnem.Values.ExtraText = "Questões dos vestibulares de Enem \r\nde edições passadas, envolvendo todas\r\n as áreas do conhecimento";
            buttonEnem.Values.Text = "ENEM";
            // 
            // buttonCienciasN
            // 
            buttonCienciasN.Cursor = Cursors.Hand;
            buttonCienciasN.Location = new Point(415, 234);
            buttonCienciasN.Name = "buttonCienciasN";
            buttonCienciasN.OverrideDefault.Back.Color1 = Color.White;
            buttonCienciasN.OverrideDefault.Back.Color2 = Color.White;
            buttonCienciasN.OverrideDefault.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonCienciasN.OverrideDefault.Border.Color2 = Color.FromArgb(255, 102, 0);
            buttonCienciasN.Size = new Size(350, 120);
            buttonCienciasN.StateCommon.Back.Color1 = Color.White;
            buttonCienciasN.StateCommon.Back.Color2 = Color.White;
            buttonCienciasN.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonCienciasN.StateCommon.Border.Rounding = 10F;
            buttonCienciasN.StateCommon.Border.Width = 1;
            buttonCienciasN.StateCommon.Content.LongText.Color1 = Color.FromArgb(255, 102, 0);
            buttonCienciasN.StateCommon.Content.LongText.Font = new Font("Segoe UI", 10F);
            buttonCienciasN.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Center;
            buttonCienciasN.StateCommon.Content.LongText.TextV = PaletteRelativeAlign.Far;
            buttonCienciasN.StateCommon.Content.Padding = new Padding(-1, -1, -1, 15);
            buttonCienciasN.StateCommon.Content.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            buttonCienciasN.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonCienciasN.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            buttonCienciasN.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            buttonCienciasN.StateNormal.Back.Color1 = Color.White;
            buttonCienciasN.StateNormal.Back.Color2 = Color.White;
            buttonCienciasN.StatePressed.Back.Color1 = SystemColors.ButtonFace;
            buttonCienciasN.StatePressed.Back.Color2 = Color.White;
            buttonCienciasN.StateTracking.Back.Color1 = Color.White;
            buttonCienciasN.StateTracking.Back.Color2 = Color.White;
            buttonCienciasN.TabIndex = 1;
            buttonCienciasN.Values.DropDownArrowColor = Color.Empty;
            buttonCienciasN.Values.ExtraText = "Questões envolvendo os conhecimentos \r\nsobre química, física e  biologia";
            buttonCienciasN.Values.Text = "CIÊNCIAS DA NATUREZA";
            // 
            // buttonMatematica
            // 
            buttonMatematica.Cursor = Cursors.Hand;
            buttonMatematica.Location = new Point(37, 70);
            buttonMatematica.Name = "buttonMatematica";
            buttonMatematica.OverrideDefault.Back.Color1 = Color.White;
            buttonMatematica.OverrideDefault.Back.Color2 = Color.White;
            buttonMatematica.OverrideDefault.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonMatematica.OverrideDefault.Border.Color2 = Color.FromArgb(255, 102, 0);
            buttonMatematica.Size = new Size(350, 120);
            buttonMatematica.StateCommon.Back.Color1 = Color.White;
            buttonMatematica.StateCommon.Back.Color2 = Color.White;
            buttonMatematica.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            buttonMatematica.StateCommon.Border.Rounding = 10F;
            buttonMatematica.StateCommon.Border.Width = 1;
            buttonMatematica.StateCommon.Content.LongText.Color1 = Color.FromArgb(255, 102, 0);
            buttonMatematica.StateCommon.Content.LongText.Font = new Font("Segoe UI", 10F);
            buttonMatematica.StateCommon.Content.LongText.TextH = PaletteRelativeAlign.Center;
            buttonMatematica.StateCommon.Content.LongText.TextV = PaletteRelativeAlign.Far;
            buttonMatematica.StateCommon.Content.Padding = new Padding(-1, -1, -1, 15);
            buttonMatematica.StateCommon.Content.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            buttonMatematica.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonMatematica.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            buttonMatematica.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            buttonMatematica.StateNormal.Back.Color1 = Color.White;
            buttonMatematica.StateNormal.Back.Color2 = Color.White;
            buttonMatematica.StatePressed.Back.Color1 = SystemColors.ButtonFace;
            buttonMatematica.StatePressed.Back.Color2 = Color.White;
            buttonMatematica.StateTracking.Back.Color1 = Color.White;
            buttonMatematica.StateTracking.Back.Color2 = Color.White;
            buttonMatematica.TabIndex = 0;
            buttonMatematica.Values.DropDownArrowColor = Color.Empty;
            buttonMatematica.Values.ExtraText = "Questões envolvendo os conhecimentos \nem matemática e raciocínio lógico";
            buttonMatematica.Values.Text = "MATEMÁTICA E SUAS TECNOLOGIAS";
            buttonMatematica.Click += buttonMatematica_Click_2;
            // 
            // panelBusca
            // 
            panelBusca.Dock = DockStyle.Fill;
            panelBusca.Location = new Point(0, 0);
            panelBusca.Name = "panelBusca";
            panelBusca.Size = new Size(1121, 616);
            panelBusca.StateCommon.Color1 = Color.White;
            panelBusca.TabIndex = 1;
            // 
            // btnCard
            // 
            btnCard.Location = new Point(0, 0);
            btnCard.Name = "btnCard";
            btnCard.Size = new Size(90, 25);
            btnCard.TabIndex = 0;
            // 
            // QuestoesForm
            // 
            ClientSize = new Size(1280, 720);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "QuestoesForm";
            Text = "QuestoesForm";
            ((System.ComponentModel.ISupportInitialize)PanelConteudo).EndInit();
            PanelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCards).EndInit();
            panelCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelBusca).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelCards;
        private Krypton.Toolkit.KryptonPanel panelBusca;
        private KryptonButton btnCard;
        private KryptonButton buttonMatematica;
        private KryptonButton buttonProvaoP;
        private KryptonButton buttonLinguagens;
        private KryptonButton buttonCienciasH;
        private KryptonButton buttonEnem;
        private KryptonButton buttonCienciasN;
    }
}