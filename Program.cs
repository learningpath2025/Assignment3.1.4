namespace Assignment3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetInputAndOutput();
            //TestChangeConsecutiveOnesToZeros();
        }

        static void GetInputAndOutput()
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = ChangeConsecutiveOnesToZeros(arr);
            Console.WriteLine($"Output: [{string.Join(", ", result)}]");
        }

        static void TestChangeConsecutiveOnesToZeros()
        {
            int[] input = { 0, 2, 1, 1, 9, 1, 1 };
            int[] expectedOutput = { 0, 2, 0, 0, 9, 1, 1 };
            int[] actualOutput = ChangeConsecutiveOnesToZeros(input);
            if (actualOutput.SequenceEqual(expectedOutput))
            {
                Console.WriteLine("Test passed.");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }
        }

        static int[] ChangeConsecutiveOnesToZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 1 && arr[i + 1] == 1)
                {
                    arr[i] = 0;
                    arr[i + 1] = 0;
                    break; // Only change the first occurrence
                }
            }
            return arr;
        }
    }
}
