//Задача 38: 
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//Например: [3 7 22 2 78] -> 76


using static MyLibrary;

public static class MyArray
{


    public static void Main()
    {
        int number = Input("Введите размер массива: ");
        int[] array = CreateArray((int)number);
        Fill(array);
        Console.WriteLine(Print(array));
        int max = 0;
        int min = 0;
        Difference(array, max, min);
    }

    //Метод нахождения максимального и минимального элемента массива и их разница.
    static int Difference(int[] array, int max, int min)
    {
        int size = array.Length;
        max = array[0];
        min = array[0];
        for (int i = 0; i < size; i++)
        {
            if (array[i] > max)
                max = array[i];
            else
            if (array[i] < min)
                min = array[i];
            array[i]++;
        }
        Console.WriteLine($"Максимальное {max}\nМинимальное {min}\nРазница {max - min}");
        return size;

    }


}



