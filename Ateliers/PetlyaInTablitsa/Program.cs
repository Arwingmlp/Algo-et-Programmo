using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PetlyaInTablitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            bool answerr = true;
            double saisiNb = 0;
            string phrase = "";
            float TotResult = 0;



            while (answerr == true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Que voulez-vous faire ?");
                Console.WriteLine();
                Console.WriteLine("1. Savoir la factoriel d'un nombre");
                Console.WriteLine("2. Écrire une phrase et trouver le mot qui ce rapproche plus de la lettre A");
                Console.WriteLine("3. Savoir la moyenne d'un tableau et le plus grand nombre de celui-ci");
                Console.WriteLine("4. Quitter l'application");


                choice = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (choice)
                {
                    //Exercice 1 sur les nombres factorielles !
                    case 1:
                        Console.WriteLine("Veuillez rentre votre nombre :3");
                        saisiNb = Convert.ToInt32(Console.ReadLine());
                        for (double i = saisiNb - 1; i > 1; i--)
                        {
                            saisiNb = saisiNb * i;
                        }
                        Console.WriteLine("Le résultat est " + saisiNb);
                        Console.ReadKey();
                        break;
                    //Exercice 2
                    case 2:
                        Console.WriteLine("Veuillez écrire votre phrase :3");
                        phrase = Convert.ToString(Console.ReadLine());

                        string[] tabPhrase = phrase.Split(' ');
                        char PlusPetit = tabPhrase[0][0];

                        int pos = 0;
                        for (int i = 1; i < tabPhrase.Length; i++)
                        {
                            string mot = tabPhrase[i];
                            if(mot[0] < PlusPetit)
                            {
                                PlusPetit = mot[0];
                                pos = i;
                            }
                        }
                        Console.WriteLine("Le mot le plus proche de a est : " + tabPhrase[pos]);
                        //Note : Les majuscules chient tout !
                        Console.ReadKey();
                    break;
                        //Exercice 3
                    case 3:
                        float[] tabRes = {23,65,132,34,123,32,45,6,3,24,90,45,243,13,35,46,86,64,52,75};
                        for(int i = 0; i<20; i++)
                        {                           
                            TotResult = TotResult + tabRes[i];                           
                        }
                        TotResult = TotResult / 20;
                        Console.WriteLine("La moyenne des 20 nombres est de "+ TotResult);
                        float biggestNumber = tabRes.Max();
                        Console.WriteLine("Le plus grand nombre est " + biggestNumber);
                        Console.WriteLine();
                        Console.WriteLine("Appuyer sur une touche pour continuer...");
                        Console.ReadKey();
                        Console.WriteLine();
                    break;
                    case 4:
                        answerr = false;
                    break;
                }
                Console.Clear();
            }
        }
    }
}
