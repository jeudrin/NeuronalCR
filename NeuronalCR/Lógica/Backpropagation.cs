using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuronalCR.Class
{
    /// <summary>
    /// Clase para el algoritmo backpropagation
    /// </summary>
    public class Backpropagation
    {
        public int límiteIteraciones { set; get; }
        public string l;
        public double tasaDeAprendizaje { set; get; }
        public string ni;
        public List<Patron> patrones;
        public List<Neurona> neuronas;

        public bool catcha = false;
        
        /// <summary>
        /// Método que se encarga de obtener los datos de entrada hacia la red neuronal.
        /// </summary>
        /// <returns>datos de entrada de la red neuronal</returns>
        public List<List<double>> getEntries()
        {
            //Columnas de la tabla de entrada de datos.
            List<double> c1 = new List<double>();
            List<double> c2 = new List<double>();
            List<double> c3 = new List<double>();
            List<double> c4 = new List<double>();
            List<double> c5 = new List<double>();
            List<double> c6 = new List<double>();
            List<double> c7 = new List<double>();
            List<double> c8 = new List<double>();
            List<double> c9 = new List<double>();
            List<double> c10 = new List<double>();
            List<double> c11 = new List<double>();
            List<double> c12 = new List<double>();
            List<double> c13 = new List<double>();
            List<double> c14 = new List<double>();
            List<double> c15 = new List<double>();
            List<double> c16 = new List<double>();
            List<double> c17 = new List<double>();
            List<double> c18 = new List<double>();
            List<double> c19 = new List<double>();
            List<double> c20 = new List<double>();
            List<double> c21 = new List<double>();
            List<double> c22 = new List<double>();
            List<double> c23 = new List<double>();
            List<double> c24 = new List<double>();
            List<double> c25 = new List<double>();
            List<double> c26 = new List<double>();
            List<double> c27 = new List<double>();
            List<double> c28 = new List<double>();
            List<double> c29 = new List<double>();
            List<double> c30 = new List<double>();
            List<double> c31 = new List<double>();
            List<double> c32 = new List<double>();
            List<double> c33 = new List<double>();
            List<double> c34 = new List<double>();
            List<double> c35 = new List<double>();
            List<double> c36 = new List<double>();

            //Columnas de los datos de salida esperados
            List<double> c37 = new List<double>();
            List<double> c38 = new List<double>();
            List<double> c39 = new List<double>();
            List<double> c40 = new List<double>();
            List<double> c41 = new List<double>();
            List<double> c42 = new List<double>();

            List<double> p1 = new List<double>();
            List<double> p2 = new List<double>();
            List<double> p3 = new List<double>();
            List<double> p4 = new List<double>();
            List<double> p5 = new List<double>();
            List<double> p6 = new List<double>();
            List<double> p7 = new List<double>();
            List<double> p8 = new List<double>();
            List<double> p9 = new List<double>();
            List<double> p10 = new List<double>();
            List<double> p11 = new List<double>();
            List<double> p12 = new List<double>();
            List<double> p13 = new List<double>();
            List<double> p14 = new List<double>();
            List<double> p15 = new List<double>();
            List<double> p16 = new List<double>();
            List<double> p17 = new List<double>();
            List<double> p18 = new List<double>();
            List<double> p19 = new List<double>();
            List<double> p20 = new List<double>();
            List<double> p21 = new List<double>();
            List<double> p22 = new List<double>();
            List<double> p23 = new List<double>();
            List<double> p24 = new List<double>();
            List<double> p25 = new List<double>();
            List<double> p26 = new List<double>();
            List<double> p27 = new List<double>();
            List<double> p28 = new List<double>();
            List<double> p29 = new List<double>();
            List<double> p30 = new List<double>();
            List<double> p31 = new List<double>();
            List<double> p32 = new List<double>();
            List<double> p33 = new List<double>();
            List<double> p34 = new List<double>();
            List<double> p35 = new List<double>();
            List<double> p36 = new List<double>();

            List<List<double>> entries = new List<List<double>>();

            for (int j = 0; j < patrones.Count; j++)
            {
                for (int k = 0; k < (patrones.ElementAt(j).entradas.Count + patrones.ElementAt(j).salidas.Count); k++)
                {
                    //Con esto obtenemos los valores de los datos de entrada. (patrones)
                    if (k >= (patrones.ElementAt(j).entradas.Count + patrones.ElementAt(j).salidas.Count) - 6)
                    {
                        if (k == 36)
                        {
                            c37.Add(patrones.ElementAt(j).salidas.ElementAt(k-36).valorItem); //j y k van al reves creo.
                        }
                        else if (k == 37)
                        {
                            c38.Add(patrones.ElementAt(j).salidas.ElementAt(k-36).valorItem);
                        }
                        else if (k == 38)
                        {
                            c39.Add(patrones.ElementAt(j).salidas.ElementAt(k-36).valorItem);
                        }
                        else if (k == 39)
                        {
                            c40.Add(patrones.ElementAt(j).salidas.ElementAt(k-36).valorItem);
                        }
                        else if (k == 40)
                        {
                            c41.Add(patrones.ElementAt(j).salidas.ElementAt(k-36).valorItem);
                        }
                        else if (k == 41)
                        {
                            c42.Add(patrones.ElementAt(j).salidas.ElementAt(k-36).valorItem);
                        }
                    }
                    else
                    {
                        if (k == 0)
                        {
                            c1.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 1)
                        {
                            c2.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 2)
                        {
                            c3.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 3)
                        {
                            c4.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 4)
                        {
                            c5.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 5)
                        {
                            c6.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 6)
                        {
                            c7.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 7)
                        {
                            c8.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 8)
                        {
                            c9.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 9)
                        {
                            c10.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 10)
                        {
                            c11.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 11)
                        {
                            c12.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 12)
                        {
                            c13.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 13)
                        {
                            c14.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 14)
                        {
                            c15.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 15)
                        {
                            c16.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 16)
                        {
                            c17.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 17)
                        {
                            c18.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 18)
                        {
                            c19.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 19)
                        {
                            c20.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 20)
                        {
                            c21.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 21)
                        {
                            c22.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 22)
                        {
                            c23.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 23)
                        {
                            c24.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 24)
                        {
                            c25.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 25)
                        {
                            c26.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 26)
                        {
                            c27.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 27)
                        {
                            c28.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 28)
                        {
                            c29.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 29)
                        {
                            c30.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 30)
                        {
                            c31.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 31)
                        {
                            c32.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 32)
                        {
                            c33.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 33)
                        {
                            c34.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 34)
                        {
                            c35.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }                        
                        else if (k == 35)
                        {
                            c36.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                    }
                }
            }
           
            //Almacenamos los valores de entrada por orden de fila en listas de doubles.
            for (int w = 0; w < c1.Count; w++)
            {
                if (w == 0)
                {
                    p1.Add(c1.ElementAt(w));
                    p1.Add(c2.ElementAt(w));
                    p1.Add(c3.ElementAt(w));
                    p1.Add(c4.ElementAt(w));
                    p1.Add(c5.ElementAt(w));
                    p1.Add(c6.ElementAt(w));
                    p1.Add(c7.ElementAt(w));
                    p1.Add(c8.ElementAt(w));
                    p1.Add(c9.ElementAt(w));
                    p1.Add(c10.ElementAt(w));
                    p1.Add(c11.ElementAt(w));
                    p1.Add(c12.ElementAt(w));
                    p1.Add(c13.ElementAt(w));
                    p1.Add(c14.ElementAt(w));
                    p1.Add(c15.ElementAt(w));
                    p1.Add(c16.ElementAt(w));
                    p1.Add(c17.ElementAt(w));
                    p1.Add(c18.ElementAt(w));
                    p1.Add(c19.ElementAt(w));
                    p1.Add(c20.ElementAt(w));
                    p1.Add(c21.ElementAt(w));
                    p1.Add(c22.ElementAt(w));
                    p1.Add(c23.ElementAt(w));
                    p1.Add(c24.ElementAt(w));
                    p1.Add(c25.ElementAt(w));
                    p1.Add(c26.ElementAt(w));
                    p1.Add(c27.ElementAt(w));
                    p1.Add(c28.ElementAt(w));
                    p1.Add(c29.ElementAt(w));
                    p1.Add(c30.ElementAt(w));
                    p1.Add(c31.ElementAt(w));
                    p1.Add(c32.ElementAt(w));
                    p1.Add(c33.ElementAt(w));
                    p1.Add(c34.ElementAt(w));
                    p1.Add(c35.ElementAt(w));
                    p1.Add(c36.ElementAt(w));
                    p1.Add(c37.ElementAt(w));
                    p1.Add(c38.ElementAt(w));
                    p1.Add(c39.ElementAt(w));
                    p1.Add(c40.ElementAt(w));
                    p1.Add(c41.ElementAt(w));
                    p1.Add(c42.ElementAt(w));                    
                }
                else if (w == 1)
                {
                    p2.Add(c1.ElementAt(w));
                    p2.Add(c2.ElementAt(w));
                    p2.Add(c3.ElementAt(w));
                    p2.Add(c4.ElementAt(w));
                    p2.Add(c5.ElementAt(w));
                    p2.Add(c6.ElementAt(w));
                    p2.Add(c7.ElementAt(w));
                    p2.Add(c8.ElementAt(w));
                    p2.Add(c9.ElementAt(w));
                    p2.Add(c10.ElementAt(w));
                    p2.Add(c11.ElementAt(w));
                    p2.Add(c12.ElementAt(w));
                    p2.Add(c13.ElementAt(w));
                    p2.Add(c14.ElementAt(w));
                    p2.Add(c15.ElementAt(w));
                    p2.Add(c16.ElementAt(w));
                    p2.Add(c17.ElementAt(w));
                    p2.Add(c18.ElementAt(w));
                    p2.Add(c19.ElementAt(w));
                    p2.Add(c20.ElementAt(w));
                    p2.Add(c21.ElementAt(w));
                    p2.Add(c22.ElementAt(w));
                    p2.Add(c23.ElementAt(w));
                    p2.Add(c24.ElementAt(w));
                    p2.Add(c25.ElementAt(w));
                    p2.Add(c26.ElementAt(w));
                    p2.Add(c27.ElementAt(w));
                    p2.Add(c28.ElementAt(w));
                    p2.Add(c29.ElementAt(w));
                    p2.Add(c30.ElementAt(w));
                    p2.Add(c31.ElementAt(w));
                    p2.Add(c32.ElementAt(w));
                    p2.Add(c33.ElementAt(w));
                    p2.Add(c34.ElementAt(w));
                    p2.Add(c35.ElementAt(w));
                    p2.Add(c36.ElementAt(w));
                    p2.Add(c37.ElementAt(w));
                    p2.Add(c38.ElementAt(w));
                    p2.Add(c39.ElementAt(w));
                    p2.Add(c40.ElementAt(w));
                    p2.Add(c41.ElementAt(w));
                    p2.Add(c42.ElementAt(w));
                }
                else if (w == 2)
                {
                    p3.Add(c1.ElementAt(w));
                    p3.Add(c2.ElementAt(w));
                    p3.Add(c3.ElementAt(w));
                    p3.Add(c4.ElementAt(w));
                    p3.Add(c5.ElementAt(w));
                    p3.Add(c6.ElementAt(w));
                    p3.Add(c7.ElementAt(w));
                    p3.Add(c8.ElementAt(w));
                    p3.Add(c9.ElementAt(w));
                    p3.Add(c10.ElementAt(w));
                    p3.Add(c11.ElementAt(w));
                    p3.Add(c12.ElementAt(w));
                    p3.Add(c13.ElementAt(w));
                    p3.Add(c14.ElementAt(w));
                    p3.Add(c15.ElementAt(w));
                    p3.Add(c16.ElementAt(w));
                    p3.Add(c17.ElementAt(w));
                    p3.Add(c18.ElementAt(w));
                    p3.Add(c19.ElementAt(w));
                    p3.Add(c20.ElementAt(w));
                    p3.Add(c21.ElementAt(w));
                    p3.Add(c22.ElementAt(w));
                    p3.Add(c23.ElementAt(w));
                    p3.Add(c24.ElementAt(w));
                    p3.Add(c25.ElementAt(w));
                    p3.Add(c26.ElementAt(w));
                    p3.Add(c27.ElementAt(w));
                    p3.Add(c28.ElementAt(w));
                    p3.Add(c29.ElementAt(w));
                    p3.Add(c30.ElementAt(w));
                    p3.Add(c31.ElementAt(w));
                    p3.Add(c32.ElementAt(w));
                    p3.Add(c33.ElementAt(w));
                    p3.Add(c34.ElementAt(w));
                    p3.Add(c35.ElementAt(w));
                    p3.Add(c36.ElementAt(w));
                    p3.Add(c37.ElementAt(w));
                    p3.Add(c38.ElementAt(w));
                    p3.Add(c39.ElementAt(w));
                    p3.Add(c40.ElementAt(w));
                    p3.Add(c41.ElementAt(w));
                    p3.Add(c42.ElementAt(w));
                }
                else if (w == 3)
                {
                    p4.Add(c1.ElementAt(w));
                    p4.Add(c2.ElementAt(w));
                    p4.Add(c3.ElementAt(w));
                    p4.Add(c4.ElementAt(w));
                    p4.Add(c5.ElementAt(w));
                    p4.Add(c6.ElementAt(w));
                    p4.Add(c7.ElementAt(w));
                    p4.Add(c8.ElementAt(w));
                    p4.Add(c9.ElementAt(w));
                    p4.Add(c10.ElementAt(w));
                    p4.Add(c11.ElementAt(w));
                    p4.Add(c12.ElementAt(w));
                    p4.Add(c13.ElementAt(w));
                    p4.Add(c14.ElementAt(w));
                    p4.Add(c15.ElementAt(w));
                    p4.Add(c16.ElementAt(w));
                    p4.Add(c17.ElementAt(w));
                    p4.Add(c18.ElementAt(w));
                    p4.Add(c19.ElementAt(w));
                    p4.Add(c20.ElementAt(w));
                    p4.Add(c21.ElementAt(w));
                    p4.Add(c22.ElementAt(w));
                    p4.Add(c23.ElementAt(w));
                    p4.Add(c24.ElementAt(w));
                    p4.Add(c25.ElementAt(w));
                    p4.Add(c26.ElementAt(w));
                    p4.Add(c27.ElementAt(w));
                    p4.Add(c28.ElementAt(w));
                    p4.Add(c29.ElementAt(w));
                    p4.Add(c30.ElementAt(w));
                    p4.Add(c31.ElementAt(w));
                    p4.Add(c32.ElementAt(w));
                    p4.Add(c33.ElementAt(w));
                    p4.Add(c34.ElementAt(w));
                    p4.Add(c35.ElementAt(w));
                    p4.Add(c36.ElementAt(w));
                    p4.Add(c37.ElementAt(w));
                    p4.Add(c38.ElementAt(w));
                    p4.Add(c39.ElementAt(w));
                    p4.Add(c40.ElementAt(w));
                    p4.Add(c41.ElementAt(w));
                    p4.Add(c42.ElementAt(w));
                }
                else if (w == 4)
                {
                    p5.Add(c1.ElementAt(w));
                    p5.Add(c2.ElementAt(w));
                    p5.Add(c3.ElementAt(w));
                    p5.Add(c4.ElementAt(w));
                    p5.Add(c5.ElementAt(w));
                    p5.Add(c6.ElementAt(w));
                    p5.Add(c7.ElementAt(w));
                    p5.Add(c8.ElementAt(w));
                    p5.Add(c9.ElementAt(w));
                    p5.Add(c10.ElementAt(w));
                    p5.Add(c11.ElementAt(w));
                    p5.Add(c12.ElementAt(w));
                    p5.Add(c13.ElementAt(w));
                    p5.Add(c14.ElementAt(w));
                    p5.Add(c15.ElementAt(w));
                    p5.Add(c16.ElementAt(w));
                    p5.Add(c17.ElementAt(w));
                    p5.Add(c18.ElementAt(w));
                    p5.Add(c19.ElementAt(w));
                    p5.Add(c20.ElementAt(w));
                    p5.Add(c21.ElementAt(w));
                    p5.Add(c22.ElementAt(w));
                    p5.Add(c23.ElementAt(w));
                    p5.Add(c24.ElementAt(w));
                    p5.Add(c25.ElementAt(w));
                    p5.Add(c26.ElementAt(w));
                    p5.Add(c27.ElementAt(w));
                    p5.Add(c28.ElementAt(w));
                    p5.Add(c29.ElementAt(w));
                    p5.Add(c30.ElementAt(w));
                    p5.Add(c31.ElementAt(w));
                    p5.Add(c32.ElementAt(w));
                    p5.Add(c33.ElementAt(w));
                    p5.Add(c34.ElementAt(w));
                    p5.Add(c35.ElementAt(w));
                    p5.Add(c36.ElementAt(w));
                    p5.Add(c37.ElementAt(w));
                    p5.Add(c38.ElementAt(w));
                    p5.Add(c39.ElementAt(w));
                    p5.Add(c40.ElementAt(w));
                    p5.Add(c41.ElementAt(w));
                    p5.Add(c42.ElementAt(w));
                }
                else if (w == 5)
                {
                    p6.Add(c1.ElementAt(w));
                    p6.Add(c2.ElementAt(w));
                    p6.Add(c3.ElementAt(w));
                    p6.Add(c4.ElementAt(w));
                    p6.Add(c5.ElementAt(w));
                    p6.Add(c6.ElementAt(w));
                    p6.Add(c7.ElementAt(w));
                    p6.Add(c8.ElementAt(w));
                    p6.Add(c9.ElementAt(w));
                    p6.Add(c10.ElementAt(w));
                    p6.Add(c11.ElementAt(w));
                    p6.Add(c12.ElementAt(w));
                    p6.Add(c13.ElementAt(w));
                    p6.Add(c14.ElementAt(w));
                    p6.Add(c15.ElementAt(w));
                    p6.Add(c16.ElementAt(w));
                    p6.Add(c17.ElementAt(w));
                    p6.Add(c18.ElementAt(w));
                    p6.Add(c19.ElementAt(w));
                    p6.Add(c20.ElementAt(w));
                    p6.Add(c21.ElementAt(w));
                    p6.Add(c22.ElementAt(w));
                    p6.Add(c23.ElementAt(w));
                    p6.Add(c24.ElementAt(w));
                    p6.Add(c25.ElementAt(w));
                    p6.Add(c26.ElementAt(w));
                    p6.Add(c27.ElementAt(w));
                    p6.Add(c28.ElementAt(w));
                    p6.Add(c29.ElementAt(w));
                    p6.Add(c30.ElementAt(w));
                    p6.Add(c31.ElementAt(w));
                    p6.Add(c32.ElementAt(w));
                    p6.Add(c33.ElementAt(w));
                    p6.Add(c34.ElementAt(w));
                    p6.Add(c35.ElementAt(w));
                    p6.Add(c36.ElementAt(w));
                    p6.Add(c37.ElementAt(w));
                    p6.Add(c38.ElementAt(w));
                    p6.Add(c39.ElementAt(w));
                    p6.Add(c40.ElementAt(w));
                    p6.Add(c41.ElementAt(w));
                    p6.Add(c42.ElementAt(w));
                }
                else if (w == 6)
                {
                    p7.Add(c1.ElementAt(w));
                    p7.Add(c2.ElementAt(w));
                    p7.Add(c3.ElementAt(w));
                    p7.Add(c4.ElementAt(w));
                    p7.Add(c5.ElementAt(w));
                    p7.Add(c6.ElementAt(w));
                    p7.Add(c7.ElementAt(w));
                    p7.Add(c8.ElementAt(w));
                    p7.Add(c9.ElementAt(w));
                    p7.Add(c10.ElementAt(w));
                    p7.Add(c11.ElementAt(w));
                    p7.Add(c12.ElementAt(w));
                    p7.Add(c13.ElementAt(w));
                    p7.Add(c14.ElementAt(w));
                    p7.Add(c15.ElementAt(w));
                    p7.Add(c16.ElementAt(w));
                    p7.Add(c17.ElementAt(w));
                    p7.Add(c18.ElementAt(w));
                    p7.Add(c19.ElementAt(w));
                    p7.Add(c20.ElementAt(w));
                    p7.Add(c21.ElementAt(w));
                    p7.Add(c22.ElementAt(w));
                    p7.Add(c23.ElementAt(w));
                    p7.Add(c24.ElementAt(w));
                    p7.Add(c25.ElementAt(w));
                    p7.Add(c26.ElementAt(w));
                    p7.Add(c27.ElementAt(w));
                    p7.Add(c28.ElementAt(w));
                    p7.Add(c29.ElementAt(w));
                    p7.Add(c30.ElementAt(w));
                    p7.Add(c31.ElementAt(w));
                    p7.Add(c32.ElementAt(w));
                    p7.Add(c33.ElementAt(w));
                    p7.Add(c34.ElementAt(w));
                    p7.Add(c35.ElementAt(w));
                    p7.Add(c36.ElementAt(w));
                    p7.Add(c37.ElementAt(w));
                    p7.Add(c38.ElementAt(w));
                    p7.Add(c39.ElementAt(w));
                    p7.Add(c40.ElementAt(w));
                    p7.Add(c41.ElementAt(w));
                    p7.Add(c42.ElementAt(w));
                }
                else if (w == 7)
                {
                    p8.Add(c1.ElementAt(w));
                    p8.Add(c2.ElementAt(w));
                    p8.Add(c3.ElementAt(w));
                    p8.Add(c4.ElementAt(w));
                    p8.Add(c5.ElementAt(w));
                    p8.Add(c6.ElementAt(w));
                    p8.Add(c7.ElementAt(w));
                    p8.Add(c8.ElementAt(w));
                    p8.Add(c9.ElementAt(w));
                    p8.Add(c10.ElementAt(w));
                    p8.Add(c11.ElementAt(w));
                    p8.Add(c12.ElementAt(w));
                    p8.Add(c13.ElementAt(w));
                    p8.Add(c14.ElementAt(w));
                    p8.Add(c15.ElementAt(w));
                    p8.Add(c16.ElementAt(w));
                    p8.Add(c17.ElementAt(w));
                    p8.Add(c18.ElementAt(w));
                    p8.Add(c19.ElementAt(w));
                    p8.Add(c20.ElementAt(w));
                    p8.Add(c21.ElementAt(w));
                    p8.Add(c22.ElementAt(w));
                    p8.Add(c23.ElementAt(w));
                    p8.Add(c24.ElementAt(w));
                    p8.Add(c25.ElementAt(w));
                    p8.Add(c26.ElementAt(w));
                    p8.Add(c27.ElementAt(w));
                    p8.Add(c28.ElementAt(w));
                    p8.Add(c29.ElementAt(w));
                    p8.Add(c30.ElementAt(w));
                    p8.Add(c31.ElementAt(w));
                    p8.Add(c32.ElementAt(w));
                    p8.Add(c33.ElementAt(w));
                    p8.Add(c34.ElementAt(w));
                    p8.Add(c35.ElementAt(w));
                    p8.Add(c36.ElementAt(w));
                    p8.Add(c37.ElementAt(w));
                    p8.Add(c38.ElementAt(w));
                    p8.Add(c39.ElementAt(w));
                    p8.Add(c40.ElementAt(w));
                    p8.Add(c41.ElementAt(w));
                    p8.Add(c42.ElementAt(w));
                }
                else if (w == 8)
                {
                    p9.Add(c1.ElementAt(w));
                    p9.Add(c2.ElementAt(w));
                    p9.Add(c3.ElementAt(w));
                    p9.Add(c4.ElementAt(w));
                    p9.Add(c5.ElementAt(w));
                    p9.Add(c6.ElementAt(w));
                    p9.Add(c7.ElementAt(w));
                    p9.Add(c8.ElementAt(w));
                    p9.Add(c9.ElementAt(w));
                    p9.Add(c10.ElementAt(w));
                    p9.Add(c11.ElementAt(w));
                    p9.Add(c12.ElementAt(w));
                    p9.Add(c13.ElementAt(w));
                    p9.Add(c14.ElementAt(w));
                    p9.Add(c15.ElementAt(w));
                    p9.Add(c16.ElementAt(w));
                    p9.Add(c17.ElementAt(w));
                    p9.Add(c18.ElementAt(w));
                    p9.Add(c19.ElementAt(w));
                    p9.Add(c20.ElementAt(w));
                    p9.Add(c21.ElementAt(w));
                    p9.Add(c22.ElementAt(w));
                    p9.Add(c23.ElementAt(w));
                    p9.Add(c24.ElementAt(w));
                    p9.Add(c25.ElementAt(w));
                    p9.Add(c26.ElementAt(w));
                    p9.Add(c27.ElementAt(w));
                    p9.Add(c28.ElementAt(w));
                    p9.Add(c29.ElementAt(w));
                    p9.Add(c30.ElementAt(w));
                    p9.Add(c31.ElementAt(w));
                    p9.Add(c32.ElementAt(w));
                    p9.Add(c33.ElementAt(w));
                    p9.Add(c34.ElementAt(w));
                    p9.Add(c35.ElementAt(w));
                    p9.Add(c36.ElementAt(w));
                    p9.Add(c37.ElementAt(w));
                    p9.Add(c38.ElementAt(w));
                    p9.Add(c39.ElementAt(w));
                    p9.Add(c40.ElementAt(w));
                    p9.Add(c41.ElementAt(w));
                    p9.Add(c42.ElementAt(w));
                }
                else if (w == 9)
                {
                    p10.Add(c1.ElementAt(w));
                    p10.Add(c2.ElementAt(w));
                    p10.Add(c3.ElementAt(w));
                    p10.Add(c4.ElementAt(w));
                    p10.Add(c5.ElementAt(w));
                    p10.Add(c6.ElementAt(w));
                    p10.Add(c7.ElementAt(w));
                    p10.Add(c8.ElementAt(w));
                    p10.Add(c9.ElementAt(w));
                    p10.Add(c10.ElementAt(w));
                    p10.Add(c11.ElementAt(w));
                    p10.Add(c12.ElementAt(w));
                    p10.Add(c13.ElementAt(w));
                    p10.Add(c14.ElementAt(w));
                    p10.Add(c15.ElementAt(w));
                    p10.Add(c16.ElementAt(w));
                    p10.Add(c17.ElementAt(w));
                    p10.Add(c18.ElementAt(w));
                    p10.Add(c19.ElementAt(w));
                    p10.Add(c20.ElementAt(w));
                    p10.Add(c21.ElementAt(w));
                    p10.Add(c22.ElementAt(w));
                    p10.Add(c23.ElementAt(w));
                    p10.Add(c24.ElementAt(w));
                    p10.Add(c25.ElementAt(w));
                    p10.Add(c26.ElementAt(w));
                    p10.Add(c27.ElementAt(w));
                    p10.Add(c28.ElementAt(w));
                    p10.Add(c29.ElementAt(w));
                    p10.Add(c30.ElementAt(w));
                    p10.Add(c31.ElementAt(w));
                    p10.Add(c32.ElementAt(w));
                    p10.Add(c33.ElementAt(w));
                    p10.Add(c34.ElementAt(w));
                    p10.Add(c35.ElementAt(w));
                    p10.Add(c36.ElementAt(w));
                    p10.Add(c37.ElementAt(w));
                    p10.Add(c38.ElementAt(w));
                    p10.Add(c39.ElementAt(w));
                    p10.Add(c40.ElementAt(w));
                    p10.Add(c41.ElementAt(w));
                    p10.Add(c42.ElementAt(w));
                }
                else if (w == 10)
                {
                    p11.Add(c1.ElementAt(w));
                    p11.Add(c2.ElementAt(w));
                    p11.Add(c3.ElementAt(w));
                    p11.Add(c4.ElementAt(w));
                    p11.Add(c5.ElementAt(w));
                    p11.Add(c6.ElementAt(w));
                    p11.Add(c7.ElementAt(w));
                    p11.Add(c8.ElementAt(w));
                    p11.Add(c9.ElementAt(w));
                    p11.Add(c10.ElementAt(w));
                    p11.Add(c11.ElementAt(w));
                    p11.Add(c12.ElementAt(w));
                    p11.Add(c13.ElementAt(w));
                    p11.Add(c14.ElementAt(w));
                    p11.Add(c15.ElementAt(w));
                    p11.Add(c16.ElementAt(w));
                    p11.Add(c17.ElementAt(w));
                    p11.Add(c18.ElementAt(w));
                    p11.Add(c19.ElementAt(w));
                    p11.Add(c20.ElementAt(w));
                    p11.Add(c21.ElementAt(w));
                    p11.Add(c22.ElementAt(w));
                    p11.Add(c23.ElementAt(w));
                    p11.Add(c24.ElementAt(w));
                    p11.Add(c25.ElementAt(w));
                    p11.Add(c26.ElementAt(w));
                    p11.Add(c27.ElementAt(w));
                    p11.Add(c28.ElementAt(w));
                    p11.Add(c29.ElementAt(w));
                    p11.Add(c30.ElementAt(w));
                    p11.Add(c31.ElementAt(w));
                    p11.Add(c32.ElementAt(w));
                    p11.Add(c33.ElementAt(w));
                    p11.Add(c34.ElementAt(w));
                    p11.Add(c35.ElementAt(w));
                    p11.Add(c36.ElementAt(w));
                    p11.Add(c37.ElementAt(w));
                    p11.Add(c38.ElementAt(w));
                    p11.Add(c39.ElementAt(w));
                    p11.Add(c40.ElementAt(w));
                    p11.Add(c41.ElementAt(w));
                    p11.Add(c42.ElementAt(w));
                }
                else if (w == 11)
                {
                    p12.Add(c1.ElementAt(w));
                    p12.Add(c2.ElementAt(w));
                    p12.Add(c3.ElementAt(w));
                    p12.Add(c4.ElementAt(w));
                    p12.Add(c5.ElementAt(w));
                    p12.Add(c6.ElementAt(w));
                    p12.Add(c7.ElementAt(w));
                    p12.Add(c8.ElementAt(w));
                    p12.Add(c9.ElementAt(w));
                    p12.Add(c10.ElementAt(w));
                    p12.Add(c11.ElementAt(w));
                    p12.Add(c12.ElementAt(w));
                    p12.Add(c13.ElementAt(w));
                    p12.Add(c14.ElementAt(w));
                    p12.Add(c15.ElementAt(w));
                    p12.Add(c16.ElementAt(w));
                    p12.Add(c17.ElementAt(w));
                    p12.Add(c18.ElementAt(w));
                    p12.Add(c19.ElementAt(w));
                    p12.Add(c20.ElementAt(w));
                    p12.Add(c21.ElementAt(w));
                    p12.Add(c22.ElementAt(w));
                    p12.Add(c23.ElementAt(w));
                    p12.Add(c24.ElementAt(w));
                    p12.Add(c25.ElementAt(w));
                    p12.Add(c26.ElementAt(w));
                    p12.Add(c27.ElementAt(w));
                    p12.Add(c28.ElementAt(w));
                    p12.Add(c29.ElementAt(w));
                    p12.Add(c30.ElementAt(w));
                    p12.Add(c31.ElementAt(w));
                    p12.Add(c32.ElementAt(w));
                    p12.Add(c33.ElementAt(w));
                    p12.Add(c34.ElementAt(w));
                    p12.Add(c35.ElementAt(w));
                    p12.Add(c36.ElementAt(w));
                    p12.Add(c37.ElementAt(w));
                    p12.Add(c38.ElementAt(w));
                    p12.Add(c39.ElementAt(w));
                    p12.Add(c40.ElementAt(w));
                    p12.Add(c41.ElementAt(w));
                    p12.Add(c42.ElementAt(w));
                }
                else if (w == 12)
                {
                    p13.Add(c1.ElementAt(w));
                    p13.Add(c2.ElementAt(w));
                    p13.Add(c3.ElementAt(w));
                    p13.Add(c4.ElementAt(w));
                    p13.Add(c5.ElementAt(w));
                    p13.Add(c6.ElementAt(w));
                    p13.Add(c7.ElementAt(w));
                    p13.Add(c8.ElementAt(w));
                    p13.Add(c9.ElementAt(w));
                    p13.Add(c10.ElementAt(w));
                    p13.Add(c11.ElementAt(w));
                    p13.Add(c12.ElementAt(w));
                    p13.Add(c13.ElementAt(w));
                    p13.Add(c14.ElementAt(w));
                    p13.Add(c15.ElementAt(w));
                    p13.Add(c16.ElementAt(w));
                    p13.Add(c17.ElementAt(w));
                    p13.Add(c18.ElementAt(w));
                    p13.Add(c19.ElementAt(w));
                    p13.Add(c20.ElementAt(w));
                    p13.Add(c21.ElementAt(w));
                    p13.Add(c22.ElementAt(w));
                    p13.Add(c23.ElementAt(w));
                    p13.Add(c24.ElementAt(w));
                    p13.Add(c25.ElementAt(w));
                    p13.Add(c26.ElementAt(w));
                    p13.Add(c27.ElementAt(w));
                    p13.Add(c28.ElementAt(w));
                    p13.Add(c29.ElementAt(w));
                    p13.Add(c30.ElementAt(w));
                    p13.Add(c31.ElementAt(w));
                    p13.Add(c32.ElementAt(w));
                    p13.Add(c33.ElementAt(w));
                    p13.Add(c34.ElementAt(w));
                    p13.Add(c35.ElementAt(w));
                    p13.Add(c36.ElementAt(w));
                    p13.Add(c37.ElementAt(w));
                    p13.Add(c38.ElementAt(w));
                    p13.Add(c39.ElementAt(w));
                    p13.Add(c40.ElementAt(w));
                    p13.Add(c41.ElementAt(w));
                    p13.Add(c42.ElementAt(w));
                }
                else if (w == 13)
                {
                    p14.Add(c1.ElementAt(w));
                    p14.Add(c2.ElementAt(w));
                    p14.Add(c3.ElementAt(w));
                    p14.Add(c4.ElementAt(w));
                    p14.Add(c5.ElementAt(w));
                    p14.Add(c6.ElementAt(w));
                    p14.Add(c7.ElementAt(w));
                    p14.Add(c8.ElementAt(w));
                    p14.Add(c9.ElementAt(w));
                    p14.Add(c10.ElementAt(w));
                    p14.Add(c11.ElementAt(w));
                    p14.Add(c12.ElementAt(w));
                    p14.Add(c13.ElementAt(w));
                    p14.Add(c14.ElementAt(w));
                    p14.Add(c15.ElementAt(w));
                    p14.Add(c16.ElementAt(w));
                    p14.Add(c17.ElementAt(w));
                    p14.Add(c18.ElementAt(w));
                    p14.Add(c19.ElementAt(w));
                    p14.Add(c20.ElementAt(w));
                    p14.Add(c21.ElementAt(w));
                    p14.Add(c22.ElementAt(w));
                    p14.Add(c23.ElementAt(w));
                    p14.Add(c24.ElementAt(w));
                    p14.Add(c25.ElementAt(w));
                    p14.Add(c26.ElementAt(w));
                    p14.Add(c27.ElementAt(w));
                    p14.Add(c28.ElementAt(w));
                    p14.Add(c29.ElementAt(w));
                    p14.Add(c30.ElementAt(w));
                    p14.Add(c31.ElementAt(w));
                    p14.Add(c32.ElementAt(w));
                    p14.Add(c33.ElementAt(w));
                    p14.Add(c34.ElementAt(w));
                    p14.Add(c35.ElementAt(w));
                    p14.Add(c36.ElementAt(w));
                    p14.Add(c37.ElementAt(w));
                    p14.Add(c38.ElementAt(w));
                    p14.Add(c39.ElementAt(w));
                    p14.Add(c40.ElementAt(w));
                    p14.Add(c41.ElementAt(w));
                    p14.Add(c42.ElementAt(w));
                }
                else if (w == 14)
                {
                    p15.Add(c1.ElementAt(w));
                    p15.Add(c2.ElementAt(w));
                    p15.Add(c3.ElementAt(w));
                    p15.Add(c4.ElementAt(w));
                    p15.Add(c5.ElementAt(w));
                    p15.Add(c6.ElementAt(w));
                    p15.Add(c7.ElementAt(w));
                    p15.Add(c8.ElementAt(w));
                    p15.Add(c9.ElementAt(w));
                    p15.Add(c10.ElementAt(w));
                    p15.Add(c11.ElementAt(w));
                    p15.Add(c12.ElementAt(w));
                    p15.Add(c13.ElementAt(w));
                    p15.Add(c14.ElementAt(w));
                    p15.Add(c15.ElementAt(w));
                    p15.Add(c16.ElementAt(w));
                    p15.Add(c17.ElementAt(w));
                    p15.Add(c18.ElementAt(w));
                    p15.Add(c19.ElementAt(w));
                    p15.Add(c20.ElementAt(w));
                    p15.Add(c21.ElementAt(w));
                    p15.Add(c22.ElementAt(w));
                    p15.Add(c23.ElementAt(w));
                    p15.Add(c24.ElementAt(w));
                    p15.Add(c25.ElementAt(w));
                    p15.Add(c26.ElementAt(w));
                    p15.Add(c27.ElementAt(w));
                    p15.Add(c28.ElementAt(w));
                    p15.Add(c29.ElementAt(w));
                    p15.Add(c30.ElementAt(w));
                    p15.Add(c31.ElementAt(w));
                    p15.Add(c32.ElementAt(w));
                    p15.Add(c33.ElementAt(w));
                    p15.Add(c34.ElementAt(w));
                    p15.Add(c35.ElementAt(w));
                    p15.Add(c36.ElementAt(w));
                    p15.Add(c37.ElementAt(w));
                    p15.Add(c38.ElementAt(w));
                    p15.Add(c39.ElementAt(w));
                    p15.Add(c40.ElementAt(w));
                    p15.Add(c41.ElementAt(w));
                    p15.Add(c42.ElementAt(w));
                }
                else if (w == 15)
                {
                    p16.Add(c1.ElementAt(w));
                    p16.Add(c2.ElementAt(w));
                    p16.Add(c3.ElementAt(w));
                    p16.Add(c4.ElementAt(w));
                    p16.Add(c5.ElementAt(w));
                    p16.Add(c6.ElementAt(w));
                    p16.Add(c7.ElementAt(w));
                    p16.Add(c8.ElementAt(w));
                    p16.Add(c9.ElementAt(w));
                    p16.Add(c10.ElementAt(w));
                    p16.Add(c11.ElementAt(w));
                    p16.Add(c12.ElementAt(w));
                    p16.Add(c13.ElementAt(w));
                    p16.Add(c14.ElementAt(w));
                    p16.Add(c15.ElementAt(w));
                    p16.Add(c16.ElementAt(w));
                    p16.Add(c17.ElementAt(w));
                    p16.Add(c18.ElementAt(w));
                    p16.Add(c19.ElementAt(w));
                    p16.Add(c20.ElementAt(w));
                    p16.Add(c21.ElementAt(w));
                    p16.Add(c22.ElementAt(w));
                    p16.Add(c23.ElementAt(w));
                    p16.Add(c24.ElementAt(w));
                    p16.Add(c25.ElementAt(w));
                    p16.Add(c26.ElementAt(w));
                    p16.Add(c27.ElementAt(w));
                    p16.Add(c28.ElementAt(w));
                    p16.Add(c29.ElementAt(w));
                    p16.Add(c30.ElementAt(w));
                    p16.Add(c31.ElementAt(w));
                    p16.Add(c32.ElementAt(w));
                    p16.Add(c33.ElementAt(w));
                    p16.Add(c34.ElementAt(w));
                    p16.Add(c35.ElementAt(w));
                    p16.Add(c36.ElementAt(w));
                    p16.Add(c37.ElementAt(w));
                    p16.Add(c38.ElementAt(w));
                    p16.Add(c39.ElementAt(w));
                    p16.Add(c40.ElementAt(w));
                    p16.Add(c41.ElementAt(w));
                    p16.Add(c42.ElementAt(w));
                }
                else if (w == 16)
                {
                    p17.Add(c1.ElementAt(w));
                    p17.Add(c2.ElementAt(w));
                    p17.Add(c3.ElementAt(w));
                    p17.Add(c4.ElementAt(w));
                    p17.Add(c5.ElementAt(w));
                    p17.Add(c6.ElementAt(w));
                    p17.Add(c7.ElementAt(w));
                    p17.Add(c8.ElementAt(w));
                    p17.Add(c9.ElementAt(w));
                    p17.Add(c10.ElementAt(w));
                    p17.Add(c11.ElementAt(w));
                    p17.Add(c12.ElementAt(w));
                    p17.Add(c13.ElementAt(w));
                    p17.Add(c14.ElementAt(w));
                    p17.Add(c15.ElementAt(w));
                    p17.Add(c16.ElementAt(w));
                    p17.Add(c17.ElementAt(w));
                    p17.Add(c18.ElementAt(w));
                    p17.Add(c19.ElementAt(w));
                    p17.Add(c20.ElementAt(w));
                    p17.Add(c21.ElementAt(w));
                    p17.Add(c22.ElementAt(w));
                    p17.Add(c23.ElementAt(w));
                    p17.Add(c24.ElementAt(w));
                    p17.Add(c25.ElementAt(w));
                    p17.Add(c26.ElementAt(w));
                    p17.Add(c27.ElementAt(w));
                    p17.Add(c28.ElementAt(w));
                    p17.Add(c29.ElementAt(w));
                    p17.Add(c30.ElementAt(w));
                    p17.Add(c31.ElementAt(w));
                    p17.Add(c32.ElementAt(w));
                    p17.Add(c33.ElementAt(w));
                    p17.Add(c34.ElementAt(w));
                    p17.Add(c35.ElementAt(w));
                    p17.Add(c36.ElementAt(w));
                    p17.Add(c37.ElementAt(w));
                    p17.Add(c38.ElementAt(w));
                    p17.Add(c39.ElementAt(w));
                    p17.Add(c40.ElementAt(w));
                    p17.Add(c41.ElementAt(w));
                    p17.Add(c42.ElementAt(w));
                }
                else if (w == 17)
                {
                    p18.Add(c1.ElementAt(w));
                    p18.Add(c2.ElementAt(w));
                    p18.Add(c3.ElementAt(w));
                    p18.Add(c4.ElementAt(w));
                    p18.Add(c5.ElementAt(w));
                    p18.Add(c6.ElementAt(w));
                    p18.Add(c7.ElementAt(w));
                    p18.Add(c8.ElementAt(w));
                    p18.Add(c9.ElementAt(w));
                    p18.Add(c10.ElementAt(w));
                    p18.Add(c11.ElementAt(w));
                    p18.Add(c12.ElementAt(w));
                    p18.Add(c13.ElementAt(w));
                    p18.Add(c14.ElementAt(w));
                    p18.Add(c15.ElementAt(w));
                    p18.Add(c16.ElementAt(w));
                    p18.Add(c17.ElementAt(w));
                    p18.Add(c18.ElementAt(w));
                    p18.Add(c19.ElementAt(w));
                    p18.Add(c20.ElementAt(w));
                    p18.Add(c21.ElementAt(w));
                    p18.Add(c22.ElementAt(w));
                    p18.Add(c23.ElementAt(w));
                    p18.Add(c24.ElementAt(w));
                    p18.Add(c25.ElementAt(w));
                    p18.Add(c26.ElementAt(w));
                    p18.Add(c27.ElementAt(w));
                    p18.Add(c28.ElementAt(w));
                    p18.Add(c29.ElementAt(w));
                    p18.Add(c30.ElementAt(w));
                    p18.Add(c31.ElementAt(w));
                    p18.Add(c32.ElementAt(w));
                    p18.Add(c33.ElementAt(w));
                    p18.Add(c34.ElementAt(w));
                    p18.Add(c35.ElementAt(w));
                    p18.Add(c36.ElementAt(w));
                    p18.Add(c37.ElementAt(w));
                    p18.Add(c38.ElementAt(w));
                    p18.Add(c39.ElementAt(w));
                    p18.Add(c40.ElementAt(w));
                    p18.Add(c41.ElementAt(w));
                    p18.Add(c42.ElementAt(w));
                }
                else if (w == 18)
                {
                    p19.Add(c1.ElementAt(w));
                    p19.Add(c2.ElementAt(w));
                    p19.Add(c3.ElementAt(w));
                    p19.Add(c4.ElementAt(w));
                    p19.Add(c5.ElementAt(w));
                    p19.Add(c6.ElementAt(w));
                    p19.Add(c7.ElementAt(w));
                    p19.Add(c8.ElementAt(w));
                    p19.Add(c9.ElementAt(w));
                    p19.Add(c10.ElementAt(w));
                    p19.Add(c11.ElementAt(w));
                    p19.Add(c12.ElementAt(w));
                    p19.Add(c13.ElementAt(w));
                    p19.Add(c14.ElementAt(w));
                    p19.Add(c15.ElementAt(w));
                    p19.Add(c16.ElementAt(w));
                    p19.Add(c17.ElementAt(w));
                    p19.Add(c18.ElementAt(w));
                    p19.Add(c19.ElementAt(w));
                    p19.Add(c20.ElementAt(w));
                    p19.Add(c21.ElementAt(w));
                    p19.Add(c22.ElementAt(w));
                    p19.Add(c23.ElementAt(w));
                    p19.Add(c24.ElementAt(w));
                    p19.Add(c25.ElementAt(w));
                    p19.Add(c26.ElementAt(w));
                    p19.Add(c27.ElementAt(w));
                    p19.Add(c28.ElementAt(w));
                    p19.Add(c29.ElementAt(w));
                    p19.Add(c30.ElementAt(w));
                    p19.Add(c31.ElementAt(w));
                    p19.Add(c32.ElementAt(w));
                    p19.Add(c33.ElementAt(w));
                    p19.Add(c34.ElementAt(w));
                    p19.Add(c35.ElementAt(w));
                    p19.Add(c36.ElementAt(w));
                    p19.Add(c37.ElementAt(w));
                    p19.Add(c38.ElementAt(w));
                    p19.Add(c39.ElementAt(w));
                    p19.Add(c40.ElementAt(w));
                    p19.Add(c41.ElementAt(w));
                    p19.Add(c42.ElementAt(w));
                }
                else if (w == 19)
                {
                    p20.Add(c1.ElementAt(w));
                    p20.Add(c2.ElementAt(w));
                    p20.Add(c3.ElementAt(w));
                    p20.Add(c4.ElementAt(w));
                    p20.Add(c5.ElementAt(w));
                    p20.Add(c6.ElementAt(w));
                    p20.Add(c7.ElementAt(w));
                    p20.Add(c8.ElementAt(w));
                    p20.Add(c9.ElementAt(w));
                    p20.Add(c10.ElementAt(w));
                    p20.Add(c11.ElementAt(w));
                    p20.Add(c12.ElementAt(w));
                    p20.Add(c13.ElementAt(w));
                    p20.Add(c14.ElementAt(w));
                    p20.Add(c15.ElementAt(w));
                    p20.Add(c16.ElementAt(w));
                    p20.Add(c17.ElementAt(w));
                    p20.Add(c18.ElementAt(w));
                    p20.Add(c19.ElementAt(w));
                    p20.Add(c20.ElementAt(w));
                    p20.Add(c21.ElementAt(w));
                    p20.Add(c22.ElementAt(w));
                    p20.Add(c23.ElementAt(w));
                    p20.Add(c24.ElementAt(w));
                    p20.Add(c25.ElementAt(w));
                    p20.Add(c26.ElementAt(w));
                    p20.Add(c27.ElementAt(w));
                    p20.Add(c28.ElementAt(w));
                    p20.Add(c29.ElementAt(w));
                    p20.Add(c30.ElementAt(w));
                    p20.Add(c31.ElementAt(w));
                    p20.Add(c32.ElementAt(w));
                    p20.Add(c33.ElementAt(w));
                    p20.Add(c34.ElementAt(w));
                    p20.Add(c35.ElementAt(w));
                    p20.Add(c36.ElementAt(w));
                    p20.Add(c37.ElementAt(w));
                    p20.Add(c38.ElementAt(w));
                    p20.Add(c39.ElementAt(w));
                    p20.Add(c40.ElementAt(w));
                    p20.Add(c41.ElementAt(w));
                    p20.Add(c42.ElementAt(w));
                }
                else if (w == 20)
                {
                    p21.Add(c1.ElementAt(w));
                    p21.Add(c2.ElementAt(w));
                    p21.Add(c3.ElementAt(w));
                    p21.Add(c4.ElementAt(w));
                    p21.Add(c5.ElementAt(w));
                    p21.Add(c6.ElementAt(w));
                    p21.Add(c7.ElementAt(w));
                    p21.Add(c8.ElementAt(w));
                    p21.Add(c9.ElementAt(w));
                    p21.Add(c10.ElementAt(w));
                    p21.Add(c11.ElementAt(w));
                    p21.Add(c12.ElementAt(w));
                    p21.Add(c13.ElementAt(w));
                    p21.Add(c14.ElementAt(w));
                    p21.Add(c15.ElementAt(w));
                    p21.Add(c16.ElementAt(w));
                    p21.Add(c17.ElementAt(w));
                    p21.Add(c18.ElementAt(w));
                    p21.Add(c19.ElementAt(w));
                    p21.Add(c20.ElementAt(w));
                    p21.Add(c21.ElementAt(w));
                    p21.Add(c22.ElementAt(w));
                    p21.Add(c23.ElementAt(w));
                    p21.Add(c24.ElementAt(w));
                    p21.Add(c25.ElementAt(w));
                    p21.Add(c26.ElementAt(w));
                    p21.Add(c27.ElementAt(w));
                    p21.Add(c28.ElementAt(w));
                    p21.Add(c29.ElementAt(w));
                    p21.Add(c30.ElementAt(w));
                    p21.Add(c31.ElementAt(w));
                    p21.Add(c32.ElementAt(w));
                    p21.Add(c33.ElementAt(w));
                    p21.Add(c34.ElementAt(w));
                    p21.Add(c35.ElementAt(w));
                    p21.Add(c36.ElementAt(w));
                    p21.Add(c37.ElementAt(w));
                    p21.Add(c38.ElementAt(w));
                    p21.Add(c39.ElementAt(w));
                    p21.Add(c40.ElementAt(w));
                    p21.Add(c41.ElementAt(w));
                    p21.Add(c42.ElementAt(w));
                }
                else if (w == 21)
                {
                    p22.Add(c1.ElementAt(w));
                    p22.Add(c2.ElementAt(w));
                    p22.Add(c3.ElementAt(w));
                    p22.Add(c4.ElementAt(w));
                    p22.Add(c5.ElementAt(w));
                    p22.Add(c6.ElementAt(w));
                    p22.Add(c7.ElementAt(w));
                    p22.Add(c8.ElementAt(w));
                    p22.Add(c9.ElementAt(w));
                    p22.Add(c10.ElementAt(w));
                    p22.Add(c11.ElementAt(w));
                    p22.Add(c12.ElementAt(w));
                    p22.Add(c13.ElementAt(w));
                    p22.Add(c14.ElementAt(w));
                    p22.Add(c15.ElementAt(w));
                    p22.Add(c16.ElementAt(w));
                    p22.Add(c17.ElementAt(w));
                    p22.Add(c18.ElementAt(w));
                    p22.Add(c19.ElementAt(w));
                    p22.Add(c20.ElementAt(w));
                    p22.Add(c21.ElementAt(w));
                    p22.Add(c22.ElementAt(w));
                    p22.Add(c23.ElementAt(w));
                    p22.Add(c24.ElementAt(w));
                    p22.Add(c25.ElementAt(w));
                    p22.Add(c26.ElementAt(w));
                    p22.Add(c27.ElementAt(w));
                    p22.Add(c28.ElementAt(w));
                    p22.Add(c29.ElementAt(w));
                    p22.Add(c30.ElementAt(w));
                    p22.Add(c31.ElementAt(w));
                    p22.Add(c32.ElementAt(w));
                    p22.Add(c33.ElementAt(w));
                    p22.Add(c34.ElementAt(w));
                    p22.Add(c35.ElementAt(w));
                    p22.Add(c36.ElementAt(w));
                    p22.Add(c37.ElementAt(w));
                    p22.Add(c38.ElementAt(w));
                    p22.Add(c39.ElementAt(w));
                    p22.Add(c40.ElementAt(w));
                    p22.Add(c41.ElementAt(w));
                    p22.Add(c42.ElementAt(w));
                }
                else if (w == 22)
                {
                    p23.Add(c1.ElementAt(w));
                    p23.Add(c2.ElementAt(w));
                    p23.Add(c3.ElementAt(w));
                    p23.Add(c4.ElementAt(w));
                    p23.Add(c5.ElementAt(w));
                    p23.Add(c6.ElementAt(w));
                    p23.Add(c7.ElementAt(w));
                    p23.Add(c8.ElementAt(w));
                    p23.Add(c9.ElementAt(w));
                    p23.Add(c10.ElementAt(w));
                    p23.Add(c11.ElementAt(w));
                    p23.Add(c12.ElementAt(w));
                    p23.Add(c13.ElementAt(w));
                    p23.Add(c14.ElementAt(w));
                    p23.Add(c15.ElementAt(w));
                    p23.Add(c16.ElementAt(w));
                    p23.Add(c17.ElementAt(w));
                    p23.Add(c18.ElementAt(w));
                    p23.Add(c19.ElementAt(w));
                    p23.Add(c20.ElementAt(w));
                    p23.Add(c21.ElementAt(w));
                    p23.Add(c22.ElementAt(w));
                    p23.Add(c23.ElementAt(w));
                    p23.Add(c24.ElementAt(w));
                    p23.Add(c25.ElementAt(w));
                    p23.Add(c26.ElementAt(w));
                    p23.Add(c27.ElementAt(w));
                    p23.Add(c28.ElementAt(w));
                    p23.Add(c29.ElementAt(w));
                    p23.Add(c30.ElementAt(w));
                    p23.Add(c31.ElementAt(w));
                    p23.Add(c32.ElementAt(w));
                    p23.Add(c33.ElementAt(w));
                    p23.Add(c34.ElementAt(w));
                    p23.Add(c35.ElementAt(w));
                    p23.Add(c36.ElementAt(w));
                    p23.Add(c37.ElementAt(w));
                    p23.Add(c38.ElementAt(w));
                    p23.Add(c39.ElementAt(w));
                    p23.Add(c40.ElementAt(w));
                    p23.Add(c41.ElementAt(w));
                    p23.Add(c42.ElementAt(w));
                }
                else if (w == 23)
                {
                    p24.Add(c1.ElementAt(w));
                    p24.Add(c2.ElementAt(w));
                    p24.Add(c3.ElementAt(w));
                    p24.Add(c4.ElementAt(w));
                    p24.Add(c5.ElementAt(w));
                    p24.Add(c6.ElementAt(w));
                    p24.Add(c7.ElementAt(w));
                    p24.Add(c8.ElementAt(w));
                    p24.Add(c9.ElementAt(w));
                    p24.Add(c10.ElementAt(w));
                    p24.Add(c11.ElementAt(w));
                    p24.Add(c12.ElementAt(w));
                    p24.Add(c13.ElementAt(w));
                    p24.Add(c14.ElementAt(w));
                    p24.Add(c15.ElementAt(w));
                    p24.Add(c16.ElementAt(w));
                    p24.Add(c17.ElementAt(w));
                    p24.Add(c18.ElementAt(w));
                    p24.Add(c19.ElementAt(w));
                    p24.Add(c20.ElementAt(w));
                    p24.Add(c21.ElementAt(w));
                    p24.Add(c22.ElementAt(w));
                    p24.Add(c23.ElementAt(w));
                    p24.Add(c24.ElementAt(w));
                    p24.Add(c25.ElementAt(w));
                    p24.Add(c26.ElementAt(w));
                    p24.Add(c27.ElementAt(w));
                    p24.Add(c28.ElementAt(w));
                    p24.Add(c29.ElementAt(w));
                    p24.Add(c30.ElementAt(w));
                    p24.Add(c31.ElementAt(w));
                    p24.Add(c32.ElementAt(w));
                    p24.Add(c33.ElementAt(w));
                    p24.Add(c34.ElementAt(w));
                    p24.Add(c35.ElementAt(w));
                    p24.Add(c36.ElementAt(w));
                    p24.Add(c37.ElementAt(w));
                    p24.Add(c38.ElementAt(w));
                    p24.Add(c39.ElementAt(w));
                    p24.Add(c40.ElementAt(w));
                    p24.Add(c41.ElementAt(w));
                    p24.Add(c42.ElementAt(w));
                }
                else if (w == 24)
                {
                    p25.Add(c1.ElementAt(w));
                    p25.Add(c2.ElementAt(w));
                    p25.Add(c3.ElementAt(w));
                    p25.Add(c4.ElementAt(w));
                    p25.Add(c5.ElementAt(w));
                    p25.Add(c6.ElementAt(w));
                    p25.Add(c7.ElementAt(w));
                    p25.Add(c8.ElementAt(w));
                    p25.Add(c9.ElementAt(w));
                    p25.Add(c10.ElementAt(w));
                    p25.Add(c11.ElementAt(w));
                    p25.Add(c12.ElementAt(w));
                    p25.Add(c13.ElementAt(w));
                    p25.Add(c14.ElementAt(w));
                    p25.Add(c15.ElementAt(w));
                    p25.Add(c16.ElementAt(w));
                    p25.Add(c17.ElementAt(w));
                    p25.Add(c18.ElementAt(w));
                    p25.Add(c19.ElementAt(w));
                    p25.Add(c20.ElementAt(w));
                    p25.Add(c21.ElementAt(w));
                    p25.Add(c22.ElementAt(w));
                    p25.Add(c23.ElementAt(w));
                    p25.Add(c24.ElementAt(w));
                    p25.Add(c25.ElementAt(w));
                    p25.Add(c26.ElementAt(w));
                    p25.Add(c27.ElementAt(w));
                    p25.Add(c28.ElementAt(w));
                    p25.Add(c29.ElementAt(w));
                    p25.Add(c30.ElementAt(w));
                    p25.Add(c31.ElementAt(w));
                    p25.Add(c32.ElementAt(w));
                    p25.Add(c33.ElementAt(w));
                    p25.Add(c34.ElementAt(w));
                    p25.Add(c35.ElementAt(w));
                    p25.Add(c36.ElementAt(w));
                    p25.Add(c37.ElementAt(w));
                    p25.Add(c38.ElementAt(w));
                    p25.Add(c39.ElementAt(w));
                    p25.Add(c40.ElementAt(w));
                    p25.Add(c41.ElementAt(w));
                    p25.Add(c42.ElementAt(w));
                }
                else if (w == 25)
                {
                    p26.Add(c1.ElementAt(w));
                    p26.Add(c2.ElementAt(w));
                    p26.Add(c3.ElementAt(w));
                    p26.Add(c4.ElementAt(w));
                    p26.Add(c5.ElementAt(w));
                    p26.Add(c6.ElementAt(w));
                    p26.Add(c7.ElementAt(w));
                    p26.Add(c8.ElementAt(w));
                    p26.Add(c9.ElementAt(w));
                    p26.Add(c10.ElementAt(w));
                    p26.Add(c11.ElementAt(w));
                    p26.Add(c12.ElementAt(w));
                    p26.Add(c13.ElementAt(w));
                    p26.Add(c14.ElementAt(w));
                    p26.Add(c15.ElementAt(w));
                    p26.Add(c16.ElementAt(w));
                    p26.Add(c17.ElementAt(w));
                    p26.Add(c18.ElementAt(w));
                    p26.Add(c19.ElementAt(w));
                    p26.Add(c20.ElementAt(w));
                    p26.Add(c21.ElementAt(w));
                    p26.Add(c22.ElementAt(w));
                    p26.Add(c23.ElementAt(w));
                    p26.Add(c24.ElementAt(w));
                    p26.Add(c25.ElementAt(w));
                    p26.Add(c26.ElementAt(w));
                    p26.Add(c27.ElementAt(w));
                    p26.Add(c28.ElementAt(w));
                    p26.Add(c29.ElementAt(w));
                    p26.Add(c30.ElementAt(w));
                    p26.Add(c31.ElementAt(w));
                    p26.Add(c32.ElementAt(w));
                    p26.Add(c33.ElementAt(w));
                    p26.Add(c34.ElementAt(w));
                    p26.Add(c35.ElementAt(w));
                    p26.Add(c36.ElementAt(w));
                    p26.Add(c37.ElementAt(w));
                    p26.Add(c38.ElementAt(w));
                    p26.Add(c39.ElementAt(w));
                    p26.Add(c40.ElementAt(w));
                    p26.Add(c41.ElementAt(w));
                    p26.Add(c42.ElementAt(w));
                }
                else if (w == 26)
                {
                    p27.Add(c1.ElementAt(w));
                    p27.Add(c2.ElementAt(w));
                    p27.Add(c3.ElementAt(w));
                    p27.Add(c4.ElementAt(w));
                    p27.Add(c5.ElementAt(w));
                    p27.Add(c6.ElementAt(w));
                    p27.Add(c7.ElementAt(w));
                    p27.Add(c8.ElementAt(w));
                    p27.Add(c9.ElementAt(w));
                    p27.Add(c10.ElementAt(w));
                    p27.Add(c11.ElementAt(w));
                    p27.Add(c12.ElementAt(w));
                    p27.Add(c13.ElementAt(w));
                    p27.Add(c14.ElementAt(w));
                    p27.Add(c15.ElementAt(w));
                    p27.Add(c16.ElementAt(w));
                    p27.Add(c17.ElementAt(w));
                    p27.Add(c18.ElementAt(w));
                    p27.Add(c19.ElementAt(w));
                    p27.Add(c20.ElementAt(w));
                    p27.Add(c21.ElementAt(w));
                    p27.Add(c22.ElementAt(w));
                    p27.Add(c23.ElementAt(w));
                    p27.Add(c24.ElementAt(w));
                    p27.Add(c25.ElementAt(w));
                    p27.Add(c26.ElementAt(w));
                    p27.Add(c27.ElementAt(w));
                    p27.Add(c28.ElementAt(w));
                    p27.Add(c29.ElementAt(w));
                    p27.Add(c30.ElementAt(w));
                    p27.Add(c31.ElementAt(w));
                    p27.Add(c32.ElementAt(w));
                    p27.Add(c33.ElementAt(w));
                    p27.Add(c34.ElementAt(w));
                    p27.Add(c35.ElementAt(w));
                    p27.Add(c36.ElementAt(w));
                    p27.Add(c37.ElementAt(w));
                    p27.Add(c38.ElementAt(w));
                    p27.Add(c39.ElementAt(w));
                    p27.Add(c40.ElementAt(w));
                    p27.Add(c41.ElementAt(w));
                    p27.Add(c42.ElementAt(w));
                }
                else if (w == 27)
                {
                    p28.Add(c1.ElementAt(w));
                    p28.Add(c2.ElementAt(w));
                    p28.Add(c3.ElementAt(w));
                    p28.Add(c4.ElementAt(w));
                    p28.Add(c5.ElementAt(w));
                    p28.Add(c6.ElementAt(w));
                    p28.Add(c7.ElementAt(w));
                    p28.Add(c8.ElementAt(w));
                    p28.Add(c9.ElementAt(w));
                    p28.Add(c10.ElementAt(w));
                    p28.Add(c11.ElementAt(w));
                    p28.Add(c12.ElementAt(w));
                    p28.Add(c13.ElementAt(w));
                    p28.Add(c14.ElementAt(w));
                    p28.Add(c15.ElementAt(w));
                    p28.Add(c16.ElementAt(w));
                    p28.Add(c17.ElementAt(w));
                    p28.Add(c18.ElementAt(w));
                    p28.Add(c19.ElementAt(w));
                    p28.Add(c20.ElementAt(w));
                    p28.Add(c21.ElementAt(w));
                    p28.Add(c22.ElementAt(w));
                    p28.Add(c23.ElementAt(w));
                    p28.Add(c24.ElementAt(w));
                    p28.Add(c25.ElementAt(w));
                    p28.Add(c26.ElementAt(w));
                    p28.Add(c27.ElementAt(w));
                    p28.Add(c28.ElementAt(w));
                    p28.Add(c29.ElementAt(w));
                    p28.Add(c30.ElementAt(w));
                    p28.Add(c31.ElementAt(w));
                    p28.Add(c32.ElementAt(w));
                    p28.Add(c33.ElementAt(w));
                    p28.Add(c34.ElementAt(w));
                    p28.Add(c35.ElementAt(w));
                    p28.Add(c36.ElementAt(w));
                    p28.Add(c37.ElementAt(w));
                    p28.Add(c38.ElementAt(w));
                    p28.Add(c39.ElementAt(w));
                    p28.Add(c40.ElementAt(w));
                    p28.Add(c41.ElementAt(w));
                    p28.Add(c42.ElementAt(w));
                }
                else if (w == 28)
                {
                    p29.Add(c1.ElementAt(w));
                    p29.Add(c2.ElementAt(w));
                    p29.Add(c3.ElementAt(w));
                    p29.Add(c4.ElementAt(w));
                    p29.Add(c5.ElementAt(w));
                    p29.Add(c6.ElementAt(w));
                    p29.Add(c7.ElementAt(w));
                    p29.Add(c8.ElementAt(w));
                    p29.Add(c9.ElementAt(w));
                    p29.Add(c10.ElementAt(w));
                    p29.Add(c11.ElementAt(w));
                    p29.Add(c12.ElementAt(w));
                    p29.Add(c13.ElementAt(w));
                    p29.Add(c14.ElementAt(w));
                    p29.Add(c15.ElementAt(w));
                    p29.Add(c16.ElementAt(w));
                    p29.Add(c17.ElementAt(w));
                    p29.Add(c18.ElementAt(w));
                    p29.Add(c19.ElementAt(w));
                    p29.Add(c20.ElementAt(w));
                    p29.Add(c21.ElementAt(w));
                    p29.Add(c22.ElementAt(w));
                    p29.Add(c23.ElementAt(w));
                    p29.Add(c24.ElementAt(w));
                    p29.Add(c25.ElementAt(w));
                    p29.Add(c26.ElementAt(w));
                    p29.Add(c27.ElementAt(w));
                    p29.Add(c28.ElementAt(w));
                    p29.Add(c29.ElementAt(w));
                    p29.Add(c30.ElementAt(w));
                    p29.Add(c31.ElementAt(w));
                    p29.Add(c32.ElementAt(w));
                    p29.Add(c33.ElementAt(w));
                    p29.Add(c34.ElementAt(w));
                    p29.Add(c35.ElementAt(w));
                    p29.Add(c36.ElementAt(w));
                    p29.Add(c37.ElementAt(w));
                    p29.Add(c38.ElementAt(w));
                    p29.Add(c39.ElementAt(w));
                    p29.Add(c40.ElementAt(w));
                    p29.Add(c41.ElementAt(w));
                    p29.Add(c42.ElementAt(w));
                }
                else if (w == 29)
                {
                    p30.Add(c1.ElementAt(w));
                    p30.Add(c2.ElementAt(w));
                    p30.Add(c3.ElementAt(w));
                    p30.Add(c4.ElementAt(w));
                    p30.Add(c5.ElementAt(w));
                    p30.Add(c6.ElementAt(w));
                    p30.Add(c7.ElementAt(w));
                    p30.Add(c8.ElementAt(w));
                    p30.Add(c9.ElementAt(w));
                    p30.Add(c10.ElementAt(w));
                    p30.Add(c11.ElementAt(w));
                    p30.Add(c12.ElementAt(w));
                    p30.Add(c13.ElementAt(w));
                    p30.Add(c14.ElementAt(w));
                    p30.Add(c15.ElementAt(w));
                    p30.Add(c16.ElementAt(w));
                    p30.Add(c17.ElementAt(w));
                    p30.Add(c18.ElementAt(w));
                    p30.Add(c19.ElementAt(w));
                    p30.Add(c20.ElementAt(w));
                    p30.Add(c21.ElementAt(w));
                    p30.Add(c22.ElementAt(w));
                    p30.Add(c23.ElementAt(w));
                    p30.Add(c24.ElementAt(w));
                    p30.Add(c25.ElementAt(w));
                    p30.Add(c26.ElementAt(w));
                    p30.Add(c27.ElementAt(w));
                    p30.Add(c28.ElementAt(w));
                    p30.Add(c29.ElementAt(w));
                    p30.Add(c30.ElementAt(w));
                    p30.Add(c31.ElementAt(w));
                    p30.Add(c32.ElementAt(w));
                    p30.Add(c33.ElementAt(w));
                    p30.Add(c34.ElementAt(w));
                    p30.Add(c35.ElementAt(w));
                    p30.Add(c36.ElementAt(w));
                    p30.Add(c37.ElementAt(w));
                    p30.Add(c38.ElementAt(w));
                    p30.Add(c39.ElementAt(w));
                    p30.Add(c40.ElementAt(w));
                    p30.Add(c41.ElementAt(w));
                    p30.Add(c42.ElementAt(w));
                }
                else if (w == 30)
                {
                    p31.Add(c1.ElementAt(w));
                    p31.Add(c2.ElementAt(w));
                    p31.Add(c3.ElementAt(w));
                    p31.Add(c4.ElementAt(w));
                    p31.Add(c5.ElementAt(w));
                    p31.Add(c6.ElementAt(w));
                    p31.Add(c7.ElementAt(w));
                    p31.Add(c8.ElementAt(w));
                    p31.Add(c9.ElementAt(w));
                    p31.Add(c10.ElementAt(w));
                    p31.Add(c11.ElementAt(w));
                    p31.Add(c12.ElementAt(w));
                    p31.Add(c13.ElementAt(w));
                    p31.Add(c14.ElementAt(w));
                    p31.Add(c15.ElementAt(w));
                    p31.Add(c16.ElementAt(w));
                    p31.Add(c17.ElementAt(w));
                    p31.Add(c18.ElementAt(w));
                    p31.Add(c19.ElementAt(w));
                    p31.Add(c20.ElementAt(w));
                    p31.Add(c21.ElementAt(w));
                    p31.Add(c22.ElementAt(w));
                    p31.Add(c23.ElementAt(w));
                    p31.Add(c24.ElementAt(w));
                    p31.Add(c25.ElementAt(w));
                    p31.Add(c26.ElementAt(w));
                    p31.Add(c27.ElementAt(w));
                    p31.Add(c28.ElementAt(w));
                    p31.Add(c29.ElementAt(w));
                    p31.Add(c30.ElementAt(w));
                    p31.Add(c31.ElementAt(w));
                    p31.Add(c32.ElementAt(w));
                    p31.Add(c33.ElementAt(w));
                    p31.Add(c34.ElementAt(w));
                    p31.Add(c35.ElementAt(w));
                    p31.Add(c36.ElementAt(w));
                    p31.Add(c37.ElementAt(w));
                    p31.Add(c38.ElementAt(w));
                    p31.Add(c39.ElementAt(w));
                    p31.Add(c40.ElementAt(w));
                    p31.Add(c41.ElementAt(w));
                    p31.Add(c42.ElementAt(w));
                }
                else if (w == 31)
                {
                    p32.Add(c1.ElementAt(w));
                    p32.Add(c2.ElementAt(w));
                    p32.Add(c3.ElementAt(w));
                    p32.Add(c4.ElementAt(w));
                    p32.Add(c5.ElementAt(w));
                    p32.Add(c6.ElementAt(w));
                    p32.Add(c7.ElementAt(w));
                    p32.Add(c8.ElementAt(w));
                    p32.Add(c9.ElementAt(w));
                    p32.Add(c10.ElementAt(w));
                    p32.Add(c11.ElementAt(w));
                    p32.Add(c12.ElementAt(w));
                    p32.Add(c13.ElementAt(w));
                    p32.Add(c14.ElementAt(w));
                    p32.Add(c15.ElementAt(w));
                    p32.Add(c16.ElementAt(w));
                    p32.Add(c17.ElementAt(w));
                    p32.Add(c18.ElementAt(w));
                    p32.Add(c19.ElementAt(w));
                    p32.Add(c20.ElementAt(w));
                    p32.Add(c21.ElementAt(w));
                    p32.Add(c22.ElementAt(w));
                    p32.Add(c23.ElementAt(w));
                    p32.Add(c24.ElementAt(w));
                    p32.Add(c25.ElementAt(w));
                    p32.Add(c26.ElementAt(w));
                    p32.Add(c27.ElementAt(w));
                    p32.Add(c28.ElementAt(w));
                    p32.Add(c29.ElementAt(w));
                    p32.Add(c30.ElementAt(w));
                    p32.Add(c31.ElementAt(w));
                    p32.Add(c32.ElementAt(w));
                    p32.Add(c33.ElementAt(w));
                    p32.Add(c34.ElementAt(w));
                    p32.Add(c35.ElementAt(w));
                    p32.Add(c36.ElementAt(w));
                    p32.Add(c37.ElementAt(w));
                    p32.Add(c38.ElementAt(w));
                    p32.Add(c39.ElementAt(w));
                    p32.Add(c40.ElementAt(w));
                    p32.Add(c41.ElementAt(w));
                    p32.Add(c42.ElementAt(w));
                }
                else if (w == 32)
                {
                    p33.Add(c1.ElementAt(w));
                    p33.Add(c2.ElementAt(w));
                    p33.Add(c3.ElementAt(w));
                    p33.Add(c4.ElementAt(w));
                    p33.Add(c5.ElementAt(w));
                    p33.Add(c6.ElementAt(w));
                    p33.Add(c7.ElementAt(w));
                    p33.Add(c8.ElementAt(w));
                    p33.Add(c9.ElementAt(w));
                    p33.Add(c10.ElementAt(w));
                    p33.Add(c11.ElementAt(w));
                    p33.Add(c12.ElementAt(w));
                    p33.Add(c13.ElementAt(w));
                    p33.Add(c14.ElementAt(w));
                    p33.Add(c15.ElementAt(w));
                    p33.Add(c16.ElementAt(w));
                    p33.Add(c17.ElementAt(w));
                    p33.Add(c18.ElementAt(w));
                    p33.Add(c19.ElementAt(w));
                    p33.Add(c20.ElementAt(w));
                    p33.Add(c21.ElementAt(w));
                    p33.Add(c22.ElementAt(w));
                    p33.Add(c23.ElementAt(w));
                    p33.Add(c24.ElementAt(w));
                    p33.Add(c25.ElementAt(w));
                    p33.Add(c26.ElementAt(w));
                    p33.Add(c27.ElementAt(w));
                    p33.Add(c28.ElementAt(w));
                    p33.Add(c29.ElementAt(w));
                    p33.Add(c30.ElementAt(w));
                    p33.Add(c31.ElementAt(w));
                    p33.Add(c32.ElementAt(w));
                    p33.Add(c33.ElementAt(w));
                    p33.Add(c34.ElementAt(w));
                    p33.Add(c35.ElementAt(w));
                    p33.Add(c36.ElementAt(w));
                    p33.Add(c37.ElementAt(w));
                    p33.Add(c38.ElementAt(w));
                    p33.Add(c39.ElementAt(w));
                    p33.Add(c40.ElementAt(w));
                    p33.Add(c41.ElementAt(w));
                    p33.Add(c42.ElementAt(w));
                }
                else if (w == 33)
                {
                    p34.Add(c1.ElementAt(w));
                    p34.Add(c2.ElementAt(w));
                    p34.Add(c3.ElementAt(w));
                    p34.Add(c4.ElementAt(w));
                    p34.Add(c5.ElementAt(w));
                    p34.Add(c6.ElementAt(w));
                    p34.Add(c7.ElementAt(w));
                    p34.Add(c8.ElementAt(w));
                    p34.Add(c9.ElementAt(w));
                    p34.Add(c10.ElementAt(w));
                    p34.Add(c11.ElementAt(w));
                    p34.Add(c12.ElementAt(w));
                    p34.Add(c13.ElementAt(w));
                    p34.Add(c14.ElementAt(w));
                    p34.Add(c15.ElementAt(w));
                    p34.Add(c16.ElementAt(w));
                    p34.Add(c17.ElementAt(w));
                    p34.Add(c18.ElementAt(w));
                    p34.Add(c19.ElementAt(w));
                    p34.Add(c20.ElementAt(w));
                    p34.Add(c21.ElementAt(w));
                    p34.Add(c22.ElementAt(w));
                    p34.Add(c23.ElementAt(w));
                    p34.Add(c24.ElementAt(w));
                    p34.Add(c25.ElementAt(w));
                    p34.Add(c26.ElementAt(w));
                    p34.Add(c27.ElementAt(w));
                    p34.Add(c28.ElementAt(w));
                    p34.Add(c29.ElementAt(w));
                    p34.Add(c30.ElementAt(w));
                    p34.Add(c31.ElementAt(w));
                    p34.Add(c32.ElementAt(w));
                    p34.Add(c33.ElementAt(w));
                    p34.Add(c34.ElementAt(w));
                    p34.Add(c35.ElementAt(w));
                    p34.Add(c36.ElementAt(w));
                    p34.Add(c37.ElementAt(w));
                    p34.Add(c38.ElementAt(w));
                    p34.Add(c39.ElementAt(w));
                    p34.Add(c40.ElementAt(w));
                    p34.Add(c41.ElementAt(w));
                    p34.Add(c42.ElementAt(w));
                }
                else if (w == 34)
                {
                    p35.Add(c1.ElementAt(w));
                    p35.Add(c2.ElementAt(w));
                    p35.Add(c3.ElementAt(w));
                    p35.Add(c4.ElementAt(w));
                    p35.Add(c5.ElementAt(w));
                    p35.Add(c6.ElementAt(w));
                    p35.Add(c7.ElementAt(w));
                    p35.Add(c8.ElementAt(w));
                    p35.Add(c9.ElementAt(w));
                    p35.Add(c10.ElementAt(w));
                    p35.Add(c11.ElementAt(w));
                    p35.Add(c12.ElementAt(w));
                    p35.Add(c13.ElementAt(w));
                    p35.Add(c14.ElementAt(w));
                    p35.Add(c15.ElementAt(w));
                    p35.Add(c16.ElementAt(w));
                    p35.Add(c17.ElementAt(w));
                    p35.Add(c18.ElementAt(w));
                    p35.Add(c19.ElementAt(w));
                    p35.Add(c20.ElementAt(w));
                    p35.Add(c21.ElementAt(w));
                    p35.Add(c22.ElementAt(w));
                    p35.Add(c23.ElementAt(w));
                    p35.Add(c24.ElementAt(w));
                    p35.Add(c25.ElementAt(w));
                    p35.Add(c26.ElementAt(w));
                    p35.Add(c27.ElementAt(w));
                    p35.Add(c28.ElementAt(w));
                    p35.Add(c29.ElementAt(w));
                    p35.Add(c30.ElementAt(w));
                    p35.Add(c31.ElementAt(w));
                    p35.Add(c32.ElementAt(w));
                    p35.Add(c33.ElementAt(w));
                    p35.Add(c34.ElementAt(w));
                    p35.Add(c35.ElementAt(w));
                    p35.Add(c36.ElementAt(w));
                    p35.Add(c37.ElementAt(w));
                    p35.Add(c38.ElementAt(w));
                    p35.Add(c39.ElementAt(w));
                    p35.Add(c40.ElementAt(w));
                    p35.Add(c41.ElementAt(w));
                    p35.Add(c42.ElementAt(w));
                }
                else if (w == 35)
                {
                    p36.Add(c1.ElementAt(w));
                    p36.Add(c2.ElementAt(w));
                    p36.Add(c3.ElementAt(w));
                    p36.Add(c4.ElementAt(w));
                    p36.Add(c5.ElementAt(w));
                    p36.Add(c6.ElementAt(w));
                    p36.Add(c7.ElementAt(w));
                    p36.Add(c8.ElementAt(w));
                    p36.Add(c9.ElementAt(w));
                    p36.Add(c10.ElementAt(w));
                    p36.Add(c11.ElementAt(w));
                    p36.Add(c12.ElementAt(w));
                    p36.Add(c13.ElementAt(w));
                    p36.Add(c14.ElementAt(w));
                    p36.Add(c15.ElementAt(w));
                    p36.Add(c16.ElementAt(w));
                    p36.Add(c17.ElementAt(w));
                    p36.Add(c18.ElementAt(w));
                    p36.Add(c19.ElementAt(w));
                    p36.Add(c20.ElementAt(w));
                    p36.Add(c21.ElementAt(w));
                    p36.Add(c22.ElementAt(w));
                    p36.Add(c23.ElementAt(w));
                    p36.Add(c24.ElementAt(w));
                    p36.Add(c25.ElementAt(w));
                    p36.Add(c26.ElementAt(w));
                    p36.Add(c27.ElementAt(w));
                    p36.Add(c28.ElementAt(w));
                    p36.Add(c29.ElementAt(w));
                    p36.Add(c30.ElementAt(w));
                    p36.Add(c31.ElementAt(w));
                    p36.Add(c32.ElementAt(w));
                    p36.Add(c33.ElementAt(w));
                    p36.Add(c34.ElementAt(w));
                    p36.Add(c35.ElementAt(w));
                    p36.Add(c36.ElementAt(w));
                    p36.Add(c37.ElementAt(w));
                    p36.Add(c38.ElementAt(w));
                    p36.Add(c39.ElementAt(w));
                    p36.Add(c40.ElementAt(w));
                    p36.Add(c41.ElementAt(w));
                    p36.Add(c42.ElementAt(w));
                }
            }
            //Almacenamos los patrones en una lista de manera que creamos una matriz de valores de entrada.
                        
            entries.Add(p1);            
            entries.Add(p2);
            entries.Add(p3);
            entries.Add(p4);
            entries.Add(p5);
            entries.Add(p6);
            entries.Add(p7);
            entries.Add(p8);
            entries.Add(p9);
            entries.Add(p10);
            entries.Add(p11);
            entries.Add(p12);
            entries.Add(p13);
            entries.Add(p14);
            entries.Add(p15);
            entries.Add(p16);
            entries.Add(p17);
            entries.Add(p18);
            entries.Add(p19);
            entries.Add(p20);
            entries.Add(p21);
            entries.Add(p22);
            entries.Add(p23);
            entries.Add(p24);
            entries.Add(p25);
            entries.Add(p26);
            entries.Add(p27);
            entries.Add(p28);
            entries.Add(p29);
            entries.Add(p30);
            entries.Add(p31);
            entries.Add(p32);
            entries.Add(p33);
            entries.Add(p34);
            entries.Add(p35);
            entries.Add(p36);
            
            return entries;
        }


        /// <summary>
        ///Usamos este método al analizar el caracter elegido por el usuario. 
        /// </summary>
        /// <returns>matris producto del analisis del caracter del usuario</returns>
        public List<List<double>> getUserEntry()
        {
            //Columnas de la tabla de entrada de datos.
            List<double> c1 = new List<double>();
            List<double> c2 = new List<double>();
            List<double> c3 = new List<double>();
            List<double> c4 = new List<double>();
            List<double> c5 = new List<double>();
            List<double> c6 = new List<double>();
            List<double> c7 = new List<double>();
            List<double> c8 = new List<double>();
            List<double> c9 = new List<double>();
            List<double> c10 = new List<double>();
            List<double> c11 = new List<double>();
            List<double> c12 = new List<double>();
            List<double> c13 = new List<double>();
            List<double> c14 = new List<double>();
            List<double> c15 = new List<double>();
            List<double> c16 = new List<double>();
            List<double> c17 = new List<double>();
            List<double> c18 = new List<double>();
            List<double> c19 = new List<double>();
            List<double> c20 = new List<double>();
            List<double> c21 = new List<double>();
            List<double> c22 = new List<double>();
            List<double> c23 = new List<double>();
            List<double> c24 = new List<double>();
            List<double> c25 = new List<double>();
            List<double> c26 = new List<double>();
            List<double> c27 = new List<double>();
            List<double> c28 = new List<double>();
            List<double> c29 = new List<double>();
            List<double> c30 = new List<double>();
            List<double> c31 = new List<double>();
            List<double> c32 = new List<double>();
            List<double> c33 = new List<double>();
            List<double> c34 = new List<double>();
            List<double> c35 = new List<double>();
            List<double> c36 = new List<double>();

            //Columnas de los datos de salida esperados
            List<double> c37 = new List<double>();
            List<double> c38 = new List<double>();
            List<double> c39 = new List<double>();
            List<double> c40 = new List<double>();
            List<double> c41 = new List<double>();
            List<double> c42 = new List<double>();

            List<double> p1 = new List<double>();

            List<List<double>> entries = new List<List<double>>();

            for (int j = 0; j < patrones.Count; j++)
            {
                for (int k = 0; k < (patrones.ElementAt(j).entradas.Count + patrones.ElementAt(j).salidas.Count); k++)
                {
                    //Con esto obtenemos los valores de los datos de entrada. (patrones)
                    if (k >= (patrones.ElementAt(j).entradas.Count + patrones.ElementAt(j).salidas.Count) - 6)
                    {
                        if (k == 36)
                        {
                            c37.Add(patrones.ElementAt(j).salidas.ElementAt(k - 36).valorItem); //j y k van al reves creo.
                        }
                        else if (k == 37)
                        {
                            c38.Add(patrones.ElementAt(j).salidas.ElementAt(k - 36).valorItem);
                        }
                        else if (k == 38)
                        {
                            c39.Add(patrones.ElementAt(j).salidas.ElementAt(k - 36).valorItem);
                        }
                        else if (k == 39)
                        {
                            c40.Add(patrones.ElementAt(j).salidas.ElementAt(k - 36).valorItem);
                        }
                        else if (k == 40)
                        {
                            c41.Add(patrones.ElementAt(j).salidas.ElementAt(k - 36).valorItem);
                        }
                        else if (k == 41)
                        {
                            c42.Add(patrones.ElementAt(j).salidas.ElementAt(k - 36).valorItem);
                        }
                    }
                    else
                    {
                        if (k == 0)
                        {
                            c1.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 1)
                        {
                            c2.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 2)
                        {
                            c3.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 3)
                        {
                            c4.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 4)
                        {
                            c5.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 5)
                        {
                            c6.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 6)
                        {
                            c7.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 7)
                        {
                            c8.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 8)
                        {
                            c9.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 9)
                        {
                            c10.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 10)
                        {
                            c11.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 11)
                        {
                            c12.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 12)
                        {
                            c13.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 13)
                        {
                            c14.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 14)
                        {
                            c15.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 15)
                        {
                            c16.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 16)
                        {
                            c17.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 17)
                        {
                            c18.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 18)
                        {
                            c19.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 19)
                        {
                            c20.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 20)
                        {
                            c21.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 21)
                        {
                            c22.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 22)
                        {
                            c23.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 23)
                        {
                            c24.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 24)
                        {
                            c25.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 25)
                        {
                            c26.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 26)
                        {
                            c27.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 27)
                        {
                            c28.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 28)
                        {
                            c29.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 29)
                        {
                            c30.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 30)
                        {
                            c31.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 31)
                        {
                            c32.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 32)
                        {
                            c33.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 33)
                        {
                            c34.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 34)
                        {
                            c35.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                        else if (k == 35)
                        {
                            c36.Add(patrones.ElementAt(j).entradas.ElementAt(k).valorItem);
                        }
                    }
                }
            }

            //Almacenamos los valores de entrada por orden de fila en listas de doubles.
            for (int w = 0; w < c1.Count; w++)
            {
                if (w == 0)
                {
                    p1.Add(c1.ElementAt(w));
                    p1.Add(c2.ElementAt(w));
                    p1.Add(c3.ElementAt(w));
                    p1.Add(c4.ElementAt(w));
                    p1.Add(c5.ElementAt(w));
                    p1.Add(c6.ElementAt(w));
                    p1.Add(c7.ElementAt(w));
                    p1.Add(c8.ElementAt(w));
                    p1.Add(c9.ElementAt(w));
                    p1.Add(c10.ElementAt(w));
                    p1.Add(c11.ElementAt(w));
                    p1.Add(c12.ElementAt(w));
                    p1.Add(c13.ElementAt(w));
                    p1.Add(c14.ElementAt(w));
                    p1.Add(c15.ElementAt(w));
                    p1.Add(c16.ElementAt(w));
                    p1.Add(c17.ElementAt(w));
                    p1.Add(c18.ElementAt(w));
                    p1.Add(c19.ElementAt(w));
                    p1.Add(c20.ElementAt(w));
                    p1.Add(c21.ElementAt(w));
                    p1.Add(c22.ElementAt(w));
                    p1.Add(c23.ElementAt(w));
                    p1.Add(c24.ElementAt(w));
                    p1.Add(c25.ElementAt(w));
                    p1.Add(c26.ElementAt(w));
                    p1.Add(c27.ElementAt(w));
                    p1.Add(c28.ElementAt(w));
                    p1.Add(c29.ElementAt(w));
                    p1.Add(c30.ElementAt(w));
                    p1.Add(c31.ElementAt(w));
                    p1.Add(c32.ElementAt(w));
                    p1.Add(c33.ElementAt(w));
                    p1.Add(c34.ElementAt(w));
                    p1.Add(c35.ElementAt(w));
                    p1.Add(c36.ElementAt(w));
                    p1.Add(c37.ElementAt(w));
                    p1.Add(c38.ElementAt(w));
                    p1.Add(c39.ElementAt(w));
                    p1.Add(c40.ElementAt(w));
                    p1.Add(c41.ElementAt(w));
                    p1.Add(c42.ElementAt(w));
                }                
            }
            
            //Almacenamos los patrones en una lista de manera que creamos una matriz de valores de entrada.
            entries.Add(p1);            
            return entries;
        }


        /// <summary>
        ///Recorremos la red neuronal para obtener la matriz de valores de la capa oculta.
        /// </summary>
        /// <returns>capa oculta de la red</returns>
        public List<List<double>> getCapaOculta()
        {
            List<List<double>> capaOculta = new List<List<double>>();
            //Mientras sea menor a 36 porque solo queremos los pesos que salen de las neuronas de inicio.
            for (int i = 0; i < 36; i++) 
            {
                List<double> values = new List<double>();               
                for (int j = 0; j < neuronas.ElementAt(i).neuronasDeIda.Count; j++)
                {
                    values.Add(neuronas.ElementAt(i).neuronasDeIda.ElementAt(j).peso);
                }
                capaOculta.Add(values);
            }            
            return capaOculta;
        }
        
        /// <summary>
        /// Recorremos la red neuronal para obtener la matriz de valores de la capa de salida.
        /// </summary>
        /// <returns>capa de salida de la red</returns>
        public List<List<double>> getCapaSalida()
        {
            List<List<double>> capaSalida = new List<List<double>>();
            
            //Nos posicionamos en la capa de salida la cual inicia en la neurona 43
            for (int i = (neuronas.Count - 6); i < neuronas.Count; i++)
            {
                List<double> values = new List<double>();
                for (int j = 0; j < neuronas.ElementAt(i).neuronasDeLlegada.Count; j++)
                {
                    values.Add(neuronas.ElementAt(i).neuronasDeLlegada.ElementAt(j).peso);
                }
                capaSalida.Add(values);
            }            
            return capaSalida;
        }
        
        /// <summary>
        /// Método principal que se encargará de realizar las iteraciones y ajustes de pesos si fuera necesario.
        /// </summary>
        /// <param name="datosEntrada">matriz de entrada</param>
        /// <param name="iteraciones">nnumero de interaciones</param>
        /// <param name="flag">bandera de control</param>
        /// <returns>retorna el valor del analisis</returns>
        public double iniciarAnalisis(List<List<double>> datosEntrada, int iteraciones, bool flag)
        {
            int t = 36;
            //string whatsWrong = "";
            int dividendo = 0;
            int pesosPerfectos = 0;
            int entrada = 0; //Para saber en cual entrada de la tabla estamos
            List<List<double>> pesosCapaOculta = new List<List<double>>();
            List<List<double>> pesosCapaSalida = new List<List<double>>();
            List<double> Lsalida = new List<double>();
            double salida = 0;
            double porcentajeSimilitud = 0; //para saber que tan parecida es la letra al resultado esperado.

            pesosCapaOculta = this.getCapaOculta(); //Obtenemos la capa oculta de la red neuronal.
            pesosCapaSalida = this.getCapaSalida(); //Obtenemos la capa de salida de la red neuronal.

            while (iteraciones > 0)
            {
                porcentajeSimilitud = 0;
                Lsalida = getSalidas(datosEntrada, pesosCapaOculta, pesosCapaSalida, entrada);
                pesosPerfectos = 0;
                dividendo = 0;
                for (int i = 0; i < datosEntrada.Count; i++)
                {
                    Lsalida = getSalidas(datosEntrada, pesosCapaOculta, pesosCapaSalida, entrada);
                    t = 36;

                    //j = Igual a la cantidad de salidas - 6 para posicionarnos en la primera salida de la capa de salida.
                    for (int j = (Lsalida.Count - 6); j < Lsalida.Count; j++)
                    {
                        salida = Lsalida.ElementAt(j);
                        //Usamos la t para obtener la salida de cada patrón.
                        if (datosEntrada.ElementAt(i).ElementAt(t) == 1)
                        {
                            t++; //Siguiente salida de ese patrón.
                            if (salida >= 0.9595)
                            {
                                //Pura vida, no hace falta ajuste"
                                pesosPerfectos++; //Los pesos sirven para este patrón.
                                porcentajeSimilitud += salida;
                                dividendo++;
                                //whatsWrong += "No hace falta ajustar: " + salida.ToString() + "                                                 ";
                            }
                            else
                            {
                                //Hay que ajustar porque se necesita una salida más alta.
                                //whatsWrong += "Ajustando hacia arriba: " + salida.ToString() + "                                                  ";
                                pesosPerfectos = 0;
                                ajuste(entrada, datosEntrada, pesosCapaOculta, pesosCapaSalida, tasaDeAprendizaje);
                                porcentajeSimilitud += salida;
                                dividendo++;
                            }
                        }
                        else if (datosEntrada.ElementAt(i).ElementAt(t) == 0)
                        {
                            t++; //Siguiente salida de ese patrón.
                            if (salida <= 0.0505)
                            {
                                //Pura vida, no hace falta ajuste"
                                pesosPerfectos++; //Los pesos sirven para este patrón.
                                porcentajeSimilitud -= salida;
                                //whatsWrong += "No hace falta ajustar: " + salida.ToString() + "                                             ";
                            }
                            else if(flag)
                            {
                                //Hay que ajustar porque se necesita una salida más baja.
                                pesosPerfectos = 0;
                                ajuste(entrada, datosEntrada, pesosCapaOculta, pesosCapaSalida, tasaDeAprendizaje);
                                porcentajeSimilitud -= salida;
                                //whatsWrong += "Ajustando hacia abajo: " + salida.ToString() + "                                          ";
                            }
                        }
                    }
                    if (pesosPerfectos == 6)
                    {   //  Los pesos están ajustados de manera tal que todos los caracteres tendrán
                        //  un buen porcentaje de reconocimiento.
                        break;
                    }
                    else
                    {
                        entrada++;
                        pesosCapaOculta = this.getCapaOculta(); //Obtenemos la capa oculta de la red neuronal
                        pesosCapaSalida = this.getCapaSalida(); //Obtenemos la capa de salida de la red neuronal
                    }                    
                }
                entrada = 0;
                iteraciones--;
            }
            if (dividendo == 0) //Si el caracter que estamos analizando es el cero
            {
                porcentajeSimilitud += 1;
                dividendo = 1;
            }
            porcentajeSimilitud = ((porcentajeSimilitud / dividendo) * 100);
            return porcentajeSimilitud;
        }

        /// <summary>
        /// Obtenemos las salidas de todas las neuronas
        /// </summary>
        /// <param name="datosEntrada">matriz de entrada</param>
        /// <param name="pesosCapaOculta"pesos de la capa oculta></param>
        /// <param name="pesosCapaSalida">pesos de la capa salida</param>
        /// <param name="numeroEntrada">numero de entrada</param>
        /// <returns>lista de salidas</returns>
        public List<double> getSalidas(List<List<double>> datosEntrada, List<List<double>> pesosCapaOculta,
            List<List<double>> pesosCapaSalida, int numeroEntrada)
        {
            //Para las salidas
            double s1 = 0;
            double s2 = 0;
            double s3 = 0;
            double s4 = 0;
            double s5 = 0;
            double s6 = 0;
            double s7 = 0;
            double s8 = 0;
            double s9 = 0;
            double s10 = 0;
            double s11 = 0;
            double s12 = 0;
            double s13 = 0;
            double s14 = 0;
            List<double> salidas = new List<double>();

            //Para las salidas sin usar la Math.e
            double e1 = 0; 
            double e2 = 0; 
            double e3 = 0;
            double e4 = 0;
            double e5 = 0;
            double e6 = 0;
            double e7 = 0;
            double e8 = 0;
            double e9 = 0;
            double e10 = 0;
            double e11 = 0;
            double e12 = 0;
            double e13 = 0;
            double e14 = 0;

            //Obtenemos las salidas de la capa oculta
            for (int i = 0; i < pesosCapaOculta.Count; i++)
            {             
                e1 += (pesosCapaOculta.ElementAt(i).ElementAt(0) * 
                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i));
                s1 = 1 / (1 + (Math.Pow(Math.E, -e1)));
                    
                e2 += (pesosCapaOculta.ElementAt(i).ElementAt(1) *
                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i));
                s2 = 1 / (1 + (Math.Pow(Math.E, -e2)));
                                        
                e3 += (pesosCapaOculta.ElementAt(i).ElementAt(2) *
                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i));
                s3 = 1 / (1 + (Math.Pow(Math.E, -e3)));
                    
                e4 += (pesosCapaOculta.ElementAt(i).ElementAt(3) *
                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i));
                s4 = 1 / (1 + (Math.Pow(Math.E, -e4)));
                                        
                e5 += (pesosCapaOculta.ElementAt(i).ElementAt(4) *
                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i));
                s5 = 1 / (1 + (Math.Pow(Math.E, -e5)));
                    
                e6 += (pesosCapaOculta.ElementAt(i).ElementAt(5) *
                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i));
                s6 = 1 / (1 + (Math.Pow(Math.E, -e6)));
                
                e7 += (pesosCapaOculta.ElementAt(i).ElementAt(6) *
                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i));
                s7 = 1 / (1 + (Math.Pow(Math.E, -e7)));

                e8 += (pesosCapaOculta.ElementAt(i).ElementAt(7) *
                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i));
                s8 = 1 / (1 + (Math.Pow(Math.E, -e8)));
            }

            //Obtenemos las salida de la capa de salida
            e9 = 0;
            e10 = 0;
            e11 = 0;
            e12 = 0;
            e13 = 0;
            e14 = 0;
            
            for (int i = 0; i < pesosCapaSalida.Count; i++)
            {
                for (int j = 0; j < pesosCapaSalida.ElementAt(i).Count; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            e9 += s1 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 1)
                        {
                            e9 += s2 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 2)
                        {
                            e9 += s3 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 3)
                        {
                            e9 += s4 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 4)
                        {
                            e9 += s5 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 5)
                        {
                            e9 += s6 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 6)
                        {
                            e9 += s7 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 7)
                        {
                            e9 += s8 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                    }
                    else if (i == 1)
                    {
                        if (j == 0)
                        {
                            e10 += s1 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 1)
                        {
                            e10 += s2 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 2)
                        {
                            e10 += s3 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 3)
                        {
                            e10 += s4 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 4)
                        {
                            e10 += s5 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 5)
                        {
                            e10 += s6 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 6)
                        {
                            e10 += s7 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 7)
                        {
                            e10 += s8 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                    }
                    else if (i == 2)
                    {
                        if (j == 0)
                        {
                            e11 += s1 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 1)
                        {
                            e11 += s2 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 2)
                        {
                            e11 += s3 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 3)
                        {
                            e11 += s4 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 4)
                        {
                            e11 += s5 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 5)
                        {
                            e11 += s6 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 6)
                        {
                            e11 += s7 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 7)
                        {
                            e11 += s8 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                    }
                    else if (i == 3)
                    {
                        if (j == 0)
                        {
                            e12 += s1 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 1)
                        {
                            e12 += s2 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 2)
                        {
                            e12 += s3 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 3)
                        {
                            e12 += s4 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 4)
                        {
                            e12 += s5 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 5)
                        {
                            e12 += s6 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 6)
                        {
                            e12 += s7 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 7)
                        {
                            e12 += s8 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                    }
                    else if (i == 4)
                    {
                        if (j == 0)
                        {
                            e13 += s1 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 1)
                        {
                            e13 += s2 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 2)
                        {
                            e13 += s3 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 3)
                        {
                            e13 += s4 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 4)
                        {
                            e13 += s5 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 5)
                        {
                            e13 += s6 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 6)
                        {
                            e13 += s7 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 7)
                        {
                            e13 += s8 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                    }
                    else if (i == 5)
                    {
                        if (j == 0)
                        {
                            e14 += s1 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 1)
                        {
                            e14 += s2 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 2)
                        {
                            e14 += s3 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 3)
                        {
                            e14 += s4 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 4)
                        {
                            e14 += s5 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 5)
                        {
                            e14 += s6 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 6)
                        {
                            e14 += s7 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                        else if (j == 7)
                        {
                            e14 += s8 * pesosCapaSalida.ElementAt(i).ElementAt(j);
                        }
                    }
                }
            }
            s9 = 1 / (1 + (Math.Pow(Math.E, -e9)));
            s10 = 1 / (1 + (Math.Pow(Math.E, -e10)));
            s11 = 1 / (1 + (Math.Pow(Math.E, -e11)));
            s12 = 1 / (1 + (Math.Pow(Math.E, -e12)));
            s13 = 1 / (1 + (Math.Pow(Math.E, -e13)));
            s14 = 1 / (1 + (Math.Pow(Math.E, -e14)));
            
            salidas.Add(s1);
            salidas.Add(s2);
            salidas.Add(s3);
            salidas.Add(s4);
            salidas.Add(s5);
            salidas.Add(s6);
            salidas.Add(s7);
            salidas.Add(s8);
            salidas.Add(s9);
            salidas.Add(s10);
            salidas.Add(s11);
            salidas.Add(s12);
            salidas.Add(s13);
            salidas.Add(s14);

            return salidas;
        }


        /// <summary>
        /// Método para ajustar los pesos
        /// </summary>
        /// <param name="numeroEntrada">numero de entrada</param>
        /// <param name="datosEntrada">matriz de entrada</param>
        /// <param name="pesosCapaOculta"pesos de la capa oculta></param>
        /// <param name="pesosCapaSalida">pesos de la capa salida</param>
        /// <param name="valorAjuste">valor de ajuste</param>
        public void ajuste(int numeroEntrada, List<List<double>> datosEntrada, List<List<double>> pesosCapaOculta, 
            List<List<double>> pesosCapaSalida, double valorAjuste)
        {
            if (catcha == false)
            {
                //Aquí obtenemos todas las salidas de la red neuronal.
                List<double> LSalidas = getSalidas(datosEntrada, pesosCapaOculta, pesosCapaSalida, numeroEntrada);

                //Este valorEsperado del caracter que está siendo analizado es individual para cada neurona de salida.
                double valorEsperadoSalida1 = datosEntrada.ElementAt(numeroEntrada).ElementAt(36);
                double valorEsperadoSalida2 = datosEntrada.ElementAt(numeroEntrada).ElementAt(37);
                double valorEsperadoSalida3 = datosEntrada.ElementAt(numeroEntrada).ElementAt(38);
                double valorEsperadoSalida4 = datosEntrada.ElementAt(numeroEntrada).ElementAt(39);
                double valorEsperadoSalida5 = datosEntrada.ElementAt(numeroEntrada).ElementAt(40);
                double valorEsperadoSalida6 = datosEntrada.ElementAt(numeroEntrada).ElementAt(41);

                //8 Salidas de la capa oculta
                double s1 = LSalidas.ElementAt(0); //Salida de la primera neurona de la capa oculta.
                double s2 = LSalidas.ElementAt(1);
                double s3 = LSalidas.ElementAt(2);
                double s4 = LSalidas.ElementAt(3);
                double s5 = LSalidas.ElementAt(4);
                double s6 = LSalidas.ElementAt(5);
                double s7 = LSalidas.ElementAt(6);
                double s8 = LSalidas.ElementAt(7);

                //6 Salidas de la capa de salida.
                double s9 = LSalidas.ElementAt(8); //Salida de la primera neurona de la capa de salida.
                double s10 = LSalidas.ElementAt(9);
                double s11 = LSalidas.ElementAt(10);
                double s12 = LSalidas.ElementAt(11);
                double s13 = LSalidas.ElementAt(12);
                double s14 = LSalidas.ElementAt(13);

                //Deltas para ajustar los pesos que llegan a la capa de salida.
                double deltaSalida1 = s9 * (1 - s9) * (valorEsperadoSalida1 - s9);
                double deltaSalida2 = s10 * (1 - s10) * (valorEsperadoSalida2 - s10);
                double deltaSalida3 = s11 * (1 - s11) * (valorEsperadoSalida3 - s11);
                double deltaSalida4 = s12 * (1 - s12) * (valorEsperadoSalida4 - s12);
                double deltaSalida5 = s13 * (1 - s13) * (valorEsperadoSalida5 - s13);
                double deltaSalida6 = s14 * (1 - s14) * (valorEsperadoSalida6 - s14);

                //Delta para la primera neurona de la capa oculta.
                double deltaOculta1 = s1 * (1 - s1) * ((pesosCapaSalida.ElementAt(0).ElementAt(0) * deltaSalida1) +
                    (pesosCapaSalida.ElementAt(1).ElementAt(0) * deltaSalida2) + (pesosCapaSalida.ElementAt(2).ElementAt(0) * deltaSalida3) +
                    (pesosCapaSalida.ElementAt(3).ElementAt(0) * deltaSalida4) + (pesosCapaSalida.ElementAt(4).ElementAt(0) * deltaSalida5) +
                    (pesosCapaSalida.ElementAt(5).ElementAt(0) * deltaSalida6));
                //Delta para la segunda neurona de la capa oculta.
                double deltaOculta2 = s2 * (1 - s2) * ((pesosCapaSalida.ElementAt(0).ElementAt(1) * deltaSalida1) +
                    (pesosCapaSalida.ElementAt(1).ElementAt(1) * deltaSalida2) + (pesosCapaSalida.ElementAt(2).ElementAt(1) * deltaSalida3) +
                    (pesosCapaSalida.ElementAt(3).ElementAt(1) * deltaSalida4) + (pesosCapaSalida.ElementAt(4).ElementAt(1) * deltaSalida5) +
                    (pesosCapaSalida.ElementAt(5).ElementAt(1) * deltaSalida6));
                //Delta para la tercera neurona de la capa oculta.
                double deltaOculta3 = s3 * (1 - s3) * ((pesosCapaSalida.ElementAt(0).ElementAt(2) * deltaSalida1) +
                    (pesosCapaSalida.ElementAt(1).ElementAt(2) * deltaSalida2) + (pesosCapaSalida.ElementAt(2).ElementAt(2) * deltaSalida3) +
                    (pesosCapaSalida.ElementAt(3).ElementAt(2) * deltaSalida4) + (pesosCapaSalida.ElementAt(4).ElementAt(2) * deltaSalida5) +
                    (pesosCapaSalida.ElementAt(5).ElementAt(2) * deltaSalida6));
                //Delta para la cuarta neurona de la capa oculta.
                double deltaOculta4 = s4 * (1 - s4) * ((pesosCapaSalida.ElementAt(0).ElementAt(3) * deltaSalida1) +
                    (pesosCapaSalida.ElementAt(1).ElementAt(3) * deltaSalida2) + (pesosCapaSalida.ElementAt(2).ElementAt(3) * deltaSalida3) +
                    (pesosCapaSalida.ElementAt(3).ElementAt(3) * deltaSalida4) + (pesosCapaSalida.ElementAt(4).ElementAt(3) * deltaSalida5) +
                    (pesosCapaSalida.ElementAt(5).ElementAt(3) * deltaSalida6));
                //Delta para la quinta neurona de la capa oculta.
                double deltaOculta5 = s5 * (1 - s5) * ((pesosCapaSalida.ElementAt(0).ElementAt(4) * deltaSalida1) +
                    (pesosCapaSalida.ElementAt(1).ElementAt(4) * deltaSalida2) + (pesosCapaSalida.ElementAt(2).ElementAt(4) * deltaSalida3) +
                    (pesosCapaSalida.ElementAt(3).ElementAt(4) * deltaSalida4) + (pesosCapaSalida.ElementAt(4).ElementAt(4) * deltaSalida5) +
                    (pesosCapaSalida.ElementAt(5).ElementAt(4) * deltaSalida6));
                //Delta para la sexta neurona de la capa oculta.
                double deltaOculta6 = s6 * (1 - s6) * ((pesosCapaSalida.ElementAt(0).ElementAt(5) * deltaSalida1) +
                    (pesosCapaSalida.ElementAt(1).ElementAt(5) * deltaSalida2) + (pesosCapaSalida.ElementAt(2).ElementAt(5) * deltaSalida3) +
                    (pesosCapaSalida.ElementAt(3).ElementAt(5) * deltaSalida4) + (pesosCapaSalida.ElementAt(4).ElementAt(5) * deltaSalida5) +
                    (pesosCapaSalida.ElementAt(5).ElementAt(5) * deltaSalida6));
                //Delta para la séptima neurona de la capa oculta.
                double deltaOculta7 = s7 * (1 - s7) * ((pesosCapaSalida.ElementAt(0).ElementAt(6) * deltaSalida1) +
                    (pesosCapaSalida.ElementAt(1).ElementAt(6) * deltaSalida2) + (pesosCapaSalida.ElementAt(2).ElementAt(6) * deltaSalida3) +
                    (pesosCapaSalida.ElementAt(3).ElementAt(6) * deltaSalida4) + (pesosCapaSalida.ElementAt(4).ElementAt(6) * deltaSalida5) +
                    (pesosCapaSalida.ElementAt(5).ElementAt(6) * deltaSalida6));
                //Delta para la octava neurona de la capa oculta.
                double deltaOculta8 = s8 * (1 - s8) * ((pesosCapaSalida.ElementAt(0).ElementAt(7) * deltaSalida1) +
                    (pesosCapaSalida.ElementAt(1).ElementAt(7) * deltaSalida2) + (pesosCapaSalida.ElementAt(2).ElementAt(7) * deltaSalida3) +
                    (pesosCapaSalida.ElementAt(3).ElementAt(7) * deltaSalida4) + (pesosCapaSalida.ElementAt(4).ElementAt(7) * deltaSalida5) +
                    (pesosCapaSalida.ElementAt(5).ElementAt(7) * deltaSalida6));

                //Ahora procedemos a hacer los ajustes de los pesos.
                //Primero los pesos de la capa de salida.
                for (int i = 0; i < pesosCapaSalida.Count; i++)
                {
                    for (int j = 0; j < pesosCapaSalida.ElementAt(i).Count; j++)
                    {
                        if (j == 0)
                        {
                            //Actualizamos los pesos salientes de la primera neurona oculta.
                            if (i == 0)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s1 * deltaSalida1);
                            }
                            else if (i == 1)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s1 * deltaSalida2);
                            }
                            else if (i == 2)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s1 * deltaSalida3);
                            }
                            else if (i == 3)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s1 * deltaSalida4);
                            }
                            else if (i == 4)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s1 * deltaSalida5);
                            }
                            else if (i == 5)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s1 * deltaSalida6);
                            }
                        }
                        else if (j == 1)
                        {
                            //Actualizamos los pesos salientes de la segunda neurona oculta.
                            if (i == 0)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s2 * deltaSalida1);
                            }
                            else if (i == 1)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s2 * deltaSalida2);
                            }
                            else if (i == 2)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s2 * deltaSalida3);
                            }
                            else if (i == 3)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s2 * deltaSalida4);
                            }
                            else if (i == 4)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s2 * deltaSalida5);
                            }
                            else if (i == 5)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s2 * deltaSalida6);
                            }
                        }
                        else if (j == 2)
                        {
                            //Actualizamos los pesos salientes de la tercera neurona oculta.
                            if (i == 0)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s3 * deltaSalida1);
                            }
                            else if (i == 1)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s3 * deltaSalida2);
                            }
                            else if (i == 2)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s3 * deltaSalida3);
                            }
                            else if (i == 3)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s3 * deltaSalida4);
                            }
                            else if (i == 4)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s3 * deltaSalida5);
                            }
                            else if (i == 5)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s3 * deltaSalida6);
                            }
                        }
                        else if (j == 3)
                        {
                            //Actualizamos los pesos salientes de la cuarta neurona oculta.
                            if (i == 0)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s4 * deltaSalida1);
                            }
                            else if (i == 1)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s4 * deltaSalida2);
                            }
                            else if (i == 2)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s4 * deltaSalida3);
                            }
                            else if (i == 3)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s4 * deltaSalida4);
                            }
                            else if (i == 4)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s4 * deltaSalida5);
                            }
                            else if (i == 5)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s4 * deltaSalida6);
                            }
                        }
                        else if (j == 4)
                        {
                            //Actualizamos los pesos salientes de la quinta neurona oculta
                            if (i == 0)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s5 * deltaSalida1);
                            }
                            else if (i == 1)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s5 * deltaSalida2);
                            }
                            else if (i == 2)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s5 * deltaSalida3);
                            }
                            else if (i == 3)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s5 * deltaSalida4);
                            }
                            else if (i == 4)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s5 * deltaSalida5);
                            }
                            else if (i == 5)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s5 * deltaSalida6);
                            }
                        }
                        else if (j == 5)
                        {
                            //Actualizamos los pesos salientes de la sexta neurona oculta
                            if (i == 0)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s6 * deltaSalida1);
                            }
                            else if (i == 1)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s6 * deltaSalida2);
                            }
                            else if (i == 2)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s6 * deltaSalida3);
                            }
                            else if (i == 3)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s6 * deltaSalida4);
                            }
                            else if (i == 4)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s6 * deltaSalida5);
                            }
                            else if (i == 5)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s6 * deltaSalida6);
                            }
                        }
                        else if (j == 6)
                        {
                            //Actualizamos los pesos salientes de la séptima neurona oculta
                            if (i == 0)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s7 * deltaSalida1);
                            }
                            else if (i == 1)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s7 * deltaSalida2);
                            }
                            else if (i == 2)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s7 * deltaSalida3);
                            }
                            else if (i == 3)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s7 * deltaSalida4);
                            }
                            else if (i == 4)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s7 * deltaSalida5);
                            }
                            else if (i == 5)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s7 * deltaSalida6);
                            }
                        }
                        else if (j == 7)
                        {
                            //Actualizamos los pesos salientes de la octava neurona oculta
                            if (i == 0)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s8 * deltaSalida1);
                            }
                            else if (i == 1)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s8 * deltaSalida2);
                            }
                            else if (i == 2)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s8 * deltaSalida3);
                            }
                            else if (i == 3)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s8 * deltaSalida4);
                            }
                            else if (i == 4)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s8 * deltaSalida5);
                            }
                            else if (i == 5)
                            {
                                this.neuronas.ElementAt(i + (this.neuronas.Count - 6)).neuronasDeLlegada.ElementAt(j).peso =
                                    pesosCapaSalida.ElementAt(i).ElementAt(j) + (valorAjuste * s8 * deltaSalida6);
                            }
                        }
                    }
                }

                //Ahora los pesos que llegan a la capa oculta.
                for (int i = 0; i < pesosCapaOculta.Count; i++)
                {
                    for (int j = 0; j < pesosCapaOculta.ElementAt(i).Count; j++)
                    {
                        if (j == 0)
                        {
                            //Ajustamos y actualizamos los pesos que llegan a la primera neurona de la capa oculta.
                            this.neuronas.ElementAt(i).neuronasDeIda.ElementAt(j).peso =
                                pesosCapaOculta.ElementAt(i).ElementAt(j) + (valorAjuste *
                                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i) * deltaOculta1);
                        }
                        else if (j == 1)
                        {
                            //Ajustamos y actualizamos los pesos que llegan a la segunda neurona de la capa oculta.
                            this.neuronas.ElementAt(i).neuronasDeIda.ElementAt(j).peso =
                                pesosCapaOculta.ElementAt(i).ElementAt(j) + (valorAjuste *
                                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i) * deltaOculta2);
                        }
                        else if (j == 2)
                        {
                            //Ajustamos y actualizamos los pesos que llegan a la tercera neurona de la capa oculta.
                            this.neuronas.ElementAt(i).neuronasDeIda.ElementAt(j).peso =
                                pesosCapaOculta.ElementAt(i).ElementAt(j) + (valorAjuste *
                                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i) * deltaOculta3);
                        }
                        else if (j == 3)
                        {
                            //Ajustamos y actualizamos los pesos que llegan a la cuarta neurona de la capa oculta.
                            this.neuronas.ElementAt(i).neuronasDeIda.ElementAt(j).peso =
                                pesosCapaOculta.ElementAt(i).ElementAt(j) + (valorAjuste *
                                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i) * deltaOculta4);
                        }
                        else if (j == 4)
                        {
                            //Ajustamos y actualizamos los pesos que llegan a la quinta neurona de la capa oculta.
                            this.neuronas.ElementAt(i).neuronasDeIda.ElementAt(j).peso =
                                pesosCapaOculta.ElementAt(i).ElementAt(j) + (valorAjuste *
                                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i) * deltaOculta5);
                        }
                        else if (j == 5)
                        {
                            //Ajustamos y actualizamos los pesos que llega a la sexta neurona de la capa oculta.
                            this.neuronas.ElementAt(i).neuronasDeIda.ElementAt(j).peso =
                                pesosCapaOculta.ElementAt(i).ElementAt(j) + (valorAjuste *
                                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i) * deltaOculta6);
                        }
                        else if (j == 6)
                        {
                            //Ajustamos y actualizamos los pesos que llega a la séptima neurona de la capa oculta.
                            this.neuronas.ElementAt(i).neuronasDeIda.ElementAt(j).peso =
                                pesosCapaOculta.ElementAt(i).ElementAt(j) + (valorAjuste *
                                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i) * deltaOculta7);
                        }
                        else if (j == 7)
                        {
                            //Ajustamos y actualizamos los pesos que llega a la octava neurona de la capa oculta.
                            this.neuronas.ElementAt(i).neuronasDeIda.ElementAt(j).peso =
                                pesosCapaOculta.ElementAt(i).ElementAt(j) + (valorAjuste *
                                    datosEntrada.ElementAt(numeroEntrada).ElementAt(i) * deltaOculta8);
                        }
                    }
                }
            }
        }
        
    }
}
