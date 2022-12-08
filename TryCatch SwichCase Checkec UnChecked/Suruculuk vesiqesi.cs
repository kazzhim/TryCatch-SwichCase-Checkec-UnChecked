Console.Write("Yasiniz:");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Neticeniz:");
if(age<=0)
{ 
    Console.WriteLine("duzgun reqem daxil et"); 
}
else if (age>=18)
{
    Console.WriteLine("sürücülük vesiqesi ala bilersiniz");
}
else
{
    Console.WriteLine(18-age);
}

