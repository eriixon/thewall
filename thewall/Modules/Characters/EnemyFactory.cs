using System.Collections.Generic;
using thewall.Modules.Inventory;
using thewall.Modules.Movement;

namespace thewall.Modules.Characters
{
    public class EnemyFactory : IEnemyFactory
    {
        public Enemy CreateEnemy(double maxHealth, double currentHealth, IList<IItem> inventory, Move position)
        {
            return new Enemy(maxHealth, currentHealth, inventory, position);
        }
    }
}
