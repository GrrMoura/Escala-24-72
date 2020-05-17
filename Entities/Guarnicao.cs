using System;
namespace Projeto.Entities

{
    class Guarnicao
    {
        public string[] Duplas = new string[5];
        public int[,] DiasTrabalho = new int[4, 32];
        public void CadastrarGuarnicao()
        {
            for (int i = 0; i < 4; i++) //Cadastrando as guarnições
            {
                System.Console.WriteLine("Digite o nome da {0}º Dupla", i);
                Duplas[i] = Console.ReadLine();
            }

            for (int i = 0; i < 4; i++)
            // cadastrando os dias de serviço das guarnições
            {
                for (int l = 0 + 1 + i; l < 32; l += 4)
                {
                    DiasTrabalho[i, l] = l;
                }

            }
        }
    }
}