using System;
using Krypton.Toolkit;
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
    public partial class PopupForm : Form
    {
        public PopupForm(string titulo, string mensagem)
        {
            InitializeComponent();
            configPopup(titulo, mensagem);
        }

        private void configPopup(string titulo, string msg)
        {
            this.Size = new Size(600, 410);
            this.AutoScaleMode = AutoScaleMode.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "";
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SizeGripStyle = SizeGripStyle.Hide;
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            KryptonLabel labelTitulo = new KryptonLabel();
            labelTitulo.Text = titulo;
            labelTitulo.Location = new Point(30, 10);
            labelTitulo.StateCommon.ShortText.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            labelTitulo.StateCommon.ShortText.Color1 = Color.FromArgb(32, 0, 177);
            Controls.Add(labelTitulo);

            KryptonRichTextBox texto = new KryptonRichTextBox();
            texto.ReadOnly = true;
            texto.Location = new Point(30, 50);
            texto.Size = new Size(520, 240);
            texto.StateCommon.Border.Rounding = 8;
            texto.StateCommon.Border.Color1 = Color.FromArgb(255, 102, 0);
            texto.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            texto.StateCommon.Content.Font = new Font("Segoe UI", 11);
            texto.Text = msg;
            Controls.Add(texto);

            KryptonButton btnFechar = new KryptonButton();
            btnFechar.Text = "Fechar";
            btnFechar.Location = new Point(230, 300);
            btnFechar.Size = new Size(120, 40);
            btnFechar.StateCommon.Back.Color1 = Color.FromArgb(255, 102, 0);
            btnFechar.StateCommon.Back.Color2 = Color.FromArgb(255, 102, 0);
            btnFechar.StateCommon.Border.Rounding = 15;
            btnFechar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnFechar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnFechar.Click += (s, e) => this.Close();
            Controls.Add(btnFechar);

            btnFechar.MouseDown += (s, e) =>
            {
                btnFechar.Size = new Size(115, 35);
                btnFechar.Location = new Point(233, 303);
            };

            btnFechar.MouseUp += (s, e) =>
            {
                btnFechar.Size = new Size(120, 40);
                btnFechar.Location = new Point(230, 300);
            };
        }
    }
}

