using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaRA
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Curso { get; set; }

        public Pessoa(string nome, string curso)
        {
            Nome = nome;
            Curso = curso;
        }
    }
}
