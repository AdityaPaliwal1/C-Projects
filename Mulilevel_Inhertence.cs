using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      academic obj = new academic();
      obj.basicinfo();
      obj.contactinfo();
      obj.academicinfo();
      obj.display();
      
    }
    public class studentbasic{
        public string name;
        public int rollno;
        
        public void basicinfo(){
            Console.WriteLine("Enter Your name here...\n");
            name = Console.ReadLine();
            Console.WriteLine("Enter your rollno.\n");
            rollno = Convert.ToInt32(Console.ReadLine());
            
        }
        
    }
    public class contact : studentbasic{
     public string address;
     public string email;
     public ulong phn;
      public void contactinfo(){
          Console.WriteLine("Enter your phone number :");
          phn = Convert.ToUInt64(Console.ReadLine());
          Console.WriteLine("Enter your email :");
          email = Console.ReadLine();
          Console.WriteLine("Enter your address :");
          address = Console.ReadLine();
      }
    }
    public class academic : contact{
        int total;
        public void academicinfo(){
            Console.WriteLine("Enter Percentage of last semester :");
            total = Convert.ToInt32(Console.ReadLine());
            
        }
        public void display(){
            Console.WriteLine("______Your Final Sheet Is_______\n");
            Console.WriteLine("Your name is :" + name +"\n");
             Console.WriteLine("Your rollno is :"+ rollno+"\n");
             Console.WriteLine("Your email is :"+ email+"\n");
             Console.WriteLine("Your phone number  is :"+ phn+"\n");
              Console.WriteLine("Your address is :"+ address+"\n");
             Console.WriteLine("Your last sem percentage  is :"+ total+"\n");
            
            
            
        }
    }
}
