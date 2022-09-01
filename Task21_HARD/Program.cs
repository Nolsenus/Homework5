double GetDistance(double[] pointA, double[] pointB) {
    double sum = 0;
    for (int i = 0; i < pointA.Length; ++i) {
        sum += (pointA[i] - pointB[i]) * (pointA[i] - pointB[i]);
    }
    return Math.Sqrt(sum);
}

void PrintPoint(double[] point) {
    Console.Write("{");
    for (int i = 0; i < point.Length - 1; ++i) {
        Console.Write($"{point[i]}, ");
    }
    Console.WriteLine(point[point.Length - 1] + "}");
}

Console.Write("Введите натуральное число - размерность пространства: ");
try {
    int N = Convert.ToInt32(Console.ReadLine());
    if (N > 0){
        double[] pointA = new double[N];
        for (int i = 0; i < N; ++i) {
            Console.Write($"Введите {i + 1}-ю координату точки А: ");
            pointA[i] = Convert.ToDouble(Console.ReadLine());
        }
        double[] pointB = new double[N];
        for (int i = 0; i < N; ++i) {
            Console.Write($"Введите {i + 1}-ю координату точки B: ");
            pointB[i] = Convert.ToDouble(Console.ReadLine());
        }
        PrintPoint(pointA);
        PrintPoint(pointB);
        Console.WriteLine(GetDistance(pointA, pointB));
    } else {
        Console.WriteLine("Вы ввели не натурально число.");
    }
} catch {
    Console.WriteLine("Вы ввели что-то не то.");
}