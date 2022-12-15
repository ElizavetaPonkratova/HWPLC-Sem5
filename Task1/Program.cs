/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.WriteLine("Enter size array:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
FillArrayRandomNumbers(arr);
PrintArray(arr);
int count = 0;

for (int z = 0; z < arr.Length; z++)
if (arr[z] % 2 == 0)
count++;

Console.WriteLine($"=> {count} even numbers");

void FillArrayRandomNumbers(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}