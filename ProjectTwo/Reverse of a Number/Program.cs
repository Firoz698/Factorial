//Reverse of a Number

int[] arrayStort = { 1,2,3,4,5};
int[] Stroee = new int[arrayStort.Length];

for (int i = arrayStort.Length -1; i >=0; i--)
{
    Stroee[i] = arrayStort[i];
    Console.Write(arrayStort[i]);
}
Console.WriteLine(" ");
foreach (int i in Stroee)
{
    Console.WriteLine(i);
}
