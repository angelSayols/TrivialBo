using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace Trivial
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            questionari[] h = new questionari[5];
            questionari[] m = new questionari[5];
            questionari[] e = new questionari[5];
            questionari[] s = new questionari[5];
            questionari[] g = new questionari[5];
            questionari[] a = new questionari[5];
            crearPreguntes(h,s,a,g,e,m);
            ConsoleKeyInfo tecla;
        
            do
            {
                Console.Clear();
                ShowOptions();
                tecla = Console.ReadKey();
                Console.Clear();
                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        //historia
                        tractamentTematica(h);
                        break;
                    case ConsoleKey.D2:
                        //sport 2
                        tractamentTematica(h);
                        break;
                    case ConsoleKey.D3:
                        //art 3
                        tractamentTematica(h);
                        break;
                    case ConsoleKey.D4:
                        //geografia 4
                        tractamentTematica(h);
                        break;
                    case ConsoleKey.D5:
                        //entreteniment 5
                        tractamentTematica(h);
                        break;
                    case ConsoleKey.D6:
                        //mates 6
                        tractamentTematica(h);
                        break;

                    default:
                        MsgNextScreen("Error.Prem una tecla per tornar al menu...");
                        break;
                }

            } while (tecla.Key != ConsoleKey.D0);
        }

        public static void ShowOptions()
        {
            Console.WriteLine("TRY ONE OF THIS THEMES: ");
            Console.WriteLine("PRESS 1 FOR HISTORY");
            Console.WriteLine("PRESS 2 FOR SPORTS");
            Console.WriteLine("PRESS 3 FOR ART");
            Console.WriteLine("PRESS 4 FOR GEOGRAPHY");
            Console.WriteLine("PRESS 5 FOR ENTERTAINMENT");
            Console.WriteLine("PRESS 6 FOR MATHS");
            Console.WriteLine("PRESS 0 FOR LEAVING");
        }

        private static void crearPreguntes(questionari[] h, questionari[] s, questionari[] a, questionari[] g, questionari[] e, questionari[] m)
        {
            h[0] = new questionari("What year was born Franco?", "1) 5 August 2034","2) 4 December 1892","3) 2 November 1677"," 4) He was not born", "2");
            h[1] = new questionari("When was the Eiffel finished?", "1) 31 March 1889", "2) 4 December 1892", "3) 2 November 1677", " 4)It is fake", "1");
            h[2] = new questionari("What was taken the first photo?", "1) 1.826", "2) 1892", "3) 1677", "4) It was not taken", "1");
            h[3] = new questionari("Who invented the Piruletas?", "1) Luis Jiménez Somacarrera", "2) Thomas Edison", "3) Nobody", "4) Fernando Alonso", "1");
            h[4] = new questionari("How long was the WW2 ?", "1) 9", "2) 4", "3) 6", "4) 8999", "3");
            s[0] = new questionari("Which sport is common in spain ?", "1) soccer", "2) baseball", "3) waterpolo", "4) skii", "1");
            s[0] = new questionari("How long lasts a soccer game ?", "1) 100 min", "2) 45 min", "3) 90 min", "4) 6 hours", "3");
            s[0] = new questionari("When was the first soccer mundial celebrated ?", "1) 1999", "2) 1931", "3) 3456", "4) 1930", "4");
            s[0] = new questionari("Which country was the inventor of volleyball ?", "1) Spain", "2) USA", "3) France", "4) China", "2");
            s[0] = new questionari("How is it called a point in football ?", "1) basket", "2) Pere", "3) goal", "4) touchdown", "4");
            a[0] = new questionari("Who painted Guernica ?", "1) Picasso", "2) Lionel Messi", "3) Vivaldi", "4) Miguel Ángel", "1");
            a[0] = new questionari("Which is the first name of Dalí ?", "1) Pere", "2) Johaness", "3) Salvador", "4) Mohamed", "3");
            a[0] = new questionari("Who sculpted The Thinker ?", "1) Rodin", "2) Marc ", "3) Picasso", "4) Dalí", "1");
            a[0] = new questionari("Which of this artists is Spanish ?", "1) Picasso", "2) Leonardo Da Vinci", "3) Tiziano", "4) Vladimir Putin", "1");
            a[0] = new questionari("Who painted rare clocks ?", "1) Dalí", "2) Da Vinci", "3) Vladimir Putin", "4) Pedor Sánchez", "1");
            //g[0] = { };
            //g[0] = { };
            //g[0] = { };
            //g[0] = { };
            //g[0] = { };
            //e[0] = { };
            //e[0] = { };
            //e[0] = { };
            //e[0] = { };
            //e[0] = { };
            //m[0] = { };
            //m[0] = { };
            //m[0] = { };
            //m[0] = { };
            //m[0] = { };
        }

        
        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        

        public static void tractamentTematica(questionari[] q)
        {
            Random r = new Random();
            int number = r.Next(q.Length);
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(q[number].RetornaPregunta()[i]);
            }

            string llegir = Console.ReadLine();
            if (llegir == q[number].RetornaPregunta()[5]) Console.WriteLine("CORRECTE");
            else Console.WriteLine("INCORRECTE");
        }
    }
}