using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            //number of cards
            string[] stack = new string[52];
            Random r = new Random();
            //init variables
            int c = 0;
            bool[] choice = new bool[52];
            bool done = false;
            int s = 0;
            bool moreCard=true;
            int poäng = 0;
            int poängSumma = 0;

            //cards choice
            for (int i = 0; i < 52; i++)
            {
                choice[i] = true;
            }

            //value
            for (int i = 0; i < 13; i++)
            {
                stack[i] ="hjärter "+ (i+1);
            }

            for (int i = 13; i < 26; i++)
            {
                stack[i] = "klöver "+ (i-12);
            }

            for (int i = 26; i < 39; i++)
            {
                stack[i] = "ruter "+(i-25);
            }

            for (int i = 39; i < 52; i++)
            {
                stack[i] ="spader "+(i-38);
            }

            //Card yes/no
            while (moreCard)
            {
                done = false;
                Console.WriteLine("Vill du ha ett kort?");
                string pick = Console.ReadLine();

                if (pick == "ja" || pick == "Ja" || pick == "JA")
                {
                    moreCard = true;
                }

                if (pick == "nej" || pick == "Nej" || pick == "NEJ")
                {
                    moreCard = false;
                }

                //Score
                if (moreCard)
                {
                    while (!done)
                    {
                        c = r.Next(0, 52);
                        if (choice[c])
                        {
                            Console.WriteLine("Du drog "+stack[c]);
                            choice[c] = false;
                            s++;

                            string[] cardsDrawn = stack[c].Split(' ');
                            poäng = Convert.ToInt32(cardsDrawn[1]);
                            poängSumma += poäng;

                            if (poängSumma > 21)
                            {
                                Console.WriteLine(", du förlorade");
                                done = true;
                                moreCard = false;
                            }
                            else if (poängSumma == 21)
                            {
                                Console.WriteLine("Grattis 21!");
                                Console.ReadLine();
                                return;
                            }
                            else
                            {
                                Console.WriteLine(" och din poängsumma är "+poängSumma);
                                done = true;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Din poängsumma är "+ poängSumma);
                }

               
                }
                    
                }
                
            }
            

        }
