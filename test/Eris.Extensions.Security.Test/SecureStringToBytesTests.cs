using FluentAssertions;
using System.Security;
using System.Text;
using Xunit;

namespace Eris.Extensions.Security.Test
{
    public class SecureStringToBytesTests
    {
        [Fact]
        public void SecureString_To_ASCII_Bytes()
        {
            var input = "text".ToSecureString();

            var result = input.GetBytes(Encoding.ASCII);

            result.Should()
                .BeOfType<byte[]>()
                .And
                .BeEquivalentTo(Encoding.ASCII.GetBytes("text"));
        }

        [Fact]
        public void SecureString_To_Unicode_Bytes()
        {
            var input = "text".ToSecureString();

            var result = input.GetBytes(Encoding.Unicode);

            result.Should()
                .BeOfType<byte[]>()
                .And
                .BeEquivalentTo(Encoding.Unicode.GetBytes("text"));
        }
    }
}