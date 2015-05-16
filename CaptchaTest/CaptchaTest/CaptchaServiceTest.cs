using CaptchaLibrary;
using NSubstitute;
using NUnit.Framework;

namespace CaptchaTest
{
    [TestFixture]
    public class CaptchaServiceTest
    {
        [Test]
        public void GetCaptchaPatternONE_ShouldBeONEPlus1_WhenRandomIs1111()
        {
            CaptchaService captchaService = StubRandomNumberCaptcha(1, 1, 1, 1);
            Assert.AreEqual("ONE+1", captchaService.GetCaptcha());
        }

        [Test]
        public void GetCaptchaPatternONE_ShouldBeONEPlus9_WhenRandomIs1119()
        {
            CaptchaService captchaService = StubRandomNumberCaptcha(1, 1, 1, 9);
            Assert.AreEqual("ONE+9", captchaService.GetCaptcha());
        }

        [Test]
        public void GetCaptchaPatternTWO_ShouldBe1PlusONE_WhenRandomIs2111()
        {
            CaptchaService captchaService = StubRandomNumberCaptcha(2, 1, 1, 1);
            Assert.AreEqual("1+ONE", captchaService.GetCaptcha());
        }

        [Test]
        public void GetCaptchaPatternTWO_ShouldBe1PlusNINE_WhenRandomIs2119()
        {
            CaptchaService captchaService = StubRandomNumberCaptcha(2, 1, 1, 9);
            Assert.AreEqual("1+NINE", captchaService.GetCaptcha());
        }

        [Test]
        public void GetCaptchaPatternTWO_ShouldBe9MinusNINE_WhenRandomIs2939() 
        {
            CaptchaService captchaService = StubRandomNumberCaptcha(2, 9, 3, 9);
            Assert.AreEqual("9-NINE", captchaService.GetCaptcha());
        }

        private CaptchaService StubRandomNumberCaptcha(int pattern, int leftOperand, int operatorType, int rightOperand)
        {
            var stub = Substitute.For<IRandomNumber>();
            stub.GetPattern().Returns(pattern);
            stub.GetLeftOperand().Returns(leftOperand);
            stub.GetOperator().Returns(operatorType);
            stub.GetRightOperand().Returns(rightOperand);
            return new CaptchaService(stub);
        }
    }
}
