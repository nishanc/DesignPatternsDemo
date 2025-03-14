namespace DesignPatternsDemo.Examples
{
    public class Sorter
    {
        public void Sort(List<int> numbers, string algorithm)
        {
            if (algorithm == "BubbleSort")
            {
                Console.WriteLine("Sorting using Bubble Sort...");
                // Bubble sort logic here
                int n = numbers.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (numbers[j] > numbers[j + 1])
                        {
                            // Swap
                            int temp = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = temp;
                        }
                    }
                }
            }
            else if (algorithm == "QuickSort")
            {
                Console.WriteLine("Sorting using Quick Sort...");
                // Quick sort logic here
                QuickSortHelper(numbers, 0, numbers.Count - 1);
            }
            else if (algorithm == "MergeSort")
            {
                Console.WriteLine("Sorting using Merge Sort...");
                // Merge sort logic here
            }
            else
            {
                Console.WriteLine("Unknown sorting algorithm!");
            }
        }

        private void QuickSortHelper(List<int> numbers, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(numbers, low, high);
                QuickSortHelper(numbers, low, pivot - 1);
                QuickSortHelper(numbers, pivot + 1, high);
            }
        }

        private int Partition(List<int> numbers, int low, int high)
        {
            int pivot = numbers[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (numbers[j] < pivot)
                {
                    i++;
                    (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
                }
            }

            (numbers[i + 1], numbers[high]) = (numbers[high], numbers[i + 1]);
            return i + 1;
        }
    }
}
