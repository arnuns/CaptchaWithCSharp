﻿using System;
namespace CaptchaLibrary
{
    public class RandomNumber : IRandomNumber
    {
        private Random random;
        public RandomNumber()
        {
            random = new Random();
        }

        public int GetPattern()
        {
            return random.Next(1, 3);
        }

        public int GetLeftOperand()
        {
            return random.Next(1, 10);
        }

        public int GetRightOperand()
        {
            return random.Next(1, 10);
        }

        public int GetOperator()
        {
            return random.Next(1, 4);
        }
    }
}
