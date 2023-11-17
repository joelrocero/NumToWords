namespace NumToWords.Helpers
{
    public static class NumToWordsConverter
    {
        public static string NumberToWords(int number)
        {

            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            var words = "";

            int numLength = number.ToString().Length;

            if (number / 1000000000 > 0)
            {
                words += NumberToWords(number / 1000000000) + $" billion {(numLength == 6 ? "and" : "")} ";
                number %= 1000000000;
            }

            if (number / 1000000 > 0)
            {
                words += NumberToWords(number / 1000000) + $" million {(numLength == 5 ? "and" : "")} ";
                number %= 1000000;
            }

            if (number / 1000 > 0)
            {
                words += NumberToWords(number / 1000) + $" thousand {(numLength == 4 ? "and" : "")} ";
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                words += NumberToWords(number / 100) + $" hundred {(numLength == 3 ? "and" : "")} ";
                number %= 100;
            }




            words = SmallNumberToWord(number, words);

            return words;
        }

        public static string SmallNumberToWord(int number, string words)
        {
            if (number <= 0) return words;
            if (words != "")
                words += " ";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
            return words;
        }
    }
}
