using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtStringBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int nbLettre = 0;
            int eee = 0;
            string phrase = "X";

            Console.WriteLine("Veuiller saisir votre phrase...");
            phrase = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Vous avez saisie : " + phrase);
            Console.WriteLine("");
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("1. Afficher la longeur de la chaîne de caractères.");
            Console.WriteLine("2. Savoir s'il y a le mot Octopuss dans la phrase.");
            Console.WriteLine("3. Connaître la position du premier 'e'.");
            Console.WriteLine("4. Afficher une sous-phrase.");
            Console.WriteLine("5. Transformer tout en majuscule et afficher.");
            Console.WriteLine("6. Transformer tout en minuscule et afficher.");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    nbLettre = phrase.Length;
                    Console.WriteLine("Vous avez " + nbLettre + " caractères!");
                    Console.ReadKey();
                break;

                case 2:
                    if (phrase.Contains("octopuss"))
                    {
                        Console.WriteLine("Cette phrase contient le mot octopuss.");
                    }
                    else if (phrase.Contains("Octopuss"))
                    {
                        Console.WriteLine("Cette phrase contient le mot Octopuss.");
                    }
                    else
                    {
                        Console.WriteLine("Cette phrase ne contient pas le mot Octupuss");
                    }
                    Console.ReadKey();
                break;

                case 3:
                    eee = phrase.IndexOf("e");
                    eee = eee + 1;
                    Console.WriteLine("Votre premier 'e' est à la " + eee + "e position.");
                    Console.ReadKey();
                break;

                case 4:
                    phrase = phrase.Substring(3);
                    Console.WriteLine(phrase);
                    Console.ReadKey();
                break;

                case 5:
                    phrase = phrase.ToUpper();
                    Console.WriteLine("Votre phrase est devenue : " + phrase);
                    Console.ReadKey();
                break;

                case 6:
                    phrase = phrase.ToLower();
                    Console.ReadKey();
                break;
                }

            }

        }
    }

