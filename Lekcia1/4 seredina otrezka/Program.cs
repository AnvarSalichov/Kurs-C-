// задача по нахождению середины отрезка между точками

// Алгоритм:
// 1. определить три точки
// 2. выбрать из них две любых
// 3. найти середину  между ними
// 4. поставить в этом месте точку
// 5. выбрать случайную вершину треугольника
// 6. соединить ее с полученной на 4 шаге точнокй
// 7. перейти к шагу 3
// 8. шаги 3-7 повторить 9, 28, 31 раз (лучше 10 000 раз)

Console.Clear();
int xa = 40; int ya = 1;
int xb = 1; int yb = 30;
int xc = 80; int yc = 30;
Console.SetCursorPosition (xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition (xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition (xc, yc);
Console.WriteLine("+");
int x = xa, y = xb;// yb
int count = 0;
while(count<10000)
{
    int what = new Random().Next(0, 3);// [0;3) - это числа 0, 1, 2
    if (what == 0)
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }
    if (what == 1)
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }if (what == 2)
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }
Console.SetCursorPosition(x, y); //встать в начальную позицию
Console.WriteLine("+");//отметить место символом +
count = count+1;
}