// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return Akkerman(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1));
    return Akkerman(numberM, numberN);
}

Console.WriteLine(Akkerman(numberM, numberN));