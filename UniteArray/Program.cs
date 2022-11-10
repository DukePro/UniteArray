using System;

namespace Programm
{
    class MyProgramm
    {
        static void Main()
        {
            int[] array1 = new int[] { 1, 2, 1, 3, 4 };
            int[] array2 = new int[] { 1, 4, 7, 8, 0 };
            List<int> list = new List<int>();
            AddArrayToList(list, array1);
            AddArrayToList(list, array2);
            DisplayList(list);
        }

        static void AddArrayToList(List<int>list, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (list.Contains(array[i]) == false)
                {
                    list.Add(array[i]);
                }
            }
        }

        static void DisplayList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item);
            }
        }
    }
}