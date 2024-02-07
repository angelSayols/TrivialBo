using System.Numerics;
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

                ShowOptions();
                tecla = Console.ReadKey();
                Console.Clear();
                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        //historia 1
                        break;
                    case ConsoleKey.D2:
                        //sport 2
                        break;
                    case ConsoleKey.D3:
                        //art 3
                        break;
                    case ConsoleKey.D4:
                        //geografia 4
                        break;
                    case ConsoleKey.D5:
                        //entreteniment 5
                        break;
                    case ConsoleKey.D6:
                        //mates 6                    
                        break;

                    default:
                        MsgNextScreen("Error.Prem una tecla per tornar al menu...");
                        break;
                }

            } while (tecla.Key != ConsoleKey.D0);
        }

        private static void crearPreguntes(questionari[] h, questionari[] s, questionari[] a, questionari[] g, questionari[] e, questionari[] m)
        {
            h[0] = { };
            h[1] = { };
            h[2] = { };
            h[3] = { };
            h[4] = { };
            s[0] = { };
            s[0] = { };
            s[0] = { };
            s[0] = { };
            s[0] = { };
            a[0] = { };
            a[0] = { };
            a[0] = { };
            a[0] = { };
            a[0] = { };
            g[0] = { };
            g[0] = { };
            g[0] = { };
            g[0] = { };
            g[0] = { };
            e[0] = { };
            e[0] = { };
            e[0] = { };
            e[0] = { };
            e[0] = { };
            m[0] = { };
            m[0] = { };
            m[0] = { };
            m[0] = { };
            m[0] = { };
        }

        
        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        public static void ShowOptions()
        {
            Console.WriteLine("sdkfjsdlakf");
        }

        public static void tractamentTematica(List<string> preguntes)
        {
            Random r = new Random();
            
        }
    }
}