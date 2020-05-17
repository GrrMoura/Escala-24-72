using System;
namespace Projeto.Entities
{
    class Escala
    {
        public int[] FinaisSemana = new int[32];

        public void finaisDeSemana(int firstDomingo, int quantDiaMes) //descobrir os finais de semana
        {
            for (int i = firstDomingo; i <= quantDiaMes; i += 7)
            {
                FinaisSemana[i] = i;
                if (i >= 2)
                {
                    FinaisSemana[i - 1] = i - 1;
                }
            }
        }
        public void FeriadosEfinaisDeSemana(int[] diasferiados, int quantFeriados)
        //acrescnetando os feriados aos finais de semana para depois comprar com os dias trabalhados
        {
            for (int i = 1; i <= quantFeriados; i++)
            {
                FinaisSemana[diasferiados[i]] = diasferiados[i];
            }
        }
    }
}
