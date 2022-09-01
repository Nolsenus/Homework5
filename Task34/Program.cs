int[] RandomThreeDigitArray(int size) {
    int[] result = new int[size];
    for (int i = 0; i < size; ++i) {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

void PrintArray(int[] array) {
    for(int i = 0; i < array.Length - 1; ++i) {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int CountEven(int[] array) {
    int count = 0;
    foreach (int i in array) {
        if (i % 2 ==0) {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размер массива (натуральное число): ");
try{
    int size = Convert.ToInt32(Console.ReadLine());
    if (size > 0) {
        int[] array = RandomThreeDigitArray(size);
        PrintArray(array);
        Console.WriteLine($"Количество чётных элементов - {CountEven(array)}");
    } else {
        Console.WriteLine("Вы ввели не натуральное число.");
    }
} catch {
    Console.WriteLine("Вы ввели не целое число.");
}