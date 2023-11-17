using NumToWords.Helpers;

namespace NumToWords.Services
{
    public class NumbToWordsService : INumberToWordsService
    {
        public string ConvertNumberToWords(double doubleNumber)
        {
            if(doubleNumber < 0)
            {
                throw new Exception("Invalid input");
            }


            var beforeFloatingPoint = (int)Math.Floor(doubleNumber);
            var beforeFloatingPointWord = $"{NumToWordsConverter.NumberToWords(beforeFloatingPoint)} dollars";

            var afterFloatingPoint = (doubleNumber - beforeFloatingPoint) * 100;

            if(afterFloatingPoint <= 0) {
                return $"{beforeFloatingPointWord}";
            }

            var afterFloatingPointWord =
                $"{NumToWordsConverter.SmallNumberToWord((int)afterFloatingPoint, "")} cents";
            
            return $"{beforeFloatingPointWord} and {afterFloatingPointWord}";
        }



    }
}
