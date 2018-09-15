using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while(scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("Escolhe entre PEDRA, PAPEL ou TESOURA: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();


                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "PEDRA";
                            Console.WriteLine("Computador escolhe PEDRA");
                            if (inputPlayer == "PEDRA")
                            {
                                Console.WriteLine("É um empate!\n\n");
                            }

                            else if (inputPlayer == "PAPEL")
                            {
                                Console.WriteLine("Tu ganhas!!\n\n");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "TESOURA")
                            {
                                Console.WriteLine("CPU ganhou!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPEL";
                            Console.WriteLine("Computador escolhe PAPEL");
                            if (inputPlayer == "PEDRA")
                            {
                                Console.WriteLine("CPU ganhou!\n\n");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "PAPEL")
                            {
                                Console.WriteLine("É um empate!!\n\n");

                            }

                            else if (inputPlayer == "TESOURA")
                            {
                                Console.WriteLine("Ganhaste!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "TESOURA";
                            Console.WriteLine("Computador escolhe TESOURA");
                            if (inputPlayer == "PEDRA")
                            {
                                Console.WriteLine("Ganhaste!\n\n");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "PAPEL")
                            {
                                Console.WriteLine("CPU ganhou!!\n\n");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "TESOURA")
                            {
                                Console.WriteLine("É um empate!\n\n");

                            }
                            break;
                        default:

                            break;
                    }

                    Console.WriteLine("\n\nPONTOS:\tJOGADOR:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
                }

                if(scorePlayer == 3)
                {
                    Console.WriteLine("GANHASTE!!!");
                }
                else if(scoreCPU == 3)
                {
                    Console.WriteLine("CPU GANHOU!!!");
                }
                else
                {

                }

                Console.WriteLine("Queres jogar outra vez?(s/n)");
                string loop = Console.ReadLine();
                if(loop == "s")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else { }
            }                            
        }
    }
}
