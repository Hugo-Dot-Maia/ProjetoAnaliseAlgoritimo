namespace ProjetoAnaliseAlgoritimo
{
    public class QuickSortMedianOfThree
    {
        public static int Comparisons { get; private set; } = 0;
        public static int Swaps { get; private set; } = 0;

        public static void Sort(int[] array, int M)
        {
            Comparisons = 0; // Resetando contador
            Swaps = 0;       // Resetando contador
            QuickSortRecursive(array, 0, array.Length - 1, M);
        }

        private static void QuickSortRecursive(int[] array, int low, int high, int M)
        {
            while (low < high)
            {
                if (high - low + 1 < M)
                {
                    InsertionSort(array, low, high);
                    break;
                }
                else
                {
                    int pivotIndex = PartitionMedianOfThree(array, low, high);

                    if (pivotIndex - low < high - pivotIndex)
                    {
                        QuickSortRecursive(array, low, pivotIndex - 1, M);
                        low = pivotIndex + 1;
                    }
                    else
                    {
                        QuickSortRecursive(array, pivotIndex + 1, high, M);
                        high = pivotIndex - 1;
                    }
                }
            }
        }

        private static void InsertionSort(int[] array, int low, int high)
        {
            for (int i = low + 1; i <= high; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= low && array[j] > key)
                {
                    Comparisons++; // Incrementa comparações
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        private static int PartitionMedianOfThree(int[] array, int low, int high)
        {
            int medianIndex = MedianOfThree(array, low, high);
            Swap(array, medianIndex, high); // Move o pivô para o final
            return Partition(array, low, high);
        }

        private static int MedianOfThree(int[] array, int low, int high)
        {
            int mid = (low + high) / 2;

            Comparisons += 3; // Três comparações realizadas
            if (array[high] < array[low])
                Swap(array, low, high);
            if (array[mid] < array[low])
                Swap(array, mid, low);
            if (array[high] < array[mid])
                Swap(array, high, mid);

            return mid;
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
            if (i != j)
            {
                Swaps++; // Incrementa swaps
            }
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
