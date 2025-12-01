using Krypton.Toolkit;
using System;
using System.Drawing.Design;

namespace StudyFlow
{
    partial class BaseForm
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

        public void AtualizarFotoTopo(Image novaFoto)
        {
            pictureUser.Image = novaFoto;     // esse já existe no BaseForm.Designer
            pictureUser.Refresh();
        }

        private Image ZoomNaImagem(Image foto, float zoomFactor)
        {
            int novaLargura = (int)(foto.Width * zoomFactor);
            int novaAltura = (int)(foto.Height * zoomFactor);

            Bitmap bmp = new Bitmap(novaLargura, novaAltura);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(foto, new Rectangle(0, 0, novaLargura, novaAltura));
            }

            return bmp;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            pictureUser = new KryptonPictureBox();
            kryptonPictureBoxmenu = new KryptonPictureBox();
            pictureBox1 = new PictureBox();
            PanelEsquerda = new KryptonPanel();
            ButtonAjuda = new KryptonButton();
            ButtonResolucao = new KryptonButton();
            ButtonQuestao = new KryptonButton();
            ButtonRanking = new KryptonButton();
            ButtonPerfil = new KryptonButton();
            PanelConteudo = new KryptonPanel();
            kryptonButuonsobrenos = new KryptonButton();
            kryptonPanelmenu = new KryptonPanel();
            kryptonPerfil = new KryptonButton();
            kryptonButtonsair = new KryptonButton();
            kryptonPanel1 = new KryptonPanel();
            PanelCima = new KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)pictureUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBoxmenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelEsquerda).BeginInit();
            PanelEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PanelConteudo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanelmenu).BeginInit();
            kryptonPanelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelCima).BeginInit();
            PanelCima.SuspendLayout();
            SuspendLayout();
            // 
            // pictureUser
            // 
            pictureUser.Location = new Point(1200, 11);
            pictureUser.Name = "pictureUser";
            pictureUser.Size = new Size(60, 60);
            pictureUser.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureUser.TabIndex = 0;
            pictureUser.TabStop = false;
            // 
            // kryptonPictureBoxmenu
            // 
            kryptonPictureBoxmenu.Cursor = Cursors.Hand;
            kryptonPictureBoxmenu.Image = Properties.Resources.menu;
            kryptonPictureBoxmenu.Location = new Point(1211, 15);
            kryptonPictureBoxmenu.Name = "kryptonPictureBoxmenu";
            kryptonPictureBoxmenu.Size = new Size(48, 48);
            kryptonPictureBoxmenu.TabIndex = 1;
            kryptonPictureBoxmenu.TabStop = false;

            // Evento de clique normal
            kryptonPictureBoxmenu.Click += kryptonPictureBoxmenu_Click;

            // Evento para efeito de clique (diminuir e voltar ao tamanho)
            kryptonPictureBoxmenu.MouseDown += (s, e) =>
            {
                kryptonPictureBoxmenu.Size = new Size(44, 44);             // diminui tamanho
                kryptonPictureBoxmenu.Location = new Point(1209, 14);     // ajusta posição
            };

            kryptonPictureBoxmenu.MouseUp += (s, e) =>
            {
                kryptonPictureBoxmenu.Size = new Size(48, 48);            // volta ao tamanho original
                kryptonPictureBoxmenu.Location = new Point(1211, 15);     // posição original
            };
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(32, 0, 177);
            pictureBox1.Image = Properties.Resources.logoStudyHorizontal;
            pictureBox1.Location = new Point(439, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 74);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelEsquerda
            // 
            PanelEsquerda.Controls.Add(ButtonAjuda);
            PanelEsquerda.Controls.Add(ButtonResolucao);
            PanelEsquerda.Controls.Add(ButtonQuestao);
            PanelEsquerda.Controls.Add(ButtonRanking);
            PanelEsquerda.Controls.Add(ButtonPerfil);
            PanelEsquerda.Dock = DockStyle.Left;
            PanelEsquerda.Location = new Point(0, 80);
            PanelEsquerda.Name = "PanelEsquerda";
            PanelEsquerda.Size = new Size(167, 601);
            PanelEsquerda.StateNormal.Color1 = Color.FromArgb(32, 0, 177);
            PanelEsquerda.TabIndex = 1;
            PanelEsquerda.Paint += PanelEsquerda_Paint;
            // 
            // ButtonAjuda
            // 
            ButtonAjuda.ButtonStyle = ButtonStyle.LowProfile;
            ButtonAjuda.Cursor = Cursors.Hand;
            ButtonAjuda.Dock = DockStyle.Top;
            ButtonAjuda.Location = new Point(0, 280);
            ButtonAjuda.Name = "ButtonAjuda";
            ButtonAjuda.Size = new Size(167, 70);
            ButtonAjuda.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            ButtonAjuda.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
            ButtonAjuda.StateCommon.Content.Image.ImageH = PaletteRelativeAlign.Near;
            ButtonAjuda.StateCommon.Content.Image.ImageV = PaletteRelativeAlign.Center;
            ButtonAjuda.StateCommon.Content.Padding = new Padding(15, 0, 0, 0);
            ButtonAjuda.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonAjuda.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ButtonAjuda.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
            ButtonAjuda.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            ButtonAjuda.StatePressed.Back.Color1 = Color.FromArgb(50, 0, 150);
            ButtonAjuda.StateTracking.Back.Color1 = Color.FromArgb(45, 0, 200);
            ButtonAjuda.TabIndex = 4;
            ButtonAjuda.Values.DropDownArrowColor = Color.Empty;
            ButtonAjuda.Values.Image = Properties.Resources.question;
            ButtonAjuda.Values.Text = "  AJUDA";
            ButtonAjuda.Click += ButtonAjuda_Click;
            // 
            // ButtonResolucao
            // 
            ButtonResolucao.ButtonStyle = ButtonStyle.LowProfile;
            ButtonResolucao.Cursor = Cursors.Hand;
            ButtonResolucao.Dock = DockStyle.Top;
            ButtonResolucao.Location = new Point(0, 210);
            ButtonResolucao.Name = "ButtonResolucao";
            ButtonResolucao.Size = new Size(167, 70);
            ButtonResolucao.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            ButtonResolucao.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
            ButtonResolucao.StateCommon.Content.Image.ImageH = PaletteRelativeAlign.Near;
            ButtonResolucao.StateCommon.Content.Image.ImageV = PaletteRelativeAlign.Center;
            ButtonResolucao.StateCommon.Content.Padding = new Padding(15, 0, 0, 0);
            ButtonResolucao.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonResolucao.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ButtonResolucao.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
            ButtonResolucao.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            ButtonResolucao.StatePressed.Back.Color1 = Color.FromArgb(50, 0, 150);
            ButtonResolucao.StateTracking.Back.Color1 = Color.FromArgb(45, 0, 200);
            ButtonResolucao.TabIndex = 3;
            ButtonResolucao.Values.DropDownArrowColor = Color.Empty;
            ButtonResolucao.Values.Image = Properties.Resources.check;
            ButtonResolucao.Values.Text = "  RESOLUÇÕES\r\n";
            ButtonResolucao.Click += ButtonQuestoes_Click;
            // 
            // ButtonQuestao
            // 
            ButtonQuestao.ButtonStyle = ButtonStyle.LowProfile;
            ButtonQuestao.Cursor = Cursors.Hand;
            ButtonQuestao.Dock = DockStyle.Top;
            ButtonQuestao.Location = new Point(0, 140);
            ButtonQuestao.Name = "ButtonQuestao";
            ButtonQuestao.Size = new Size(167, 70);
            ButtonQuestao.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            ButtonQuestao.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
            ButtonQuestao.StateCommon.Content.Image.ImageH = PaletteRelativeAlign.Near;
            ButtonQuestao.StateCommon.Content.Image.ImageV = PaletteRelativeAlign.Center;
            ButtonQuestao.StateCommon.Content.Padding = new Padding(15, 0, 0, 0);
            ButtonQuestao.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonQuestao.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ButtonQuestao.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
            ButtonQuestao.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            ButtonQuestao.StatePressed.Back.Color1 = Color.FromArgb(50, 0, 150);
            ButtonQuestao.StateTracking.Back.Color1 = Color.FromArgb(45, 0, 200);
            ButtonQuestao.TabIndex = 2;
            ButtonQuestao.Values.DropDownArrowColor = Color.Empty;
            ButtonQuestao.Values.Image = Properties.Resources.open_book;
            ButtonQuestao.Values.Text = "  QUESTÕES";
            ButtonQuestao.Click += ButtonNivelamento_Click;
            // 
            // ButtonRanking
            // 
            ButtonRanking.ButtonStyle = ButtonStyle.LowProfile;
            ButtonRanking.Cursor = Cursors.Hand;
            ButtonRanking.Dock = DockStyle.Top;
            ButtonRanking.Location = new Point(0, 70);
            ButtonRanking.Name = "ButtonRanking";
            ButtonRanking.Size = new Size(167, 70);
            ButtonRanking.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            ButtonRanking.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
            ButtonRanking.StateCommon.Content.Image.ImageH = PaletteRelativeAlign.Near;
            ButtonRanking.StateCommon.Content.Image.ImageV = PaletteRelativeAlign.Center;
            ButtonRanking.StateCommon.Content.Padding = new Padding(15, 0, 0, 0);
            ButtonRanking.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonRanking.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ButtonRanking.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
            ButtonRanking.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            ButtonRanking.StatePressed.Back.Color1 = Color.FromArgb(50, 0, 150);
            ButtonRanking.StateTracking.Back.Color1 = Color.FromArgb(45, 0, 200);
            ButtonRanking.TabIndex = 1;
            ButtonRanking.Values.DropDownArrowColor = Color.Empty;
            ButtonRanking.Values.Image = Properties.Resources.trophy;
            ButtonRanking.Values.Text = "  RANKING";
            ButtonRanking.Click += ButtonRanking_Click;
            // 
            // ButtonPerfil
            // 
            ButtonPerfil.ButtonStyle = ButtonStyle.LowProfile;
            ButtonPerfil.Cursor = Cursors.Hand;
            ButtonPerfil.Dock = DockStyle.Top;
            ButtonPerfil.Location = new Point(0, 0);
            ButtonPerfil.Name = "ButtonPerfil";
            ButtonPerfil.Size = new Size(167, 70);
            ButtonPerfil.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            ButtonPerfil.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
            ButtonPerfil.StateCommon.Content.Image.ImageH = PaletteRelativeAlign.Near;
            ButtonPerfil.StateCommon.Content.Image.ImageV = PaletteRelativeAlign.Center;
            ButtonPerfil.StateCommon.Content.Padding = new Padding(15, 0, 0, 0);
            ButtonPerfil.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonPerfil.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ButtonPerfil.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Near;
            ButtonPerfil.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            ButtonPerfil.StatePressed.Back.Color1 = Color.FromArgb(50, 0, 150);
            ButtonPerfil.StateTracking.Back.Color1 = Color.FromArgb(45, 0, 200);
            ButtonPerfil.TabIndex = 0;
            ButtonPerfil.Values.DropDownArrowColor = Color.Empty;
            ButtonPerfil.Values.Image = (Image)resources.GetObject("ButtonPerfil.Values.Image");
            ButtonPerfil.Values.Text = "  PERFIL";
            ButtonPerfil.Click += ButtonHome_Click;
            // 
            // PanelConteudo
            // 
            PanelConteudo.Dock = DockStyle.Fill;
            PanelConteudo.Location = new Point(167, 80);
            PanelConteudo.Name = "PanelConteudo";
            PanelConteudo.Size = new Size(1097, 601);
            PanelConteudo.StateNormal.Color1 = Color.White;
            PanelConteudo.TabIndex = 2;
            PanelConteudo.Paint += PanelConteudo_Paint;
            // 
            // kryptonButuonsobrenos
            // 
            kryptonButuonsobrenos.Location = new Point(5, 42);
            kryptonButuonsobrenos.Name = "kryptonButuonsobrenos";
            kryptonButuonsobrenos.Size = new Size(92, 36);
            kryptonButuonsobrenos.StateCommon.Back.Color1 = Color.White;
            kryptonButuonsobrenos.StateCommon.Back.Color2 = Color.White;
            kryptonButuonsobrenos.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonButuonsobrenos.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            kryptonButuonsobrenos.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButuonsobrenos.StateCommon.Border.Rounding = 4F;
            kryptonButuonsobrenos.StateCommon.Content.ShortText.Color1 = Color.Black;
            kryptonButuonsobrenos.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            kryptonButuonsobrenos.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButuonsobrenos.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButuonsobrenos.StateTracking.Back.Color1 = Color.FromArgb(255, 102, 0);
            kryptonButuonsobrenos.StateTracking.Back.Color2 = Color.FromArgb(255, 102, 0);
            kryptonButuonsobrenos.StateTracking.Border.Color1 = Color.Black;
            kryptonButuonsobrenos.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButuonsobrenos.StateTracking.Content.ShortText.Color1 = Color.White;/////////////////////////////
            kryptonButuonsobrenos.StateTracking.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            kryptonButuonsobrenos.TabIndex = 3;
            kryptonButuonsobrenos.Values.DropDownArrowColor = Color.Empty;
            kryptonButuonsobrenos.Values.Text = "Sobre Nós";
            kryptonButuonsobrenos.Visible = false;
            kryptonButuonsobrenos.Click += kryptonButuonsobrenos_Click;
            // 
            // kryptonPanelmenu
            // 
            kryptonPanelmenu.Controls.Add(kryptonPerfil);
            kryptonPanelmenu.Controls.Add(kryptonButtonsair);
            kryptonPanelmenu.Controls.Add(kryptonButuonsobrenos);
            kryptonPanelmenu.Location = new Point(1147, 83);
            kryptonPanelmenu.Name = "kryptonPanelmenu";
            kryptonPanelmenu.Size = new Size(105, 128);
            kryptonPanelmenu.StateCommon.Color1 = Color.White;
            kryptonPanelmenu.StateCommon.Color2 = Color.White;
            kryptonPanelmenu.StateCommon.ColorStyle = PaletteColorStyle.Solid;
            kryptonPanelmenu.TabIndex = 4;
            kryptonPanelmenu.Visible = false;
            kryptonPanelmenu.Paint += kryptonPanelmenu_Paint;
            // 
            // kryptonPerfil
            // 
            kryptonPerfil.Cursor = Cursors.Hand;
            kryptonPerfil.Location = new Point(5, 3);
            kryptonPerfil.Name = "kryptonPerfil";
            kryptonPerfil.Size = new Size(92, 38);
            kryptonPerfil.StateCommon.Back.Color1 = Color.White;
            kryptonPerfil.StateCommon.Back.Color2 = Color.White;
            kryptonPerfil.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonPerfil.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            kryptonPerfil.StateCommon.Border.Color2 = Color.Black;
            kryptonPerfil.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonPerfil.StateCommon.Border.Rounding = 5F;
            kryptonPerfil.StateCommon.Content.ShortText.Color1 = Color.Black;
            kryptonPerfil.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            kryptonPerfil.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonPerfil.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonPerfil.StatePressed.Back.Color1 = Color.LightGray;
            kryptonPerfil.StatePressed.Back.Color2 = Color.LightGray;
            kryptonPerfil.StateTracking.Back.Color1 = Color.FromArgb(255, 102, 0);
            kryptonPerfil.StateTracking.Back.Color2 = Color.FromArgb(255, 102, 0);
            kryptonPerfil.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonPerfil.TabIndex = 1;
            kryptonPerfil.Values.DropDownArrowColor = Color.Empty;
            kryptonPerfil.Values.Text = "Perfil";
            kryptonPerfil.Visible = false;
            kryptonPerfil.Click += kryptonPerfil_Click;
            // 
            // kryptonButtonsair
            // 
            kryptonButtonsair.Cursor = Cursors.Hand;
            kryptonButtonsair.Location = new Point(5, 79);
            kryptonButtonsair.Name = "kryptonButtonsair";
            kryptonButtonsair.Size = new Size(92, 38);
            kryptonButtonsair.StateCommon.Back.Color1 = Color.White;
            kryptonButtonsair.StateCommon.Back.Color2 = Color.White;
            kryptonButtonsair.StateCommon.Back.ColorStyle = PaletteColorStyle.Solid;
            kryptonButtonsair.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            kryptonButtonsair.StateCommon.Border.Color2 = Color.Black;
            kryptonButtonsair.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonButtonsair.StateCommon.Border.Rounding = 5F;
            kryptonButtonsair.StateCommon.Content.ShortText.Color1 = Color.Black;
            kryptonButtonsair.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            kryptonButtonsair.StateCommon.Content.ShortText.TextH = PaletteRelativeAlign.Center;
            kryptonButtonsair.StateCommon.Content.ShortText.TextV = PaletteRelativeAlign.Center;
            kryptonButtonsair.StatePressed.Back.Color1 = Color.LightGray;
            kryptonButtonsair.StatePressed.Back.Color2 = Color.LightGray;
            kryptonButtonsair.StateTracking.Back.Color1 = Color.FromArgb(255, 102, 0);
            kryptonButtonsair.StateTracking.Back.Color2 = Color.FromArgb(255, 102, 0);
            kryptonButtonsair.StateTracking.Content.ShortText.Color1 = Color.White;
            kryptonButtonsair.TabIndex = 2;
            kryptonButtonsair.Values.DropDownArrowColor = Color.Empty;
            kryptonButtonsair.Values.Text = "Sair";
            kryptonButtonsair.Click += kryptonButtonsair_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Location = new Point(1120, 111);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(103, 132);
            kryptonPanel1.TabIndex = 0;
            // 
            // PanelCima
            // 
            PanelCima.Controls.Add(kryptonPanel1);
            PanelCima.Controls.Add(kryptonPictureBoxmenu);
            PanelCima.Controls.Add(pictureBox1);
            PanelCima.Dock = DockStyle.Top;
            PanelCima.Location = new Point(0, 0);
            PanelCima.Name = "PanelCima";
            PanelCima.Size = new Size(1264, 80);
            PanelCima.StateNormal.Color1 = Color.FromArgb(32, 0, 177);
            PanelCima.TabIndex = 0;
            // 
            // BaseForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1264, 681);
            Controls.Add(PanelConteudo);
            Controls.Add(PanelEsquerda);
            Controls.Add(kryptonPanelmenu);
            Controls.Add(PanelCima);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BaseForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudyFlow";
            FormClosing += BaseForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBoxmenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelEsquerda).EndInit();
            PanelEsquerda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PanelConteudo).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanelmenu).EndInit();
            kryptonPanelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelCima).EndInit();
            PanelCima.ResumeLayout(false);
            ResumeLayout(false);
        }
        //kryptonPictureBox1_Click
        #endregion

        private Krypton.Toolkit.KryptonPanel PanelCima;
        private Krypton.Toolkit.KryptonPanel PanelEsquerda;
        protected internal Krypton.Toolkit.KryptonPanel PanelConteudo;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton ButtonQuestao;
        private Krypton.Toolkit.KryptonButton ButtonRanking;
        private Krypton.Toolkit.KryptonButton ButtonPerfil;
        private Krypton.Toolkit.KryptonButton ButtonAjuda;
        private Krypton.Toolkit.KryptonButton ButtonResolucao;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBoxmenu;
        private KryptonPanel kryptonPanel1;


        private KryptonPictureBox pictureUser;
        private KryptonButton kryptonPerfil;
        private KryptonButton kryptonButuonsobrenos;
        private KryptonButton kryptonButtonsair;
        private Krypton.Toolkit.KryptonPanel kryptonPanelmenu;
    }
}