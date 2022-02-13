//  Проверить истинность утверждения  ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//                                    !   ||         && 
int x = new Random().Next(0,2);
int y = new Random().Next(0,2);
Console.WriteLine(x);
Console.WriteLine(y);
string x11 = x.ToString();
string y11 = y.ToString();
bool x1 = Convert.ToBoolean(x);
bool y1 = Convert.ToBoolean(y);
bool result1 = (!(x1||y1)==true);
Console.WriteLine(result1);
bool result2 = (!x1 && y1)==true;
Console.WriteLine(result2);
if (result1==result2) Console.WriteLine("statement is true");
else Console.WriteLine("statement isn't true");

//Console.WriteLine("statement is true");
//Console.WriteLine(strX);
//Console.WriteLine(strY);
