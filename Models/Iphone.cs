namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        private string Senha { get; set; }

        public Iphone(string senha, string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Senha = senha;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Utilize o Face ID para baixar o aplicativo\n");
            bool isFaceID = new Random().Next(2) == 1;

            if (isFaceID)
            {
                System.Console.WriteLine("BAIXAR POR FACE ID");
                Thread.Sleep(2000);

                System.Console.WriteLine("Ok");
                Console.WriteLine($"Instalando aplicativo {nomeApp}");

                Thread.Sleep(3000);
                Console.WriteLine($"{nomeApp} instalado com sucesso!");

                return;
            }

            System.Console.WriteLine("Digite a senha para baixar.");
            string senhaDigitada = Console.ReadLine() ?? "";

            while (!senhaDigitada.Equals(Senha))
            {
                Console.WriteLine("Senha incorreta\ndigite novamente a senha.");
                senhaDigitada = Console.ReadLine() ?? "";
            }

            Console.WriteLine($"{nomeApp} está sendo instalado...");

            Thread.Sleep(3000);

            Console.WriteLine($"{nomeApp} instalado com sucesso!");
        }
    }
}