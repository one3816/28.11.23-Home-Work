int count = 0;
int[] array = new int[10];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i] + " ");
}
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine(count);