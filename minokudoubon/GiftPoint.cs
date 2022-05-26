using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minokudoubon
{
    /// <summary>
    /// 第5章で紹介されるギフトポイント付与クラス
    /// </summary>
    internal class GiftPoint
    {
        const int MIN_POINT = 0;
        const int STANDARD_MEMBERSHIP_POINT = 3000;
        const int PREMIUM_MEMBERSHIP_POINT = 10000;
        public int value { get; }

        /// <summary>
        /// コンストラクタ
        /// クラス内のメソッドからのみ呼び出すため、privateに指定しておく
        /// </summary>
        /// <param name="point">ポイントの初期値</param>
        /// <exception cref="ArgumentOutOfRangeException">ポイントが0以下の時に投げる</exception>
        private GiftPoint(int point)
        {
            if (point < MIN_POINT)
            {
                throw new ArgumentOutOfRangeException("ポイントが0以上ではありません");
            }

            this.value = point;
        }

        /// <summary>
        /// 標準会員向け入会ギフトポイント
        /// </summary>
        public static GiftPoint forStandardMembership()
        {
            return new GiftPoint(STANDARD_MEMBERSHIP_POINT);
        }

        /// <summary>
        /// プレミアム会員向け入会ギフトポイント
        /// </summary>
        public static GiftPoint forPremiumMembership()
        {
            return new GiftPoint(PREMIUM_MEMBERSHIP_POINT);
        }
    }
}
