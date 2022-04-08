using NUnit.Framework;


namespace ReversedKataTest
{
    [TestFixture]
    public class Tests
    {
        // Testing if a word gets reversed.
        [Test]
        public void Solution_DoesStringReverse()
        {
            Assert.AreEqual("dlrow", Kata.Solution("world"));
        }

        // Testing if a number gets reversed.
        [Test]
        public void Solution_DoIntegersReverse()
        {
            Assert.AreEqual("54321", Kata.Solution("12345"));
        }

        // Testing if a sentence gets reversed.
        [Test]
        public void Solution_DoesSentenceReverse()
        {
            Assert.AreEqual("dnuor si dlrow ehT", Kata.Solution("The world is round"));
        }
    }
}