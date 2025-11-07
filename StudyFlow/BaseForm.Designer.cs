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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelCima = new Krypton.Toolkit.KryptonPanel();
            PanelEsquerda = new Krypton.Toolkit.KryptonPanel();
            ButtonAjuda = new Krypton.Toolkit.KryptonButton();
            ButtonQuestoes = new Krypton.Toolkit.KryptonButton();
            ButtonNivelamento = new Krypton.Toolkit.KryptonButton();
            ButtonRanking = new Krypton.Toolkit.KryptonButton();
            ButtonHome = new Krypton.Toolkit.KryptonButton();
            PanelConteudo = new Krypton.Toolkit.KryptonPanel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PanelCima).BeginInit();
            PanelCima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PanelEsquerda).BeginInit();
            PanelEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PanelConteudo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelCima
            // 
            PanelCima.Controls.Add(pictureBox1);
            PanelCima.Dock = DockStyle.Top;
            PanelCima.Location = new Point(0, 0);
            PanelCima.Name = "PanelCima";
            PanelCima.Size = new Size(1288, 80);
            PanelCima.StateNormal.Color1 = Color.FromArgb(32, 0, 177);
            PanelCima.TabIndex = 0;
            // 
            // PanelEsquerda
            // 
            PanelEsquerda.Controls.Add(ButtonAjuda);
            PanelEsquerda.Controls.Add(ButtonQuestoes);
            PanelEsquerda.Controls.Add(ButtonNivelamento);
            PanelEsquerda.Controls.Add(ButtonRanking);
            PanelEsquerda.Controls.Add(ButtonHome);
            PanelEsquerda.Dock = DockStyle.Left;
            PanelEsquerda.Location = new Point(0, 80);
            PanelEsquerda.Name = "PanelEsquerda";
            PanelEsquerda.Size = new Size(167, 616);
            PanelEsquerda.StateNormal.Color1 = Color.FromArgb(32, 0, 177);
            PanelEsquerda.TabIndex = 1;
            // 
            // ButtonAjuda
            // 
            ButtonAjuda.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            ButtonAjuda.Cursor = Cursors.Hand;
            ButtonAjuda.Dock = DockStyle.Top;
            ButtonAjuda.Location = new Point(0, 280);
            ButtonAjuda.Name = "ButtonAjuda";
            ButtonAjuda.Size = new Size(167, 70);
            ButtonAjuda.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            ButtonAjuda.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ButtonAjuda.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonAjuda.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ButtonAjuda.StateCommon.Content.Padding = new Padding(15, 0, 0, 0);
            ButtonAjuda.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonAjuda.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ButtonAjuda.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonAjuda.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ButtonAjuda.StatePressed.Back.Color1 = Color.FromArgb(50, 0, 150);
            ButtonAjuda.StateTracking.Back.Color1 = Color.FromArgb(45, 0, 200);
            ButtonAjuda.TabIndex = 4;
            ButtonAjuda.Values.DropDownArrowColor = Color.Empty;
            ButtonAjuda.Values.Image = Properties.Resources.question;
            ButtonAjuda.Values.Text = "  AJUDA";
            ButtonAjuda.Click += ButtonAjuda_Click;
            // 
            // ButtonQuestoes
            // 
            ButtonQuestoes.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            ButtonQuestoes.Cursor = Cursors.Hand;
            ButtonQuestoes.Dock = DockStyle.Top;
            ButtonQuestoes.Location = new Point(0, 210);
            ButtonQuestoes.Name = "ButtonQuestoes";
            ButtonQuestoes.Size = new Size(167, 70);
            ButtonQuestoes.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            ButtonQuestoes.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ButtonQuestoes.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonQuestoes.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ButtonQuestoes.StateCommon.Content.Padding = new Padding(15, 0, 0, 0);
            ButtonQuestoes.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonQuestoes.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ButtonQuestoes.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonQuestoes.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ButtonQuestoes.StatePressed.Back.Color1 = Color.FromArgb(50, 0, 150);
            ButtonQuestoes.StateTracking.Back.Color1 = Color.FromArgb(45, 0, 200);
            ButtonQuestoes.TabIndex = 3;
            ButtonQuestoes.Values.DropDownArrowColor = Color.Empty;
            ButtonQuestoes.Values.Image = Properties.Resources.check;
            ButtonQuestoes.Values.Text = "  QUESTÕES";
            ButtonQuestoes.Click += ButtonQuestoes_Click;
            // 
            // ButtonNivelamento
            // 
            ButtonNivelamento.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            ButtonNivelamento.Cursor = Cursors.Hand;
            ButtonNivelamento.Dock = DockStyle.Top;
            ButtonNivelamento.Location = new Point(0, 140);
            ButtonNivelamento.Name = "ButtonNivelamento";
            ButtonNivelamento.Size = new Size(167, 70);
            ButtonNivelamento.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            ButtonNivelamento.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ButtonNivelamento.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonNivelamento.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ButtonNivelamento.StateCommon.Content.Padding = new Padding(15, 0, 0, 0);
            ButtonNivelamento.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonNivelamento.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ButtonNivelamento.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonNivelamento.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ButtonNivelamento.StatePressed.Back.Color1 = Color.FromArgb(50, 0, 150);
            ButtonNivelamento.StateTracking.Back.Color1 = Color.FromArgb(45, 0, 200);
            ButtonNivelamento.TabIndex = 2;
            ButtonNivelamento.Values.DropDownArrowColor = Color.Empty;
            ButtonNivelamento.Values.Image = Properties.Resources.open_book;
            ButtonNivelamento.Values.Text = "  NIVELAMENTO";
            ButtonNivelamento.Click += ButtonNivelamento_Click;
            // 
            // ButtonRanking
            // 
            ButtonRanking.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            ButtonRanking.Cursor = Cursors.Hand;
            ButtonRanking.Dock = DockStyle.Top;
            ButtonRanking.Location = new Point(0, 70);
            ButtonRanking.Name = "ButtonRanking";
            ButtonRanking.Size = new Size(167, 70);
            ButtonRanking.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            ButtonRanking.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ButtonRanking.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonRanking.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ButtonRanking.StateCommon.Content.Padding = new Padding(15, 0, 0, 0);
            ButtonRanking.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonRanking.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ButtonRanking.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonRanking.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ButtonRanking.StatePressed.Back.Color1 = Color.FromArgb(50, 0, 150);
            ButtonRanking.StateTracking.Back.Color1 = Color.FromArgb(45, 0, 200);
            ButtonRanking.TabIndex = 1;
            ButtonRanking.Values.DropDownArrowColor = Color.Empty;
            ButtonRanking.Values.Image = Properties.Resources.trophy;
            ButtonRanking.Values.Text = "  RANKING";
            ButtonRanking.Click += ButtonRanking_Click;
            // 
            // ButtonHome
            // 
            ButtonHome.ButtonStyle = Krypton.Toolkit.ButtonStyle.LowProfile;
            ButtonHome.Cursor = Cursors.Hand;
            ButtonHome.Dock = DockStyle.Top;
            ButtonHome.Location = new Point(0, 0);
            ButtonHome.Name = "ButtonHome";
            ButtonHome.Size = new Size(167, 70);
            ButtonHome.StateCommon.Back.Color1 = Color.FromArgb(32, 0, 177);
            ButtonHome.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            ButtonHome.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonHome.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ButtonHome.StateCommon.Content.Padding = new Padding(15, 0, 0, 0);
            ButtonHome.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonHome.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ButtonHome.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonHome.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ButtonHome.StatePressed.Back.Color1 = Color.FromArgb(50, 0, 150);
            ButtonHome.StateTracking.Back.Color1 = Color.FromArgb(45, 0, 200);
            ButtonHome.TabIndex = 0;
            ButtonHome.Values.DropDownArrowColor = Color.Empty;
            ButtonHome.Values.Image = Properties.Resources.house;
            ButtonHome.Values.Text = "  HOME";
            ButtonHome.Click += ButtonHome_Click;
            // 
            // PanelConteudo
            // 
            PanelConteudo.Dock = DockStyle.Fill;
            PanelConteudo.Location = new Point(167, 80);
            PanelConteudo.Name = "PanelConteudo";
            PanelConteudo.Size = new Size(1121, 616);
            PanelConteudo.StateNormal.Color1 = Color.White;
            PanelConteudo.TabIndex = 2;
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
            // BaseForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1288, 696);
            Controls.Add(PanelConteudo);
            Controls.Add(PanelEsquerda);
            Controls.Add(PanelCima);
            Location = new Point(0, 0);
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudyFlow";
            FormClosing += BaseForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)PanelCima).EndInit();
            PanelCima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PanelEsquerda).EndInit();
            PanelEsquerda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PanelConteudo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel PanelCima;
        private Krypton.Toolkit.KryptonPanel PanelEsquerda;
        protected internal Krypton.Toolkit.KryptonPanel PanelConteudo;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton ButtonNivelamento;
        private Krypton.Toolkit.KryptonButton ButtonRanking;
        private Krypton.Toolkit.KryptonButton ButtonHome;
        private Krypton.Toolkit.KryptonButton ButtonAjuda;
        private Krypton.Toolkit.KryptonButton ButtonQuestoes;
        private PictureBox pictureBox1;
    }
}