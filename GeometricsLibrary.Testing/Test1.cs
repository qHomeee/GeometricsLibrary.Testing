using Geometrics;
namespace GeometricsLibrary.Testing
{
    [TestClass]
    public sealed class Test1
    {
        [TestClass]
        public class CircleTests
        {
            [TestMethod]
            public void GetArea_ReturnsCorrectValue()
            {
                var circle = new Circle(10);
                Assert.AreEqual(Math.PI * 100, circle.GetArea());
            }

            [TestMethod]
            public void GetPerimeter_ReturnsCorrectValue()
            {
                var circle = new Circle(5);
                Assert.AreEqual(2 * Math.PI * 5, circle.GetPerimeter());
            }
        }

        [TestClass]
        public class SquareTests
        {
            [TestMethod]
            public void GetArea_ReturnsCorrectValue()
            {
                var square = new Square(4);
                Assert.AreEqual(16, square.GetArea());
            }

            [TestMethod]
            public void GetDiagonal_ReturnsCorrectValue()
            {
                var square = new Square(1);
                Assert.AreEqual(Math.Sqrt(2), square.GetDiagonal());
            }
        }

        [TestClass]
        public class TriangleTests
        {
            [TestMethod]
            public void GetPerimeter_ReturnsCorrectSum()
            {
                var triangle = new Triangle(3, 4, 5);
                Assert.AreEqual(12, triangle.GetPerimeter());
            }

            [TestMethod]
            public void GetArea_ReturnsCorrectValue()
            {
                var triangle = new Triangle(3, 4, 5);
                Assert.AreEqual(6, triangle.GetArea());
            }

            [TestMethod]
            public void GetAngles_ReturnsCorrectAngles()
            {
                var triangle = new Triangle(3, 4, 5);
                var angles = triangle.GetAngles();
                Assert.AreEqual(90, angles.AngleC, 1e-1);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void Constructor_InvalidSides_ThrowsException()
            {
                var invalidTriangle = new Triangle(1, 2, 3);
            }
        }

        [TestClass]
        public class RectangleTests
        {
            [TestMethod]
            public void GetArea_ReturnsCorrectValue()
            {
                var rect = new Rectangle(4, 5);
                Assert.AreEqual(20, rect.GetArea());
            }

            [TestMethod]
            public void GetDiagonal_ReturnsCorrectValue()
            {
                var rect = new Rectangle(3, 4);
                Assert.AreEqual(5, rect.GetDiagonal());
            }
        }

        [TestClass]
        public class TrapezoidTests
        {
            [TestMethod]
            public void GetArea_ReturnsCorrectValue()
            {
                var trap = new Trapezoid(10, 14, 5, 6, 4);
                Assert.AreEqual(48, trap.GetArea());
            }

            [TestMethod]
            public void GetPerimeter_ReturnsCorrectSum()
            {
                var trap = new Trapezoid(10, 14, 5, 6, 4);
                Assert.AreEqual(10 + 14 + 5 + 6, trap.GetPerimeter());
            }
        }
    }
}


