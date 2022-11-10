//Общие переменные
double y=0;
int i=Convert.ToInt32(Console.ReadLine());
double h=Convert.ToDouble(Console.ReadLine());
//Локальный минимум/максимум y=sin(x^2)
double max=0;
for (double x = i; x < i+100; x=x+h)
{
    y=Math.Sin(x*x* (180/Math.PI));
    if (y>max){
        max=y;
    }
} 
Console.WriteLine(max);
//Все нули функции y=sin(x^2)
for (double x = i; x < i+100; x=x+h)
{
    y=Math.Sin(x*x* (180/Math.PI));
    if (y==0){
        Console.WriteLine(x+" "+y);
    }
} 
//Перечесечение графиков функций y=sin(x) и y=sin(x^2)
for (double x = i; x < i+100; x=x+h)
{
    double y1=Math.Sin(x* (180/Math.PI));
    double y2=Math.Sin(x*x* (180/Math.PI));
    if (y1==y2){
        Console.WriteLine(x+" "+y1);
    }
} 

//Точка в которых функция равна значению 10 для y=sin(x)
for (double x = i; x < i+100; x=x+h)
{
    y=Math.Sin(x* (180/Math.PI));
    if (y==10){
        Console.WriteLine(x+" "+y);
    }
} 
