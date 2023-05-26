namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        ArrayProblems.Swap(array, i, j);
                    }
                }
            }
        }

        public static void MySort2(int[] array)
        {
            var current = array.ToList();
            var result = new List<int>();
            while (current.Count > 0)
            {
                var x = current.Min();
                result.Add(x);
                current.Remove(x);
            }
            result.CopyTo(array);
        }

        public static void MergeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void HeapSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BubbleSort(int[] array)
        {
            bool swapped;
            var n = array.Length;
            do
            {
                swapped = false;

                for (var i = 1; i < n; ++i)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i-1, i);
                        swapped = true;
                    }
                }

                --n;
            } 
            while (swapped && n > 0);
        }

        public static void ShuffleSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void IntroSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void CocktailSort(int[] a)
        {
            bool swapped = true;
            int start = 0;
            int end = a.Length;

            while (swapped == true)
            {

                // reset the swapped flag on entering the
                // loop, because it might be true from a
                // previous iteration.
                swapped = false;

                // loop from bottom to top same as
                // the bubble sort
                for (int i = start; i < end - 1; ++i)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        swapped = true;
                    }
                }

                // if nothing moved, then array is sorted.
                if (swapped == false)
                    break;

                // otherwise, reset the swapped flag so that it
                // can be used in the next stage
                swapped = false;

                // move the end point back by one, because
                // item at the end is in its rightful spot
                end = end - 1;

                // from top to bottom, doing the
                // same comparison as in the previous stage
                for (int i = end - 1; i >= start; i--)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        swapped = true;
                    }
                }

                // increase the starting point, because
                // the last stage would have moved the next
                // smallest number to its rightful spot.
                start = start + 1;
            }
        }
        

        public static void QuickSort(int[] array)
        {
            static void swap(int[] arr, int i, int j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            // This function takes last element as pivot,
            // places the pivot element at its correct position
            // in sorted array, and places all smaller to left
            // of pivot and all greater elements to right of pivot
            static int partition(int[] arr, int low, int high)
            {
                // Choosing the pivot
                int pivot = arr[high];

                // Index of smaller element and indicates
                // the right position of pivot found so far
                int i = (low - 1);

                for (int j = low; j <= high - 1; j++)
                {

                    // If current element is smaller than the pivot
                    if (arr[j] < pivot)
                    {

                        // Increment index of smaller element
                        i++;
                        swap(arr, i, j);
                    }
                }
                swap(arr, i + 1, high);
                return (i + 1);
            }

            static void quickSort(int[] arr, int low, int high)
            {
                if (low < high)
                {

                    // pi is partitioning index, arr[p]
                    // is now at right place
                    int pi = partition(arr, low, high);

                    // Separately sort elements before
                    // and after partition index
                    quickSort(arr, low, pi - 1);
                    quickSort(arr, pi + 1, high);
                }
            }
        }

        public static void BlockSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BogoSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void DoNothingSort(int[] array)
        {
        }

        public static void EvilSort(int[] array)
        {
            Array.Fill(array, 0);
        }

        public static void GnomeSort(int[] array)
        {
            int index = 1;
            while (index < array.Length)
            {
                if (array[index] >= array[index - 1])
                    index++;
                else
                {
                    int temp = 0;
                    temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;
                    index--;
                }
            }
            return;
        }

        public static void SelectionSort(int[] array)
        {
            int n = array.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (array[j] < array[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                int temp = array[min_idx];
                array[min_idx] = array[i];
                array[i] = temp;
            }
        }
    }
}
