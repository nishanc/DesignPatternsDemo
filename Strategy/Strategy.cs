namespace DesignPatternsDemo.Strategy
{
    // Define the Strategy Interface
    public interface ISortingStrategy
    {
        void Sort(List<int> numbers);
    }

    // Implement Different Sorting Strategies

    #region BubbleSort

    public class BubbleSort : ISortingStrategy
    {
        public void Sort(List<int> numbers)
        {
            Console.WriteLine("Sorting using Bubble Sort...");
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
    }


    #endregion

    #region QuickSort

    public class QuickSort : ISortingStrategy
    {
        public void Sort(List<int> numbers)
        {
            Console.WriteLine("Sorting using Quick Sort...");
            QuickSortHelper(numbers, 0, numbers.Count - 1);
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

    #endregion

    // Create Context Class: This class will delegate the sorting task to the selected strategy.
    public class Sorter
    {
        private ISortingStrategy _sortingStrategy;

        // Constructor allows setting a default strategy
        public Sorter(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        // Method to change the strategy at runtime
        public void SetStrategy(ISortingStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        // Method to sort using the selected strategy
        public void SortNumbers(List<int> numbers)
        {
            _sortingStrategy.Sort(numbers);
        }
    }
}
