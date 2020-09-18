using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main()
        {
            int operations = int.Parse(Console.ReadLine());
            string currentString = string.Empty;
            var saved = new Stack<string>();
            saved.Push(currentString);

            for (int i = 1; i <= operations; i++)
            {
                var command = Console.ReadLine().Split();

                if (command[0].Contains("1"))
                {
                    string someString = command[1];
                    currentString += someString;
                    saved.Push(currentString);
                }
                else if (command[0].Contains("2")) 
                {
                    int count = int.Parse(command[1]);
                    currentString = currentString.Substring(0, currentString.Length - count);
                    saved.Push(currentString);
                }
                else if (command[0].Contains("3"))
                {
                    int index = int.Parse(command[1]);
                    var chars = currentString[index - 1];

                    Console.WriteLine(chars);
                }
                else if (command[0].Contains("4"))
                {
                    saved.Pop();
                    currentString = string.Empty;
                    currentString = saved.Peek();
                }
            }
        }
    }
}
