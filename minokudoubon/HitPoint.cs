using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minokudoubon
{
    /// <summary>
    /// 第2章で紹介されるHP管理クラス
    /// </summary>
    public class HitPoint
    {
        const int min = 0;
        const int max = 999;
        readonly int value;

        // C#だと引数の再代入禁止ができないみたい?
        public HitPoint(int value)
        {
            if (value < min) throw new ArgumentOutOfRangeException($"{min} 以上を指定してください");
            if (value > max) throw new ArgumentOutOfRangeException($"{max} 以下を指定してください");
            this.value = value;
        }

        public HitPoint Damage(int damageAmount)
        {
            // ローカル変数も再代入禁止できない?
            int damaged = value - damageAmount;
            int corrected = damaged < min ? min : damaged;
            return new HitPoint(corrected);
        }

        public HitPoint Recover(int recoveryAmount)
        {
            int recoverd = value + recoveryAmount;
            int corrected = recoverd < max ? max : recoverd;
            return new HitPoint(corrected);
        }
    }
}
