using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Lab4Demons
{
    class Program
    {
        public struct Demon
        {
            public string Name { get; set; }
            public int Class { get; set; }
            public int Life { get; set; }
            public int Attack { get; set; }
            public int Vit { get; set; }
            public bool alive { get; set; }

            public Demon(string _Name, int _Class, int _life, int _dam, int _vit, bool _alive) : this()
            {
                Name = _Name;
                Class = _Class;
                Life = _life;
                Attack = _dam;
                Vit = _vit;
                alive = _alive;
            }

        }

        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer();
            Random random = new Random();

            //Variable------------------------------------------------------------------------------------------------------------------------------------------------------------------
            int choiceDJ = 0;
            int choiceDB = 0;
            int choice = 0;
            int nbturn = 0;
            int life = 0;
            int totalBKill = 0;
            int totalPkill = 0;
            int healed = 0;
            bool validturn = false;
            bool END = false;
            bool endofthegame = false;

            //Bot------------------------------------------------------------------------------------------------------------------------------------------------------------------
            int botStrat = 0;
            botStrat = random.Next(1,6);
            int Bchoice = 0;

            

            //Demons--------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Demon[] tabDemon = new Demon[15];
            Demon[] tabDemonBot = new Demon[3];
            Demon[] tabDemonJ1 = new Demon[3];
            Demon[] tabDemonChoice = new Demon[3];
            Demon[] tabBattle = new Demon[2];
            bool[] tabDemonTake = new bool[15];
            int[] totalLifeP = new int[3];
            int[] totalLifeB = new int[3];

            for (int i = 0; i < 14; i++)
            {
                tabDemonTake[i] = false;
            }


            //Tank
            tabDemon[0] = new Demon("Cacodemon", 0, 350, 150, 150, true);
            tabDemon[1] = new Demon("Pinky", 0, 400, 100, 111, true);
            tabDemon[2] = new Demon("Baron of Hell", 0, 350, 200, 50, true);
            tabDemon[3] = new Demon("Mancubus", 0, 400, 210, 1, true);
            tabDemon[4] = new Demon("Spectre", 0, 300, 200, 100, true);
            
            //DPS
            tabDemon[5] = new Demon("Arch-Ville", 1, 200, 300, 108, true);
            tabDemon[6] = new Demon("Hell Knight", 1, 200, 200, 203, true);
            tabDemon[7] = new Demon("Lost soul", 3, 1, 9999, 9999, true);
            tabDemon[8] = new Demon("Prowler", 1, 150, 250, 250, true);
            tabDemon[9] = new Demon("Possessed Soldier", 1, 50, 101, 52, true);
            tabDemon[10] = new Demon("Cherub", 1, 50, 200, 300, true);
            //Support
            tabDemon[11] = new Demon("Possessed scientist", 2, 50, 50, 50, true);
            tabDemon[12] = new Demon("Summoner", 2, 70, 100, 100, true);
            tabDemon[13] = new Demon("Harvester", 2, 50, 50, 105, true);
            tabDemon[14] = new Demon("Kronos", 2, 100, 50, 51, true);
                       
            //VOID-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            void battleScreen()
            {
                battle();
                //DUEL
                Console.SetCursorPosition(57, 2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("WAR");
                Console.ForegroundColor = ConsoleColor.White;


                //Player Demon P1
                Console.SetCursorPosition(1, 1);
                if (tabDemonJ1[0].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine(tabDemonJ1[0].Name);
                Console.SetCursorPosition(1, 2);
                if (tabDemonJ1[1].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine(tabDemonJ1[1].Name);
                Console.SetCursorPosition(1, 3);
                if (tabDemonJ1[2].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine(tabDemonJ1[2].Name);
                Console.ForegroundColor = ConsoleColor.White;


                Console.SetCursorPosition(21, 1);
                Console.WriteLine(tabDemonJ1[0].Life + "/" + totalLifeP[0]);
                Console.SetCursorPosition(21, 2);
                Console.WriteLine(tabDemonJ1[1].Life + "/" + totalLifeP[1]);
                Console.SetCursorPosition(21, 3);
                Console.WriteLine(tabDemonJ1[2].Life + "/" + totalLifeP[2]);


                //Bot Demon P1

                
                Console.SetCursorPosition(90, 1);
                if (tabDemonBot[0].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine(tabDemonBot[0].Name);
                Console.SetCursorPosition(90, 2);
                if (tabDemonBot[1].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine(tabDemonBot[1].Name);
                Console.SetCursorPosition(90, 3);
                if (tabDemonBot[2].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine(tabDemonBot[2].Name);
                Console.ForegroundColor = ConsoleColor.White;


                Console.SetCursorPosition(111, 1);
                Console.WriteLine(tabDemonBot[0].Life + "/" + totalLifeB[0]);
                Console.SetCursorPosition(111, 2);
                Console.WriteLine(tabDemonBot[1].Life + "/" + totalLifeB[1]);
                Console.SetCursorPosition(111, 3);
                Console.WriteLine(tabDemonBot[2].Life + "/" + totalLifeB[2]);

                //Player Demon P2
                
                Console.SetCursorPosition(16, 9);
                if(tabDemonJ1[0].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("1." + tabDemonJ1[0].Name);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("1." + tabDemonJ1[0].Name);
                }
                
                Console.SetCursorPosition(33, 14);
                if (tabDemonJ1[1].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("2." + tabDemonJ1[1].Name);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("2." + tabDemonJ1[1].Name);

                }
                Console.SetCursorPosition(16, 19);
                if (tabDemonJ1[2].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("3." + tabDemonJ1[2].Name);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("3." + tabDemonJ1[2].Name);
                }
                Console.ForegroundColor = ConsoleColor.White;
                //Bot Demon P2
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(90, 9);
                if (tabDemonBot[0].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(tabDemonBot[0].Name);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(tabDemonBot[0].Name);
                }
                Console.SetCursorPosition(73, 14);
                if (tabDemonBot[1].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(tabDemonBot[1].Name);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(tabDemonBot[1].Name);
                }

                Console.SetCursorPosition(90, 19);
                if (tabDemonBot[2].alive == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(tabDemonBot[2].Name);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(tabDemonBot[2].Name);
                }
                Console.ForegroundColor = ConsoleColor.White;

                
                             
                

                
                
            }
            void Playerround()
            {
                //Player round
                Console.SetCursorPosition(1, 25);
                Console.WriteLine("Veuillez selectionner un démon...");
                Console.SetCursorPosition(0, 29);
                choiceDJ = Convert.ToInt32(Console.ReadLine());
                choiceDJ = choiceDJ - 1;
                tabBattle[0] = tabDemonJ1[choiceDJ];
                Console.Clear();
                battleScreen();
                Console.SetCursorPosition(1, 25);
                Console.WriteLine("Que voulez vous faire ?");
                Console.SetCursorPosition(1, 26);
                Console.WriteLine("1. Attaquer");
                if (tabDemonJ1[choiceDJ].Class == 2)
                {
                    Console.SetCursorPosition(1, 27);
                    Console.WriteLine("2. Soigner un démon");

                }
                Console.SetCursorPosition(0, 29);
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    Console.Clear();
                    battleScreen();
                    
                    Console.SetCursorPosition(1, 25);
                    Console.WriteLine("Vous avez choisis " + tabDemonJ1[choiceDJ].Name + " pour attaquer l'ennemi...");
                    Console.SetCursorPosition(1, 27);
                    Console.WriteLine("Appuper pour continuer....");
                    Console.ReadKey();
                }

                //Healing +++++++++
                if(tabDemonJ1[choiceDJ].Class == 2 && choice == 2)
                {
                    validturn = true;
                    life = random.Next(50, 101);
                    Console.Clear();
                    battleScreen();
                    Console.SetCursorPosition(1, 25);
                    Console.WriteLine("Quelle démon voulez vous soigner ?");
                    Console.SetCursorPosition(0, 29);
                    choice = Convert.ToInt32(Console.ReadLine());
                    choice = choice - 1;
                    healed = tabDemonJ1[choice].Life;
                   
                        if (tabDemonJ1[choice].alive == false)
                        {
                            Console.SetCursorPosition(1, 25);
                            Console.WriteLine("Vous avez soigner un cadavre de 0 HP ! GG boy");
                        }
                        else
                        {

                            tabDemonJ1[choice].Life = tabDemonJ1[choice].Life + life;
                            if (tabDemonJ1[choice].Life > totalLifeP[choice])
                            {
                                tabDemonJ1[0].Life = totalLifeP[choice];
                            }
                        healed = tabDemonJ1[choice].Life - healed;
                        Console.SetCursorPosition(1, 25);
                        Console.WriteLine("Vous avez soigner " + tabDemonJ1[choice].Name + " pour un total de " + healed + " HP!");
                    }
                 
                    Console.Clear();
                    battleScreen();
                    
                    Console.SetCursorPosition(0, 29);
                    Console.ReadKey();

                }
            }            
            void Botround()
            {
                Console.Clear();
                battleScreen();
                validturn = false;
                while (validturn == false)
                {
                    choiceDB = random.Next(1, 4);
                    choiceDB = choiceDB - 1;
                    if(tabDemonBot[choiceDB].alive == true)
                    {
                        validturn = true;
                    }
                }
                               
                tabBattle[1] = tabDemonBot[choiceDB];
                validturn = false;
                while (validturn == false)
                {
                    choice = random.Next(1, 3);

                    if(choice == 2 && tabDemonBot[choiceDB].Class == 2)
                    {
                        healed = tabDemonBot[choice].Life;
                        life = random.Next(50, 101);
                        validturn = true;
                        choice = random.Next(1, 4);
                        choice = choice - 1;

                        if (tabDemonBot[choice].alive == false)
                        {
                            Console.SetCursorPosition(1, 25);
                            Console.WriteLine("L'ennemie a soigner un cadavre de 0 HP ! Retard bot lmaooo");
                        }
                        else
                        {
                            tabDemonBot[choice].Life = tabDemonBot[choice].Life + life;
                            if (tabDemonBot[choice].Life > totalLifeB[choice])
                            {
                                tabDemonBot[0].Life = totalLifeB[choice];
                            }
                            healed = tabDemonBot[choice].Life - healed;
                            Console.SetCursorPosition(1, 25);
                            Console.WriteLine("L'ennemi a soigner son " + tabDemonBot[choice].Name + " pour un total de " + healed + " HP!");
                        }
                        


                        


                    }
                    else if(choice == 1)
                    {
                        Console.Clear();
                        battleScreen();
                        Console.SetCursorPosition(1, 25);
                        Console.WriteLine("L'ennemi a choisis un " + tabDemonBot[choiceDB].Name + " pour vous attaquez...");
                        
                        validturn = true;
                    }


                }

                Console.SetCursorPosition(1, 27);
                Console.WriteLine("Appuper pour continuer....");
                Console.ReadKey();
            }
            void resetEverything()
            {
                validturn = false;
                Console.Clear();
                battleScreen();
            }
            void truebattle()
            {
                //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
                if (tabBattle[0].Class == 3 || tabBattle[1].Class == 3)
                {
                    if (tabBattle[0].Class == 3 && tabBattle[0].alive == false)
                    {
                        Console.SetCursorPosition(1, 25);
                        Console.WriteLine("Vous ordenez a votre " + tabBattle[0].Name + " d'utiliser suicide... It's not very effective !");
                        Console.SetCursorPosition(1, 26);
                        Console.WriteLine("Juste pour vous faire chier d'essayer d'abuser mon jeu, je donne une + 1 kill au bot !");
                        totalBKill++;
                    }
                    else if (tabBattle[1].Class == 3 && tabBattle[1].alive == true)
                    {
                        Console.SetCursorPosition(1, 25);
                        Console.WriteLine("Le " + tabBattle[1].Name + " ennemi utilise suicide... " + tabBattle[0].Name + " se prend " + tabBattle[1].Attack + "de dégats !");
                        tabDemonJ1[choiceDJ].Life = 0;
                        tabDemonBot[choiceDB].Life = 0;
                        tabDemonJ1[choiceDJ].alive = false;
                        tabDemonBot[choiceDB].alive = false;
                        totalBKill++;
                        totalPkill++;
                        Console.SetCursorPosition(1, 27);
                        Console.WriteLine("Appuyer sur une touche pour continuer....");
                        Console.SetCursorPosition(0, 29);
                    }
                    else if (tabBattle[0].Class == 3 || tabBattle[1].Class == 3)
                    {
                        Console.SetCursorPosition(1, 25);
                        Console.WriteLine("Votre " + tabBattle[0].Name + " utilise suicide... " + tabBattle[1].Name + " se prend " + tabBattle[0].Attack + " de dégats !");
                        tabDemonJ1[choiceDJ].Life = 0;
                        tabDemonBot[choiceDB].Life = 0;
                        tabDemonJ1[choiceDJ].alive = false;
                        tabDemonBot[choiceDB].alive = false;
                        totalBKill++;
                        totalPkill++;
                        Console.SetCursorPosition(1, 27);
                        Console.WriteLine("Appuyer sur une touche pour continuer....");
                        Console.SetCursorPosition(0, 29);
                        
                    }
                    else if (tabBattle[1].Class == 3 && tabBattle[1].alive == false)
                    {

                    }
                    Console.ReadKey();


                }
                else
                {
                    //normal battle
                    if(tabDemonJ1[choiceDJ].alive == false)
                    {
                        Console.SetCursorPosition(1, 25);
                        Console.WriteLine("Vous ordenez a votre " + tabBattle[0].Name + " d'attaquer... It's not very effective !");
                        Console.SetCursorPosition(1, 26);
                        Console.WriteLine("Juste pour vous faire chier d'essayer d'abuser mon jeu, je donne une + 1 kill au bot !");
                        totalBKill++;

                        Console.ReadKey();
                    }
                    else if(tabBattle[0].Vit > tabBattle[1].Vit)
                    {
                        tabDemonBot[choiceDB].Life = tabDemonBot[choiceDB].Life - tabBattle[0].Attack;
                        if(tabDemonBot[choiceDB].Life <= 0)
                        {
                            totalPkill++;
                            tabDemonBot[choiceDB].alive = false;
                            tabDemonBot[choiceDB].Life = 0;
                        }
                        else
                        {
                            tabDemonJ1[choiceDJ].Life = tabDemonJ1[choiceDJ].Life - tabBattle[1].Attack;
                            if(tabDemonJ1[choiceDJ].Life <= 0)
                            {
                                totalBKill++;
                                tabDemonJ1[choiceDJ].Life = 0;
                                tabDemonJ1[choiceDJ].alive = false;
                            }
                        }
                    }
                    else
                    {
                        tabDemonJ1[choiceDJ].Life = tabDemonJ1[choiceDJ].Life - tabBattle[1].Attack;
                        if (tabDemonJ1[choiceDJ].Life <= 0)
                        {
                            totalBKill++;
                            tabDemonJ1[choiceDJ].Life = 0;
                            tabDemonJ1[choiceDJ].alive = false;
                        }
                        else
                        {
                            tabDemonBot[choiceDB].Life = tabDemonBot[choiceDB].Life - tabBattle[0].Attack;
                            if (tabDemonBot[choiceDB].Life <= 0)
                            {
                                totalPkill++;
                                tabDemonBot[choiceDB].alive = false;
                                tabDemonBot[choiceDB].Life = 0;
                            }
                        }
                    }
                }
            }
            void BotChoice()
            {
                while (validturn == false)
                {
                    //Bot strat 1 ----------------------------------------
                    if (botStrat == 1)
                    {
                        if (nbturn == 0)
                        {
                            Bchoice = random.Next(0, 5);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];

                            }

                        }
                        else if (nbturn == 1)
                        {
                            Bchoice = random.Next(5, 11);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];

                            }
                        }
                        else if (nbturn == 2)
                        {
                            Bchoice = random.Next(11, 15);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];
                                END = true;
                            }
                        }
                    }
                    //Bot strat 2 ----------------------------------------
                    else if (botStrat == 2)
                    {
                        if (nbturn == 0)
                        {
                            Bchoice = random.Next(0, 5);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];

                            }

                        }
                        else if (nbturn == 1)
                        {
                            Bchoice = random.Next(0, 5);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];
                                
                            }
                        }
                        else if (nbturn == 2)
                        {
                            Bchoice = random.Next(11, 15);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];
                                END = true;
                            }
                        }
                    }
                    //Bot strat 3 ----------------------------------------
                    else if (botStrat == 3)
                    {
                        if (nbturn == 0)
                        {
                            Bchoice = random.Next(5, 11);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];

                            }

                        }
                        else if (nbturn == 1)
                        {
                            Bchoice = random.Next(5, 11);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];

                            }
                        }
                        else if (nbturn == 2)
                        {
                            Bchoice = random.Next(5, 11);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];
                                END = true;
                            }
                        }
                    }
                    //Bot strat 4 ----------------------------------------
                    else if (botStrat == 4)
                    {
                        if (nbturn == 0)
                        {
                            Bchoice = random.Next(5, 11);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];

                            }

                        }
                        else if (nbturn == 1)
                        {
                            Bchoice = random.Next(5, 11);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];

                            }
                        }
                        else if (nbturn == 2)
                        {
                            Bchoice = random.Next(11, 15);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];
                                END = true;
                            }
                        }
                    }
                    //Bot strat 5 ----------------------------------------
                    else if (botStrat == 5)
                    {
                        if (nbturn == 0)
                        {
                            Bchoice = random.Next(0, 5);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];

                            }

                        }
                        else if (nbturn == 1)
                        {
                            Bchoice = random.Next(0, 5);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];

                            }
                        }
                        else if (nbturn == 2)
                        {
                            Bchoice = random.Next(11, 15);
                            if (tabDemonTake[Bchoice] == false)
                            {
                                validturn = true;
                                tabDemonTake[Bchoice] = true;
                                tabDemonBot[nbturn] = tabDemon[Bchoice];
                                END = true;
                            }
                        }
                    }
                }
               
            }

            try
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Menu.wav";
                player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            while (END == false)
            {
                Console.WriteLine("=======================================================================================================================");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                               Character Selection");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("     TANK");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkGray;


                if(tabDemonTake[0] == true)
                {                   
                    Console.WriteLine("");                    
                }
                else
                {
                    Console.WriteLine("1. Cacodemon");
                }
                if (tabDemonTake[1] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("2. Pinky");
                }
                if(tabDemonTake[2] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("3. Baron of Hell");
                }
                if (tabDemonTake[3] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("4. Mancubus");
                }
                if (tabDemonTake[4] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("5. Spectre");
                }

                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("     DPS");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                if (tabDemonTake[5] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("6. Arch-Ville");
                }
                if (tabDemonTake[6] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("7. Hell Knight");
                }
                if (tabDemonTake[7] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("8. Lost Soul");
                }
                if (tabDemonTake[8] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("9. Prowler");
                }
                if (tabDemonTake[9] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("10. Possessed Soldier");
                }
                if (tabDemonTake[10] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("11. Cherub");
                }



                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("   Support");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                if (tabDemonTake[11] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("12. Possessed Scientist");
                }
                if (tabDemonTake[12] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("13. Summoner");
                }
                if (tabDemonTake[13] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("14. Harvester");
                }
                if (tabDemonTake[14] == true)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("15. Kronos");
                }


                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");

               

                Console.WriteLine("=======================================================================================================================");

                while (validturn == false)
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    choice = choice - 1;
                    Console.SetCursorPosition(45, 6);
                   
                    if (choice > 15)
                    {
                        choice = 14;
                    }

                    if (tabDemonTake[choice] == false)
                    {
                        validturn = true;
                        tabDemonTake[choice] = true;
                        tabDemonJ1[nbturn] = tabDemon[choice];
                        Console.WriteLine("Vous avez choisis un " + tabDemon[choice].Name + "!");

                    }                   
                    else
                    {
                        Console.WriteLine("Démon non disponible...");
                        Console.SetCursorPosition(45, 8);
                        Console.WriteLine("Try Again !");
                    }
                                         
                    
                    Console.SetCursorPosition(0, 28);
                }

                validturn = false;                
                BotChoice();
                validturn = false;
                nbturn++;
                Console.SetCursorPosition(45, 8);
                Console.WriteLine("Appuyer sur une touche pour continuer !");
                Console.SetCursorPosition(0, 29);
                Console.ReadKey();
                Console.Clear();



            }
            void victoryChecker()
            {
                if(totalBKill == 3)
                {
                    endofthegame = true;
                }
                else if(totalPkill == 3)
                {
                    endofthegame = true;
                }
            }
            //Battle start here-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            //Music--------------------------------------------------------------------------
            choice = random.Next(1, 5);
            if(choice == 1)
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Temple.wav";
                player.Play();
            }
            else if(choice == 2)
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Mila.wav";
                player.Play();
            }
            else if(choice == 4)
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Battlefield.wav";
                player.Play();
            }
            else
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Brawl.wav";
                player.Play();
            }

            totalLifeP[0] = tabDemonJ1[0].Life;
            totalLifeP[1] = tabDemonJ1[1].Life;
            totalLifeP[2] = tabDemonJ1[2].Life;

            totalLifeB[0] = tabDemonBot[0].Life;
            totalLifeB[1] = tabDemonBot[1].Life;
            totalLifeB[2] = tabDemonBot[2].Life;


            while(endofthegame == false)
            {
                Console.Clear();
                battleScreen();
                Playerround();
                resetEverything();
                Botround();
                resetEverything();
                truebattle();
                victoryChecker();
            }
            
            if(totalPkill == 3)
            {
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "Dog.wav";
                player.Play();
                doge();
                Console.ReadKey();
            }
            else if(totalBKill == 3)
            {
                Console.Clear();
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "GameOver.wav";
                player.Play();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("");
                Console.WriteLine("..######......###....##.....##.########.....#######..##.....##.########.########.");
                Console.WriteLine(".##....##....##.##...###...###.##..........##.....##.##.....##.##.......##.....##");
                Console.WriteLine(".##.........##...##..####.####.##..........##.....##.##.....##.##.......##.....##");
                Console.WriteLine(".##...####.##.....##.##.###.##.######......##.....##.##.....##.######...########.");
                Console.WriteLine(".##....##..#########.##.....##.##..........##.....##..##...##..##.......##...##..");
                Console.WriteLine(".##....##..##.....##.##.....##.##..........##.....##...##.##...##.......##....##.");
                Console.WriteLine("..######...##.....##.##.....##.########.....#######.....###....########.##.....##");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                          Despacito(2017) - Luis Fonsi ");
                System.Threading.Thread.Sleep(273000);
            }


        }
        static void battle()
        {
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("                                                          |");
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("|                                                                                                                     |");
            Console.WriteLine("=======================================================================================================================");
        }
        static void doge()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

              Console.WriteLine("               ▄              ▄");
              Console.WriteLine("               ▌▒█           ▄▀▒▌");
              Console.WriteLine(" WOW           ▌▒▒█        ▄▀▒▒▒▐");
              Console.WriteLine("              ▐▄▀▒▒▀▀▀▀▄▄▄▀▒▒▒▒▒▐");
              Console.WriteLine("            ▄▄▀▒░▒▒▒▒▒▒▒▒▒█▒▒▄█▒▐");
              Console.WriteLine("          ▄▀▒▒▒░░░▒▒▒░░░▒▒▒▀██▀▒▌");
              Console.WriteLine("         ▐▒▒▒▄▄▒▒▒▒░░░▒▒▒▒▒▒▒▀▄▒▒▌");
              Console.WriteLine("         ▌░░▌█▀▒▒▒▒▒▄▀█▄▒▒▒▒▒▒▒█▒▐");
              Console.WriteLine("        ▐░░░▒▒▒▒▒▒▒▒▌██▀▒▒░░░▒▒▒▀▄▌");
              Console.WriteLine("        ▌░▒▄██▄▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▌");
              Console.WriteLine("       ▀▒▀▐▄█▄█▌▄░▀▒▒░░░░░░░░░░▒▒▒▐");
              Console.WriteLine("       ▐▒▒▐▀▐▀▒░▄▄▒▄▒▒▒▒▒▒░▒░▒░▒▒▒▒▌");
              Console.WriteLine("       ▐▒▒▒▀▀▄▄▒▒▒▄▒▒▒▒▒▒▒▒░▒░▒░▒▒▐");
              Console.WriteLine("        ▌▒▒▒▒▒▒▀▀▀▒▒▒▒▒▒░▒░▒░▒░▒▒▒▌");
              Console.WriteLine("        ▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▒▄▒▒▐");
              Console.WriteLine("         ▀▄▒▒▒▒▒▒▒▒▒▒▒░▒░▒░▒▄▒▒▒▒▌");
              Console.WriteLine("           ▀▄▒▒▒▒▒▒▒▒▒▒▄▄▄▀▒▒▒▒▄▀");
              Console.WriteLine("             ▀▄▄▄▄▄▄▀▀▀▒▒▒▒▒▄▄▀");
              Console.WriteLine("                ▒▒▒▒▒▒▒▒▒▒▀▀");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(37, 2);
            Console.WriteLine("Much Victory Screen");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(44, 8);
            Console.WriteLine("Very Ascii");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(7, 20);
            Console.WriteLine("How to Victory Screen?");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(7, 15);
            Console.WriteLine("such effort");
        }
    }
}
