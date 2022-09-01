bool IsPalindrome(int number) {
    if(number == 0) {
        return true;
    }
    if (number < 0) {
        number = -number;
    }
    bool result = true;
    while (number > 9) {
        int numberCopy = number;
        int lastDigit = number % 10;
        int firstDigit = 0;
        int order = 1;
        while (numberCopy > 0) {
            firstDigit = numberCopy % 10;
            order *= 10;
            numberCopy /= 10;
        }
        if (firstDigit != lastDigit) {
            result = false;
            break;
        }
        number -= order * firstDigit;
        number /= 10;
    }
    return result;
}

Console.Write("Введите целое число: ");
try {
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) {
        Console.WriteLine($"{number} - " + (IsPalindrome(number) ? "Палиндром" : "Не палиндром"));
    } else {
        Console.WriteLine("Вы ввели не натуральное число.");
    }
} catch {
    Console.WriteLine("Вы вввели не целое число.");
}