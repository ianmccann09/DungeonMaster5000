using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DandD;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AbilityScoreCalulationTest()
        {
            var strength = new Ability()
            {
                Score = 20
            };
            Assert.IsTrue(strength.Modifier == 5);

            var stamina = new Ability()
            {
                Score = 19
            };
            Assert.IsTrue(stamina.Modifier == 4);

            var dexterity = new Ability()
            {
                Score = 7
            };
            Assert.IsTrue(dexterity.Modifier == -2);
        }

        [TestMethod]
        public void CharacterTest()
        {
            var bard = new Character();
            bard.Dexterity.Score = 13;
            bard.Constitution.Score = 10;
            bard.Wisdom.Score = 9;
            bard.Charisma.Score = 16;
            bard.Strength.Score = 8;
            bard.Intelligence.Score = 12;

            var stealthRoll = bard.Stealth.RollModifier;
            Assert.IsTrue(stealthRoll == 1);

            bard.Dexterity.Score = 20;
            bard.Stealth.Ranks = 1;
            bard.Stealth.IsFavored = true;
            Assert.IsTrue(bard.Stealth.RollModifier == 9);
            var roll=bard.Acrobatics.RollModifier;
        }
    }
    
}
