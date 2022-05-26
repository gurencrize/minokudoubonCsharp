using Microsoft.VisualStudio.TestTools.UnitTesting;
using minokudoubon;

namespace minokudoubontest
{
    [TestClass]
    public class AttackPowerTest
    {
        [TestMethod]
        public void 別のAttackPowerを無効化してもその影響を受けない()
        {
            AttackPower attackPower = new AttackPower(20);
            AttackPower attackPower2 = new AttackPower(20);
            attackPower2.disable();
            Assert.AreEqual(attackPower.Value,20);
        }

        [TestMethod]
        public void AttackPowerを強化できる()
        {
            AttackPower attackPower = new AttackPower(20);
            AttackPower rainForced = attackPower.reinForce(new AttackPower(15));
            Assert.AreEqual(rainForced.Value, 35);
        }
    }
}
