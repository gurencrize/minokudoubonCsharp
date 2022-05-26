using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minokudoubon
{
    public class Waepon
    {
        public AttackPower AttackPower { get; }

        public Waepon(AttackPower attackPower)
        {
            AttackPower = attackPower;
        }

        public Waepon ReinForce(AttackPower increment)
        {
            AttackPower reinForced = AttackPower.reinForce(increment);
            return new Waepon(reinForced);
        }
    }
}
