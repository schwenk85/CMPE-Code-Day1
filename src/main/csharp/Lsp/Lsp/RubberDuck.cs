using System;

namespace Lsp
{
    public class RubberDuck : QuackingDuck
    {
        public override void Display()
        {
            Console.WriteLine("This is a rubber duck.");
        }

        public override void Quack()
        {
            Console.WriteLine("squeek");
        }
    }
}