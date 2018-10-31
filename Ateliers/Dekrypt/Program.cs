using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            string result = "";
            string crypted = "";

            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("1. Crypter un message");
            Console.WriteLine("2. Décrypter un message");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            if(choice == 1)
            {
                Console.WriteLine("Veuillez entrez votre message :");
                crypted = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Vous avez entrer " + crypted);
                Console.WriteLine("");
                Console.WriteLine("Appuyez une touche pour continuez...");
                Console.ReadKey();
                Console.Clear();
                for (int i = 0; i < crypted.Length; i++)
                {
                    result += Convert.ToChar((int)crypted[i] + 1);
                }
                Console.WriteLine("Votre message est maintenent : " + result);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Veuillez entrez votre message à décrypter:");
                crypted = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Vous avez entrer " + crypted);
                Console.WriteLine("");
                Console.WriteLine("Appuyez une touche pour continuez...");
                Console.ReadKey();
                Console.Clear();
                for (int i = 0; i < crypted.Length; i++)
                {
                    result += Convert.ToChar((int)crypted[i] - 1);
                }
                Console.WriteLine("Le message est : " + result);
                Console.ReadKey();
            }
        }
        
    }
}