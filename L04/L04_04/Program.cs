/* еще один пример рекурсии - числа Фибоначи 
1 1 2 3 5 8 13 21 ... - это когда каждое следующее число, задается через предыдущее

f(1) = 1
f(2) = 1
f(n) = f(n-1)+f(n-2)
*/
/*
int Fibonachi (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonachi (n-1) + Fibonachi (n-2);
}
for (int i = 1; i < 10; i++) //указываем как будут читаться числа Фибоначи, выводим первый 10
{
    Console.WriteLine(Fibonachi(i));
}*/

double Fibonachi (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonachi (n-1) + Fibonachi (n-2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonachi(i)}");
}
