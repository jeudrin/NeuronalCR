using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;

namespace NeuronalCR
{
    public partial class Form1 : Form
    {
        static Image<Bgr, Byte> imagenSeleccionada;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image<Bgr, byte> imagenOriginal = new Image<Bgr, byte>(openFileDialog.FileName);

                    imagenSeleccionada = imagenOriginal.Resize(360, 414, Emgu.CV.CvEnum.Inter.Linear);

                    imageBox.Image = imagenSeleccionada;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            int limite = 170;

            Image<Gray, Byte> imagenGray = imagenSeleccionada.Convert<Gray, Byte>();
            imagenGray = imagenGray.ThresholdBinary(new Gray(limite), new Gray(255));
            imagenSeleccionada = new Image<Bgr, byte>(imagenGray.Bitmap);
            imageBox.Image = imagenSeleccionada;
        }

        private void btnRedNeuronal_Click(object sender, EventArgs e)
        {
        }        
    }
}