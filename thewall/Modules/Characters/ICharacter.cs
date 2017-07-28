using System.Collections.Generic;
using thewall.Modules.Inventory;
using thewall.Modules.Movement;

namespace thewall.Modules.Characters
{
    public interface ICharacter
    {
        double MaxHealth { get; set; }
        double Health { get; set; }
        IList<IItem> Inventory { get; set; }
        Move Position { get; set; }

        double Attack();
        void Defence(double damage);
        void Move();
    }
}
