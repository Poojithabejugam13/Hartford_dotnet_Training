namespace Arrays
{
    using System;
    class Program
    {
        static void Main()
        {
            // 1. Declare and initialize array
            int[] arr = { 10, 20, 30, 20, 40 };
            Console.WriteLine("Original Array:");
            PrintArray(arr);
            // 2. Length
            Console.WriteLine("\nLength of array: " + arr.Length);
            // 3. Sort
            Array.Sort(arr);
            Console.WriteLine("\nAfter Sorting:");
            PrintArray(arr);
            // 4. Reverse
            Array.Reverse(arr);
            Console.WriteLine("\nAfter Reversing:");
            PrintArray(arr);
            // 5. IndexOf
            int firstIndex = Array.IndexOf(arr, 20);
            Console.WriteLine("\nFirst Index of 20: " + firstIndex);

            // 6. LastIndexOf
            int lastIndex = Array.LastIndexOf(arr, 20);
            Console.WriteLine("Last Index of 20: " + lastIndex);

            // 7. Exists
            bool exists = Array.Exists(arr, x => x == 30);
            Console.WriteLine("Does 30 exist? " + exists);

            // 8. Find
            int firstGreater = Array.Find(arr, x => x > 25);
            Console.WriteLine("First element > 25: " + firstGreater);

            // 9. FindAll
            int[] greaterThan20 = Array.FindAll(arr, x => x > 20);
            Console.WriteLine("Elements > 20:");
            PrintArray(greaterThan20);

            // 10. Copy
            int[] copiedArray = new int[arr.Length];
            Array.Copy(arr, copiedArray, arr.Length);
            Console.WriteLine("\nCopied Array:");
            PrintArray(copiedArray);

            // 11. BinarySearch (array must be sorted)
            Array.Sort(arr);
            int searchIndex = Array.BinarySearch(arr, 30);
            Console.WriteLine("\nBinary Search index of 30: " + searchIndex);

            // 12. Clear
            Array.Clear(arr, 0, arr.Length);
            Console.WriteLine("\nAfter Clear:");
            PrintArray(arr);
        }

       
        static void PrintArray(int[] array)
        {
            foreach (int x in array)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }

}
