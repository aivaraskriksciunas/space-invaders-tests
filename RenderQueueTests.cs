using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceInvaders.Scenes;
using SpaceInvaders.Graphics;
using SFML.Graphics;
using NSubstitute;

namespace SpaceInvadersTests
{
    [TestClass]
    public class RenderQueueTests
    {
        [TestMethod]
        public void TestAddsItemToQueue()
        {
            // Arrange
            var queue = new RenderQueue();
            var mockItem = Substitute.For<IRenderable>();

            // Act
            queue.AddToQueue( mockItem );

            // Assert 
            Assert.AreEqual( 1, queue.queue.Count, "Should add item to queue" );
        }

        [TestMethod]
        public void TestClearsQueue()
        {
            // Arrange
            var queue = new RenderQueue();
            var mockItem = Substitute.For<IRenderable>();

            // Act
            queue.AddToQueue( mockItem );
            queue.AddToQueue( mockItem );
            Assert.AreEqual( 2, queue.queue.Count, "Should add 2 items to queue" );

            queue.ClearQueue();

            // Assert
            Assert.AreEqual( 0, queue.queue.Count, "Should clear queue" );
        }

    }
}
