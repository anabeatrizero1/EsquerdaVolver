using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comandos;
            char [] charComandos;
            int numeroDeComandos;
            char direcao = 'N';

            while (true)
            {

                Console.WriteLine("Digite o número de comandos: (1 a 1000) ");
                numeroDeComandos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite sequencialmente os comandos: (D- para esqueda |E - para direita)");
                comandos = Console.ReadLine().ToUpper();
                charComandos = comandos.ToCharArray();

                for (int i = 0; i < numeroDeComandos; i++)
                {
                    if (charComandos[0] == '0')
                    {
                        break;
                    }
                }
                

                for (int i = 0; i < numeroDeComandos; i++)
                {
                    switch (direcao)
                    {
                        case 'N':
                            if (charComandos[i] == 'D')
                            {
                                direcao = 'L';
                            }
                            else if (charComandos[i] == 'E')
                            {
                                direcao = 'O';
                            }
                            break;
                        case 'L':
                            if (charComandos[i] == 'D')
                            {
                                direcao = 'S';
                            }
                            else if (charComandos[i] == 'E')
                            {
                                direcao = 'N';
                            }
                            break;
                        case 'S':
                            if (charComandos[i] == 'D')
                            {
                                direcao = 'O';
                            }
                            else if (charComandos[i] == 'E')
                            {
                                direcao = 'L';
                            }
                            break;
                        case 'O':
                            if (charComandos[i] == 'D')
                            {
                                direcao = 'N';
                            }
                            else if (charComandos[i] == 'E')
                            {
                                direcao = 'S';
                            }
                            break;

                    }


                }
                Console.WriteLine(direcao);
                Console.ReadLine();
            }
        }
    }
}
