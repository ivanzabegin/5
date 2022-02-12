// Найти третью цифру числа или сообщить, что её нет.

int a = new Random().Next(1, 999);
Console.WriteLine(a);
char [] s = a.ToString().ToCharArray();
//Console.WriteLine(s);
//Console.WriteLine(s.Length);
int b = a/100;
//Console.WriteLine(b);
if (b!=0) Console.WriteLine(s[2]);
else Console.WriteLine("no 3rd number"); 

