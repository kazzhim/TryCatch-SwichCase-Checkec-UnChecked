string test = "Kazim,Semed,Umid,Elsad";
string test1=string.Empty;

for(int i=0; i<test.Length;i++)
{
    if (test[i]==',')
    {
        test1 += '.';
        continue;
    }
    test1+= test[i];   
}
Console.WriteLine(test1);