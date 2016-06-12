using System.Collections.Generic;

namespace NeuronalCR.Class
{
    public class Patron
    {
        public string descriptor { get; set; }       
        public List<PatronItem> entradas { get; set; }
        public List<PatronItem> salidas { get; set; }

        public Patron()
        {         
        }

        public Patron(string descriptorRecibido)
        {
            this.descriptor = descriptorRecibido;
        }

        public void agregarEntrada(PatronItem entrada)
        { 
            if(this.entradas == null)
            {
                this.entradas = new List<PatronItem>();
            }            
            this.entradas.Add(entrada);          
        }

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