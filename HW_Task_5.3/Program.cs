// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
        Console.WriteLine($" -> {difference} (difference between max and min values of array elements) - 3-rd task");
        Console.WriteLine();
        Console.ReadKey();
        Console.Clear();
    }
}



