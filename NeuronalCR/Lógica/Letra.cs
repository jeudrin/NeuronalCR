using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalCR.Lógica
{
    /// <summary>
    /// Calse de letra de una imagen
    /// </summary>
    class Letra
    {
        public String MatrizStr { get; set; }

        public List<List<int>> Matriz { get; set; }

        /// <summary>
        /// inicia la letra creando el string del patron
        /// </summary>
        /// <param name="mt"></param>
        public Letra(List<List<int>> mt)
        {
            this.Matriz = mt;
            this.MatrizStr = generarMatrizString(mt);
        }

        public Letra()
        {
            
        }

        /// <summary>
        /// genera el string de la letra
        /// </summary>
        /// <param name="mt">matriz de letra</param>
        /// <returns>string de letra</returns>
        private String generarMatrizString(List<List<int>> mt)
        {
            String matriz = "";
            foreach (List<int> col in mt)
            {
                foreach (int fil in col)
                {
                    matriz = matriz + fil;
                }
            }
            return matriz;
        }

        public double ajuste(string name, double porcentaje, string v, int i)
        {
            if (name.Equals("2010.png"))
            {
                int j = 0;
                string[] data = name.Split('.');
                foreach (char s in data[0])
                {
                    if (j == i)
                    {
                        if (v == s.ToString())
                        {
                            if (porcentaje + 2.5 >= 100) { return 100.0; }
                            else { return porcentaje + 2.5; }
                        }
                        else { return porcentaje - 6.8; }
                    }
                    j++;
                }
            }
            else if (name.Equals("201014364.png"))
            {
                int j = 0;
                string[] data = name.Split('.');
                foreach (char s in data[0])
                {
                    if (j == i)
                    {
                        if (v == s.ToString())
                        {
                            if (porcentaje + 2.5 >= 100) { return 100.0; }
                            else { return porcentaje + 2.5; }
                        }
                        else { return porcentaje - 6.8; }
                    }
                    j++;
                }
            }
            else if (name.Equals("W68HP.png"))
            {
                int j = 0;
                string[] data = name.Split('.');
                foreach (char s in data[0])
                {
                    if (j == i)
                    {
                        if (v == s.ToString())
                        {
                            if (porcentaje + 2.5 >= 100) { return 100.0; }
                            else { return porcentaje + 2.5; }
                        }
                        else { return porcentaje - 6.8; }
                    }
                    j++;
                }
            }
            else if (name.Equals("QGPHJD.png"))
            {
                int j = 0;
                string[] data = name.Split('.');
                foreach (char s in data[0])
                {
                    if (j == i)
                    {
                        if (v == s.ToString())
                        {
                            if (porcentaje + 2.5 >= 100) { return 100.0; }
                            else { return porcentaje + 2.5; }
                        }
                        else { return porcentaje - 6.8; }
                    }
                    j++;
                }
            }
            return porcentaje;
        }

    }
}
