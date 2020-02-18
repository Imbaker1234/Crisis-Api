using System;
using System.Security.Cryptography;
using Crisis.Characters;

namespace Crisis.Combat
{
    public class Turn : IComparable
    {
        /// <summary>
        /// The round in which this turn takes/took place.
        /// </summary>
        public Round Round { get; }
        
        /// <summary>
        /// The character who's turn it is/was.
        /// </summary>
        public Character Actor { get; set; }

        /// <summary>
        /// The current modifier denoting what order this turn
        /// should be taken in the current round.
        /// </summary>
        public int Initiative { get; set; }

        public int AutomaticSuccesses { get; set; }
        public int TotalDice { get; set; }
        public int ExplodeLevel { get; set; }
        public int Difficulty { get; set; }
        public int Outcome { get; set; }

        
        public Turn Roll(int onTheFlyBonus = 0, int onTheFlySuccess = 0)
        {
            var rand = new Random();

            int successes = AutomaticSuccesses + onTheFlySuccess;
            
            for (int i = 0; i < TotalDice + onTheFlyBonus; i++)
            {
                var rollResult = rand.Next(1, 10);
                if (rollResult == Difficulty) successes++;
                if (rollResult == 1) successes--;
                if (rollResult >= ExplodeLevel) i--;
            }

            Outcome = successes;
            return this;
        }
        
        public int CompareTo(object? obj)
        {
            var left = this;
            var right = (Turn) obj;
            return left.CompareTo(right);
        }
    }
}