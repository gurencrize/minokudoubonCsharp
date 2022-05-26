using Microsoft.VisualStudio.TestTools.UnitTesting;
using minokudoubon;
using System;

namespace minokudoubontest
{
    [TestClass]
    public class WaeponTest
    {
        [TestMethod]
        public void Waeponに対する強化が他のAttackPowerに影響を与えない()
        {
            AttackPower attackPowerA = new AttackPower(10);
            AttackPower attackPowerB = new AttackPower(20);
            Waepon waeponA = new Waepon(attackPowerA);
            Waepon waeponB = new Waepon(attackPowerB);
            AttackPower increment = new AttackPower(5);
            Waepon reinforcedWaeponA = waeponA.ReinForce(increment);

            Assert.AreEqual(attackPowerA.Value, 10);
            Assert.AreEqual(attackPowerB.Value, 20);
            Assert.AreEqual(waeponB.AttackPower.Value, 20);
            Assert.AreEqual(reinforcedWaeponA.AttackPower.Value, 15);

        }
    }
}