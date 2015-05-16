
namespace CaptchaLibrary
{
    public class CaptchaService
    {
        private IRandomNumber randomizer;
        public CaptchaService(IRandomNumber randomizer)
        {
            this.randomizer = randomizer;
        }
        public string GetCaptcha()
        {
            Captcha captcha = new Captcha(randomizer.GetPattern(), randomizer.GetLeftOperand(), randomizer.GetOperator(), randomizer.GetRightOperand());
            return captcha.ToString();
        }
    }
}
