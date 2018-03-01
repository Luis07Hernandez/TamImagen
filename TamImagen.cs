using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Abrir_archivo_BMP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Propiedades()
        {
            OpenFileBMP.ShowDialog();
            string Name = OpenFileBMP.FileName;
            string opfext = System.IO.Path.GetExtension(OpenFileBMP.FileName);
            string opext = System.IO.Path.GetFileName(OpenFileBMP.FileName);

            Bitmap imgBMPorg;
            if (opfext == ".bmp" || opfext == ".Bmp")
            {
                FileInfo xFile = new FileInfo(Name);
                imgBMPorg = new Bitmap(Name, true);
                imgBMP.Image = Image.FromFile(Name);

                txtInfo.Text = "Nombre: " + opext + Environment.NewLine;
                txtInfo.Text += "Dirección: " + Name + Environment.NewLine;
                txtInfo.Text += "Tamaño: " + xFile.Length + " Bytes. " + Environment.NewLine;
                /*
                8 Bits = 1 Byte
                1024 Bytes = 1 KiloByte
                1024 KiloBytes = 1 MegaByte
                Si tienes 4 MegaByte y quieres convertirlo en Bytes es tan simple como
                4 * 1024 * 1024 =  4194304 Bytes
                */
                txtInfo.Text += "Ancho: " + imgBMPorg.Width + " Pixeles <---> Resolucion : " + imgBMPorg.HorizontalResolution + Environment.NewLine;
                txtInfo.Text += "Alto: " + imgBMPorg.Height + " Pixeles <---> Resolucion : " + imgBMPorg.VerticalResolution + Environment.NewLine;

            }
            else
            {
                txtInfo.Text = "Archivo de imagen no permitido, solo .BMP";
            }
        }
        
         
        


        private void btnAbrir_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();

            Propiedades();

        }
    }
}
