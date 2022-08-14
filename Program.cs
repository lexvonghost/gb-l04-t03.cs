//Задача 29: Напишите программу, которая задаёт массив  и выводит на экран.

Console.WriteLine("Введите число, определяющее длинну массива");
int size =  Convert.ToInt32(Console.ReadLine());

int[] NumbersArray(int size)
{
    int[] numbersArray = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        numbersArray[i] = rnd.Next(100);
    }
    return numbersArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int[] array = NumbersArray(size);
PrintArray(array);