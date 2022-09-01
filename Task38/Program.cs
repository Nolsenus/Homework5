double[] RandomArray(int size) {
    double[] result = new double[size];
    for (int i = 0; i < size; ++i) {
        result[i] = new Random().NextDouble() * 99 + 1;
    }
    return result;
}

void PrintArray(double[] array) {
    for(int i = 0; i < array.Length - 1; ++i) {
        Console.Write($"{array[i].ToString("0.00")}, ");
    }
    Console.WriteLine(array[array.Length - 1].ToString("0.00"));
}

double MinMaxDiff(double[] array) {
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; ++i) {
        if (array[i] > max) {
            max = array[i];
        } else if (array[i] < min) {
            min = array[i];
        }
    }
    return max - min;
}

Console.Write("Введите натуральное число - размер массива: ");
try {
    int size = Convert.ToInt32(Console.ReadLine());
    if (size > 0) {
        double[] array = RandomArray(size);
        PrintArray(array);
        Console.WriteLine($"Разница между наибольшим и наименьшим элементами - {MinMaxDiff(array).ToString("0.00")}");
    } else {
        Console.WriteLine("Вы ввели не натуральное число.");
    }
} catch {
    Console.WriteLine("Вы ввели не целое число.");
}