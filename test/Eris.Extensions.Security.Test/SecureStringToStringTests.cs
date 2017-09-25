using FluentAssertions;
using System.Security;
using System.Text;
using Xunit;

namespace Eris.Extensions.Security.Test
{
    public class SecureStringToStringTests
    {
        [Fact]
        public void SecureString_To_ASCII_String()
        {
            var input = "text".ToSecureString();

            var result = input.GetString(Encoding.ASCII);

            result.Should()
                .BeOfType<string>()
                .And
                .BeEquivalentTo("text");
        }

        [Fact]
        public void SecureString_To_Unicode_String()
        {
            var input = "text".ToSecureString();

            var result = input.GetString(Encoding.Unicode);

            result.Should()
                .BeOfType<string>()
                .And
                .BeEquivalentTo("text");
        }
    }
}