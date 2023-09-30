int factorial(int num) {
    int sum = 1;
    for(int i = 1; i <= num; i++) {
        checked {
            sum *= i;
        }
    }
    return sum;
}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{A} -> {factorial(A)}");