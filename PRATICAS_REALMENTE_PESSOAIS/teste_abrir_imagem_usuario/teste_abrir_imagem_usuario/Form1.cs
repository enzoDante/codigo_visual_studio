using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_abrir_imagem_usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //altere o sizeMode do picturebox p nn cortar a imagem altere p StretchImage

        private void button1_Click(object sender, EventArgs e)
        {
            //openFileDialog1 = ofdLogo
            //inicialização do campo FileName
            openFileDialog1.FileName = "";
            //titulo q a caixa terá
            openFileDialog1.Title = "Selecione uma foto";
            //formatos q é permitido
            openFileDialog1.Filter = "JPEG|*.JPG|PNG|*.png";
            //chamando a caixa de diálogo
            openFileDialog1.ShowDialog();


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //adiciona uma imagem q foi selecionada do openfiledialog p o picturebox
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

        }
    }
}
