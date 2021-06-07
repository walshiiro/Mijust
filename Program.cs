using System;

namespace Mijustbotx
{
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new Bot();
               bot.runasync().GetAwaiter().GetResult();
        }
    }
}