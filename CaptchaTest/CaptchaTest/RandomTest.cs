using CaptchaLibrary;
using NSubstitute;
using NUnit.Framework;

namespace CaptchaTest
{
    [TestFixture]
    public class RandomTest
    {

        [Test]
        public void RandomPattern_ShouldBeInRangeONEandTWO_WhenOutPutPatternIs1()
        {
            var substitute = Substitute.For<IRandomNumber>();
            substitute.GetPattern().Returns(1);
            Assert.That(substitute.GetPattern(), Is.InRange(1, 2));
        }

        [Test]
        public void RandomPattern_ShouldBeThrownInvalidRangeException_WhenOutPutPatternIs3()
        {
            var substitute = Substitute.For<IRandomNumber>();
            substitute.GetPattern().Returns(x => { throw new InvalidRangeException(); });
            Assert.Throws(typeof(InvalidRangeException),
                delegate { substitute.GetPattern(); });
        }

        //[Test]
        //public void RandomOperand_ShouldBePASS_WhenRecieveNumberBetweenONEAndNINE()
        //{
        //    RandomNumber randomNumber = new RandomNumber();
        //    Assert.That(randomNumber.GetOperand(), Is.InRange(1, 9));
        //}

        //[Test]
        //public void RandomOperator_ShouldBePASS_WhenRecieveNumberBetweenONEAndTHREE()
        //{
        //    RandomNumber randomNumber = new RandomNumber();
        //    Assert.That(randomNumber.GetOperator(), Is.InRange(1, 3));
        //}
    }
}
