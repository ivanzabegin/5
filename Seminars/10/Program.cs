// Показать вторую цифру трёхзначного числа

int a = new Random().Next(100, 999);
Console.WriteLine(a);
int a1 = Convert.ToInt32(a);
     Console.WriteLine((a1%100)/10);