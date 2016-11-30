using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DandD.Enums;
using DandD.Interfaces;

namespace DandD
{
    public class Character : ICharacter
    {
        // constructor
        public Character()
        {   
            // ability init
            Strength     = new Ability ();
            Dexterity    = new Ability ();
            Constitution = new Ability ();
            Intelligence = new Ability ();
            Wisdom       = new Ability ();
            Charisma     = new Ability ();
            // skills init
            Acrobatics     = new Skill(Strength);
            AnimalHandling = new Skill(Wisdom);
            Arcana         = new Skill(Intelligence);
            Athletics      = new Skill(Strength);
            Deception      = new Skill(Charisma);
            History        = new Skill(Intelligence);
            Insight        = new Skill(Wisdom);
            Intimidation   = new Skill(Charisma);
            Investigation  = new Skill(Intelligence);
            Medicine       = new Skill(Wisdom);
            Nature         = new Skill(Intelligence);
            Perception     = new Skill(Wisdom);
            Performance    = new Skill(Charisma);
            Persuasion     = new Skill(Charisma);
            Religion       = new Skill(Intelligence);
            SleightOfHand  = new Skill(Dexterity);
            Stealth        = new Skill(Dexterity);
            Survival       = new Skill(Strength);
        }
                     
        public string CharacterName { get; set; }
        public string Background { get; set; }
        public ClassTypes Class { get; set; }
        public RaceTypes Race { get; set; }
        public AlignmentTypes Alignment { get; set; }
        //stats
        public Ability Strength     { get; set; }
        public Ability Dexterity    { get; set; }
        public Ability Constitution { get; set; }
        public Ability Intelligence { get; set; }
        public Ability Wisdom       { get; set; }
        public Ability Charisma     { get; set; }
        //skills
        public Skill Acrobatics     { get; private set; }
        public Skill AnimalHandling { get; private set; }
        public Skill Arcana         { get; private set; }
        public Skill Athletics      { get; private set; }
        public Skill Deception      { get; private set; }
        public Skill History        { get; private set; }
        public Skill Insight        { get; private set; }
        public Skill Intimidation   { get; private set; }
        public Skill Investigation  { get; private set; }
        public Skill Medicine       { get; private set; }
        public Skill Nature         { get; private set; }
        public Skill Perception     { get; private set; }
        public Skill Persuasion     { get; private set; }
        public Skill Performance    { get; private set; }
        public Skill Religion       { get; private set; }
        public Skill SleightOfHand  { get; private set; }
        public Skill Stealth        { get; private set; }
        public Skill Survival       { get; private set; }
    }
}