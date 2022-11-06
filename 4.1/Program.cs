//Миронова Анастасия 22-ИСП-2/1
//4.1 Вариант 4
//Уровень Сложный

char[] binNum = { '1', '0', '0', '1', '1', '0', '0', '1', '.', '1', '0', '1', };
int dot_index = Array.IndexOf(binNum, '.');

double result = 0;
for (int i = 0; i < dot_index; i++)
{
    if (binNum[i].Equals('1'))
    {
        result += Math.Pow(2, dot_index - 1 - i);
        Console.WriteLine(Math.Pow(2, dot_index - 1 - i));
    }
}

for (int i = dot_index + 1; i < binNum.Length; i++)
{
    if (binNum[i].Equals('1'))
    {
        result += Math.Pow(2, -i + dot_index);
        Console.WriteLine(Math.Pow(2, -i + dot_index));
    }
}

Console.WriteLine(result);