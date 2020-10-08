using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamen_papir_skare
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputIgrac, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain == true)
            {
                int bodoviIgrac = 0;
                int bodoviCPU = 0;

                while (bodoviIgrac < 3 && bodoviCPU < 3)
                {

                    Console.Write("Izaberite KAMEN, PAPIR ili ŠKARE:   ");
                    inputIgrac = Console.ReadLine();
                    inputIgrac = inputIgrac.ToUpper();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "KAMEN";
                            Console.WriteLine("CPU je odabrao KAMEN!");
                            if (inputIgrac == "KAMEN")
                            {
                                Console.WriteLine("NERIJEŠENO!\n\n");
                            }
                            else if (inputIgrac == "PAPIR")
                            {
                                Console.WriteLine("Igrač je pobijedio!\n\n");
                                bodoviIgrac++;
                            }
                            else if (inputIgrac == "ŠKARE" || inputIgrac == "SKARE")
                            {
                                Console.WriteLine("CPU je pobijedio!\n\n");
                                bodoviCPU++;
                            }
                            break;

                        case 2:
                            inputCPU = "PAPIR";
                            Console.WriteLine("CPU je odabrao PAPIR!");
                            if (inputIgrac == "KAMEN")
                            {
                                Console.WriteLine("CPU je pobijedio!\n");
                                bodoviCPU++;
                            }
                            else if (inputIgrac == "PAPIR")
                            {
                                Console.WriteLine("NERIJEŠENO!\n");
                            }
                            else if (inputIgrac == "ŠKARE" || inputIgrac == "SKARE")
                            {
                                Console.WriteLine("Igrač je pobijedio!\n");
                                bodoviIgrac++;
                            }
                            break;

                        case 3:
                            inputCPU = "ŠKARE";
                            Console.WriteLine("CPU je odabrao ŠKARE!");
                            if (inputIgrac == "KAMEN")
                            {
                                Console.WriteLine("Igrač je pobijedio!\n");
                                bodoviIgrac++;
                            }
                            else if (inputIgrac == "PAPIR")
                            {
                                Console.WriteLine("CPU je pobijedio!\n");
                                bodoviCPU++;
                            }
                            else if (inputIgrac == "ŠKARE" || inputIgrac == "SKARE")
                            {
                                Console.WriteLine("NERIJEŠENO!\n");
                            }
                            break;

                        default:
                            Console.WriteLine("Neispravan unos!");
                            break;
                    }
                    Console.WriteLine("\n\nBODOVI:\tIGRAČ:\t{0}\tCPU:\t{1}", bodoviIgrac, bodoviCPU);
                }

                if (bodoviIgrac == 3)
                {
                    Console.WriteLine("Igrač je pobjednik!");
                }
                else if (bodoviCPU == 3)
                {
                    Console.WriteLine("CPU je pobjednik!");
                }
                else
                {
                }

                Console.WriteLine("Želite li još igrati?(da/ne)");
                string odgovor = Console.ReadLine();
                odgovor = odgovor.ToUpper();

                if (odgovor == "DA")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (odgovor == "NE")
                {
                    playAgain = false;
                }
                else
                {
                }

            }
        }
    }
}
