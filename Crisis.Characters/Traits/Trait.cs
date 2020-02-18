namespace Crisis.Characters.Traits
{
    public class Trait
    {
        public string Name { get; set; }
        public int Value { get; set; }
        
        public static implicit operator int(Trait t) => t.Value;
    }
}