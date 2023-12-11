// Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)



using System;



class Program

{

    static void Main()

    {
        Console.WriteLine("Введите элементы массива");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int[] array = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)

        {

            array[i] = int.Parse(numbers[i]);

        }

        ReverseArray(array);

        Console.WriteLine("Перевернутый массив");

        for (int i = 0; i < array.Length; i++)

        {

            Console.Write(array[i] + " ");
       
        }

    }
    static void ReverseArray(int[] array)

    {

        int length = array.Length;

        for (int i = 0; i < length / 2; i++)

        {
           
            int temp = array[i];

            array[i] = array[length - i - 1];

            array[length - i - 1] = temp;

        }

    }

}













