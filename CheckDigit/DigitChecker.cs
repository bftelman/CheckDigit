namespace CheckDigit
{
    public class DigitChecker
    {
        public static bool Check(string cardNumber)
        {
            var splitCardNumber = SplitNumber(cardNumber);
            var sumOdd = SumOdd(splitCardNumber);

            var sumEven = SumEven(splitCardNumber);

            if ((sumOdd + sumEven) % 10 == 0)
            {
                return true;
            }

            return false;
        }

        private static int[] SplitNumber(string cardNumber)
        {
            var res = new List<int>();
            for (int i = 0; i < cardNumber.Length; i++)
            {
                var parsedInt = cardNumber[i] - '0';
                res.Add(parsedInt);
            }

            res.Reverse();

            return [.. res];
        }

        private static int SumOdd(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i += 2)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static int SumEven(int[] numbers)
        {
            int sum = 0;
            for (int i = 1; i < numbers.Length; i += 2)
            {
                var tmp = numbers[i] * 2;
                if (tmp >= 10)
                {
                    sum += tmp / 10 + tmp % 10;
                }
                else
                {
                    sum += tmp;
                }
            }

            return sum;
        }
    }
}
