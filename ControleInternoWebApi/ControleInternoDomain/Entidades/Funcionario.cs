using ControleInternoDomain.Enums;
using System;

namespace ControleInternoDomain
{
    public  class Funcionario
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public DateTime DataDeAdmissao { get;}
        public DateTime DataDeNascimento { get;  set; }
        public double Salario { get; set; }
        public int NumeroDeMatricula { get;}
        public bool Status { get; set; }
        public ECargos Cargos { get; set; }

        public Funcionario (string nome,ECargos cargos)
        {
            Nome = nome;
            Cargos = cargos;
        }

        public Funcionario()
        {
            

        }


        public void AlterarSalario(double porcentagemDeAumento)
        {
            Salario *= porcentagemDeAumento;
        }

        public void AlterarStatus(bool status)
        {
            Status = status;
        }
    }
}
