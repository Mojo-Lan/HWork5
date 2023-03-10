//Задача 36: 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//Например:
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//3  7  23  12
//0  1  2   3


using static MyLibrary;

public static class MyArray
{
    public static void Main()
    {
        int size = Input("Введите размер массива: ");    //задали количество чисел в массиве
        int[] ar = CreateArray(size);                                //Создали пустой массив
        Fill(ar);                                                    //Заполнили массив числами
        Console.WriteLine(Print(ar));                                //Напечатали массив
        Console.WriteLine("Сумма элементов на нечетных позициях = " + ElPosition(ar));   //напечатали сумму элементов из метода
    }
}
