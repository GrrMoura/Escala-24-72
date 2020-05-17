using System;

namespace Projeto
{
    class Meses
    {
        public int QuantDiaMes, FirstDomingo, quantferiado;
        public int[] DiasQueSaoFeriados = new int[6];
        public Meses(DateTime data)
        {
            int d1 = data.Month;// pegando o mes para saber quantos dias possui
            switch (d1)
            {
                case 04:
                case 06:
                case 09:
                case 11:
                    QuantDiaMes = 30;
                    break;

                case 02:
                    QuantDiaMes = 28;
                    break;

                default:
                    QuantDiaMes = 31;
                    break;
            }
            string diaSemana = data.DayOfWeek.ToString();
            /*poderia usar enums,mas nao consegui... ver depois..
              descobrindo qual o primeiro dia da semana, 
              para saber qual é o primeiro domingo dos mês*/
            switch (diaSemana)
            {
                case "Monday":
                    FirstDomingo = 7;
                    break;

                case "Tuesday":
                    FirstDomingo = 6;
                    break;

                case "Wednesday":
                    FirstDomingo = 5;
                    break;

                case "Thursday":
                    FirstDomingo = 4;
                    break;

                case "Friday":
                    FirstDomingo = 3;
                    break;

                case "Saturday":
                    FirstDomingo = 2;
                    break;

                default:
                    FirstDomingo = 1;
                    break;
            }
        }
        public void Feriados() // cadastrando a quantidade de feriados e quais dias
        {
            Console.WriteLine("Quantos feriados?|n[0] para nenhum;");
            quantferiado = int.Parse(Console.ReadLine());

            if (quantferiado != 0)
            {
                Console.WriteLine("Qual ou quais os Dias?");

                for (int i = 1; i <= quantferiado; i++)
                {
                    Console.Write("Digite o {0}º: ", i);
                    DiasQueSaoFeriados[i] = int.Parse(Console.ReadLine());
                }
            }
            else { }
        }
    }
}