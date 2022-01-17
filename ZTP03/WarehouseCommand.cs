using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTP03
{
    class WarehouseCommand : ICommand
    {
        private Warehouse _warehouse;
        private string _name;
        private int _value;

        public WarehouseCommand(Warehouse warehouse, string name, int value)
        {
            this._warehouse = warehouse;
            this._name = name;
            this._value = value;

        }
        public void Execute()
        {
            this._warehouse.AddStuff(this._name, this._value);
        }

        public void UnExecute()
        {
            this._warehouse.RemoveStuff(this._name, this._value);
        }
    }
}
