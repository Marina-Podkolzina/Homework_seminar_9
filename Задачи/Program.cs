void Zadacha64()
{
    Console.WriteLine("Введите число M");
    int m =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int n =Convert.ToInt32(Console.ReadLine());
    Pow(n,m);
    

}
void Pow( int n,int count =1)
{
    Console.Write(count+",");
    count++;
    if (count>=n)
    {
        return;
    }
    Pow (n,count);

    if (count % 3==0 )
    {
        Console.WriteLine();
        Console.WriteLine(count);
    }
}

//Zadacha64();


void Zadacha66()
{
    
    Console.WriteLine("Введите число M");
    int m =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int n =Convert.ToInt32(Console.ReadLine());
    Pow1(n,m);
    
}
void Pow1(int n,int count=1,int sum = 0)
{
    
    sum = sum+ count;
    count++;
    if (count>n)
    {
       Console.WriteLine(sum);
       return;
    }
    Pow1 (n,count,sum);
   
}
//Zadacha66();


void Zadacha68()
{
    Console.WriteLine("Введите число M");
    int m =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N");
    int n =Convert.ToInt32(Console.ReadLine());
    if (m>0 && n>0)
    {
        Console.WriteLine($"A(m,n) = {Akkerman(m,n)}");
    }
    else
    {
        Console.WriteLine("Не работает с отрицательными числами");
    }


}   
int Akkerman( int m,int n)
{
    if (m==0)
    {
        return n+1;
    }
    else
    {
    if (n==0)
    {
        return Akkerman(m-1,1);
    }
    else
    {
        return Akkerman(m-1,Akkerman(m,n-1));
    }
    }
    
}
//Zadacha68();


