// Покажем последную цифру числа
Console.WriteLine("Жду число:");
int number = int.Parse(Console.ReadLine() ?? "");
int result = number % 10;
Console.WriteLine($"Последняя цивра это - {result}");
