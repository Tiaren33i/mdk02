// Task#1
// ВАРИАНТ №1
// 	Составить программу для вычисления площадь треугольника по формуле Герона
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());
double p=(a+b+c)*0.5;
double s=Math.Sqrt(p*(p-a)*(p-b)*(p-c));
Console.WriteLine(s);

// Task#2
// ВАРИАНТ №2
// 	Дана последовательность действительных чисел. Выяснить, будет ли она возрастающей.
double[] list=new double[]{0.1,-0.1,0.5,0.6,-3};
String message="последовательность возрастающая";
for (int i = 1; i < list.Length; i++)
{
    if (list[i]<list[i-1]){
        message="последовательность не возрастающая";
        break;
    }
}
Console.WriteLine(message);

// Task#3
// ВАРИАНТ №3
// 	Составить программу для вычисления площадь треугольника по через синус угла и двум прилежащим к нему сторонам.
int agle=Convert.ToInt32(Console.ReadLine());//сохранены в радианах - поэтому в формуле необходим переход в градусы по формуле: degrees = radians * (180/pi)
int line_1=Convert.ToInt32(Console.ReadLine());
int line_2=Convert.ToInt32(Console.ReadLine());
double plozhad=Math.Sin(agle* (180/Math.PI))*line_1*line_2;
Console.WriteLine(plozhad);

// Task#4
// ВАРИАНТ №4
// 	 Найти произведение положительных элементов одномерного массива A размера N. 
int prod=1;
int n=Convert.ToInt32(Console.ReadLine());
int[] mass_a=new int[n];
for (int i = 0; i < mass_a.Length; i++)
{
    mass_a[i]=Convert.ToInt32(Console.ReadLine());
    if (mass_a[i]>0){
        prod=prod*mass_a[i];
    }
}
Console.WriteLine(prod);

// Task#5
// ВАРИАНТ №5
// 	Определить время года по номеру месяца. Номер месяца вводить с клавиатуры
int m=Convert.ToInt32(Console.ReadLine());
String m_result="Номер месяца выходит за диапозон [1,12]";
if ((m==1) ||(m==2)||(m==12)){
    m_result="Зима";
}
if ((m==3) ||(m==4)||(m==5)){
    m_result="Весна";
}
if ((m==6) ||(m==7)||(m==8)){
    m_result="Лето";
}
if ((m==9) ||(m==10)||(m==11)){
    m_result="Осень";
}
Console.WriteLine(m_result);

// Task#6
// ВАРИАНТ №6
// 	Составить программу для анализа, введенного пользователем числа (целое или нет; положительное, отрицательное или нуль; четное или нечетное). 
double analyz_a=Convert.ToDouble(Console.ReadLine());
int int_a=(int)analyz_a;
if (analyz_a-int_a==0){
    Console.WriteLine("Число - целое");
} else {
    Console.WriteLine("Число - вещественное");
}
if (analyz_a>0){
    Console.WriteLine("Число - положительное");
} else if (analyz_a==0) {
    Console.WriteLine("Число - 0");    
} else{
    Console.WriteLine("Число - отрицательное");
}
if (analyz_a%2==0){
    Console.WriteLine("Число - четное");
} else {
    Console.WriteLine("Число - нечетное");    
}
// Task#7
// ВАРИАНТ №7
// 	В переменную последовательно вводятся N вещественных чисел. Вычислить максимальное значение.
int count_n=Convert.ToInt32(Console.ReadLine());
double max_n=Double.MinValue;
for (int i = 0; i < count_n; i++)
{
    double val=Convert.ToDouble(Console.ReadLine());
    if (val>max_n){
          max_n=val; 
    }
}
Console.WriteLine(max_n);      
// Task#8
// ВАРИАНТ №8
// 	В массив A[N] занесены натуральные числа. Найти сумму тех элементов, которые кратны данному K. 
int count_an=Convert.ToInt32(Console.ReadLine());
int k_an=Convert.ToInt32(Console.ReadLine());
int sum_an=0;
int[] arr_n=new int[n];
for (int i = 0; i < arr_n.Length; i++)
{
    arr_n[i]=Convert.ToInt32(Console.ReadLine());
    if (arr_n[i]%k_an==0){
        sum_an+=arr_n[i];
    }
}
Console.WriteLine(sum_an);
// Task#9
// ВАРИАНТ №9
// 	Составить программу вычисления факториала введенного с клавиатуры числа. // результат вывести в таком виде: fact=1*2*3=6 ( при n =3)
int f=1;
int n_f=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n_f; i++)
{
    f*=i;
}
Console.WriteLine(f);

