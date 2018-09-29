using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;



namespace Lab2BlackDoom
{

    class Program
    {

        static void Main(string[] args)
        {
            //Variable et Music player
            SoundPlayer player = new SoundPlayer();

            //basic
            int chargement = 0;
            int enemyPV = 100;
            int playerPV = 100;
            int figure = 10;
            int bet = 0;
            int choice = 0;

            int totalPlayer = 0;
            int totalBot = 0;

            //Cards
            int card1 = 0;
            int card2 = 0;
            int card3 = 0;

            int Bcard1 = 0;
            int Bcard2 = 0;
            int Bcard3 = 0;

            //Random
            Random random = new Random();
            int PickaCard()
            {
                int resultNumber = 0;
                resultNumber = random.Next(1, 14);
                if (resultNumber >= 10)
                {
                    resultNumber = 10;
                }
                else if (resultNumber == 1)
                {
                    resultNumber = 11;
                }
                return resultNumber;
            }

            //Fonctions
            int additionPlayer()
            {
                int result = 0;
                              
                result = card1 + card2 + card3;
                
                return result;
            }
            int additionBot()
            {
                int result = 0;
                
                result = Bcard1 + Bcard2 + Bcard3;
                
                return result;
            }
            int winning()
            {
                int result = 0;
                playerPV = playerPV + bet;
                enemyPV = enemyPV - bet;
                return result;
            }
            int losing()
            {
                int result = 0;
                playerPV = playerPV - bet;
                enemyPV = enemyPV + bet;
                return result;
            }

            //Début du programme
            
            
            

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            try
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "WiiMiitheme.wav";
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            


            Console.WriteLine("Bienvenue dans mon jeu de BlackJack :P !");
            Console.WriteLine("");
            Console.WriteLine("Ceci est la suite de mon RPG sur Doom en text base :3");
            Console.WriteLine("");
            Console.WriteLine("Mise en situation : Après avoir vaincu le Pinkie, vous entrez dans une autre pièce.");
            Console.WriteLine("Dans cette pièce, il y a un genre de reaper furry qui veut votre âme...");
            Console.WriteLine("");
            Console.WriteLine("Alors, voici les règles ~ :");
            Console.WriteLine("1. Vous avez 100 points d'HP, et votre ennemy aussi");
            Console.WriteLine("2. Vous devez jouer votre nombre de vie dans une game de blackjack.");
            Console.WriteLine("3. Vous mourrez si votre vie est égal à 0.");
            Console.WriteLine("");
            Console.WriteLine("Pour une liste des règlements du BlackJack :");
            Console.WriteLine("https://fr.wikipedia.org/wiki/Blackjack_(jeu)");
            Console.WriteLine("");
            Console.WriteLine("Bonne chance et have fun ^-^");
            Console.WriteLine("");
            Console.WriteLine("Appuyez sur une touche pour continuer ~");
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            try
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "DoomTheme.wav";
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            System.Threading.Thread.Sleep(4600);

            do
            {
                Console.WriteLine("______ _____  ________  ___   _____  _____ ");
                Console.WriteLine("|  _  |  _  ||  _  |  |/  |  |_   _||_   _|");
                Console.WriteLine("| | | | | | || | | | .  . |    | |    | |  ");
                Console.WriteLine("| | | | | | || | | | ||/| |    | |    | |  ");
                Console.WriteLine("| |/ /| |_/ /| |_/ / |  | |   _| |_  _| |_ ");
                Console.WriteLine("|___/  |___/  |___/|_|  |_/   |___/  |___/ ");
                Console.WriteLine("");
                Console.WriteLine("*Text Base edition *");
                Console.WriteLine("");
                Console.WriteLine("Chargement " + chargement + "%");
                System.Threading.Thread.Sleep(130);
                Console.Clear();

                chargement = chargement += 3;
            }
            while (chargement <= 100);

            Console.WriteLine("______ _____  ________  ___   _____  _____ ");
            Console.WriteLine("|  _  |  _  ||  _  |  |/  |  |_   _||_   _|");
            Console.WriteLine("| | | | | | || | | | .  . |    | |    | |  ");
            Console.WriteLine("| | | | | | || | | | ||/| |    | |    | |  ");
            Console.WriteLine("| |/ /| |_/ /| |_/ / |  | |   _| |_  _| |_ ");
            Console.WriteLine("|___/  |___/  |___/|_|  |_/   |___/  |___/ ");
            Console.WriteLine("");
            Console.WriteLine("*Text Base edition *");
            Console.WriteLine("");
            Console.WriteLine("Chargement " + chargement + "%");
            Console.WriteLine("Chargement réussi !");
            Console.WriteLine("");
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.WriteLine("ou pas si vous voulez continuer d'écouter la musique.");
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            try
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "DoomImp.wav";
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            Console.WriteLine("Vous entrez dans une pièce sombre avec un spotlight de lumière...");
            Console.WriteLine("");
            Console.WriteLine("Une table verte s'y trouve avec deux chaises.");
            Console.WriteLine("");
            Console.WriteLine("Par curiosité, vous vous assisez sur une des deux chaise...");
            Console.WriteLine("");
            Console.WriteLine("Quand soudin, un reaper apparait sur l'autre chaise !!");
            Console.WriteLine("");
            Console.WriteLine("Appuyer sur une touche pour continuer....");
            Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            try
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "UndertaleGhost.wav";
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            reaper1();
            reaperOwO();
            reaper2();
            Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|    OwO Wat's dis ?  Un nouvel adversaire !  Je t'explique... Tu es assis sur une chaise que tu ne peux pas          |");
            Console.WriteLine("|    te relever tant que tu ne m'aura pas battue dans une partie de BlackJack >:3                                     |");
            Console.WriteLine("|                                                                                           (Press Space to continue) |");
            Console.WriteLine("|_____________________________________________________________________________________________________________________|");
            Console.ReadKey();
            Console.Clear();

            reaper1();
            reaperHappy();
            reaper2();

            Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|    ^w^  On misera notre energy vitale. Of course, si vous n'en avez plus, vous allez mourir ;3                      |");
            Console.WriteLine("|    Histoire de ne pas trop ce compliquer la vie, on va juste enlevez les différents type de cartes ~                |");
            Console.WriteLine("|    Aussi, on aura le droit de piger une carte seulement qu'une fois :3                    (Press Space to continue) |");
            Console.WriteLine("|_____________________________________________________________________________________________________________________|");
            Console.ReadKey();
            Console.Clear();

            reaper1();
            reaperOwO();
            reaper2();

            Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|    OwO Alors, es-tu prêt pour commencer?  Quoi que rendu la, tu na pas trop le choix ;3                             |");
            Console.WriteLine("|    Je te laisse piocher en premier <3                                                                               |");
            Console.WriteLine("|                                                                                           (Press Space to continue) |");
            Console.WriteLine("|_____________________________________________________________________________________________________________________|");
            Console.ReadKey();
            Console.Clear();

            reaper1();
            reaperFocused();
            reaper2();

            Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|    -u- Je ne t'empêche pas de prendre une pause pour écouté le reste de la chansons...                              |");
            Console.WriteLine("|    L'OST de Undertale est vraiment bonne xD !                                                                       |");
            Console.WriteLine("|                                                                                           (Press Space to continue) |");
            Console.WriteLine("|_____________________________________________________________________________________________________________________|");
            Console.ReadKey();
            
            do
            {

                try
                {
                    player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "GameCorner.wav";
                    player.Play();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }


                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                

                //Gaming time :P

                do
                {
                    
                    Console.Clear();
                    gaming();
                    Console.WriteLine("How much do you wanna bet :3 ?");
                    Console.WriteLine("PS- You have " + playerPV + " energies left :3");
                    Console.WriteLine("");
                    bet = Convert.ToInt32(Console.ReadLine());
                    if (bet > playerPV)
                    {
                        do
                        {
                            Console.Clear();
                            gaming();
                            Console.WriteLine("Nah, you don't have enough! Insert a correct amount of life energy");
                            Console.WriteLine("PS- You have " + playerPV + " energies left :3");
                            Console.WriteLine("");
                            bet = Convert.ToInt32(Console.ReadLine());
                        }
                        while (bet > playerPV);
                    }
                    card1 = PickaCard();
                    card2 = PickaCard();

                    Console.WriteLine("So, you bet " + bet + " life energies");
                    Console.WriteLine("");
                    Console.WriteLine("Your cards value are " + card1 + " and " + card2);

                    Bcard1 = PickaCard();
                    Bcard2 = PickaCard();


                    Console.WriteLine("");
                    Console.WriteLine("The reaper show you one of his two card, a " + Bcard1);
                    Console.WriteLine("");

                    Console.WriteLine("Watcha wanna do ?");
                    Console.WriteLine("1. Draw a card");
                    Console.WriteLine("2. Stop");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        card3 = PickaCard();
                        Console.Clear();
                        gaming();
                        Console.WriteLine("You have now a " + card1 + ", " + card2 + " and a " + card3);
                        Console.WriteLine("");

                        if (Bcard1 + Bcard2 < 20)
                        {
                            Console.WriteLine("The reaper also decides to draw a new card...");

                            Bcard3 = PickaCard();

                            Console.WriteLine("");
                            Console.WriteLine("It's show time <3 !");
                            Console.WriteLine("");
                            Console.WriteLine("Your hand : " + card1 + ", " + card2 + " and a " + card3);
                            Console.WriteLine("Reaper hand : " + Bcard1 + ", " + Bcard2 + " and a " + Bcard3);
                        }
                        else
                        {
                            Console.WriteLine("The reaper decides to stop...");
                            Console.WriteLine("");
                            Console.WriteLine("It's show time <3 !");
                            Console.WriteLine("");
                            Console.WriteLine("Your hand : " + card1 + ", " + card2 + " and a " + card3);
                            Console.WriteLine("Reaper hand : " + Bcard1 + " and a " + Bcard2);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        totalBot = additionBot();
                        totalPlayer = additionPlayer();

                        gaming();
                        //Player win
                        if (totalPlayer != totalBot && totalPlayer == 21)
                        {
                            Console.WriteLine("You win the round and get " + bet + " life energies !");
                            winning();
                        }
                        else if (totalPlayer > totalBot && totalPlayer <= 21)
                        {
                            Console.WriteLine("You win the round and get " + bet + " life energies !");
                            winning();
                        }
                        else if (totalPlayer < totalBot && totalBot > 21)
                        {
                            Console.WriteLine("You win the round and get " + bet + " life energies !");
                            winning();
                        }
                        //Bot Win
                        else if (totalBot != totalPlayer && totalBot == 21)
                        {
                            Console.WriteLine("The reaper wins the round and gets " + bet + " life energies !");
                            losing();
                        }
                        else if (totalBot > totalPlayer && totalBot <= 21)
                        {
                            Console.WriteLine("The reaper wins the round and gets " + bet + " life energies !");
                            losing();
                        }
                        else if (totalBot < totalPlayer && totalPlayer > 21)
                        {
                            Console.WriteLine("The reaper wins the round and gets " + bet + " life energies !");
                            losing();
                        }
                        //Equality
                        else if (totalPlayer == totalBot)
                        {
                            Console.WriteLine("Equality :o ! Let's try that again....");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey();
                    }
                    else if (choice == 2)
                    {
                        Console.Clear();
                        gaming();
                        Console.WriteLine("You decide to stop...");
                        if (Bcard1 + Bcard2 < 20)
                        {
                            Console.WriteLine("The reaper decides to draw a new card...");
                            Bcard3 = PickaCard();

                            Console.WriteLine("");
                            Console.WriteLine("It's show time <3 !");
                            Console.WriteLine("");
                            Console.WriteLine("Your hand : " + card1 + " and a  " + card2);
                            Console.WriteLine("Reaper hand : " + Bcard1 + ", " + Bcard2 + " and a " + Bcard3);
                        }
                        else
                        {
                            Console.WriteLine("The reaper decides to stop...");
                            Console.WriteLine("");
                            Console.WriteLine("It's show time <3 !");
                            Console.WriteLine("");
                            Console.WriteLine("Your hand : " + card1 + " and a  " + card2);
                            Console.WriteLine("Reaper hand : " + Bcard1 + " and a " + Bcard2);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Press a key to continue :3");
                        Console.ReadKey();
                        Console.Clear();
                        gaming();
                        totalBot = additionBot();
                        totalPlayer = additionPlayer();

                        //Player win
                        if (totalPlayer != totalBot && totalPlayer == 21)
                        {
                            Console.WriteLine("You win the round and get " + bet + " life energies !");
                            winning();
                        }
                        else if (totalPlayer > totalBot && totalPlayer <= 21)
                        {
                            Console.WriteLine("You win the round and get " + bet + " life energies !");
                            winning();
                        }
                        else if (totalPlayer < totalBot && totalBot > 21)
                        {
                            Console.WriteLine("You win the round and get " + bet + " life energies !");
                            winning();
                        }
                        //Bot Win
                        else if (totalBot != totalPlayer && totalBot == 21)
                        {
                            Console.WriteLine("The reaper wins the round and gets " + bet + " life energies !");
                            losing();
                        }
                        else if (totalBot > totalPlayer && totalBot <= 21)
                        {
                            Console.WriteLine("The reaper wins the round and gets " + bet + " life energies !");
                            losing();
                        }
                        else if (totalBot < totalPlayer && totalPlayer > 21)
                        {
                            Console.WriteLine("The reaper wins the round and gets " + bet + " life energies !");
                            losing();
                        }
                        //Equality
                        else if (totalPlayer == totalBot)
                        {
                            Console.WriteLine("Equality :o ! Let's try that again....");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey();
                    }
                }
                while (enemyPV > 0 && playerPV > 0);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                //Losing
                if (playerPV <= 0)
                {

                    try
                    {
                        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Agelosing.wav";
                        player.Play();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }

                    reaper1();
                    reaperRich();
                    reaper2();
                    Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
                    Console.WriteLine("|                                                                                                                     |");
                    Console.WriteLine("|    $w$ Oh oh !!! J'ai gagner ~                                                                                      |");
                    Console.WriteLine("|    Dommage pour toi, ton âme est maintenent a moi >:3 !                                                             |");
                    Console.WriteLine("|                                                                                           (Press Space to continue) |");
                    Console.WriteLine("|_____________________________________________________________________________________________________________________|");
                    Console.ReadKey();

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    try
                    {
                        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Brawl.wav";
                        player.Play();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }

                    Console.WriteLine(" _______  _______  __   __  _______      _______  __   __  _______  ______  ");
                    Console.WriteLine("|       ||   _   ||  |_|  ||       |    |       ||  | |  ||       ||    _ | ");
                    Console.WriteLine("|    ___||  |_|  ||       ||    ___|    |   _   ||  |_|  ||    ___||   | ||  ");
                    Console.WriteLine("|   | __ |       ||       ||   |___     |  | |  ||       ||   |___ |   |_||_ ");
                    Console.WriteLine("|   ||  ||       ||       ||    ___|    |  |_|  ||       ||    ___||    __  |");
                    Console.WriteLine("|   |_| ||   _   || ||_|| ||   |___     |       | |     | |   |___ |   |  | |");
                    Console.WriteLine("|_______||__| |__||_|   |_||_______|    |_______|  |___|  |_______||___|  |_|");

                    Console.WriteLine("Continue ?");
                    Console.WriteLine("1. Let's try that again !");
                    Console.WriteLine("2. Ragequit");
                    choice = Convert.ToInt32(Console.ReadLine());

	            playerPV = 100;
                    enemyPV = 100;

                    if (choice == 2)
                    {
                        System.Environment.Exit(1);
                    }
                }
                //Victory
                else if (enemyPV <= 0)
                {
                    try
                    {
                        player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Flowey.wav";
                        player.Play();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                    }

                    reaper1();
                    reaperCry();
                    reaper2();
                    Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
                    Console.WriteLine("|                                                                                                                     |");
                    Console.WriteLine("|    ;n; Oh nhuuu... Tu m'as battue...                                                                                |");
                    Console.WriteLine("|    C'est vraiment dommage, j'aurais voulu jouer un peux plus longtemps....                                          |");
                    Console.WriteLine("|                                                                                           (Press Space to continue) |");
                    Console.WriteLine("|_____________________________________________________________________________________________________________________|");
                    Console.ReadKey();
                    Console.Clear();

                    reaper1();
                    reaperOwO();
                    reaper2();
                    Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
                    Console.WriteLine("|                                                                                                                     |");
                    Console.WriteLine("|    OwO Attends une seconde.... Je peux pas mourrir si je suis la mort !                                             |");
                    Console.WriteLine("|    Alors ~ on va pouvoir jouer juste qu'a ce que tu meur >:3 !                                                      |");
                    Console.WriteLine("|                                                                                           (Press Space to continue) |");
                    Console.WriteLine("|_____________________________________________________________________________________________________________________|");
                    Console.ReadKey();
                    Console.Clear();
                    reaper1();
                    reaperEvil();
                    reaper2();
                    Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
                    Console.WriteLine("|                                                                                                                     |");
                    Console.WriteLine("|    >:3  MOUAHAHAHAH                                                                                                 |");
                    Console.WriteLine("|                                                                                                                     |");
                    Console.WriteLine("|   1- Continuez à jouez... 2- Se levez et exploser la tête du reaper avec un BFG           (Press 1 or 2 to continue)|");
                    Console.WriteLine("|_____________________________________________________________________________________________________________________|");
                    choice = Convert.ToInt32(Console.ReadLine());

		    playerPV = 100;
                    enemyPV = 100;
                }
            }
            while (choice == 1);

            try
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "DoomVictory.wav";
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            Console.Clear();
            reaper1();
            reaperFocused();
            reaper2();
            Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|    -u- Que fait tu... ? C'est quoi cette arme ? et pourquoi me vise tu ?                                            |");
            Console.WriteLine("|    Tu sais que tu ne peux pas me tué, alors pourquoi essayer ^^\" ?                                                 |");
            Console.WriteLine("|                                                                                           (Press Space to continue) |");
            Console.WriteLine("|_____________________________________________________________________________________________________________________|");
            Console.ReadKey();
            Console.Clear();

            reaper1();
            reaperFocused();
            reaper2();
            Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|    -u- Alors, assis toi et recommencons ~                                                                           |");
            Console.WriteLine("|    S'il vous plait ? ^^\" ?                                                                                         |");
            Console.WriteLine("|                                                                                           (Press Space to continue) |");
            Console.WriteLine("|_____________________________________________________________________________________________________________________|");
            Console.ReadKey();
            Console.Clear();

            reaper1();
            reaperCry();
            reaper2();
            Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|    ^^; Nah, sérieux arrête....                                                                                      |");
            Console.WriteLine("|    Pls >3<    I don't wanna die ;3;  !!                                                                             |");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|_____________________________________________________________________________________________________________________|");

            try
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "BFG.wav";
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            System.Threading.Thread.Sleep(3200);

            flashing();
            flashing();
            flashing();
            flashing();
            flashing();
            flashing();
            flashing();
            flashing();
            flashing();
            flashing();
            flashing();
            flashing();
            flashing();




            try
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "DOOM2016.wav";
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            Console.WriteLine("______ _____  ________  ___   _____  _____ ");
            Console.WriteLine("|  _  |  _  ||  _  |  |/  |  |_   _||_   _|");
            Console.WriteLine("| | | | | | || | | | .  . |    | |    | |  ");
            Console.WriteLine("| | | | | | || | | | ||/| |    | |    | |  ");
            Console.WriteLine("| |/ /| |_/ /| |_/ / |  | |   _| |_  _| |_ ");
            Console.WriteLine("|___/  |___/  |___/|_|  |_/   |___/  |___/ ");
            Console.WriteLine("");
            Console.WriteLine("*Text Base edition *");
            Console.WriteLine("");
            Console.WriteLine("Par Arwing~");
            Console.WriteLine("");
            Console.WriteLine("Appuyez sur une touche pour quitter ^-^");
            Console.ReadKey();

        }
        //GRAPHIC
        static void reaper1()
        {
            Console.WriteLine("              ...");
            Console.WriteLine("             ;::::;");
            Console.WriteLine("           ;::::; :;");
            Console.WriteLine("         ;:::::'   :;");
            Console.WriteLine("        ;:::::;     ;.");
        }
        static void reaper2()
        {
            Console.WriteLine("       ;:::::;       ;         OOOOOOOO");
            Console.WriteLine("      ,;::::::;     ;'         / OOOOOOO");
            Console.WriteLine("    ;:::::::::`. ,,,;.        /  / DOOOOOO");
            Console.WriteLine("  .';:::::::::::::::::;,     /  /     DOOOO");
            Console.WriteLine(" ,::::::;::::::;;;;::::;,   /  /        DOOO");
            Console.WriteLine(";`::::::`'::::::;;;::::: ,#/  /          DOOO");
            Console.WriteLine(":`:::::::`;::::::;;::: ;::#  /            DOO");
            Console.WriteLine("::`:::::::`;:::::::: ;::::# /              DOO");
            Console.WriteLine("`:`:::::::`;:::::: ;::::::#/               DOO");
            Console.WriteLine(" :::`:::::::`;; ;:::::::::##                OO");
            Console.WriteLine("::::`:::::::`;::::::::;:::#                 O");
            Console.WriteLine(" `:::::`::::::::::::;'`:;::#                O");
            Console.WriteLine("  `:::::`::::::::;' /  / `:#");
            Console.WriteLine("   ::::::`:::::;'  /  /   `#");
        }
        static void reaperOwO()
        {
            Console.WriteLine("       ,:::::'  0  0 ;           OOO\\");
            Console.WriteLine("       ::::::;    W  ;          OOOOO\\");
        }
        static void reaperHappy()
        {
            Console.WriteLine("       ,:::::'  ^  ^ ;           OOO\\");
            Console.WriteLine("       ::::::;    W  ;          OOOOO\\");
        }
        static void reaperEvil()
        {
            Console.WriteLine("       ,:::::'  ｀  ´ ;           OOO\\");
            Console.WriteLine("       ::::::;    u  ;          OOOOO\\");
        }
        static void reaperRich()
        {
            Console.WriteLine("       ,:::::'  $  $ ;           OOO\\");
            Console.WriteLine("       ::::::;    W  ;          OOOOO\\");
        }
        static void reaperCry()
        {
            Console.WriteLine("       ,:::::'  ;  ; ;           OOO\\");
            Console.WriteLine("       ::::::;    n  ;          OOOOO\\");
        }
        static void reaperSurprised()
        {
            Console.WriteLine("       ,:::::'  O  O ;           OOO\\");
            Console.WriteLine("       ::::::;    O  ;          OOOOO\\");
        }
        static void reaperFocused()
        {
            Console.WriteLine("       ,:::::'  -  - ;           OOO\\");
            Console.WriteLine("       ::::::;    u  ;          OOOOO\\");
        }
        static void gaming()
        {
            Console.WriteLine(" _____________________________________________________________________________________________________________________ ");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|                                                GAMING TIME !!                                                       |");
            Console.WriteLine("|_____________________________________________________________________________________________________________________|");
            Console.WriteLine("");
        }
        static void flashing()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(100);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            System.Threading.Thread.Sleep(100);
        }
    }
}
