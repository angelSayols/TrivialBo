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
            g[0] = new questionari("What is the second highest mountain in the Earth?", "1)Everest", "2)K2", "3)Lhotse", "4)Makalu", "2");
            g[0] = new questionari("What is the longest river in the world?", "1)Nilo", "2)Misisipi", "3)Congo", "4)Amazonas", "4");
            g[0] = new questionari("What is the largest river in the world?", "1)Congo", "2)Misisipi", "3)Amazonas", "4)Nilo", "3");
            g[0] = new questionari("What are the names of the mountains that border Spain and France?", "1)Pirineos", "2)Los Alpes", "3)Los Andes", "4)Los Urales", "1");
            g[0] = new questionari("Which of these countries is not part of the Iberian Peninsula?", "1)Portugal", "2)France", "3)Spain", "4)Andorra", "2");
            e[0] = new questionari("What is the name of the last actor who plays Spider-man?", "1)Tom Holland", "2)Andrew Garfield", "3)Tobey Maguire", "4)Chris Hemsworth", "1");
            e[0] = new questionari("Oscar-winning film for best film of 2023", "1)Top Gun:Maverick", "2)Todo a la vez en todas partes", "3)Sin novedad en el frente", "4)Avatar:El sentido del agua", "2");
            e[0] = new questionari("Which of these films has the less Oscars awards?", "1)Ben-Hur", "2)Titanic", "3)West Side History", "4)Lo que el viento se llevo", "4");
            e[0] = new questionari("What is the name of the protagonist of Peaky Blinders?", "1)Thomas Shelby", "2)Arthur Shelby", "3)Poly Grey", "4)Jhon Shelby", "1");
            e[0] = new questionari("What is the highest grossing movie in history?", "1)Avengers:Infinity War", "2)Titanic", "3)Avengers:End Game", "4)Avatar", "4");
            m[0] = new questionari("√36=?", "1)5", "2)4", "3)6", "4)7", "3");
            m[0] = new questionari("12-6=?", "1)5", "2)4", "3)6", "4)7", "3");
            m[0] = new questionari("12/2=?", "1)5", "2)4", "3)6", "4)7", "3");
            m[0] = new questionari("2x3=?", "1)5", "2)4", "3)6", "4)7", "3");
            m[0] = new questionari ("3+3=?", "1)5", "2)4","3)6","4)7","3") ;
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