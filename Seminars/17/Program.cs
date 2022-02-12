// По двум заданным числам проверять является ли одно квадратом другого

int numbera = 25;
int numberb = 5;
if (Math.Sqrt(numbera)==numberb) Console.WriteLine("1st is quadrat");
else Console.WriteLine("no 1 st isn't quadrat");
if (Math.Sqrt(numberb)==numbera) Console.WriteLine("2nd is quadrat");
else Console.WriteLine("2ns isn't quadrat");