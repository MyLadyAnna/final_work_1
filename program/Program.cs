// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

void FirstArrayInSecond (string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

string[] array1 = new string[5] {"^_^", "-2", "hello", "world", "int"};
string[] array2 = new string[array1.Length];

FirstArrayInSecond (array1, array2);
PrintArray (array2);




