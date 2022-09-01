int[] RandomArray(int size) {
    int[] result = new int[size];
    for (int i = 0; i < size; ++i) {
        result[i] = new Random().Next(-100, 101);
    }
    return result;
}

void PrintArray(int[] array) {
    for(int i = 0; i < array.Length - 1; ++i) {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int SumOfOddIndex(int[] array) {
    int count = 0;
    for (int i = 1; i < array.Length; i += 2) {
        count += array[i];
    }
    return count;
}

Console.Write("Введите размер массива (натуральное число): ");
try {
    int size = Convert.ToInt32(Console.ReadLine());
    if (size > 0) {
        int[] array = RandomArray(size);
        PrintArray(array);
        Console.WriteLine($"Сумма элементов с нечётными индексами - {SumOfOddIndex(array)}");
    } else {
        Console.WriteLine("Вы ввели не натуральное число.");
    }
} catch {
    Console.WriteLine("Вы ввели не целое число.");
}