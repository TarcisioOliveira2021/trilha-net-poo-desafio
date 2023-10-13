namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero,string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando o {Modelo}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"O {Numero} está recebendo um ligação...");
        }

        public void ChecarQtdArmazenamento()
        {
            Console.WriteLine($"O {Modelo} tem {Memoria}gb de memória.");
        }

        public void ChecarIMEI()
        {
            Console.WriteLine($"O {Modelo} tem IMEI de número:{IMEI}.");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}