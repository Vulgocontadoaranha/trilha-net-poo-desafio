namespace DesafioPOO.Models
{
    // implementado
   public class Iphone : Smartphone
    {
        public Iphone() : base("iPhone 14", "0987654321", "098765432109876", 256)
        {
            Console.WriteLine("Smartphone Iphone:");
        }

        public override void Ligar()
        {
            
            Console.WriteLine("inicializando o iPhone...");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu iPhone...");
        }
    }
}