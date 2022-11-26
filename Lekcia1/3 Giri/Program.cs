// Задача по нахождению самой тяжелой гири
int a = 2;
int b = 3;
int c = 8;
int d = 6;
int e = 4;
int max = a;
if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;
if (d>max) max=d;
if (e>max) max=e;

Console.Write("Самая тяжелая гиря - ");
Console.WriteLine(max+" кг");
