using static System.Console;

/// <summary>
/// Это библиотека для работы с массивами:
/// <para> Метод создания массива - CreateArray </para>
/// <para> Метод заполнения массива трехзначными числами - Fill </para>
/// <para> Метод печати массива - Print </para>
/// <para> Метод конвертации массива из 15-ой в 10-ую СС - ConversionArray </para>
/// <para> Метод ввода массива с клавиатуры пользователем - Input </para>
/// <para> Метод возведения a в степень b - Pow </para>
/// <para> Метод, который показывает количество четных чисел в массиве - NumEvenArray </para>
/// </summary>
public class MyLibrary
{

    /// <summary>
    /// Метод создания массива
    /// <para>Созданный массив из count элементов</para>
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    public static int[] CreateArray(int count)
    {
        return new int[count];
    }


    /// <summary>
    /// Метод заполенения массива трехзначными числами 
    /// </summary>
    /// <param name="array"></param>
    public static void Fill(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(100, 999);
            //array[i] = new Random().Next(0, 15);  
        }
    }
    /// <summary>
    /// Метод печати массива
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static string Print(int[] array)
    {
        return String.Join(' ', array);
    }

    //написать конвертов из 15-ой в 10-ую
    //[6, 4, 3, 10]
    // 3  2   1  0
    //10*15^0 + 3*15^1 + 4*15^2 + 6*15^3
    /// <summary>
    /// Метод конвертации массива из 15-ой в 10-ую СС
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int ConversionArray(int[] value)
    {
        int result = 0;
        int count = value.Length;
        for (int i = 0; i < count; i++)
        {
            result += value[i] * Pow(15, count - 1 - i);
        }
        return result;
    }
    /// <summary>
    /// Метод ввода массива с клавиатуры пользователем - Input
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static int Input(string text)
    {
        Console.Write(text);
        return int.Parse(ReadLine());
    }
    /// <summary>
    /// Метод возведения а в степень b
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Pow(int a, int b)
    {
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }
        return result;
    }

/// <summary>
/// Метод, который показывает количество четных чисел в массиве
/// </summary>
/// <param name="array"></param>
/// <returns></returns>
    public static int NumEvenArray(int[] array)
    {
        int result = 0;
        //int count = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                result++;
            }

        }
        return result;
    }
}




