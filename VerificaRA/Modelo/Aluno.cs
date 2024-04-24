using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaRA.Modelo
{
    public class Aluno(string nome, string curso, string numeroRegistro) : Pessoa(nome, curso)
    {
        public string NumeroRegistro { get; } = numeroRegistro;
    }
}
