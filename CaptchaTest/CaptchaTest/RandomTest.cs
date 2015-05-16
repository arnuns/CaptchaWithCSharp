using CaptchaLibrary;
using NSubstitute;
using NUnit.Framework;

namespace CaptchaTest
{
    [TestFixture]
    public class RandomTest
    {
        [Test]
        public void RandomLeftOperand_ShouldBePASS_WhenRecieveNumberBetweenONEAndNINE()
        {
            RandomNumber randomNumber = new RandomNumber();
            Assert.That(randomNumber.GetRightOperand(), Is.InRange(1, 9));
        }

        [Test]
        public void RandomRightOperand_ShouldBePASS_WhenRecieveNumberBetweenONEAndNINE()
        {
            RandomNumber randomNumber = new RandomNumber();
            Assert.That(randomNumber.GetRightOperand(), Is.InRange(1, 9));
        }

        [Test]
        public void RandomOperator_ShouldBePASS_WhenRecieveNumberBetweenONEAndTHREE()
        {
            RandomNumber randomNumber = new RandomNumber();
            Assert.That(randomNumber.GetOperator(), Is.InRange(1, 3));
        }
    }
}
