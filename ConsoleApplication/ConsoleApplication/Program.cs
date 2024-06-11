using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        private static string format = "Hello {0},{1}{2}";
        static void Main(string[] args)
        {
            // get first Name
            Console.Write("Please enter your firstname :--");
            string Name = Console.ReadLine();
            // get first last Name
            Console.Write("Please enter your lastename :--");
            string LName = Console.ReadLine();
            // print all input 
            Console.WriteLine(string.Format(format, Name, Environment.NewLine, Name + LName));
            // wait for next 1
            Console.Read();
            FibonacciNumber2ForLoop(2000);
            FibonacciNumber2ByValue(2000);
            FibonacciNumber2ByPosition(50);
            //Console.Write(Fib(3));
        
            //Console.WriteLine ("0 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 ");
            //Console.WriteLine ("0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597");
            //FibonacciNumber(2000);
        }
        private static void FibonacciNumber2ForLoop(int n )
    {
        int input, first = 0, second = 1, third = 0;
        Console.Write("Enter a number : ");
        input = Convert.ToInt32(Console.ReadLine());
        Console.Write("First {0} Fibonacci numbers {1} {2} ", input, first, second);
        for (int i = 3; i <= input; i++)
        {
            
            third = first + second;
            if(third> input ) return;
            Console.Write("{0} ", third);
            first = second;
            second = third;
            
        }
        
    }
    
    private static void FibonacciNumber2ByPosition(int n )
    {
        int a=0;
        int counter=0 ;
         while (counter<n)
        {
            
           a = Fib2(counter);
           Console.WriteLine($"counter {counter}, Value {a} Fib2(counter) =  { Fib2(counter) }");
           counter++;
        }
        
    }
    private static void FibonacciNumber2ByValue(int n )
    {
        int a=0;
        int counter=0 ;
         while (counter<n)
        {
            
           a = Fib2(counter);
           if(a>= n)
           {
               counter= a;
               return ;
           }
           Console.WriteLine($"counter {counter}, Value {a} Fib2(counter) =  { Fib2(counter) }");
           counter++;
        }
        
    }
    static int Fib(int n) {
        if (n < 2){
            Console.WriteLine($"{ n }");//- {n}- {n}
        }
        else{
            Console.WriteLine($"else { n }");//- {n-1}- {n-2}
        }
        
        return (n < 2)? n : Fib(n - 1) + Fib(n - 2);
    }
     static int Fib2(int n) {
      //  if (n < 2){
      //      Console.WriteLine($"Fib2 { n }");//- {n}- {n}
      //  }
      //  else{
     //       Console.WriteLine($"Fib2 else { n }");//- {n-1}- {n-2}
     //   }
        
        return (n < 2)? n : Fib2(n - 1) + Fib2(n - 2);
    }
    private static void FibonacciNumber(int n )
    {
        int a = 0 ; int b=1; int c=0  ;
        List<int> aa = new List<int>();
        while (a < n)
        {
            //if(a==0) b=1;
           Console.WriteLine($"{a}-- {b}-{c} ");//  if (n < 2){
      //      Console.WriteLine($"Fib2 { n }");//- {n}- {n}
      //  }
      //  else{
     //       Console.WriteLine($"Fib2 else { n }");//- {n-1}- {n-2}
     //   }
        
           aa.Add(a);
            //Console.WriteLine($"assignment {a},{b},{c} "); 
            c= b; b=(a+b); a= c;
         // 0 = 1;1=(0+1); 0 = 0   first case
         // 1 = 1;1=(0+1); 1 = 1
         // 1 = 1;2=(1+1); 1 = 1
         // 2 = 2;3=(1+2); 2 = 2
         // 3 = 3;5=(2+3); 3 = 3
         // 5 = 5;8=(3+5); 5 = 5
        }
        Console.WriteLine($"List  {String.Join(",", aa)} "); 
        
    
    }
    }
}
