using Lab1Sadik;

double Calculate(double input, Calculation calc1, Calculation calc2)
{
    double result = calc1.Perform(input);
    result = calc2.Perform(result);
    return result;
}

Console.WriteLine("Введите начальное число: ");
double inputNumber = double.Parse(Console.ReadLine());

Console.WriteLine("Введите величину на которое нужно увеличить число");
Add addOperation = new Add(3.0);

Console.WriteLine("Введите коэффициент на который нужно умножить число");
Multiply multiplyOperation = new Multiply(2.0);

// Вызываем функцию Calculate
double result = Calculate(inputNumber, addOperation, multiplyOperation);
