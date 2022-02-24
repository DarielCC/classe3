
namespace Classe2.Exercicio1.Entidades
{
    public class Funcionario
    {
        private string _nome;
        private string _noIdentidade;
        private int _anosExperiencia;
        private string _especialidade;
        private int _idDepartamento;

        public string Nome { get => _nome; set => _nome = value; }
        public string NoIdentidade { get => _noIdentidade; set => _noIdentidade = value; }
        public int AnosExperiencia { get => _anosExperiencia; set => _anosExperiencia = value; }
        public DateTime DataNascimento { get; private set; }
        public string Especialidade { get => _especialidade; set => _especialidade = value; }

        public int IdDepartamento { get => _idDepartamento; set => _idDepartamento = value; }

        public void AdicionarDataNascimento(DateTime dataNascimento)
        {
            if(dataNascimento < new DateTime(1940, 1, 1))
            {
                throw new Exception($"Funcionario-> Nome: {Nome} tem a Data de nascimento inválida");
            }

            DataNascimento = dataNascimento;
        }

        public int CalcularIdade => DateTime.Today.Year - DataNascimento.Year;

        public string RetorneDados => $"Nome: {Nome}, Idade: {CalcularIdade}";
    }
}
