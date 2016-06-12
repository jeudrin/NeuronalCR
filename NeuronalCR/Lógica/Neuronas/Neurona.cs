using System.Collections.Generic;

namespace NeuronalCR.Class
{
    public class Neurona
    {
        public int tipoDeCapa; // 0 entrada, 1 oculta, 2 salida
        public string identificadorNeurona;
        public List<NeuronaConPeso> neuronasDeLlegada;
        public List<NeuronaConPeso> neuronasDeIda;

        public Neurona()
        {         
        }

        public Neurona(string identificadorRecibido)
        {
            this.identificadorNeurona = identificadorRecibido;
        }

        public void agregarNeuronaDeLlegada(NeuronaConPeso neuronaDeLlegada)
        {
            if (neuronasDeLlegada == null)
            {
                neuronasDeLlegada = new List<NeuronaConPeso>();
            }
            neuronasDeLlegada.Add(neuronaDeLlegada);        
        }

        public void agregarNeuronaDeIda(NeuronaConPeso neuronaDeIda)
        {
            if (neuronasDeIda == null)
            {
                neuronasDeIda = new List<NeuronaConPeso>();
            }
            neuronasDeIda.Add(neuronaDeIda);
        }
    }
}