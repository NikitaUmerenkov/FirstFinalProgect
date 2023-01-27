string[] Array;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
Array = stroka.Split(' ');
var result = new string[Array.Length];
var realSize = 0;
foreach (var value in Array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));