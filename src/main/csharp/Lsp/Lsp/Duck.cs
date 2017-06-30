using System;

namespace Lsp
{
    public abstract class Duck
    {
        public abstract void Display();

        public virtual void Swim()
        {
            Console.WriteLine("splash splash");
        }

        public virtual void WriteActions()
        {
            Console.Write("NEXT:");
            Display();
            Console.Write("SWIMMING:");
            Swim();
        }
    }
}