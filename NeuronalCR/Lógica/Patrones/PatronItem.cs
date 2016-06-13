namespace NeuronalCR.Class
{
    /// <summary>
    /// item de patron 
    /// </summary>
    public class PatronItem
    {
        public string identificadorItem { get; set; }
        public int valorItem { get; set; }

        /// <summary>
        /// cosntructor
        /// </summary>
        /// <param name="identificadorRecibido">id de patron</param>
        /// <param name="valorRecibido">valor del patron</param>
        public PatronItem(string identificadorRecibido, int valorRecibido)
        {
            this.identificadorItem = identificadorRecibido;
            this.valorItem = valorRecibido;        
        }
    }
}