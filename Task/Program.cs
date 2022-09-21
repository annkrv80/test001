/*Программа, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.*/
Console.Clear();
Console.Write("Введите число эллементов массива ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
FillingArray(array);
PrintArray(array);
Console.WriteLine();
int newSize=CountElement(array);
string[] changeArray = ConvertArray(array,newSize);
PrintArray(changeArray);





void FillingArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        string letter=Console.ReadLine()??"";

        if(letter!="")
        {
            array[i] = letter;
        }
        else
        {
            Console.WriteLine ("Ошибка! Введите данные!");
            break;
        }
    }
}


void PrintArray(string[] array)

{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int CountElement (string[] array)
{
    int size = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
           size++;
        }
    }
    
    return size;
}

string[] ConvertArray (string[] array, int newSize)
{
    int count = 0;
    string[] resultArray = new string[newSize];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            resultArray[count] = array[i];
            count++;
        }
    }
    
    return resultArray;
}



