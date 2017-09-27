# System.Security extensions

[![](https://img.shields.io/nuget/v/Eris.Extensions.Security.svg)](https://www.nuget.org/packages/Eris.Extensions.Security)

## SecureString 

Extensions to easily convert from and to a SecureString object

```c#
SecureString secureString1 = "text".ToSecureString();
SecureString secureString2 = new byte[] { 116, 101, 120, 116}.ToSecureString();

string text = secureString1.GetString();
byte[] bytes = secureString1.GetBytes();

```
