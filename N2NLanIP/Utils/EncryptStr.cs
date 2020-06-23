using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace mdc.Api.Utils
{
	public class EncryptStr
	{
		private static byte[] Keys = new byte[]
		{
			18,
			52,
			86,
			120,
			144,
			171,
			205,
			239
		};

		public static string EncryptDES(string encryptString, string encryptKey)
		{
			string result;
			try
			{
				byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
				byte[] rgbIV = EncryptStr.Keys;
				byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
				DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
				MemoryStream mStream = new MemoryStream();
				CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
				cStream.Write(inputByteArray, 0, inputByteArray.Length);
				cStream.FlushFinalBlock();
				result = Convert.ToBase64String(mStream.ToArray());
			}
			catch
			{
				result = encryptString;
			}
			return result;
		}

		public static string DecryptDES(string decryptString, string decryptKey)
		{
			string result;
			try
			{
				byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
				byte[] rgbIV = EncryptStr.Keys;
				byte[] inputByteArray = Convert.FromBase64String(decryptString);
				DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
				MemoryStream mStream = new MemoryStream();
				CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
				cStream.Write(inputByteArray, 0, inputByteArray.Length);
				cStream.FlushFinalBlock();
				result = Encoding.UTF8.GetString(mStream.ToArray());
			}
			catch
			{
				result = "";
			}
			return result;
		}

		public string GenerateKey()
		{
			DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DES.Create();
			return Encoding.ASCII.GetString(desCrypto.Key);
		}

		public string EncryptString(string sInputString, string sKey)
		{
			byte[] data = Encoding.ASCII.GetBytes(sInputString);
			ICryptoTransform desencrypt = new DESCryptoServiceProvider
			{
				Key = Encoding.ASCII.GetBytes(sKey),
				IV = Encoding.ASCII.GetBytes(sKey)
			}.CreateEncryptor();
			byte[] result = desencrypt.TransformFinalBlock(data, 0, data.Length);
			return BitConverter.ToString(result);
		}

		public string DecryptString(string sInputString, string sKey)
		{
			string[] sInput = sInputString.Split("-".ToCharArray());
			byte[] data = new byte[sInput.Length];
			for (int i = 0; i < sInput.Length; i++)
			{
				data[i] = byte.Parse(sInput[i], NumberStyles.HexNumber);
			}
			ICryptoTransform desencrypt = new DESCryptoServiceProvider
			{
				Key = Encoding.ASCII.GetBytes(sKey),
				IV = Encoding.ASCII.GetBytes(sKey)
			}.CreateDecryptor();
			byte[] result = desencrypt.TransformFinalBlock(data, 0, data.Length);
			return Encoding.UTF8.GetString(result);
		}
		/// <summary>
        /// 密码加盐
        /// </summary>
        /// <param name="pwd">密码</param>
        /// <returns>加盐后的密码</returns>
        public static string AddSalt( string pwd )
        {
            string pre1="qin";
            string v= "YY"; 
            string pre2="@";
            string pre3="H";
            string pre4="ua";
            // 组成 Huaqin@
            v = pre3 + pre4 + pre1 + pre2 + pwd;
            return v;
        }
	}
}
