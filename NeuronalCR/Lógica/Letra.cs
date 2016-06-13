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
    }
}
