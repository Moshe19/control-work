
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.Write("Введите желаемое колличество элеменов в массив: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arreyStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine("Можете начинать.");
    Console.WriteLine($"Введите {i+1}-й элемент и нажмите entr: ");
    string arrey = Convert.ToString(Console.ReadLine());
    arreyStrings[i] = arrey;
}
string[] arreyFinal = new string[size];
int len = 3;
int count = 0;
for (int j = 0; j < size; j++)
{
    if (arreyStrings[j].Length <= len)
    {
        arreyFinal[count] = arreyStrings[j];
        count++;
    }
}
Console.WriteLine();
PrintArray(arreyFinal);
void PrintArray(string[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write(arrey[i] + " ");
    }
    Console.WriteLine();
}
