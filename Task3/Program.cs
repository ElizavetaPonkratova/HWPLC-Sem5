/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.WriteLine("Enter size array: ");
int size = int.Parse(Console.ReadLine());
float[] arr = new float [size];
ArrayRandomNumbers(arr);
PrintArray(arr);
float min = Int32.MaxValue;
float max = Int32.MinValue;

void ArrayRandomNumbers(float[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
}

void PrintArray(float[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write("]");
    Console.WriteLine();
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
        {
            min = arr[i];
        }
    if (arr[i] > max)
        {
            max = arr[i];
        }
}

Console.WriteLine($"MAX => {max}, MIN => {min}. Difference between MAX and MIN values = {max - min}");

//Не могу разобраться, как убрать запятую в конце массива..