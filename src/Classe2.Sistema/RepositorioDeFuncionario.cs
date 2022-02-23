using Classe2.Exercicio1.Entidades;

namespace Classe2.Sistema
{
    public class RepositorioDeFuncionario
    {
        private List<Funcionario> _funcionários;

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if(_funcionários is null)
            {
                _funcionários = new List<Funcionario>();
            }

            _funcionários.Add(funcionario);
        }

        public int RetornatIdadeFuncionario(string noIdentidade)
        {
            var funcionario = _funcionários.FirstOrDefault(func => func.NoIdentidade == noIdentidade);

            if(funcionario == null)
            {
                throw new Exception($"Funcionario com identidade {noIdentidade} não encontrado");
            }

            return funcionario.CalcularIdade;
        }
    }
}
