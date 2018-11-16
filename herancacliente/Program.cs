using System;

namespace herancacliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Informacoes informacoes = new Informacoes();

            Console.WriteLine("Escolha um tipo de cliente\n1 - Fisico\n2 - Juridico");
            int tipo = Convert.ToInt32(Console.ReadLine());

            informacoes.Informecoes(tipo);
        }
    }
}
