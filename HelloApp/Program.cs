﻿namespace HelloApp
{
    class Hello {         
        static void Main(string[] args)
        {
            System.Console.WriteLine("hello everyone");
            GreetWHite();
            GreetBlack();
        }

        static void GreetWHite()
        {
            System.Console.WriteLine("hello white");
        }

        static void GreetBlack()
        {
            System.Console.WriteLine("hello black");
        }
    }
}