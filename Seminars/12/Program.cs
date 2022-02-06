// Удалить вторую цифру трёхзначного числа

int a = new Random().Next(100, 999);
Console.WriteLine(a);
string s = a.ToString();
string c = s.Remove (1, 1);
Console.WriteLine(c);
