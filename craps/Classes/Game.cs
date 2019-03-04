using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace craps
{
    public class Game
    {
        // this class is going to keep track of all of our rules for a game.
        List<Roll> rolls = new List<Roll>();
        public Roll currentRoll = new Roll();
        public int count = 0;

        public int points = 0;
        public int won = 0; //1 = won, 2 = lost.
                            //  public bool won;
        public string message = "";
        public int[] sumArray;
        public string resultMessage = "Null";
        public string winStr = "Draw";

        public void Play()
        {
            if (won == 0)
            {
                currentRoll = new Roll();
                rolls.Add(currentRoll);
                count++;
                if (count == 1)
                {
                    FirstRoll();
                }
                else
                {
                    SecondRoll();
                }
            }
        }


        private void FirstRoll()
        {
            if (currentRoll.total == 7 || currentRoll.total == 11)
            {
                won = 1;
                message = "\nBecause you got " + currentRoll.total + " on your first roll";
                resultMessage = "Win";
            }
            else if (currentRoll.total == 2 || currentRoll.total == 3 || currentRoll.total == 12)
            {
                //craps!
                won = 2;
                message = "\nBecause you got " + currentRoll.total + " on your first roll";
                resultMessage = "Lose";
            }
            else
            {
                points = currentRoll.total;
            }
        }

        private void SecondRoll()
        {

            if (currentRoll.total == 7)
            {
                won = 2;
                message = "\nBecause you got " + currentRoll.total + " on your "+ count + "roll";
                resultMessage = "Lose";

            }
            else if(currentRoll.total == points)
            {
                won = 1;
                message = "\nBecause you got " + currentRoll.total + " on your " + count + "roll"+
                    "\nWhich is equal to " + points + " which is what you got on your first roll";
                resultMessage = "Win";
            }
        }

        public void GetSums()
        {
            List<int> sums = new List<int>();
            for(var i =0; i < rolls.Count; i++)
            {
                sums.Add(rolls[i].total);
            }
            sumArray = sums.ToArray();
        }


        
    }

    public class Roll
    {
        public int total = 0;
        public int diceOne = 0;
        public int diceTwo = 0;

        public Roll()
        {
            diceOne = GetRoll();
            diceTwo = GetRoll();
            total = diceOne + diceTwo;
        }

        private Int16 GetRoll()
        {
            string diceApiAddress = "https://rolz.org/api/?1d6.json";
            string diceJson;

            using (WebClient wc = new WebClient())
            {
                diceJson = wc.DownloadString(diceApiAddress);
            }
            // now we're going to turn them into json objects so that they'll be easier to deal with from now on.
            JObject diceObject = JObject.Parse(diceJson);
            return Int16.Parse(diceObject.GetValue("result").Value<string>());

        }
    }
}
