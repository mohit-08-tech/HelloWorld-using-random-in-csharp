using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         ----Printing Hello world using Random function----\n");
            PrintingHelloWorld ob = new PrintingHelloWorld();
            ob.Print();
        }
    }
    class PrintingHelloWorld
    {
        char[] Helloworldarr = new char[10];
        char[] SavedHwToCompare = new char[10] { 'h', 'e', 'l', 'l', 'o', 'w', 'o', 'r', 'l', 'd' };
        String alphabets = "abcdefghijklmnopqrstuvwxyz";
        char ch = ' ';
        string HelloWorld;
        string compHello = "helloworld";

        Random choose = new Random();
        public void Print()
        {
            int i = 0;
            //int index = choose.Next(26);
            //stor = alp.ElementAt(index);
            //Console.WriteLine("Index {0}\n Char {1}",index,stor);
            do
            {
                int index = choose.Next(26);
                ch = alphabets.ElementAt(index);

                if (ch == SavedHwToCompare[i])
                {
                    Helloworldarr[i] = ch;
                    i++;
                    HelloWorld = new string(Helloworldarr);

                }

                else
                {
                    Helloworldarr[i] = ch;
                    HelloWorld = new string(Helloworldarr);

                }
                if (Helloworldarr[0] != '\0')
                {
                    foreach (char item in Helloworldarr)
                    {
                        Console.Write(item);
                    }
                    Thread.Sleep(1000);
                    Console.WriteLine();
                }

            } while (HelloWorld != compHello);

            Console.WriteLine("\n--------------------------------------CONGRATULATIONS------------------------------------------");
            Console.WriteLine("Your string is ready: {0}", HelloWorld);
        }

    }
}
