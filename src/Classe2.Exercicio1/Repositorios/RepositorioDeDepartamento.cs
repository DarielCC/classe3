using Classe2.Exercicio1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe2.Exercicio1.Repositorios
{
    public class RepositorioDeDepartamento
    {
        private List<Departamento> _departamentos;

        public void AdicionarDepartamentos(IEnumerable<Departamento> departamentos)
        {
            if(_departamentos == null)
            {
                _departamentos = new List<Departamento>();
            }

            _departamentos.AddRange(departamentos);
        }
    }
}
