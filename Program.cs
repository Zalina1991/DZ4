/* Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число
 A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

/* Console.WriteLine("Введите два числа: ");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double result = Math.Pow(a, b);
 Console.WriteLine($"{a} ^ {b} = {result}"); */

/* Задача 27: Напишите программу, которая принимает
 на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

//int GetSumNums(int number) {
  // int sum = number+(number+0);
   //return sum;
//}

/* Console.WriteLine("Vvedite chislo");
int a = int.Parse(Console.ReadLine());
int sum = 0;
while (a > 0)
{
    sum = sum + (a % 10);
    a = a / 10;
}
Console.WriteLine("Сумма цифр:" + sum);
 */


/* //Задача 29: Напишите программу, которая задаёт
 массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

 //Console.Write("Введите массив чисел: ");
//int i = int.Parse(Console.ReadLine());
void PrintArray(int[] arr) 
{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random().Next(0, 9);
        index++;
    }

}

void SelectionSort(int[] arra)
{
    int count = arra.Length;
    int pos = 0;
    while (pos < count)
    {
    Console.Write(arra[pos]);
    pos++;
    }
} 
int[] array = new int[8];
PrintArray(array);

SelectionSort(array);
