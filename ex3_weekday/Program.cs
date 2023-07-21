// Ввод номера дня недели
Console.WriteLine("Жду номер дня недели:");
int numWeekday = int.Parse(Console.ReadLine() ?? "");
string weekday = "неверный";

// Начнем проверки
    if (numWeekday == 1) weekday = "Понедельник";
    else if (numWeekday == 2) weekday = "Вторник";
    else if (numWeekday == 3) weekday = "Среда";
    else if (numWeekday == 4) weekday = "Четверг";
    else if (numWeekday == 5) weekday = "Пятница";
    else if (numWeekday == 6) weekday = "Суббота";
    else if (numWeekday == 7) weekday = "Воскресенье";


Console.WriteLine(weekday);