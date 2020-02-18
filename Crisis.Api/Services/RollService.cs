using System;
using System.Linq;
using Crisis.Characters;
using Crisis.Characters.Effects;
using Crisis.Characters.Traits;
using Crisis.Characters.Traits.Skills;
using Crisis.Combat;
using Microsoft.AspNetCore.Mvc;
using Attribute = Crisis.Characters.Attributes.Attribute;

namespace Crisis.Api.Services
{
    public class RollService
    {
        public Turn TakeAction(string characterName, string attributeName, string skillName, int difficulty,
            int explodeLevel)
        {
             return PreRoll(characterName, attributeName, skillName, difficulty, explodeLevel).Roll();
        } 
        
        private Turn PreRoll(string characterName, string attributeName, string skillName, int difficulty, int explodeLevel)
        {
            Character character = AppState.CurrentCrisis.Characters.First(ch => ch.Name == characterName);
            Attribute attribute = character.GetType().GetProperty(attributeName).GetValue(character) as Attribute;
            Skill skill = character.GetType().GetProperty(skillName).GetValue(character) as Skill;

            int extraDice = GetTraitBonus(character, attribute, EffectType.Bonus)
                            + GetTraitBonus(character, skill, EffectType.Bonus);

            int automaticSuccesses = 0;
            automaticSuccesses = GetTraitBonus(character, attribute, EffectType.Static)
                                 + GetTraitBonus(character, skill, EffectType.Static);

            int totalDice =
                attribute.Value +
                skill.Value +
                extraDice;
            
            var product = new Turn();

            product.AutomaticSuccesses = automaticSuccesses;
            product.TotalDice = totalDice;
            product.Difficulty = difficulty;
            product.ExplodeLevel = explodeLevel;

            return product;
        }

        private int GetTraitBonus(Character character, Trait trait, EffectType effectType)
        {
            return character.SkillEffects.Where(se =>
                se.AffectedSkill.Name == trait.Name && se.EffectType == effectType).Select(se => se.Value).First();
        }
    }
}