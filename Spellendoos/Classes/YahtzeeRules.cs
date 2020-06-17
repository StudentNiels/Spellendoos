using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Spellendoos.Classes
{
    class YahtzeeRules
    {
        private List<string> rules;
        private Dictionary<string, int> score_options;
        public YahtzeeRules()
        {
            this.rules = new List<string>();
            addRule("Drie gelijke");
            addRule("Vier gelijke");
            addRule("Kleine straat");
            addRule("Grote straat");
            addRule("Full House");
            addRule("Kans");
            addRule("Yahtzee");
            score_options = new Dictionary<string, int>();
        }

        public void addRule(string rule)
        {
            this.rules.Add(rule);
        }


        public Dictionary<string, int> checkRules(int[] results)
        {
            //Check potential scores and add the ones possible to the dictionary
            int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0;

            score_options.Clear();

            foreach (int result in results)
            {
                switch (result)
                {
                    case 1:
                        one++;
                        break;
                    case 2:
                        two++;
                        break;
                    case 3:
                        three++;
                        break;
                    case 4:
                        four++;
                        break;
                    case 5:
                        five++;
                        break;
                    case 6:
                        six++;
                        break;
                }
                
            }
            //Kans is always a thing.
            score_options.Add("Kans", one * 1 + two * 2 + three * 3 + four * 4 + five * 5 + six * 6);
            //checked if number appears more than three times
            if (one >= 3 || two >= 3 || three >= 3 || four >= 3 || five >= 3 || six >= 3)
            {
                score_options.Add("Drie gelijk", (1 * one + 2 * two + 3 * three + 4 * four + 5 * five + 6 * six));
                //checked if number appears more than three times and the others have the same value
                if (one >= 2 || two >= 2 || three >= 2 || four >= 2 || five >= 2 || six >= 2)
                {
                    score_options.Add("Full House",25);
                }
                //checked if number appears more than four times
                if (one >= 4 || two >= 4 || three >= 4 || four >= 4 || five >= 4 || six >= 4)
                {
                    score_options.Add("Vier Gelijk",1 * one + 2 * two + 3 * three + 4 * four + 5 * five + 6 * six);
                }
                //checked if number appears five times
                if (one == 5 || two == 5 || three == 5 || four == 5 || five == 5 || six == 5)
                {
                    score_options.Add("Yahtzee",50);
                }
            }
            else if (one == 1)
            {
                if (two == 1)
                {
                    if (three == 1)
                    {
                        if (four == 1)
                        {
                            score_options.Add("Kleine straat", 30);
                            if (five == 1)
                            {
                                
                            }
                        }
                    }
                }
            }
            else if (two == 1)
            {
                if (three == 1)
                {
                    if (four == 1)
                    {
                        if (five == 1)
                        {
                            score_options.Add("Kleine straat", 30);
                            if (six == 1)
                            {
                                score_options.Add("Grote straat", 40);
                            }
                        }
                    }
                }
            }
            else if (three == 1)
            {
                if (four == 1)
                {
                    if (five == 1)
                    {
                        if (six == 1)
                        {
                            score_options.Add("Kleine straat", 30);
                        }
                    }
                }
            }
            return score_options;
        }
    }

}
