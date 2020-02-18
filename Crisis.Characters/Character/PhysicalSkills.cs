using Crisis.Characters.Traits.Skills;

namespace Crisis.Characters
{
    public partial class Character
    {
        //Strength
        public Skill Brawl { get; set; }
        public Skill Might { get; set; }
        
        //Dexterity
        public Skill Athletics { get; set; }
        public Skill Drive { get; set; }
        public Skill Ranged { get; set; }
        public Skill Legerdemain { get; set; }
        public Skill MartialArts { get; set; }
        public Skill Melee { get; set; }
        public Skill Pilot { get; set; }
        public Skill Stealth { get; set; }
        
        //Stamina
        public Skill Endurance { get; set; }
        public Skill Resistance { get; set; }
    }
}