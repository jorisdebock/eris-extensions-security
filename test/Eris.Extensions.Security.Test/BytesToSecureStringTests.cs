using FluentAssertions;
using System.Security;
using System.Text;
using Xunit;

namespace Eris.Extensions.Security.Test
{
    public class BytesToSecureStringTests
    {
        [Fact]
        public void ASCII_String_To_SecureString()
        {
            var input = Encoding.ASCII.GetBytes("text");

            var result = input.ToSecureString(Encoding.ASCII);

            result.Should()
                .BeOfType<SecureString>();
        }

        [Fact]
        public void Unicode_String_To_SecureString()
        {
            var input = Encoding.Unicode.GetBytes("text");

            var result = input.ToSecureString(Encoding.Unicode);

            result.Should()
                .BeOfType<SecureString>();
        }
    }
}