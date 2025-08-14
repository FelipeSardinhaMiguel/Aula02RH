using System;
using Aula02RH.Models;
using Aula02RH.Models.Enuns;

namespace Aula02RH
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            f.Id = 10;
            f.Nome = "CR7";
            f.CPF = "12345678910";
            f.DataAdmissao = DateTime.Parse("01/01/2000");
            f.Salario = 1000.00M;
            f.TipoFuncionario = TipoFuncionarioEnuns.Aprendiz;

            string mensagem = f.ExibirPeriodoExperiencia();
            Console.WriteLine(mensagem);

            Funcionario func = new Funcionario();

            Console.WriteLine("Digite o ID do seu funcionario: ");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do seu funcionario: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do seu funcionario.");
            func.CPF = Console.ReadLine();
            

            Console.WriteLine("Digite a data de admissão: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salario do seu funcionario: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo que ele é (1 - CLT ou 2 - Aprendiz): ");
            int opcao = int.Parse(Console.ReadLine());


            func.TipoFuncionario = (opcao ==1) ? TipoFuncionarioEnuns.CLT : TipoFuncionarioEnuns.Aprendiz;

            func.ReajustarSalario();
            decimal valorDescontoVT = func.CalcularDescVT(6);

            Console.WriteLine("=========================================");
            Console.WriteLine($"O seu funcionario é: {func.Nome}.\n");
            Console.WriteLine($"O CPF dele é: {func.CPF}.\n");
            Console.WriteLine($"O salario reajustado é R${func.Salario}.\n");
            Console.WriteLine($"O Desconto do VT é R${valorDescontoVT}.");
            Console.WriteLine("=========================================");

            Console.WriteLine($"Então o {func.TipoFuncionario}, cujo o nome {func.Nome} proprietário do CPF {func.CPF}, que foi incluido no dia {func.DataAdmissao}, que possui o id {func.Id}, e no momento esta com um salario de R${func.Salario} e com o VT de aproximadamente R${valorDescontoVT}");

        }
    }
}