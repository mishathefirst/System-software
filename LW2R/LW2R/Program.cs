using System;

using System.Runtime.InteropServices;

namespace LW2R
{
    class Program
    {

        //[DllImport("libextlabutils.so")]
        //, EntryPoint="get_partitions")]
        //static extern void print(string message);
        [DllImport("libextlabutils.so")]
        static extern void get_partitions();
        [DllImport("libextlabutils.so")]
        static extern void entrance(char[] path);
        //[DllImport("libextlabutilsextra.so")]
        //static extern char[] entrance(char[] path, char[] command);

        static void Main(string[] args)
        {
            if (args[0].Equals("1"))
            {
                get_partitions();
            } else if (args[0].Equals("2"))
            {
                Console.WriteLine("Enter a command:");
                string command = "new";
                string path = args[1];
                string output = "";
                command = Console.ReadLine();
                
                //while (!command.Equals("quit"))
                //{
                    //command = Console.ReadLine();
                    //output = entrance(path.ToCharArray(), command.ToCharArray()).ToString();
                    //Console.WriteLine(output);
                    //switch (command)
                    //{
                      //  case "ls": execute_ext_ls();
                    //}
                //}

                //Console.WriteLine(command);
                entrance(args[1].ToCharArray()); 
            }
            else
            {
                Console.WriteLine("Wrong command!");
            }
            
            
            

            //entrance();
            
            //Console.WriteLine("Hello World!");
        }
    }
}












/*
using System;

namespace LW2R
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
*/