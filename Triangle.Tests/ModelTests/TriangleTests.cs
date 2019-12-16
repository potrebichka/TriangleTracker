using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tri;

namespace Tri.Tests
{
  [TestClass]
  public class TriangleTest
  {
    [TestMethod]
    public void TriangleType_GiveTriangleType_NotTriangle()
    {
      Triangle label = new Triangle(5, 1, 1);
      Assert.AreEqual("It's not a Triangle!", label.TriangleType());
    }
    [TestMethod]
    public void TriangleType_GiveTriangleType_Equilateral()
    {
      Triangle label = new Triangle(1, 1, 1);
      Assert.AreEqual("It's an Equilateral Triangle!", label.TriangleType());
    }
    [TestMethod]
    public void TriangleType_GiveTriangleType_Scalene()
    {
      Triangle label = new Triangle(1,2,3);
      Assert.AreEqual("It's a Scalene Triangle!", label.TriangleType());
    }
    [TestMethod]
    public void TriangleType_GiveTriangleType_Isosceles()
    {
      Triangle label = new Triangle(2,2,3);
      Assert.AreEqual("It's an Isosceles Triangle!" , label.TriangleType());
    }
  }
}