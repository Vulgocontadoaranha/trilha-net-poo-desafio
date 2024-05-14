namespace DesafioPOO.Models
{
    //implementado
    public class Nokia : Smartphone
    {
        public Nokia() : base("Nokia 1100", "1234567890", "123456789012345", 128)
        {
            Console.WriteLine("Smartphone Nokia:");
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu Nokia...");
        }
    }   
}