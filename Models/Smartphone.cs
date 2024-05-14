namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // implementado
        public string Numero { get; set; }
        private string Modelo {get; set;}
        public string IMEI { get; set; }
        public int Memoria { get; set; }
        

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // implementado

            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

            
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public static void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}