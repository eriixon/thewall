using System.Collections.Generic;
using thewall.Modules.Inventory;
using thewall.Modules.Movement;

namespace thewall.Modules.Characters
{
    public interface IEnemyFactory
    {
        Enemy CreateEnemy(double maxHealth, double currentHealth, IList<IItem> inventory, Move position);
    }
}
