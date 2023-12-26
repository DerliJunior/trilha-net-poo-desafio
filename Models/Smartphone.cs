namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string numero;
        private string imei;
        private string modelo;
        private int memoria;

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get { return numero; } set { numero = value; } }

        private string Modelo { get { return modelo; } set { modelo = value; } }

        private string IMEI { get { return imei; } set { imei = value; } }

        private int Memoria { get { return memoria; } set { memoria = value; } }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.numero = numero;
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}