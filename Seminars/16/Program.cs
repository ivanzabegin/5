// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int a = new Random().Next(1, 7);
Console.WriteLine(a);
int M = 1;
string Mo = M.ToString();
int T = 2;
string Tu = T.ToString();
int W = 3;
string We = W.ToString();
int Th = 4;
string Thu = Th.ToString();
int F = 5;
string Fr = F.ToString();
int Sa = 6;
string Sat = Sa.ToString();
int Su = 7;
string Sun = Su.ToString();
//Console.WriteLine("Monday");
if (a==1) Console.WriteLine("Monday");
else if  (a==2) Console.WriteLine("Tuesday");
else if  (a==3) Console.WriteLine("Wednesday");
else if  (a==4) Console.WriteLine("Thursday");
else if  (a==5) Console.WriteLine("Friday");
else if  (a==6) Console.WriteLine("Saturday, day off");
else if  (a==7) Console.WriteLine("Sunday, day off");

