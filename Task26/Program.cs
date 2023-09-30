// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int CountOfNumber(int num) {
    if(num == 0) return 1;
    int count = 0;
    while(num != 0) {
        num /= 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{A} -> {CountOfNumber(A)}");
