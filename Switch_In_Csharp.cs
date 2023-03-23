using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter your number:");
int num = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("operation on number are :");
   Console.WriteLine("\r\n1.Prime no.\r\n 2.Even Or odd \r\n 3.Factors \r\n 4.Composite no.");
   
   Console.WriteLine("Enter your choice :");
    int choice = Convert.ToInt32(Console.ReadLine());
    char ch;
   
    switch(choice){
       case 1 : 
       for(int i=2; i<num/2;i++){
           if(num%i !=0)
           Console.WriteLine("Number is prime");
       else
           Console.WriteLine("Not a Prime");
         break;
       }
      
      break;
       case 2:
       if(num%2==0){
           Console.WriteLine("Even Number");
       }
       else{
           Console.WriteLine("Odd Number");
       }
       break;
      case 3 :
            Console.WriteLine("The Factors are : ");
            for (int x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
            break;
            case 4:
             
   int j;
   int count = 0;

   for(j=1; j<=num; j++)
   {
    if(num % j == 0)
     count++;
   }
	 
   if(count > 2)
    Console.Write("{0} is a composite number", num);
   else
    Console.Write("{0} is not a composite number", num);
   break;
   }
   

}

}

