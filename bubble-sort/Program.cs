using System;

namespace bubble_sort
{
    class Program
    {
        static int[] bubbleSort(int[] arr) {
          int n = arr.Length;
          for(int i=0; i<n-1; i++) {
            for(int j=0; j<n-i-1; j++) {
              if(arr[j]>arr[j+1]) {
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
              }
            }
          }
          return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = {4, 3, 5, 1, 2};
            int[] res = bubbleSort(arr);
            foreach(int i in res) {
              Console.WriteLine(i);
            }
        }
    }
}
