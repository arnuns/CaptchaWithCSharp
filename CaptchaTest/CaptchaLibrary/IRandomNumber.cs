
namespace CaptchaLibrary
{
    public interface IRandomNumber
    {
        int GetPattern();

        int GetRightOperand();

        int GetOperator();

        int GetLeftOperand();
    }

}
