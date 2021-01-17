using System;
using System.Collections.Generic;
using System.Linq;

namespace NUnitTestProject1
{
    public class BowlingGame
    {
        public int[] rolls = new int [21];
        int currentRoll = 0;
        public void Roll(int pins)
        {
            rolls[currentRoll++]=pins;
        }
        public int Score()
        {
            int score = 0;
            int roll = 0;
            for (int frame = 0; frame < 10;frame++)
            {
                if(IsSpare(roll))
                {
                    score += 10 + rolls[roll + 2];
                    roll += 2;
                }
                else if (IsStrike(roll))
                {
                    score += 10 + rolls[roll + 1] + rolls[roll + 2];
                    roll++;
                }
                else
                {
                    score += rolls[roll] + rolls[roll + 1];
                    roll += 2;
                }                
            }
            return score;
        }

        private bool IsSpare(int roll)
        {
            return rolls[roll] + rolls[roll + 1] == 10;
        }
        private bool IsStrike(int roll)
        {
            return rolls[roll] == 10;
        }

        public void RollMany(int rolls, int pints)
        {
            for (int i = 0; i < rolls; i++)
            {
                Roll(pints);
            }
        }
    }
}