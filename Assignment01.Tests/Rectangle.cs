using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Assignment01.Tests
{
    [TestFixture]
    public class Rectangle
    {
        [Test]
        public void Length_Given2_Output2()
        {
            Assignment01.Rectangle r = new Assignment01.Rectangle();
            Assert.AreEqual(2, r.SetLength(2), 0);
        }

        [Test]
        public void Length_Get_Given1_Output1()
        {
            Assignment01.Rectangle r = new Assignment01.Rectangle();
            Assert.AreEqual(1, r.GetLength(), 0);
        }

        [Test]
        public void Width_Given2_Output2()
        {
            Assignment01.Rectangle r = new Assignment01.Rectangle();
            Assert.AreEqual(2, r.SetWidth(2), 0);
        }
        [Test]
        public void Width_Get_Given1_Output1() 
        {
            Assignment01.Rectangle r = new Assignment01.Rectangle();
            Assert.AreEqual(1, r.GetWidth(), 0);
        }
        [Test]
        public void Perimeter_Given33_Output12()
        {
            Assignment01.Rectangle r = new Assignment01.Rectangle(3,3);
            Assert.AreEqual(12, r.GetPerimeter(), 0);
        }
        [Test]
        public void Area_Given33_Output()
        {
            Assignment01.Rectangle r = new Assignment01.Rectangle(3,3);
            Assert.AreEqual(9, r.GetArea(), 0);
        }
    }
}
