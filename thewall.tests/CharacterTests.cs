using thewall.Modules.Characters;
using System.Collections.Generic;
using thewall.Modules.Inventory;
using thewall.Modules.Movement;
using NUnit.Framework;

namespace thewall.tests
{
    [TestFixture]
    public class CharacterTests
    {

        [Test]
        public void DoesHeroExist()
        {
            var hero = Hero.Instance(100, 100, new List<IItem>(), new Move());
            Assert.That(hero.MaxHealth, Is.EqualTo(100));
        }

        [Test]
        public void DoesEnemiesExist()
        {
            List<Enemy> enemies = new List<Enemy>();
            var factory = new EnemyFactory();
            for (int i = 0; i < 10; i++)
            {
                var e = factory.CreateEnemy(100, 100, new List<IItem>(), new Move());
                enemies.Add(e);
            }

            Assert.That(enemies.Count, Is.EqualTo(10));
        }
    }
}
