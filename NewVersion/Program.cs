using System;
using System.Collections.Generic;
using System.Linq;

namespace NewVersion
{
    class Program
    {
        static Dictionary<string, DateTime> dicionarioPessoas = new Dictionary<string, DateTime>();

        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Seja Bem vindo ao gerenciamento de aniversários.");
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1- Adicionar nova pessoa");
            Console.WriteLine("2- Pesquisar pessoa");
            Console.WriteLine("3- Sair");

            var opcao = int.Parse(Console.ReadLine());


            while (opcao != 3)
            {
                switch (opcao)
                {
                    case 1:
                        adicionarPessoa();
                        break;
                    case 2:
                        pesquisarPessoa();
                        break;
                    case 3:
                        break;
                }

            }

        }
        public static void adicionarPessoa()
        {
            Console.WriteLine("Digite o nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome da pessoa:");
            var sobrenome = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento da pessoa no formato dd/mm/aaaa:");
            var dataNascimento = Console.ReadLine();

            var nomeConcatenado = nome + sobrenome;
            var dataCerta = Convert.ToDateTime(dataNascimento);

            Console.WriteLine("Os dados estão corretos?");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sobrenome: {sobrenome}");
            Console.WriteLine($"Data de Nascimento: {dataNascimento}");
            Console.WriteLine("1- Sim");
            Console.WriteLine("2 - Não");
            var opcao2 = int.Parse(Console.ReadLine());

            if (opcao2 == 1)
            {
                dicionarioPessoas.Add(nomeConcatenado, dataCerta);
                Console.WriteLine("Pessoa adicionada com sucesso");
            }
            else
            {
                Console.WriteLine("Dados descartados. Reinicie o programa para colocar os dados novamente.");
            }

        }

        public static void pesquisarPessoa()
        {
            Console.WriteLine("Digite o nome do usuário que quer encontrar os dados: ");
            var termoDePesquisa = Console.ReadLine();

            var pessoasEncontradas = (from pessoa in dicionarioPessoas where pessoa.Key.ToLower().Contains(termoDePesquisa.ToLower()) select pessoa).ToList();

            if (pessoasEncontradas.Count > 0)
            {
                Console.WriteLine("Selecione as pessoas abaixo");
                for (var i = 0; i <pessoasEncontradas.Count; i++)
                {
                    Console.WriteLine($"{i} - {pessoasEncontradas[i].Key}");
                }

                var indexAExibir = Convert.ToInt32(Console.ReadLine());


            }

        }
    }
}
