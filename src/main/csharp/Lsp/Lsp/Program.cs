using System;
using System.Collections.Generic;

namespace Lsp
{
    internal class Program
    {
        private static void Main()
        {
            var ducks = new List<Duck> {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck()};

            HaveFunWithAllTheDucks(ducks);

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        private static void HaveFunWithAllTheDucks(IEnumerable<Duck> ducks)
        {
            foreach (var duck in ducks)
            {
                duck.WriteActions();
                Console.WriteLine();
            }
        }
    }
}