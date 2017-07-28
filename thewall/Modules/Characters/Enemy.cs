using System.Collections.Generic;
using thewall.Modules.Inventory;
using thewall.Modules.Movement;

namespace thewall.Modules.Characters
{
    public class Enemy: Character
    {
        public Enemy(double maxHealth, double currentHealth, IList<IItem> inventory, Move position)
        {
            MaxHealth = maxHealth;
            Health = currentHealth;
            Inventory = inventory;
            Position = position;
        }
    }
}
