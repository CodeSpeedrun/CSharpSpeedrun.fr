/* What are design patterns?
Design patterns are conceptual solutions to common software problems. They advocate the reusability and maintainability of applications. The most popular design patterns come from the book by GOF.
*/

/* What is Singleton Design Pattern?
SDP is one of the most popular and simple design pattern. It makes sure there is only one global instance for the class.
*/
using System;
using System.Collections.Generic;

namespace CSharpSpeedrun.com
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton(); 

        //Private constructor prevent creation of instances 
        private Singleton() { }
        public static Singleton Instance
        {
            get
            { 
                return instance;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Singleton s1 = Singleton.Instance; 
        }
    }
}//vs
  
using System;
using System.IO;

namespace CSharpSpeedrun.com
{ 
    public class SingletonDemo
    {
        private static SingletonDemo instance = new SingletonDemo(); 

        public static SingletonDemo GetInstance
        {
            get
            {
                return instance;
            }
        }
    } 
}
/*
  
*/