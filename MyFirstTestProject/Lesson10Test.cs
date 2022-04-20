using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApplication;

namespace MyFirstTestProject;

/*
 * This is my test class for Lesson 18 and Exercise 18 Unit Tests.
 */
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

    // Excercise 18 Unit Tests
    /*
     * 1.Write a test method inside the Lesson10Test.cs file. Ensure you have the 
     * [TestMethod] above this method. This method will be called IdVerify. We will
     * be utilizing the arrange and assert portions of the AAA pattern. Create a 
     * variable of int called id. Provide a value for this variable. Create an 
     * object of Lesson 10 using the default constructor. Using the object created,
     * assign the id variable to the Id property. Using an Assert, we are going to 
     * check to see if theid property was assigned properly, or if its still using 
     * the default value of 1000. Pick through the Assert methods to determine 
     * which would fit. There are more than 1 possible method to test this, 
     * including the one used in the lecture. Run the test several times to ensure 
     * you get both a passing test and a failure. Ensure you provide a passing 
     * version in your checked in code.You only need to provide 1 Assert + method.
     */
    [TestMethod]
    public void IdVerify()
    {
        int id = 20;
        Lesson10 lesson10Object = new Lesson10();
        lesson10Object.Id = id; // Got failed test when commenting this line out.

        Assert.AreEqual(id, lesson10Object.Id);
    }
}
