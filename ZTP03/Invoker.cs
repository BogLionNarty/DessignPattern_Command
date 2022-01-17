using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP03
{
    class Invoker
    {
        Warehouse warehouse = new();
        List<ICommand> commands = new();
        int current = 0;


        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ---- ", levels);
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count )
                {
                    ICommand command = commands[current++];
                    command.Execute();
                }
            }
        }
        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ----", levels);
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    ICommand command = commands[--current] as ICommand;
                    command.UnExecute();
                }
            }
        }
        public void Execute(string name, int value)
        {
            ICommand command = new WarehouseCommand (warehouse, name, value);
            commands.Add(command);
            current++;
            command.Execute();

        }
        public void DisplayList()
        {
            foreach(ICommand command in commands)
            {
                Console.WriteLine(command);
            }
            
        }
        public void DisplayWarehouse()
        {
            warehouse.DisplayWarehouse();
            Console.WriteLine("&&&&&&&&&&&&&&&&&");
        }

    }
}
