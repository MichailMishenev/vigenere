namespace vigenere.Tests
{
    public class VigenereTests
    {
        [Fact]
        public void VigenereTest()
        {
            string message = "Привет! Hello!";
            string key = "абвabc";
            string result = Crypt.VigenereEncrypt(message, key);
            Assert.Equal("Ртлгжх! Igomq!", result);
            Assert.Equal(message, Crypt.VigenereDecrypt(result, key));
        }

        [Fact]
        public void CaesarTest()
        {
            string message = "Привет! Hello!";
            int shift = 3;
            string result = Crypt.CaesarEncrypt(message, shift);
            Assert.Equal("Тулеих! Khoor!", result);
            Assert.Equal(message, Crypt.CaesarDecrypt(result, shift));
        }

        [Fact]
        public void AtbashTest()
        {
            string message = "Привет! Hello!";
            string result = Crypt.AtbashTransform(message);
            Assert.Equal("Рпчэън! Svool!", result);
            Assert.Equal(message, Crypt.AtbashTransform(result));
        }
    }
}