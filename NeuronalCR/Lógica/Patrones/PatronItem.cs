namespace NeuronalCR.Class
{
    public class PatronItem
    {
        public string identificadorItem { get; set; }
        public int valorItem { get; set; }

        public PatronItem(string identificadorRecibido, int valorRecibido)
        {
            this.identificadorItem = identificadorRecibido;
            this.valorItem = valorRecibido;        
        }
    }
}