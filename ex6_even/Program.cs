// Ждем число
Console.WriteLine("Жду число: ");
int numTest = int.Parse(Console.ReadLine () ?? "");
// Проверим на четность (т.е деление на два без остатка)
if (numTest % 2 == 0 ) Console.WriteLine($"Число: {numTest} - Четное"); 
else Console.WriteLine($"Число: {numTest} - Нечетное");  
    

// Примеры для проверки
//      4 -> да
//      -3 -> нет
//      7 -> нет
