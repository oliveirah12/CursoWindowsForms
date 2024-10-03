using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Questao : Form
    {
        public Frm_Questao(string NomeImagem, string Mensagem)
        {
            InitializeComponent();
            Image MyImage = (Image)global::CursoWindowsForms
                                            .Properties.Resources
                                                .ResourceManager.GetObject(NomeImagem);
            Pic_Imagem.Image = MyImage;
            Lbl_Questao.Text = Mensagem;
;        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
