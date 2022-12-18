//Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//Например:
// [345, 897, 568, 234] -> 2
using static MyLibrary;

public static class Array
{
    public static void Main()
    {
        int size = Input("Сколько чисел в массиве: ");    //задали количество чисел в массиве
        int[] ar = CreateArray(size);                     //Создали пустой массив
        Fill(ar);                                         //Заполнили массив числами
        Console.WriteLine(Print(ar));                     //Напечатали массив
        Console.WriteLine("Количество четных чисел в массиве - " + NumEvenArray(ar));
       // Console.WriteLine(NumEvenArray(  ar));

    }
}