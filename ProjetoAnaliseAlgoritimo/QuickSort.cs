using System;

namespace ProjetoAnaliseAlgoritimo
{
    public class QuickSort
    {
        public static int Comparisons { get; private set; } = 0;
        public static int Swaps { get; private set; } = 0;

        public static void Sort(int[] array)
        {
            Comparisons = 0; // Resetando contador
            Swaps = 0;       // Resetando contador
            QuickSortRecursive(array, 0, array.Length - 1);
        }

        private static void QuickSortRecursive(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSortRecursive(array, low, pivotIndex - 1);
                QuickSortRecursive(array, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                Comparisons++; // Incrementa comparações
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);
            return i + 1;
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i != j) // Apenas conta swaps se os índices forem diferentes
            {
                Swaps++; // Incrementa swaps
            }
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
