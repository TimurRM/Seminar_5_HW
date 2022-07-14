
internal class Program
{
    private static void Main(string[] args)
    {
Console.WriteLine();        
        int[] CreateRandomArray(int start, int end)
        {
            int[] RandomArray = new int[6];
            for (int i = 0; i < 6; i++)
            {
                RandomArray[i] = new Random().Next(start, end);
            }
            return RandomArray;
        }


        void ShowArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.Write(array[i]);
                }

            }
            Console.Write("]");
        }


        int[] myRandomArray = CreateRandomArray(1, 20);
        
        int EvenNumbers(int[] array)
        {
            int evenNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenNumbers++;
                }
            }
            return evenNumbers;
        }

        ShowArray(myRandomArray);

        int evenNum = EvenNumbers(myRandomArray);
        Console.WriteLine($" -> {evenNum} (quantity of even numbers in array) 1-st task");

Console.WriteLine();

        int OddPositionNumbers(int[] array)
        {
            int oddPositionNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddPositionNumber += myRandomArray[i];
                }
            }
            return oddPositionNumber;
        }

        ShowArray(myRandomArray);

        int oddSum = OddPositionNumbers(myRandomArray);
        Console.WriteLine($" -> {oddSum} (sum of elements in odd positions) 2-nd task");

 Console.WriteLine();       

        int Difference(int[] array)
        {
            int maxNum = myRandomArray[0];
            int minNum = myRandomArray[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (maxNum < myRandomArray[i])
                    {
                    maxNum = myRandomArray[i];
                    }
                if (minNum > myRandomArray[i])
                    {
                    minNum = myRandomArray[i];
                    }
        }
            int decision = maxNum - minNum;

            return decision;
        }

        ShowArray(myRandomArray);

        int difference  = Difference(myRandomArray);
        Console.WriteLine($" -> {difference } (difference between max and min values of array elements) - 3-rd task");

        Console.WriteLine();
        Console.ReadKey();
        Console.Clear();
    }
}