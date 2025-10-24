namespace StudyFlow
{
    partial class AjudaForm
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
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)PanelConteudo).BeginInit();
            PanelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // PanelConteudo
            // 
            PanelConteudo.Controls.Add(kryptonLabel1);
            PanelConteudo.Size = new Size(1057, 583);
            PanelConteudo.StateNormal.Color1 = Color.White;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(118, 60);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(88, 20);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "kryptonLabel1";
            // 
            // AjudaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(1270, 663);
            Name = "AjudaForm";
            Text = "AjudaForm";
            ((System.ComponentModel.ISupportInitialize)PanelConteudo).EndInit();
            PanelConteudo.ResumeLayout(false);
            PanelConteudo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}