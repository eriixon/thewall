using System;
using System.Collections.Generic;
using thewall.Modules.Inventory;
using thewall.Modules.Movement;

namespace thewall.Modules.Characters
{
    public abstract class Character : ICharacter
    {
        public double MaxHealth { get; set; }
        public double Health { get; set; }
        public IList<IItem> Inventory { get; set; }
        public Move Position { get; set; }

        public double Attack()
        {
            throw new NotImplementedException();
        }

        public void Defence(double damage)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
