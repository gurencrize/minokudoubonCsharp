using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minokudoubon
{
    public class AttackPower
    {
        const int min = 0;
        private readonly int value;

        // readonlyな変数が外から呼べないのでインスタンス外から値を読み込みたい時はプロパティを使う
        public int Value { get { return value; } }

        public AttackPower(int value)
        {
            if(value < min) throw new ArgumentOutOfRangeException("引数の値が不正です。");
            this.value = value;
        }

        /// <summary>
        /// 攻撃力を強化する
        /// </summary>
        /// <param name="increment">攻撃力の増分</param>
        /// <returns>強化された攻撃力</returns>
        public AttackPower reinForce(AttackPower increment)
        {
            return new AttackPower(this.value + increment.value);
        }

        /// <summary>
        /// 攻撃力を無力化する
        /// </summary>
        /// <returns>無力化した攻撃力</returns>
        public AttackPower disable()
        {
            return new AttackPower(min);
        }

    }
}
