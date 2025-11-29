using Krypton.Toolkit;
namespace StudyFlow
{
    partial class HomeForm
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
            kryptonLabel1 = new KryptonLabel();
            kryptonPictureBox1 = new KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)PanelConteudo).BeginInit();
            PanelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelConteudo
            // 
            PanelConteudo.Controls.Add(kryptonPictureBox1);
            PanelConteudo.Controls.Add(kryptonLabel1);
            PanelConteudo.Size = new Size(1121, 616);
            PanelConteudo.StateNormal.Color1 = Color.White;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(429, 190);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(88, 20);
            kryptonLabel1.TabIndex = 3;
            kryptonLabel1.Values.Text = "kryptonLabel1";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Location = new Point(886, 95);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(100, 50);
            kryptonPictureBox1.TabIndex = 4;
            kryptonPictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            ClientSize = new Size(1288, 696);
            Name = "HomeForm";
            Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)PanelConteudo).EndInit();
            PanelConteudo.ResumeLayout(false);
            PanelConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel linkLabelSenha;
        private KryptonLabel kryptonLabel1;
        private KryptonPictureBox kryptonPictureBox1;
    }
}