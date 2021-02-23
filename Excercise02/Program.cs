using System;
using Fei.BaseLib;

namespace Excercise02
{


    class Program
    {
        private static int PrintMenu()
        {
            Console.WriteLine("\nPress 1 for new array");
            Console.WriteLine("Press 2 for display array");
            Console.WriteLine("Press 3 for ascending sort of array");
            Console.WriteLine("Press 4 for descending sort of array");
            Console.WriteLine("Press 5 for find min in array");
            Console.WriteLine("Press 6 for find max in array");
            Console.WriteLine("Press 7 for find first occurence of entered value in array");
            Console.WriteLine("Press 8 for find last occurence of entered value in array");
            Console.WriteLine("Press 9 for exit\n");
            return Reading.ReadInt("Enter your choice: ");
        }

        static void Main(string[] args)
        {
            Boolean stillContinue = true;
            int input;
            int[] array = new int[0];
            while (stillContinue)
            {
                input = PrintMenu();
                switch (input)
                {
                    case 1:
                        array = createArray();
                        break;
                    case 2:
                        printArray(array);
                        break;
                    case 3:
                        sortArrayAsc(ref array);
                        break;
                    case 4:
                        sortArrayDesc(ref array);
                        break;
                    case 5:
                        findMin(array);
                        break;
                    case 6:
                        findMax(array);
                        break;
                    case 7:
                        findFirst(array);
                        break;
                    case 8:
                        findLast(array);
                        break;
                    case 9:
                        stillContinue = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            Console.WriteLine("Goodbye");
           
        }

        private static void findMax(int[] array)
        {
            if (array.Length < 1)
            {
                Console.WriteLine("Empty array");
                return;
            }

            int max = Int32.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Max value in array is: " + max);
        }

        private static void findFirst(int[] array)
        {
            int searchedVal = Reading.ReadInt("Enter searched value: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == searchedVal)
                {
                    Console.WriteLine($"{searchedVal} found at {i + 1}. position");
                    return;
                }
            }
            Console.WriteLine($"{searchedVal} is not in array");
        }

        private static void findLast(int[] array)
        {
            int searchedVal = Reading.ReadInt("Enter searched value: ");
            for (int i = array.Length-1; i >= 0 ; i--)
            {
                if (array[i] == searchedVal)
                {
                    Console.WriteLine($"{searchedVal} found at {i + 1}. position");
                    return;
                }
            }
            Console.WriteLine($"{searchedVal} is not in array");
        }

        private static void findMin(int[] array)
        {
            if (array.Length < 1)
            {
                Console.WriteLine("Empty array");
                return;
            }

            int min = Int32.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Min value in array is: " + min);
        }

        private static void printArray(int[] array)
        {
            if(array.Length < 1)
            {
                Console.WriteLine("Empty array");
            } else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + ", ");
                }
            }
            Console.WriteLine();
        }

        private static void sortArrayAsc(ref int[] array)
        {
            if (array.Length > 2)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    bool swapped = false;
                    for (int j = i; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int tmp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = tmp;
                            swapped = true;
                        }
                    }
                    for (int j = array.Length - 2 - i; j > i; j--)
                    {
                        if (array[j] < array[j -1] )
                        {
                            int tmp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = tmp;
                            swapped = true;
                        }
                    }
                    if (!swapped) break;
                }
            }
            Console.WriteLine("Array sorted");
        }

        private static void sortArrayDesc(ref int[] array)
        {
            if (array.Length > 2)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    bool swapped = false;
                    for (int j = i; j < array.Length - i - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int tmp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = tmp;
                            swapped = true;
                        }
                    }
                    for (int j = array.Length - 2 - i; j > i; j--)
                    {
                        if (array[j] > array[j - 1])
                        {
                            int tmp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = tmp;
                            swapped = true;
                        }
                    }
                    if (!swapped) break;
                }
            }
            Console.WriteLine("Array sorted");
        }



        private static int[] createArray()
        {
            int size = Reading.ReadInt(1, "Enter size of array: ");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Reading.ReadInt("Enter "+(i+1)+". element of array : ");
            }
            return arr;
        }
    }
}
