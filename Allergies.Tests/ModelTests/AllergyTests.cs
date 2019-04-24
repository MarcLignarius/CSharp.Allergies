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
  }
}
