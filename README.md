# System.Security extensions

## SecureString 

Extensions to easily convert from and to a SecureString object

```c#
SecureString secureString1 = "text".ToSecureString();
SecureString secureString2 = new byte[] { 116, 101, 120, 116}.ToSecureString();

string text = secureString1.GetString();
byte[] bytes = secureString1.GetBytes();

```