using System.Collections.Generic;
using Crisis.Characters;

namespace Crisis.Combat
{
    public class Round
    {
        /// <summary>
        /// The current Crisis this round takes place in.
        /// </summary>
        public Crisis Crisis { get; set; }
        
        /// <summary>
        /// The current order of turns.
        /// </summary>
        public Queue<Character> InitiativeOrder { get; set; }
        
        /// <summary>
        /// The list of people currently holding their action.
        /// </summary>
        public Queue<Character> HeldTurns { get; set; }
        
        public List<Turn> TakenTurns { get; set; }
    }
}