/*Разработайте приложение, которое умеет запускать дочерний процесс и ожидать его завершения.
 * Когда дочерний процесс завершен, родительское приложение должно отобразить код завершения.*/

using System.Diagnostics;

Process process = new();

process.StartInfo.FileName = "notepad";

process.Start();
process.WaitForExit();

Console.WriteLine($"Process exit code: {process.ExitCode}");
