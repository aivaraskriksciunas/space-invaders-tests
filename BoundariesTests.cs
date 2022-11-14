using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpaceInvaders.Utils;

namespace SpaceInvadersTests
{
    [TestClass]
    class BoundariesTests
    {
        [TestMethod]
        public void TestPointCollision()
        {
            // Arrange
            var boundary = new Boundaries( 100, 100, 200, 200 );

            // Assert
            Assert.IsTrue( boundary.IsInside( 150, 150 ), "Should detect collision" );
            Assert.IsFalse( boundary.IsInside( 250, 250 ), "Should not detect collision" );
            Assert.IsFalse( boundary.IsInside( 250, 150 ), "Should not detect collision" );
            Assert.IsFalse( boundary.IsInside( 150, 250 ), "Should not detect collision" );
        }

        [TestMethod]
        public void TestBoundaryCollision()
        {
            // Arrange
            var boundary = new Boundaries( 100, 100, 200, 200 );
            var bigBound = new Boundaries( 90, 90, 210, 210 );
            var smallBound = new Boundaries( 150, 150, 160, 160 );
            var outsideBound = new Boundaries( 300, 300, 350, 350 );
            var oneCornerBound = new Boundaries( 180, 90, 300, 110 );

            // Assert
            Assert.IsTrue( boundary.Overlaps( bigBound ), "Should detect collision with a bigger boundary" );
            Assert.IsTrue( boundary.Overlaps( smallBound ), "Should detect collision with a smaller boundary which is inside" );
            Assert.IsFalse( boundary.Overlaps( outsideBound ), "Should not detect collision with non overlapping bounds" );
            Assert.IsTrue( boundary.Overlaps( oneCornerBound ), "Should detect collision even when bounds have one overlapping corner" );
        }
    }
}
