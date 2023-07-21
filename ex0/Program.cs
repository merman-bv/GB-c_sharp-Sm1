using System.Net;


Console.WriteLine("Ожидание целого числа:");
//string  myInput = Console.ReadLine() ?? "";
//int number = int.Parse(myInput);
int number = int.Parse(Console.ReadLine() ?? "");

int result = number * number ;

//Console.WriteLine ("Result = "+result);
Console.WriteLine ($"Result : {number} * {number} = {result}");


//string Host = System.Net.Dns.GetHostName();
//string IP = System.Net.Dns.Use GetHostEntry(Host).AddressList[0].ToString();