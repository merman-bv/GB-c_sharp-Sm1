// Ожидавем ввод челого числа
Console.WriteLine("Жду целое число:");
int num = int.Parse(Console.ReadLine() ?? "");
if (num == 0) return;
// У нас число положительное, исключим ошибку
num = Math.Abs(num);
int cur = -num;
while (cur <= num)
{
    Console.Write($"{cur} ");
    cur = cur + 1;
}

