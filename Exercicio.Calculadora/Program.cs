using System;

namespace Exercicio.Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //tenta executar codigo
            try
            {
                #region codigo aqui

                Console.WriteLine("Insira um valor:");
                var valorDigitadoUm = Console.ReadLine();
                decimal valorConvertidoUm = decimal.Parse(valorDigitadoUm);

                Console.WriteLine("Insira outro valor:");
                var valorDigitadoDois = Console.ReadLine();
                decimal valorConvertidoDois = decimal.Parse(valorDigitadoDois);

                // interpolacao
                //Console.WriteLine($"Resultado Soma: {valorConvertidoUm + valorConvertidoDois}");

                //concatenacao
                Console.WriteLine("Resultado Soma: "
                    + (valorConvertidoUm + valorConvertidoDois));

                Console.WriteLine("Resultado Subtração: "
                    + (valorConvertidoUm - valorConvertidoDois));

                Console.WriteLine("Resultado Multiplicação: "
                    + (valorConvertidoUm * valorConvertidoDois));

                Console.WriteLine("Resultado Divisão: "
                    + (valorConvertidoUm / valorConvertidoDois));

                Console.WriteLine("Resultado Resto Divisão: "
                    + (valorConvertidoUm % valorConvertidoDois));

                #endregion codigo aqui
            }
            //captura erro/falha/excecao
            catch 
            {
                Console.WriteLine("Digite um valor correto!");
            }
            //finaliza o sistema
            finally
            {
                Console.ReadKey();
            }
        }
    }
}