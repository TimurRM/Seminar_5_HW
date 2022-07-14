// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


internal class Program
{
    private static void Main(string[] args)
    {
Console.WriteLine();        
        int[] CreateRandomArray(int start, int end)
        {
            int[] RandomArray = new int[4];
            for (int i = 0; i < 4; i++)
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


        int[] myRandomArray = CreateRandomArray(-9, 9);

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
        Console.WriteLine($" -> {oddSum} (sum of elements in odd positions) - 2-nd task");
        Console.WriteLine();
        Console.ReadKey();
        Console.Clear();
    
    }
}
