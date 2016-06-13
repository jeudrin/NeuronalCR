using System.Collections.Generic;

namespace NeuronalCR.Class
{
    /// <summary>
    /// patron 
    /// </summary>
    public class Patron
    {
        public string descriptor { get; set; }       
        public List<PatronItem> entradas { get; set; }
        public List<PatronItem> salidas { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public Patron()
        {         
        }

        /// <summary>
        /// cosntructor
        /// </summary>
        /// <param name="descriptorRecibido"> descriptor o id </param>
        public Patron(string descriptorRecibido)
        {
            this.descriptor = descriptorRecibido;
        }

        /// <summary>
        /// agrega una entrada al patron
        /// </summary>
        /// <param name="entrada">item patron de entrada</param>
        public void agregarEntrada(PatronItem entrada)
        { 
            if(this.entradas == null)
            {
                this.entradas = new List<PatronItem>();
            }            
            this.entradas.Add(entrada);          
        }

        /// <summary>
        /// agrega una salida al patron
        /// </summary>
        /// <param name="salida">item patron de salida</param>
        public void agregarSalida(PatronItem salida)
        {
            if (this.salidas == null)
            {
                this.salidas = new List<PatronItem>();
            }
            this.salidas.Add(salida);
        }
    }
}