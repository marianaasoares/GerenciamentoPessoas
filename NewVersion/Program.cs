using System;
using System.Collections.Generic;
using System.Linq;

namespace NewVersion
{
    class Program
    {
        static Dictionary<string, DateTime> dicionarioPessoas = new Dictionary<string, DateTime>();

        static string inicio = "Pressione qualquer tecla para voltar ao menu inicial ...";

        static void Main(string[] args)
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Olá! Seja Bem vindo ao gerenciamento de aniversários.");
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1- Adicionar nova pessoa");
                Console.WriteLine("2- Pesquisar pessoa");
                Console.WriteLine("3- Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        adicionarPessoa();
                        break;
                    case "2":
                        pesquisarPessoa();
                        break;
                    case "3":
                        break;

                }

            } while (opcao != "3");


        }
        public static void adicionarPessoa()
        {
            Console.WriteLine("Digite o nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite o sobrenome da pessoa:");
            var sobrenome = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento da pessoa no formato dd/mm/aaaa:");
            var dataNascimento = Console.ReadLine();

            var dataCerta = Convert.ToDateTime(dataNascimento);

            Console.WriteLine("Os dados estão corretos?");
            Console.WriteLine($"Nome: {nome} {sobrenome}");
            Console.WriteLine($"Data de Nascimento: {dataNascimento: dd/MM/yyyy}");
            Console.WriteLine("1- Sim");
            Console.WriteLine("2 - Não");
            var opcao2 = Console.ReadLine();

            if (opcao2 == "1")
            {
                dicionarioPessoas.Add($"{nome} {sobrenome}", dataCerta);
                Console.WriteLine($"Pessoa adicionada com sucesso! {inicio}");
            }
            else
            {
                Console.WriteLine("Dados descartados. Reinicie o programa para colocar os dados novamente...");
                Console.ReadKey();
            }

        }

        public static void pesquisarPessoa()
        {
            Console.WriteLine("Digite o nome do usuário que quer encontrar os dados: ");
            var termoDePesquisa = Console.ReadLine();

            var pessoasEncontradas = (from pessoa in dicionarioPessoas
                                      where pessoa.Key.ToLower().Contains(termoDePesquisa.ToLower())
                                      select pessoa).ToList();

            if (pessoasEncontradas.Count > 0)
            {
                Console.WriteLine("Selecione uma das pessoas encontradas abaixo: ");
                for (var i = 0; i <pessoasEncontradas.Count; i++)
                {
                    Console.WriteLine($"{i} - {pessoasEncontradas[i].Key}");
                }

                var indexAExibir = Convert.ToInt32(Console.ReadLine());

                if (indexAExibir < pessoasEncontradas.Count)
                {
                    var pessoa = pessoasEncontradas[indexAExibir];

                    Console.WriteLine("Dados da pessoa escolhida:");
                    Console.WriteLine($"Nome completo: {pessoa.Key}");
                    Console.WriteLine($"Data de nascimento: {pessoa.Value:dd/MM/yyyy}");

                    var dataNascimentoAtual = new DateTime(DateTime.Now.Year, pessoa.Value.Month, pessoa.Value.Day);

                    var tempoAniversario = dataNascimentoAtual - DateTime.Now.Date;

                    if(tempoAniversario.Days > 0)
                    
                        Console.Write($"Faltam {tempoAniversario.Days} dia(s) para esse aniversário. {inicio}");

                    else if (tempoAniversario.Days == 0)
                    
                        Console.WriteLine($"Feliz Aniversário! {inicio}");
                    
                    else
                
                        Console.WriteLine($"Infelizmente você já fez aniversário esse ano. {inicio}");
                    
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Opção inválida. {inicio}");
                    Console.ReadKey();
                }


            }
            else {
                Console.WriteLine($"Pessoa não encontrada, tente novamente. {inicio}");
                Console.ReadKey();

            }


        }
    }
}
