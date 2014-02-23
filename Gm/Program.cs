using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using System.Diagnostics;
namespace Gm
{


    class Program
    {

        static void Main(string[] args)
        {

            ConsoleKey K = new ConsoleKey();
            Console.CursorVisible = false;
            char[] Oldmap = new char [1999];
            char[] map = new char[1999];

            string Enveroment="";

            char GG='@';
            int GGAtk = 1;
            int GGdef = 1;
            int GGHp = 10;

            char Mob1,Mob2,Mob3,Mob4,Mob5;

            char[] Monstr =new char[10];

            int[] MonstrAtk = new int [10];
            int[] MonstrDef =  new int [10];
            int[] MonstrHp = new int [10];

            bool Invent1, Invent2, Invent3,Invent4,Invent5,Invent6,Invent7,Invent8,Invent9,Invent10;
            bool Game = true;
            bool lvlUpDate = true;

            bool fight = false;

            byte[] bytes = new byte[10];
         
            Invent1 = Invent2 = Invent3 = Invent4 = Invent5 = Invent6 = Invent7 = Invent8 = Invent9 = Invent10 = false;
            int i, Pos,deltaPos;
            Pos = 1150;
            

 /////////////////////////////////////////////////////////////////////           //////////////////////////////////////////////////////////////////////////////////

            while (Game)
            {
                if (lvlUpDate)
                {                   
                    using (StreamReader sr = new StreamReader("map.dat"))
                    {
                        String line = sr.ReadToEnd();
                        for (i = 0; i <= 1919; i++){
                            map[i] = line[i];
                        Oldmap[i]=line[i];
                        }
                    }
                    lvlUpDate = false;
                }

                Debug.WriteLine(fight);
                deltaPos = 0;
                K = Console.ReadKey().Key;
                switch (K)
                {
                    case ConsoleKey.I:  ////Inventori
                      
                        break;

                    case ConsoleKey.D:
                        deltaPos=Pos+1;
                        if (map[deltaPos] != '#')
                        {
                            Pos = deltaPos;
                            for (i = 0; i <= 1919; i++)
                                map[i] = Oldmap[i];
                                map[Pos] = GG;
                        }
                        break;

                    case ConsoleKey.A:
                       deltaPos=Pos-1;
                        if (map[deltaPos] != '#')
                        {
                            Pos = deltaPos;
                            for (i = 0; i <= 1919; i++)
                                map[i] = Oldmap[i];
                                map[Pos] = GG;
                        }
                        break;

                    case ConsoleKey.W:
                        //Thread.Sleep(100);
                         deltaPos=Pos-80;
                        if (map[deltaPos] != '#')
                        {
                            Pos = deltaPos;
                            for (i = 0; i <= 1919; i++)
                                map[i] = Oldmap[i];
                                map[Pos] = GG;
                        }
                        break;

                    case ConsoleKey.S:
                         deltaPos=Pos+80;
                        if (map[deltaPos] != '#')
                        {
                            Pos = deltaPos;
                            for (i = 0; i <= 1919; i++)
                                map[i] = Oldmap[i];
                                map[Pos] = GG;
                        }
                        break;
                        

                        if (map[Pos - 1] == '^' || map[Pos + 1] == '^' || map[Pos + 80] == '^' || map[Pos - 80] == '^')
                            fight = true;
                        else fight = false;

                        for (i = 0; i <= 1919; i++)
                            if (map[i] == '^' && Pos == i - 160)
                            {
                                map[i] = Oldmap[i];
                                map[i - 80] = '^';

                            }

                       

                        if (fight)
                        {
                            Console.WriteLine("fight");
                        }
                        

                }

                          /////// Выводим графику
                         Enveroment = "";
                        for (i = 0; i <= 1919; i++)
                        {
                            
                            Enveroment = Enveroment + map[i];
                        }
                        Console.Clear();
                       Console.Write(Enveroment);
                        
                        
                }
            }

        }
    }


 