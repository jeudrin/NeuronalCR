using System.Collections.Generic;

namespace NeuronalCR.Class
{
    /// <summary>
    /// neurona sin peso
    /// </summary>
    public class Neurona
    {
        public int tipoDeCapa; // 0 entrada, 1 oculta, 2 salida
        public string identificadorNeurona;
        public List<NeuronaConPeso> neuronasDeLlegada;
        public List<NeuronaConPeso> neuronasDeIda;

        /// <summary>
        /// cosntructor 
        /// </summary>
        public Neurona()
        {         
        }

        /// <summary>
        /// cosntructor
        /// </summary>
        /// <param name="identificadorRecibido">id del patron</param>
        public Neurona(string identificadorRecibido)
        {
            this.identificadorNeurona = identificadorRecibido;
        }

        /// <summary>
        /// agrega una neurona de llega a la red
        /// </summary>
        /// <param name="neuronaDeLlegada">neurona de llegada(con peso)</param>
        public void agregarNeuronaDeLlegada(NeuronaConPeso neuronaDeLlegada)
        {
            if (neuronasDeLlegada == null)
            {
                neuronasDeLlegada = new List<NeuronaConPeso>();
            }
            neuronasDeLlegada.Add(neuronaDeLlegada);        
        }

        /// <summary>
        /// agrega una neuron de ida a a la red
        /// </summary>
        /// <param name="neuronaDeIda">neurona de ida(con peso)</param>
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