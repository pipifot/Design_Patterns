﻿using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            // Constructor is protected -- cannot use new
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user
            Console.ReadKey();

        }
    }
}
