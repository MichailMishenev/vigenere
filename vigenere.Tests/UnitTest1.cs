namespace vigenere.Tests
{
    public class VigenereTests
    {
        [Fact]
        public void VigenereTest()
        {
            string message = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z А Б В Г Д Е Ё Ж З И Й К Л М Н О П Р С Т У Ф Х Ц Ч Ш Щ Ъ Ы Ь Э Ю Я";
            string key = "abcабв";
            string result = Crypt.VigenereEncrypt(message, key);
            Assert.Equal("B D F E G I H J L K M O N P R Q S U T V X W Y A Z B Г В Д Ё Е Ж И З Й Л К М О Н П С Р Т Ф У Х Ч Ц Ш Ъ Щ Ы Э Ь Ю А Я Б", result);
            Assert.Equal(message, Crypt.VigenereDecrypt(result, key));
        }

        [Fact]
        public void CaesarTest()
        {
            string message = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z А Б В Г Д Е Ё Ж З И Й К Л М Н О П Р С Т У Ф Х Ц Ч Ш Щ Ъ Ы Ь Э Ю Я";
            int shift = 3;
            string result = Crypt.CaesarEncrypt(message, shift);
            Assert.Equal("D E F G H I J K L M N O P Q R S T U V W X Y Z A B C Г Д Е Ё Ж З И Й К Л М Н О П Р С Т У Ф Х Ц Ч Ш Щ Ъ Ы Ь Э Ю Я А Б В", result);
            Assert.Equal(message, Crypt.CaesarDecrypt(result, shift));
        }

        [Fact]
        public void AtbashTest()
        {
            string message = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z А Б В Г Д Е Ё Ж З И Й К Л М Н О П Р С Т У Ф Х Ц Ч Ш Щ Ъ Ы Ь Э Ю Я";
            string result = Crypt.AtbashTransform(message);
            Assert.Equal("Z Y X W V U T S R Q P O N M L K J I H G F E D C B A Я Ю Э Ь Ы Ъ Щ Ш Ч Ц Х Ф У Т С Р П О Н М Л К Й И З Ж Ё Е Д Г В Б А", result);
            Assert.Equal(message, Crypt.AtbashTransform(result));
        }
    }
}