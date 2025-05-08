namespace vigenere.Tests
{
    public class VigenereTests
    {
        [Fact]
        public void VigenereTest()
        {
            string message = "������! Hello!";
            string key = "���abc";
            string result = Crypt.VigenereEncrypt(message, key);
            Assert.Equal("������! Igomq!", result);
            Assert.Equal(message, Crypt.VigenereDecrypt(result, key));
        }
        [Fact]
        public void CaesarTest()
        {
            string message = "������! Hello!";
            int shift = 3;
            string result = Crypt.CaesarEncrypt(message, shift);
            Assert.Equal("������! Khoor!", result);
            Assert.Equal(message, Crypt.CaesarDecrypt(result, shift));
        }
        [Fact]
        public void AtbashTest()
        {
            string message = "������! Hello!";
            string result = Crypt.AtbashTransform(message);
            Assert.Equal("������! Svool!", result);
            Assert.Equal(message, Crypt.AtbashTransform(result));
        }
    }
}