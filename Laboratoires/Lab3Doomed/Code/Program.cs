using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Lab3Doomed
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer();

            //random
            Random random = new Random();
            //Variables
            int i = 0;
            int ia = 0;
            int ib = 0;
            int ip = 0;
            int gg = 0;
            int choice = 0;
            int nbError = 0;
            int bonnerep = 0;
            int im = 0;
            int q = 0;
            string answer = "";
            string lettre = "";
            bool found = false;
            float TotResult = 0;

            //Tableau
            string[] tabMot = { "possessed", "mancubus", "cacodemon", "unwilling", "revenant", "harvester", "chaingun", "hellshot", "reaper", "chainsaw" };


            //tictactooo
            int value1 = 0;
            int value2 = 0;
            int value3 = 0;
            int value4 = 0;
            int value5 = 0;
            int value6 = 0;
            int value7 = 0;
            int value8 = 0;
            int value9 = 0;

            bool taken = false;

            int nbTurn = 0;

            int x = 0;
            int y = 0;
            int bx = 0;
            int by = 0;

            int x1 = 0;
            int y1 = 0;

            int x2 = 0;
            int y2 = 0;

            int x3 = 0;
            int y3 = 0;

            int x4 = 0;
            int y4 = 0;

            int x5 = 0;
            int y5 = 0;

            int x6 = 0;
            int y6 = 0;

            int x7 = 0;
            int y7 = 0;

            int x8 = 0;
            int y8 = 0;

            int x9 = 0;
            int y9 = 0;

            int WinLose = 0;


            int BotChoice = 0;


            //Fonctions
            int winnerchecker()
            {
                int result = 0;

                //Player Victory

                if ((value1 == 1 && value2 == 1 && value3 == 1) || (value4 == 1 && value5 == 1 && value6 == 1) || (value7 == 1 && value8 == 1 && value9 == 1))
                {
                    result = 1;
                }
                else if ((value1 == 1 && value4 == 1 && value7 == 1) || (value2 == 1 && value5 == 1 && value8 == 1) || (value3 == 1 && value6 == 1 && value9 == 1))
                {
                    result = 1;
                }
                else if ((value1 == 1 && value5 == 1 && value9 == 1) || (value3 == 1 && value5 == 1 && value7 == 1))
                {
                    result = 1;
                }

                //Bot victory

                else if ((value1 == 2 && value2 == 2 && value3 == 2) || (value4 == 2 && value5 == 2 && value6 == 2) || (value7 == 2 && value8 == 2 && value9 == 2))
                {
                    result = 2;
                }
                else if ((value1 == 2 && value4 == 2 && value7 == 2) || (value2 == 2 && value5 == 2 && value8 == 2) || (value3 == 2 && value6 == 2 && value9 == 2))
                {
                    result = 2;
                }
                else if ((value1 == 2 && value5 == 2 && value9 == 2) || (value3 == 2 && value5 == 2 && value7 == 2))
                {
                    result = 2;
                }

                return result;
            }




            Console.WriteLine("Bienvenue dans mon jeux :3");
            Console.WriteLine("1. Pendu");
            Console.WriteLine("2. Tic Tac To");
            Console.WriteLine("3. Exercice inutile");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //HangMan-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            if (choice == 1)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                //Musique
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "LavenderTown.wav";
                player.Play();

                i = random.Next(0, 10);
                answer = tabMot[i];
                char[] motcache = new char[answer.Length];
                for (im = 0; im < answer.Length; im++)
                {
                    motcache[im] = "*"[0];
                }


                void penduXL()
                {
                    for (ip = 0; ip < answer.Length; ip++)
                    {

                        Console.Write(motcache[ip]);
                    }
                    lettre = Console.ReadLine();
                    for (q = 0; q < answer.Length; q++)
                    {
                        Console.Write(motcache[q]);
                    }
                    for (ib = 0; ib < answer.Length; ib++)
                    {
                        if (answer[ib] == lettre[0])
                        {
                            if (motcache[ib] == "*"[0])
                            {
                                motcache[ib] = answer[ib];
                                gg++;
                            }
                            found = true;
                        }
                    }
                    if (found == false)
                    {
                        nbError++;
                    }
                    found = false;

                    Console.Clear();
                }


                while (nbError != 7)
                {
                    switch (nbError)
                    {
                        case 0:
                            Pendu0();
                            penduXL();
                            break;
                        case 1:
                            Pendu1();
                            penduXL();
                            break;
                        case 2:
                            Pendu2();
                            penduXL();
                            break;
                        case 3:
                            Pendu3();
                            penduXL();
                            break;
                        case 4:
                            Pendu4();
                            penduXL();
                            break;
                        case 5:
                            Pendu5();
                            penduXL();
                            break;
                        case 6:
                            Pendu6();
                            Console.WriteLine("");
                            Console.WriteLine("You are dead !");
                            Console.ReadKey();
                            nbError = nbError + 1;
                            break;
                    }
                    if (nbError == 7)
                    {
                        //GameOver
                    }
                    else
                    {
                        //Victory
                    }
                }


            }
            //Tic Tac Toe----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            else if (choice == 2)
            {
                while (WinLose == 0)
                {


                    if (nbTurn == 0)
                    {
                        Boom();

                    }
                    else if (nbTurn == 1)
                    {
                        Boom();
                        Console.SetCursorPosition(x1, y1);
                        Console.WriteLine("X");

                        System.Threading.Thread.Sleep(1000);

                        Console.SetCursorPosition(x2, y2);
                        Console.WriteLine("O");
                    }
                    else if (nbTurn == 2)
                    {
                        Boom();
                        Console.SetCursorPosition(x1, y1);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(x2, y2);
                        Console.WriteLine("O");
                        Console.SetCursorPosition(x3, y3);
                        Console.WriteLine("X");

                        System.Threading.Thread.Sleep(1000);

                        Console.SetCursorPosition(x4, y4);
                        Console.WriteLine("O");
                    }
                    else if (nbTurn == 3)
                    {
                        Boom();
                        Console.SetCursorPosition(x1, y1);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(x2, y2);
                        Console.WriteLine("O");
                        Console.SetCursorPosition(x3, y3);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(x4, y4);
                        Console.WriteLine("O");
                        Console.SetCursorPosition(x5, y5);
                        Console.WriteLine("X");

                        System.Threading.Thread.Sleep(1000);

                        Console.SetCursorPosition(x6, y6);
                        Console.WriteLine("O");
                    }
                    else if (nbTurn == 4)
                    {
                        Boom();
                        Console.SetCursorPosition(x1, y1);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(x2, y2);
                        Console.WriteLine("O");
                        Console.SetCursorPosition(x3, y3);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(x4, y4);
                        Console.WriteLine("O");
                        Console.SetCursorPosition(x5, y5);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(x6, y6);
                        Console.WriteLine("O");
                        Console.SetCursorPosition(x7, y7);
                        Console.WriteLine("X");

                        System.Threading.Thread.Sleep(1000);

                        Console.SetCursorPosition(x8, y8);
                        Console.WriteLine("O");
                    }
                    else if (nbTurn == 5)
                    {
                        Boom();
                        Console.SetCursorPosition(x1, y1);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(x2, y2);
                        Console.WriteLine("O");
                        Console.SetCursorPosition(x3, y3);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(x4, y4);
                        Console.WriteLine("O");
                        Console.SetCursorPosition(x5, y5);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(x6, y6);
                        Console.WriteLine("O");
                        Console.SetCursorPosition(x7, y7);
                        Console.WriteLine("X");
                        Console.SetCursorPosition(x8, y8);
                        Console.WriteLine("O");

                        System.Threading.Thread.Sleep(1000);

                        Console.SetCursorPosition(x9, y9);
                        Console.WriteLine("X");
                    }

                    //Player
                    do
                    {
                        Console.SetCursorPosition(0, 13);
                        choice = Convert.ToInt32(Console.ReadLine());
                        taken = false;

                        switch (choice)
                        {
                            case 1:

                                if (value1 != 1 && value1 != 2)
                                {
                                    x = 8;
                                    y = 4;
                                    value1 = 1;
                                }
                                else
                                {
                                    taken = true;
                                }

                                break;
                            case 2:
                                if (value2 != 1 && value2 != 2)
                                {
                                    x = 11;
                                    y = 4;
                                    value2 = 1;
                                }
                                else
                                {
                                    taken = true;
                                }

                                break;
                            case 3:
                                if (value3 != 1 && value3 != 2)
                                {
                                    x = 14;
                                    y = 4;
                                    value3 = 1;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 4:
                                if (value4 != 1 && value4 != 2)
                                {
                                    x = 8;
                                    y = 6;
                                    value4 = 1;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 5:
                                if (value5 != 1 && value5 != 2)
                                {
                                    x = 11;
                                    y = 6;
                                    value5 = 1;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 6:
                                if (value6 != 1 && value6 != 2)
                                {
                                    x = 14;
                                    y = 6;
                                    value6 = 1;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 7:
                                if (value7 != 1 && value7 != 2)
                                {
                                    x = 8;
                                    y = 8;
                                    value7 = 1;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 8:
                                if (value8 != 1 && value8 != 2)
                                {
                                    x = 11;
                                    y = 8;
                                    value8 = 1;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 9:
                                if (value9 != 1 && value9 != 2)
                                {
                                    x = 14;
                                    y = 8;
                                    value9 = 1;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;

                        }



                    }


                    while (taken == true);
                    //Bot 
                    do
                    {

                        BotChoice = random.Next(1, 10);
                        taken = false;

                        switch (BotChoice)
                        {

                            case 1:

                                if (value1 != 1 && value1 != 2)
                                {
                                    bx = 8;
                                    by = 4;
                                    value1 = 2;
                                }
                                else
                                {
                                    taken = true;
                                }

                                break;
                            case 2:
                                if (value2 != 1 && value2 != 2)
                                {
                                    bx = 11;
                                    by = 4;
                                    value2 = 2;
                                }
                                else
                                {
                                    taken = true;
                                }

                                break;
                            case 3:
                                if (value3 != 1 && value3 != 2)
                                {
                                    bx = 14;
                                    by = 4;
                                    value3 = 2;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 4:
                                if (value4 != 1 && value4 != 2)
                                {
                                    bx = 8;
                                    by = 6;
                                    value4 = 2;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 5:
                                if (value5 != 1 && value5 != 2)
                                {
                                    bx = 11;
                                    by = 6;
                                    value5 = 2;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 6:
                                if (value6 != 1 && value6 != 2)
                                {
                                    bx = 14;
                                    by = 6;
                                    value6 = 2;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 7:
                                if (value7 != 1 && value7 != 2)
                                {
                                    bx = 8;
                                    by = 8;
                                    value7 = 2;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 8:
                                if (value8 != 1 && value8 != 2)
                                {
                                    bx = 11;
                                    by = 8;
                                    value8 = 2;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;
                            case 9:
                                if (value9 != 1 && value9 != 2)
                                {
                                    bx = 14;
                                    by = 8;
                                    value9 = 2;
                                }
                                else
                                {
                                    taken = true;
                                }
                                break;

                        }
                    }
                    while (taken == true);

                    if (nbTurn == 0)
                    {
                        x1 = x;
                        y1 = y;
                        x2 = bx;
                        y2 = by;
                    }
                    else if (nbTurn == 1)
                    {
                        x3 = x;
                        y3 = y;
                        x4 = bx;
                        y4 = by;
                    }
                    else if (nbTurn == 2)
                    {
                        x5 = x;
                        y5 = y;
                        x6 = bx;
                        y6 = by;
                    }
                    else if (nbTurn == 3)
                    {
                        x7 = x;
                        y7 = y;
                        x8 = bx;
                        y8 = by;
                    }
                    else if (nbTurn == 4)
                    {
                        x9 = x;
                        y9 = y;
                    }

                    nbTurn++;

                    WinLose = winnerchecker();
                    Console.Clear();
                }


                Console.Clear();

                if (WinLose == 1)
                {
                    Console.WriteLine("Vous avez gagner");
                    Console.ReadKey();
                }
                else if (WinLose == 2)
                {
                    Console.WriteLine("Vous avez Perdu");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Match Nul");
                    Console.ReadKey();
                }
            }
            //Exercice 1 inutile---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            else
            {
                //Génératrion du tableau
                float[] tabRes = new float[300];
                for (i = 0; i­ < 300; i++)
                {
                    choice = random.Next(1, 10001);
                    tabRes[i] = choice;
                    
                }
                

                Console.WriteLine("Que voulez-vous faire ?");
                Console.WriteLine();
                Console.WriteLine("1. Trouver le plus grand nombre");
                Console.WriteLine("2. Trouver le plus petit nombre");
                Console.WriteLine("3. Saisir un nombre et checker s'il est dans le tableau");
                Console.WriteLine("4. Faire la Moyenne");
                Console.WriteLine("5. Quitter");



                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {

                    case 1:
                        float maxValue = tabRes.Max();
                        Console.WriteLine("Le plus grand nombre est " + maxValue);

                        Console.ReadKey();

                        break;

                    case 2:
                        float minValue = tabRes.Min();
                        Console.WriteLine("Le plus petit nombre est " + minValue);

                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Veuillez rentrez votre nombre :3");
                        choice = Convert.ToInt32(Console.ReadLine());

                        bool trrr = false;

                        for (i = 0; i < 300; i++)
                        {
                            if (choice == tabRes[i])
                            {
                                trrr = true;
                            }
                        }
                        if (trrr == true)
                        {
                            Console.WriteLine("Votre chiffre ce trouve dans le tableau  !");
                        }
                        else
                        {
                            Console.WriteLine("Votre chiffre ne ce trouve pas dans le tableau :( ");
                        }

                        Console.ReadKey();

                        break;
                    case 4:
                        for (i = 0; i < 300; i++)
                        {
                            TotResult = TotResult + tabRes[i];
                        }
                        TotResult = TotResult / 300;
                        Console.WriteLine("La moyenne des 300 nombres est de " + TotResult);
                        Console.WriteLine();
                        Console.WriteLine("Appuyer sur une touche pour continuer...");
                        Console.ReadKey();
                        Console.WriteLine();
                        break;
                }
            }



        }


        //Acsii Art
        static void Pendu0()
        {
            Console.WriteLine("                  -/osooooooso+-              ");
            Console.WriteLine("              .+so/.          ./os+.              ");
            Console.WriteLine("            :yhMy:              :yMhy:            ");
            Console.WriteLine("          .y+  d//ys-        -sy//d  +h.          ");
            Console.WriteLine("         /h`   .m` `+yo.  .oy+` `m.   .h/         ");
            Console.WriteLine("        /h      os    .ymdy.    so      h/      ");
            Console.WriteLine("       .m`       d: `/ys--sy/` :d       `m.       ");
            Console.WriteLine("       s+        -myy:      :yyN:        +s       ");
            Console.WriteLine("       d-      -shhy          yhyo-      -d       ");
            Console.WriteLine("       d-   .oy+.  m-        -m  .+yo.   -d      ");
            Console.WriteLine("       s+`+yo.     -m`      `m-     .oy+`+s   ");
            Console.WriteLine("       .NNmsssssssssNdssosssdNsssssssssmNN.    ");
            Console.WriteLine("        /h          `m:    :m`          h/  ");
            Console.WriteLine("         /h.         -m`   m-         .h/  ");
            Console.WriteLine("          .h+         so  os         +h.     ");
            Console.WriteLine("            :yo.      `m--m`      .oy:           ");
            Console.WriteLine("              .+so/.   :mm:   ./os+.       ");
            Console.WriteLine("                  -/ooooddoooo/-   ");
        }
        static void Pendu1()
        {
            Console.WriteLine("                  -/osooooooso+-              ");
            Console.WriteLine("              .+so/.  ______  ./os+.              ");
            Console.WriteLine("            :yhMy:   /      \\   :yMhy:            ");
            Console.WriteLine("          .y+  d//ys|        |sy//d  +h.          ");
            Console.WriteLine("         /h`   .m` `+\\______/+` `m.   .h/         ");
            Console.WriteLine("        /h      os    .ymdy.    so      h/      ");
            Console.WriteLine("       .m`       d: `/ys--sy/` :d       `m.       ");
            Console.WriteLine("       s+        -myy:      :yyN:        +s       ");
            Console.WriteLine("       d-      -shhy          yhyo-      -d       ");
            Console.WriteLine("       d-   .oy+.  m-        -m  .+yo.   -d      ");
            Console.WriteLine("       s+`+yo.     -m`      `m-     .oy+`+s   ");
            Console.WriteLine("       .NNmsssssssssNdssosssdNsssssssssmNN.    ");
            Console.WriteLine("        /h          `m:    :m`          h/  ");
            Console.WriteLine("         /h.         -m`   m-         .h/  ");
            Console.WriteLine("          .h+         so  os         +h.     ");
            Console.WriteLine("            :yo.      `m--m`      .oy:           ");
            Console.WriteLine("              .+so/.   :mm:   ./os+.       ");
            Console.WriteLine("                  -/ooooddoooo/-   ");
        }
        static void Pendu2()
        {
            Console.WriteLine("                  -/osooooooso+-              ");
            Console.WriteLine("              .+so/.  ______  ./os+.              ");
            Console.WriteLine("            :yhMy:   /      \\   :yMhy:            ");
            Console.WriteLine("          .y+  d//ys|        |sy//d  +h.          ");
            Console.WriteLine("         /h`   .m` `+\\______/+` `m.   .h/         ");
            Console.WriteLine("        /h      os   /      \\   so      h/      ");
            Console.WriteLine("       .m`       d: /        \\ d       `m.       ");
            Console.WriteLine("       s+        -my|        |yyN:        +s       ");
            Console.WriteLine("       d-      -shhy\\        / /yhyo-     -d       ");
            Console.WriteLine("       d-   .oy+.  m-|      |-m  .+yo.   -d      ");
            Console.WriteLine("       s+`+yo.     -m|      |m-     .oy+`+s   ");
            Console.WriteLine("       .NNmsssssssssN|______|NsssssssssmNN.    ");
            Console.WriteLine("        /h          `m:    :m`          h/  ");
            Console.WriteLine("         /h.         -m`   m-         .h/  ");
            Console.WriteLine("          .h+         so  os         +h.     ");
            Console.WriteLine("            :yo.      `m--m`      .oy:           ");
            Console.WriteLine("              .+so/.   :mm:   ./os+.       ");
            Console.WriteLine("                  -/ooooddoooo/-   ");
        }
        static void Pendu3()
        {
            Console.WriteLine("                  -/osooooooso+-              ");
            Console.WriteLine("              .+so/.  ______  ./os+.              ");
            Console.WriteLine("            :yhMy:   /      \\   :y_hy:            ");
            Console.WriteLine("          .y+  d//ys|        |sy _/ \\h.          ");
            Console.WriteLine("         /h`   .m` `+\\______/+`/     |.h/         ");
            Console.WriteLine("        /h      os   /      \\_/     /   h/      ");
            Console.WriteLine("       .m`       d: /              /     `m.       ");
            Console.WriteLine("       s+        -my|        ____/        +s       ");
            Console.WriteLine("       d-      -shhy\\        / /yhyo-     -d       ");
            Console.WriteLine("       d-   .oy+.  m-|      |-m  .+yo.   -d      ");
            Console.WriteLine("       s+`+yo.     -m|      |m-     .oy+`+s   ");
            Console.WriteLine("       .NNmsssssssssN|______|NsssssssssmNN.    ");
            Console.WriteLine("        /h          `m:    :m`          h/  ");
            Console.WriteLine("         /h.         -m`   m-         .h/  ");
            Console.WriteLine("          .h+         so  os         +h.     ");
            Console.WriteLine("            :yo.      `m--m`      .oy:           ");
            Console.WriteLine("              .+so/.   :mm:   ./os+.       ");
            Console.WriteLine("                  -/ooooddoooo/-   ");
        }
        static void Pendu4()
        {
            Console.WriteLine("                  -/osooooooso+-              ");
            Console.WriteLine("              .+so/.  ______  ./os+.              ");
            Console.WriteLine("            :yhMy:   /      \\   :y_hy:            ");
            Console.WriteLine("          .y+/ \\_ ys|        |sy _/ \\h.          ");
            Console.WriteLine("         /h`|     \\ +\\______/+`/     |.h/         ");
            Console.WriteLine("        /h   \\     \\_/      \\_/     /   h/      ");
            Console.WriteLine("       .m`    \\                    /     `m.       ");
            Console.WriteLine("       s+       \\____        ____/        +s       ");
            Console.WriteLine("       d-      -shhy\\        / /yhyo-     -d       ");
            Console.WriteLine("       d-   .oy+.  m-|      |-m  .+yo.   -d      ");
            Console.WriteLine("       s+`+yo.     -m|      |m-     .oy+`+s   ");
            Console.WriteLine("       .NNmsssssssssN|______|NsssssssssmNN.    ");
            Console.WriteLine("        /h          `m:    :m`          h/  ");
            Console.WriteLine("         /h.         -m`   m-         .h/  ");
            Console.WriteLine("          .h+         so  os         +h.     ");
            Console.WriteLine("            :yo.      `m--m`      .oy:           ");
            Console.WriteLine("              .+so/.   :mm:   ./os+.       ");
            Console.WriteLine("                  -/ooooddoooo/-   ");
        }
        static void Pendu5()
        {
            Console.WriteLine("                  -/osooooooso+-              ");
            Console.WriteLine("              .+so/.  ______  ./os+.              ");
            Console.WriteLine("            :yhMy:   /      \\   :y_hy:            ");
            Console.WriteLine("          .y+/ \\_ ys|        |sy _/ \\h.          ");
            Console.WriteLine("         /h`|     \\ +\\______/+`/     |.h/         ");
            Console.WriteLine("        /h   \\     \\_/      \\_/     /   h/      ");
            Console.WriteLine("       .m`    \\                    /     `m.       ");
            Console.WriteLine("       s+       \\____        ____/        +s       ");
            Console.WriteLine("       d-      -shhy\\        / /yhyo-     -d       ");
            Console.WriteLine("       d-   .oy+.  m-|      |-m  .+yo.   -d      ");
            Console.WriteLine("       s+`+yo.     -m|      |m-     .oy+`+s   ");
            Console.WriteLine("       .NNmsssssssssN|     _|NsssssssssmNN.    ");
            Console.WriteLine("        /h          `/    /:m`          h/  ");
            Console.WriteLine("         /h.        /   /   m-         .h/  ");
            Console.WriteLine("          .h+     /    /o  os         +h.     ");
            Console.WriteLine("            :yo. /    /m--m`       .oy:           ");
            Console.WriteLine("              .+so\\_/  :mm:    ./os+.       ");
            Console.WriteLine("                  -/ooooddoooo/-   ");
        }
        static void Pendu6()
        {
            Console.WriteLine("                  -/osooooooso+-              ");
            Console.WriteLine("              .+so/.  ______  ./os+.              ");
            Console.WriteLine("            :yhMy:   /      \\   :y_hy:            ");
            Console.WriteLine("          .y+/ \\_ ys| X   X  |sy _/ \\h.          ");
            Console.WriteLine("         /h`|     \\ +\\______/+`/     |.h/         ");
            Console.WriteLine("        /h   \\     \\_/      \\_/     /   h/      ");
            Console.WriteLine("       .m`    \\                    /     `m.       ");
            Console.WriteLine("       s+       \\____        ____/        +s       ");
            Console.WriteLine("       d-      -shhy\\        / /yhyo-     -d       ");
            Console.WriteLine("       d-   .oy+.  m-|      |-m  .+yo.   -d      ");
            Console.WriteLine("       s+`+yo.     -m|      |m-     .oy+`+s   ");
            Console.WriteLine("       .NNmsssssssssN|      |NsssssssssmNN.    ");
            Console.WriteLine("        /h          `/   _   \\        h/  ");
            Console.WriteLine("         /h.        /   /  \\  \\       .h/  ");
            Console.WriteLine("          .h+     /    /o  o\\   \\    +h.     ");
            Console.WriteLine("            :yo. /    /m--m` \\   \\oy:           ");
            Console.WriteLine("              .+so\\_/  :mm:   \\_/os+.      ");
            Console.WriteLine("                  -/ooooddoooo/-   ");
        }
        static void Boom()
        {
            Console.WriteLine("  ____________________");
            Console.WriteLine(" /____/____/____/_____/|");
            Console.WriteLine(" |    |____|____|    | |");
            Console.WriteLine(" | C  |         | A  | |");
            Console.WriteLine(" | 4  | 1  2  3 | A  | |");
            Console.WriteLine(" | U  |         |    | |");
            Console.WriteLine(" | T  | 4  5  6 | B  | |");
            Console.WriteLine(" | 1  |         | O  | |");
            Console.WriteLine(" | 0  | 7  8  9 | M  | |");
            Console.WriteLine(" | N  |_________| B  | |");
            Console.WriteLine(" |____|____|____|____|_/");
            Console.WriteLine("");
            Console.WriteLine("Veuillez faire votre choix...");
        }

    }

}
