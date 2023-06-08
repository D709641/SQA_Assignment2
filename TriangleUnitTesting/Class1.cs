using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleUnitTesting
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void ValidEquilateral_Inpu15and15and15_ReturnsEquilateral()
        {
            // Arrange
            int firstSide = 15;
            int secondSide = 15;
            int thirdSide = 15;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("An EQUILATERAL triangle is formed", result);
        }

    }
}
