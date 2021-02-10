using System;

namespace Aula_100221
{
    class Program
    {
        class Veiculo
        {
            public string Nome;
            public string Marca;
            public Placa IdPlaca;
        }

        class Placa
        {
            public string Letras;
            public int Numero;
        }

        static void Main(string[] args)
        {
            {
                Veiculo[] Cadastro = new Veiculo[3];

                for (int i = 0; i < 3; i++)
                {

                    Veiculo MeuVeiculo = new Veiculo();

                    Console.Write("Nome da veiculo:");
                    MeuVeiculo.Nome = Console.ReadLine();

                    Console.Write("Marca do veiculo:");
                    MeuVeiculo.Marca = Console.ReadLine();

                    MeuVeiculo.IdPlaca = new Placa();

                    Console.Write("Placa - Letras:");
                    MeuVeiculo.IdPlaca.Letras = Console.ReadLine();

                    Console.Write("Placa - Numero:");
                    MeuVeiculo.IdPlaca.Numero = int.Parse(Console.ReadLine());

                    Console.Write("\n\n");

                    Cadastro[i] = MeuVeiculo;   
                }
                Console.Clear();

                foreach (Veiculo V in Cadastro)
                {
                    Console.WriteLine("{0} - {1}", V.Nome, V.Marca);
                    Console.WriteLine($"Placa: {V.IdPlaca.Letras}-{V.IdPlaca.Numero}\n");
                }
                Console.ReadKey();
            }
        }
    }
}