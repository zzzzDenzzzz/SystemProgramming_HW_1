using SearchWord_Task_4;

Console.WriteLine($"result = {SearchWordClass.Search(args)}");

foreach (var arg in args)
{
    Console.WriteLine($"arg = {arg}");
}
