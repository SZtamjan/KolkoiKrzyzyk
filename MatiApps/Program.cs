﻿using System;

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
            Console.Beep();
            Console.Clear();
            Console.WriteLine(i % 2 == 0 ? "Teraz kolej O" : "Teraz kolej X");
            pole(p);
            
            do
            {

                i++;

                //Kolej na
                if (i % 2 == 0)
                {
                    int move;
                    do
                    {
                            move = Convert.ToInt32(Console.ReadLine());
                    } while (p[move] == 'O' || p[move] == 'X');
                    p[move] = 'X';
                    
                }
                else
                {
                    int move;
                    do
                    {
                        move = Convert.ToInt32(Console.ReadLine());
                    } while (p[move] == 'O' || p[move] == 'X');
                    p[move] = 'O';
                }

                
                //Funkcje
                Console.Beep();
                Console.Clear();
                Console.WriteLine(i % 2 == 0 ? "Teraz kolej O" : "Teraz kolej X");
                pole(p);
                win1 = win(p);
            } while(win1==false);
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
        static bool win(char[] p)
        {
            bool lmao = false;
            //Wygrane w poziomie
            if ((p[1] == p[2]) && (p[2] == p[3]) && (p[1] != ' '))
            {
                lmao = true;
                Console.WriteLine("Wygrywa " + p[1]);
            }
            if ((p[4] == p[5]) && (p[5] == p[6]) && (p[2] != ' '))
            {
                lmao = true;
                Console.WriteLine("Wygrywa " + p[4]);
            }
            if ((p[7] == p[8]) && (p[8] == p[9]) && (p[7] != ' '))
            {
                lmao = true;
                Console.WriteLine("Wygrywa " + p[7]);
            }
            //Wygrane w pionie
            if ((p[1] == p[4]) && (p[4] == p[7]) && (p[1] != ' '))
            {
                lmao = true;
                Console.WriteLine("Wygrywa " + p[1]);
            }
            if ((p[2] == p[5]) && (p[5] == p[8]) && (p[2] != ' '))
            {
                lmao = true;
                Console.WriteLine("Wygrywa " + p[2]);
            }
            if ((p[3] == p[6]) && (p[6] == p[9]) && (p[3] != ' '))
            {
                lmao = true;
                Console.WriteLine("Wygrywa " + p[3]);
            }
            //Wygrane po skosie
            if ((p[1] == p[5]) && (p[5] == p[9]) && (p[1] != ' '))
            {
                lmao = true;
                Console.WriteLine("Wygrywa " + p[1]);
            }
            if ((p[3] == p[5]) && (p[5] == p[7]) && (p[3] != ' '))
            {
                lmao = true;
                Console.WriteLine("Wygrywa " + p[3]);
            }

            return lmao;
        }
    }
}
