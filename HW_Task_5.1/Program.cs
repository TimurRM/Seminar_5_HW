// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


internal class Program
{
    private static void Main(string[] args)
    {
        int[] CreateRandomArray(int start, int end)
        {
            int[] RandomArray = new int[12];
            for (int i = 0; i < 12; i++)
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


        int[] myRandomArray = CreateRandomArray(99, 1000);

        int positiveNumbers(int[] array)
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

        int evenNum = positiveNumbers(myRandomArray);
        Console.WriteLine($" -> {evenNum}");
    }
}