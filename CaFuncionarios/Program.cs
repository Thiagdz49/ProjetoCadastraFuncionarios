// See https://aka.ms/new-console-template for more informationC
using CaFuncionarios;
using System;
using System.Globalization;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;

var culture = new CultureInfo("pt-BR"); // Definindo a cultura para pt-BR para formatação de datas e números

Thread.CurrentThread.CurrentCulture = culture;
Thread.CurrentThread.CurrentUICulture = culture;

Console.Title = "Cadastro de Funcionários";
Console.ForegroundColor = ConsoleColor.Green; // alterando cor das letras
Console.BackgroundColor = ConsoleColor.Black; // Mudando cor de fundo
List<Funcionario> funcionarios = new List<Funcionario>(); // Lista com os Funcionários
funcionarios.Add(new Funcionario() { Matricula = 1, Nome = "zeruela", Endereço = "Rua dos Bobos", Cidade = "São Paulo", Uf = "SP", Cep = "18040-150", Cpf = "300.300.200-20", Telefone = "(11) 94596-5439", Email = "zeruela123@gmail.com", Datanasc = new DateTime(02,09,1990) });
funcionarios.Add(new Funcionario() { Matricula = 2, Nome = "Charles", Endereço = "São guilherme", Cidade = "Sorocaba", Uf = "SP", Cep = "18074-34", Cpf = "23300998700", Telefone = "(15) 99873-2123", Email = "carlos44@gmail.com", Datanasc = new DateTime(15,08,2016) });
int opcao = 0;

try
{
    do
    {
        Console.Clear();

        Funcionario funcionario;

        Console.WriteLine(Console.Title); 
        Console.WriteLine("Escolha umas das opções abaixo:" +
            "\n1. Cadastrar um Funcionário" +
            "\n2. Listar os Funcionários" +
            "\n3. Editar Funcionário" +
            "\n4. Consultar um Funcionário" +
            "\n5. Excluir um Funcionário" +
            "\n0. Sair"
            );
        opcao = int.Parse(Console.ReadLine());
        // TODO: Continues here
        switch (opcao)
        {
            case 1://Cadastrar
                Console.Clear();
                funcionario = new Funcionario();
                Console.WriteLine("Cadastrar um Funcionário");
                Console.WriteLine("Informe a matrícula: ");
                funcionario.Matricula = int.Parse(Console.ReadLine()!);
                if (funcionarios.Any(f => f.Matricula == funcionario.Matricula)) // Verificação de matricula ja existente.
                {
                    Console.WriteLine("Matrícula já existente");
                    break;
                }
                Console.WriteLine("Informe o Nome: ");
                funcionario.Nome = Console.ReadLine()!;
                Console.WriteLine("Informe o endereço: ");
                funcionario.Endereço = Console.ReadLine()!;
                Console.WriteLine("Informe o Cidade: ");
                funcionario.Cidade = Console.ReadLine()!;
                Console.WriteLine("Informe o uf: ");
                funcionario.Uf = Console.ReadLine()!;
                Console.WriteLine("Informe o Cep: ");
                funcionario.Cep = Console.ReadLine()!;
                Console.WriteLine("Informe o Cpf: ");
                funcionario.Cpf = Console.ReadLine()!;
                Console.WriteLine("Informe o Telefone: ");
                funcionario.Telefone = Console.ReadLine()!;
                Console.WriteLine("Informe o Email: ");
                funcionario.Email = Console.ReadLine()!;
                Console.WriteLine("Informe o Data de nascimento: ");
                funcionario.Datanasc = DateTime.Parse(Console.ReadLine()!);
                funcionarios.Add(funcionario);
                break;
            case 2://Listar
                Console.Clear();
                Console.WriteLine("Listagem dos funcionários: ");
                foreach (var item in funcionarios)
                {
                    Console.WriteLine(item.ToString() + "\n");
                }
                break;
            case 3:// Editar
                Console.WriteLine("Alterando funcionários:");
                Console.WriteLine("informe a matricula desejada: ");
                int mat = int.Parse(Console.ReadLine()!);
                bool nothave = true;
                foreach(var func in funcionarios)
                {
                    if (func.Matricula == mat)
                    {
                        nothave = false;
                        Console.WriteLine("Informe o Nome: ");
                        func.Nome = Console.ReadLine()!;
                        Console.WriteLine("Informe o endereço: ");
                        func.Endereço = Console.ReadLine()!;
                        Console.WriteLine("Informe o Cidade: ");
                        func.Cidade = Console.ReadLine()!;
                        Console.WriteLine("Informe o uf: ");
                        func.Uf = Console.ReadLine()!;
                        Console.WriteLine("Informe o Cep: ");
                        func.Cep = Console.ReadLine()!;
                        Console.WriteLine("Informe o Cpf: ");
                        func.Cpf = Console.ReadLine()!;
                        Console.WriteLine("Informe o Telefone: ");
                        func.Telefone = Console.ReadLine()!;
                        Console.WriteLine("Informe o Email: ");
                        func.Email = Console.ReadLine()!;
                        Console.WriteLine("Informe o Data de nascimento: ");
                        func.Datanasc = Lerdata();
                        Console.WriteLine("Alterado com sucesso");
                    }
                }
                if (nothave)
                {
                    Console.WriteLine("Nao tem funcionário desssa matrícula.");
                }
                break;
            case 4://Consultar 
                Console.Clear();
                Console.WriteLine("Consultar Funcionário");
                Console.WriteLine("Informe a Matricula:");
                int Mat = int.Parse(Console.ReadLine()!);
                foreach (var fun in funcionarios)
                {
                    if (fun.Matricula == Mat)
                    {
                        Console.WriteLine(fun.ToString());
                    }
                }
                    
                break;
            case 5://Excluir
                Console.Clear();    
                Console.WriteLine("Informe a matrícula");
                int mati = int.Parse(Console.ReadLine()!); 
                for (int i = 0; i < funcionarios.Count; i++)
                {
                    if (funcionarios[i].Matricula == mati)
                    {
                        funcionarios.RemoveAt(i);
                        Console.WriteLine("Funcionário excluido");
                    }   
                }
                break;
            case 0://Sair
                Console.WriteLine("Até breve...");
                break;
            default:
                Console.WriteLine("Opção Invalida");
                break;
        }
        Console.WriteLine("Pressionae um tecla para continuar....");
        Console.ReadKey(); 

    } while (opcao != 0);
}
catch (Exception ex)
{
    Console.WriteLine("Aconteceu um erro \n" + ex.Message);
}

static DateTime Lerdata()
{
    while (true)
    { 
        string input = Console.ReadLine()!;
        if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))

        {
            return data;
        }
        else
        {
            Console.WriteLine("Data inválida. Por favor, tente novamente.");
        }
    }
}





