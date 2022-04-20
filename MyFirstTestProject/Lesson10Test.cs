using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApplication;

namespace MyFirstTestProject;

[TestClass]
public class Lesson10Test
{
    [TestMethod]
    public void FirstName_LastName_ZipCode_Verify()
    {

        // Arrange
        string firstName = "George";
        string lastName = "Washington";
        int zipCode = 64119;
        Lesson10 lesson10 = new Lesson10(firstName, lastName, zipCode);

        // Act - Nothing

        // Assert
        Assert.AreEqual(firstName, lesson10.FirstName);
        Assert.AreEqual(lastName, lesson10.LastName);
        Assert.AreEqual(zipCode, lesson10.ZipCode);
    }
}
