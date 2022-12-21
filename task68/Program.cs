// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {AccermanFunction(m,n)}");

int AccermanFunction (int m, int n)
{
    if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AccermanFunction(m - 1, 1);
    else
      return AccermanFunction(m - 1, AccermanFunction(m, n - 1));
}