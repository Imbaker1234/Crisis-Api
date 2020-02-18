using System;
using System.Collections.Generic;
using Crisis.Characters;

namespace Crisis.Combat
{
    public class Crisis
    {
        public List<Character> Characters { get; set; }
        public List<Round> Rounds { get; set; }

        public void Initiative(List<Character> characters)
        {
            foreach (var character in characters)
            {
                
            }
        }
    }
}