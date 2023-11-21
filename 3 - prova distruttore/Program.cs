using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___prova_distruttore
{
    class Esempio : IDisposable
    {
        //attributi
        private string stringa;
        private int numero;

        public Esempio()
        {
            stringa = " ";
            numero = 0;
        }

        // Costruttori con parametri
        public Esempio(string stringa, int numero)
        {
            this.stringa = stringa;
            this.numero = numero;
        }

        //Metodi accessor
        public string Stringa()
        {
            return stringa;
        }

        public int Numero()
        {
            return numero;
        }

        //distuttore
        ~Esempio()
        {
            Console.WriteLine("Distruttore chiamato. Pulizia delle risorse non gestite.");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose chiamato. Pulizia delle risorse gestite.");
            GC.SuppressFinalize(this);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creazione dell'istanza di Esempio.");
            using (Esempio es = new Esempio("Hello", 42))
            {
                Console.WriteLine($"Stringa: {es.Stringa()}, Numero: {es.Numero()}");
            }

            Console.WriteLine("Fine del Main. L'oggetto Esempio è stato distrutto o eliminato.");
            Console.ReadLine();
        }
    }
}
