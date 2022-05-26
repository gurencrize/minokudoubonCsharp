using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minokudoubon
{
    /// <summary>
    /// 第4章で紹介される可変のHP管理クラス
    /// </summary>
    public class HitPointMutable
    {
        const int MIN = 0;
        private int amount;

        public HitPointMutable(int amount)
        {
            if(amount < MIN)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.amount = amount;
        }

        public void Damage(int damageAmount)
        {
            int nextAmount = amount - damageAmount;
            amount = Math.Max(MIN, nextAmount);
        }

        public bool isZero()
        {
            return amount == MIN;
        }
    }
}
