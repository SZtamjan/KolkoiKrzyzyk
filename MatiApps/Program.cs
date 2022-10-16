using System;

namespace MatiApps
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Zostaw to debilu
            char[] p = new char[10] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };


            
            bool win1 =false;
            int i=0;

            do
            {
                //Funkcje
                Console.Beep();
                Console.Clear();
                i++;
                pole(p);
                if ((p[1] == p[2]) && (p[2] == p[3]) && (p[1]!=' '))
                {
                    Console.WriteLine("Krzyzyk wygrywa");
                    break;
                }
                //Kolej na
                if (i % 2 == 0)
                {
                    int move;
                    do
                    {
                        
                        Console.WriteLine("Teraz kolej X");
                        move = Convert.ToInt32(Console.ReadLine());
                    } while (p[move] == 'O' || p[move] == 'X');
                    p[move] = 'X';
                    
                }
                else
                {
                    int move;
                    do
                    {
                        
                        Console.WriteLine("Teraz kolej O");
                        move = Convert.ToInt32(Console.ReadLine());
                    } while (p[move] == 'O' || p[move] == 'X');
                    p[move] = 'O';
                }

                //Tutaj pod tym napisz kiedyś sprawdzanie czy są 3 obok siebie te same znaki
                
            } while(win1=true);
        }
        static void pole(char[] p)
        {
            Console.Write(p[1]);
            Console.Write("|");
            Console.Write(p[2]);
            Console.Write("|");
            Console.WriteLine(p[3]);
            Console.WriteLine("------");
            Console.Write(p[4]);
            Console.Write("|");
            Console.Write(p[5]);
            Console.Write("|");
            Console.WriteLine(p[6]);
            Console.WriteLine("------");
            Console.Write(p[7]);
            Console.Write("|");
            Console.Write(p[8]);
            Console.Write("|");
            Console.WriteLine(p[9]);
        }
       /* static void win(char[] p)
        {
            bool winiary;
            if (p[1] == p[2] && p[2] == p[3])
            {
                winiary = true;
            }
        }*/
    }
}
