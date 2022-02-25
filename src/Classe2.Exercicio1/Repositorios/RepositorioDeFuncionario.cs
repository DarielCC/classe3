using Classe2.Exercicio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe2.Exercicio1.Repositorios
{
    public class RepositorioDeFuncionario
    {
        private List<Funcionario> _funcionarios;

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            if(_funcionarios == null)
            {
                _funcionarios = new List<Funcionario>();
            }

            _funcionarios.Add(funcionario);
        }
    }
}
