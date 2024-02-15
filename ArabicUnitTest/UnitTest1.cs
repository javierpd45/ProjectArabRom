namespace ArabicUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Convert_1_to_I()
        {
            var convert = new ConversorNum();
            var num = 1;

            var result = convert.ConvertArabicRoman(num);

            Assert.That(result, Is.EqualTo("I"));
        }

        [Test]
        public void Convert_3999_to_MMMCMXCIX()
        {
            var convert = new ConversorNum();
            var num = 3999;

            var result = convert.ConvertArabicRoman(num);

            Assert.That(result, Is.EqualTo("MMMCMXCIX"));
        }

        [Test]
        public void Convert_500_to_D()
        {
            var convert = new ConversorNum();
            var num = 500;

            var result = convert.ConvertArabicRoman(num);

            Assert.That(result, Is.EqualTo("D"));
        }

        [Test]
        public void Convert_1234_to_MCCXXXIV()
        {
            var convert = new ConversorNum();
            var num = 1234;

            var result = convert.ConvertArabicRoman(num);

            Assert.That(result, Is.EqualTo("MCCXXXIV"));
        }

        [Test]
        public void Convert_0_throwException()
        {
            var convert = new ConversorNum();
            var num = 0;

            

            try
            {
                var result = convert.ConvertArabicRoman(num);
            }
            catch (Exception ex)
            {

                Assert.That(ex.Message, Is.EqualTo("El numero debe estar entre 1 y 3999")); ;
            }
            
        }

        [Test]
        public void Convert_5000_throwException()
        {
            var convert = new ConversorNum();
            var num = 5000;



            try
            {
                var result = convert.ConvertArabicRoman(num);
            }
            catch (Exception ex)
            {

                Assert.That(ex.Message, Is.EqualTo("El numero debe estar entre 1 y 3999")); ;
            }

        }
    }
}