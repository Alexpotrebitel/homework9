// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*void  Shownums(int m, int n)
{
    Console.Write(" "+n);
    if (1<n) Shownums(m,n-1);
            }
  Console.WriteLine();  
 Shownums(1,10);
*/
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int m = InputNumbers("Input the number M: ");
int n = InputNumbers("Input the number N: ");
int temp = m;
if (m > n) 
{
    m = n; 
    n = temp;
}
ShowSum(m, n, temp = 0);
void ShowSum(int m, int n, int sum=0)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов от m до n равна{sum}.");
        return;
    }
    ShowSum(m, n - 1, sum);   
}
int InputNumbers(string input) 
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
*/
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Ackerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ackerman(m - 1, 1);
  else return Ackerman(m - 1, Ackerman(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int m = InputNumbers("Input the number m: ");
int n = InputNumbers("Input the number n: ");

int AckermanFunction = Ackerman(m, n);

Console.Write($"The Ackerman function is equal to {AckermanFunction}.");