// Task#10
//ВАРИАНТ №10
//	Определить максимальный элемент массива А[10] и его порядковый номер. 

int[] arr=new int[]{1,-1,5,6,-3};
int x=arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>x){
        x=arr[i];
    }
}
Console.WriteLine(x);

// Task#11
// ВАРИАНТ №11
// 	Составить программу для вычисления суммы всех натуральных чисел, кратных числу b и меньших 100. 
int n_b=Convert.ToInt32(Console.ReadLine());
int res_b=0;
for (int i = 0; i < arr.Length; i++)
{
    int el_b=Convert.ToInt32(Console.ReadLine());
    if ((el_b%b==0)&&(el_b<100)){
        res_b+=el_b;
    }
}
Console.WriteLine(res_b);

// Task#12
// ВАРИАНТ №12
// 	В переменную последовательно вводят числа, отличные от нуля. Окончание ввода - ноль. Определить среднее арифметическое отрицательных чисел. 
Console.WriteLine("Введите 0, чтобы перестать водить числа");
int sum_12=0;
int b_12=0;
double sredn_12;
while(true)
{
int n_12=int.Parse(Console.ReadLine());
if(n_12==0)
{
break;
}
if(n_12<0)
{
sum_12=sum_12+n_12;
b_12++;
}
sredn_12=sum_12/b_12;

}
Console.WriteLine(sredn_12);
// Task#13
// ВАРИАНТ №13
// 	С клавиатуры вводятся числа. Суммировать числа до тех пор, пока сумма не станет больше 100. Вывести сумму и количество просуммированных чисел. 

int sum_13=0;
int b_13=0;
while (true)
{
int n_13=int.Parse(Console.ReadLine());
 b_13++;
sum_13=sum_13+n_13;
if(sum_13>=100)
{
break;
}    
}
Console.WriteLine(sum_13);
Console.WriteLine(b_13);
// Task#14
// ВАРИАНТ №14
// 	Составить программу, которая запрашивает дату (число, месяц, год) и проверяет корректность введенным пользователем данных. 
bool d_14=true;
bool c_14=true;
bool a_14=true;
Console.WriteLine("Введите число");

int n_14=int.Parse(Console.ReadLine());
if(n_14>=32||n<=0)
{
d_14=false;}
Console.WriteLine("Введите месяц");
int mounth_14=int.Parse(Console.ReadLine());
if(mounth_14<=0||mounth_14>=13)
{
c_14=false;}
Console.WriteLine("Введите год");
int year_14=int.Parse(Console.ReadLine());
if(year_14<=0||year_14>=10000)
{
a_14=false;}
if(d_14&&c_14&&a_14)
{
Console.WriteLine("Вы ввели корректную дату");
}

// Task#15
// ВАРИАНТ №15
// 	Найти сумму положительных элементов одномерного массива A размера N.
Console.WriteLine("Введите размер массива");
int n_15=int.Parse(Console.ReadLine());
int[] a_15=new int[n_15];
int sum_15=0;
for(int i=0;i<n_15;i++)
{
a_15[i]=int.Parse(Console.ReadLine());
}
for(int i=0;i<n_15;i++)
{
if(a_15[i]>=0)
{
sum_15=sum_15+a_15[i];
}
}
Console.WriteLine(sum_15);
// Task#16
// ВАРИАНТ №16
// 	В массиве целых чисел есть нулевые элементы. Создать массив из номеров этих элементов.
int[] a_16=new int{0,1,0,0,1,0,1};
int[] z_16=new int[];
int p_16=0;
for (int i = 0; i < a_16.Length; i++)
{
    if(a_16[i]==0){
        z_16[p_16]=i+1;
        p_16++;
    }
}
for (int i = 0; i < z_16.Length; i++)
{
Console.WriteLine(z_16[i]);
}



// Task#17
// ВАРИАНТ №17
// 	  Написать программу вывода на экран четных чисел из интервала от 0 до100. 
for(int i=0;i<=100;i++)
{
if(i%2==0){
    Console.Write(i+" ");
}
}

