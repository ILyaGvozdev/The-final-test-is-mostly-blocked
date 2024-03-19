
// Задача: 
// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.Write($"Введите {i+1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}



void PrintArray(string[] array)
{
    System.Console.Write($"Ваш массив - ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"[{array[i]}] ");
    }
    System.Console.WriteLine();
}




string[] ArrayToSizeSimbol(string[] array)
{
    System.Console.Write("Задайте число ограничения по символам в новом массиве: ");
    int n = int.Parse(Console.ReadLine());
    int count1 = 0;
    int count2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n) 
        {
            count1++;
        }
    }
    string[] arrayNew = new string[count1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n) 
        {
            arrayNew[count2] = array[i];
            count2++;
        }
    }
    return arrayNew;
}

System.Console.Write("Задайте длину массива: ");
int size = int.Parse(Console.ReadLine());
PrintArray((ArrayToSizeSimbol(CreateArray(size))));



