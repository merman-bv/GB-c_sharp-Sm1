// Хочу увидеть адрес своего компьютера

using System.Net;

Console.WriteLine("Hello, People!");





string Host = System.Net.Dns.GetHostName();
string IP = System.Net.Dns.GetHostEntry(Host).AddressList[1].ToString();
Console.WriteLine($"Host computer: {Host}");
Console.WriteLine($"Address computer: {IP}");