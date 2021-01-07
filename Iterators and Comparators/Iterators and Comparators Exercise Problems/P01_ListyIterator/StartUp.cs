using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_ListyIterator
{
    public class StartUp
    {
        static void Main()
        {
            var listyIterator = new ListyIterator<string>(new List<string>());
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    var currComm = command
                        .Split()
                        .ToArray();

                    switch (currComm[0])
                    {
                        case "Create":
                            var elements = currComm.Skip(1).ToList();
                            listyIterator = new ListyIterator<string>(elements);
                            break;

                        case "Print":
                            listyIterator.Print();
                            break;

                        case "Move":
                            Console.WriteLine(listyIterator.Move());
                            break;

                        case "HasNext":
                            Console.WriteLine(listyIterator.HasNext());
                            break;
                    }
                }
                catch (Exception m)
                {
                    Console.WriteLine(m.Message);
                }
            }
        }
    }
}
