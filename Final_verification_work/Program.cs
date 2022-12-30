/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа.
При решении пользоваться исключительно массивами. */

string[] arrayOfStrings = EntersArrayOfStrings();
Console.WriteLine("Исходный массив: [{0}]", String.Join(", ", arrayOfStrings));
string[] arrayOfStringsTreeSymb = ArrayOfStringsTreeSymb(arrayOfStrings);
Console.WriteLine("Результирующий массив: [{0}]", String.Join(", ", arrayOfStringsTreeSymb));

// Метод для ввода массива строк с клавиатуры.
string[] EntersArrayOfStrings()
{
    string[] arrayOfStrings = new string[0];
    string[] arrayOfStringsTemp = new string[0];
    string str = "";
    int countStringsArray = 0;
    Console.WriteLine("Введите строки. Для прекращения - введите пустую строку");
    do
    {
        str = Console.ReadLine();
        if (str != "")
        {
            countStringsArray++;
            arrayOfStringsTemp = new string[countStringsArray];
            for (int i = 0; i < arrayOfStringsTemp.Length - 1; i++)
                arrayOfStringsTemp[i] = arrayOfStrings[i];
            arrayOfStringsTemp[countStringsArray - 1] = str;
            arrayOfStrings = arrayOfStringsTemp;
        }
    } while (str != "");
    return arrayOfStrings;
}

// Метод для формирования из введённого массива строк массива строк, длинна которых меньше либо равна 3 символа.
string[] ArrayOfStringsTreeSymb(string[] array)
{
    string[] arrayOfStrings = new string[0];
    string[] arrayOfStringsTemp = new string[0];
    int countStringsArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            countStringsArray++;
            arrayOfStringsTemp = new string[countStringsArray];
            for (int j = 0; j < arrayOfStringsTemp.Length - 1; j++)
                arrayOfStringsTemp[j] = arrayOfStrings[j];
            arrayOfStringsTemp[countStringsArray - 1] = array[i];
            arrayOfStrings = arrayOfStringsTemp;
        }
    }
    return arrayOfStrings;
}