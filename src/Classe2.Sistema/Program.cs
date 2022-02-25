// See https://aka.ms/new-console-template for more information
using Classe2.Exercicio1.Entidades;
using Classe2.Exercicio1.Repositorios;

Console.WriteLine("Meus funcionarios");

try
{
    Funcionario funcionario1 = new Funcionario();
    funcionario1.Nome = "Dariel";
    funcionario1.Especialidade = "Desenvolvedor";
    funcionario1.AnosExperiencia = 9;
    funcionario1.AdicionarDataNascimento(new DateTime(1987, 3, 3));
    funcionario1.NoIdentidade = "254.658.541-54";
    funcionario1.IdDepartamento = 1;

    Funcionario funcionario2 = new Funcionario();
    funcionario2.Nome = "Maria";
    funcionario2.Especialidade = "Marketing";
    funcionario2.AnosExperiencia = 5;
    funcionario2.AdicionarDataNascimento(new DateTime(1990, 10, 30));
    funcionario2.NoIdentidade = "598.236.555-54";
    funcionario2.IdDepartamento = 1;

    Funcionario funcionario3 = new Funcionario();
    funcionario3.Nome = "João";
    funcionario3.Especialidade = "Front-End";
    funcionario3.AnosExperiencia = 3;
    funcionario3.AdicionarDataNascimento(new DateTime(2000, 10, 30));
    funcionario3.NoIdentidade = "658.658.555-54";
    funcionario3.IdDepartamento = 2;

    FuncionarioTerceirizado funcionario4 = new FuncionarioTerceirizado();
    funcionario4.NoContrato = 123;
    funcionario4.Nome = "Pedro";
    funcionario4.Especialidade = "XPTO";
    funcionario4.AnosExperiencia = 6;
    funcionario4.AdicionarDataNascimento(new DateTime(1998, 10, 30));
    funcionario4.NoIdentidade = "658.658.987-54";
    funcionario4.IdDepartamento = 2;

    Departamento departamento1 = new Departamento() { 
        IdDepartamento = 1,
        Nome = "Financeiro",
        Setor = "Administração"    
    };

    Departamento departamento2 = new Departamento()
    {
        IdDepartamento = 2,
        Nome = "Desenvolvimento",
        Setor = "TI"
    };


    departamento1.AdicionarFuncionario(funcionario1);
    departamento1.AdicionarFuncionario(funcionario2);
    departamento2.AdicionarFuncionario(funcionario3);
    departamento2.AdicionarFuncionario(funcionario4);


    var departamentos = new List<Departamento> { departamento1, departamento2 };

    RepositorioDeDepartamento repositorioDeDepartamento = new RepositorioDeDepartamento();
    repositorioDeDepartamento.AdicionarDepartamentos(departamentos);

    Console.WriteLine("-----------------------");
    Console.WriteLine("Digite o Id do Departamento: ");
    var idDepartamento = int.Parse(Console.ReadLine());
    var departamento = repositorioDeDepartamento.RetornarDepartamentoPorId(idDepartamento);
    Console.WriteLine("Digite o número de identidade: ");
    var noIdentidade = Console.ReadLine();
    var idade = departamento?.RetornatIdadeFuncionario(noIdentidade);
    Console.WriteLine($"A identidade do funcionario é: {idade}");
    Console.WriteLine("-----------------------");
    var quantidadeDeFuncionarios = departamento?.QuantidadeFuncionarios(idDepartamento);
    Console.WriteLine($"A quantidade de funcionários do departamento é: {quantidadeDeFuncionarios}");
    
    Console.WriteLine("-----------------------");
    var noContrato = departamento?.RetornatNoContratoFuncionario(noIdentidade);
    Console.WriteLine($"O número do contrato é: {noContrato}");








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


