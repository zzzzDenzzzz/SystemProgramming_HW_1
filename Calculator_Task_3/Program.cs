using Calculator_Task_3;

Console.WriteLine($"result = {CalculatorClass.Calculate(args)}{Environment.NewLine}");

foreach (var arg in args)
{
    Console.WriteLine($"arg = {arg}");
}
