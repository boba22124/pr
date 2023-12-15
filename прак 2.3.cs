using System;

public class CaesarCipher
{
private int shift;

public CaesarCipher(int shift)
{
this.shift = shift;
}

public string Encrypt(string input)
{
char[] inputArray = input.ToCharArray();

for (int i = 0; i < inputArray.Length; i++)
{
if (char.IsLetter(inputArray[i]))
{
char offset = char.IsUpper(inputArray[i]) ? 'A' : 'a';
inputArray[i] = (char)((inputArray[i] + shift - offset) % 26 + offset);
}
}

return new string(inputArray);
}

public string Decrypt(string input)
{
shift = 26 - shift; // обратный сдвиг для дешифрования
return Encrypt(input);
}
}

class Program
{
static void Main()
{
string message = "Hello, World!";
int shift = 3;

CaesarCipher cipher = new CaesarCipher(shift);
string encryptedMessage = cipher.Encrypt(message);
string decryptedMessage = cipher.Decrypt(encryptedMessage);

Console.WriteLine("Original message: " + message);
Console.WriteLine("Encrypted message: " + encryptedMessage);
Console.WriteLine("Decrypted message: " + decryptedMessage);
}
}