using System;

namespace Crisis.Characters
{
    public partial class Character
    {
        //Physical
        public Attribute Strength { get; set; }
        public Attribute Dexterity { get; set; }
        public Attribute Stamina { get; set; }
        
        //Mental
        public Attribute Perception { get; set; }
        public Attribute Intelligence { get; set; }
        public Attribute Wits { get; set; }
        
        //Social
        public Attribute Appearance { get; set; }
        public Attribute Manipulation { get; set; }
        public Attribute Charisma { get; set; }
    }
}