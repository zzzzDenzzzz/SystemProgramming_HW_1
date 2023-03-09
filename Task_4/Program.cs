/*Разработайте приложение, которое умеет запускать дочерний процесс и передавать ему аргументы командной 
строки. В качестве аргументов должны быть путь к файлу и слово для поиска. Например, аргументы:
 ■ E:\someFolder;
 ■ bicycle.
Дочерний процесс должен отобразить количество раз, сколько слово bicycle встречается в файле.*/

using System.Diagnostics;

string path = @"D:\c_sharp\SystemProgramming_HW_1\Task_4\Text\TextDoc.txt";
string word = "word";

Process.Start(new ProcessStartInfo
{
    FileName = @"D:\c_sharp\SystemProgramming_HW_1\SearchWord\bin\Debug\net7.0\SearchWord_Task_4.exe",
    ArgumentList = { path, word }
})!.WaitForExit();