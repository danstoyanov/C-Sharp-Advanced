using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main()
        {
            var item = new EqualityScale<int>(3, 2);
            Console.WriteLine(item.AreEqual());

            var seon = new EqualityScale<string>("D", "");
            Console.WriteLine(seon.AreEqual());

            var charecter = new EqualityScale<char>('D', 'A');
            Console.WriteLine(charecter.AreEqual());
        }
    }
}
