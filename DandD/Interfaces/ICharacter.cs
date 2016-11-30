using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DandD.Enums;

namespace DandD.Interfaces
{
    interface ICharacter
    {
        string CharacterName { get; set; }
        string Background { get; set; }
        ClassTypes Class { get; set; }
        RaceTypes Race { get; set; }
        AlignmentTypes Alignment { get; set; }
        //stats
        Ability Strength { get; set; }
        Ability Dexterity { get; set; }
        Ability Constitution { get; set; }
        Ability Intelligence { get; set; }
        Ability Wisdom { get; set; }
        Ability Charisma { get; set; }
        //skills
        Skill Acrobatics        { get; }
        Skill AnimalHandling    { get; }
        Skill Arcana            { get; }
        Skill Athletics         { get; }
        Skill Deception         { get; }
        Skill History           { get; }
        Skill Insight           { get; }
        Skill Intimidation      { get; }
        Skill Investigation     { get; }
        Skill Medicine          { get; }
        Skill Nature            { get; }
        Skill Perception        { get; }
        Skill Persuasion        { get; }
        Skill Performance       { get; }
        Skill Religion          { get; }
        Skill SleightOfHand     { get; }
        Skill Stealth           { get; }
        Skill Survival          { get; }


    }
}
