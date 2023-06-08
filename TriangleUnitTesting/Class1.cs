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

        [Test]
        public void ValidScalene_Input3and4and5_ReturnsScaleneTriangle()
        {
            // Arrange
            int side1 = 3;
            int side2 = 4;
            int side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A SCALENE triangle is formed", result);
        }

        [Test]
        public void ValidScalene_Input7and9and12_ReturnsScaleneTriangle()
        {
            // Arrange
            int side1 = 7;
            int side2 = 9;
            int side3 = 12;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A SCALENE triangle is formed", result);
        }

        [Test]
        public void ValidScalene_Input8and15and17_ReturnsScaleneTriangle()
        {
            // Arrange
            int side1 = 8;
            int side2 = 15;
            int side3 = 17;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A SCALENE triangle is formed", result);
        }

        [Test]
        public void ValidScalene_Input5and12and13_ReturnsScaleneTriangle()
        {
            // Arrange
            int side1 = 5;
            int side2 = 12;
            int side3 = 13;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A SCALENE triangle is formed", result);
        }

        [Test]
        public void ValidScalene_Input9and10and11_ReturnsScaleneTriangle()
        {
            // Arrange
            int side1 = 9;
            int side2 = 10;
            int side3 = 11;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.AreEqual("A SCALENE triangle is formed", result);
        }
    }
}
