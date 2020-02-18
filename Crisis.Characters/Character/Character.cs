using System.Collections.Generic;
using Crisis.Characters.Effects;

namespace Crisis.Characters
{
    public partial class Character
    {
        public string Name { get; set; }
        
        public int Health { get; set; }
        public int Focus { get; set; }
        public int DamageReduction { get; set; }
        
        //Effects
        public List<AttributeEffect> AttributeEffects { get; set; }
        public List<SkillEffect> SkillEffects { get; set; }
    }
}