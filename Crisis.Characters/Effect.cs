namespace Crisis.Characters.Effects
{
    public abstract class Effect
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Value { get; set; }
        public EffectType EffectType { get; set; }

        protected Effect(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }
    }
}