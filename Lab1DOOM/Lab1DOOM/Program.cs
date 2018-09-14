using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1DOOM
    //Copyright Arwing 2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notes de musique
            int mi1 = 165;
            int faD1 = 185;
            int sol1 = 196;
            int solD1 = 208;
            int la1 = 220;
            int laD1 = 233;
            int si1 = 247;
            int do2 = 262;
            int re2 = 293;
            int reD2 = 311;
            int mi2 = 330;
            int fa2 = 349;
            int faD2 = 370;
            int sol2 = 392;
            int solD2 = 415;
            int la2 = 440;
            int laD2 = 466;
            int si2 = 494;
            int do3 = 523;
            int re3 = 587;
            int mi3 = 659;
            int sol3 = 784;
            int laD3 = 831;
            int doD4 = 1109;
            //Longetude
            int halfN = 1000;
            int noteN = 750;
            int blackN = 500;
            int zeeN = 300;
            int zee2N = 330;
            int halfB = 250;
            int fastN = 175;
            //stats
            int luck = 0;
            int force = 0;
            int agility = 0;
            int totalS = 0;
            int PV = 100;
            //Armes Ammunition
            int shotgunB = 0;
            int smgB = 0;
            int BFGB = 0;
            int damage = 0;
            //Armes
            bool pistol = false;
            bool smg = false;
            bool shotgun = false;
            bool masterB = false;
            //Choix
            string name = "X";
            string trololol = "X";
            string firstD = "X";
            int choice = 0;
            //Random
            Random random = new Random();
            int RNG = 0;
            int RNG2 = 0;
            int sJW = 8;
            //Enemy
            int possD = 20;
            int cado = 150;
            int revD = 250;
            int pinky = 500;
            int totalMK = 0;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("______ _____  ________  ___");
            Console.WriteLine("|  _  |  _  ||  _  |  |/  |");
            Console.WriteLine("| | | | | | || | | | .  . |");
            Console.WriteLine("| | | | | | || | | | ||/| |");
            Console.WriteLine("| |/ /| |_/ /| |_/ / |  | |");
            Console.WriteLine("|___/  |___/  |___/|_|  |_/");

            Console.WriteLine("Chargement en cours...");

            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(re2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(do2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(laD1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(si1, fastN);
            Console.Beep(do2, fastN);

            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(re2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(do2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(laD1, noteN);

            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(re2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(do2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(laD1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(si1, fastN);
            Console.Beep(do2, fastN);

            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(re2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(do2, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(mi1, fastN);
            Console.Beep(laD1, noteN);

            Console.WriteLine("Chargement réussi, appuyer pour commencer une partie.");
            Console.ReadKey();
            Console.Clear();
            //Nom
            Console.WriteLine("Veuiller rentrer votre nom.");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Vous avez saisir DoomGuy, êtes-vous sur d'utiliser ce nom? Y/N");
            trololol = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Bienvenue DoomGuy, appuyer sur une touche pour continuer");
            Console.ReadKey();
            //Statistique
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vous devez rentrer vos stats avant de commencer");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(" ");
            Console.WriteLine("La Chance : Augmente les chances de trouver du loot");
            System.Threading.Thread.Sleep(1200);
            Console.WriteLine("La Puissance : Augmente les dégats");
            System.Threading.Thread.Sleep(1200);
            Console.WriteLine("L'Agilité : Augmente vos chance d'esquiver");
            System.Threading.Thread.Sleep(1200);
            Console.WriteLine(" ");
            Console.WriteLine("Vous avez le droit à un maximum de 15 points");
            Console.WriteLine("");
            Console.WriteLine("Appuyer sur une touche pour continuer...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Rentrer votre Chance");
            luck = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rentrer votre Puissance");
            force = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rentrer votre Agilité");
            agility = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Votre Chance est de : " + luck);
            Console.WriteLine("Votre Puissance est de : " + force);
            Console.WriteLine("Votre Agilité est de : " + agility);
            Console.WriteLine("Are you sure about that ? (Y/N)");
            firstD = Convert.ToString(Console.ReadLine());

            if (firstD == "Y")
            {
                Console.WriteLine("D'accord, vous être prêt a commencer votre aventure!");
            }
            else if (firstD == "y")
            {
                Console.WriteLine("D'accord, vous être prêt a commencer votre aventure!");
            }
            else
            {
                Console.WriteLine("Rentrer votre chance");
                luck = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Rentrer votre Puissance");
                force = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Rentrer votre agilité");
                agility = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Votre Chance est de : " + luck);
                Console.WriteLine("Votre Puissance est de : " + force);
                Console.WriteLine("Votre Agilité est de : " + agility);
            }
            totalS = (luck + force + agility);

            if (totalS > 15)
            {
                //DEAD BLUE SCREEN END
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A problem has been detected and Doom has been shut down to prevent damage to your computer.");
                Console.WriteLine("");
                Console.WriteLine("A process or thread crucial to system operation has unexpectedly exited or been terminated.");
                Console.WriteLine("");
                Console.WriteLine("If this is the first time you've seen this stop error screen,");
                Console.WriteLine("Restart the game and enter the right amount of stats");
                Console.WriteLine("If this screen appears again, follow these steps");
                Console.WriteLine("");
                Console.WriteLine("Check to make sure any new hardware or software is properly installed. If this is a new installation, ask your hardware or software manufacturer for any Doom uptates you might need.");
                Console.WriteLine("");
                Console.WriteLine("If prolems continue, disable or remove any newly installed hardware or software. Disable BIOS memory options such as caching or shadowing.");
                Console.WriteLine("");
                Console.WriteLine("Technical information:");
                Console.WriteLine("");
                Console.WriteLine("*** STOP: 0X000000F4 (0X0000003,0X83776D40,0X84776EAC,0XB29FB000");
                Console.Beep(3000, 4000);
                System.Environment.Exit(1);

            }
            else
            {
                Console.WriteLine("  ");
                Console.WriteLine("Appuyer sur une touche pour ENFIN commencer.");
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Vous vous reveillez dans une tombe. à l'extérieur de celle-ci, il y a plein de cadavres et du sang sur les mur...");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(4000);
                RNG = random.Next(1, 11);
                RNG2 = RNG + luck;
                if (RNG2 >= 9)
                {
                    Console.WriteLine("Vous trouvez un guard mort qui tien un SMG accompagner de 30 balle.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Vous trouvez également un pistol sur le cadavre d'un démon.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.WriteLine("Le SMG tire 5 balles par tour qui font 10 de dégats chaque.");
                    Console.WriteLine("Le pistol à infini de balles, vous pouvez seulement en tirer une par tour et fait un total de 20 dégats.");
                    smgB = 30;
                    smg = true;
                    pistol = true;
                }
                else
                {
                    Console.WriteLine("Vous trouvez un pistol sur le cadavre d'un démon.");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("");
                    Console.WriteLine("Le pistol à infini de balles, vous pouvez seulement en tirer une par tour et fait un total de 20 dégats.");
                    pistol = true;
                }
                //Les dégats causer suive cette équation : Dommage par balles * NB balles * Multiplicateur de Dégat (puissance)
            }
            Console.WriteLine("");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Vous sortez alors de la piece avec votre nouvel ami...");
            Console.WriteLine("");
            Console.WriteLine("Appuyez pour continuer...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Vous entrez dans une petite pièce qui a deux sorties. Une qui est sombre et une autre qui est éclairer.");
            System.Threading.Thread.Sleep(3000);

            RNG = random.Next(1, 11);
            RNG = RNG + luck;
            if (RNG >= 13)
            {
                Console.WriteLine("");
                Console.WriteLine("Dans le fond de la pièce, vous apercevez une crate barée avec un cadena.");
                Console.WriteLine("Vous desidez de tirer sur le cadena avec votre pistol et d'écouvrer une cache de munition!");
                smgB = smgB + 15;
                shotgunB = shotgunB + 3;
                BFGB = BFGB + 1;
                System.Threading.Thread.Sleep(4000);
            }
            Console.WriteLine("");
            Console.WriteLine("Quelle chemin décidez-vous de prendre ? Sombre(1) ou Claire(2) ?");
            choice = Convert.ToInt32(Console.ReadLine());
            //Pièce Sombre
            if (choice == 1)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Vous desidez alors d'entrer dans la pièce sombre....");
                Console.WriteLine("");
                Console.WriteLine("Vous voyez fuck all à part la porte de l'autre coté...");                
                Console.WriteLine("Heureusement, il n'y avait aucun piège, ni démon dans cette pièce sombre...");
                Console.WriteLine("");
                Console.WriteLine("Vous continuez alors votre chemin....");
                Console.WriteLine("");
                Console.WriteLine("Appuyez pour continuer...");
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Vous entrez dans la prochaine pièce et entender un bruit de tir... Deux rockets vous passe à coté de la tête, s'explosant sur un mur derrière vous?!");
                Console.WriteLine("");
                Console.WriteLine("Le monstre ressemble a un squellette qui a deux Rocket Battery sur le dos.");
                //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                //Revenant fight !                
                Console.WriteLine("");
                Console.WriteLine("Que faites vous ?");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("");
                Console.WriteLine("1. Le tirer avec votre pistol");
                Console.WriteLine("2. Le tirer avec votre SMG");
                Console.WriteLine("3. Esquiver son attaque et s'en aller vers la prochaine pièce");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                //Pistol
                if (choice == 1)
                {
                    Console.WriteLine("");
                    damage = 20 * 1 * force;
                    revD = revD - damage;
                    Console.WriteLine("Vous décidez de prendre votre pistol et de tirer une balle quekpar sur lui, pour un total de " + damage + " dégat.");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("");
                    if (revD <= 0)
                    {
                        Console.WriteLine("Votre attaque est tellement puissante qu'il explose !");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Le revenant vous tire deux rockets, vous fesant 80 de dégats!");
                        PV = PV - 80;
                        Console.WriteLine("");
                        Console.WriteLine("Il s'apprête a vous attaquez avec son attaque spécial... Que faites vous ?");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("");
                        Console.WriteLine("4. Le tirer encore avec votre pistol");
                        Console.WriteLine("5. Le tirer avec votre SMG");
                        Console.WriteLine("6. Esquiver son attaque et s'en aller vers la prochaine pièce");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 4)
                        {
                            Console.WriteLine("");
                            damage = 20 * 1 * force;
                            revD = revD - damage;
                            Console.WriteLine("Alors, vous tirer avec votre pistol une fois de plus, lui fesant un autre " + damage + ".");
                            Console.WriteLine("");
                            if (revD <= 0)
                            {
                                Console.WriteLine("Votre deuxième tire le tue...");
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Le Revenant vous tire un barrage de rockets, vous fesant 120 HP de dégats !");
                                System.Threading.Thread.Sleep(3000);
                                gameOver();

                            }
                            Console.WriteLine("Vous vous sentez plus fort après ce combat, et il vous reste " + PV + " HP.");
                            force = force + 1;
                            totalMK = totalMK + 1;
                            
                        }
                        //SMG
                        else if (choice == 5)
                        {
                            Console.WriteLine("");
                            if (smg == true)
                            {
                                damage = 10 * 5 * force;
                                revD = revD - damage;
                                Console.WriteLine("Vous prenez votre SMG et tirer 5 balles en direction du Revenant.");
                                Console.WriteLine("");
                                if (revD > 0)
                                {
                                    Console.WriteLine("Encore en vie, il vous tire une nuke, vous causant un autre 1000 de dégat! Vous explosez...");
                                    System.Threading.Thread.Sleep(3000);
                                    gameOver();
                                }
                                else
                                {
                                    Console.WriteLine("Les 5 balles l'atteigne de plein fouet! Il meurt sur le coup.");
                                    smgB = smgB - 5;
                                }
                                Console.ReadLine();
                                Console.WriteLine("Vous vous sentez plus fort après ce combat, et il vous reste " + PV + " HP.");
                                force = force + 1;
                                totalMK = totalMK + 1;

                            }
                            else
                            {
                                Console.WriteLine("Vous prenez votre SMG imaginaire et tirer des balles imaginaires. Le Revenant vous tire un missile au Francium.");
                                PV = PV - 9999;
                                Console.WriteLine("");
                                Console.WriteLine(" La map explose...");
                                System.Threading.Thread.Sleep(3000);
                                gameOver();
                            }
                        }
                        else if (choice == 6)
                        {
                            Console.Clear();
                            Console.WriteLine("Vous desidez de dodge sa prochaine attaque et de run vers la sortie....");
                            Console.WriteLine("");
                            if (agility >= 7)
                            {
                                Console.WriteLine("Tell que dans un film de Michael Bay, vous sautez au moment de l'explosion, surfant l'onde de choque vers la sortie.");
                            }
                            else
                            {
                                Console.WriteLine("Vous essayez de sauter avec l'onde de choque... mais le missile vous arrive dessu...");
                                System.Threading.Thread.Sleep(3000);
                                gameOver();
                            }
                        }
                    }
                }

                else if (choice == 2)
                {
                    //SMG CHOICE 1
                    Console.WriteLine("");
                    if (smg == true)
                    {
                        Console.WriteLine("Vous prenez votre SMG et tirer 5 balles en direction du Revenant.");
                        damage = force * 10 * 5;
                        smgB = smgB - 5;
                        revD = revD - damage;
                        Console.WriteLine("");
                        if (revD <= 0)
                        {
                            Console.WriteLine("Vos balles pognent les missiles du Revenant, le fesant exploser en mille morceaux !");
                            totalMK = totalMK + 1;
                        }
                        else
                        {
                            Console.WriteLine("Le démon survie a votre attaque et vous tire une rocket, vous causant un 80 HP de dégats!");
                            PV = PV - 80;
                            Console.WriteLine("");
                            Console.WriteLine("Appuyer sur une touche pour continuer...");
                            Console.ReadKey();
                            Console.Clear();
                            if (PV <= 0)
                            {
                                Console.WriteLine("Vous explosez telle un feu d'artifice !");
                                Console.WriteLine("");
                                Console.WriteLine("Appuyer sur une touche pour continuer....");
                                Console.ReadKey();
                                gameOver();
                            }
                            else
                            {
                                Console.WriteLine("Une autre rocket se dirige vers vous ! Que faites-vous ?");
                                Console.WriteLine("");
                                Console.WriteLine("4. Tirer le Cacodemon avec votre pistol");
                                Console.WriteLine("5. Tirer le cacodemon avec votre SMG");
                                Console.WriteLine("6. Tentez d'esquiver son attaque et allez dans la prochaine");
                                choice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                if (choice == 4)
                                {
                                    Console.WriteLine("Vous prenez alors votre pistol et tirer sur le Revenant !");
                                    Console.WriteLine("");
                                    damage = 1 * 10 * force;
                                    revD = revD - damage;
                                    if (revD > 0)
                                    {
                                        Console.WriteLine("Votre tir ne l'a pas tué, vous causant un autre 80 de dégats !");
                                        Console.WriteLine("");
                                        Console.WriteLine("Appuyer sur une touche pour continuer....");
                                        Console.ReadKey();
                                        gameOver();
                                    }
                                }
                                else if (choice == 5)
                                {
                                    Console.WriteLine("Vous prenez alors votre SMG et tirer une rafalle vers le Revenant !");
                                    Console.WriteLine("");
                                    revD = revD - damage;
                                    if (revD > 0)
                                    {
                                        Console.WriteLine("Le Cacodemon, encore en vie, vous tire une autre rocket...");
                                        Console.WriteLine("");
                                        Console.WriteLine("Appuyer sur une touche pour continuer....");
                                        Console.ReadKey();
                                        gameOver();
                                    }
                                }
                                else if (choice == 6)
                                {
                                    Console.WriteLine("Vous desidez d'esquiver son attaque et essayez de vous enfuir vers la prochaine pièce...");
                                    Console.WriteLine("");
                                    if (agility < 7)
                                    {
                                        Console.WriteLine("Bad news ! Il s'avère que ses missiles sont a tête chercheuse ;)");
                                        Console.WriteLine("");
                                        Console.WriteLine("Appuyer sur une touche pour continuer....");
                                        Console.ReadKey();
                                        gameOver();
                                    }
                                }
                                if (revD <= 0)
                                {
                                    Console.WriteLine("Après cette victoire sérrée, vous vous sentez plus fort");
                                    force = force + 1;
                                    totalMK = totalMK + 1;
                                }
                                else
                                {
                                    Console.WriteLine("Comme un lache, vous parvenez à vous enfuir vers la prochaine pièce...");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vous prenez votre SMG immaginaire et direz une rafale de balle invisible ! Vous recevez un missile de plein fouet et subissez 80 HP de dégats !");
                        PV = PV - 80;
                        if (PV <= 0)
                        {
                            Console.WriteLine("Malheureusement, Parménide n'est pas venue vous aidez....");
                            Console.WriteLine("");
                            Console.WriteLine("Appuyer sur une touche pour continuer...");
                            Console.ReadKey();
                            gameOver();
                        }
                        else
                        {
                            //Si player pas mort
                            Console.WriteLine("");
                            Console.WriteLine("Avec cette event un peu awkward, il vous tire un missile! Que faites vous ?");
                            Console.WriteLine("");
                            Console.WriteLine("4. Vous prenez votre pistol et tirez une balle sur le missile.");
                            Console.WriteLine("5. Vous decidez encore de prendre votre SMG imaginaire !");
                            Console.WriteLine("6. Vous essayez de fuir.");
                            choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if (choice == 4)
                            {
                                Console.WriteLine("Vous prenez votre pistol et tirez une balle sur le missile !");
                                Console.WriteLine("");
                                Console.WriteLine("Appuyer sur une touche pour continuez...");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Le missile explose ! Mais un autre missile apparait et vous explose !");
                                System.Threading.Thread.Sleep(3000);
                                gameOver();
                            }
                            else if (choice == 5)
                            {
                                Console.WriteLine("Vous prenez encore votre SMG imaginaire et l'utilisez contre le Revenant en lui criant : TAYEUL TÉ SENS SONT TROMPEUR !");
                                Console.WriteLine("");
                                Console.WriteLine("La bullshit de Parménide ne s'avère pas super efficace contre ce monstre...");
                                System.Threading.Thread.Sleep(9000);
                                gameOver();
                            }
                            else
                            {
                                Console.WriteLine("Vous desidez d'esquivez son attaque...");
                                Console.WriteLine("");
                                Console.WriteLine("Appuyer pour continuez...");
                                if (agility >= 7)
                                {
                                    Console.WriteLine("MICHEAL BAY EXPLOSION !!! Vous surfez sur l'onde de choque et tomber dans la prochaine pièce!");
                                }
                                else
                                {
                                    Console.WriteLine("Vous vous prennez le missile en pleine gueule !");
                                    System.Threading.Thread.Sleep(3000);
                                    gameOver();
                                }
                            }

                        }

                    }
                }
                else if (choice == 3)
                {
                    //Dodge CHOICE 1
                    Console.WriteLine("");
                    Console.WriteLine("Vous dedidez de dodge son missile et d'essayez de vous enfuir vers la prochaine pièce...");
                    Console.WriteLine("");
                    Console.WriteLine("Appuyer sur une touche pour continuer...");
                    Console.ReadKey();
                    if (agility >= 7)
                    {
                        Console.WriteLine("MICHEAL BAY EXPLOSION !!! Vous surfez sur l'onde de choque et tomber dans la prochaine pièce!");
                    }
                    else
                    {
                        Console.WriteLine("Vous ne parvenez pas à esquivez sa boule de plasma, et la prennez de plein fouet ! Avant même de le réaliser, vous êtes mort....");
                        System.Threading.Thread.Sleep(3000);
                        gameOver();
                    }
                }
                //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.WriteLine("");
                Console.WriteLine("Appuyer sur une touche pour continuez....");
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Vous entrez dans une mini pièce. Il y a deux portes.");
                Console.WriteLine("");
                Console.WriteLine("La première à une pancarte disant : Vous entrez, vous mourez ! (1)");
                Console.WriteLine("L'autre à également une pancartes disant : La première porte dit que des mensonges. (2)");
                Console.WriteLine("");
                Console.WriteLine("Quelle porte prenez-vous ?");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (choice == 2)
                {
                    Console.WriteLine("Vous entrez dans la deuxième pièce...");
                    Console.WriteLine("");
                    Console.WriteLine("Le sol explose! Un petit kikoo minecraft a mis du TNT avec des plaque de pression :|");
                    Console.WriteLine("");
                    Console.WriteLine("Appuyer sur une touche pour mourir lol");
                    Console.ReadKey();
                    gameOver();
                }
                else
                {
                    //#######################################################################################################################################################################
                    //RedNeck
                    Console.Clear();
                    Console.WriteLine("Vous entrez dans la bonne pièce !");

                    Console.Beep(do3, halfB);
                    Console.Beep(do3, halfB);
                    Console.Beep(do3, halfB);
                    Console.Beep(do3, blackN);
                    Console.Beep(solD2, blackN);
                    Console.Beep(laD2, blackN);
                    Console.Beep(do3, blackN);
                    Console.Beep(laD2, halfB);
                    Console.Beep(do3, halfN);

                    Console.WriteLine("");
                    Console.WriteLine("Mais... au milieu de nul part, il y a un revenant avec un shotgun ?! Da f***");
                    Console.WriteLine("");
                    Console.WriteLine("Que voulez vous faire ?");
                    Console.WriteLine("");
                    Console.WriteLine("1. Prendre votre pistol et lui tirez dessu.");
                    Console.WriteLine("2. Le tirer comme un gangster avec votre SMG.");
                    Console.WriteLine("3. Sneak comme un ninja et allez à la prochaine pièce.");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if(choice == 1)
                    {
                        Console.WriteLine("Vous prenez votre pistol et lui tirez dans la tête !");
                        Console.WriteLine("");
                        damage = 1 * 20 * force;
                        possD = 20;
                        possD = possD - damage;
                        if(possD > 0)
                        {
                            Console.WriteLine("Votre tire est tellement faible... sérieux, si ta force aurait été de deux ou +, il serait mort...");
                            Console.WriteLine("");
                            Console.WriteLine("Meh, il vous tire dessu et vous mourrez lol");
                            System.Threading.Thread.Sleep(3000);
                            gameOver();
                        }
                        else
                        {
                            Console.WriteLine("Votre balle lui explose la tête ! Vous récupérez son shotgun");
                            totalMK = totalMK + 1;
                            shotgun = true;
                            shotgunB = shotgunB + 5;
                        }
                    }
                    else if(choice == 2)
                    {
                        damage = 5 * 10 * force;
                        if (smg == true)
                        {
                            Console.WriteLine("Vous prenez votre SMG et tirer 5 balles vers le possessed demon !");
                            Console.WriteLine("");
                            smgB = smgB - 5;
                            if (possD > 0)
                            {
                                Console.WriteLine("Vous ne parvenez pas à tuer le démon, et il vous tire une balle de 12...");
                                System.Threading.Thread.Sleep(4000);
                                gameOver();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vous prenez votre SMG invisible et tirez vos balle invisible sur le démon...");
                            Console.WriteLine("");
                            Console.WriteLine("Il vous punni avec une belle balle de 12 !");
                            System.Threading.Thread.Sleep(8000);
                            gameOver();

                        }
                    }
                    else
                    {
                        Console.WriteLine("Vous tentez de sneaks vers l'autre porte...");
                        Console.WriteLine("");
                        if(agility >= 8)
                        {
                            Console.WriteLine("Comme un true ninja, vous sneakez à côté de lui sans problême !");
                        }
                        else
                        {
                            Console.WriteLine("Vos sick ninja skill sont pas assez haut... Il vous voie et vous tire une balle de 12 dans yeule.");
                            System.Threading.Thread.Sleep(3000);
                            gameOver();

                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Appuyez sur une touche pour continuer...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Vous vous dirrigez vers la dernière pièce.... avec une grosse croix rouge sur la porte !");
                    Console.WriteLine("");
                    Console.WriteLine("Vous trouvez également un medkit qui vous redonne toute votre vie :P");
                    PV = 100;
                    Console.WriteLine("");
                    Console.WriteLine("Appuyez sur une touche pour continuer....");
                    Console.ReadKey();
                    Console.Clear();

                }


                Console.WriteLine("Veuillez spammer une touche pour continuer.... RIP BUG");
                Console.ReadKey();
            }
            //Pièce Claire
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Vous entrez dans la pièce claire et remarquer qu'il y a Possessed Scientist");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("");
                Console.WriteLine("Il s'approche de vous lentement. Que faites-vous ?");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("1. Le tirer avec votre pistol");
                Console.WriteLine("2. Le tirer avec votre SMG");
                Console.WriteLine("3. Esquiver son attaque et s'en aller vers la prochaine pièce");
                choice = Convert.ToInt32(Console.ReadLine());
                //Pistol
                if (choice == 1)
                {
                    Console.WriteLine("");
                    damage = 20 * 1 * force;
                    possD = possD - damage;
                    Console.WriteLine("Vous décidez de prendre votre pistol et de tirer une balle droit dans le coeur, pour un total de " + damage + " dégat!");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("");
                    if (possD <= 0)
                    {
                        Console.WriteLine("Le chest du Possessed Scientist explose, mort sur le coup!");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("Félicitation, vous avez réussi à ne pas le one shot! votre récompense : 20 point de dégat au joueur.");
                        PV = PV - 20;
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("");
                        Console.WriteLine("Après cette defaite lamentable sur votre attaque, vous lui sacrez un poing sa yeule et il explose, vous causant un beau 30 de dégat!");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("");
                        PV = PV - 30;
                    }
                    Console.WriteLine("Vous vous sentez confiant après votre victoire, et il vous reste " + PV + " HP.");
                    totalMK = totalMK + 1;
                    possD = 20;
                }
                //SMG
                else if (choice == 2)
                {
                    Console.WriteLine("");
                    if (smg == true)
                    {
                        damage = 10 * 5 * force;
                        possD = possD - damage;
                        Console.WriteLine("Vous prenez votre SMG et tirer 5 balles en direction du Possessed Scientist.");
                        smgB = smgB - 5;
                        Console.WriteLine("");
                        if (possD > 0)
                        {
                            Console.WriteLine("Encore en vie, il vous saute dessu et explose, vous causant un beau 30 de dégat!");
                            Console.WriteLine("Il vous reste " + PV + ".");
                            System.Threading.Thread.Sleep(4000);
                            PV = PV - 30;
                        }
                        else
                        {
                            Console.WriteLine("Les 5 balles l'atteigne, le tuant sur le coup!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Vous prenez votre SMG imaginaire et tirer des balles imaginaires. Le possessed Scientist vous regarde en se posant des question... et vous attaques pour 20 de dégats.");
                        PV = PV - 20;
                        Console.WriteLine("");
                        Console.WriteLine("Vous desidez de prendre votre pistol et tirer une balle dans la tête");
                        possD = possD - damage;

                        if (possD > 0)
                        {
                            Console.WriteLine("Après cette defaite lamentable sur votre attaque, vous lui sacrez un poing sa yeule et il explose, vous causant un beau 30 de dégat!");
                            System.Threading.Thread.Sleep(4000);
                            Console.WriteLine("");
                            PV = PV - 30;
                        }
                    }


                }
                else if (choice == 3)
                {
                    Console.WriteLine("Vous tentez de simplement passer à coté et l'ignorer complettement... LOL");
                    Console.WriteLine("");

                }
                Console.WriteLine("Appuyer sur une touche pour continuer...");
                Console.ReadKey();
                Console.Clear();
                if (luck >= 10)
                {
                    //MasterBall end Start now
                    Console.WriteLine("En voulant sortir par la seule sortie possible, vous tribuchez sur une roche et ouvrer un passage secret... ");
                    Console.WriteLine("vous vous prennez également 1 HP de dégat !");
                    Console.WriteLine("");
                    Console.WriteLine("Appuyez pour continuer...");
                    PV = PV - 1;
                    Console.Beep(sol2, fastN);
                    Console.Beep(faD2, fastN);
                    Console.Beep(reD2, fastN);
                    Console.Beep(la1, fastN);
                    Console.Beep(solD1, fastN);
                    Console.Beep(mi2, fastN);
                    Console.Beep(solD2, fastN);
                    Console.Beep(do3, noteN);
                    Console.ReadKey();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.WriteLine("Vous entrez alors dans cette nouvelle pièce mystérieuse et appercevez une balle blanche et mauve avec un M sur le top.");
                    Console.WriteLine("Vous la placez dans votre inventaire.");
                    masterB = true;
                    Console.Beep(mi2, fastN);
                    Console.Beep(mi2, fastN);
                    Console.Beep(mi2, fastN);
                    Console.Beep(si2, noteN);
                    Console.WriteLine("");
                    Console.WriteLine("Vous apercevez un teleporteur avec un terminal allumer dans le fond de la pièce. Sur le téléporteur, il est écris :");
                    Console.WriteLine("");
                    Console.WriteLine("Un escargot est dans un puits de 10 mètres. Il monte 3 mètres chaque jour et descend 2 mètres chaque nuit.");
                    Console.WriteLine("En combien de jours sera-t-il rendu en haut ?");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("Veuillez entrer votre réponse....");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (choice == sJW)
                    {
                        Console.WriteLine("Vous rentrez le nombre " + choice + " et après avoir appuyer sur ENTER, un nouveau message s'affiche.");
                        Console.WriteLine("");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("READY FOR TELEPORTATION!");
                        Console.WriteLine("");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Vous regardez autour et il n' a pas d'autre sortie. Alors vous allez sur le téléporteur....");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("");
                        Console.WriteLine("Appuyer sur une touche pour continuer...");
                        Console.ReadKey();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Vous apparaissez dans une pièce entouré de lave. Vous marchez tranquillement quand soudain...");
                        System.Threading.Thread.Sleep(5000);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Threading.Thread.Sleep(100);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Threading.Thread.Sleep(100);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Threading.Thread.Sleep(100);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Threading.Thread.Sleep(100);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Threading.Thread.Sleep(100);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;


                        Console.Beep(sol2, fastN);
                        Console.Beep(faD2, fastN);
                        Console.Beep(fa2, fastN);
                        Console.Beep(sol2, fastN);
                        Console.Beep(faD2, fastN);
                        Console.Beep(fa2, fastN);
                        Console.Beep(sol2, fastN);
                        Console.Beep(faD2, fastN);
                        Console.Beep(fa2, fastN);
                        Console.Beep(sol2, fastN);
                        Console.Beep(faD2, fastN);
                        Console.Beep(fa2, fastN);
                        Console.Beep(sol2, fastN);
                        Console.Beep(faD2, fastN);
                        Console.Beep(fa2, fastN);
                        Console.Beep(sol2, fastN);
                        Console.Beep(faD2, fastN);
                        Console.Beep(fa2, fastN);

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine(" ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ");
                        Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                                                                                __  ");
                        Console.WriteLine(" _____          _ _   _    _____ _     _          _____                        |  | ");
                        Console.WriteLine("|  _  |   _ _ _|_| |_| |  |  _  |_|___| |_ _ _   |  _  |___ ___ ___ ___ ___ ___|  | ");
                        Console.WriteLine("|     |  | | | | | | . |  |   __| |   | '_| | |  |     | . | . | -_| .'|  _|_ -|__| ");
                        Console.WriteLine("|__|__|  |_____|_|_|___|  |__|  |_|_|_|_,_|_  |  |__|__|  _|  _|___|__,|_| |___|__| ");
                        Console.WriteLine("                                          |___|        |_| |_|                     ");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(" ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ___ ");
                        Console.WriteLine("|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|___|");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(300);
                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(100);
                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(1000);
                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(100);
                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(100);
                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(100);
                        Console.Beep(faD1, halfN);
                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(100);
                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(100);
                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(1000);
                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(100);
                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(100);
                        Console.Beep(sol1, blackN);
                        System.Threading.Thread.Sleep(100);
                        Console.Beep(faD1, halfN);

                        Console.WriteLine("Que voulez vous faire ?");
                        Console.WriteLine("1. Attaquer");
                        Console.WriteLine("2. Fuire");
                        Console.WriteLine("3. Utiliser la MasterBall!");

                        Console.Beep(sol2, blackN);
                        Console.Beep(faD2, blackN);
                        Console.Beep(mi2, blackN);
                        Console.Beep(sol2, blackN);
                        Console.Beep(la2, blackN);
                        Console.Beep(sol2, blackN);
                        Console.Beep(laD3, halfN);
                        Console.Beep(sol3, fastN);
                        System.Threading.Thread.Sleep(100);
                        Console.Beep(laD3, fastN);
                        Console.Beep(sol3, fastN);
                        System.Threading.Thread.Sleep(300);
                        Console.Beep(doD4, halfN);
                        choice = Convert.ToInt32(Console.ReadLine());

                        if (choice == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Vous avez une paire de couilles en acier !");
                            Console.WriteLine("Malgré ce fait, il vous saute dessu avant même que vous puissiez bouger un muscle...");
                            Console.WriteLine("vous dévorant vivant... très douloureux !");
                            System.Threading.Thread.Sleep(7000);
                            gameOver();
                        }
                        else if (choice == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Vous vous enfuyez en criant I DON'T WANT TO DIE !!!");
                            Console.WriteLine("Pas de chance, il n'y a pas de sortie... RIP");
                            System.Threading.Thread.Sleep(4000);
                            gameOver();
                        }
                        else if (choice == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Vous lancez alors votre MasterBall droit entrer c'est deux yeux.");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("");
                            Console.WriteLine("1...");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("2....");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("3.....");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("PINKY was caught!");
                            Console.Beep(do3, halfB);
                            Console.Beep(do3, halfB);
                            Console.Beep(do3, halfB);
                            Console.Beep(do3, blackN);
                            Console.Beep(solD2, blackN);
                            Console.Beep(laD2, blackN);
                            Console.Beep(do3, blackN);
                            Console.Beep(laD2, halfB);
                            Console.Beep(do3, halfN);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("");
                            Console.WriteLine("██╗   ██╗██╗ ██████╗████████╗ ██████╗ ██████╗ ██╗   ██╗    ██╗");
                            Console.WriteLine("██║   ██║██║██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗╚██╗ ██╔╝    ██║");
                            Console.WriteLine("██║   ██║██║██║        ██║   ██║   ██║██████╔╝ ╚████╔╝     ██║");
                            Console.WriteLine("╚██╗ ██╔╝██║██║        ██║   ██║   ██║██╔══██╗  ╚██╔╝      ╚═╝");
                            Console.WriteLine(" ╚████╔╝ ██║╚██████╗   ██║   ╚██████╔╝██║  ██║   ██║       ██╗");
                            Console.WriteLine("  ╚═══╝  ╚═╝ ╚═════╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚═╝");
                            Console.WriteLine("");
                            Console.Beep(faD2, halfB);
                            Console.Beep(faD2, halfB);
                            Console.Beep(re2, halfB);
                            Console.Beep(si1, blackN);
                            Console.Beep(si1, blackN);
                            Console.Beep(mi2, blackN);
                            Console.Beep(mi2, blackN);
                            Console.Beep(mi2, halfB);
                            Console.Beep(solD2, halfB);
                            Console.Beep(solD2, halfB);
                            Console.Beep(la2, halfB);
                            Console.Beep(si2, halfB);
                            Console.Beep(la2, halfB);
                            Console.Beep(la2, halfB);
                            Console.Beep(la2, halfB);
                            Console.Beep(mi2, blackN);
                            Console.Beep(re2, blackN);
                            Console.Beep(faD2, blackN);
                            Console.Beep(faD2, blackN);
                            Console.Beep(faD2, halfB);
                            Console.Beep(mi2, halfB);
                            Console.Beep(mi2, halfB);
                            Console.Beep(faD2, halfB);
                            Console.Beep(mi2, halfB);
                            Console.Beep(faD2, halfB);
                            Console.Beep(faD2, halfB);
                            Console.Beep(re2, halfB);
                            Console.Beep(si1, blackN);
                            Console.Beep(si1, blackN);
                            Console.Beep(mi2, blackN);
                            Console.Beep(mi2, blackN);
                            Console.Beep(mi2, halfB);
                            Console.Beep(solD2, halfB);
                            Console.Beep(solD2, halfB);
                            Console.Beep(la2, halfB);
                            Console.Beep(si2, halfB);
                            Console.Beep(la2, halfB);
                            Console.Beep(la2, halfB);
                            Console.Beep(la2, halfB);
                            Console.Beep(mi2, blackN);
                            Console.Beep(re2, blackN);
                            Console.Beep(faD2, blackN);
                            Console.Beep(faD2, blackN);
                            Console.Beep(faD2, halfB);
                            Console.Beep(mi2, halfB);
                            Console.Beep(mi2, halfB);
                            Console.Beep(faD2, halfB);
                            Console.Beep(mi2, halfB);
                            Console.WriteLine("Vous avez réussi avec la CHANCE. (Il y a 3 fin possible)");
                            Console.WriteLine("");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("Appuyer une touche pour fermer le jeu...");
                            Console.ReadKey();
                            System.Environment.Exit(1);
                        }


                    }
                    else
                    {
                        Console.WriteLine("Vous rentrez le nombre " + choice + " et après avoir appuyer sur ENTER, un nouveau message s'affiche.");
                        Console.WriteLine("");
                        Console.WriteLine("READY FOR TELEPORTATION!");
                        Console.WriteLine("Vous regardez autour et il n' a pas d'autre sortie. Alors vous allez sur le téléporteur....");
                        Console.WriteLine("");
                        Console.WriteLine("Appuyer sur une touche pour continuer...");
                        Console.ReadKey();
                        gameOver();
                    }

                }
                //COMBAT CONTRE LE CADO
                Console.WriteLine("Vous continuez votre chemain vers la prochaine pièce...");
                Console.WriteLine("");
                Console.WriteLine("Appuyer sur une touche pour continuer...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("La pièce semble vide... lorsque soudain, un Cacodemon vous tire une boule de plasma !");
                Console.WriteLine("");
                Console.WriteLine("Vous avez à peine le temps d'esquiver la boule qu'il vous en tire une autre ! Que faites vous ?");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("");
                Console.WriteLine("1. Le tirer avec votre pistol");
                Console.WriteLine("2. Le tirer avec votre SMG");
                Console.WriteLine("3. Esquiver son attaque et s'en aller vers la prochaine pièce");
                choice = Convert.ToInt32(Console.ReadLine());
                //Pistol
                if (choice == 1)
                {
                    Console.WriteLine("");
                    damage = 20 * 1 * force;
                    cado = cado - damage;
                    Console.WriteLine("Vous décidez de prendre votre pistol et de tirer une balle droit dans l'oeil, pour un total de " + damage + " dégat!");
                    System.Threading.Thread.Sleep(3000);
                    Console.WriteLine("");
                    if (cado <= 0)
                    {
                        Console.WriteLine("Le Cacodemon explose tellement votre attaque était puissante !");
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Le Cacodemon vous tire une boule de plasma, vous fesant 50 de dégats.");
                        PV = PV - 50;
                        if (PV <= 0)
                        {
                            System.Threading.Thread.Sleep(3000);
                            gameOver();
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Que faites vous ?");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("");
                        Console.WriteLine("4. Le tirer encore avec votre pistol");
                        Console.WriteLine("5. Le tirer avec votre SMG");
                        Console.WriteLine("6. Esquiver son attaque et s'en aller vers la prochaine pièce");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 4)
                        {
                            Console.WriteLine("");
                            damage = 20 * 1 * force;
                            cado = cado - damage;
                            Console.WriteLine("Alors, vous tirer avec votre pistol une fois de plus, lui fesant un autre " + damage + ".");
                            Console.WriteLine("");
                            if (cado <= 0)
                            {
                                Console.WriteLine("Votre deuxième tire le tue.");
                                System.Threading.Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("Le Cacodemon vous fait un autre 50 de dégats ! Vous explosez...");
                                System.Threading.Thread.Sleep(3000);
                                gameOver();

                            }
                            Console.WriteLine("Vous vous sentez plus fort après ce combat, et il vous reste " + PV + " HP.");
                            force = force + 1;
                            totalMK = totalMK + 1;
                            cado = 150;
                        }
                        //SMG
                        else if (choice == 5)
                        {
                            Console.WriteLine("");
                            if (smg == true)
                            {
                                damage = 10 * 5 * force;
                                cado = cado - damage;
                                Console.WriteLine("Vous prenez votre SMG et tirer 5 balles en direction du Cacodemon.");
                                Console.WriteLine("");
                                if (cado > 0)
                                {
                                    Console.WriteLine("Encore en vie, il vous tire dessu, vous causant un autre 50 de dégat! Vous explosez...");
                                    System.Threading.Thread.Sleep(3000);
                                    gameOver();
                                }
                                else
                                {
                                    Console.WriteLine("Les 5 balles l'atteigne, le transformant en fromage suisse.");
                                    smgB = smgB - 5;
                                }
                                Console.ReadLine();
                                Console.WriteLine("Vous vous sentez plus fort après ce combat, et il vous reste " + PV + " HP.");
                                force = force + 1;
                                totalMK = totalMK + 1;
                                cado = 150;


                            }
                            else
                            {
                                Console.WriteLine("Vous prenez votre SMG imaginaire et tirer des balles imaginaires. Cacodemon vous tire à nouveau et vous prenez un autre 50 de dégat!");
                                PV = PV - 50;
                                Console.WriteLine("");
                                Console.WriteLine("Encore en vie, il vous tire dessu, vous causant un autre 50 de dégat! Vous explosez...");
                                System.Threading.Thread.Sleep(3000);
                                gameOver();
                            }
                        }
                        else if (choice == 6)
                        {
                             Console.Clear();
                             Console.WriteLine("Vous desidez de dodge sa prochaine attaque et de run vers la sortie....");
                             Console.WriteLine("");
                             if (agility >= 7)                                
                             {
                                 Console.WriteLine("Tell que Néo dans la matrix, vous esquivez sa boule de plasma et, avec un peu de chance, vous vous rendez vers la prochaine pièce sans perdre 1 HP !");
                             }
                             else
                             {
                                 Console.WriteLine("Vous ne parvenez pas à esquivez sa boule de plasma, et la prennez de plein fouet ! Avant même de le réaliser, vous êtes mort....");
                                 System.Threading.Thread.Sleep(3000);
                                gameOver();
                            }
                        }
                    }                 
                }
                
               else if(choice == 2)
                {
                    //SMG CHOICE 1
                    Console.WriteLine("");
                    if(smg == true)
                    {
                        Console.WriteLine("Vous prenez votre SMG et tirer 5 balles en direction du Cacodemon");
                        damage = force * 10 * 5;
                        smgB = smgB - 5;
                        cado = cado - damage;
                        Console.WriteLine("");
                        if(cado <= 0)
                        {
                            Console.WriteLine("Vous transformez ce fuckeur en fromage suisse!");
                            totalMK = totalMK + 1;
                        }
                        else
                        {
                            Console.WriteLine("Le démon survie a votre attaque et sa boule vous touche, vous causant un 50 HP de dégats!");
                            PV = PV - 50;
                            Console.WriteLine("");
                            Console.WriteLine("Appuyer sur une touche pour continuer...");
                            Console.ReadKey();
                            Console.Clear();
                            if (PV <= 0)
                            {
                                Console.WriteLine("Vous explosez telle un feu d'artifice !");
                                Console.WriteLine("");
                                Console.WriteLine("Appuyer sur une touche pour continuer....");
                                Console.ReadKey();
                                gameOver();
                            }
                            else
                            {
                                Console.WriteLine("Une autre balle se dirige vers vous ! Que faites-vous ?");
                                Console.WriteLine("");
                                Console.WriteLine("4. Tirer le Cacodemon avec votre pistol");
                                Console.WriteLine("5. Tirer le cacodemon avec votre SMG");
                                Console.WriteLine("6. Tentez d'esquiver son attaque et allez dans la prochaine");
                                choice = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("");
                                if(choice == 4)
                                {
                                    Console.WriteLine("Vous prenez alors votre pistol et tirer sur de Cacodemon !");
                                    Console.WriteLine("");
                                    damage = 1 * 10 * force;
                                    cado = cado - damage;
                                    if (cado > 0)
                                    {
                                        Console.WriteLine("Votre tir ne l'a pas tué, vous causant un autre 50 de dégats !");
                                        Console.WriteLine("");
                                        Console.WriteLine("Appuyer sur une touche pour continuer....");
                                        Console.ReadKey();
                                        gameOver();
                                    }
                                }
                                else if(choice == 5)
                                {
                                    Console.WriteLine("Vous prenez alors votre SMG et tirer une rafalle vers le Cacodemon !");
                                    Console.WriteLine("");
                                    cado = cado - damage;
                                    if(cado > 0)
                                    {
                                        Console.WriteLine("Le Cacodemon, encore en vie, vous tire une autre boule de plasma...");
                                        Console.WriteLine("");
                                        Console.WriteLine("Appuyer sur une touche pour continuer....");
                                        Console.ReadKey();
                                        gameOver();
                                    }
                                }
                                else if(choice == 6)
                                {
                                    Console.WriteLine("Vous desidez d'esquiver son attaque et essayez de vous enfuir vers la prochaine pièce...");
                                    Console.WriteLine("");
                                    if(agility < 7)
                                    {
                                        Console.WriteLine("Le Cacodemon utilise nodus et vous aimbot across de map");
                                        Console.WriteLine("");
                                        Console.WriteLine("Appuyer sur une touche pour continuer....");
                                        Console.ReadKey();
                                        gameOver();
                                    }
                                }
                                if(cado <= 0)
                                {
                                Console.WriteLine("Après cette victoire sérrée, vous vous sentez plus fort");
                                force = force + 1;
                                totalMK = totalMK + 1;
                                }
                                else
                                {
                                    Console.WriteLine("Comme un lache, vous parvenez à vous enfuir vers la prochaine pièce...");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vous prenez votre SMG immaginaire et direz une rafale de balle invisible ! Vous recever la balle de plein fouet et subissez 50 HP de dégats !");
                        PV = PV - 50;
                        if(PV <= 0)
                        {
                            Console.WriteLine("Malheureusement, Parménide n'est pas venue vous aidez....");
                            Console.WriteLine("");
                            Console.WriteLine("Appuyer sur une touche pour continuer...");
                            Console.ReadKey();
                            gameOver();
                        }
                        else
                        {
                            //Si player pas mort
                            Console.WriteLine("");
                            Console.WriteLine("Avec cette event un peu awkward, il vous tire une autre boule d'énergie. Que faites vous ?");
                            Console.WriteLine("4. Vous prenez votre pistol et lui tirez une balle.");
                            Console.WriteLine("5. Vous decidez encore de prendre votre SMG imaginaire !");
                            Console.WriteLine("6. Vous essayer de fuir.");
                            choice = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if(choice == 4)
                            {
                                Console.WriteLine("Vous tirez une balle dans sa direction.... mais la boule vous atteind et vous êtes mort !");
                                Console.WriteLine("");
                                Console.WriteLine("Appuyer sur une touche pour continuer...");
                                Console.ReadKey();
                                gameOver();
                            }
                            else if(choice == 5)
                            {
                                Console.WriteLine("Vous prenez encore votre SMG imaginaire et l'utilisez contre le Cacodemon en lui criant : TAYEUL TÉ SENS SONT TROMPEUR !");
                                Console.WriteLine("");
                                Console.WriteLine("La bullshit de Parménide s'avère super efficace contre ce monstre, lui fesant 9001 de dégats !");
                            }
                            else
                            {
                                Console.WriteLine("Vous desidez d'esquivez son attaque...");
                                Console.WriteLine("");
                                Console.WriteLine("Appuyer pour continuez...");
                                if (agility >= 7)
                                {
                                    Console.WriteLine("Tell que Néo dans la matrix, vous esquivez sa boule de plasma et, avec un peu de chance, vous vous rendez vers la prochaine pièce sans perdre 1 HP !");
                                }
                                else
                                {
                                    Console.WriteLine("Vous ne parvenez pas à esquivez sa boule de plasma, et la prennez de plein fouet ! Avant même de le réaliser, vous êtes mort....");
                                    System.Threading.Thread.Sleep(3000);
                                    gameOver();
                                }
                            }

                        }

                    }
               }
                else if (choice == 3)
               {
                    //Dodge CHOICE 1
                    Console.WriteLine("");
                    Console.WriteLine("Vous dedidez de dodge la boule et d'essayer de vous enfuir vers la prochaine pièce...");
                    Console.WriteLine("");
                    Console.WriteLine("Appuyer sur une touche pour continuer...");
                    Console.ReadKey();
                    if(agility >= 7)
                    {
                        Console.WriteLine("Tell que Néo dans la matrix, vous esquivez sa boule de plasma et, avec un peu de chance, vous vous rendez vers la prochaine pièce sans perdre 1 HP !");
                    }
                    else
                    {
                        Console.WriteLine("Vous ne parvenez pas à esquivez sa boule de plasma, et la prennez de plein fouet ! Avant même de le réaliser, vous êtes mort....");
                        System.Threading.Thread.Sleep(3000);
                        gameOver();
                    }
                }
                Console.Clear();
                Console.WriteLine("Vous entrez dans la prochaine pièce, voyer un kit de soin et un shotgun. Vous les prenez et regagnez tout votre HP perdu!");
                shotgun = true;
                shotgunB = shotgunB + 5;
                PV = 100;
                Console.Beep(si2, fastN);
                System.Threading.Thread.Sleep(100);
                Console.Beep(si2, fastN);
                System.Threading.Thread.Sleep(100);
                Console.Beep(si2, fastN);
                Console.Beep(laD2, fastN);
                Console.Beep(mi3,halfN);
                Console.WriteLine("");
                Console.Write("Vous marchez vers la sortie, qui est baricadé avec une pancarte disant : ");
                Console.WriteLine("");
                Console.WriteLine("█▀▀▄ █▀▀█     █▀▀▄ █▀▀█ ▀▀█▀▀     █▀▀ █▀▀▄ ▀▀█▀▀ █▀▀ █▀▀█");
                Console.WriteLine("█░░█ █░░█     █░░█ █░░█ ░░█░░     █▀▀ █░░█ ░░█░░ █▀▀ █▄▄▀");
                Console.WriteLine("▀▀▀░ ▀▀▀▀     ▀░░▀ ▀▀▀▀ ░░▀░░     ▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀░▀▀");
                Console.WriteLine("");
                Console.WriteLine("Appuyer pour continuer...");
                Console.ReadKey();
                Console.Clear();

            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Vous défoncez la porte! De l'autre coté, une grande salle.... et un silence suspect...");
            Console.WriteLine("");
            Console.WriteLine("Vous marchez au centre et une grosse créature tombe à coté de vous! Un pinky...");
            Console.Beep(re2, fastN);
            Console.Beep(re2, fastN);
            Console.Beep(re3, zeeN);
            Console.Beep(la2, zeeN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(solD2, zeeN);
            Console.Beep(sol2, halfB);
            Console.Beep(fa2, halfB);
            Console.Beep(re2, fastN);
            Console.Beep(fa2, fastN);
            Console.Beep(sol2, fastN);
            Console.WriteLine("");
            Console.WriteLine("Vous vous sentez déterminé a lui pété la gueule !");
            Console.Beep(do2, fastN);
            Console.Beep(do2, fastN);
            Console.Beep(re3, zeeN);
            Console.Beep(la2, zeeN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(solD2, zeeN);
            Console.Beep(sol2, halfB);
            Console.Beep(fa2, halfB);
            Console.Beep(re2, fastN);
            Console.Beep(fa2, fastN);
            Console.Beep(sol2, fastN);
            Console.WriteLine("");
            Console.WriteLine("Dans un hurlement fâché, il vous regarde avec son regard menacant");
            Console.Beep(si1, fastN);
            Console.Beep(si1, fastN);
            Console.Beep(re3, zeeN);
            Console.Beep(la2, zeeN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(solD2, zeeN);
            Console.Beep(sol2, halfB);
            Console.Beep(fa2, halfB);
            Console.Beep(re2, fastN);
            Console.Beep(fa2, fastN);
            Console.Beep(sol2, fastN);

            Console.Beep(laD1, fastN);
            Console.Beep(laD1, fastN);
            Console.Beep(re3, zeeN);
            Console.Beep(la2, zeeN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(solD2, zeeN);
            Console.Beep(sol2, halfB);
            Console.Beep(fa2, halfB);
            Console.Beep(re2, fastN);
            Console.Beep(fa2, fastN);
            Console.Beep(sol2, fastN);

            Console.Beep(re2, fastN);
            Console.Beep(re2, fastN);
            Console.Beep(re3, zeeN);
            Console.Beep(la2, zeeN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(solD2, zeeN);
            Console.Beep(sol2, halfB);
            Console.Beep(fa2, halfB);
            Console.Beep(re2, fastN);
            Console.Beep(fa2, fastN);
            Console.Beep(sol2, fastN);
            Console.WriteLine("");
            Console.WriteLine("Il s'apprète à vous attaquez !");
            Console.Beep(do2, fastN);
            Console.Beep(do2, fastN);
            Console.Beep(re3, zeeN);
            Console.Beep(la2, zeeN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(solD2, zeeN);
            Console.Beep(sol2, halfB);
            Console.Beep(fa2, halfB);
            Console.Beep(re2, fastN);
            Console.Beep(fa2, fastN);
            Console.Beep(sol2, fastN);

            Console.Beep(si1, fastN);
            Console.Beep(si1, fastN);
            Console.Beep(re3, zeeN);
            Console.Beep(la2, zeeN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(solD2, zeeN);
            Console.Beep(sol2, halfB);
            Console.Beep(fa2, halfB);
            Console.Beep(re2, fastN);
            Console.Beep(fa2, fastN);
            Console.Beep(sol2, fastN);

            Console.Beep(laD1, fastN);
            Console.Beep(laD1, fastN);
            Console.Beep(re3, zeeN);
            Console.Beep(la2, zeeN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(solD2, zeeN);
            Console.Beep(sol2, halfB);
            Console.Beep(fa2, halfB);
            Console.Beep(re2, fastN);
            Console.Beep(fa2, fastN);
            Console.Beep(sol2, fastN);
            Console.WriteLine("");
            Console.WriteLine("Que faite-vous ??");

            Console.Beep(fa2, fastN);
            System.Threading.Thread.Sleep(200);
            Console.Beep(fa2, fastN);
            Console.Beep(fa2, fastN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(fa2, fastN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(fa2, fastN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(re2, fastN);
            Console.Beep(re2, zee2N);
            System.Threading.Thread.Sleep(100);


            Console.Beep(fa2, fastN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(fa2, fastN);
            Console.Beep(fa2, fastN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(sol2, fastN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(solD2, fastN);
            Console.Beep(sol2, fastN);
            Console.Beep(fa2, fastN);
            Console.Beep(re2, fastN);
            Console.Beep(fa2, fastN);
            Console.Beep(sol2, fastN);
            System.Threading.Thread.Sleep(200);

            Console.Beep(fa2, fastN);
            Console.Beep(fa2, fastN);
            Console.Beep(fa2, fastN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(sol2, fastN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(solD2, fastN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(la2, fastN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(do3, fastN);
            Console.Beep(la2, fastN);
            System.Threading.Thread.Sleep(100);
            Console.Beep(re3, fastN);
            Console.Beep(re3, fastN);
            Console.Beep(re3, fastN);
            Console.Beep(la2, fastN);
            Console.Beep(re3, fastN);
            Console.Beep(do3, noteN);
            Console.WriteLine("1. Prendre votre pistol et tirez une balle chargé");
            Console.WriteLine("2. Prendre votre SMG et lui tirer une rafalle de 10 balles !");
            Console.WriteLine("3. Prendre votre shotgun et lui direr une double balle");
            Console.WriteLine("4. Utilisez votre bullshit de Néo et fuire le boss fight...");
            Console.WriteLine("");
            Console.WriteLine("Note : Vous n'avez le droit qu'à une attaque ! Choose carefully.... ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(choice == 1)
            {
                //pistol
                Console.WriteLine("Telle que Megaman, vous tirez une gigantesque boule d'énergie !");
                damage = 100 * 1 * force;
                pinky = pinky - damage;
                if(pinky > 0)
                {
                    Console.WriteLine("Malgré la force de votre tire, il vous fonce dessu et vous arrache la colone vertébralle...");
                    Console.WriteLine("");
                    Console.WriteLine("Appuyez sur une touche pour continuez....");
                    Console.ReadKey();
                    gameOver();
                }
                else
                {
                    Console.WriteLine("Votre tire le désintégre !");
                    totalMK = totalMK + 1;
                }
            }
            else if(choice == 2)
            {
                //SMG
                if (smg == true)
                {
                    if (smgB < 5)
                    {
                        Console.WriteLine("Au moment que vous enfoncez la gachette, vous entendez un 'Click Click'.... Shit... Vous n'avez plus de balles !");
                        Console.WriteLine("");
                        Console.WriteLine("Le Pinky vous coupent en deux avec c'est griffe... Appuyez pour continuer...");
                        Console.ReadKey();
                        gameOver();
                    }
                    else
                    {
                        Console.WriteLine("Vous tirez une rafalle de balles vers le Pinky");
                        Console.WriteLine("");
                        damage = 10 * 10 * force;
                        pinky = pinky - damage;
                        if (pinky > 0)
                        {
                            Console.WriteLine("Votre attaquez n'étais pas assez puissante pour le tué... il vous saute dessu et vous bouffe vivant !");
                            Console.WriteLine("");
                            Console.WriteLine("Appuyez sur une touche pour continuez...");
                            Console.ReadKey();
                            gameOver();
                        }
                        else
                        {
                            Console.WriteLine("Votre attaque le tue... description vraiment lame lol");
                            totalMK = totalMK + 1;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Vous prennez votre SMG imaginaire et criez : TÉ SENS SONT TROMPEUR !!!! PARMÉNIDE OP !!!");
                    Console.WriteLine("");
                    Console.WriteLine("En fait, vos sens sont trompeur ! Vous n'avez jamais entrez dans la crypte... vous n'avez jamais même existez ! Appuis sur une touche pour continuez!");
                    Console.ReadKey();
                    gameOver();
                }
            }
            else if(choice == 3)
            {
                //shotgun
                Console.WriteLine("Vous prenez votre shotgun et tirez deux balles en même temps ! Le shotgun explose tellement que le tire est puissant !");
                Console.WriteLine("");
                damage = 2 * 40 * force;
                pinky = pinky - damage;
                if(pinky > 0)
                {
                    Console.WriteLine("Encore en vie, il vous arrache la tête avec c'est dents...");
                    Console.WriteLine("");
                    Console.WriteLine("Appuyez sur une touche pour continuez...");
                    Console.ReadKey();
                    gameOver();
                }
                else
                {
                    Console.WriteLine("Un énorme trou prend la place du Pinky... qui s'éffondre à terre, mort...");
                    totalMK = totalMK + 1;
                }
            }
            else
            {
                //dodge
                Console.WriteLine("Vous faite le vide dans votre tête... et commencer à courrir comme vous n'avez jamais courru auparavant !");
                Console.WriteLine("");
                if (agility >= 10)
                {
                    Console.WriteLine("Vous commencez à courrir sur les murs et faite un backflip, esquivant l'attaque du Pinky.");
                    Console.WriteLine("");
                    Console.WriteLine("Vous jumpez sur la tête du Pinky telle que Mario et vous vous enfuyez de cette salle...");
                }
                else
                {
                    Console.WriteLine("Malheureusement, vous tribuchez sur un crâne humain... Le Pinky vous sautant dessu comme un chien sauvage!");
                    Console.WriteLine("");
                    Console.WriteLine("Appuyez sur une touche pour continuer....");
                    Console.ReadKey();
                    gameOver();
                }
            }
            Console.WriteLine("Appuyez sur une touche pour continuer....");
            Console.ReadKey();
            Console.Clear();
            //ending
            if (totalMK == 0)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep(do3, halfB);
                Console.Beep(do3, halfB);
                Console.Beep(do3, halfB);
                Console.Beep(do3, blackN);
                Console.Beep(solD2, blackN);
                Console.Beep(laD2, blackN);
                Console.Beep(do3, blackN);
                Console.Beep(laD2, halfB);
                Console.Beep(do3, halfN);
                
                Console.WriteLine("");
                Console.WriteLine("██╗   ██╗██╗ ██████╗████████╗ ██████╗ ██████╗ ██╗   ██╗    ██╗");
                Console.WriteLine("██║   ██║██║██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗╚██╗ ██╔╝    ██║");
                Console.WriteLine("██║   ██║██║██║        ██║   ██║   ██║██████╔╝ ╚████╔╝     ██║");
                Console.WriteLine("╚██╗ ██╔╝██║██║        ██║   ██║   ██║██╔══██╗  ╚██╔╝      ╚═╝");
                Console.WriteLine(" ╚████╔╝ ██║╚██████╗   ██║   ╚██████╔╝██║  ██║   ██║       ██╗");
                Console.WriteLine("  ╚═══╝  ╚═╝ ╚═════╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚═╝");
                Console.WriteLine("");
                Console.Beep(faD2, halfB);
                Console.Beep(faD2, halfB);
                Console.Beep(re2, halfB);
                Console.Beep(si1, blackN);
                Console.Beep(si1, blackN);
                Console.Beep(mi2, blackN);
                Console.Beep(mi2, blackN);
                Console.Beep(mi2, halfB);
                Console.Beep(solD2, halfB);
                Console.Beep(solD2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(si2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(mi2, blackN);
                Console.Beep(re2, blackN);
                Console.Beep(faD2, blackN);
                Console.Beep(faD2, blackN);
                Console.Beep(faD2, halfB);
                Console.Beep(mi2, halfB);
                Console.Beep(mi2, halfB);
                Console.Beep(faD2, halfB);
                Console.Beep(mi2, halfB);
                Console.Beep(faD2, halfB);
                Console.Beep(faD2, halfB);
                Console.Beep(re2, halfB);
                Console.Beep(si1, blackN);
                Console.Beep(si1, blackN);
                Console.Beep(mi2, blackN);
                Console.Beep(mi2, blackN);
                Console.Beep(mi2, halfB);
                Console.Beep(solD2, halfB);
                Console.Beep(solD2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(si2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(mi2, blackN);
                Console.Beep(re2, blackN);
                Console.Beep(faD2, blackN);
                Console.Beep(faD2, blackN);
                Console.Beep(faD2, halfB);
                Console.Beep(mi2, halfB);
                Console.Beep(mi2, halfB);
                Console.Beep(faD2, halfB);
                Console.Beep(mi2, halfB);
                Console.WriteLine("Vous avez réussi avec l'AGILITÉ. (Il y a 3 fin possible)");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Appuyer une touche pour fermer le jeu...");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Beep(do3, halfB);
                Console.Beep(do3, halfB);
                Console.Beep(do3, halfB);
                Console.Beep(do3, blackN);
                Console.Beep(solD2, blackN);
                Console.Beep(laD2, blackN);
                Console.Beep(do3, blackN);
                Console.Beep(laD2, halfB);
                Console.Beep(do3, halfN);

                Console.WriteLine("");
                Console.WriteLine("██╗   ██╗██╗ ██████╗████████╗ ██████╗ ██████╗ ██╗   ██╗    ██╗");
                Console.WriteLine("██║   ██║██║██╔════╝╚══██╔══╝██╔═══██╗██╔══██╗╚██╗ ██╔╝    ██║");
                Console.WriteLine("██║   ██║██║██║        ██║   ██║   ██║██████╔╝ ╚████╔╝     ██║");
                Console.WriteLine("╚██╗ ██╔╝██║██║        ██║   ██║   ██║██╔══██╗  ╚██╔╝      ╚═╝");
                Console.WriteLine(" ╚████╔╝ ██║╚██████╗   ██║   ╚██████╔╝██║  ██║   ██║       ██╗");
                Console.WriteLine("  ╚═══╝  ╚═╝ ╚═════╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝   ╚═╝       ╚═╝");
                Console.WriteLine("");
                Console.Beep(faD2, halfB);
                Console.Beep(faD2, halfB);
                Console.Beep(re2, halfB);
                Console.Beep(si1, blackN);
                Console.Beep(si1, blackN);
                Console.Beep(mi2, blackN);
                Console.Beep(mi2, blackN);
                Console.Beep(mi2, halfB);
                Console.Beep(solD2, halfB);
                Console.Beep(solD2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(si2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(mi2, blackN);
                Console.Beep(re2, blackN);
                Console.Beep(faD2, blackN);
                Console.Beep(faD2, blackN);
                Console.Beep(faD2, halfB);
                Console.Beep(mi2, halfB);
                Console.Beep(mi2, halfB);
                Console.Beep(faD2, halfB);
                Console.Beep(mi2, halfB);
                Console.Beep(faD2, halfB);
                Console.Beep(faD2, halfB);
                Console.Beep(re2, halfB);
                Console.Beep(si1, blackN);
                Console.Beep(si1, blackN);
                Console.Beep(mi2, blackN);
                Console.Beep(mi2, blackN);
                Console.Beep(mi2, halfB);
                Console.Beep(solD2, halfB);
                Console.Beep(solD2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(si2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(la2, halfB);
                Console.Beep(mi2, blackN);
                Console.Beep(re2, blackN);
                Console.Beep(faD2, blackN);
                Console.Beep(faD2, blackN);
                Console.Beep(faD2, halfB);
                Console.Beep(mi2, halfB);
                Console.Beep(mi2, halfB);
                Console.Beep(faD2, halfB);
                Console.Beep(mi2, halfB);
                Console.WriteLine("Vous avez réussi avec la PUISSANCE. (Il y a 3 fin possible)");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Appuyer une touche pour fermer le jeu...");
                Console.ReadKey();
                System.Environment.Exit(1);
            }
            
        }
        static void gameOver()
        {            
            int re2 = 293;           
            int mi2 = 330;         
            int sol2 = 392;
            int solD2 = 415;
            int la2 = 440;
            int laD2 = 466;
            int si2 = 494;
            int do3 = 523;            
            //Longetude            
            int halfN = 1000;            
            int blackN = 500;            
            int halfB = 250;
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("█░░█ █▀▀█ █░░█   █▀▀█ █▀▀█ █▀▀   █▀▀▄ █▀▀ █▀▀█ █▀▀▄");
            Console.WriteLine("█▄▄█ █░░█ █░░█   █▄▄█ █▄▄▀ █▀▀   █░░█ █▀▀ █▄▄█ █░░█");
            Console.WriteLine("▄▄▄█ ▀▀▀▀ ░▀▀▀   ▀░░▀ ▀░▀▀ ▀▀▀   ▀▀▀░ ▀▀▀ ▀░░▀ ▀▀▀░");
            Console.WriteLine("");
            Console.WriteLine("Tips : Git Gud");
            Console.Beep(do3, blackN);
            Console.Beep(sol2, blackN);
            Console.Beep(mi2, blackN);
            Console.Beep(la2, blackN);
            Console.Beep(si2, blackN);
            Console.Beep(la2, blackN);
            Console.Beep(solD2, blackN);
            Console.Beep(laD2, blackN);
            Console.Beep(solD2, blackN);
            Console.Beep(mi2, halfB);
            Console.Beep(re2, halfB);
            Console.Beep(mi2, halfN);
            System.Environment.Exit(1);
        }      
    }
}