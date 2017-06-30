using System;

namespace Lsp
{
    public abstract class LivingDuck : QuackingDuck
    {
        public virtual void Fly()
        {
            Console.WriteLine("flap flap flap");
        }

        public override void WriteActions()
        {
            base.WriteActions();
            Console.Write("FLYING:");
            Fly();
        }
    }
}
