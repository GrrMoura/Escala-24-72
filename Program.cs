using System;
using System.IO;
using Projeto.Entities;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data da escala ex: 01/12/2020");
            string DateString = "01/05/2020"; // Console.ReadLine();

            DateTime Data = new DateTime();
            Data = DateTime.Parse(DateString);

            Guarnicao Guarnicao = new Guarnicao();
            Meses Mes = new Meses(Data);
            Escala Escala = new Escala();

            Escala.finaisDeSemana(Mes.FirstDomingo, Mes.QuantDiaMes);

            Mes.Feriados();

            Escala.FeriadosEfinaisDeSemana(Mes.DiasQueSaoFeriados, Mes.quantferiado);
            Guarnicao.CadastrarGuarnicao();



            StreamWriter texto; // para criar textos "assemble system.io"
            string CaminhoNome = "C:\\Users\\Geibi\\Desktop\\arq01.txt";
            texto = File.CreateText(CaminhoNome);


            for (int i = 0; i < 4; i++) // para criar texto na area de trabalho
            {
                texto.WriteLine("\n" + Guarnicao.Duplas[i].ToUpper());
                texto.WriteLine(" \t 12 HORAS");
                for (int l = 0 + 1 + i; l < 32; l += 4)
                {
                    if (Guarnicao.DiasTrabalho[i, l] != Escala.FinaisSemana[l])
                        texto.WriteLine(Data.AddDays(l - 1).ToLongDateString() + "\n");
                }
                texto.WriteLine(" \t 24 HORAS");
                for (int l = 0 + i + 1; l < 32; l += 4)
                {
                    if (Guarnicao.DiasTrabalho[i, l] == Escala.FinaisSemana[l] && Escala.FinaisSemana[l] != 0)
                    {
                        texto.WriteLine(Data.AddDays(l - 1).ToLongDateString());
                    }
                }
                texto.WriteLine("---------------------------------");
            }
            texto.Close();
        }
    }
}

