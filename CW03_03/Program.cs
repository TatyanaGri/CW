/*
Упорядочеванние данных внутри массива
алгоритм сортировки данных внутри массива.
допустим есть набор чисел 6 8 3 2 1 4 5 7 
нам нужно взятьпервое число и найти минимально и поменять с 
выделенным элементом, и так далее, на затрагивая уже 
отсортированные элементы массива */

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosotion = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosotion]) minPosotion = j;
        }

        int tempoarry = array[i];
        array[i] = array [minPosotion];
        array[minPosotion] = tempoarry;
    }
    Console.WriteLine();
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);