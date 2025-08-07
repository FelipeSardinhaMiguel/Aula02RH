using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula02RH.Models.Enuns;

namespace Aula02RH.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        public TipoFuncionarioEnuns /*<-- isso aqui é a minha classe e lá na pasta Enuns, está os meu atributos.*/ TipoFuncionario { get; set; }
        public int MyProperty { get; set; }

        /*Abaixo estão os metodos*/

        public void ReajustarSalario()
        {
            Salario = Salario + (Salario * 10/100);
        }

        public string ExibirPeriodoExperiencia()
        {
            String PeriodoExperiencia = string.Format("Periodo de experiência: {0} até {1}", DataAdmissao, DataAdmissao.AddMonths(3));
            return PeriodoExperiencia;
        }

        public decimal CalcularDescVT(decimal percentual)
        {
            decimal desconto = this.Salario * percentual/100;
            return desconto;
        }

    }
}