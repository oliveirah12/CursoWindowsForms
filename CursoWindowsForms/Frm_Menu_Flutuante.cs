using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                //var PosicaoX = e.X;
                //var PosicaoY = e.Y;
                //MessageBox.Show($"Clicou com o direito do mouse. " +
                //    $"\nPosição relativa:\nX:{PosicaoX} \nY: {PosicaoY}");

                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("Item 1", "cadeado");
                var vToolTip002 = DesenhaItemMenu("Item 2", "Frm_ValidaSenha");
                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);

            }

            void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Menu 001");
            }

            void vToolTip002_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Menu 002");
            }



            ToolStripMenuItem DesenhaItemMenu(string Text, string NomeImagem)
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = Text;

                Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources
                                                    .ResourceManager.GetObject(NomeImagem);
                vToolTip.Image = MyImage;

                return vToolTip;
            }
        }
    }
}
