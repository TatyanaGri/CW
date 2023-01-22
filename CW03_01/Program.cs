
// Вид 1

void Metod1 ()
{
    Console.WriteLine("Автор...");
}
Metod1(); //при вызове данного метода ставиться идентификатор и круглые скобки!

// Вид 2

void Metod2 (string msg)
{
    Console.WriteLine(msg);
}
Metod2("Текст сообзения");

void Metod21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
Metod21(msg: "Текст", count; 4); // вызывааем текст и указывем через запятую сколько раз мы хотим увидеть результаты метода

// Вид 3

int Metod3(); 
{
    return DataTime.Now.Year;
}

int year = Metod3();
Console.WriteLine(year);

// Вид 4

string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Metod4(10, "asdf");
Console.WriteLine(res);


// Синтаксис цикла for

string Metod4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Metod4(10, "asdf");
Console.WriteLine(res);

// Цикл в цикле 

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
    Console.WriteLine();
}

