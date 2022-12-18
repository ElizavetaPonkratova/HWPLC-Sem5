/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.WriteLine("Enter size array: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int [size];
ArrayRandomNumbers(arr);
PrintArray(arr);
int sum = 0;

void ArrayRandomNumbers(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100,100);
    }
}

void PrintArray(int[] arr)
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
    if (i % 2 == 1)
        {
            Console.WriteLine(arr[i] + "");
            sum = sum + arr[i];
        }
}

Console.WriteLine($"Sum of the elements standing in odd positions => {sum}");