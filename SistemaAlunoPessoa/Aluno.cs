using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlunoPessoa
{
    internal class Aluno : Pessoa
    {
        string matricula { get; set; }
        string codigoCurso { get; set; }
        string nomeCurso { get; set; }

        public Aluno(string nome, string telefone, string cidade, string rg, string cpf, string matricula, string codigoCurso, string nomeCurso) : base(nome, telefone, cidade, rg, cpf)
        {
            this.matricula = matricula;
            this.codigoCurso = codigoCurso;
            this.nomeCurso = nomeCurso;
        }
    }
}
