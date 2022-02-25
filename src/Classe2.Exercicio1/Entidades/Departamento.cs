namespace Classe2.Exercicio1.Entidades
{
    public class Departamento
    {
        private string _nome;
        private string _setor;
        private int _idDepartamento;

        private IList<Funcionario> _funcionarios;

        public string Nome { get => _nome; set => _nome = value; }
        public string Setor { get => _setor; set => _setor = value; }
        public int IdDepartamento { get => _idDepartamento; set => _idDepartamento = value; }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if (_funcionarios is null)
            {
                _funcionarios = new List<Funcionario>();
            }

            _funcionarios.Add(funcionario);
        }

        public int RetornatNoContratoFuncionario(string noIdentidade)
        {
            var funcionario = _funcionarios.FirstOrDefault(func => func.NoIdentidade == noIdentidade);

            if (funcionario is null)
                throw new Exception($"Funcionario com identidade {noIdentidade} não encontrado");
            
            if(funcionario is FuncionarioTerceirizado)
                return (funcionario as FuncionarioTerceirizado).NoContrato;

            throw new Exception($"O funcionário com identidade {noIdentidade} não possui Número de Contrato");
        }

        public int RetornatIdadeFuncionario(string noIdentidade)
        {
            var funcionario = _funcionarios.FirstOrDefault(func => func.NoIdentidade == noIdentidade);

            if (funcionario == null)
            {
                throw new Exception($"Funcionario com identidade {noIdentidade} não encontrado");
            }

            return funcionario.CalcularIdade;
        }

        public int QuantidadeFuncionarios(int idDepartamento)
            => _funcionarios.Count(func => func.IdDepartamento == idDepartamento);
    }
}
