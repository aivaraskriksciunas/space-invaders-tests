using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceInvaders.GameObjects.Enemies;
using SpaceInvaders.GameObjects.Bullets;

namespace SpaceInvadersTests
{
    [TestClass]
    class EnemyTests
    {
        [TestMethod]
        public void TestEnemyTakesDamage()
        {
            // Arrange
            var enemy = new Enemy( 1 );
            var bullet = new Bullet( 0, 0, 0, BulletTarget.ENEMY );
            var startingHealth = enemy.Health;

            // Act
            enemy.OnBulletHit( bullet );

            // Assert
            Assert.IsTrue( enemy.Health < startingHealth, "Health should be lower" );
           
        }

        [TestMethod]
        public void TestEnemyIgnoresBulletsForPlayer()
        {
            // Arrange
            var enemy = new Enemy( 1 );
            var bullet = new Bullet( 0, 0, 0, BulletTarget.PLAYER );
            var startingHealth = enemy.Health;

            // Act
            enemy.OnBulletHit( bullet );

            // Assert
            Assert.AreEqual( startingHealth, enemy.Health, "Enemy should not have taken damage" );

        }
    }
}
