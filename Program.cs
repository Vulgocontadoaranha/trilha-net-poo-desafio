using DesafioPOO.Models;

// implementado
 public class Testes
    {
        public static void Main(string[] args)
        {
            // Cria um objeto da classe Nokia
            Nokia nokia = new Nokia();

            // Testa o método "Ligar" da classe Nokia
            nokia.Ligar();

            // Testa o método "InstalarAplicativo" da classe Nokia
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");
            

            // Cria um objeto da classe Iphone
            Iphone iphone = new Iphone();

            // Testa o método "Ligar" da classe Iphone
            iphone.Ligar();

            // Testa o método "InstalarAplicativo" da classe Iphone
            iphone.InstalarAplicativo("Instagram");
        }
}