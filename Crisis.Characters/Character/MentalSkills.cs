using Crisis.Characters.Traits.Skills;

namespace Crisis.Characters
{
    public partial class Character
    {
        //Perception
        public Skill Awareness { get; set; }
        public Skill Investigation { get; set; }
        
        //Intelligence
        public Skill Lore { get; set; }
        public Skill Bureacracy { get; set; }
        public Skill Runes { get; set; }
        public Skill Crafting { get; set; }
        public Skill Intrusion { get; set; }
        public Skill Linguistics { get; set; }
        public Skill Medicine { get; set; }
        public Skill Alchemy { get; set; }
        
        //Wits
        public Skill Survival { get; set; }
        public Skill Insight { get; set; }
        public Skill AnimalHandling { get; set; }
    }
}