using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlunoPessoa
{
    internal class Pessoa
    {
        string nome { get; set; }
        string telefone { get; set; }
        string cidade { get; set; }
        string rg { get; set; }
        string cpf { get; set; }

        public Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cidade = cidade;
            this.rg = rg;
            this.cpf = cpf;
        }

        public static bool jaCadastrado(string cpf, string rg, List<Pessoa> lista)
        {
            foreach (Pessoa i in lista)
            {
                if (cpf.Equals(i.cpf))
                {
                    return true;
                }
                else if (rg.Equals(i.rg))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
