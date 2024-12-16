using System;

class OptimizedSortExample
{
    // Оптимизированная пузырьковая сортировка с проверкой
    static void OptimizedBubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Обмен элементов
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // Если элементы не обменивались, массив уже отсортирован
            if (!swapped) break;
        }
    }

    static void Main(string[] args)
    {
        int[] data = { 64, 34, 25, 12, 22, 11, 90 };
        Console.WriteLine("Исходный массив:");
        Console.WriteLine(string.Join(", ", data));

        OptimizedBubbleSort(data);

        Console.WriteLine("Отсортированный массив:");
        Console.WriteLine(string.Join(", ", data));
    }
}