// Task#18
// ВАРИАНТ №18
// 	Составить программу, которая по номеру дня недели выводит на экран расписание уроков в вашей группе в соответствующий день.
string[]raspisanie=new string
{"Математика,русский",
"Английский, Физика",
"химия,украинский,физ-р",
"Химия,физика,математика,история,литература",
"информатика,русский,история",
"философия, физ-ра, литература",
"обществознание,физика"};
Console.WriteLine("Введите номер дня");
int n_18=int.Parse(Console.ReadLine());
// for(int i=0;i<raspisanie.Length;i++)
// {
// if(n_18==raspisanie[i+1])
// {
//     Console.WriteLine(raspisanie[i+1])
// }
// else continue;
// }
if (n_18>7||n_18<0){
    Console.WriteLine('exit');
} else {
   Console.WriteLine(raspisanie[n_18-1]) ;
}

// Task#19
// ВАРИАНТ №19
// 	Написать программу для подсчета суммы чисел, кратных 3 в диапазоне от 30 до 60.
int sum_19=0;
 for(int i=30;i<=60;i++)
 {
if(i%3==0)
{
sum_19=sum_19+i;
}
 }
 Console.WriteLine(sum_19);

// Task#20
// ВАРИАНТ №20
// 	Составить  программу для нахождения минимального значения среди элементов, стоящих до первого четного элемента.
int[]mas_20=new int{3,5,1,6,2,9,8};
int min_20=mas_20[0];
for(int i=0;i<mas_20.Length;i++)
{
if(mas_20[i]%2==0)
{
    break;
}
if(min_20>mas_20[i])
{
    min_20=mas_20[i];
}
}
Console.WriteLine(min_20);


// Task#21
// ВАРИАНТ №21
// 	Составить программу для поиска произведения положительных элементов массива. 
Console.WriteLine("Введите размер массива");
int n_21=int.Parse(Console.ReadLine());
int proizv_21=1;
int[] mas_21=new int[n_21];
for(int i=0;i<n_21;i++)
{
mas_21[i]=int.Parse(Console.ReadLine());
}
for(int i=0;i<n_21;i++)
{
    if(mas_21[i]>0)
    {
        proizv_21=proizv_21*mas_21[i];
    }
}
System.Console.WriteLine(proizv_21);

// Task#22
// ВАРИАНТ №22
// 	Написать программу для нахождения в массиве из N элементов количества нулевых элементов. 
Console.WriteLine("Введите размер массива");
int n_22=int.Parse(Console.ReadLine());
int[] mas_22=new int[n_22];
int kol_22=0;
for(int i=0;i<n_22;i++)
{
mas_22[i]=int.Parse(Console.ReadLine());
}
for(int i=0;i<n_22;i++)
{
    if(mas_22[i]==0)
    {
        kol_22++;
    }
}
System.Console.WriteLine(kol_22);
// Task#23
// ВАРИАНТ №23
// 	Найти количество положительных элементов одномерного массива A размера N.
 Console.WriteLine("Введите размер массива");
int n_23=int.Parse(Console.ReadLine());
int[] mas_23=new int[n_23];
int kol_23=0;
for(int i=0;i<n_23;i++)
{
mas_23[i]=int.Parse(Console.ReadLine());
}
for(int i=0;i<n_23;i++)
{
    if(mas_23[i]>0)
    {
        kol_23++;
    }
}
System.Console.WriteLine(kol_23);

// Task#24
// ВАРИАНТ №24
// 	Написать программу для определения максимального элемента массива А[20].
int []mas_24=new int[20];
int max_24=mas_24[0];
System.Console.WriteLine("Введите числа");
for(int i=0;i<mas_24.Length;i++)
{
    mas_24=int.Parse(Console.ReadLine());
}
for(int i=0;i<mas_24.Length;i++)
{
  if(max<mas_24[i])
  {
    max_24=mas_24[i];
  }  
}
System.Console.WriteLine(max_24);
// Task#25
// ВАРИАНТ №25
// 	Определить минимальный элемент массива А[15] и его порядковый номер.
int []mas_25=new int[15];
int min_25=mas_25[0];
int poryadkoviy;
System.Console.WriteLine("Введите числа");
for(int i=0;i<mas_25.Length;i++)
{
    mas_25=int.Parse(Console.ReadLine());
}
for(int i=0;i<mas_25.Length;i++)
{
if(min_25>mas_25[i])
{
    min_25=mas_25[i];
    poryadkoviy=i+1;
}
}
System.Console.WriteLine(min_25);
System.Console.WriteLine(poryadkoviy);