/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(100);
    }
    return arr;
}
int[] arr = InitArray(5);
Console.Write("[");
Console.Write(string.Join(" ", arr));
Console.Write("]");
int minNum = 0;
int maxNum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] >= maxNum)
    maxNum = arr[i];
    else
    {
        minNum = arr[i];
    }
}
int sumNum = 0;
if(maxNum > minNum)
    sumNum = maxNum - minNum;
    else
    sumNum = minNum - maxNum;

Console.Write($" -> {sumNum}");