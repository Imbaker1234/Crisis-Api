using Crisis.Characters.Traits.Skills;

namespace Crisis.Characters.Effects
{
    public class SkillEffect : Effect
    {
        public Skill AffectedSkill { get; set; }

        public SkillEffect(Skill skill, string name, int duration, EffectType? type) : base(name, duration)
        {
            var effect = new SkillEffect(new Character().Alchemy, "Insight of the Master", 5, EffectType.Bonus);
        }
    }
}