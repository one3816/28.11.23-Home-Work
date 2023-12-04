//int value = new Random().Next(1, 100000);
int value = 98675;
Console.WriteLine(value);
int count = 0;

while (value/10 > 0)
{
    
}



int[] array = new int[5];
if(value < 100000)
{
    
    array[0] = value/10000;
    array[1] = value/1000;
    array[2] = value/100;
    array[3] = value/10;
    array[4] = value%10;
}
if(value < 10000)
{
    int fourth = value/1000;
    count++;
}
if(value < 1000)
{
    int third = value/100;
    count++;
}
if(value < 100)
{
    int second = value/10;
    count++;
}
if(value < 10)
{
    int first = value%10;
}
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + " ");
}