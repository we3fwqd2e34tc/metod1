//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Разработать функцию Double(const S:string):string, возвращающую строку, в которой 
//каждый символ строки S удвоен. С помощью данной функции у каждой строки из 
//введенного набора удвоить каждый символ.
//static string Double(string s)
//{
//    int k = s.Length;
//    string f = "";
//    for (int i = 0; i < k; i++)
//    {
//        f += s[i].ToString() + s[i].ToString();

//    }
//    return f;
//}
//Console.WriteLine("Введите строку:");
//string? s = Console.ReadLine();
//Console.WriteLine($"Удвоенная строка:" + Double(s));

//Описать функцию Sign(X) целого типа, возвращающую для вещественного числа X 
//следующие значения: –1, если X< 0; 0, если X = 0; 1, если X > 0.С помощью 
//этой функции найти значение выражения Sign(A) +Sign(B) для данных вещественных 
//чисел A и B.

//static double SignX(double X)
//{
//    double result = 0;
//    if (X < 0)
//    {
//        result = -1;  
//    }
//    else if (X == 0)
//    {
//        result = 0;
//    }
//    else if (X > 0)
//    {
//        result = 1;
//    } 
//    return result;
//}

//double X = Convert.ToDouble(Console.ReadLine());
//double B = Convert.ToDouble(Console.ReadLine());
//double sum = SignX(X) + SignX(B);
//Console.WriteLine(sum);

//Описать функцию MinInt(A, N) целого типа, находящую минимальный элемент 
//целочисленного массива A размера N. С помощью этой функции найти минимальные 
//элементы массивов A, B, C размера NA, NB, NC соответственно.



//static int MinInt(int[] mass, int N)
//{
//    int min = 0;
//    for (int i = 0; i < N; i++)
//    {
//        if (min > mass[i])
//        {
//            min = mass[i];
//        }
//    }
//    return min;
//}

//Console.Write("Введите размер массива N = ");
//int N = Convert.ToInt32(Console.ReadLine());
//int[] A = new int[N];
//int[] B = new int[N];
//int[] C = new int[N];
//int r = 0;
//for (int i = 0; i < N; i++)
//{
//    Console.Write($"Введите элемент массива А  под индексом {i} ");
//    A[i] = int.Parse(Console.ReadLine());
//    Console.WriteLine("Минимальный A " + MinInt(), N);
//}

//for (int i = 0; i < N; i++)
//{
//    Console.Write($"Введите элемент массива B  под индексом {i} ");
//    B[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < N; i++)
//{
//    Console.Write($"Введите элемент массива С  под индексом {i} ");
//    C[i] = int.Parse(Console.ReadLine());
//}


//Console.WriteLine("Минимальный B " + MinInt(B, B.Length));
//Console.WriteLine("Минимальный C " + MinInt(C, C.Length));


////Описать рекурсивную функцию Fact(N) вещественного типа, вычисляющую значение 
////факториала N! = 1·2·…·N (N > 0 — параметр целого типа). С помощью этой функции 
////вычислить факториалы пяти данных чисел.


int Factorial(int n)
{
    if (n == 1)

        return 1;

    return n * Factorial(n - 1);
}
Random rnd = new Random();
Random rnd1 = new Random();
Random rnd2 = new Random();
Random rnd3 = new Random();
Random rnd4 = new Random();


int factorial = Factorial(rnd.Next(1,6));
int factorial1 = Factorial(rnd1.Next(1, 6));
int factorial2 = Factorial(rnd2.Next(1, 6));
int factorial3 = Factorial(rnd3.Next(1, 6));
int factorial4 = Factorial(rnd4.Next(1, 6)); ;


Console.WriteLine($"Факториал числа 1 = {factorial}");
Console.WriteLine($"Факториал числа 2 = {factorial}");
Console.WriteLine($"Факториал числа 3 = {factorial}");
Console.WriteLine($"Факториал числа 4 = {factorial}");
Console.WriteLine($"Факториал числа 5 = {factorial}");





