using System;

namespace TestedePerfomance02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Seja Bem vindo ao gerenciamento de aniversários.");
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1- Adicionar nova pessoa");
            Console.WriteLine("2- Pesquisar pessoa");
            Console.WriteLine("3- Sair");

            var opcao = int.Parse(Console.ReadLine());


            if (opcao == 1)
            {
                Console.WriteLine("Digite o nome:");
                var nome = Console.ReadLine();
                Console.WriteLine("Digite o sobrenome da pessoa:");
                var sobrenome = Console.ReadLine();
                Console.WriteLine("Digite a data de nascimento da pessoa no formato dd/mm/aaaa:");
                var dataNascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Os dados estão corretos?");
                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Sobrenome: {sobrenome}");
                Console.WriteLine($"Data de Nascimento: {dataNascimento}");

                Console.WriteLine("1- Sim");
                Console.WriteLine("2 - Não");
                var opcao2 = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Os dados foram salvos com sucesso!");
                }
                else
                {
                    Console.WriteLine("Os dados não foram salvos, repita a operação.");
                }
            } else if (opcao == 2)
            {
                Console.WriteLine("Selecione uma das opções abaixo:");

            }


        }
    }
}
