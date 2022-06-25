Console.WriteLine("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    Console.Write(a);
    Console.WriteLine(" -> YES");
}
else
{
    Console.Write(a);
    Console.WriteLine(" -> NO");
}