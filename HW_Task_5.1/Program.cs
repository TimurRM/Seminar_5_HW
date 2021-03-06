// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


internal class Program
{
    private static void Main(string[] args)
    {
Console.WriteLine();        
        int[] CreateRandomArray(int start, int end)
        {
            int[] RandomArray = new int[10];
            for (int i = 0; i < 10; i++)
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


        int[] myRandomArray = CreateRandomArray(100, 1000);

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
        Console.WriteLine($" -> {evenNum} (quantity of even numbers in array) - 1-st task");
        Console.WriteLine();
        Console.ReadKey();
        Console.Clear();
    }
}