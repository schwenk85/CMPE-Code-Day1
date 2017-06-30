using System;

namespace Lsp
{
    public abstract class QuackingDuck : Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("quaak");
        }

        public override void WriteActions()
        {
            base.WriteActions();
            Console.Write("QUACKING:");
            Quack();
        }
    }
}
