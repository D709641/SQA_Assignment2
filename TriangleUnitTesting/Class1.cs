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
        
        [Test]
        public void ValidIsosceles_Input15and15and18_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 15;
            int secondSide = 15;
            int thirdSide = 18;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("An ISOSCELES triangle is formed", result);
        }

        [Test]
        public void ValidIsosceles_Input5and7and7_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 5;
            int secondSide = 7;
            int thirdSide = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("An ISOSCELES triangle is formed", result);
        }

        [Test]
        public void ValidIsosceles_Input6and9and9_ReturnsIsosceles()
        {
            // Arrange
            int firstSide = 6;
            int secondSide = 9;
            int thirdSide = 9;

            // Act
            string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual("An ISOSCELES triangle is formed", result);
        }
    }
}
