using FluentAssertions;
using System.Security;
using Xunit;

namespace Eris.Extensions.Security.Test
{
    public class StringToSecureStringTests
    {
        [Fact]
        public void String_To_SecureString()
        {
            var input = "text";

            var result = input.ToSecureString();

            result.Should()
                .BeOfType<SecureString>();
        }
    }
}