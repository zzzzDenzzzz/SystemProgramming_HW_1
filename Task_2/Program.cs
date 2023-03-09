/*Разработайте приложение, которое умеет запускать дочерний процесс. В зависимости от выбора пользователя 
родительское приложение должно ожидать завершения дочернего процесса и отображать код завершения либо 
принудительно завершать работу дочернего процесса.*/

using System.Diagnostics;

Console.WriteLine("Enter W or K");
ConsoleKey key = Console.ReadKey().Key;

StartProcess("notepad", key);

static void StartProcess(string fileName, ConsoleKey key)
{
    Process process = new();

    process.StartInfo.FileName = fileName;
    process.Start();

    if (key == ConsoleKey.W)
    {
        process.WaitForExit();
    }

    if (key == ConsoleKey.K)
    {
        Thread.Sleep(5000);
        process.Kill();
    }

    Console.WriteLine($"Process exit code: {process.ExitCode}");
}
