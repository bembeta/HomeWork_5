/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

*/
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}
int[] arr = InitArray(size);
Console.Write("[");
Console.Write(string.Join(",", arr));
Console.Write("]");
int sum = 0;
for (int i = 0; i < arr.Length; i+=2)
    {
    sum = sum + arr[i];
    }
Console.Write($" ->  {sum}");


