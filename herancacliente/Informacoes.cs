using System;
namespace herancacliente
{
    public class Informacoes
    {

        public void Informecoes(int tipo)
        {

            Bairro bairro = new Bairro();

            Console.WriteLine("Informe o Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o Bairro: ");
            bairro.Nome = Console.ReadLine();

            Console.WriteLine("Informe o Telefone: ");
            string telefone = Console.ReadLine();

            switch (tipo)
            {
                case 1:
                    Console.WriteLine("Informe o CPF: ");
                    string cpf = Console.ReadLine();
                    ClienteFisico clienteFisico = new ClienteFisico(nome, bairro, telefone, cpf);
                    Console.Clear();
                    Console.WriteLine("CLIENTE FISICO: \nNOME: {0}\nBAIRRO: {1}\nTELEFONE: {2}\nCPF: {3}", clienteFisico.nome, clienteFisico.bairro.Nome, clienteFisico.telefone, clienteFisico.cpf);
                    break;
                case 2:
                    Console.WriteLine("Informe o CNPJ: ");
                    string cnpj = Console.ReadLine();
                    ClienteJuridico clienteJuridico = new ClienteJuridico(nome, bairro, telefone, cnpj);
                    Console.Clear();
                    Console.WriteLine("CLIENTE JURIDICA: \nNOME: {0}\nBAIRRO: {1}\nTELEFONE: {2}\nCNPJ: {3}", clienteJuridico.nome, clienteJuridico.bairro.Nome, clienteJuridico.telefone, clienteJuridico.cnpj);
                    break;
                default:
                    Console.WriteLine("Opcao incorreta");
                    break;
            }
        }
    }
}
