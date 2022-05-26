using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minokudoubon
{
    public enum Currency
    {
        JPY,USD
    }

    /// <summary>
    /// 第3章で紹介される金額管理クラス
    /// </summary>
    public class Money
    {
        private readonly int amount; // 金額値
        private readonly Currency currency; // 通貨単位

        public Money(int amount,Currency currency)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException("金額が0以上でありません。");

            // enum型はnullにしようとするとコンパイルエラーで弾かれるのでnullチェックは不要
            // if (currency == null) throw new ArgumentNullException("通貨を指定してください。");
            this.amount = amount;
            this.currency = currency;
        }

        // 引数を変更不能にしたいけどC#だと無理
        public Money Add(Money other)
        {
            // 再代入ができなくなっているので↓はコンパイルエラーになる
            // amount += other;

            // other.amount privateなのに読めるんだ…
            int added = amount + other.amount;
            return new Money(added, currency);
        }


    }
}
