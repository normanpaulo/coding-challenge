using CodingChallenge;

namespace CodingChallengeTest
{
    [TestFixture]
    public class CodingChallengeUnitTest
    {
        [TestCase("<>", true)]
        [TestCase("><", false)]
        [TestCase("<<>", false)]
        [TestCase("", true)]
        [TestCase("<abc...xyz>", true)]
        public void HasMatchingBrackets_UnitTest(string input, bool expectedResult)
        {
            bool actualResult = Lib.HasMatchingBrackets(input);

            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }
    }
}