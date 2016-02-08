using System;

namespace FodyCcCExample
{
    using AssemblyToEmbed;

    using static Console;

    class Program
    {
        static void Main(string[] args)
        {
            Foo.Bar();

            WriteLine("K THX BYE!");
            ReadKey();
        }
    }
}
