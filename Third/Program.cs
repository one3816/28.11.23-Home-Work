double max = 0;
double min = 0;
double[] array = new double[10];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write(array[i] + " ");
}
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    if(array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine();
Console.WriteLine("=>" + (max - min));