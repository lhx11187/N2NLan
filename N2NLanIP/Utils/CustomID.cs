using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace mdc.Api.Utils
{
    /// <summary>
    /// 自定义标识类，生成的ID通常用作数据表的主键
    /// </summary>
    public class CustomID
    {
        /// <summary>
        /// 生成10位数字，一般用作数据回传的主键
        /// </summary>
        /// <returns></returns>
        public static long Generate10bitNumber(string datetimeStr = null)
        {
            TimeSpan ts = (string.IsNullOrWhiteSpace(datetimeStr) ? DateTime.Now : DateTime.Parse(datetimeStr)) - DateTime.Parse("1970-01-01 08:00:00");
            long id = (long)(ts.TotalSeconds);
            return id;
        }

        /// <summary>
        /// 自动还原MainID或PB_ID为时间点
        /// </summary>
        /// <param name="mainID"></param>
        /// <returns></returns>
        public static DateTime MainID2DateTime(string mainID)
        {
            DateTime? dt = null;
            int idType = -1;

            if (Regex.IsMatch(mainID, "^[0-9]{13}$", RegexOptions.IgnoreCase))              //如果是13位纯数字
            {
                idType = 1;                                       //标识为MainID
            }
            else if (Regex.IsMatch(mainID, "^[0-9A-Z]{8}$", RegexOptions.IgnoreCase))       //如果是8位数字和字母
            {
                mainID = Compute.ConvertTo10(mainID).ToString();  //转换为13位纯数字字符串
                idType = 1;                                       //标识为MainID
            }
            else if (Regex.IsMatch(mainID, "^[0-9]{10}$", RegexOptions.IgnoreCase))         //批次号必须是10纯位数字
            {
                idType = 2;                                       //标识为PB_ID
            }
            else
            {
                throw new Exception("输入的ID不在指定的范围之内，转换失败！");
            }

            if (idType == 1)
            {
                dt = DateTime.Parse("1970-01-01 08:00:00").AddMilliseconds(Convert.ToInt64(mainID));
            }
            else if (idType == 2)
            {
                dt = DateTime.Parse("1970-01-01 08:00:00").AddSeconds(Convert.ToInt64(mainID));
            }

            return dt.Value;
        }

        /// <summary>
        /// 生成13位数字，一般用作认证码
        /// </summary>
        /// <returns></returns>
        public static long Generate13bitNumber()
        {
            TimeSpan ts = DateTime.Now - DateTime.Parse("1970-01-01 08:00:00");
            long id = (long)(ts.TotalMilliseconds);
            return id;
        }
    }
}