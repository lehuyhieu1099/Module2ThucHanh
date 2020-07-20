using System;
using System.Collections.Generic;
using System.Text;

namespace Searching_and_Sort
{
    public class MyArray
    {
        public int[] CrerateArray(int size)
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(30, 60);
            }
            return arr;
        }
        public bool IsSymmetryArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] == arr[arr.Length - 1 - i])
                {
                    return true;
                }
            }
            return false;
        }
        public int[] SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currentMin = arr[i];
                int currentMinIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentMin > arr[j])
                    {
                        currentMin = arr[j];
                        currentMinIndex = j;
                    }
                }
                if (currentMinIndex != i)
                {
                    arr[currentMinIndex] = arr[i];
                    arr[i] = currentMin;
                }
            }
            return arr;
        }
        public bool IsSortedArray(int[] arr,int upordown)
        {
            if (upordown == 1)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] >= arr[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            } else if (upordown == -1)
            {
                for(int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] <= arr[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public string Find(int[] arr, int number)
        {
            if (IsSortedArray(arr,1) && IsSortedArray(arr, 1))
            {
                int low = 0;
                int high = arr.Length - 1;
                while (high > low)
                {
                    int mid = (low + high) / 2;
                    if (number < arr[mid])
                        high = mid - 1;
                    else if (number == arr[mid])
                        return $"{mid}";
                    else
                        low = mid + 1;
                }
                return "Not found!";
            } 
            return "This array has not been sorted!!";
        }
        public void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }
        

    }
}
