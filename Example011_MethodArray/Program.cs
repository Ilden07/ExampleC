int[] array = { 11, 21, 31, 41, 18, 15, 16, 71, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while ( index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index +1;
}
