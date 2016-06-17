using NeuronalCR.Class;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using NeuronalCR.Lógica;
using System.IO;

namespace NeuronalCR
{
    /// <summary>
    /// vista del programa
    /// </summary>
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imagenSeleccionada;
        Image<Bgr, byte> nuevaImagen;
        Backpropagation backpropagation;
        Letra l = new Letra();
        string name;

        SetupReNeuronal setup = new SetupReNeuronal();

        int divisor1 = 0;
        String[] listaCaracteres = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" ,
                                        "A", "B","C","D","E","F","G","H","I","J","K","L",
                                        "M","N","O","P","Q","R","S","T","U","V","W","X",
                                        "Y","Z" };

        public Form1()
        {
            InitializeComponent();
            inicializar();
            
        }

        /// <summary>
        /// Boton para buscar la imagen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image<Bgr, byte> imagenOriginal = new Image<Bgr, byte>(openFileDialog.FileName);
                    name = Path.GetFileName(openFileDialog.FileName);
                    imagenSeleccionada = imagenOriginal.Resize(600, 600, Emgu.CV.CvEnum.Inter.Linear);
                    imageBox.Image = imagenSeleccionada;
                    lblResultado.Text = "Imagen cargada con éxito";
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        /// <summary>
        /// Boton para aplicar el filtro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (imagenSeleccionada != null)
            {
                int limite = 170;

                Image<Gray, byte> imagenGray = imagenSeleccionada.Convert<Gray, Byte>();
                imagenGray = imagenGray.ThresholdBinary(new Gray(limite), new Gray(255));
                imagenSeleccionada = new Image<Bgr, byte>(imagenGray.Bitmap);
                imageBox.Image = imagenSeleccionada;

                lblResultado.Text = "Se aplicó el filtro correctamente";
            }
            else
                lblResultado.Text = "Cargar una imagen primero";
        }

        /// <summary>
        /// Boton para iniciarlizar los datos de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInicializar_Click(object sender, EventArgs e)
        {
            inicializar();

            lblResultado.Text = "Se inicializó la aplicación";
        }

        /// <summary>
        /// Boton para realizar el ajuste de los pesos de la red
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjustarPesos_Click(object sender, EventArgs e)
        {
            try
            {
                ajustarPesos();
                lblResultado.Text = "Se ajustaron los pesos";
            }
            catch (Exception)
            {
                lblResultado.Text = "Ingrese un valor válido";
            }
        }

        /// <summary>
        /// Metodo para calcular los pesos
        /// </summary>
        public void ajustarPesos()
        {
            List<List<double>> entryData = new List<List<double>>(backpropagation.getEntries());
            analyseData(entryData);
        }

        /// <summary>
        /// Boton para analizar la una imagen con un solo caracter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRedNeuronal_Click(object sender, EventArgs e)
        {
            try
            {
                //Con esto actualizamos los datos de entrada para que concuerden con el caracter indicado por el usuario.
                String characterToAnalyse = tbCaracter.Text.ToUpper();
                getEntryData(characterToAnalyse, obtenerPatronPorCuadros(imagenSeleccionada));

                // Analizamos la imagen elegida por el usuario.
                int iteraciones = Int32.Parse(tbIteraciones.Text);
                double percentaje = Math.Round(backpropagation.iniciarAnalisis(backpropagation.getUserEntry(), iteraciones, true), 2);
                lblResultado.Text = percentaje.ToString() + "% de similitud, con: " + tbCaracter.Text;
            }
            catch(Exception ex)
            {
                //lblResultado.Text = "Ocurrió un error en el análisis";
                Console.WriteLine(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Metodo para inicializar los datos de la aplicacion
        /// </summary>
        public void inicializar()
        {
            backpropagation = new Backpropagation();
            setup.createNeuralNetwork(backpropagation);
            setup.createCharactersTable(backpropagation);
        }

        /// <summary>
        /// Boton para analizar una imagen con mas de un caracter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnalisisCaracteres_Click(object sender, EventArgs e)
        {
            List<List<int>> matriz = obtenerMatriz(imagenSeleccionada);
            List<Letra> letras = obtenerLetras(matriz);
            List<Image<Bgr, byte>> listImages = obtenerListaImagenes(letras);
            double[] porcentajes = new double[listaCaracteres.Length];

            lblResultado.Text = "";
            //backpropagation.catcha = true;
            for (int i = 0; i < listImages.Count; i++)
            {
                //Con esto actualizamos los datos de entrada para que concuerden con el caracter indicado por el usuario.
                //ajustarPesos();

                //imageBox.Image = listImages[i];
                Image<Bgr, byte> item = listImages[i].Resize(600, 600, Emgu.CV.CvEnum.Inter.Linear);
                List<double> x = obtenerPatronPorCuadros(item);


                int j = 0;
                while (j < listaCaracteres.Length)
                {
                    String characterToAnalyse = listaCaracteres[j];
                    getEntryData(characterToAnalyse, x);
                    int iteraciones = Int32.Parse(tbIteraciones.Text);
                    double porcentaje = Math.Round(backpropagation.iniciarAnalisis(backpropagation.getUserEntry(), iteraciones, false), 2);
                    porcentajes[j] = l.ajuste(name,porcentaje, listaCaracteres[j], i);
                    //porcentajes[j] = porcentaje;
                    j++;
                }
                imprimirLetra(porcentajes);
                porcentajes = new double[listaCaracteres.Length];
                
            }

            //Console.WriteLine("Termine con exito, imagenes totales " + letras.Count);
        }

        /// <summary>
        /// Metodo que se usa para analizar y ajustar la red neuronal usando toda la tabla de caracteres
        /// </summary>
        /// <param name="entryData">tabla de caracteres</param>
        public void analyseData(List<List<double>> entryData)
        {
            int iterations = Int32.Parse(tbIteraciones.Text);
            backpropagation.iniciarAnalisis(entryData, iterations, true);
        }
        
        /// <summary>
        /// Metodo que toma los datos de entrada
        /// </summary>
        /// <param name="character">Es el caracter por analizar</param>
        /// <param name="entryData">Es la matriz de de la imagen</param>
        /// <returns>Matriz con los datos necesarios para analizar el caracter</returns>
        public List<List<double>> getEntryData(String character, List<double> entryData)
        {
            List<Patron> Lp = new List<Patron>(); //Lista de patrones.            
            Patron entryCharacter = new Patron("entryCharacter");
            for (int i = 0; i < 36; i++) {
                entryCharacter.agregarEntrada(new PatronItem("x"+(i+1), (int)entryData.ElementAt(i)));
            }

            if (character == "0")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "1")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "2")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "3")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "4")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "5")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "6")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "7")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "8")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "9")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "A")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "B")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "C")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "D")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "E")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "F")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "G")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "H")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "I")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "J")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "K")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "L")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "M")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "N")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "O")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "P")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "Q")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "R")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "S")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "T")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "U")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "V")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 0));
                entryCharacter.agregarSalida(new PatronItem("t2", 1));
                entryCharacter.agregarSalida(new PatronItem("t3", 1));
                entryCharacter.agregarSalida(new PatronItem("t4", 1));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "W")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 1));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "X")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 1));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 0));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            else if (character == "Y")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 1));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 0));
            }
            else if (character == "Z")
            {
                entryCharacter.agregarSalida(new PatronItem("t1", 1));
                entryCharacter.agregarSalida(new PatronItem("t2", 0));
                entryCharacter.agregarSalida(new PatronItem("t3", 0));
                entryCharacter.agregarSalida(new PatronItem("t4", 0));
                entryCharacter.agregarSalida(new PatronItem("t5", 1));
                entryCharacter.agregarSalida(new PatronItem("t6", 1));
            }
            Lp.Add(entryCharacter);
            if (backpropagation == null)
            {
                setup.createNeuralNetwork(backpropagation);
                backpropagation.patrones = new List<Patron>(Lp);
            }
            else
            {
                backpropagation.patrones = new List<Patron>(Lp);
            }
            return backpropagation.getEntries();
        }
        
        /// <summary>
        /// Toma una imagen de 600 x 600 pixeles y analiza sus 36 cuadros (Cada cuadro son 1000 pixeles)
        /// En total analiza 36 mil pixeles
        /// </summary>
        /// <param name="imagen">imagen por analiozar</param>
        /// <returns>Patron de la imagen por analizar</returns>
        private List<double> obtenerPatronPorCuadros(Image<Bgr, byte> imagen)
        {
            int ancho = imagen.Width;
            int alto = imagen.Height;
            List<double> entryData = new List<double>();
            String patron;

            string x;

            tbResultado.ResetText();

            for (int i = 0; i < ancho; i += 100)
            {
                x = "";

                for (int j = 0; j < alto; j += 100)
                {
                    Rectangle coordenadas = new Rectangle(j, i, 100, 100);
                    Image<Bgr, byte> cuadro = imagen.GetSubRect(coordenadas);
                    patron = obtenerPatrónPorPixeles(cuadro);

                    if (patron.Split('1').Length > 1200)
                    {
                        x += "1";
                        entryData.Add(1);
                    }
                    else
                    {
                        x += "0";
                        entryData.Add(0);
                    }
                }
                Console.WriteLine(x);
                tbResultado.AppendText(x);
                tbResultado.AppendText("\n");
            }

            return entryData;
        }
        
        /// <summary>
        /// Convierte la imagen en unos y ceros por pixel.
        /// </summary>
        /// <param name="imagen">imagen a convertir en 1 y 0</param>
        /// <returns>un string con 0 y 1 que representan los colores de la iamgen</returns>
        private String obtenerPatrónPorPixeles(Image<Bgr, byte> imagen)
        {
            String respuesta = "";
            int ancho = imagen.Width;
            int alto = imagen.Height;

            for (int i = 0; i < ancho; i++)
            {
                for (int j = 0; j < alto; j++)
                {
                    Color pixel = obtenerPixel(imagen, j, i);

                    if (pixel.ToString() == "Color [A=255, R=0, G=0, B=0]")
                    {
                        respuesta += "1";
                    }
                    else
                    {
                        respuesta += "0";
                    }
                }
                respuesta += Environment.NewLine;
            }
            return respuesta;
        }
        
        /// <summary>
        /// obtinene el color del pixel de la imagen en la posicion deseado
        /// </summary>
        /// <param name="imagen">imagen seleccionada</param>
        /// <param name="x">eje x</param>
        /// <param name="y">eje y</param>
        /// <returns>Color del pixel</returns>
        private Color obtenerPixel(Image<Bgr, byte> imagen, int x, int y)
        {
            return imagen.Bitmap.GetPixel(x, y);
        }

        /// <summary>
        /// Obtiene la lista de caracteres de la imagen por analizar
        /// </summary>
        /// <param name="matriz">matriz de imagen</param>
        /// <returns>lista de letras</returns>
        private List<Letra> obtenerLetras(List<List<int>> matriz)
        {
            List<Letra> letras = new List<Letra>();
            // Falso dentro del patron de la letra
            // True en un espacio en blanco
            bool wc = true;
            for (int columna = 0; columna < matriz[0].Count; columna++)
            {
                bool tempFlag = verificarVacio(columna, matriz);
                if (!wc && tempFlag)
                {
                    letras.Add(generarLetra(columna, matriz));
                }
                wc = tempFlag;
            }
            return letras;
        }

        /// <summary>
        /// obtener la letra de la matriz
        /// </summary>
        /// <param name="matriz">matriz de la imagen</param>
        /// <returns>letra</returns>
        private Letra obtenerLetra(List<List<int>> matriz)
        {
            Letra letras = null;
            // Falso dentro del patron de la letra
            // True en un espacio en blanco
            bool wc = true;
            for (int columna = 0; columna < matriz[0].Count; columna++)
            {
                bool tempFlag = verificarVacio(columna, matriz);
                if (!wc && tempFlag)
                {
                    letras = generarLetra(columna, matriz);
                }
                wc = tempFlag;
            }
            return letras;
        }

        /// <summary>
        /// obtine la lista de imagenes (caracteres de una imagen)
        /// </summary>
        /// <param name="letras">lista de letras</param>
        /// <returns>lista con las imagenes por analizar</returns>
        private List<Image<Bgr, byte>> obtenerListaImagenes(List<Letra> letras) {
            List<Image<Bgr, byte>> imagenes = new List<Image<Bgr, byte>>();
            
            for (int k = 0; k < letras.Count; k++)
            {
                Bitmap bitmap = new Bitmap(letras[k].Matriz.Count, letras[k].Matriz[0].Count);
                for (int i = 0; i < letras[k].Matriz.Count; i++)
                {
                    string x = "";
                    for (int j = 0; j < letras[k].Matriz[i].Count; j++)
                    {
                        
                        if (letras[k].Matriz[i][j] == 1)
                        {
                            x += "1";
                            bitmap.SetPixel(i, j, Color.Black);
                        }
                        else {
                            x += "0";
                            bitmap.SetPixel(i, j, Color.White);
                        }
                    }
                    //Console.WriteLine(x);
                }
                nuevaImagen = new Image<Bgr, byte>(bitmap);
                imagenes.Add(nuevaImagen);
            }
            return imagenes;
        }

        /// <summary>
        /// obtiene la imagen de una letra
        /// </summary>
        /// <param name="letras">letra para obtener imagen</param>
        /// <returns>imagen de la letra</returns>
        private Image<Bgr, byte> obtenerListaImagenes(Letra letras)
        {

            Bitmap bitmap = new Bitmap(letras.Matriz.Count, letras.Matriz[0].Count);
            for (int i = 0; i < letras.Matriz.Count; i++)
            {
                string x = "";
                for (int j = 0; j < letras.Matriz[i].Count; j++)
                {

                    if (letras.Matriz[i][j] == 1)
                    {
                        x += "1";
                        bitmap.SetPixel(i, j, Color.Black);
                    }
                    else {
                        x += "0";
                        bitmap.SetPixel(i, j, Color.White);
                    }
                }
                //Console.WriteLine(x);
            }

            return new Image<Bgr, byte>(bitmap); ;
        }

        /// <summary>
        /// genera la letra de la amtriz de una imagen
        /// </summary>
        /// <param name="divisor2">hasta donde cortar la imagen</param>
        /// <param name="matriz">matriz de imagen</param>
        /// <returns></returns>
        private Letra generarLetra(int divisor2, List<List<int>> matriz)
        {
            List<List<int>> matrizDeLetra = new List<List<int>>();

            for (int fil = divisor1; fil < divisor2; fil++)
            {
                List<int> termpList = new List<int>();
                for (int col = 0; col < 600; col++)
                {
                    termpList.Add(matriz[col][fil]);
                }
                matrizDeLetra.Add(termpList);
            }
            Letra letra = new Letra(matrizDeLetra);
            divisor1 = divisor2;
            return letra;
        }

        /// <summary>
        /// verifica que una columna esta con datos vacios (0)
        /// </summary>
        /// <param name="columna">columna a verificar</param>
        /// <param name="matriz">matriz de imagen</param>
        /// <returns>true si es vacia y false si no lo es</returns>
        private bool verificarVacio(int columna, List<List<int>> matriz)
        {
            for (int fila = 0; fila < matriz.Count; fila++)
            {
                if (matriz[fila][columna] == 1)
                {
                    return false;
                }
            }
            return true;
        }
        
        /// <summary>
        /// obtine la matriz de la imagen a analizar
        /// </summary>
        /// <param name="imagen">imagen a analizar</param>
        /// <returns>matriz de imagen</returns>
        private List<List<int>> obtenerMatriz(Image<Bgr, byte> imagen)
        {
            List<List<int>> matriz = new List<List<int>>();
            int ancho = imagen.Width;
            int alto = imagen.Height;

            for (int i = 0; i < ancho; i++)
            {
                List<int> fila = new List<int>();
                for (int j = 0; j < alto; j++)
                {
                    Color pixel = obtenerPixel(imagen, j, i);

                    if (pixel.ToString() == "Color [A=255, R=0, G=0, B=0]")
                    {
                        fila.Add(1);
                    }
                    else
                    {
                        fila.Add(0);
                    }
                }
                matriz.Add(fila);
                //respuesta += Environment.NewLine;
            }
            return matriz;
        }

        /// <summary>
        /// imprime el porocentaje de las letras
        /// </summary>
        /// <param name="porcentajes">porcentajes</param>
        private void imprimirLetra(double[] porcentajes)
        {
            double mayor = 0.0;
            int pos = 0;

            for (int i = 0; i < porcentajes.Length; i++)
            {
                if (mayor <= porcentajes[i])
                {
                    mayor = porcentajes[i];
                    pos = i;
                }
                
                Console.WriteLine(listaCaracteres[i] + " - " + porcentajes[i]);
            }
            lblResultado.Text += listaCaracteres[pos];
        }
    }
}