//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Documents;

//namespace Spellendoos.Classes
//{
//    class YahtzeeRules
//    {
//        private List<string> rules;
//        private List<int> score_options;
//        public YahtzeeRules()
//        {
//            addRule("Drie gelijke");
//            addRule("Vier gelijke");
//            addRule("Kleine straat");
//            addRule("Grote straat");
//            addRule("Full House");
//            addRule("Kans");
//            addRule("Yahtzee");
//        }

//        public void addRule(string rule)
//        {
//            this.rules.Add(rule);
//        }

//        public void checkRules(List<Dice> thrownDices)
//        {
//            int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0;

//            List<string> ruleOptions = new List<string>();

//            foreach(Dice dice in thrownDices)
//            {
//                switch (dice.RollDice())
//                {
//                    case 1:
//                        one++;
//                        break;
//                    case 2:
//                        two++;
//                        break;
//                    case 3:
//                        three++;
//                        break;
//                    case 4:
//                        four++;
//                        break;
//                    case 5:
//                        five++;
//                        break;
//                    case 6:
//                        six++;
//                        break;
//                }
//            }
//            //checked if number appears more than three times
//            if(one >= 3 || two >= 3 || three >= 3 || four >= 3 || five >= 3 || six >= 3)
//            {
//                ruleOptions.Add("Drie gelijk");
//                score_options.Add(1 * one + 2 * two + 3 * three + 4 * four + 5 * five + 6 * six);
//                //checked if number appears more than three times and the others have the same value
//                if (one >= 2 || two >= 2 || three >= 2 || four >= 2 || five >= 2 || six >= 2)
//                {
//                    ruleOptions.Add("Full house");
//                    score_options.Add(25);
//                }
//                //checked if number appears more than four times
//                if(one >= 4 || two >= 4 || three >= 4 || four >= 4 || five >= 4 || six >= 4)
//                {
//                    ruleOptions.Add("Vier gelijk");
//                    score_options.Add(1 * one + 2 * two + 3 * three + 4 * four + 5 * five + 6 * six);
//                }
//                //checked if number appears five times
//                if (one == 5 || two == 5 || three == 5 || four == 5 || five == 5 || six == 5)
//                {
//                    ruleOptions.Add("Yahtzee");
//                    score_options.Add(50);
//                }
//            }
//            else if(one == 1)
//            {
//                if(two == 1)
//                {
//                    if(three == 1)
//                    {
//                        if(four == 1)
//                        {
//                            ruleOptions.Add("Kleine straat");
//                            score_options.Add(30);
//                            if(five == 1) 
//                            {
//                                ruleOptions.Add("Grote straat");
//                                score_options.Add(40);
//                            }
//                        }
//                    }
//                }
//            }
//            else if (two == 1)
//            {
//                if (three == 1)
//                {
//                    if (four == 1)
//                    {
//                        if (five == 1)
//                        {
//                            ruleOptions.Add("Kleine straat");
//                            score_options.Add(30);
//                            if (six == 1)
//                            {
//                                ruleOptions.Add("Grote straat");
//                                score_options.Add(40);
//                            }
//                        }
//                    }
//                }
//            }
//            else if (three == 1)
//            {
//                if (four == 1)
//                {
//                    if (five == 1)
//                    {
//                        if (six == 1)
//                        {
//                            ruleOptions.Add("Kleine straat");
//                            score_options.Add(30);
//                        }
//                    }
//                }
//            }
            
//        }
//    }

//}
