//Factorial of a Number in C#



Console.Write("Factorial Numebr : ");
int data =Convert.ToInt32( Console.ReadLine());
int Store = 1;
for (int i = 0; i < data; i++)
{
    
     Store += Store * i;
}
Console.WriteLine(Store);