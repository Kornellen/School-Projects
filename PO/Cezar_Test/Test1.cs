namespace Cezar_Test
{
    [TestClass]
    public sealed class Test1
    {

        [TestMethod]
        public void BasicData()
        {
            Assert.AreEqual("def", Cezar.Cezar.Szyfruj("abc", 3));
        }

        [TestMethod]
        public void Wrapping()
        {
            Assert.AreEqual("abc", Cezar.Cezar.Szyfruj("xyz", 3));
        }

        [TestMethod]
        public void Deciphering()
        {
            Assert.AreEqual("abc", Cezar.Cezar.Szyfruj("def", -3));
        }

        [TestMethod]
        public void ShiftBiggerThanAlphabetLenght()
        {
            Assert.AreEqual("def", Cezar.Cezar.Szyfruj("abc", 29));
        }

        [TestMethod]
        public void SpaceInRaw()
        {
            Assert.AreEqual("cd ef", Cezar.Cezar.Szyfruj("ab cd", 2));
        }
    }
}
