using System;

namespace ZTP03
{
    class Program
    {

        public static Invoker invoker = new();
        static void Main(string[] args)
        {
            invoker.Execute("TOWAR NR 3", 123);
            invoker.DisplayWarehouse();
            invoker.Execute("Towar NR 4", 12);
            invoker.Execute("Towar NR 4", 22);
            invoker.DisplayWarehouse();
            invoker.Undo(3);
            invoker.DisplayWarehouse();
            invoker.Redo(2);
            invoker.DisplayWarehouse();
        }
    }
}
