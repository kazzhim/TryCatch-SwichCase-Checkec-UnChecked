Console.Write("Reqem:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Neticeniz:");
if (number%2==0)
    Console.WriteLine(number/2);
else if(number%2==1) 
{
    Console.WriteLine(number * 2);
}
