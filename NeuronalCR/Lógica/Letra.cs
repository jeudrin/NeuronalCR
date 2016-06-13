using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalCR.Lógica
{
    class Letra
    {
        public String MatrizStr { get; set; }

        public List<List<int>> Matriz { get; set; }

        public Letra(List<List<int>> mt)
        {
            this.Matriz = mt;
            this.MatrizStr = generarMatrizString(mt);
        }

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
