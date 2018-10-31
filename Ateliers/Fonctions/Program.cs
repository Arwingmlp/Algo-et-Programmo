using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercice #1 : Le switch est idéal lorsque l'on impose un choix multiple. Le code est plus "propre"
            int choice = 0;

            Console.WriteLine("Que vouslez-vous faire ?");
            Console.WriteLine("1. Écrire trois nombre entier et savoir le plus grand");
            Console.WriteLine("2. Changer un nombre de livre en kilo");
            Console.WriteLine("3. Déplacement d'un personnage");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    plusG();
                    break;

                case 2:
                    lenK();
                    break;

                case 3:
                    zelda();
                    break;
            }



        }
        //Exercice #2
        static void plusG()
        {
            int chiffre1 = 0;
            int chiffre2 = 0;
            int chiffre3 = 0;

            Console.WriteLine("Veuillez inscrire vos trois nombres");
            Console.WriteLine("");
            Console.WriteLine("Nombre 1...");
            chiffre1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Nombre 2...");
            chiffre2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("et le nombre 3...");
            chiffre3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (chiffre1 > chiffre2 && chiffre1 > chiffre3)
            {
                Console.WriteLine(chiffre1 + " est le plus grand nombre !");
                Console.ReadKey();
            }
            else if (chiffre2 > chiffre1 && chiffre2 > chiffre3)
            {
                Console.WriteLine(chiffre2 + " est le plus grand nombre !");
                Console.ReadKey();
            }
            else if (chiffre3 > chiffre2 && chiffre3 > chiffre1)
            {
                Console.WriteLine(chiffre3 + " est le plus grand nombre !");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Veuillez rentrer trois chiffre différent....");
                plusG();
            }

        }
        //Exercice #3
        static void lenK()
        {
            double result = 0;
            double livre = 2.2046;
            double kilo = 0.4536;
            int choice = 0;

            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("");
            Console.WriteLine("1. Convertir de Kilo à Livre");
            Console.WriteLine("2. Convertir de Livre à Kilo");
            Console.WriteLine("");
            Console.WriteLine("((Si c'est un chiffre a virgule, veuillez mettre un point et non une virgule))");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (choice == 1)
            {
                Console.WriteLine("Veuillez rendrer votre nombre de kilo...");
                kilo = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                result = kilo * livre;
                Console.WriteLine("Vous avez maintenent " + result + " livre(s) !");
                Console.ReadKey();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Veuillez rendrer votre nombre de Livre...");
                livre = Convert.ToDouble(Console.ReadLine());
                result = livre * kilo;
                Console.WriteLine("Vous avez maintenent " + result + " Kilo(s) !");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Veuillez rentrer un nombre valide...");
                Console.ReadKey();
                lenK();
            }
        }
        //Excercice 4
        static void blbl()
        {
            string genererSrcImage()
            {
                Random generateur = new Random();
                int randomImg = 0;
                string source = "";

                randomImg = generateur.Next(1, 4);
                source = "img/robot" + randomImg + ".jpg";

                return source;
            }

            String image1Source = "", image2Source = "", image3Source = "";
            image1Source = genererSrcImage();
            image2Source = genererSrcImage();
            image3Source = genererSrcImage();
        }
        //Exercice 5
        static void zelda()
        {
            int posX = 0;
            int posY = 0;

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                if(keyinfo.Key == ConsoleKey.W)
                {
                    posY += 1;
                }
                else if (keyinfo.Key == ConsoleKey.A)
                {
                    posX -= 1;
                }
                else if (keyinfo.Key == ConsoleKey.S)
                {
                    posY -= 1;
                }
                else if (keyinfo.Key == ConsoleKey.D)
                {
                    posX += 1;
                }
                Console.Clear();
                Console.WriteLine("Votre position est " + "(" + posX + "," + posY + ")");
                Console.WriteLine("");
                Console.WriteLine("Appuyez sur Échap pour quitter...");
            }
            while (keyinfo.Key != ConsoleKey.Escape);
        }
    }
}
