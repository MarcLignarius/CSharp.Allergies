using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies.Models;

namespace Allergies.Tests
{
  [TestClass]
  public class Allergy
  {

    [TestMethod]
    public void GetAllergyScores_IsAllergicToCats_True()
    {
      //Arrange
      AllergyScores score = new AllergyScores(128);
      //Act

      //Arrange
      Assert.AreEqual(true, score.GetCats());
    }

    [TestMethod]
    public void GetAllergyScores_IsAllergicToPollen_True()
    {
      //Arrange
      AllergyScores score = new AllergyScores(64);
      //Act

      //Arrange
      Assert.AreEqual(true, score.GetPollen());
    }

    [TestMethod]
    public void GetAllergyScores_IsAllergicToPChocolate_True()
    {
      //Arrange
      AllergyScores score = new AllergyScores(32);
      //Act

      //Arrange
      Assert.AreEqual(true, score.GetChocolate());
    }

    [TestMethod]
    public void GetAllergyScores_IsAllergicToTomatoes_True()
    {
      //Arrange
      AllergyScores score = new AllergyScores(16);
      //Act

      //Arrange
      Assert.AreEqual(true, score.GetTomatoes());
    }

  }
}


// [TestMethod]
// public void GetAllergyScores_IsAllergicToStrawberries_True()
// {
//   //Arrange
//   AllergyScores score = new AllergyScores(8);
//   //Act
//
//   //Arrange
//   Assert.AreEqual(true, score.GetStrawberries());
// }
//
// [TestMethod]
// public void GetAllergyScores_IsAllergicToShellfish_True()
// {
//   //Arrange
//   AllergyScores score = new AllergyScores(4);
//   //Act
//
//   //Arrange
//   Assert.AreEqual(true, score.GetShellfish());
// }
//
// [TestMethod]
// public void GetAllergyScores_IsAllergicToPeanuts_True()
// {
//   //Arrange
//   AllergyScores score = new AllergyScores(2);
//   //Act
//
//   //Arrange
//   Assert.AreEqual(true, score.GetPeanuts());
// }
//
// [TestMethod]
// public void GetAllergyScores_IsAllergicToEggs_True()
// {
//   //Arrange
//   AllergyScores score = new AllergyScores(1);
//   //Act
//
//   //Arrange
//   Assert.AreEqual(true, score.GetEggs());
// }
