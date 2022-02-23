﻿// See https://aka.ms/new-console-template for more information
using Classe2.Exercicio1.Entidades;
using Classe2.Sistema;

Console.WriteLine("Meus funcionarios");

try
{
    Funcionario funcionario1 = new Funcionario();
    funcionario1.Nome = "Dariel";
    funcionario1.Especialidade = "Desenvolvedor";
    funcionario1.AnosExperiencia = 9;
    funcionario1.AdicionarDataNascimento(new DateTime(1987, 3, 3));
    funcionario1.NoIdentidade = "254.658.541-54";

    Funcionario funcionario2 = new Funcionario();
    funcionario2.Nome = "Maria";
    funcionario2.Especialidade = "Marketing";
    funcionario2.AnosExperiencia = 5;
    funcionario2.AdicionarDataNascimento(new DateTime(1990, 10, 30));
    funcionario2.NoIdentidade = "598.236.555-54";

    Funcionario funcionario3 = new Funcionario();
    funcionario3.Nome = "João";
    funcionario3.Especialidade = "Front-End";
    funcionario3.AnosExperiencia = 3;
    funcionario3.AdicionarDataNascimento(new DateTime(2000, 10, 30));
    funcionario3.NoIdentidade = "658.658.555-54";


    RepositorioDeFuncionario repo = new RepositorioDeFuncionario();
    repo.AdicionarFuncionario(funcionario1);
    repo.AdicionarFuncionario(funcionario2);
    repo.AdicionarFuncionario(funcionario3);


    Console.WriteLine("-----------------------");
    Console.WriteLine("Digite o número de identidade: ");
    var noIdentidade = Console.ReadLine();
    var idade = repo.RetornatIdadeFuncionario(noIdentidade);
    Console.WriteLine($"A identidade do funcionario é: {idade}");








    /*Console.WriteLine("-----------------------");
    Console.WriteLine("Funcionario 1");
    Console.WriteLine("-----------------------");
    Console.WriteLine($"Nome: {funcionario1.Nome}");
    Console.WriteLine($"Especialidade: {funcionario1.Especialidade}");
    Console.WriteLine($"Experiencia: {funcionario1.AnosExperiencia}");
    Console.WriteLine($"CPF: {funcionario1.NoIdentidade}");
    Console.WriteLine($"Idade: {funcionario1.CalcularIdade}");

    Console.WriteLine("-----------------------");
    Console.WriteLine("Funcionario 2");
    Console.WriteLine("-----------------------");
    Console.WriteLine(funcionario2.RetorneDados);


    Console.WriteLine("-----------------------");
    Console.WriteLine("Funcionario 3");
    Console.WriteLine("-----------------------");
    Console.WriteLine(funcionario2.RetorneDados);*/
}
catch (Exception ex)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine(ex.Message);
}


