using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Spellendoos.Classes
{
    class MensErgerJeNiet : BoardGame
    {
        private int numberOfFields;
        private int[] playerPosition1 = new int[4];
        private int[] playerPosition2 = new int[4];
        private int[] playerPosition3 = new int[4];
        private int[] playerPosition4 = new int[4];
        private int i, j;

        public MensErgerJeNiet(string name, List<Player> players)
        {
            this.name = name;
            this.dices = new DiceTray(1, 6);
            this.players = players;

            this.active = true;
            //this.numberOfFields = 44;
            this.Grid = new LinkedList<int>();
        }

        public override void EndGame()
        {
            //Close the game.
            active = false;
        }

        public override string GetGameName()
        {
            return this.name;
        }

        public override LinkedList<int> GetGrid()
        {
            throw new NotImplementedException();
        }

        public override bool IsActive()
        {
            //This method is simply to check whether or not the game is currently active for testing purposes.
            if (active == true)
            {
                Console.WriteLine("Mens erger je niet is actief!");
                return true;
            }
            else
            {
                Console.WriteLine("Mens erger je niet is niet actief.");
                return false;
            }
        }

        public void playGame()
        {
            
            bool onGoing = true;
            //voor als positie is toegevoegd als alle pionen op een positie tussen de 41 en 44 staan dan heeft de speler gewonnen
            for (i = 0; i <= 6; i++)
            {
                int numberOfPlayer = 1;
                foreach (Player currentPlayer in players)
                {
                    int[] results = dices.RollDices();
                    foreach (int result in results)
                    {
                        Console.WriteLine("Dobbelstenen zijn gegooid en de waarde is: " + result);
                        int[] newResults = dices.RollDices();
                        //speler 1
                        if (numberOfPlayer == 1)
                        {
                            
                                if (playerPosition1[0] == 0)
                                {
                                    if (result == 6)
                                    {
                                        Console.WriteLine("Er komt een nieuwe pion in het spel voor speler " + numberOfPlayer);
                                        playerPosition1[0] = +newResults[0];
                                        Console.WriteLine("Dobbelstenen zijn gegooid en de pion mag " + newResults[0] + " stappen vooruit. Deze pion staat nu op vakje " + playerPosition1[0]);
                                        j = 4;
                                    }
                                    else
                                    {
                                        j = 4;
                                    }
                                }
                                else if (playerPosition2[0] > 41)
                                {
                                    Console.WriteLine("deze pion is al binnen");
                                }
                                else
                                {
                                    Console.WriteLine("Er komt een nieuwe pion in het spel voor speler " + numberOfPlayer);
                                    playerPosition1[0] = playerPosition2[0] + newResults[0];
                                    Console.WriteLine("Dobbelstenen zijn gegooid en de pion mag " + newResults[0] + " stappen vooruit. Deze pion staat nu op vakje " + playerPosition1[0]);
                                    
                            }
                        }
                        //speler 2
                        else if (numberOfPlayer == 2)
                        {
                            {
                                if (playerPosition2[0] == 0)
                                {
                                    if (result == 6)
                                    {
                                        Console.WriteLine("Er komt een nieuwe pion in het spel voor speler 2");
                                        playerPosition2[0] = playerPosition2[0] + newResults[0];
                                        Console.WriteLine("Dobbelstenen zijn gegooid en de pion mag " + newResults[0] + " stappen vooruit. Deze pion staat nu op vakje " + playerPosition2[0]);
                                    }
                                }
                                else if (playerPosition2[0] > 41)
                                {
                                    Console.WriteLine("deze pion is al binnen");
                                }
                                else
                                {
                                    Console.WriteLine("Er komt een nieuwe pion in het spel voor speler 2" + numberOfPlayer);
                                    playerPosition2[0] = playerPosition2[0] + newResults[0];
                                    Console.WriteLine("Dobbelstenen zijn gegooid en de pion mag " + newResults[0] + " stappen vooruit. Deze pion staat nu op vakje " + playerPosition2[0]);
                                }
                            }
                        }
                        //speler 3
                        else if (numberOfPlayer == 3)
                        {
                                if (playerPosition3[0] == 0)
                                {
                                    if (result == 6)
                                    {
                                        Console.WriteLine("Er komt een nieuwe pion in het spel voor speler " + numberOfPlayer);
                                        playerPosition3[0] = playerPosition3[0] + newResults[0];
                                        Console.WriteLine("Dobbelstenen zijn gegooid en de pion mag " + newResults[0] + " stappen vooruit. Deze pion staat nu op vakje " + playerPosition3[0]);
                                        
                                    }
                                }
                                else if (playerPosition3[0] > 41)
                                {
                                    Console.WriteLine("deze pion is al binnen");
                                }
                                else
                                {
                                    Console.WriteLine("Er komt een nieuwe pion in het spel voor speler " + numberOfPlayer);
                                    playerPosition3[0] = playerPosition2[0] + newResults[0];
                                    Console.WriteLine("Dobbelstenen zijn gegooid en de pion mag " + newResults[0] + " stappen vooruit. Deze pion staat nu op vakje " + playerPosition3[0]);
                                    j = 4;
                                }
                            }
                        
                        //speler 4
                        else if (numberOfPlayer == 4)
                        {
                                if (playerPosition4[0] == 0)
                                {
                                    if (result == 6)
                                    {
                                        Console.WriteLine("Er komt een nieuwe pion in het spel voor speler " + numberOfPlayer);
                                        playerPosition4[0] = playerPosition4[0] + newResults[0];
                                        Console.WriteLine("Dobbelstenen zijn gegooid en de pion mag " + newResults[0] + " stappen vooruit. Deze pion staat nu op vakje " + playerPosition4[0]);
                                    }
                                    else
                                    {
                                        j = 4;
                                    }
                                }
                                else if (playerPosition4[0] < 41)
                                {
                                    Console.WriteLine("Er komt een nieuwe pion in het spel voor speler " + numberOfPlayer);
                                    playerPosition[0] = playerPosition2[0] + newResults[0];
                                    Console.WriteLine("Dobbelstenen zijn gegooid en de pion mag " + newResults[0] + " stappen vooruit. Deze pion staat nu op vakje " + playerPosition4[0]);
                                    j = 4;
                                }
                            }

                        }
                        numberOfPlayer++;
                    }
                    Console.WriteLine("next turn");
                    numberOfPlayer++;
                }
        Console.WriteLine("end game");
        }

        private static void NewMethod()
        {
            Console.WriteLine("test 1");
        }

        public override void SetGrid(int horizontal, int vertical)
        {
            throw new NotImplementedException();
        }

       

    }
}
