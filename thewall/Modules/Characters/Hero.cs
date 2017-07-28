using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thewall.Modules.Inventory;
using thewall.Modules.Movement;

namespace thewall.Modules.Characters
{
    public class Hero: Character
    {
        private static Hero instance;
        public string  Name { get; private set; }

        private Hero(double maxHealth, double currentHealth, IList<IItem> inventory, Move position)
        {
            MaxHealth = maxHealth;
            Health = currentHealth;
            Inventory = inventory;
            Position = position;
        }
        public static Hero Instance(double maxHealth, double currentHealth, IList<IItem> inventory, Move position)
        {
            if (instance == null) instance = new Hero(maxHealth, currentHealth, inventory, position);
            return instance;
        }
        public void SetHeroName(string name)
        {
            Name = name;
        }
    }
}
