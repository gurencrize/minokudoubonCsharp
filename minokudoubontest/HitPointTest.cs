using Microsoft.VisualStudio.TestTools.UnitTesting;
using minokudoubon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minokudoubontest
{
    [TestClass]
    public class HitPointMutableTest
    {
        [TestMethod]
        public void 過剰なダメージで負になる()
        {
            HitPointMutable HP = new HitPointMutable(100);
            HP.Damage(500);
            Assert.IsTrue(HP.isZero());
        }
    }
}
