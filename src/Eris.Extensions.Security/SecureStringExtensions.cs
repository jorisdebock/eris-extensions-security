using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Eris.Extensions.Security
{
    public static class SecureStringExtensions
    {
        public static SecureString ToSecureString(this byte[] values, Encoding encoding)
        {
            var secure = new SecureString();
            foreach (var c in encoding.GetChars(values))
            {
                secure.AppendChar(c);
            }

            return secure;
        }

        public static SecureString ToSecureString(this string text)
        {
            var secure = new SecureString();
            foreach (var c in text)
            {
                secure.AppendChar(c);
            }

            return secure;
        }

        public static byte[] GetBytes(this SecureString value, Encoding encoding)
        {
            var bytes = new byte[value.Length * 2];
            var valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                for (var i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = Marshal.ReadByte(valuePtr, i);
                }
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }

            return Encoding.Convert(Encoding.Unicode, encoding, bytes);
        }

        public static string GetString(this SecureString value, Encoding encoding)
        {
            var bytes = value.GetBytes(encoding);

            return encoding.GetString(bytes);
        }
    }
}