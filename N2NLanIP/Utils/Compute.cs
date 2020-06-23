using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mdc.Api.Utils
{
    /// <summary>
    /// 数学计算
    /// </summary>
    public class Compute
    {
        //十进制转二进制
        //Console.WriteLine("十进制166的二进制表示: "+Convert.ToString(166, 2));
        //十进制转八进制


        //二进制转十进制
        //Console.WriteLine("二进制 111101 的十进制表示: "+Convert.ToInt32("111101", 2));
        //八进制转十进制
        //Console.WriteLine("八进制 44 的十进制表示: "+Convert.ToInt32("44", 8));

        //编码,可加一些字符也可以实现72,96等任意进制转换，但是有符号数据不直观，会影响阅读。
        private static string keys = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static int exponent = keys.Length;//幂数
        private const string X36 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static char[] rDigits = X36.ToArray();

        #region    进制转换Start
        /// <summary>
        /// 10进制数值字符串转换成36进制
        /// </summary>
        /// <param name="val">10进制数字</param>
        /// <returns>36进制字符串</returns>
        public static string ConvertTo36(string valstr)
        {
            long val = Convert.ToInt64(valstr);
            string result = "";
            while (val >= 36)
            {
                result = X36[(int)(val % 36)] + result;
                val /= 36;
            }
            if (val >= 0)
            {
                result = X36[(int)val] + result;
            }
            return result;
        }

        /// <summary>
        /// 10进制数值转换成36进制
        /// </summary>
        /// <param name="val">10进制数字</param>
        /// <returns>36进制字符串</returns>
        public static string ConvertTo36(long val)
        {
            string result = "";
            while (val >= 36)
            {
                result = X36[(int)(val % 36)] + result;
                val /= 36;
            }
            if (val >= 0)
            {
                result = X36[(int)val] + result;
            }
            return result;
        }

        /// <summary>
        /// 36进制转换成10进制数值
        /// </summary>
        /// <param name="str">36进制字符串</param>
        /// <returns>10进制数字</returns>
        public static long ConvertTo10(string str)
        {
            long result = 0;
            int len = str.Length;
            for (int i = len; i > 0; i--)
            {
                result += X36.IndexOf(str[i - 1]) * Convert.ToInt64(Math.Pow(36, len - i));
            }
            return result;
        }

        /// <summary>
        /// ulong数值转62进制字符串
        /// </summary>
        /// <param name="value">The max value can not more decimal.MaxValue<</param>
        /// <returns>Return a specified 62 encode string//17223472558080896352ul</returns>
        public static string Decimal2Str(decimal value)
        {
            string result = string.Empty;
            do
            {
                decimal index = value % exponent;
                result = keys[(int)index] + result;
                value = (value - index) / exponent;
            }
            while (value > 0);

            return result;
        }

        /// <summary>
        /// 62进制字符串转decimal数值
        /// </summary>
        /// <param name="value">62 encode string</param>
        /// <returns>Return a specified decimal number that decode by 62 string</returns>
        public static decimal Str2Decimal(string value)//bUI6zOLZTrj
        {
            decimal result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                int x = value.Length - i - 1;
                result += keys.IndexOf(value[i]) * Pow(exponent, x);// Math.Pow(exponent, x);
            }
            return result;
        }

        /// <summary>
        /// 将指定基数的数字的 System.String 表示形式转换为等效的 64 位有符号整数。
        /// </summary>
        /// <param name="value">包含数字的 System.String。</param>
        /// <param name="fromBase">value 中数字的基数，它必须是[2,36]</param>
        /// <returns>等效于 value 中的数字的 64 位有符号整数。- 或 - 如果 value 为 null，则为零。</returns>
        public static long x2h(string value, int fromBase)
        {
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
            {
                return 0L;
            }

            string sDigits = new string(rDigits, 0, fromBase);
            long result = 0;
            //value = reverse(value).ToUpper(); 1
            value = value.ToUpper();// 2
            for (int i = 0; i < value.Length; i++)
            {
                if (!sDigits.Contains(value[i].ToString()))
                {
                    throw new ArgumentException(string.Format("The argument \"{0}\" is not in {1} system.", value[i], fromBase));
                }
                else
                {
                    try
                    {
                        //result += (long)Math.Pow(fromBase, i) * getcharindex(rDigits, value[i]); 1
                        //result += (long)Math.Pow(fromBase, i) * getcharindex(rDigits, value[value.Length - i - 1]);//   2
                        result += (long)Math.Pow(fromBase, i) * X36.IndexOf(value[value.Length - i - 1]);
                    }
                    catch
                    {
                        throw new OverflowException("运算溢出.");
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// long转化为toBase进制
        /// </summary>
        /// <param name="value"></param>
        /// <param name="toBase"></param>
        /// <returns></returns>
        public static string h2x(long value, int toBase)
        {
            int digitIndex = 0;
            long longPositive = Math.Abs(value);
            int radix = toBase;
            char[] outDigits = new char[63];

            for (digitIndex = 0; digitIndex <= 64; digitIndex++)
            {
                if (longPositive == 0) { break; }

                outDigits[outDigits.Length - digitIndex - 1] = rDigits[longPositive % radix];
                longPositive /= radix;
            }

            return new string(outDigits, outDigits.Length - digitIndex, digitIndex);
        }

        /// <summary>
        /// 任意进制转换,将fromBase进制表示的value转换为toBase进制
        /// </summary>
        /// <param name="value"></param>
        /// <param name="fromBase">原来进制（2-36进制）</param>
        /// <param name="toBase">转换后的进制（2-36进制）</param>
        /// <returns></returns>
        public static string X2X(object value, int fromBase, int toBase)
        {
            string vStr = value.ToString();
            if (string.IsNullOrEmpty(vStr.Trim()))
            {
                return string.Empty;
            }

            if (fromBase < 2 || fromBase > 36)
            {
                throw new ArgumentException(String.Format("The fromBase radix \"{0}\" is not in the range 2..36.", fromBase));
            }

            if (toBase < 2 || toBase > 36)
            {
                throw new ArgumentException(String.Format("The toBase radix \"{0}\" is not in the range 2..36.", toBase));
            }

            long m = x2h(vStr, fromBase);
            string r = h2x(m, toBase);
            return r;
        }
        #endregion 进制转换End

        #region    数学运算Start
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static decimal Pow(decimal exp, decimal x)
        {
            decimal value = 1;////1 will be the result for any number's power 0.任何数的0次方，结果都等于1
            while (x > 0)
            {
                value = value * exp;
                x--;
            }
            return value;
        }

        /// <summary>
        /// 科学计数法转数值
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        public static Decimal KXJSF2Decimal(string strData)
        {
            Decimal dData = 0.0M;
            if (strData.Contains("E"))
            {
                dData = Convert.ToDecimal(Decimal.Parse(strData, System.Globalization.NumberStyles.Float));
            }
            return dData;
        }

        /// <summary>
        /// 科学计数法转字符串
        /// </summary>
        /// <param name="dbNum"></param>
        /// <returns></returns>
        public static string KXJSF2String(double dbNum)
        {
            double bef = Math.Abs(dbNum);
            int aft = 0;
            while (bef >= 10 || (bef < 1 && bef != 0))
            {
                if (bef >= 10)
                {
                    bef = bef / 10;
                    aft++;
                }
                else
                {
                    bef = bef * 10;
                    aft--;
                }
            }
            return string.Concat(dbNum >= 0 ? "" : "-", ReturnBef(bef), "E", ReturnAft(aft));
        }

        /// <summary>
        /// 有效数字的处理
        /// </summary>
        /// <param name="bef">有效数字</param>
        /// <returns>三位有效数字，不足则补零</returns>
        public static string ReturnBef(double bef)
        {
            string ret = "";
            if (bef.ToString() != null)
            {
                char[] arr = bef.ToString().ToCharArray();
                switch (arr.Length)
                {
                    case 1:
                    case 2: ret = string.Concat(arr[0], ".", "00"); break;
                    case 3: ret = string.Concat(arr[0] + "." + arr[2] + "0"); break;
                    default: ret = string.Concat(arr[0] + "." + arr[2] + arr[3]); break;
                }
            }
            else
            {
                ret = "000";
            }
            return ret;
        }

        /// <summary>
        /// 幂的处理
        /// </summary>
        /// <param name="aft">幂数</param>
        /// <returns>三位幂数部分，不足则补零</returns>
        public static string ReturnAft(int aft)
        {
            string ret = "";
            if (aft.ToString() != null)
            {
                string end;
                char[] arr = System.Math.Abs(aft).ToString().ToCharArray();
                switch (arr.Length)
                {
                    case 1: end = "00" + arr[0]; break;
                    case 2: end = "0" + arr[0] + arr[1]; break;
                    default: end = System.Math.Abs(aft).ToString(); break;
                }
                ret = string.Concat(aft >= 0 ? "+" : "-", end);
            }
            else
            {
                ret = "+000";
            }
            return ret;
        }
        #endregion 数学运算End

        #region    算法Start
        /// <summary>
        /// 自定义算法1-时间戳加密
        /// </summary>
        /// <returns></returns>
        public static string EnTimeStamp()
        {
            var d = DateTime.Now;
            TimeSpan ts = DateTime.Now.ToUniversalTime() - DateTime.Parse("1970-01-01 00:00:00");
            long num = (long)ts.TotalMilliseconds;
            var strNum = X2X(num, 10, 36);
            var ArrNum = num.ToString().ToCharArray();
            var checksum2 = 0;
            for (var i = 0; i < ArrNum.Length; i += 2)
            {
                checksum2 ^= Convert.ToInt32(ArrNum[i]);
                checksum2 = checksum2 & 0xF;
            }
            checksum2 = checksum2 % 36;
            return strNum + ConvertTo36(checksum2).ToString();
        }

        /// <summary>
        /// 校验EnTimeStamp的值是否正确
        /// 校验调用如下:
        /// string a = EnTimeStamp();
        /// bool b = CheckTimeStamp(a);
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool CheckTimeStamp(string str)
        {
            var strNum = str.Substring(0, str.Length - 1); // 取n-1位
            var checksum = str.Substring(str.Length - 1);  // 取n位

            var ArrNum = X2X(strNum, 36, 10).ToArray();
            var checksum2 = 0;
            for (var i = 0; i < ArrNum.Length; i += 2)
            {
                checksum2 ^= Convert.ToInt32(ArrNum[i]);
                checksum2 = checksum2 & 0xF;
            }

            string rest = X2X((checksum2 % 36), 10, 36);

            return rest == checksum;
        }
        #endregion 算法End
    }
}